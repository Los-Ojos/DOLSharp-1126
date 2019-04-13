using System;
using System.Collections.Generic;
using System.Text;
using DOL.GS;
using DOL.AI;
using DOL.AI.Brain;
using DOL.Events;
using DOL.Database;
using DOL.GS.PacketHandler;

namespace DOL.GS.Scripts
{
    public class BPRefunder : GameNPC
    {
        public override bool Interact(GamePlayer player)
        {
            if (base.Interact(player))
            {
                SendReply(player, "Hand me an item and I will refund the cost!");
                return true;
            }
            return false;
        }
        public override bool ReceiveItem(GameLiving source, InventoryItem item)
        {
            GamePlayer player = source as GamePlayer;
            if (player == null)
            {
                return false;
            }

            Refund(item, player);

            return false;
        }
        public void Refund(InventoryItem item, GamePlayer player)
        {
            bool can = false;
            if (item.PackageID.ToLower().Contains("art"))
            {
                can = true;
            }
            if (item.Name.Contains("Special"))
            {
                can = true;
            }
            if (item.Name.Contains("Dragon"))
            {
                can = true;
            }
            if (item.Name.Contains("Pyroc"))
            {
                can = true;
            }
            if (item.Name.Contains("Lith"))
            {
                can = true;
            }
            if (item.Name.Contains("Benth"))
            {
                can = true;
            }
            if (item.Name.Contains("Tempest"))
            {
                can = true;
            }
			if (item.Name.Contains("Dragonslayer"))
            {
                can = true;
            }
            switch (item.PackageID)
            {
                case "LabWeaps":
                case "Artifacts":
                case "Bounty Jewlery":
                case "DragonWeapons":
                    can = true;
                    break;
            }
            if (can == true)
            {
                player.Inventory.RemoveItem(item);
                player.GainBountyPoints(item.Price, false);
            }
            

        }
        public void SendReply(GamePlayer player, string msg)
        {
            player.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }
    }
}
