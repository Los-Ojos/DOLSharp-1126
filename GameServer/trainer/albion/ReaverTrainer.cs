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
using DOL.GS.PacketHandler;

namespace DOL.GS.Trainer
{
    /// <summary>
    /// Reaver Trainer
    /// </summary>
    [NPCGuildScript("Reaver Trainer", eRealm.Albion)] // this attribute instructs DOL to use this script for all "Reaver Trainer" NPC's in Albion (multiple guilds are possible for one script)
    public class ReaverTrainer : GameTrainer
    {
        public override eCharacterClass TrainedClass => eCharacterClass.Reaver;

        /// <summary>
        /// Interact with trainer
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public override bool Interact(GamePlayer player)
        {
            if (!base.Interact(player))
            {
                return false;
            }

            // check if class matches.
            if (player.CharacterClass.ID == (int)TrainedClass)
            {
                OfferTraining(player);
            }
            else
            {
                // perhaps player can be promoted
                if (CanPromotePlayer(player))
                {
                    player.Out.SendMessage(Name + " says, \"You have come to seek admittance into the [Temple of Arawn] to worship the old god that your ancestors worshipped?\"", eChatType.CT_System, eChatLoc.CL_PopupWindow);
                    if (!player.IsLevelRespecUsed)
                    {
                        OfferRespecialize(player);
                    }
                }
                else
                {
                    CheckChampionTraining(player);
                }
            }

            return true;
        }

        /// <summary>
        /// Talk to trainer
        /// </summary>
        /// <param name="source"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public override bool WhisperReceive(GameLiving source, string text)
        {
            if (!base.WhisperReceive(source, text))
            {
                return false;
            }

            if (!(source is GamePlayer player))
            {
                return false;
            }

            switch (text) {
                case "Temple of Arawn":
                    // promote player to other class
                    if (CanPromotePlayer(player))
                    {
                        // TODO:
                        // ##Melarlian says, "You have come to seek admittance into the [Temple of Arawn] to worship the old god that your ancestors worshipped?"
                        // ##Melarlian says, "Very well then. Choose your weapon, and it shall be done. Know that once this choice is made, there is no return. You may choose a flexible [slashing] or a flexible [crushing] weapon?"
                        // ##Melarlian says, "Here is your Whip of the Initiate. Welcome to the Temple of Arawn, Calaoron."
                        PromotePlayer(player, (int)eCharacterClass.Reaver, "Welcome to the Temple of Arawn, " + player.Name + ".", null);   // TODO: gifts
                    }

                    break;
            }

            return true;
        }
    }
}

