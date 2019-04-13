//A Invisible Buffbot (Model 666) that just buffs players with its radius.
// Checks if the player has the effect to prevent constant buffing.
//Based on the BuffMerchant.

//Jaystar 2017


using System.Collections;

using DOL.Database;

using DOL.GS.Keeps;
using DOL.GS;
using DOL.GS.Spells;
using DOL.GS.PacketHandler;
using DOL.GS.Effects;
using DOL.AI.Brain;

namespace DOL.GS.Scripts
{
    public class AutoBuffBot : GameNPC
    {
        public const int PlayerCheck = 2 * 800;
              

        #region BuffMerchant attrib/spells/casting
        public AutoBuffBot()
			: base()
		{
            Flags |= GameNPC.eFlags.PEACE;
        }

        public override int Concentration
        {
            get
            {
                return 10000;
            }
        }

        public override int Mana
        {
            get
            {
                return 10000;
            }
        }

        private Queue m_buffs = new Queue();
        private const int BUFFS_SPELL_DURATION = 7200;
        private const bool BUFFS_PLAYER_PET = true;

        
        public void BuffPlayer(GamePlayer player, Spell spell, SpellLine spellLine)
        {
            if (m_buffs == null) m_buffs = new Queue();

            m_buffs.Enqueue(new Container(spell, spellLine, player));

            //don't forget his pet !
            if (BUFFS_PLAYER_PET && player.ControlledBrain != null)
            {
                if (player.ControlledBrain.Body != null)
                {
                    m_buffs.Enqueue(new Container(spell, spellLine, player.ControlledBrain.Body));
                }
            }

            CastBuffs();

        }
        public void CastBuffs()
        {
            Container con = null;
            while (m_buffs.Count > 0)
            {
                con = (Container)m_buffs.Dequeue();

                ISpellHandler spellHandler = ScriptMgr.CreateSpellHandler(this, con.Spell, con.SpellLine);

                if (spellHandler != null)
                {
                    spellHandler.StartSpell(con.Target);
                }
            }
        }

        #region SpellCasting

        private static SpellLine m_MerchBaseSpellLine;
        private static SpellLine m_MerchSpecSpellLine;
        private static SpellLine m_MerchOtherSpellLine;

        /// <summary>
        /// Spell line used by Merchs
        /// </summary>
        public static SpellLine MerchBaseSpellLine
        {
            get
            {
                if (m_MerchBaseSpellLine == null)
                    m_MerchBaseSpellLine = new SpellLine("MerchBaseSpellLine", "BuffMerch Spells", "unknown", true);

                return m_MerchBaseSpellLine;
            }
        }
        public static SpellLine MerchSpecSpellLine
        {
            get
            {
                if (m_MerchSpecSpellLine == null)
                    m_MerchSpecSpellLine = new SpellLine("MerchSpecSpellLine", "BuffMerch Spells", "unknown", false);

                return m_MerchSpecSpellLine;
            }
        }
        public static SpellLine MerchOtherSpellLine
        {
            get
            {
                if (m_MerchOtherSpellLine == null)
                    m_MerchOtherSpellLine = new SpellLine("MerchOtherSpellLine", "BuffMerch Spells", "unknown", true);

                return m_MerchOtherSpellLine;
            }
        }

        private static Spell m_baseaf;
        private static Spell m_basestr;
        private static Spell m_basecon;
        private static Spell m_basedex;
        private static Spell m_strcon;
        private static Spell m_dexqui;
        private static Spell m_acuity;
        private static Spell m_specaf;
        private static Spell m_casterbaseaf;
        private static Spell m_casterbasestr;
        private static Spell m_casterbasecon;
        private static Spell m_casterbasedex;
        private static Spell m_casterstrcon;
        private static Spell m_casterdexqui;
        private static Spell m_casteracuity;
        private static Spell m_casterspecaf;
        private static Spell m_haste;       



        #region Spells

