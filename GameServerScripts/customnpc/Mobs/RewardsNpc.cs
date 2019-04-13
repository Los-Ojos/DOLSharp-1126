/* Made By Kedrik.
 * Majorly Modded by Exde.
 */

using System;
using DOL;
using DOL.GS;
using DOL.Events;
using DOL.Database;
using System.Collections;
using DOL.GS.PacketHandler;

namespace DOL.GS.Scripts
{
	public class RewardsNPC: GameNPC
    {
        private int Chance;//Chance for Prefixes

        public override bool AddToWorld()
        {
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            switch (Realm)
            {
                case eRealm.Albion:
                    template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2230); break;
                case eRealm.Midgard:
                    template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2232);
                    template.AddNPCEquipment(eInventorySlot.ArmsArmor, 2233);
                    template.AddNPCEquipment(eInventorySlot.LegsArmor, 2234);
                    template.AddNPCEquipment(eInventorySlot.HandsArmor, 2235);
                    template.AddNPCEquipment(eInventorySlot.FeetArmor, 2236);
                    break;
                case eRealm.Hibernia:
                    template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2231); ; break;
            }

            Inventory = template.CloseTemplate();
            Flags |= GameNPC.eFlags.PEACE;
            return base.AddToWorld();
        }
        private ushort spell = 208; //Spell Casted
        private GamePlayer tplayer = null;

		public override bool Interact(GamePlayer player)
		{	
			if(!base.Interact(player)) return false;
            SendReply(player, "Hello, I can grant you some amazing [Abilities] to aid you in PvP combat. " +
            "Be sure to also visit The King who will allow you to embark on the full path of the Champion.");
			return true;
		}
		public override bool WhisperReceive(GameLiving source, string str)
		{
			if(!base.WhisperReceive(source,str)) return false;
		  	if(!(source is GamePlayer)) return false;
			GamePlayer t = (GamePlayer) source;
			switch(str)
			{
                case "Abilities":
                    if (t.Level >= 50)
                    {
                        t.AddSpellLine(SkillBase.GetSpellLine("Champion Abilities"));
                        t.Out.SendMessage("I have given you your first Champion Abilities!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                        t.RefreshSpecDependantSkills(true);
                        t.Out.SendUpdatePlayerSkills();
                        t.Out.SendUpdatePlayer();
                        t.UpdatePlayerStatus();
                        t.SaveIntoDatabase();
                    }
                    else SendReply(t, "You are not the correct level, come back when you have reached level 45.");
                    break;

                case "The King":
                    if (t.Level >= 50)
                    {
                        Say("I'm now teleporting you to the King");
                        t.MoveTo(394, 32327, 32379, 15901, 63);
                    }
                    else 
                    SendReply(t, "You are not the correct level, here you go :).");
                    t.Level = 50;
                    t.Health = t.MaxHealth;
                    t.Endurance = t.MaxEndurance;
                    t.Mana = t.MaxMana;
                    t.UpdatePlayerStatus();
                    break;

				default: break;
			}
			return true;
		}
        public void ShowAnimation(GamePlayer target)
        {
            foreach (GamePlayer vplayer in this.GetPlayersInRadius(WorldMgr.VISIBILITY_DISTANCE))
            {
                vplayer.Out.SendSpellCastAnimation(this, spell, 20); //Caster,SpellID,Duration
            }
            tplayer = target;
            RegionTimer timer = new RegionTimer(tplayer, new RegionTimerCallback(ShowEffect), 2000);//GameObject,ElapsedEvent,Duration in MS
        }

        public int ShowEffect(RegionTimer timer)
        {
            
                foreach (GamePlayer vplayer in this.GetPlayersInRadius(WorldMgr.VISIBILITY_DISTANCE))
                {
                    vplayer.Out.SendSpellEffectAnimation(this, tplayer, spell, 0, false, 1);  //vergessen,GameObject,SpellID,vergessen,vergessen,vergessen
                }
                RegionTimer timer2 = new RegionTimer(tplayer, new RegionTimerCallback(Teleport), 2000);

                timer.Stop();
                timer = null;
                return 0;
            }
        
        public int Teleport(RegionTimer timer2)
        {

                tplayer = null;
                timer2.Stop();
                timer2 = null;
                return 0;
            }
        
		private void SendReply(GamePlayer target, string msg)
		{
			target.Out.SendMessage(
				msg,
				eChatType.CT_Say,eChatLoc.CL_PopupWindow);
		}
	}
}