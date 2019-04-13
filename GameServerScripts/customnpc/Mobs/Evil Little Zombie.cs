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
 * 
 * The Sound Effects only work in some regions.
 */
using System;
using System.Collections;
using System.Timers;
using DOL;
using DOL.AI.Brain;
using DOL.GS;
using DOL.GS.GameEvents;
using DOL.GS.PacketHandler;
using DOL.Database;
using DOL.Events;
using DOL.GS.Spells;
using DOL.GS.Effects;


namespace DOL.GS
{
    /// <summary>
    /// A very, very cute cat
    /// </summary>
    /// <author>Blues</author>
    public class CuteCat : GameNPC
    {

        public override bool AddToWorld()
        {
            Name = "evil little zombie";
            Model = 923;
            Level = 40;
            Size = 55;
            Realm = 0;
            Flags ^= eFlags.PEACE;
            MaxSpeedBase = 230;
            CuteCatBrain catbrain = new CuteCatBrain();
            SetOwnBrain(catbrain);


            
            base.AddToWorld();
            return true;
        }
    }

}
namespace DOL.AI.Brain
{
    /// <summary>
    /// Isn't it cute?
    /// </summary>
    public class CuteCatBrain : StandardMobBrain
    {
        /// <summary>
        /// Brain Think Method
        /// </summary>
        public override void Think()
        {
            CheckAreaForKuschel();
            Miau(Body);
        }

        public void CheckAreaForKuschel()
        {
            if (Body.TargetObject == null)
            {
                foreach (GamePlayer player in Body.GetPlayersInRadius(500))
                {
                    
                    //as soon as the cat finds someone we take him as target
                    Body.TargetObject = player;
                    break;
                }
            }
            //if (Body.TargetObject != null && WorldMgr.GetDistance(Body, Body.TargetObject) < 1200)
			if (Body.TargetObject != null && new Point3D(Body.X, Body.Y, Body.Z).GetDistanceTo(Body.TargetPosition) < 1200)
            {
                GameEventMgr.AddHandler(Body, GameNPCEvent.ArriveAtTarget, new DOLEventHandler(ArriveAt));
                TheWalk(Body.TargetObject as GamePlayer, Body);
            }
            else
            {
                Body.TargetObject = null;
                //if (WorldMgr.GetDistance(Body.SpawnX, Body.SpawnY, Body.SpawnZ, Body.X, Body.Y, Body.Z) > 1000)
				if (Body.SpawnPoint.GetDistance(new Point3D(Body.X, Body.Y, Body.Z)) > 1000)
                    Body.WalkToSpawn();
                else
                    Body.WalkTo((Body.X - Util.Random(1, 100)), (Body.Y - Util.Random(1, 100)), Body.Z, 80);
            }
        }

        public void TheWalk(GamePlayer target, GameNPC cat)
        {
            int tx, ty;

            tx = target.GetPointFromHeading(this.Body.Heading, 30).X;
            ty = target.GetPointFromHeading(this.Body.Heading, 30).Y;
            cat.WalkTo(tx, ty, target.Z, 80);
        }

        public void ArriveAt(DOLEvent e, object sender, EventArgs arguments)
        {
            if (Body.TargetObject == null)
            {
                GameEventMgr.RemoveHandler(Body, GameNPCEvent.ArriveAtTarget, new DOLEventHandler(ArriveAt));
                return;
            }
            //if (WorldMgr.GetDistance(Body, Body.TargetObject) > 85)
			if (new Point3D(Body.X, Body.Y, Body.Z).GetDistanceTo(Body.TargetPosition) > 85)
                TheWalk(Body.TargetObject as GamePlayer, Body);
            else
            {
                GameEventMgr.RemoveHandler(Body, GameNPCEvent.ArriveAtTarget, new DOLEventHandler(ArriveAt));
                Kuschel(Body.TargetObject as GamePlayer);
            }
            return;
        }

