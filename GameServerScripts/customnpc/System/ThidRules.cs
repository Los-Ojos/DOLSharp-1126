
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
 * Created by VaNaTiC@gmx.net 
 * for Thidranki Classic (http://www.thidrankiclassic.de)
 * 
 * Some notes:
 * - ...
 * 
 * Features:
 * - ...
 * 
 * ChangeLog:
 * 2007-06-27, Sio:
 * - PvP-Zone -> Albion SI (RegionID: 51)
 * - Safe-Zone -> Mid SI Aegir (new SetupZone, RegionID: 151)
 * 2007-06-12, VaNaTiC:
 * - PvP-Zone -> Celestius (Stars ML10 Spot RegionID: 91)
 * - PvE-Zone -> Passage of Conflict (RegionID: 244)
 * - PvE-Zone -> Darkness Falls (RegionID: 249)
 * - added changes from PvPServerRules.IsSameRealm() Rev 676
 * 2007-06-08, VaNaTiC:
 * - added colorhandling on GameEntered
 * - added LevelUpSound to RegionChanged and GamEntered to update NPCs color
 * 2007-06-04, VaNaTiC:
 * - added changes from PvPServerRules.IsSameRealm() Rev 664
 * - added changes from AbstractServerRules.IsAllowedToAttack() Rev 664
 * 2007-06-02, VaNaTiC:
 * - added check for xrealm+disband in event PlayerRegionChanged
 * - IsAllowedToCastSpell(): added complete handling PvE, PvP, RvR and SafeZones
 * - IsAllowedToUnderstand(): added complete handling PvE, PvP, RvR and SafeZones
 * - IsAllowedToTrade(): added complete handling PvE, PvP, RvR and SafeZones
 * - IsAllowedToGroup(): added complete handling PvE, PvP, RvR and SafeZones
 * - IsSameRealm(): added complete handling PvE, PvP, RvR and SafeZones
 * - IsAllowedToAttack(): added complete handling PvE, PvP, RvR and SafeZones
 * - added handling PvE-Zones
 * 2007-06-01, VaNaTiC:
 * - added preparing for PvE-zones
 * 2007-05-31, VaNaTiC:
 * - renamed ThidrankiClassicServerRules -> TCServerRules
 * - added PvE (safe-zone), PvP(pvp-zone) name-coloring and name-handling
 * - added m_pvpRegions and related code
 * - changed m_safeRegions from int[] to ushort[] and edited related m_safeRegions-Code
 * 2007-05-29, VaNaTiC:
 * - added PvE name/lastname/guild-handling in safe-zones
 * - added experimental PvE color-handling in safe-zones
 * 2007-05-22, VaNaTiC:
 * - allowed trading for all realms in safe-zones (setup-zone)
 * - allowed broadcast for all realms in safe-zones (setup-zone)
 * 2007-05-14, Lordy:
 * - added configuration Values: CLAIM_STATUS, CLAIM_BONUS, CLAIM_Logging
 * - added GuildClaimBonus(int RP, int BP, GamePlayer pl) method Line 
 * - added in onplayerkilled() line 572 GuildClaimBonus() call
 * 2007-04-24, VaNaTiC:
 * - OnPlayerKilled(): fixed some things in LOGGING-Section
 * 2007-04-19, VaNaTiC:
 * - OnPlayerKilled(): fixed bug in handling XPGainers
 * - OnPlayerKilled(): added Logging
 * - OnPlayerKilled(): recalc for values with percent-based rate
 * - OnPlayerKilled(): counting of Friends/Enemies based upon XPGainers
 * - OnPlayerKilled(): consts for better configurability
 * - OnPlayerKilled(): dont count GMs to Friends/Enemies anymore
 * 2007-04-18, VaNaTiC:
 * - overridden IsAllowedToConnect() for vip-access
 * - added vip-access based upon account.Mail
 * - overridden IsAllowedToAttack() for safezones
 * - added safezones based upon PvP-RuleSet, as it was implemented in our old AbstractServerRules.cs
 * 2007-04-17, VaNaTiC:
 * - added in my OnPlayerKilled() handling for both grps
 * - handled in my OnPlayerKilled() mali for zergers :D
 * - added copy of NormalServerRules.OnPlayerKilled()
 * - created ( copy&paste&edit of NormalServerRules :-D )
 */
using System;
using System.Net;
using System.Text;
using System.Reflection;
using System.Collections;



using DOL.Database;
using DOL.AI.Brain;
using DOL.Events;
using DOL.Language;
using DOL.GS;
using DOL.GS.Keeps;
using DOL.GS.Scripts;
using DOL.GS.ServerRules;
using DOL.GS.PacketHandler;
using DOL.GS.ServerProperties;

using log4net;
using System.Collections.Generic;

namespace DOL.GS.ServerRules
{
    /// <summary>
    /// Set of rules for ThidrankiClassic "RvR" server type.
    /// </summary>
    [ServerRules(eGameServerType.GST_Test)]
    public class TCServerRules : NormalServerRules
    {
        #region configuration flags
        /// <summary>
        /// if it is 0.75 it means that only 75% of the whole RP-worth is recalculated
        /// </summary>
        public readonly double CALC_RATE = 0.75;
        /// <summary>
        /// if ENEMIES (Killer and Friends) > FRIENDS (Dead Player and Friends) 
        /// and this property is true then the ENEMIES get a penalty
        /// </summary>
        public readonly bool CALC_PENALTY = true;
        /// <summary>
        /// if ENEMIES (Killer and Friends) < FRIENDS (Dead Player and Friends) 
        /// and this property is true then the ENEMIES get a bonus
        /// </summary>
        public readonly bool CALC_BONUS = false;
        /// <summary>
        /// Enable/Disable Logging in GameServer-Logs as [INFO]
        /// </summary>
        public readonly bool LOGGING = false;
        /// <summary>
        /// If set true, the Player get a RP/BP bonus if The Guild Claim the Keep/Tower.
        /// </summary>
        public readonly bool CLAIM_STATUS = true;
        /// <summary>
        /// The % Value the player will get RPs/BPs to the Normal Amount.
        /// </summary>
        public readonly double CLAIM_BONUS = 0.10;
        /// <summary>
        /// ClaimBonus Logging
        /// Enable/Disable Logging in GameServer-Logs as [INFO] 
        /// </summary>
        public readonly bool CLAIM_LOGGING = false;

        #endregion

        /// <summary>
        /// Defines a logger for this class.
        /// </summary>
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public override string RulesDescription()
        {
            return "ThidrankiClassic RvR Server Rules Fair-Play-System";
        }

        #region configuration here your safe/pvp-regions for setup/event-zone

        /// <summary>
        /// our declared safe-zones (based upon PvP-RuleSet)
        /// </summary>
        protected static int[] m_safeRegions =
		{
			
			2, //Alb Housing
			202, //Hibernia Housing
			102, //Midgard Housing
		};

        /// <summary>
        /// our declared pvp-zones (based upon PvP-RuleSet)
        /// </summary>
        protected static int[] m_pvpRegions =
		{

			51, //Avalon
		};

        /// <summary>
        /// our declared pve-zones (based upon PvE-RuleSet)
        /// </summary>
        protected static int[] m_pveRegions =
		{
			485,	 //Unused Placeholder
		};
        
        #endregion

        #region functions and handling for safe/pvp-regions

        /// <summary>
        /// returns true if the given region is a safe-zone
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        public static bool IsSafeZone(int regionId)
        {
            if (m_safeRegions != null && m_safeRegions.Length > 0)
                foreach (int reg in m_safeRegions)
                    if (reg == regionId)
                        return true;
            return false;
        }

        /// <summary>
        /// returns true if the given region is a pvp-zone
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        public static bool IsPvPZone(int regionId)
        {
            if (m_pvpRegions != null && m_pvpRegions.Length > 0)
                foreach (int reg in m_pvpRegions)
                    if (reg == regionId)
                        return true;
            return false;
        }

        /// <summary>
        /// returns true if the given region is a pve-zone
        /// </summary>
        /// <param name="regionId"></param>
        /// <returns></returns>
        public static bool IsPvEZone(int regionId)
        {
            if (m_pveRegions != null && m_pveRegions.Length > 0)
                foreach (int reg in m_pveRegions)
                    if (reg == regionId)
                        return true;
            return false;
        }

        #endregion

        #region IsAllowedToAttack() merge of PvE, PvP, SafeZone and NormalRvR

        /// <summary>
        /// AbstractServerRules: Is attacker allowed to attack defender.
        /// </summary>
        /// <param name="attacker">living that makes attack</param>
        /// <param name="defender">attacker's target</param>
        /// <param name="quiet">should messages be sent</param>
        /// <returns>true if attack is allowed</returns>
        protected virtual bool Abstract_IsAllowedToAttack(GameLiving attacker, GameLiving defender, bool quiet)
        {
            if (attacker == null || defender == null)
                return false;

            //dead things can't attack
            if (!defender.IsAlive || !attacker.IsAlive)
                return false;

            GamePlayer playerAttacker = attacker as GamePlayer;
            GamePlayer playerDefender = defender as GamePlayer;

            if (playerDefender != null && playerDefender.Client.ClientState == GameClient.eClientState.WorldEnter)
            {
                if (!quiet)
                    MessageToLiving(attacker, defender.Name + " is entering the game and is temporarily immune to PvP attacks!");
                return false;
            }

            if (playerAttacker != null && playerDefender != null)
            {
                // Attacker immunity
                if (playerAttacker.IsInvulnerableToAttack)
                {
                    if (quiet == false) MessageToLiving(attacker, "You can't attack players until your PvP invulnerability timer wears off!");
                    return false;
                }

                // Defender immunity
                if (playerDefender.IsInvulnerableToAttack)
                {
                    if (quiet == false) MessageToLiving(attacker, defender.Name + " is temporarily immune to PvP attacks!");
                    return false;
                }
            }

            // PEACE NPCs can't be attacked/attack
            if (attacker is GameNPC)
                if ((((GameNPC)attacker).Flags & GameNPC.eFlags.PEACE) != 0)
                    return false;

            if (defender is GameNPC)
                if ((((GameNPC)defender).Flags & GameNPC.eFlags.PEACE) != 0)
                    return false;

            //GMs can't be attacked
            if (playerDefender != null && playerDefender.Client.Account.PrivLevel > 1)
                return false;

            //safe area support for defender
            foreach (AbstractArea area in defender.CurrentAreas)
            {
                if (!area.IsSafeArea)
                    continue;

                if (quiet == false) MessageToLiving(attacker, "You can't attack someone in a safe area!");
                return false;
            }

            //safe area support for attacker
            foreach (AbstractArea area in attacker.CurrentAreas)
            {
                if (area.IsSafeArea)
                {
                    if (quiet == false) MessageToLiving(attacker, "You can't attack someone in a safe area!");
                    return false;
                }
            }

            //I don't want mobs attacking guards
            if (defender is GameKeepGuard && attacker is GameNPC && attacker.Realm == 0)
                return false;

            return true;
        }

        /// <summary>
        /// PvEServerRules: Is attacker allowed to attack defender.
        /// </summary>
        /// <param name="attacker">living that makes attack</param>
        /// <param name="defender">attacker's target</param>
        /// <param name="quiet">should messages be sent</param>
        /// <returns>true if attack is allowed</returns>
        protected virtual bool PvE_IsAllowedToAttack(GameLiving attacker, GameLiving defender, bool quiet)
        {
            if (!Abstract_IsAllowedToAttack(attacker, defender, quiet))
                return false;

            // if controlled NPC - do checks for owner instead
            if (attacker is GameNPC)
            {
                IControlledBrain controlled = ((GameNPC)attacker).Brain as IControlledBrain;
                if (controlled != null)
                {
                    attacker = controlled.Owner;
                    quiet = true; // silence all attacks by controlled npc
                }
            }
            if (defender is GameNPC)
            {
                IControlledBrain controlled = ((GameNPC)defender).Brain as IControlledBrain;
                if (controlled != null)
                    defender = controlled.Owner;
            }

            //"You can't attack yourself!"
            if (attacker == defender)
            {
                if (quiet == false) MessageToLiving(attacker, "You can't attack yourself!");
                return false;
            }

            if (attacker.Realm != 0 && defender.Realm != 0)
            {
                if (attacker is GamePlayer && ((GamePlayer)attacker).DuelTarget != defender)
                {
                    // allow mobs to attack mobs
                    if (attacker.Realm == 0)
                        return true;

                    if (quiet == false) MessageToLiving(attacker, "You can not attack other players on this server!");
                    return false;
                }
            }

            // mobs can't attack mobs
            if (attacker.Realm == 0 && defender.Realm == 0)
                return false;

            return true;
        }

        /// <summary>
        /// PvPServerRules: Is attacker allowed to attack defender.
        /// </summary>
        /// <param name="attacker">living that makes attack</param>
        /// <param name="defender">attacker's target</param>
        /// <param name="quiet">should messages be sent</param>
        /// <returns>true if attack is allowed</returns>
        protected virtual bool PvP_IsAllowedToAttack(GameLiving attacker, GameLiving defender, bool quiet)
        {
            if (!Abstract_IsAllowedToAttack(attacker, defender, quiet))
                return false;

            // if controlled NPC - do checks for owner instead
            if (attacker is GameNPC)
            {
                IControlledBrain controlled = ((GameNPC)attacker).Brain as IControlledBrain;
                if (controlled != null)
                {
                    attacker = controlled.Owner;
                    quiet = true; // silence all attacks by controlled npc
                }
            }
            if (defender is GameNPC)
            {
                IControlledBrain controlled = ((GameNPC)defender).Brain as IControlledBrain;
                if (controlled != null)
                    defender = controlled.Owner;
            }

            // can't attack self
            if (attacker == defender)
            {
                if (quiet == false) MessageToLiving(attacker, "You can't attack yourself!");
                return false;
            }

            //ogre: sometimes other players shouldn't be attackable
            GamePlayer playerAttacker = attacker as GamePlayer;
            GamePlayer playerDefender = defender as GamePlayer;
            if (playerAttacker != null && playerDefender != null)
            {
                //check group
                if (playerAttacker.Group != null && playerAttacker.Group.IsInTheGroup(playerDefender))
                {
                    if (!quiet) MessageToLiving(playerAttacker, "You can't attack your group members.");
                    return false;
                }

                if (playerAttacker.DuelTarget != defender)
                {
                    //check guild
                    if (playerAttacker.Guild != null && playerAttacker.Guild == playerDefender.Guild)
                    {
                        if (!quiet) MessageToLiving(playerAttacker, "You can't attack your guild members.");
                        return false;
                    }

                    //todo: battlegroups

                    // Safe regions
                    if (m_safeRegions != null)
                    {
                        foreach (int reg in m_safeRegions)
                            if (playerAttacker.CurrentRegionID == reg)
                            {
                                if (quiet == false) MessageToLiving(playerAttacker, "You're currently in a safe zone, you can't attack other players here.");
                                return false;
                            }
                    }

                    /********************************** DISABLED by VaNaTiC cause of special TCServerRules
                                        // Players with safety flag can not attack other players
                                        if (playerAttacker.Level < m_safetyLevel && playerAttacker.SafetyFlag)
                                        {
                                            if (quiet == false) MessageToLiving(attacker, "Your PvP safety flag is ON.");
                                            return false;
                                        }

                                        // Players with safety flag can not be attacked in safe regions
                                        if (playerDefender.Level < m_safetyLevel && playerDefender.SafetyFlag)
                                        {
                                            bool unsafeRegion = false;
                                            foreach (int regionID in m_unsafeRegions)
                                            {
                                                if (regionID == playerDefender.CurrentRegionID)
                                                {
                                                    unsafeRegion = true;
                                                    break;
                                                }
                                            }
                                            if (unsafeRegion == false)
                                            {
                                                //"PLAYER has his safety flag on and is in a safe area, you can't attack him here."
                                                if (quiet == false) MessageToLiving(attacker, playerDefender.Name + " has " + playerDefender.GetPronoun(1, false) + " safety flag on and is in a safe area, you can't attack " + playerDefender.GetPronoun(2, false) + " here.");
                                                return false;
                                            }
                                        }
                    ******************************************************************************/
                }
            }

            // allow mobs to attack mobs
            if (attacker.Realm == 0 && defender.Realm == 0)
                return true;

            //allow confused mobs to attack same realm
            if (attacker is GameNPC && (attacker as GameNPC).IsConfused && attacker.Realm == defender.Realm)
                return true;

            // "friendly" NPCs can't attack "friendly" players
            if (defender is GameNPC && defender.Realm != 0 && attacker.Realm != 0 && defender is GameKeepGuard == false)
            {
                if (quiet == false) MessageToLiving(attacker, "You can't attack a friendly NPC!");
                return false;
            }
            // "friendly" NPCs can't be attacked by "friendly" players
            if (attacker is GameNPC && attacker.Realm != 0 && defender.Realm != 0 && attacker is GameKeepGuard == false)
            {
                return false;
            }

            #region Keep Guards
            //guard vs guard / npc
            if (attacker is GameKeepGuard)
            {
                if (defender is GameKeepGuard)
                    return false;

                if (defender is GameNPC && (defender as GameNPC).Brain is IControlledBrain == false)
                    return false;
            }

            //player vs guard
            if (defender is GameKeepGuard && attacker is GamePlayer
                && GameServer.KeepManager.IsEnemy(defender as GameKeepGuard, attacker as GamePlayer) == false)
            {
                if (quiet == false) MessageToLiving(attacker, "You can't attack a friendly NPC!");
                return false;
            }

            //guard vs player
            if (attacker is GameKeepGuard && defender is GamePlayer
                && GameServer.KeepManager.IsEnemy(attacker as GameKeepGuard, defender as GamePlayer) == false)
            {
                return false;
            }
            #endregion

            return true;
        }

        /// <summary>
        /// Is attacker allowed to attack defender.
        /// ThidrankiClassic: PvE, PvP, RvR and SafeRegions in One for our SetupZone Caer Sidi
        /// </summary>
        /// <param name="attacker">living that makes attack</param>
        /// <param name="defender">attacker's target</param>
        /// <param name="quiet">should messages be sent</param>
        /// <returns>true if attack is allowed</returns>
        public override bool IsAllowedToAttack(GameLiving attacker, GameLiving defender, bool quiet)
        {
            if (attacker == null || defender == null)
                return false;

            if (TCServerRules.IsPvPZone(attacker.CurrentRegionID))
                return PvP_IsAllowedToAttack(attacker, defender, quiet);
            else if (TCServerRules.IsPvEZone(attacker.CurrentRegionID))
                return PvE_IsAllowedToAttack(attacker, defender, quiet);

            bool allowed = base.IsAllowedToAttack(attacker, defender, true);
            // ONLY check safe-zones if allowed from base
            if (allowed && TCServerRules.IsSafeZone(attacker.CurrentRegionID))
            {
                if (defender is GamePlayer
                     && (attacker is GamePlayer || !(attacker is GameTrainingDummy)))
                {
                    if (!quiet)
                        MessageToLiving(attacker, "You're currently in a safe zone, you can't attack other players here.");
                    return false;
                }
            }
            return allowed;
        }

        #endregion

        #region IsSameRealm merge for PvE, PvP, RvR and SafeRegions

        /// <summary>
        /// PvEServerRules: Does source considers target "friendly".
        /// Used for spells with "Realm" and "Group" spell types, friend list.
        /// </summary>
        /// <param name="source">spell source, considering object</param>
        /// <param name="target">spell target, considered object</param>
        /// <param name="quiet"></param>
        /// <returns></returns>
        protected virtual bool PvE_IsSameRealm(GameLiving source, GameLiving target, bool quiet)
        {
            if (source == null || target == null) return false;

            // if controlled NPC - do checks for owner instead
            if (source is GameNPC)
            {
                IControlledBrain controlled = ((GameNPC)source).Brain as IControlledBrain;
                if (controlled != null)
                {
                    source = controlled.Owner;
                    quiet = true; // silence all attacks by controlled npc
                }
            }
            if (target is GameNPC)
            {
                IControlledBrain controlled = ((GameNPC)target).Brain as IControlledBrain;
                if (controlled != null)
                    target = controlled.Owner;
            }

            // clients with priv level > 1 are considered friendly by anyone
            if (target is GamePlayer && ((GamePlayer)target).Client.Account.PrivLevel > 1) return true;

            // mobs can heal mobs, players heal players/NPC
            if (source.Realm == 0 && target.Realm == 0) return true;
            if (source.Realm != 0 && target.Realm != 0) return true;

            //Peace flag NPCs are same realm
            if (target is GameNPC)
                if ((((GameNPC)target).Flags & GameNPC.eFlags.PEACE) != 0)
                    return true;

            if (source is GameNPC)
                if ((((GameNPC)source).Flags & GameNPC.eFlags.PEACE) != 0)
                    return true;

            if (quiet == false) MessageToLiving(source, target.GetName(0, true) + " is not a member of your realm!");
            return false;
        }

        /// <summary>
        /// PvPServerRules: Does source considers target "friendly".
        /// Used for spells with "Realm" and "Group" spell types, friend list.
        /// </summary>
        /// <param name="source">spell source, considering object</param>
        /// <param name="target">spell target, considered object</param>
        /// <param name="quiet"></param>
        /// <returns></returns>
        protected virtual bool PvP_IsSameRealm(GameLiving source, GameLiving target, bool quiet)
        {
            if (source == null || target == null) return false;

            // if controlled NPC - do checks for owner instead
            if (source is GameNPC)
            {
                IControlledBrain controlled = ((GameNPC)source).Brain as IControlledBrain;
                if (controlled != null)
                {
                    source = controlled.Owner;
                    quiet = true; // silence all attacks by controlled npc
                }
            }
            if (target is GameNPC)
            {
                IControlledBrain controlled = ((GameNPC)target).Brain as IControlledBrain;
                if (controlled != null)
                    target = controlled.Owner;
            }

            // clients with priv level > 1 are considered friendly by anyone
            if (target is GamePlayer && ((GamePlayer)target).Client.Account.PrivLevel > 1) return true;
            // checking as a gm, targets are considered friendly
            if (source is GamePlayer && ((GamePlayer)source).Client.Account.PrivLevel > 1) return true;

            // mobs can heal mobs, players heal players/NPC
            if (source.Realm == 0 && target.Realm == 0) return true;

            //keep guards
            if (source is GameKeepGuard && target is GamePlayer)
            {
                if (!GameServer.KeepManager.IsEnemy(source as GameKeepGuard, target as GamePlayer))
                    return true;
            }

            if (target is GameKeepGuard && source is GamePlayer)
            {
                if (!GameServer.KeepManager.IsEnemy(target as GameKeepGuard, source as GamePlayer))
                    return true;
            }

            //doors need special handling
            if (target is GameKeepDoor && source is GamePlayer)
                return GameServer.KeepManager.IsEnemy(target as GameKeepDoor, source as GamePlayer);

            if (source is GameKeepDoor && target is GamePlayer)
                return GameServer.KeepManager.IsEnemy(source as GameKeepDoor, target as GamePlayer);

            //components need special handling
            if (target is GameKeepComponent && source is GamePlayer)
                return GameServer.KeepManager.IsEnemy(target as GameKeepComponent, source as GamePlayer);

            //Peace flag NPCs are same realm
            if (target is GameNPC)
                if ((((GameNPC)target).Flags & GameNPC.eFlags.PEACE) != 0)
                    return true;

            if (source is GameNPC)
                if ((((GameNPC)source).Flags & GameNPC.eFlags.PEACE) != 0)
                    return true;

            if (source is GamePlayer && target is GamePlayer)
                return true;

            if (source is GamePlayer && target is GameNPC && target.Realm != 0)
                return true;

            if (quiet == false) MessageToLiving(source, target.GetName(0, true) + " is not a member of your realm!");
            return false;
        }

        /// <summary>
        /// Does source considers target "friendly".
        /// Used for spells with "Realm" and "Group" spell types, friend list.
        /// </summary>
        /// <param name="source">spell source, considering object</param>
        /// <param name="target">spell target, considered object</param>
        /// <param name="quiet"></param>
        /// <returns></returns>
        public override bool IsSameRealm(GameLiving source, GameLiving target, bool quiet)
        {
           

        	
        	if (source == null || target == null) return false;

            if (TCServerRules.IsPvPZone(source.CurrentRegionID))
                return PvP_IsSameRealm(source, target, quiet);
            else if (TCServerRules.IsPvEZone(source.CurrentRegionID))
                return PvE_IsSameRealm(source, target, quiet);
            else
                return base.IsSameRealm(source, target, quiet);
        }

        #endregion

        #region IsAllowedToCastSpell() merge for PvE, PvP, RvR and SafeZones

        /// <summary>
        /// Is caster allowed to cast a spell
        /// </summary>
        /// <param name="caster"></param>
        /// <param name="target"></param>
        /// <param name="spell"></param>
        /// <param name="spellLine"></param>
        /// <returns>true if allowed</returns>
        public override bool IsAllowedToCastSpell(GameLiving caster, GameLiving target, Spell spell, SpellLine spellLine)
        {
            if (!base.IsAllowedToCastSpell(caster, target, spell, spellLine))
                return false;
            if (!TCServerRules.IsPvPZone(caster.CurrentRegionID))
                return true;
            // if reached here, we have to know we are in pvp and check if allowed there

            GamePlayer casterPlayer = caster as GamePlayer;
            if (casterPlayer != null)
            {
                if (casterPlayer.IsInvulnerableToAttack)
                {
                    // always allow selftargeted spells
                    if (spell.Target == "Self") return true;

                    // only caster can be the target, can't buff/heal other players
                    // PBAE/GTAE doesn't need a target so we check spell type as well
                    if (caster != target || spell.Target == "Area" || spell.Target == "Enemy" || (spell.Target == "Group" && spell.SpellType != "SpeedEnhancement"))
                    {
                        MessageToLiving(caster, "You can only cast spells on yourself until your PvP invulnerability timer wears off!", eChatType.CT_Important);
                        return false;
                    }
                }

            }
            return true;
        }

        #endregion

        #region possible to grp mates from all realms in safe/pvp-zone (setup or pvp-regions)

        /// <summary>
        /// Is source allowed to group target.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="quiet"></param>
        /// <returns></returns>
        public override bool IsAllowedToGroup(GamePlayer source, GamePlayer target, bool quiet)
        {
            bool allowed = base.IsAllowedToGroup(source, target, true);
            // ONLY check safe/pvp-zones if NOT allowed from base
            if (!allowed
                 && source != null
                 && target != null
                 && source is GamePlayer
                 && target is GamePlayer
                 && source.Realm != target.Realm
                 && source.CurrentRegionID == target.CurrentRegionID)
            {
                if (TCServerRules.IsSafeZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvEZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvPZone(target.CurrentRegionID))
                    return true;

                if (!quiet)
                    MessageToLiving(source, "You can't invite a player of another realm.");
                return false;
            }

            return allowed;
        }

        #endregion

        #region all realms can communicate in safe/pvp-zone (setup or pvp-regions)

        /// <summary>
        /// Is target allowed to understand source.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public override bool IsAllowedToUnderstand(GameLiving source, GamePlayer target)
        {
            bool allowed = base.IsAllowedToUnderstand(source, target);
            // ONLY check safe/pvp-zones if NOT allowed from base
            if (!allowed
                 && source != null
                 && target != null
                 && source is GamePlayer)
                if (TCServerRules.IsSafeZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvEZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvPZone(target.CurrentRegionID))
                    return true;
            return allowed;
        }

        #endregion

        #region all realms can trade in safe/pvp-zone (setup or pvp-regions)

        /// <summary>
        /// Is source allowed to trade with target.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="quiet"></param>
        /// <returns></returns>
        public override bool IsAllowedToTrade(GameLiving source, GameLiving target, bool quiet)
        {
            bool allowed = base.IsAllowedToTrade(source, target, true);
            // ONLY check safe/pvp-zones if NOT allowed from base
            if (!allowed
                 && source != null
                 && target != null
                 && source is GamePlayer
                 && target is GamePlayer
                 && source.Realm != target.Realm
                 && source.CurrentRegionID == target.CurrentRegionID)
            {
                if (TCServerRules.IsSafeZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvEZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvPZone(target.CurrentRegionID))
                    return true;

                if (!quiet)
                    MessageToLiving(source, "You can't trade with enemy realm!");
                return false;
            }

            return allowed;
        }

        #endregion

        #region PvE/PvP name- and color-handling in safe/pvp-zones

        /// <summary>
        /// Gets the server type color handling scheme
        /// 
        /// ColorHandling: this byte tells the client how to handle color for PC and NPC names (over the head) 
        /// 0: standard way, other realm PC appear red, our realm NPC appear light green 
        /// 1: standard PvP way, all PC appear red, all NPC appear with their level color 
        /// 2: Same realm livings are friendly, other realm livings are enemy; nearest friend/enemy buttons work
        /// 3: standard PvE way, all PC friendly, realm 0 NPC enemy rest NPC appear light green 
        /// 4: All NPC are enemy, all players are friendly; nearest friend button selects self, nearest enemy don't work at all
        /// </summary>
        /// <param name="client">The client asking for color handling</param>
        /// <returns>The color handling</returns>
        public override byte GetColorHandling(GameClient client)
        {
            if (client != null && client.Player != null)
            {
                if (TCServerRules.IsSafeZone(client.Player.CurrentRegionID))
                    return 3;
                else if (TCServerRules.IsPvEZone(client.Player.CurrentRegionID))
                    return 3;
                else if (TCServerRules.IsPvPZone(client.Player.CurrentRegionID))
                    return 1;
            }
            return base.GetColorHandling(client);
        }

        /// <summary>
        /// Gets the player name based on server type and safe/pvp-zone
        /// </summary>
        /// <param name="source">The "looking" player</param>
        /// <param name="target">The considered player</param>
        /// <returns>The name of the target</returns>
        public override string GetPlayerName(GamePlayer source, GamePlayer target)
        {
            if (source != null
                 && target != null
                 && source is GamePlayer
                 && target is GamePlayer
                 && source.Realm != target.Realm
                 && source.CurrentRegionID == target.CurrentRegionID)
            {
                if (TCServerRules.IsSafeZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvEZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvPZone(target.CurrentRegionID))
                    return target.Name;
            }
            return base.GetPlayerName(source, target);
        }

        /// <summary>
        /// Gets the player last name based on server type and safe/pvp-zone
        /// </summary>
        /// <param name="source">The "looking" player</param>
        /// <param name="target">The considered player</param>
        /// <returns>The last name of the target</returns>
        public override string GetPlayerLastName(GamePlayer source, GamePlayer target)
        {
            if (source != null
                 && target != null
                 && source is GamePlayer
                 && target is GamePlayer
                 && source.Realm != target.Realm
                 && source.CurrentRegionID == target.CurrentRegionID)
            {
                if (TCServerRules.IsSafeZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvEZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvPZone(target.CurrentRegionID))
                    return target.LastName;
            }
            return base.GetPlayerLastName(source, target);
        }

        /// <summary>
        /// Gets the player guild name based on server type and safe/pvp-zone
        /// </summary>
        /// <param name="source">The "looking" player</param>
        /// <param name="target">The considered player</param>
        /// <returns>The guild name of the target</returns>
        public override string GetPlayerGuildName(GamePlayer source, GamePlayer target)
        {
            if (source != null
                 && target != null
                 && source is GamePlayer
                 && target is GamePlayer
                 && source.Realm != target.Realm
                 && source.CurrentRegionID == target.CurrentRegionID)
            {
                if (TCServerRules.IsSafeZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvEZone(target.CurrentRegionID) ||
                     TCServerRules.IsPvPZone(target.CurrentRegionID))
                    return target.GuildName;
            }
            return base.GetPlayerGuildName(source, target);
        }

        #endregion

        #region vip-handling with account.Mail

        /// <summary>
        /// Allows or denies a client from connecting to the server ...
        /// For ThidrankiClassic: Account.Mail != "" -> VIP
        /// NOTE: The client has not been fully initialized when this method is called.
        /// For example, no account or character data has been loaded yet.
        /// </summary>
        /// <param name="client">The client that sent the login request</param>
        /// <param name="username">The username of the client wanting to connect</param>
        /// <returns>true if connection allowed, false if connection should be terminated</returns>
        /// <remarks>You can only send ONE packet to the client and this is the
        /// LoginDenied packet before returning false. Trying to send any other packet
        /// might result in unexpected behaviour on server and client!</remarks>
        public override bool IsAllowedToConnect(GameClient client, string username)
        {
            if (!client.Socket.Connected)
                return false;
            string accip = ((IPEndPoint)client.Socket.RemoteEndPoint).Address.ToString();

            // Ban account
            IList<DBBannedAccount> objs;
            //objs = GameServer.Database.SelectObjects<DBBannedAccount>("(Type ='Account' AND Account ='" + GameServer.Database.Escape(username) + "') OR (Type ='Account+Ip' AND Account ='" + GameServer.Database.Escape(username) + "')");
            objs = GameServer.Database.SelectObjects<DBBannedAccount>("((Type='A' OR Type='B') AND Account ='" + GameServer.Database.Escape(username) + "')");
            if (objs.Count > 0)
            {
                client.Out.SendLoginDenied(eLoginError.AccountIsBannedFromThisServerType);
                return false;
            }

            // Ban IP Adress
            //objs = GameServer.Database.SelectObjects<DBBannedAccount>("(Type = 'Ip' AND Ip ='" + GameServer.Database.Escape(accip) + "') OR (Type ='Account+Ip' AND Ip ='" + GameServer.Database.Escape(accip) + "')");
            objs = GameServer.Database.SelectObjects<DBBannedAccount>("((Type='I' OR Type='B') AND Ip ='" + GameServer.Database.Escape(accip) + "')");
            if (objs.Count > 0)
            {
                client.Out.SendLoginDenied(eLoginError.AccountIsBannedFromThisServerType);
                return false;
            }

            GameClient.eClientVersion min = (GameClient.eClientVersion)Properties.CLIENT_VERSION_MIN;
            if (min != GameClient.eClientVersion.VersionNotChecked && client.Version < min)
            {
                client.Out.SendLoginDenied(eLoginError.ClientVersionTooLow);
                return false;
            }

            GameClient.eClientVersion max = (GameClient.eClientVersion)Properties.CLIENT_VERSION_MAX;
            if (max != GameClient.eClientVersion.VersionNotChecked && client.Version > max)
            {
                client.Out.SendLoginDenied(eLoginError.ClientVersionTooLow);
                return false;
            }

            if (Properties.CLIENT_TYPE_MAX > -1)
            {
                GameClient.eClientType type = (GameClient.eClientType)Properties.CLIENT_TYPE_MAX;
                if ((int)client.ClientType > (int)type)
                {
                    client.Out.SendLoginDenied(eLoginError.ExpansionPacketNotAllowed);
                    return false;
                }
            }

            /* Example to limit the connections from a certain IP range!
            if(client.Socket.RemoteEndPoint.ToString().StartsWith("192.168.0."))
            {
                client.Out.SendLoginDenied(eLoginError.AccountNoAccessAnyGame);
                return false;
            }
            */


            /* Example to deny new connections on saturdays
            if(DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                client.Out.SendLoginDenied(eLoginError.GameCurrentlyClosed);
                return false;
            }
            */

            /* Example to deny new connections between 10am and 12am
            if(DateTime.Now.Hour >= 10 && DateTime.Now.Hour <= 12)
            {
                client.Out.SendLoginDenied(eLoginError.GameCurrentlyClosed);
                return false;
            }
            */

            IList<Account> accountobjs;
            if (Properties.MAX_PLAYERS > 0)
            {
                if (WorldMgr.GetAllClients().Count > Properties.MAX_PLAYERS)
                {
                    // GMs are still allowed to enter server
                    accountobjs = GameServer.Database.SelectObjects<Account>(string.Format("Name = '{0}'", GameServer.Database.Escape(username)));
                    if (accountobjs.Count > 0)
                    {
                        Account account = accountobjs[0] as Account;
                        if (account.PrivLevel > 1) return true;
                        if (account.Mail != "") return true;
                    }

                    // Normal Players will not be allowed over the max
                    client.Out.SendLoginDenied(eLoginError.TooManyPlayersLoggedIn);
                    return false;
                }
            }

            if (Properties.STAFF_LOGIN)
            {
                // GMs are still allowed to enter server
                accountobjs = GameServer.Database.SelectObjects<Account>(string.Format("Name = '{0}'", GameServer.Database.Escape(username)));
                if (accountobjs.Count > 0)
                {
                    Account account = accountobjs[0] as Account;
                    if (account.PrivLevel > 1) return true;
                }

                // Normal Players will not be allowed to log in
                client.Out.SendLoginDenied(eLoginError.GameCurrentlyClosed);
                return false;
            }

            return true;
        }

        #endregion

        #region special anti-zerg-handling on calculating RP/BP-worth on player killed

        /// <summary>
        /// Invoked on Player death and deals out
        /// experience/realm points if needed
        /// </summary>
        /// <param name="killedPlayer">player that died</param>
        /// <param name="killer">killer</param>
        public override void OnPlayerKilled(GamePlayer killedPlayer, GameObject killer)
        {
            #region "player has been killed recently"
            killedPlayer.LastDeathRealmPoints = 0;
            // "player has been killed recently"
            long noExpSeconds = ServerProperties.Properties.RP_WORTH_SECONDS;
            if (killedPlayer.DeathTime + noExpSeconds > killedPlayer.PlayedTime)
            {
                lock (killedPlayer.XPGainers.SyncRoot)
                {
                    foreach (DictionaryEntry de in killedPlayer.XPGainers)
                    {
                        if (de.Key is GamePlayer)
                        {
                            ((GamePlayer)de.Key).Out.SendMessage(killedPlayer.Name + " has been killed recently and is worth no realm points!", eChatType.CT_Important, eChatLoc.CL_SystemWindow);
                            ((GamePlayer)de.Key).Out.SendMessage(killedPlayer.Name + " has been killed recently and is worth no experience!", eChatType.CT_Important, eChatLoc.CL_SystemWindow);
                        }
                    }
                }
                return;
            }
            #endregion "player has been killed recently"

            lock (killedPlayer.XPGainers.SyncRoot)
            {
                #region "You gain no experience from this kill!"
                bool dealNoXP = false;
                float totalDamage = 0;
                //Collect the total damage
                foreach (DictionaryEntry de in killedPlayer.XPGainers)
                {
                    GameObject obj = (GameObject)de.Key;
                    if (obj is GamePlayer)
                    {
                        //If a gameplayer with privlevel > 1 attacked the
                        //mob, then the players won't gain xp ...
                        if (((GamePlayer)obj).Client.Account.PrivLevel > 1)
                        {
                            dealNoXP = true;
                            break;
                        }
                    }
                    totalDamage += (float)de.Value;
                }

                if (dealNoXP)
                {
                    foreach (DictionaryEntry de in killedPlayer.XPGainers)
                    {
                        GamePlayer player = de.Key as GamePlayer;
                        if (player != null)
                            player.Out.SendMessage("You gain no experience from this kill!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    }
                    return;
                }
                #endregion "You gain no experience from this kill!"

                #region calculating the base-amount of XP,RP+BP
                long playerExpValue = killedPlayer.ExperienceValue;
                playerExpValue = (long)(playerExpValue * ServerProperties.Properties.XP_RATE);
                int playerRPValue = killedPlayer.RealmPointsValue;
                int playerBPValue = 0;
                bool BG = false;
                foreach (AbstractGameKeep keep in GameServer.KeepManager.GetKeepsOfRegion(killedPlayer.CurrentRegionID))
                {
                    if (keep.DBKeep.BaseLevel < 50)
                    {
                        BG = true;
                        break;
                    }
                }
                if (!BG)
                    playerBPValue = killedPlayer.BountyPointsValue;
                long playerMoneyValue = killedPlayer.MoneyValue;
                #endregion calculating the base-amount

                #region RECALCULATING the amount of XP,RP+BP based upon count of friends and enemies

                // getting all attackers for died player
                // (better performance if we do it only once)
                Hashtable attackersOfKilledPlayer = new Hashtable();
                // getting all attackers for the enemies of died player
                Hashtable attackersOfKiller = new Hashtable();
                lock (killedPlayer.XPGainers.SyncRoot)
                {
                    foreach (DictionaryEntry de in killedPlayer.XPGainers)
                        if (de.Key is GameLiving)
                        {
                            attackersOfKilledPlayer[de.Key] = killedPlayer;
                            GameLiving living = (GameLiving)de.Key;
                            lock (living.XPGainers.SyncRoot)
                            {
                                foreach (DictionaryEntry de2 in living.XPGainers)
                                    attackersOfKiller[de2.Key] = living;
                            }
                        }
                }

                // Counting friends and enemies in radius of 1500
                int nFriends = 1; // should be min 1 (killedPlayer itself) + others
                int nEnemies = 1; // should be min 1 (killer itself) + others

                // try to parse killers player grp (if its a player and if it has a grp)
                Group killerPlayerGrp = null;
                if (killer is GamePlayer)
                    killerPlayerGrp = ((GamePlayer)killer).Group;
                else if (killer is GameNPC && ((GameNPC)killer).Brain is ControlledNpcBrain)
                    killerPlayerGrp = ((ControlledNpcBrain)((GameNPC)killer).Brain).Owner.Group;

                // add killed players grp to friends (itself, not)
                if (killedPlayer.Group != null)
                    nFriends += killedPlayer.Group.MemberCount - 1;
                if (killerPlayerGrp != null)
                    nEnemies += killerPlayerGrp.MemberCount - 1;

                // handle all players in radius
                foreach (GamePlayer player in killedPlayer.GetPlayersInRadius(1500))
                {
                    // check if killer or killedPlayer itself (we already counted both above)
                    if (player == killer || player == killedPlayer)
                        continue;
                    // check if player is GM
                    if (player.Client.Account.PrivLevel >= (uint)ePrivLevel.GM)
                        continue;
                    // check if player is in killed players grp
                    if (killedPlayer.Group != null && killedPlayer.Group.IsInTheGroup(player))
                        continue;
                    // check if player is in killer players grp
                    if (killerPlayerGrp != null && killerPlayerGrp.IsInTheGroup(player))
                        continue;

                    //->new code (2007-04-19)
                    // look if this player is in the XPGainers-List of the died player
                    // -> enemy
                    if (attackersOfKilledPlayer.ContainsKey(player))
                        nEnemies++;
                    // look if this player is in the list of attackers of killedPlayers enemies (created&filled above)
                    if (attackersOfKiller.ContainsKey(player))
                        nFriends++;
                    //<-new code (2007-04-19)

                    //->OBSOLETE as of above new code (2007-04-19)
                    /*
                    // else count it to the right side
                    if ( killedPlayer.Realm == player.Realm ) 
                        ++nFriends; 
                    else 
                        ++nEnemies;
                    */
                    //<-OBSOLETE as of above new code (2007-04-19)
                }

                if (LOGGING)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("OnPlayerKilled(): ");
                    if (killedPlayer != null) sb.Append(killedPlayer.Name); else sb.Append("???");
                    sb.Append(" was killed by ");
                    if (killer != null) sb.Append(killer.Name); else sb.Append("???");

                    if (killer != null && killer is GameNPC && ((GameNPC)killer).Brain is ControlledNpcBrain)
                        sb.Append("(").Append(((ControlledNpcBrain)((GameNPC)killer).Brain).Owner.Name).Append(")");

                    sb.Append(" RP=").Append(playerRPValue).Append("->").Append(ReCalc(playerRPValue, nEnemies, nFriends, CALC_RATE));
                    sb.Append(" Friends=").Append(nFriends).Append(" Enemies=").Append(nEnemies);
                    if (CALC_PENALTY && nEnemies > nFriends)
                        sb.Append(" PENALTY");
                    else if (CALC_BONUS && nEnemies < nFriends)
                        sb.Append(" BONUS");
                    log.Info(sb.ToString());
                }
                // penalty or bonus for enemies
                // if they are more or less as friends
                // of died player
                if ((CALC_PENALTY && nEnemies > nFriends) ||
                     (CALC_BONUS && nEnemies < nFriends))
                {
                    playerExpValue = ReCalc(playerExpValue, nEnemies, nFriends, CALC_RATE);
                    playerRPValue = (int)ReCalc(playerRPValue, nEnemies, nFriends, CALC_RATE);
                    playerBPValue = (int)ReCalc(playerBPValue, nEnemies, nFriends, CALC_RATE);
                    playerMoneyValue = ReCalc(playerMoneyValue, nEnemies, nFriends, CALC_RATE);
                    /*
                    playerExpValue /= nEnemies * nFriends;
                    playerRPValue /= nEnemies * nFriends;
                    playerBPValue /= nEnemies * nFriends;
                    playerMoneyValue /= nEnemies * nFriends;
                    */
                }

                #endregion RECALCULATING the amount of XP,RP+BP based upon grp-sizes

                #region Now deal the XP and RPs to all livings
                foreach (DictionaryEntry de in killedPlayer.XPGainers)
                {
                    GameLiving living = de.Key as GameLiving;
                    GamePlayer expGainPlayer = living as GamePlayer;
                    if (living == null) continue;
                    if (living.ObjectState != GameObject.eObjectState.Active) continue;
                    /*
                     * http://www.camelotherald.com/more/2289.shtml
                     * Dead players will now continue to retain and receive their realm point credit
                     * on targets until they release. This will work for solo players as well as 
                     * grouped players in terms of continuing to contribute their share to the kill
                     * if a target is being attacked by another non grouped player as well.
                     */
                    //if (!living.Alive) continue;
				
				   if (!living.IsWithinRadius(killedPlayer, WorldMgr.MAX_EXPFORKILL_DISTANCE)) continue;


                    double damagePercent = (float)de.Value / totalDamage;
                    if (!living.IsAlive)//Dead living gets 25% exp only
                        damagePercent *= 0.25;

                    // realm points
                    int rpCap = living.RealmPointsValue * 2;
                    int realmPoints = (int)(playerRPValue * damagePercent);
                    //rp bonuses from RR and Group
                    //20% if R1L0 char kills RR10,if RR10 char kills R1L0 he will get -20% bonus
                    //100% if full group,scales down according to player count in group and their range to target
                    if (living is GamePlayer)
                    {
                        GamePlayer killerPlayer = living as GamePlayer;
                        realmPoints = (int)(realmPoints * (1.0 + 2.0 * (killedPlayer.RealmLevel - killerPlayer.RealmLevel) / 900.0));
                        if (killerPlayer.Group != null && killerPlayer.Group.MemberCount > 1)
                        {
                            lock (killerPlayer.Group)
                            {
                                int count = 0;
                                foreach (GamePlayer player in killerPlayer.Group.GetPlayersInTheGroup())
                                {
                                    if (!living.IsWithinRadius(killedPlayer, WorldMgr.MAX_EXPFORKILL_DISTANCE)) continue;
                                    count++;
                                }
                                realmPoints = (int)(realmPoints * (1.0 + count * 0.125));
                            }
                        }
                    }
                    if (realmPoints > rpCap)
                        realmPoints = rpCap;
                    if (realmPoints > 0)
                    {
                        if (living is GamePlayer)
                            killedPlayer.LastDeathRealmPoints += realmPoints;
                        living.GainRealmPoints(realmPoints);
                    }

                    // bounty points
                    int bpCap = living.BountyPointsValue * 2;
                    int bountyPoints = (int)(playerBPValue * damagePercent);
                    if (bountyPoints > bpCap)
                        bountyPoints = bpCap;

#warning this is guessed, i do not believe this is the right way, we will most likely need special messages to be sent
                    //apply the keep bonus for bounty points
                    if (killer != null)
                    {
                        if (Keeps.KeepBonusMgr.RealmHasBonus(eKeepBonusType.Bounty_Points_5, (eRealm)killer.Realm))
                            bountyPoints += (bountyPoints / 100) * 5;
                        else if (Keeps.KeepBonusMgr.RealmHasBonus(eKeepBonusType.Bounty_Points_3, (eRealm)killer.Realm))
                            bountyPoints += (bountyPoints / 100) * 3;
                    }

                    if (bountyPoints > 0)
                    {
                        living.GainBountyPoints(bountyPoints);
                    }

                    //Claim Bonus RP/BP if Player Guild have a keep/tower.
                    GamePlayer pl = living as GamePlayer;
                    if (pl != null && pl.Guild != null && pl.Guild.ClaimedKeeps != null)
                    {
                        foreach (AbstractGameKeep keep in pl.Guild.ClaimedKeeps)
                        {
                            if (pl.CurrentRegionID == keep.Region)
                            {
                                GuildClaimBonus(realmPoints, bountyPoints, pl, keep);
                            }
                        }
                    }



                    // experience
                    // TODO: pets take 25% and owner gets 75%
                    long xpReward = (long)(playerExpValue * damagePercent); // exp for damage percent

                    long expCap = (long)(living.ExperienceValue * 1.25);
                    if (xpReward > expCap)
                        xpReward = expCap;

                    //outpost XP
                    //1.54 http://www.camelotherald.com/more/567.shtml
                    //- Players now receive an exp bonus when fighting within 16,000 
                    //units of a keep controlled by your realm or your guild.
                    //You get 20% bonus if your guild owns the keep or a 10% bonus 
                    //if your realm owns the keep.

                    long outpostXP = 0;

                    if (!BG && living is GamePlayer)
                    {
                        AbstractGameKeep keep = GameServer.KeepManager.GetKeepCloseToSpot(living.CurrentRegionID, living, 16000);
                        if (keep != null)
                        {
                            byte bonus = 0;
                            if (keep.Guild != null && keep.Guild == (living as GamePlayer).Guild)
                                bonus = 20;
                            else if (GameServer.Instance.Configuration.ServerType == eGameServerType.GST_Normal &&
                                keep.Realm == living.Realm)
                                bonus = 10;

                            outpostXP = (xpReward / 100) * bonus;
                        }
                    }
                    xpReward += outpostXP;

                    living.GainExperience(GameLiving.eXPSource.Player, xpReward);

                    //gold
                    if (living is GamePlayer)
                    {
                        long money = (long)(playerMoneyValue * damagePercent);
                        //long money = (long)(Money.GetMoney(0, 0, 17, 85, 0) * damagePercent * killedPlayer.Level / 50);
                        ((GamePlayer)living).AddMoney(money, "You recieve {0}");
                    }

                    if (killedPlayer.ReleaseType != GamePlayer.eReleaseType.Duel && expGainPlayer != null)
                    {
                        switch ((eRealm)killedPlayer.Realm)
                        {
                            case eRealm.Albion:
                                expGainPlayer.KillsAlbionPlayers++;
                                if (expGainPlayer == killer)
                                {
                                    expGainPlayer.KillsAlbionDeathBlows++;
                                    if ((float)de.Value == totalDamage)
                                        expGainPlayer.KillsAlbionSolo++;
                                }
                                break;

                            case eRealm.Hibernia:
                                expGainPlayer.KillsHiberniaPlayers++;
                                if (expGainPlayer == killer)
                                {
                                    expGainPlayer.KillsHiberniaDeathBlows++;
                                    if ((float)de.Value == totalDamage)
                                        expGainPlayer.KillsHiberniaSolo++;
                                }
                                break;

                            case eRealm.Midgard:
                                expGainPlayer.KillsMidgardPlayers++;
                                if (expGainPlayer == killer)
                                {
                                    expGainPlayer.KillsMidgardDeathBlows++;
                                    if ((float)de.Value == totalDamage)
                                        expGainPlayer.KillsMidgardSolo++;
                                }
                                break;
                        }
                        killedPlayer.DeathsPvP++;
                    }
                }
                #endregion Now deal the XP and RPs to all livings
            }
        }

        #region recalculation method
        /// <summary>
        /// it returns (value * rate / devisor * factor) + value * (1-rate)
        /// </summary>
        /// <param name="value">the value which should be recalculated</param>
        /// <param name="divisor">the divisor for the rate of value</param>
        /// <param name="factor">the factor for the rate of value</param>
        /// <param name="rate">rate in percent [0..1]</param>
        /// <returns></returns>
        private long ReCalc(long value, int divisor, int factor, double rate)
        {
            if (rate < 0.0)
                rate = 0.0;
            else if (rate > 1.0)
                rate = 1.0;
            if (divisor == 0)
                divisor = 1;
            return (long)Math.Round(value * rate / divisor * factor + value * (1.0 - rate));
        }
        #endregion

        #region GuildClaimBonus

        /// <summary>
        /// Will add a RP bonus if your guild claim a Tower or Keep.
        /// </summary>
        /// <param name="RP">The RealmPoints the Player will earn.</param>
        /// <param name="BP">The BountyPoints the Player will earn.</param>
        /// <param name="pl">The Player that earn the bonus.</param>
        private void GuildClaimBonus(int RP, int BP, GamePlayer pl, AbstractGameKeep keep)
        {
            if (RP == 0
                && BP == 0
                && pl == null)
                return;

            int RPbonus = (int)(RP * CLAIM_BONUS);
            int BPbonus = (int)(BP * CLAIM_BONUS);
            if (CLAIM_STATUS)
            {
                pl.Out.SendMessage("Your Guild have claimed the " + keep.Name + " therefore you receives " + RPbonus.ToString() + " realmpoints and " + BPbonus.ToString() + " bountypoints as a bonus.", eChatType.CT_Important, eChatLoc.CL_SystemWindow);
                pl.BountyPoints += BPbonus;
                pl.RealmPoints += RPbonus;
            }
            if (CLAIM_LOGGING)
                log.Info("ClaimBonus: Player=" + pl.Name + " Acc: " + pl.Client.Account.Name + " Guild: " + pl.Guild.Name + " HasClaimed: " + keep.Name + " RP/BP Bonus: " + RPbonus.ToString() + " / " + BPbonus.ToString());

            return;
        }

        #endregion GuildClaimBonus

        #endregion
    }
}

#region send name-coloring on regionchanged

namespace DOL.GS.GameEvents
{
    /// <summary>
    /// 
    /// </summary>
    public class ColorHandlingRegionChangedEvent
    {
        /// <summary>
        /// Defines a logger for this class.
        /// </summary>
        public static readonly ILog LOG = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Event handler fired when server is started
        /// </summary>
        [GameServerStartedEvent]
        public static void OnServerStart(DOLEvent e, object sender, EventArgs arguments)
        {
            GameEventMgr.AddHandler(GamePlayerEvent.RegionChanged, new DOLEventHandler(PlayerRegionChanged));
            GameEventMgr.AddHandler(GamePlayerEvent.GameEntered, new DOLEventHandler(PlayerGameEntered));
        }

        /// <summary>
        /// Event handler fired when server is stopped
        /// </summary>
        [GameServerStoppedEvent]
        public static void OnServerStop(DOLEvent e, object sender, EventArgs arguments)
        {
            GameEventMgr.RemoveHandler(GamePlayerEvent.RegionChanged, new DOLEventHandler(PlayerRegionChanged));
            GameEventMgr.RemoveHandler(GamePlayerEvent.GameEntered, new DOLEventHandler(PlayerGameEntered));
        }

        private static void ResetColorHandling(GamePlayer player)
        {
            if (player == null) return;
            lock (player)
            {
                player.Out.SendLoginGranted();
                player.Out.SendLevelUpSound();
            }
        }

        private static void CheckGroup(GamePlayer player)
        {
            if (player == null || player.Group == null) return;
            lock (player)
            {
                foreach (GamePlayer p in player.Group.GetPlayersInTheGroup())
                    if (p != null
                         && p != player
                         && !GameServer.ServerRules.IsAllowedToGroup(p, player, true))
                    {
                        player.Group.SendMessageToGroupMembers("You are not allowed to group other realmmates here!", eChatType.CT_Important, eChatLoc.CL_ChatWindow);
                        player.Group.RemoveMember(player);
                        break;
                    }
            }
        }

        /// <summary>
        /// Event handler fired when players changed region
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <param name="arguments"></param>
        private static void PlayerRegionChanged(DOLEvent e, object sender, EventArgs arguments)
        {
            ResetColorHandling(sender as GamePlayer);
            CheckGroup(sender as GamePlayer);
        }

        /// <summary>
        /// Event handler fired when players enters the game
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <param name="arguments"></param>
        private static void PlayerGameEntered(DOLEvent e, object sender, EventArgs arguments)
        {
            ResetColorHandling(sender as GamePlayer);
        }
    }
}

#endregion

#region special examine-handling for safe-zones

namespace DOL.GS.PacketHandler.Client.v168
{
    /// <summary>
    /// Handles player target changes
    /// </summary>
    [PacketHandlerAttribute(PacketHandlerType.TCP, 0x18 ^ 168, "Handles player target changes")]
    public class TCPlayerTargetHandler : IPacketHandler
    {
        public void HandlePacket(GameClient client, GSPacketIn packet)
        {
            ushort targetID = packet.ReadShort();
            ushort flags = packet.ReadShort();
            /*
             * 0x8000 = 'examine' bit
             * 0x4000 = LOS1 bit; is 0 if no LOS
             * 0x2000 = LOS2 bit; is 0 if no LOS
             * 0x0001 = players attack mode bit (not targets!)
             */

            ChangeTargetAction action = new ChangeTargetAction(
                client.Player,
                targetID,
                !((flags & (0x4000 | 0x2000)) == 0),
                (flags & 0x8000) != 0);

            action.Start(1);

            
        }


    /// <summary>
    /// Handles every received packet
    /// </summary>
    /// <param name="client">The client that sent the packet</param>
    /// <param name="packet">The received packet data</param>
    /// <returns></returns>

  
        /// <summary>
        /// Changes players target
        /// </summary>
         protected class ChangeTargetAction : RegionAction
        {
            /// <summary>
            /// The new target OID
            /// </summary>
            protected readonly int m_newTargetId;
            /// <summary>
            /// The 'target in view' flag
            /// </summary>
            protected readonly bool m_targetInView;
            /// <summary>
            /// The 'examine target' bit
            /// </summary>
            protected readonly bool m_examineTarget;

            /// <summary>
            /// Constructs a new TargetChangeAction
            /// </summary>
            /// <param name="actionSource">The action source</param>
            /// <param name="newTargetId">The new target OID</param>
            /// <param name="targetInView">The target LOS bit</param>
            /// <param name="examineTarget">The 'examine target' bit</param>
            public ChangeTargetAction(GamePlayer actionSource, int newTargetId, bool targetInView, bool examineTarget)
                : base(actionSource)
            {
                m_newTargetId = newTargetId;
                m_targetInView = targetInView;
                m_examineTarget = examineTarget;
            }

            /// <summary>
            /// Called on every timer tick
            /// </summary>
            protected override void OnTick()
            {
                GamePlayer player = (GamePlayer)m_actionSource;

                GameObject myTarget = player.CurrentRegion.GetObject((ushort)m_newTargetId);
                player.TargetObject = myTarget;
                player.TargetInView = m_targetInView;

                if (myTarget != null)
                {
                    // Send target message text only if 'examine' bit is set.
                    if (m_examineTarget)
                    {
                        IList messages = myTarget.GetExamineMessages(player);
                        if (myTarget is GamePlayer)
                        {
                            GamePlayer targetPlayer = myTarget as GamePlayer;
                            if (player.Client.Account.PrivLevel < (uint)ePrivLevel.GM
                                 && targetPlayer.Client.Account.PrivLevel < (uint)ePrivLevel.GM)
                            {
                                if (TCServerRules.IsSafeZone(myTarget.CurrentRegionID))
                                {
                                    messages.RemoveAt(messages.Count - 1);
                                    messages.Add(string.Format(LanguageMgr.GetTranslation(player.Client, "GamePlayer.GetExamineMessages.RealmMember", player.GetName(targetPlayer), targetPlayer.GetPronoun(player.Client, 0, true), targetPlayer.CharacterClass.Name)));
                                }
                                else if (TCServerRules.IsPvEZone(myTarget.CurrentRegionID))
                                {
                                    messages.RemoveAt(messages.Count - 1);
                                    messages.Add(string.Format(LanguageMgr.GetTranslation(player.Client, "GamePlayer.GetExamineMessages.RealmMember", player.GetName(targetPlayer), targetPlayer.GetPronoun(player.Client, 0, true), targetPlayer.CharacterClass.Name)));
                                }
                                else if (TCServerRules.IsPvPZone(myTarget.CurrentRegionID))
                                {
                                    messages.RemoveAt(messages.Count - 1);
                                    messages.Add(string.Format(LanguageMgr.GetTranslation(player.Client, "GamePlayer.GetExamineMessages.RealmMember", player.GetName(targetPlayer), targetPlayer.GetPronoun(player.Client, 0, true), targetPlayer.CharacterClass.Name)));
                                }
                            }// if both players are no GMs
                        }// if myTarget is GamePlayer

                        foreach (string message in messages)
                        {
                            player.Out.SendMessage(message, eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }
                    }
                    // Then no LOS message; not sure which bit to use so use both :)
                    // should be sent if targeted is using group panel to change the target
                    if (!m_targetInView)
                    {
                        player.Out.SendMessage("Target is not in view.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    }

                    player.Out.SendObjectUpdate(myTarget);
                }

                if (player.IsPraying)
                {
                    GameGravestone gravestone = myTarget as GameGravestone;
                    if (gravestone == null || !gravestone.InternalID.Equals(player.InternalID))
                    {
                        player.Out.SendMessage("You are no longer targetting your grave. Your prayers fail.", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        player.PrayTimerStop();
                    }
                }
            }
        }


    }
}


#endregion
