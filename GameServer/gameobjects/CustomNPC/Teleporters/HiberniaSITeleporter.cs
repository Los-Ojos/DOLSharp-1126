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
 */
using System;
using System.Collections.Generic;
using DOL.Database;
using DOL.GS.PacketHandler;

namespace DOL.GS
{
    /// <summary>
    /// Hibernia SI teleporter.
    /// </summary>
    /// <author>Aredhel</author>
    public class HiberniaSITeleporter : GameTeleporter
    {
        private string[] m_destination = {
            "Grove of Domnann",
            "Droighaid",
            "Aalid Feie",
            "Necht" };

        /// <summary>
        /// Player right-clicked the teleporter.
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public override bool Interact(GamePlayer player)
        {
            if (!base.Interact(player))
            {
                return false;
            }

            List<string> playerAreaList = new List<string>();
            foreach (AbstractArea area in player.CurrentAreas)
            {
                playerAreaList.Add(area.Description);
            }

            SayTo(player, "Greetings. Where can I send you?");
            foreach (string destination in m_destination)
            {
                if (!playerAreaList.Contains(destination))
                {
                    player.Out.SendMessage(
                        string.Format("[{0}]", destination),
                        eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                }
            }

            return true;
        }

        /// <summary>
        /// Player has picked a destination.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="destination"></param>
        protected override void OnDestinationPicked(GamePlayer player, Teleport destination)
        {
            // Not porting to where we already are.
            List<string> playerAreaList = new List<string>();
            foreach (AbstractArea area in player.CurrentAreas)
            {
                playerAreaList.Add(area.Description);
            }

            if (playerAreaList.Contains(destination.TeleportID))
            {
                return;
            }

            switch (destination.TeleportID.ToLower())
            {
                case "grove of domnann":
                    break;
                case "droighaid":
                    break;
                case "aalid feie":
                    break;
                case "necht":
                    break;
                default:
                    return;
            }

            SayTo(player, "Have a safe journey!");
            base.OnDestinationPicked(player, destination);
        }

        /// <summary>
        /// Teleport the player to the designated coordinates.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="destination"></param>
        protected override void OnTeleport(GamePlayer player, Teleport destination)
        {
            OnTeleportSpell(player, destination);
        }
    }
}