        /// <summary>
        /// Method to kuschel a bit
        /// </summary>
        public void Kuschel(GamePlayer target)
        {
            string gend = "he";
            if (Util.Chance(5))
            {
                foreach (GamePlayer p in Body.GetPlayersInRadius(WorldMgr.SAY_DISTANCE))
                {
                    if (p == target)
                        p.Out.SendMessage("The little zombie sneaks around your Legs", eChatType.CT_Emote, eChatLoc.CL_ChatWindow);
                    else
                        p.Out.SendMessage("The little zombie sneaks around " + target.Name + "'s Legs", eChatType.CT_Emote, eChatLoc.CL_ChatWindow);
                }
            }
            else if (Util.Chance(10))
            {
                if(target.Gender == eGender.Female)
                    gend = "she";
                foreach (GamePlayer p in Body.GetPlayersInRadius(WorldMgr.SAY_DISTANCE))
                {
                    if (p == target)
                        p.Out.SendMessage("The little zombie seams to follow you wherever you go.", eChatType.CT_Emote, eChatLoc.CL_ChatWindow);
                    else
                        p.Out.SendMessage("The little zombie seams to follow " + target.Name + " wherever " + gend + " goes.", eChatType.CT_Emote, eChatLoc.CL_ChatWindow);
                }
            }

            else if (Util.Chance(10))
            {
                foreach (GamePlayer p in Body.GetPlayersInRadius(WorldMgr.SAY_DISTANCE))
                {
                    if (p == target)
                        p.Out.SendMessage("The little zombie stares at you with wide eyes.", eChatType.CT_Emote, eChatLoc.CL_ChatWindow);
                    else
                        p.Out.SendMessage("The little zombie stares at " + target.Name + " with wide eyes.", eChatType.CT_Emote, eChatLoc.CL_ChatWindow);
                }
            }

            else if (Util.Chance(5))
            {
                foreach (GamePlayer p in Body.GetPlayersInRadius(WorldMgr.SAY_DISTANCE))
                {
                    if (p == target)
                        p.Out.SendMessage("The little zombie looks at you expectantly.", eChatType.CT_Emote, eChatLoc.CL_ChatWindow);
                    else
                        p.Out.SendMessage("The little zombie looks at " + target.Name + " expectantly.", eChatType.CT_Emote, eChatLoc.CL_ChatWindow);
                }
            }
            else if (Util.Chance(5))
                Body.Yell("I WILL EAT YOUR BRAIN!!!!!");

            else if (Util.Chance(5))
                Body.Yell("RUN OR I EAT YOUR BRAIN!!!!!");

        }

        public void Miau(GameNPC npc)
        {
            if (Util.Chance(50))
            {
                switch (Util.Random(5))
                {
                    case 1:
                        foreach (GamePlayer p in npc.GetPlayersInRadius(WorldMgr.SAY_DISTANCE))
                            p.Out.SendSoundEffect(2564, p.CurrentRegionID, (ushort)npc.X, (ushort)npc.Y, (ushort)npc.Z, 100);
                        break;

                    case 2:
                        foreach (GamePlayer p in npc.GetPlayersInRadius(WorldMgr.SAY_DISTANCE))
                            p.Out.SendSoundEffect(2565, p.CurrentRegionID, (ushort)npc.X, (ushort)npc.Y, (ushort)npc.Z, 100);
                        break;

                    case 3:
                        foreach (GamePlayer p in npc.GetPlayersInRadius(WorldMgr.SAY_DISTANCE))
                            p.Out.SendSoundEffect(2566, p.CurrentRegionID, (ushort)npc.X, (ushort)npc.Y, (ushort)npc.Z, 100);
                        break;

                    case 4:
                        foreach (GamePlayer p in npc.GetPlayersInRadius(WorldMgr.SAY_DISTANCE))
                        {
                            p.Out.SendMessage("The little zombie bites", eChatType.CT_Emote, eChatLoc.CL_ChatWindow);
                            p.Out.SendSoundEffect(2555, p.CurrentRegionID, (ushort)npc.X, (ushort)npc.Y, (ushort)npc.Z, 100);
                        }
                        break;
                    case 5:
                        foreach (GamePlayer p in npc.GetPlayersInRadius(WorldMgr.SAY_DISTANCE))
                            p.Out.SendSoundEffect(2564, p.CurrentRegionID, (ushort)npc.X, (ushort)npc.Y, (ushort)npc.Z, 100);
                        break;
                }

            }
            return;
        }
    }
}