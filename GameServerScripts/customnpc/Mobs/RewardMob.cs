///////////////////////////////////////////////////
////////     BPMobds  1.0                  ////////
////////     Copyright 2009 by Amuny       ////////
///////////////////////////////////////////////////
// Edited by Spellfire :
// Change:   The name of mob from BPMob to RewardMob to remove any confusion.
// Addition: Mob level ranges + suitable rps for their level. Line 60 of this script.
// Addition: Random Jackpot and Bonus RP system from an old script author unkown. Line 50 of this script.
// Addition: Mobs will now ignore the modifier set in server properties table. Line 32 of this script.
// Question: Bonus RP system not giving correct values?. Line 89 of this script.
// Question: How do I change the group rp range from region to an actual range value?. Line 130 of this script.
// Question: ?I may have something mixed up or inserted in the wrong area but the mobs are giving exp twice?.
using DOL.GS.ServerProperties;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using DOL.AI;
using DOL.Language;
using DOL.GS.Effects;
using DOL.GS.Movement;
using DOL.GS.Quests;
using DOL.GS.Spells;
using DOL.GS.Utils;
using DOL.GS.Housing;
using DOL.GS.RealmAbilities;
using System;
using System.Collections;
using DOL.Database;
using DOL.Events;
using DOL.GS;
using DOL.GS.PacketHandler;
using DOL.GS.Scripts;
using System.Threading;
using log4net;
using DOL.AI.Brain;

namespace DOL.GS.Scripts
{
    public class RewardMob : GameNPC
    {

        public override bool AddToWorld()
        {
            //this makes the mob non-peaceful upon creation.
            Flags = 0;
            


            return base.AddToWorld();
        }




        public override void Die(GameObject killer)
        {
            GamePlayer player = killer as GamePlayer;

            //amount of rp/bp gain based on the mob level
            int rewardrp = 100;
            int rewardbp = 50;

            if (Level >= 5 && Level <= 9) { rewardbp = 1; rewardrp = 1; }
            if (Level >= 10 && Level <= 14) { rewardbp = 2; rewardrp = 2; }
            if (Level >= 15 && Level <= 19) { rewardbp = 3; rewardrp = 3; }
            if (Level >= 20 && Level <= 24) { rewardbp = 4; rewardrp = 4; }
            if (Level >= 25 && Level <= 29) { rewardbp = 5; rewardrp = 10; }
            if (Level >= 30 && Level <= 34) { rewardbp = 50; rewardrp = 100; }
            if (Level >= 35 && Level <= 39) { rewardbp = 26; rewardrp = 40; }
            if (Level >= 40 && Level <= 44) { rewardbp = 27; rewardrp = 80; }
            if (Level >= 45 && Level <= 49) { rewardbp = 28; rewardrp = 600; }
            if (Level >= 50 && Level <= 54) { rewardbp = 50; rewardrp = 100; }
            if (Level >= 55 && Level <= 59) { rewardbp = 30; rewardrp = 1000; }
            if (Level >= 60 && Level <= 64) { rewardbp = 60; rewardrp = 2000; }
            if (Level >= 65 && Level <= 69) { rewardbp = 90; rewardrp = 27000; }
            if (Level >= 70 && Level <= 74) { rewardbp = 120; rewardrp = 5120; }
            if (Level >= 75 && Level <= 79) { rewardbp = 150; rewardrp = 10240; }
            if (Level >= 80 && Level <= 84) { rewardbp = 180; rewardrp = 20480; }
            if (Level >= 85 && Level <= 89) { rewardbp = 210; rewardrp = 40960; }
            if (Level >= 90 && Level <= 94) { rewardbp = 5000; rewardrp = 81920; }
            if (Level >= 95 && Level <= 99) { rewardbp = 5000; rewardrp = 163840; }
            if (Level >= 100 && Level <= 255) { rewardbp = 100000; rewardrp = 327680; }



            bool jackpot;
            // Jackpot Mulitplier set to *2 and *3 rps.
            int multiplier = Util.Random(2, 3);
            // Bonus can be used for holidays and other events. Set at +1 to +5 rps.
            //int bonus = Util.Random(1, 2); // bonus not working correctly
            // Chance of getting a Jackpot , set to 1 in 2.
            int chance = Util.Random(1, 2);


            if (chance == 2)
            {
                jackpot = true;
            }
            else
            {
                jackpot = false;
            }
            if (jackpot)
            {
                rewardrp = ((rewardrp) * multiplier);
               // rewardrp = ((rewardrp + bonus) * multiplier);// bonus not working correctly
            }
            else
            {
                rewardrp = (rewardrp);
               // rewardrp = (rewardrp + bonus);// bonus not working correctly
            }



            //If they worth the reward of the killed mob
            if (player is GamePlayer && IsWorthReward)
            {
                //If the player have a group, then we split the reward amount
                if (player.Group != null)
                {
                    if (player.Group.MemberCount == 1) { } //We don't affect the reward if there is only one player
                    if (player.Group.MemberCount == 2) { rewardbp = (rewardbp / 2); rewardrp = (rewardrp / 2); }
                    if (player.Group.MemberCount == 3) { rewardbp = (rewardbp / 3); rewardrp = (rewardrp / 3); }
                    if (player.Group.MemberCount == 4) { rewardbp = (rewardbp / 4); rewardrp = (rewardrp / 4); }
                    if (player.Group.MemberCount == 5) { rewardbp = (rewardbp / 5); rewardrp = (rewardrp / 5); }
                    if (player.Group.MemberCount == 6) { rewardbp = (rewardbp / 6); rewardrp = (rewardrp / 6); }
                    if (player.Group.MemberCount == 7) { rewardbp = (rewardbp / 7); rewardrp = (rewardrp / 7); }
                    if (player.Group.MemberCount >= 8) { rewardbp = (rewardbp / 8); rewardrp = (rewardrp / 8); }

                    //We give the reward to all groupmembers in the same region of the killer
                    foreach (GamePlayer player2 in player.Group.GetMembersInTheGroup())
                    {
                        if (player2.CurrentRegionID == player.CurrentRegionID)
                        {

                            player2.GainRealmPoints(rewardrp, false);// false will disable the modifier in server properties table for this mob.
                            player2.GainBountyPoints(rewardbp, false);// false will disable the modifier in server properties table for this mob.

                        }
                    }
                }
                //If the player is not in a group, we give him the reward
                else
                {

                    player.GainRealmPoints(rewardrp, false); // false will disable the modifier in server properties table for this mob.
                    player.GainBountyPoints(rewardbp, false);// false will disable the modifier in server properties table for this mob.

                }
            }

            //The mob is killed by the killer
            base.Die(killer);

            //Begin the mob's respawn timer
            StartRespawn();
        }

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        GameLiving m_DopplegangerTarget;
        public GameLiving DopplegangerTarget
        {
            get
            {
                return m_DopplegangerTarget;
            }
            set
            {
                m_DopplegangerTarget = value;
            }
        }

        public override int MaxHealth
        {
            get
            {
                return base.MaxHealth * 4;
            }
        }

    /*    public override int MaxSpeedBase
        {
            get
            {
                return 191 ;
            }
            set
            {
                m_maxSpeedBase = value;
            }
        }
        */

        public override double AttackDamage(InventoryItem weapon)
        {
            return base.AttackDamage(weapon) * 4;
        }

        public override void StartAttack(GameObject attackTarget)
        {


            base.StartAttack(attackTarget);
        }
        public void SwitchToMelee(GameObject target)
        {
            SwitchWeapon(eActiveWeaponSlot.Standard);
            this.Health = this.MaxHealth;
        }
    }
}




