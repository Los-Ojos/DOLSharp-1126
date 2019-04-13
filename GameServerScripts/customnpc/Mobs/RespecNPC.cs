using System;
using System.Collections;
using DOL.Database;
using DOL.GS.PacketHandler;
using DOL.GS;

namespace DOL.GS.Scripts
{
    public class RespecNPC : GameNPC
    {
        public override bool Interact(GamePlayer player)
        {
            if (!base.Interact(player))
                return false;

            TurnTo(player.X, player.Y);
            SayTo(player, eChatLoc.CL_ChatWindow, "Hand me a Luminescent Exerpise Stone, Luminescent Abrogo Stone, or Luminescent Ceriac Stone for a respec credit!");
            return true;
        }

        #region ReceiveItem
        public override bool ReceiveItem(GameLiving source, InventoryItem item)
        {
            GamePlayer t = source as GamePlayer;
            if (t == null || item == null)
                return false;

            switch (item.Id_nb)
            {
                case "respec_full":
                    {
                        //first check if the player has too many
                        if (t.RespecAmountAllSkill >= 5)
                        {
                            t.Out.SendMessage("You already have " + t.RespecAmountAllSkill + " Full skill respecs, to use them simply talk to your trainer and type /respec ALL", eChatType.CT_System, eChatLoc.CL_PopupWindow);
                            return true;
                        }
                        t.Out.SendMessage("You now have " + t.RespecAmountAllSkill + " Full skill respecs, to use them simply talk to your trainer and type /respec ALL", eChatType.CT_ScreenCenter, eChatLoc.CL_SystemWindow);
                        t.RespecAmountAllSkill++;
                        t.Inventory.RemoveItem(item);
                        break;
                    }
                case "respec_realm":
                    {
                        //first check if the player has too many
                        if (t.RespecAmountRealmSkill >= 5)
                        {
                            t.Out.SendMessage("You already have " + t.RespecAmountRealmSkill + " Realm skill respecs, to use them simply target your trainer and type /respec Realm", eChatType.CT_System, eChatLoc.CL_PopupWindow);
                            return true;
                        }
                        t.Out.SendMessage("You now have " + t.RespecAmountRealmSkill + " Realm skill respecs, to use them simply talk to your trainer and type /respec Realm", eChatType.CT_ScreenCenter, eChatLoc.CL_SystemWindow);                        
                        t.RespecAmountRealmSkill++;
                        t.Inventory.RemoveItem(item);
                        break;
                    }
                case "respec_single":
                    {
                        //first check if the player has too many
                        if (t.RespecAmountSingleSkill >= 5)
                        {
                            t.Out.SendMessage("You already have " + t.RespecAmountAllSkill + " Single skill Respecs, to use this simply target your trainer and type /respec <line>", eChatType.CT_System, eChatLoc.CL_PopupWindow);
                            return true;
                        }
                        t.Out.SendMessage("You now have " + t.RespecAmountAllSkill + " Single skill Respecs, to use them simply talk to your trainer and type /respec <line>", eChatType.CT_ScreenCenter, eChatLoc.CL_SystemWindow);
                        t.RespecAmountSingleSkill++;
                        t.Inventory.RemoveItem(item);
                        break;
                    }
            }            
            return true;
        }
        #endregion
    }
}
