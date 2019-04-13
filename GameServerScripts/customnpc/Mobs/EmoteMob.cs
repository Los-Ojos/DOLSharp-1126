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

/*
 * Mob that emotes GMs in the mobs aggro area with times to stop spamming the client and changes from 10 different mob models.
 * Create By Deathwish 28/03/2012
 * 
 * To make the NPC use /mob Create DOL.GS.EmoteMob
 * Enjoy
 */

using System;
using System.Collections;
using System.Timers;
using DOL.GS;
using DOL.Database;
using DOL.GS.Scripts;
using DOL.Events;
using DOL.GS.PacketHandler;
using DOL.GS.SkillHandler;
using DOL.GS.Spells;
using DOL.GS.Effects;
using DOL.AI.Brain;

namespace DOL.GS
{

    public class EmoteMob : GameNPC
    {
        #region Constructor
        public EmoteMob()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }
        #endregion Constructor
        #region AddToWorld
        public override bool AddToWorld()
        {
            int color = Util.Random(0, 86);
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.Cloak, 1724);
            template.AddNPCEquipment(eInventorySlot.TorsoArmor, 134);
            template.AddNPCEquipment(eInventorySlot.FeetArmor, 138);
            template.AddNPCEquipment(eInventorySlot.HandsArmor, 137);
            template.AddNPCEquipment(eInventorySlot.LegsArmor, 135);
            template.AddNPCEquipment(eInventorySlot.ArmsArmor, 136);
            template.AddNPCEquipment(eInventorySlot.HeadArmor, 336);
            Inventory = template.CloseTemplate();
            Name = "Guard";
            GuildName = "Emotes Gms";
            Size = 55;
            Level = 60;
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Realm = 0;
            this.SetOwnBrain(new EmoteBrain());
            Brain.Start();
            base.AddToWorld();
            int RandModels = Util.Random(1, 10);//Creates a random model between 1 and 5
            if (RandModels == 1) { Model = 8; ;return true; }
            else if (RandModels == 2) { Model = 9; ;return true; }
            else if (RandModels == 3) { Model = 40; ;return true; }
            else if (RandModels == 4) { Model = 41; ;return true; }
            else if (RandModels == 5) { Model = 158; ;return true; }
            else if (RandModels == 6) { Model = 159; ;return true; }
            else if (RandModels == 7) { Model = 303; ;return true; }
            else if (RandModels == 8) { Model = 304; ;return true; }
            else if (RandModels == 9) { Model = 340; ;return true; }
            else if (RandModels == 10) { Model = 341; ;return true; }
            return true;
        }
        #endregion AddToWorld
    }
}
namespace DOL.AI.Brain
{
    public class EmoteBrain : StandardMobBrain
    {
        public EmoteBrain()
            : base()
        {
            ThinkInterval = 10;
            AggroLevel = 100;
            AggroRange = 200;

        }
        public eEmote Emote = eEmote.Military;//The Emote the NPC does when Interacted
        public override void Think()
        {
            foreach (GamePlayer player in Body.GetPlayersInRadius((ushort)AggroRange))
            {
               if (player.Client.Account.PrivLevel >= 2)
                {
                    long Vip_Emote = Body.TempProperties.getProperty(Emote, 0L);
                    long changeTime = Body.CurrentRegion.Time - Vip_Emote;
                    if (changeTime < 15000)
                    { return; }
                    Body.TempProperties.setProperty(Emote, player.CurrentRegion.Time);
                    foreach (GamePlayer t in Body.GetPlayersInRadius((ushort)AggroRange))
                    {
                        Body.TurnTo(player, 1600);
                        t.Out.SendEmoteAnimation(Body, Emote);
                        return;
                    }
                } return;
            }
        }
    }
}