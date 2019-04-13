/*
Author : Dams33
Date : May 2007
Description : Mob that allow to change item model by whisper
 * 
 * Fixed by geshi 27/07/2010
*/

using DOL;
using DOL.GS;
using DOL.Events;
using DOL.Database;
using System;
using DOL.GS.PacketHandler;

namespace DOL.GS.Scripts
{
    public class ProcRemover : GameNPC
    {
        public string TempProperty = "ProcRemover";
        public override bool AddToWorld()
        {
            base.AddToWorld();
            return true;
        }

        public override bool Interact(GamePlayer player)
        {
            if (base.Interact(player))
            {
                TurnTo(player, 500);
                InventoryItem item = player.TempProperties.getProperty<InventoryItem>(TempProperty);
                if (item == null)
                {
                    SendReply(player, "Hello there! " +
                    "I can remove a proc from your weapons!");
                }
                else
                {
                    ReceiveItem(player, item);
                }
                return true;
            }
            return false;
        }

        public override bool WhisperReceive(GameLiving source, string str)
        {
            if (!base.WhisperReceive(source, str)) return false;
            if (!(source is GamePlayer)) return false;
            GamePlayer player = (GamePlayer)source;
            TurnTo(player.X, player.Y);

            InventoryItem item = player.TempProperties.getProperty<InventoryItem>(TempProperty);

            if (item == null)
            {
                SendReply(player, "I need an item to work on!");
                return false;
            }
            int defaultProcNumber = 1;
            int tmpProcNumber = int.Parse(str);
            RemoveProc(player, tmpProcNumber);
            SendReply(player, "I have removed your item's proc, you can now use it.");
            return true;
        }

        public override bool ReceiveItem(GameLiving source, InventoryItem item)
        {
            GamePlayer player = source as GamePlayer;
            if (player == null || item == null) return false;
            bool output = false;
            #region messages
            if (GetDistanceTo(player) > WorldMgr.INTERACT_DISTANCE)
            {
                player.Out.SendMessage("You are too far away to give anything to " + GetName(0, false) + ".", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                return false;
            }
            if ((player.TempProperties.getProperty<InventoryItem>(TempProperty)) != null)
            {
                item = player.TempProperties.getProperty<InventoryItem>(TempProperty);
                SendReply(player, "You already gave me an item! What was it again?");
                output = true;
            }
            SendReply(player, "Ok, which proc do you want to remove? \n Proc [1] or Proc [2] ?");
            player.TempProperties.setProperty(TempProperty, item);
            return true;
            #endregion messages
        }

        public void SendReply(GamePlayer player, string msg)
        {
            player.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }

        public void RemoveProc(GamePlayer player, int procNumber)
        {
            InventoryItem item = player.TempProperties.getProperty<InventoryItem>(TempProperty);
            player.TempProperties.removeProperty(TempProperty);

            if (item == null || item.OwnerID != player.InternalID || item.OwnerID == null)
                return;

            player.Inventory.RemoveItem(item);

            ItemUnique unique = new ItemUnique(item.Template);
            if (procNumber == 1)
            {
                unique.ProcSpellID = 0;
                unique.SpellID = 0;
            }
            else if (procNumber == 2)
            {
                unique.ProcSpellID1 = 0;
                unique.SpellID1 = 0;
            }
            else
            {
                SendReply(player, "Error, contact a GM");
            }
            GameServer.Database.AddObject(unique);

            InventoryItem newInventoryItem = GameInventoryItem.Create<ItemUnique>(unique);
            player.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, newInventoryItem);
            player.Out.SendInventoryItemsUpdate(new InventoryItem[] { newInventoryItem });
            player.SaveIntoDatabase();
        }
    }
}