        /// <summary>
        /// Merch Base AF buff (VERIFIED)
        /// </summary>
        public static Spell MerchBaseAFBuff
        {
            get
            {
                if (m_baseaf == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1467;
                    spell.Icon = 1467;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 78; //Effective buff 58
                    spell.Name = "Armor of the Realm";
                    spell.Description = "Adds to the recipient's Armor Factor (AF) resulting in better protection againts some forms of attack. It acts in addition to any armor the target is wearing.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 88001;
                    spell.Target = "Realm";
                    spell.Type = "ArmorFactorBuff";
                    spell.EffectGroup = 1;

                    m_baseaf = new Spell(spell, 50);
                }
                return m_baseaf;
            }
        }
        /// <summary>
        /// Merch Caster Base AF buff (VERIFIED)
        /// </summary>
        public static Spell casterMerchBaseAFBuff
        {
            get
            {
                if (m_casterbaseaf == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1467;
                    spell.Icon = 1467;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 58; //Effective buff 58
                    spell.Name = "Armor of the Realm";
                    spell.Description = "Adds to the recipient's Armor Factor (AF) resulting in better protection againts some forms of attack. It acts in addition to any armor the target is wearing.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 89001;
                    spell.Target = "Realm";
                    spell.Type = "ArmorFactorBuff";
                    spell.EffectGroup = 1;

                    m_casterbaseaf = new Spell(spell, 50);
                }
                return m_casterbaseaf;
            }
        }
        /// <summary>
        /// Merch Base Str buff (VERIFIED)
        /// </summary>
        public static Spell MerchStrBuff
        {
            get
            {
                if (m_basestr == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1457;
                    spell.Icon = 1457;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 74; //effective buff 55
                    spell.Name = "Strength of the Realm";
                    spell.Description = "Increases target's Strength.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 88002;
                    spell.Target = "Realm";
                    spell.Type = "StrengthBuff";
                    spell.EffectGroup = 4;

                    m_basestr = new Spell(spell, 50);
                }
                return m_basestr;
            }
        }
        /// <summary>
        /// Merch Caster Base Str buff (VERIFIED)
        /// </summary>
        public static Spell casterMerchStrBuff
        {
            get
            {
                if (m_casterbasestr == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1457;
                    spell.Icon = 1457;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 55; //effective buff 55
                    spell.Name = "Strength of the Realm";
                    spell.Description = "Increases target's Strength.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 89002;
                    spell.Target = "Realm";
                    spell.Type = "StrengthBuff";
                    spell.EffectGroup = 4;

                    m_casterbasestr = new Spell(spell, 50);
                }
                return m_casterbasestr;
            }
        }
        /// <summary>
        /// Merch Base Con buff (VERIFIED)
        /// </summary>
        public static Spell MerchConBuff
        {
            get
            {
                if (m_basecon == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1486;
                    spell.Icon = 1486;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 74; //effective buff 55
                    spell.Name = "Fortitude of the Realm";
                    spell.Description = "Increases target's Constitution.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 88003;
                    spell.Target = "Realm";
                    spell.Type = "ConstitutionBuff";
                    spell.EffectGroup = 201;

                    m_basecon = new Spell(spell, 50);
                }
                return m_basecon;
            }
        }
        /// <summary>
        /// Merch Caster Base Con buff (VERIFIED)
        /// </summary>
        public static Spell casterMerchConBuff
        {
            get
            {
                if (m_casterbasecon == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1486;
                    spell.Icon = 1486;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 55; //effective buff 55
                    spell.Name = "Fortitude of the Realm";
                    spell.Description = "Increases target's Constitution.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 89003;
                    spell.Target = "Realm";
                    spell.Type = "ConstitutionBuff";
                    spell.EffectGroup = 201;

                    m_casterbasecon = new Spell(spell, 50);
                }
                return m_casterbasecon;
            }
        }
        /// <summary>
        /// Merch Base Dex buff (VERIFIED)
        /// </summary>
        public static Spell MerchDexBuff
        {
            get
            {
                if (m_basedex == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1476;
                    spell.Icon = 1476;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 74; //effective buff 55
                    spell.Name = "Dexterity of the Realm";
                    spell.Description = "Increases Dexterity for a character.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 88004;
                    spell.Target = "Realm";
                    spell.Type = "DexterityBuff";
                    spell.EffectGroup = 202;

                    m_basedex = new Spell(spell, 50);
                }
                return m_basedex;
            }
        }
        /// <summary>
        /// Merch Caster Base Dex buff (VERIFIED)
        /// </summary>
        public static Spell casterMerchDexBuff
        {
            get
            {
                if (m_casterbasedex == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1476;
                    spell.Icon = 1476;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 55; //effective buff 55
                    spell.Name = "Dexterity of the Realm";
                    spell.Description = "Increases Dexterity for a character.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 89004;
                    spell.Target = "Realm";
                    spell.Type = "DexterityBuff";
                    spell.EffectGroup = 202;

                    m_casterbasedex = new Spell(spell, 50);
                }
                return m_casterbasedex;
            }
        }
        /// <summary>
        /// Merch Spec Str/Con buff (VERIFIED)
        /// </summary>
        public static Spell MerchStrConBuff
        {
            get
            {
                if (m_strcon == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1517;
                    spell.Icon = 1517;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 114; //effective buff 85
                    spell.Name = "Might of the Realm";
                    spell.Description = "Increases Str/Con for a character";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 88005;
                    spell.Target = "Realm";
                    spell.Type = "StrengthConstitutionBuff";
                    spell.EffectGroup = 204;

                    m_strcon = new Spell(spell, 50);
                }
                return m_strcon;
            }
        }
        /// <summary>
        /// Merch Caster Spec Str/Con buff (VERIFIED)
        /// </summary>
        public static Spell casterMerchStrConBuff
        {
            get
            {
                if (m_casterstrcon == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1517;
                    spell.Icon = 1517;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 85; //effective buff 85
                    spell.Name = "Might of the Realm";
                    spell.Description = "Increases Str/Con for a character";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 89005;
                    spell.Target = "Realm";
                    spell.Type = "StrengthConstitutionBuff";
                    spell.EffectGroup = 204;

                    m_casterstrcon = new Spell(spell, 50);
                }
                return m_casterstrcon;
            }
        }
        /// <summary>
        /// Merch Spec Dex/Qui buff (VERIFIED)
        /// </summary>
        public static Spell MerchDexQuiBuff
        {
            get
            {
                if (m_dexqui == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1526;
                    spell.Icon = 1526;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 114; //effective buff 85
                    spell.Name = "Deftness of the Realm";
                    spell.Description = "Increases Dexterity and Quickness for a character.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 88006;
                    spell.Target = "Realm";
                    spell.Type = "DexterityQuicknessBuff";
                    spell.EffectGroup = 203;

                    m_dexqui = new Spell(spell, 50);
                }
                return m_dexqui;
            }
        }
        /// <summary>
        /// Merch Caster Spec Dex/Qui buff (VERIFIED)
        /// </summary>
        public static Spell casterMerchDexQuiBuff
        {
            get
            {
                if (m_casterdexqui == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1526;
                    spell.Icon = 1526;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 85; //effective buff 85
                    spell.Name = "Deftness of the Realm";
                    spell.Description = "Increases Dexterity and Quickness for a character.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 89006;
                    spell.Target = "Realm";
                    spell.Type = "DexterityQuicknessBuff";
                    spell.EffectGroup = 203;

                    m_casterdexqui = new Spell(spell, 50);
                }
                return m_casterdexqui;
            }
        }
        /// <summary>
        /// Merch Spec Acuity buff (VERIFIED)
        /// </summary>
        public static Spell MerchAcuityBuff
        {
            get
            {
                if (m_acuity == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1538;
                    spell.Icon = 1538;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 96; //effective buff 72;
                    spell.Name = "Acuity of the Realm";
                    spell.Description = "Increases Acuity (casting attribute) for a character.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 88007;
                    spell.Target = "Realm";
                    spell.Type = "AcuityBuff";
                    spell.EffectGroup = 200;

                    m_acuity = new Spell(spell, 50);
                }
                return m_acuity;
            }
        }
        /// <summary>
        /// Merch Caster Spec Acuity buff (VERIFIED)
        /// </summary>
        public static Spell casterMerchAcuityBuff
        {
            get
            {
                if (m_casteracuity == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1538;
                    spell.Icon = 1538;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 72; //effective buff 72;
                    spell.Name = "Acuity of the Realm";
                    spell.Description = "Increases Acuity (casting attribute) for a character.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 89007;
                    spell.Target = "Realm";
                    spell.Type = "AcuityBuff";
                    spell.EffectGroup = 200;

                    m_casteracuity = new Spell(spell, 50);
                }
                return m_casteracuity;
            }
        }
        /// <summary>
        /// Merch Spec Af buff (VERIFIED)
        /// </summary>
        public static Spell MerchSpecAFBuff
        {
            get
            {
                if (m_specaf == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1506;
                    spell.Icon = 1506;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 90; //effective buff 67
                    spell.Name = "Armor of the Realm";
                    spell.Description = "Adds to the recipient's Armor Factor (AF), resulting in better protection against some forms of attack. It acts in addition to any armor the target is wearing.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 88014;
                    spell.Target = "Realm";
                    spell.Type = "ArmorFactorBuff";
                    spell.EffectGroup = 2;

                    m_specaf = new Spell(spell, 50);
                }
                return m_specaf;
            }
        }
        /// <summary>
        /// Merch Caster Spec Af buff (VERIFIED)
        /// </summary>
        public static Spell casterMerchSpecAFBuff
        {
            get
            {
                if (m_casterspecaf == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 1506;
                    spell.Icon = 1506;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 67; //effective buff 67
                    spell.Name = "Armor of the Realm";
                    spell.Description = "Adds to the recipient's Armor Factor (AF), resulting in better protection against some forms of attack. It acts in addition to any armor the target is wearing.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 89014;
                    spell.Target = "Realm";
                    spell.Type = "ArmorFactorBuff";
                    spell.EffectGroup = 2;

                    m_casterspecaf = new Spell(spell, 50);
                }
                return m_casterspecaf;
            }
        }
        /// <summary>
        /// Merch Haste buff (VERIFIED)
        /// </summary>
        public static Spell MerchHasteBuff
        {
            get
            {
                if (m_haste == null)
                {
                    DBSpell spell = new DBSpell();
                    spell.AllowAdd = false;
                    spell.CastTime = 0;
                    spell.Concentration = 1;
                    spell.ClientEffect = 407;
                    spell.Icon = 407;
                    spell.Duration = BUFFS_SPELL_DURATION;
                    spell.Value = 15;
                    spell.Name = "Haste of the Realm";
                    spell.Description = "Increases the target's combat speed.";
                    spell.Range = WorldMgr.VISIBILITY_DISTANCE;
                    spell.SpellID = 88010;
                    spell.Target = "Realm";
                    spell.Type = "CombatSpeedBuff";
                    spell.EffectGroup = 100;

                    m_haste = new Spell(spell, 50);
                }
                return m_haste;
            }
        }    
        

		 
        

