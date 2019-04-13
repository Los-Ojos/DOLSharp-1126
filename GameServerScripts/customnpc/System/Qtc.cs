using System.Collections;
using System;
using DOL.Database;
using DOL.Events;
using DOL.Language;
using DOL.GS;
using DOL.GS.PacketHandler;

namespace DOL.GS.Commands
{
    [CmdAttribute("&qtc",

        ePrivLevel.Player,
        "Quits player instantly to character selection screen.",
        "/qtc")]
    public class QtcCommandHandler : ICommandHandler
    {
        public void OnCommand(GameClient client, string[] args)
        {
            if (client.Player.CurrentRegionID != 72)
            {
                client.Player.Out.SendMessage("You can only use /qtc in the setup zone.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                return;
            }
            if (client.Player.IsAlive)
            {
                if (!client.Player.IsMoving)
                {
                    if (!client.Player.InCombat)
                    {

                        client.Player.Out.SendPlayerQuit(false);
                        client.Player.Quit(true);
                        client.Player.SaveIntoDatabase();
                    }
                    else
                        client.Player.Out.SendMessage("You cannot /QTC while in combat.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                }
                else
                    client.Player.Out.SendMessage("You must stop moving to /QTC.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
            }
            else
                client.Player.Out.SendMessage("You must be alive to /QTC.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
            return;
        }
    }
}