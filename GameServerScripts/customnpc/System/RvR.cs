/*
 * DAWN OF LIGHT - The first free open source DAoC server emulator
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 *
 * Autore: Krusck
 * Server: Clan cK
 * Edited by FinalFury for easier use.
 */

using System;
using System.Text;
using DOL.Language;
using DOL.GS.PacketHandler;

namespace DOL.GS.Commands
{
    /// <summary>
    /// Command handler for the /br command
	/// WHRIA
    /// </summary>
    [CmdAttribute(
        "&br",
        ePrivLevel.Player,
        "/br 1 : RvR 하러 오세요. (Come to RvR)",
        "/br 2 : RvR 이제 안해요. (We will quit RvR)"
		)]
    public class WhriaBroadcastCommandHandler : AbstractCommandHandler, ICommandHandler
    {
        public void OnCommand(GameClient client, string[] args)
        {
			if (args.Length != 2)
			{
				DisplaySyntax(client);
				return;
			}
			
			if (args[1]=="1")
			{
               foreach (GameClient thisClient in WorldMgr.GetAllPlayingClients())
                {
                    if (thisClient.Player.Level == 50)
                        thisClient.Player.Out.SendMessage("RvR 하러 오세요. (Come to RvR)", eChatType.CT_Broadcast, eChatLoc.CL_SystemWindow);
                }
	
			}
			else if (args[1]=="2")
			{
               foreach (GameClient thisClient in WorldMgr.GetAllPlayingClients())
                {
                    if (thisClient.Player.Level == 50)
                        thisClient.Player.Out.SendMessage("RvR 이제 안해요. (We will quit RvR)", eChatType.CT_Broadcast, eChatLoc.CL_SystemWindow);
                }
			}
		
        }
    }
}
