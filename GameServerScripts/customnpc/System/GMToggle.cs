
using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using DOL;
using System.Threading;
using DOL.GS;
using DOL.Events;
using DOL.Database;
using DOL.Database.Attributes;
using DOL.GS.PacketHandler;
using DOL.GS.Effects;
using DOL.GS.Spells;
using log4net;

namespace DOL.GS.Commands
{
    [CmdAttribute("&gmtoggle",
        ePrivLevel.Player,
        "Toggles whether others can see you as a admin or not.",
        "/gmtoggle")]
    public class GMToggleCommandHandler : ICommandHandler
    {
        public void OnCommand(GameClient client, string[] args)
        {
            if (client.Player.Client.Account.Name == "ADMINACCOUNT1" | client.Player.Client.Account.Name == "ADMINACCOUNT2")//make sure all account names are lowercase
                //to keep adding in accounts just paste | client.Player.Client.Account.Name == ""  after each added account.
            {
                //client.Player.Client.Out.SendMessage("Account Verified.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                if (client.Player.Client.Account.PrivLevel == 3)
                {
                    //client.Out.SendMessage("Priv Level Found.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    client.Player.Client.Account.PrivLevel = 1;
                    //client.Player.Client.Out.SendMessage("Priv level set to level 1.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    client.Player.SaveIntoDatabase();
                    //client.Player.Client.Out.SendMessage("Player saved.", eChatType.CT_System, eChatLoc.CL_SystemWindow);

                }
                else
                {
                    //client.Player.Client.Out.SendMessage("Priv level is below 3.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    client.Player.Client.Account.PrivLevel = 3;
                    //client.Player.Client.Out.SendMessage("Priv level set to 3.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    client.Player.Client.Player.SaveIntoDatabase();
                    //client.Player.Client.Out.SendMessage("Player saved.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                }
            }
            else
            {
                string wannabegm = client.Player.Name;
                client.Player.Client.Out.SendMessage("Sorry " + wannabegm + ", You can't use that command.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
            }
        }
    }
}