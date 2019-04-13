// original author: unknown

using System;
using System.Collections;
using DOL.Database;
using DOL.GS.PacketHandler;

namespace DOL.GS
{
    public class ExtensionNPC : GameNPC
    {
        private const string ITEM_WEAK = "extension_npc.item";
        private const int COST = 10;

        /// <summary>
        /// Adds messages to ArrayList which are sent when object is targeted
        /// </summary>
        /// <param name="player">GamePlayer that is examining this object</param>
        /// <returns>list with string messages</returns>
        public override IList GetExamineMessages(GamePlayer player)
        {
            /*
             * You examine Elvar Ironhand. He is friendly and is a smith.
             * [Give him an object to be repaired]
             */
            IList list = new ArrayList();
            list.Add("You target [" + GetName(0, false) + "]");
            list.Add("You examine " + GetName(0, false) + "  " + GetPronoun(0, true) + " is " + GetAggroLevelString(player, false) + " and is an advanced smith.");
            list.Add("[Give him an object to be upgraded]");
            return list;
        }

        public override bool Interact(GamePlayer player)
        {
            if (!base.Interact(player))
                return false;

            SayTo(player, "Hello " + player.Name + ", just hand me an vest, glove or boot to have an extension added to it for Bounty Points.");

            return true;
        }

        public override bool ReceiveItem(GameLiving source, InventoryItem item)
        {
            if (source == null || item == null)
                return false;

            GamePlayer player = source as GamePlayer;
            if (player == null)
                return false;

            switch ((eInventorySlot)item.Item_Type)
            {
                case eInventorySlot.TorsoArmor:
                case eInventorySlot.HandsArmor:
                case eInventorySlot.FeetArmor: break;
                default:
                    {
                        SayTo(player, "I can only add an extension onto a vest, glove or boot!");
                        return false;
                    }
            }

            if (item.Extension == 5)
            {
                SayTo(player, "Your item already has been upgraded!");
                return false;
            }

            player.TempProperties.setProperty(ITEM_WEAK, new WeakRef(item));
            player.Out.SendMessage("It will cost " + COST + " Bounty Points to upgrade the " + item.Name, eChatType.CT_System, eChatLoc.CL_SystemWindow);
            player.Client.Out.SendCustomDialog("Do you accept to upgrade the " + item.Name, new CustomDialogResponse(DialogResponse));

            return true;
        }

        protected void DialogResponse(GamePlayer player, byte response)
        {
         //   WeakReference itemWeak = (WeakReference)player.TempProperties.getObjectProperty(ITEM_WEAK, new WeakRef(null));
            WeakReference itemWeak = player.TempProperties.getProperty<WeakReference>(ITEM_WEAK);
            player.TempProperties.removeProperty(ITEM_WEAK);

            if (response != 0x01)
                return;

            InventoryItem item = (InventoryItem)itemWeak.Target;

            if (item == null || item.SlotPosition == (int)eInventorySlot.Ground
               || item.OwnerID == null || item.OwnerID != player.InternalID)
            {
                player.Out.SendMessage("Invalid item.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                return;
            }

            if (!player.RemoveBountyPoints(COST))
            {
                player.Out.SendMessage("You don't have enough bounty points, you need " + COST + ".", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                return;
            }

            player.Out.SendMessage("You pay " + GetName(0, false) + " " + COST + " bounty points.", eChatType.CT_System, eChatLoc.CL_SystemWindow);

            item.Extension = 5;
            GameServer.Database.SaveObject(item);

            SayTo(player, "It's done. Your " + item.Name + " has been upgraded!");
            return;
        }
    }
}