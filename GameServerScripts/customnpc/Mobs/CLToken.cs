using System;
using DOL;
using DOL.GS;
using DOL.Events;
using DOL.Database;
using System.Collections;
using DOL.GS.PacketHandler;

namespace DOL.GS.Scripts
{
    public class CLTokenNPC : GameNPC
    {
        public override bool Interact(GamePlayer player)
        {
            if (base.Interact(player))
            {
                TurnTo(player, 250);
                SendReply(player, "Hail Traveler!\n\n" +
                                    "I offer you a portion Champion Experience in exchange for your Champion Level tokens.\n" +
                                    "Here are my rates for the following tokens:" +
                                    "\nCL1 Token = 1 Champion Level" +
                                    "\nCL2 Token = 2 Champion Levels" +
                                    "\nCL5 Token = 5 Champion Levels" +
                                    "\nCL10 Token = If you hand me one of these tokens, I will give you enough experience to be Champion Level 10" +
                                    "\nPlease remember to talk to the King first before using my services!");
                return true;
            }
            return false;
        }

        public override bool ReceiveItem(GameLiving source, InventoryItem item)
        {
            GamePlayer player = source as GamePlayer;
            if (player == null || item == null) return false;
           if (GetDistanceTo(player) > WorldMgr.INTERACT_DISTANCE)
            {
                player.Out.SendMessage("You are too far away to give anything to " + GetName(0, false) + ".", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                return false;
            }
            if (!player.Champion)
            {
                player.Out.SendMessage("You must start your champion path before skipping levels!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                return false;
            }
            if (player.ChampionLevel == player.ChampionMaxLevel)
            {
                player.Out.SendMessage("You have already learned all the knowledge of being a champion!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                return false;
            }
            double cl1 = 32000 / ServerProperties.Properties.XP_RATE;
            double cl5 = 160000 / ServerProperties.Properties.XP_RATE;
            double cl10 = 320000 / ServerProperties.Properties.XP_RATE;
            if (item.Id_nb.Contains("CL1"))
            {
                player.Out.SendMessage("Thanks! Here's your reward...", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                player.GainChampionExperience((int)cl1);
                player.Inventory.RemoveItem(item);
                return true;
            }
            if (item.Id_nb.Contains("CL5"))
            {
                player.Out.SendMessage("Thanks! Here's your reward...", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                player.GainChampionExperience((int)cl5);
                player.Inventory.RemoveItem(item);
                return true;
            }
            if (item.Id_nb.Contains("CL10"))
            {
                player.Out.SendMessage("Thanks! Here's your reward...", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                player.GainChampionExperience((int)cl10);
                player.Inventory.RemoveItem(item);
                return true;
            }
            return false;
        }

        public void SendReply(GamePlayer player, string msg)
        {
            player.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }
    }
}


