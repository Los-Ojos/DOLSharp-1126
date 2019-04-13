/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using DOL.AI;
using DOL.AI.Brain;
using DOL.Events;
using DOL.Database;
using DOL.GS.PacketHandler;

using log4net;
namespace DOL.GS.Scripts
{
    public class RedemptionRealmChanger : GameNPC
    {
        public RedemptionRealmChanger()
        {
        }
        public override bool Interact(GamePlayer player)
        {
            if (base.Interact(player))
            {
                string str = "Hello {0}, do you want to toggle / un toggle [PvP] ?";
                SayTo(player, string.Format(str, player.Name));
                return true;
            }
            return false;
        }
        public override bool WhisperReceive(GameLiving source, string text)
        {
            if (base.WhisperReceive(source, text))
            {
                GamePlayer player = source as GamePlayer;
                if (player == null)
                    return false;

                if (text == "PvP")
                {
                    if (player.Realm == eRealm.None)
                        return false;

                    if (player.IsPvPer == true)
                    {
                        player.IsPvPer = false;
                    }
                    else if (player.IsPvPer == false)
                    {
                        player.IsPvPer = true;
                    }
                    player.SaveIntoDatabase();
                    SendReply(player, "Your PvP flag is now set to " + player.IsPvPer.ToString());
                }
            }
            return false;
        }

        public override bool ShowQuestIndicator(GamePlayer player)
        {
            return true;
        }
        public void SendReply(GamePlayer player, string msg)
        {
            player.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }
    }


}
*/