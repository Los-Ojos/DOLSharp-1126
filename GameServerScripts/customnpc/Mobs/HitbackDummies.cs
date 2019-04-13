//based on normal dummy by Alezzandroz
//edited by Blues

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


namespace DOL.GS
{
    public class HitbackDummy : GameNPC
    {

        public override bool AddToWorld()
        {
            Name = "Hitback Dummy";

            MaxSpeedBase = 0;
            Level = 50;

            Realm = 0;
            Strength = 1;
            RespawnInterval = 20000;
            base.AddToWorld();
            return true;
        }




        #region behaviour
        public override void TakeDamage(GameObject source, eDamageType damageType, int damageAmount, int criticalAmount)
        {
            if (!(Health - damageAmount - criticalAmount <= 0))
                base.TakeDamage(source, damageType, damageAmount, criticalAmount);
            if (Health < MaxHealth)
                Health = MaxHealth;
        }
        # endregion




    }
}