        #endregion Spells

        #endregion SpellCasting

        private void SendReply(GamePlayer target, string msg)
        {
            target.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }

        public class Container
        {
            private Spell m_spell;
            public Spell Spell
            {
                get { return m_spell; }
            }

            private SpellLine m_spellLine;
            public SpellLine SpellLine
            {
                get { return m_spellLine; }
            }

            private GameLiving m_target;
            public GameLiving Target
            {
                get { return m_target; }
                set { m_target = value; }
            }
            public Container(Spell spell, SpellLine spellLine, GameLiving target)
            {
                m_spell = spell;
                m_spellLine = spellLine;
                m_target = target;
            }
        }

        
        #endregion

        protected virtual int Timer(RegionTimer callingTimer)
        {
            int range = ((this.Brain as StandardMobBrain).AggroRange);
            foreach (GamePlayer t in this.GetPlayersInRadius((500))) //500 units seems to be a good range, but change to your needs
            {
                if (t.CharacterClass.ClassType == eClassType.ListCaster)
                {
                    if (!t.HasEffect(casterMerchBaseAFBuff)) BuffPlayer(t, casterMerchBaseAFBuff, MerchBaseSpellLine);
                    if (!t.HasEffect(casterMerchStrBuff)) BuffPlayer(t, casterMerchStrBuff, MerchBaseSpellLine);
                    if (!t.HasEffect(casterMerchDexBuff)) BuffPlayer(t, casterMerchDexBuff, MerchBaseSpellLine);
                    if (!t.HasEffect(casterMerchConBuff)) BuffPlayer(t, casterMerchConBuff, MerchBaseSpellLine);
                    if (!t.HasEffect(casterMerchSpecAFBuff)) BuffPlayer(t, casterMerchSpecAFBuff, MerchSpecSpellLine);
                    if (!t.HasEffect(casterMerchStrConBuff)) BuffPlayer(t, casterMerchStrConBuff, MerchSpecSpellLine);
                    if (!t.HasEffect(casterMerchDexQuiBuff)) BuffPlayer(t, casterMerchDexQuiBuff, MerchSpecSpellLine);
                    if (!t.HasEffect(casterMerchAcuityBuff)) BuffPlayer(t, casterMerchAcuityBuff, MerchSpecSpellLine);
                    if (!t.HasEffect(MerchHasteBuff)) BuffPlayer(t, MerchHasteBuff, MerchSpecSpellLine);

                    

                }
                else
                {
                    if (!t.HasEffect(MerchBaseAFBuff)) BuffPlayer(t, MerchBaseAFBuff, MerchBaseSpellLine);
                    if (!t.HasEffect(MerchStrBuff)) BuffPlayer(t, MerchStrBuff, MerchBaseSpellLine);
                    if (!t.HasEffect(MerchDexBuff)) BuffPlayer(t, MerchDexBuff, MerchBaseSpellLine);
                    if (!t.HasEffect(MerchConBuff)) BuffPlayer(t, MerchConBuff, MerchBaseSpellLine);
                    if (!t.HasEffect(MerchSpecAFBuff)) BuffPlayer(t, MerchSpecAFBuff, MerchSpecSpellLine);
                    if (!t.HasEffect(MerchStrConBuff)) BuffPlayer(t, MerchStrConBuff, MerchSpecSpellLine);
                    if (!t.HasEffect(MerchDexQuiBuff)) BuffPlayer(t, MerchDexQuiBuff, MerchSpecSpellLine);                    
                    if (!t.HasEffect(MerchHasteBuff)) BuffPlayer(t, MerchHasteBuff, MerchSpecSpellLine);
                }

                if(!t.InCombat)
                {
                    t.Health = MaxHealth;
                    if (t.CharacterClass.ID != (int)eCharacterClass.MaulerAlb && t.CharacterClass.ID != (int)eCharacterClass.MaulerHib && t.CharacterClass.ID != (int)eCharacterClass.MaulerMid && t.CharacterClass.ID != (int)eCharacterClass.Vampiir)
                    {

                        t.Mana = MaxMana;
                    }
                }



            }
            return PlayerCheck;
        }
        public override bool AddToWorld()
        {
            Level = 50;
            Model = 1623;
            new RegionTimer(this, new RegionTimerCallback(Timer), PlayerCheck);
            return base.AddToWorld();

        }
    }
}

       