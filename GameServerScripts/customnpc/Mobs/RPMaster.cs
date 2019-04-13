// Original author unknown. Certainly Ogre, Organical, Eteaw or somebody 
// else but I have not a clue...
// Thanks to you whoever you are man.

// Provided by Fooljam for public sharing on HTTP://WWW.DAOCWORLD.NET/LINKS
// This script has been tested OK on DOL server 1.7.12x
// Date : 01/10/2005
// Some features by Sirru


using System;
using System.Collections;
using System.Timers;
using DOL;
using DOL.GS;
using DOL.Database;
using DOL.GS.Scripts;
using DOL.Events;
using DOL.GS.GameEvents;
using DOL.GS.PacketHandler;
using DOL.GS.Quests;

namespace DOL.GS.Scripts
{
    public class RPMaster1 : GameNPC
    {
        private long Price = Money.GetMoney(0, 0, 0, 0, 0);//M/P/G/S/C Amount of gold used for RemoveMoney
        private eEmote Salute = eEmote.Ponder;
        //private eEmote Laugh = eEmote.Laugh;

        public override bool Interact(GamePlayer player)
        {
            if (!base.Interact(player)) return false;
            TurnTo(player, 100);
            foreach (GamePlayer emoteplayer in
this.GetPlayersInRadius(WorldMgr.VISIBILITY_DISTANCE))
            {
                emoteplayer.Out.SendEmoteAnimation(this, Salute);
            }
            player.Out.SendMessage(" Click [HERE] to get Realm Points for free at level 50!\n\n", eChatType.CT_System, eChatLoc.CL_PopupWindow);

            return true;
        }
        public void LaunchSpell(string linename, int spellLevel)
        {
            Spell castSpell = null;
            SpellLine castLine = null;
            castLine = (SpellLine)SkillBase.GetSpellLine(linename);
            IList spells = SkillBase.GetSpellList(castLine.KeyName);
            foreach (Spell spell in spells)
            {
                if (spell.Level == spellLevel)
                {
                    castSpell = spell;
                    break;
                }
            }
            CastSpell(castSpell, castLine);
        }
        public override bool WhisperReceive(GameLiving source, string str)
        {
            if (!base.WhisperReceive(source, str)) return false;
            if (!(source is GamePlayer)) return false;
            GamePlayer t = (GamePlayer)source;
            switch (str)
            {
                case "HERE":


                    if (t.RealmPoints >= 250000)
                    {
                        t.Out.SendMessage("You are already have more realm points then I want to give you!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        return false;

                    }

                    if (t.RealmPoints < 550000) //Number of RPs tht will be given
                    {
                        //      if (GamePlayer.Level = 20)
                        {

                            long amount = 525000; //Change amount of RPs given
                            t.GainRealmPoints(amount / (int)ServerProperties.Properties.RP_RATE);
                            t.Out.SendMessage("The Realm Points Master has given you realm rank 5!", eChatType.CT_Important, eChatLoc.CL_SystemWindow);
                            t.SaveIntoDatabase();
                            t.Out.SendUpdatePlayer();

                        }
                        //   	    if(player.Level <= 19)
                        //				{
                        //				t.Out.SendMessage("You need to be Level 50!", eChatType.CT_System, 
                        // eChatLoc.CL_SystemWindow);
                        //		}


                    }
                    break;

                default: break;
            }
            return true;
        }
        private void SendReply(GamePlayer target, string msg)
        {
            target.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }
    }
}

