/*
 * Doppleganger v1.0
 * Author StephenxPimentel
 * If you change or modify this script, please re-post.
 */


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

namespace DOL.GS
{
    public class Doppleganger : GameNPC
    {
        public override int RealmPointsValue
        {
            get
            {

                return 200;
            }
        }
        public override bool AddToWorld()
        {
            if (!this.InCombat)
                Name = "Forged Invader";
            else Name = "Doppleganger";
            if (!this.InCombat)
                Model = 2116;
            else Model = 2248;
            if (!this.InCombat)
                Level = 55;
            else Level = 75;
            Flags = 0;
            return base.AddToWorld();
        }

        ///Un Comment the Die command and change the "GlowingDreadedSeal"
        ///to any Item ID and on death, everyone in visibility distance. (3600 radius)
        ///will recieve that item in their inventory.

        /*
        public override void Die(GameObject killer)
        {
            if (killer != this)
                base.Die(killer);

            foreach (GamePlayer player in GetPlayersInRadius(WorldMgr.VISIBILITY_DISTANCE))
            {
                int RandItem = Util.Random(1, 10);
                if (RandItem == 1)
                {
                    player.ReceiveItem(this, "GlowingDreadedSeal");
                    player.UpdatePlayerStatus();
                }
                if (RandItem == 2)
                {
                    player.ReceiveItem(this, "GlowingDreadedSeal");
                    player.UpdatePlayerStatus();
                }
                if (RandItem == 3)
                {
                    player.ReceiveItem(this, "GlowingDreadedSeal");
                    player.UpdatePlayerStatus();
                }
                if (RandItem == 4)
                {
                    player.ReceiveItem(this, "GlowingDreadedSeal");
                    player.UpdatePlayerStatus();
                }
                if (RandItem == 5)
                {
                    player.ReceiveItem(this, "GlowingDreadedSeal");
                    player.UpdatePlayerStatus();
                }
                if (RandItem == 6)
                {
                    player.ReceiveItem(this, "GlowingDreadedSeal");
                    player.UpdatePlayerStatus();
                }
                if (RandItem == 7)
                {
                    player.ReceiveItem(this, "GlowingDreadedSeal");
                    player.UpdatePlayerStatus();
                }
                if (RandItem == 8)
                {
                    player.ReceiveItem(this, "GlowingDreadedSeal");
                    player.UpdatePlayerStatus();
                }
                if (RandItem == 9)
                {
                    player.ReceiveItem(this, "GlowingDreadedSeal");
                    player.UpdatePlayerStatus();
                }
                if (RandItem == 10)
                {
                    player.ReceiveItem(this, "GlowingDreadedSeal");
                    player.UpdatePlayerStatus();
                }
            }
        }
         */
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
                return base.MaxHealth * 8;
            }
        }

        public override double AttackDamage(InventoryItem weapon)
        {
            return base.AttackDamage(weapon) * 4;
        }
        //public override int MaxSpeed
        //{
        //    get
        //    {
        //        return 191 * 2;
        //    }
        //    set
        //    {
        //        m_maxSpeedBase = value;
        //    }
        //}
        public override int AttackRange
        {
            get
            {
                return 400;
            }
            set { }
        }
        public override void StartAttack(GameObject attackTarget)
        {
            Name = "Doppleganger";
            Model = 2248;
            Level = 75;

            base.StartAttack(attackTarget);
        }
        public void SwitchToMelee(GameObject target)
        {
            SwitchWeapon(eActiveWeaponSlot.Standard);
            this.Health = this.MaxHealth;
        }
    }
}