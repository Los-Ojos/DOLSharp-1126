/* Author : Unknown
 */
using System;
using System.Collections;
using System.Timers;
using DOL;
using DOL.AI.Brain;
using DOL.GS;
using DOL.GS.Scripts;
using DOL.GS.GameEvents;
using DOL.GS.PacketHandler;
using DOL.GS.Quests;
using DOL.GS.Spells;
using DOL.GS.Effects;
using DOL.Database;
using DOL.Events;


namespace DOL.GS
{

    public class BPRPNPC : GameNPC
    {


        public override bool AddToWorld()
        {
            Flags |= GameNPC.eFlags.PEACE;
            return base.AddToWorld();
        }

        public override bool ReceiveItem(GameLiving source, InventoryItem item)
        {
            GamePlayer t = source as GamePlayer;
            if (GetDistanceTo(t) > WorldMgr.INTERACT_DISTANCE)
            {
                ((GamePlayer)source).Out.SendMessage("You are too far away to give anything to " + GetName(0, false) + ".", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                return false;
            }

            if (t != null && item != null)
            {


                if ((item.Id_nb == "bptoken500"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainBountyPoints(500, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "bptoken1000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainBountyPoints(1000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "bptoken5000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainBountyPoints(5000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "bptoken10000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainBountyPoints(10000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "bptoken50000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainBountyPoints(50000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "bptoken100000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainBountyPoints(100000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "bptoken500000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainBountyPoints(500000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "bptoken1000000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainBountyPoints(1000000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "bptoken2000000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainBountyPoints(2000000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "bptoken5000000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainBountyPoints(5000000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "rptoken500"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainRealmPoints(500, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "rptoken1000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainRealmPoints(1000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "rptoken5000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainRealmPoints(5000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "rptoken10000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainRealmPoints(10000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "rptoken50000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainRealmPoints(50000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "rptoken100000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainRealmPoints(100000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "rptoken500000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainRealmPoints(500000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "rptoken1000000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainRealmPoints(1000000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "rptoken2000000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainRealmPoints(2000000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }
                if ((item.Id_nb == "rptoken5000000"))
                {
                    t.Out.SendMessage("Excellent, you've found a token!\n" +
                    "Here, please take your reward!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                    t.GainRealmPoints(5000000, false);
                    t.Inventory.RemoveItem(item); t.RefreshSpecDependantSkills(true); t.Out.SendUpdatePlayerSkills(); t.Out.SendUpdatePlayer(); t.UpdatePlayerStatus();
                    t.SaveIntoDatabase();

                }







            }
            return base.ReceiveItem(source, item);
        }

        public override bool Interact(GamePlayer player)
        {
            if (!base.Interact(player))
                return false;

            SayTo(player, "Hello " + player.Name + ", give me a token and I shall reward you!");

            return true;
        }

        private void SendReply(GamePlayer target, string msg)
        {
            target.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }
    }
}


