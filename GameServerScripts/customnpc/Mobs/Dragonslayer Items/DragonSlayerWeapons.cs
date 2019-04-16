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
 * The authors of this script retains their own copyright and simply grant a
 * licence to use the code according to GPL version 2.
 * No one but copyright holders has permission to change the licence.
 *
 * Modifying GPLed code without releasing the changes is a violation of
 * the software licence. Improper use of GPL-based code may also be a violation
 * of US federal securities law.
 *
 * Anyone who attemp to claim modified GPL software as proprietary are breaking
 * the federal statute
 * ===========================================================================
 * Script by Fooljam - Utopia's server packs (DOL 1.5+) and shard daddy.
 * Date : June 2006
 * For DOL version : 1.7
 * Notes :
 * - This script will create all the Dragonslayers weapons (141 items in a few seconds : Yeah!!!)
 * Once the items have been created, you can disable this script.
 * The items have all the official stats but you will need to create the procs if you want them.
 * This script took me several weeks and I killed my eyes to read and correct all the stats.
 * I like the portability of my scripts, you change your DOL source code to another, 
 * you do not need to play with your item database...
 * ===========================================================================
 * For DOL version : 1.9
 * Updated by Dams
 * Date : May 2007
 * Notes : Procs and charges Added. Optimised for fast server boot.
 * ================================================================================================
 * ================================================================================================
 * Updated by Deathwish.
 * Date: 10/03/2010
 * Fixed:   all 2handed weapons (All 2handed weapons cant be used as a onehanded weapon anymore and damage should be right).
 *          all weapons that can be used in the left hand have been set and damage should right now.
 *          Items models
 *          Damage types, and set all bows to natural.
 *          All weapons should be right model, hand, type, and object type with the right damage.
 * Added:   Minstrel and Bard Harp.
 * Added:   Minstrel and Bard Harp to merchantitems
 * All items use same Id_nb, so if you using a older version of this script, replace this script for the old one and reboot server, then change line 72 col 56 true to false 
 * All Weapons are now set to 25 Silver = 2500 BPs on merchants.
 * 
 * If you want to use the badges merchant, do a find and replace (Ctrl H) Then in the Find what put: Silver = 25   Replace With; Copper = 25
 * 1 copper = 1 badge. soo 100 badges per item would be 100 copper or 1 silver. 150 badges = 150 copper or 1 silver 50 copper
 * 
 * ============================================================================================================================
 * 
 * Updated By Deathwish
 * Date: 14/07/2010
 * Fixed For the new Svn changes, eg Prices etc.
 * 
 * Info on how the pricing works:
 * (Price = 1) = (1 Bps and 1 Badge)
 */

using System;
using DOL.Events;
using DOL.GS.PacketHandler;
using System.Collections;
using DOL.GS.Scripts;
using DOL.GS;
using DOL.Database;
using DOL.Database.Attributes;
using DOL.GS.GameEvents;
using log4net;

namespace DOL.GS.Items
{
    public class DragonslayerWeapons
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private const bool RESET_DRAGONSLAYERWEAPONS = false; // Set to true at first server boot to reset weapons, 
        // then set it to false before next boot.

        #region Albion Dragonslayer Weapons
        public static ItemTemplate ArmsmanDragonslayerBlade = null;
        public static ItemTemplate ArmsmanDragonslayerEdge = null;
        public static ItemTemplate ArmsmanDragonslayerMace = null;
        public static ItemTemplate ArmsmanDragonslayerArchMace = null;
        public static ItemTemplate ArmsmanDragonslayerFlamberge = null;
        public static ItemTemplate ArmsmanDragonslayerHalberd = null;
        public static ItemTemplate ArmsmanDragonslayerLance = null;
        public static ItemTemplate ArmsmanDragonslayerMattock = null;
        public static ItemTemplate ArmsmanDragonslayerPike = null;
        public static ItemTemplate ClericDragonslayerMace = null;
        public static ItemTemplate FriarDragonslayerMace = null;
        public static ItemTemplate FriarDragonslayerQuarterStaff = null;
        public static ItemTemplate HereticDragonslayerBarbedChain = null;
        public static ItemTemplate HereticDragonslayerFlail = null;
        public static ItemTemplate HereticDragonslayerMace = null;
        public static ItemTemplate InfiltratorDragonslayerBlade = null;
        public static ItemTemplate InfiltratorDragonslayerEdge = null;
        public static ItemTemplate InfiltratorDragonslayerLaevusBlade = null;
        public static ItemTemplate InfiltratorDragonslayerLaevusEdge = null;
        public static ItemTemplate MercenaryDragonslayerBlade = null;
        public static ItemTemplate MercenaryDragonslayerEdge = null;
        public static ItemTemplate MercenaryDragonslayerMace = null;
        public static ItemTemplate MercenaryDragonslayerLaevusBlade = null;
        public static ItemTemplate MercenaryDragonslayerLaevusEdge = null;
        public static ItemTemplate MercenaryDragonslayerLaevusMace = null;
        public static ItemTemplate MinstrelDragonslayerBlade = null;
        public static ItemTemplate MinstrelDragonslayerEdge = null;
        public static ItemTemplate MinstrelDragonslayerHarp = null;
        public static ItemTemplate PaladinDragonslayerBlade = null;
        public static ItemTemplate PaladinDragonslayerEdge = null;
        public static ItemTemplate PaladinDragonslayerMace = null;
        public static ItemTemplate PaladinDragonslayerGreatEdge = null;
        public static ItemTemplate PaladinDragonslayerGreatHammer = null;
        public static ItemTemplate PaladinDragonslayerGreatSword = null;
        public static ItemTemplate ReaverDragonslayerBarbedChain = null;
        public static ItemTemplate ReaverDragonslayerBlade = null;
        public static ItemTemplate ReaverDragonslayerEdge = null;
        public static ItemTemplate ReaverDragonslayerFlail = null;
        public static ItemTemplate ReaverDragonslayerMace = null;
        public static ItemTemplate ScoutDragonslayerBlade = null;
        public static ItemTemplate ScoutDragonslayerBow = null;
        public static ItemTemplate ScoutDragonslayerEdge = null;
        public static ItemTemplate DragonslayerCabalistStaff = null;
        public static ItemTemplate DragonslayerNecromancerStaff = null;
        public static ItemTemplate DragonslayerSorcererStaff = null;
        public static ItemTemplate DragonslayerTheurgistStaff = null;
        public static ItemTemplate DragonslayerWizardStaff = null;
        #endregion Albion Dragonslayer Weapons

        #region Hibernia Dragonslayer Weapons
        public static ItemTemplate DragonslayerAnimistStaff = null;
        public static ItemTemplate DragonslayerBainsheeStaff = null;
        public static ItemTemplate DragonslayerEldritchStaff = null;
        public static ItemTemplate DragonslayerEnchanterStaff = null;
        public static ItemTemplate DragonslayerMentalistStaff = null;
        public static ItemTemplate DragonslayerBardHarp = null;
        public static ItemTemplate BlademasterDragonslayerFuarBlade = null;
        public static ItemTemplate BlademasterDragonslayerFuarHammer = null;
        public static ItemTemplate BlademasterDragonslayerFuarSteel = null;
        public static ItemTemplate DragonslayerBardBlade = null;
        public static ItemTemplate DragonslayerBardHammer = null;
        public static ItemTemplate DragonslayerBlademasterBlade = null;
        public static ItemTemplate DragonslayerBlademasterHammer = null;
        public static ItemTemplate DragonslayerBlademasterSteel = null;
        public static ItemTemplate DragonslayerChampionBlade = null;
        public static ItemTemplate DragonslayerChampionHammer = null;
        public static ItemTemplate DragonslayerChampionSteel = null;
        public static ItemTemplate DragonslayerChampionWarblade = null;
        public static ItemTemplate DragonslayerChampionWarhammer = null;
        public static ItemTemplate DragonslayerDruidBlade = null;
        public static ItemTemplate DragonslayerDruidHammer = null;
        public static ItemTemplate DragonslayerHeroBlade = null;
        public static ItemTemplate DragonslayerHeroHammer = null;
        public static ItemTemplate DragonslayerHeroSpear = null;
        public static ItemTemplate DragonslayerHeroSteel = null;
        public static ItemTemplate DragonslayerHeroWarblade = null;
        public static ItemTemplate DragonslayerHeroWarhammer = null;
        public static ItemTemplate DragonslayerNightshadeBlade = null;
        public static ItemTemplate DragonslayerNightshadeSteel = null;
        public static ItemTemplate DragonslayerRangerBlade = null;
        public static ItemTemplate DragonslayerRangerSteel = null;
        public static ItemTemplate DragonslayerRecurveBow = null;
        public static ItemTemplate DragonslayerValewalkerScythe = null;
        public static ItemTemplate DragonslayerWardenBlade = null;
        public static ItemTemplate DragonslayerWardenHammer = null;
        public static ItemTemplate NightshadeDragonslayerFuarBlade = null;
        public static ItemTemplate NightshadeDragonslayerFuarSteel = null;
        public static ItemTemplate RangerDragonslayerFuarBlade = null;
        public static ItemTemplate RangerDragonslayerFuarSteel = null;
        public static ItemTemplate VampiirDragonslayerFuarSteel = null;
        #endregion Hibernia Dragonslayer Weapons

        #region Midgard Dragonslayer Weapons
        public static ItemTemplate DragonslayerBonedancerStaff = null;
        public static ItemTemplate DragonslayerHealerTwohandedHammer = null;
        public static ItemTemplate DragonslayerHealerHammer = null;
        public static ItemTemplate DragonslayerRunemasterStaff = null;
        public static ItemTemplate DragonslayerShamanHammer = null;
        public static ItemTemplate DragonslayerShamanTwohandedHammer = null;
        public static ItemTemplate DragonslayerSpiritmasterStaff = null;
        public static ItemTemplate DragonslayerWarlockStaff = null;
        public static ItemTemplate DragonslayerBerserkerAxelh = null;
        public static ItemTemplate DragonslayerBerserkerAxerh = null;
        public static ItemTemplate DragonslayerBerserkerHammer = null;
        public static ItemTemplate DragonslayerBerserkerSword = null;
        public static ItemTemplate DragonslayerBerserkerTwohandedAxe = null;
        public static ItemTemplate DragonslayerBerserkerTwohandedHammer = null;
        public static ItemTemplate DragonslayerBerserkerTwohandedSword = null;
        public static ItemTemplate DragonslayerCompoundBow = null;
        public static ItemTemplate DragonslayerHunterSlashingSpear = null;
        public static ItemTemplate DragonslayerHunterSpear = null;
        public static ItemTemplate DragonslayerHunterSword = null;
        public static ItemTemplate DragonslayerHunterTwohandedSword = null;
        public static ItemTemplate DragonslayerSavageAxe = null;
        public static ItemTemplate DragonslayerSavageHammer = null;
        public static ItemTemplate DragonslayerSavageSlashingGlaiverh = null;
        public static ItemTemplate DragonslayerSavageSlashingGlaivelh = null;
        public static ItemTemplate DragonslayerSavageSword = null;
        public static ItemTemplate DragonslayerSavageThrashingGlaiverh = null;
        public static ItemTemplate DragonslayerSavageThrashingGlaivelh = null;
        public static ItemTemplate DragonslayerSavageTwohandedAxe = null;
        public static ItemTemplate DragonslayerSavageTwohandedHammer = null;
        public static ItemTemplate DragonslayerSavageTwohandedSword = null;
        public static ItemTemplate DragonslayerShadowbladeAxe = null;
        public static ItemTemplate DragonslayerShadowbladeHeavyAxe = null;
        public static ItemTemplate DragonslayerShadowbladeHeavyAxe2 = null;
        public static ItemTemplate DragonslayerShadowbladeHeavySword = null;
        public static ItemTemplate DragonslayerShadowbladeSword = null;
        public static ItemTemplate DragonslayerSkaldAxe = null;
        public static ItemTemplate DragonslayerSkaldHammer = null;
        public static ItemTemplate DragonslayerSkaldSword = null;
        public static ItemTemplate DragonslayerSkaldTwohandedAxe = null;
        public static ItemTemplate DragonslayerSkaldTwohandedHammer = null;
        public static ItemTemplate DragonslayerSkaldTwohandedSword = null;
        public static ItemTemplate DragonslayerThaneAxe = null;
        public static ItemTemplate DragonslayerThaneHammer = null;
        public static ItemTemplate DragonslayerThaneSword = null;
        public static ItemTemplate DragonslayerThaneTwohandedAxe = null;
        public static ItemTemplate DragonslayerThaneTwohandedHammer = null;
        public static ItemTemplate DragonslayerThaneTwohandedSword = null;
        public static ItemTemplate DragonslayerValkyrieSlashingSpear = null;
        public static ItemTemplate DragonslayerValkyrieSword = null;
        public static ItemTemplate DragonslayerValkyrieThrustingSpear = null;
        public static ItemTemplate DragonslayerValkyrieTwohandedSword = null;
        public static ItemTemplate DragonslayerWarriorAxe = null;
        public static ItemTemplate DragonslayerWarriorHammer = null;
        public static ItemTemplate DragonslayerWarriorSword = null;
        public static ItemTemplate DragonslayerWarriorTwohandedAxe = null;
        public static ItemTemplate DragonslayerWarriorTwohandedHammer = null;
        public static ItemTemplate DragonslayerWarriorTwohandedSword = null;
        #endregion Midgard Dragonslayer Weapons
        public static ItemTemplate dragonswornbadge = null;

        [ScriptLoadedEvent]
        public static void OnScriptCompiled(DOLEvent e, object sender, EventArgs args)
        {
            try
            {
                log.Info("Dragonslayer weapons initializing ...");

                #region ALBION
                ArmsmanDragonslayerBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDragonslayerBlade");
                ArmsmanDragonslayerEdge = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDragonslayerEdge");
                ArmsmanDragonslayerMace = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDragonslayerMace");
                ArmsmanDragonslayerArchMace = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDragonslayerArchMace");
                ArmsmanDragonslayerFlamberge = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDragonslayerFlamberge");
                ArmsmanDragonslayerHalberd = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDragonslayerHalberd");
                ArmsmanDragonslayerLance = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDragonslayerLance");
                ArmsmanDragonslayerPike = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDragonslayerPike");
                ArmsmanDragonslayerMattock = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDragonslayerMattock");
                FriarDragonslayerQuarterStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("FriarDragonslayerQuarterStaff");
                FriarDragonslayerMace = GameServer.Database.FindObjectByKey<ItemTemplate>("FriarDragonslayerMace");
                DragonslayerCabalistStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerCabalistStaff");
                DragonslayerNecromancerStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerNecromancerStaff");
                DragonslayerSorcererStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSorcererStaff");
                DragonslayerTheurgistStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerTheurgistStaff");
                DragonslayerWizardStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerWizardStaff");
                ClericDragonslayerMace = GameServer.Database.FindObjectByKey<ItemTemplate>("ClericDragonslayerMace");
                HereticDragonslayerBarbedChain = GameServer.Database.FindObjectByKey<ItemTemplate>("HereticDragonslayerBarbedChain");
                HereticDragonslayerFlail = GameServer.Database.FindObjectByKey<ItemTemplate>("HereticDragonslayerFlail");
                HereticDragonslayerMace = GameServer.Database.FindObjectByKey<ItemTemplate>("HereticDragonslayerMace");
                ReaverDragonslayerBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("ReaverDragonslayerBlade");
                ReaverDragonslayerEdge = GameServer.Database.FindObjectByKey<ItemTemplate>("ReaverDragonslayerEdge");
                ReaverDragonslayerMace = GameServer.Database.FindObjectByKey<ItemTemplate>("ReaverDragonslayerMace");
                ReaverDragonslayerBarbedChain = GameServer.Database.FindObjectByKey<ItemTemplate>("ReaverDragonslayerBarbedChain");
                ReaverDragonslayerFlail = GameServer.Database.FindObjectByKey<ItemTemplate>("ReaverDragonslayerFlail");
                PaladinDragonslayerBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinDragonslayerBlade");
                PaladinDragonslayerEdge = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinDragonslayerEdge");
                PaladinDragonslayerMace = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinDragonslayerMace");
                PaladinDragonslayerGreatEdge = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinDragonslayerGreatEdge");
                PaladinDragonslayerGreatHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinDragonslayerGreatHammer");
                PaladinDragonslayerGreatSword = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinDragonslayerGreatSword");
                ScoutDragonslayerBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("ScoutDragonslayerBlade");
                ScoutDragonslayerBow = GameServer.Database.FindObjectByKey<ItemTemplate>("ScoutDragonslayerBow");
                ScoutDragonslayerEdge = GameServer.Database.FindObjectByKey<ItemTemplate>("ScoutDragonslayerEdge");
                MinstrelDragonslayerEdge = GameServer.Database.FindObjectByKey<ItemTemplate>("MinstrelDragonslayerEdge");
                MinstrelDragonslayerBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("MinstrelDragonslayerBlade");
                MinstrelDragonslayerHarp = GameServer.Database.FindObjectByKey<ItemTemplate>("MinstrelDragonslayerHarp");
                MercenaryDragonslayerLaevusMace = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryDragonslayerLaevusMace");
                MercenaryDragonslayerLaevusEdge = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryDragonslayerLaevusEdge");
                MercenaryDragonslayerLaevusBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryDragonslayerLaevusBlade");
                MercenaryDragonslayerMace = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryDragonslayerMace");
                MercenaryDragonslayerEdge = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryDragonslayerEdge");
                MercenaryDragonslayerBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryDragonslayerBlade");
                InfiltratorDragonslayerBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("InfiltratorDragonslayerBlade");
                InfiltratorDragonslayerEdge = GameServer.Database.FindObjectByKey<ItemTemplate>("InfiltratorDragonslayerEdge");
                InfiltratorDragonslayerLaevusBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("InfiltratorDragonslayerLaevusBlade");
                InfiltratorDragonslayerLaevusEdge = GameServer.Database.FindObjectByKey<ItemTemplate>("InfiltratorDragonslayerLaevusEdge");
                #endregion
                #region MIDGARD
                DragonslayerBonedancerStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBonedancerStaff");
                DragonslayerRunemasterStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerRunemasterStaff");
                DragonslayerSpiritmasterStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSpiritmasterStaff");
                DragonslayerWarlockStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerWarlockStaff");
                DragonslayerWarriorAxe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerWarriorAxe");
                DragonslayerWarriorTwohandedAxe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerWarriorTwohandedAxe");
                DragonslayerWarriorSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerWarriorSword");
                DragonslayerWarriorTwohandedSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerWarriorTwohandedSword");
                DragonslayerWarriorHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerWarriorHammer");
                DragonslayerWarriorTwohandedHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerWarriorTwohandedHammer");
                DragonslayerValkyrieSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerValkyrieSword");
                DragonslayerValkyrieTwohandedSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerValkyrieTwohandedSword");
                DragonslayerValkyrieSlashingSpear = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerValkyrieSlashingSpear");
                DragonslayerValkyrieThrustingSpear = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerValkyrieThrustingSpear");
                DragonslayerHealerHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHealerHammer");
                DragonslayerHealerTwohandedHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHealerTwohandedHammer");
                DragonslayerShamanHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerShamanHammer");
                DragonslayerShamanTwohandedHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerShamanTwohandedHammer");
                DragonslayerBerserkerAxelh = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBerserkerAxelh");
                DragonslayerBerserkerAxerh = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBerserkerAxerh");
                DragonslayerBerserkerHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBerserkerHammer");
                DragonslayerBerserkerSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBerserkerSword");
                DragonslayerBerserkerTwohandedAxe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBerserkerTwohandedAxe");
                DragonslayerBerserkerTwohandedHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBerserkerTwohandedHammer");
                DragonslayerBerserkerTwohandedSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBerserkerTwohandedSword");
                DragonslayerCompoundBow = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerCompoundBow");
                DragonslayerHunterSlashingSpear = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHunterSlashingSpear");
                DragonslayerHunterSpear = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHunterSpear");
                DragonslayerHunterSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHunterSword");
                DragonslayerHunterTwohandedSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHunterTwohandedSword");
                DragonslayerSavageAxe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSavageAxe");
                DragonslayerSavageHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSavageHammer");
                DragonslayerSavageSlashingGlaiverh = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSavageSlashingGlaiverh");
                DragonslayerSavageSlashingGlaivelh = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSavageSlashingGlaivelh");
                DragonslayerSavageSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSavageSword");
                DragonslayerSavageThrashingGlaiverh = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSavageThrashingGlaiverh");
                DragonslayerSavageThrashingGlaivelh = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSavageThrashingGlaivelh");
                DragonslayerSavageTwohandedAxe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSavageTwohandedAxe");
                DragonslayerSavageTwohandedHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSavageTwohandedHammer");
                DragonslayerSavageTwohandedSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSavageTwohandedSword");
                DragonslayerShadowbladeAxe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerShadowbladeAxe");
                DragonslayerShadowbladeHeavyAxe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerShadowbladeHeavyAxe");
                DragonslayerShadowbladeHeavyAxe2 = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerShadowbladeHeavyAxe2");
                DragonslayerShadowbladeHeavySword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerShadowbladeHeavySword");
                DragonslayerShadowbladeSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerShadowbladeSword");
                DragonslayerSkaldAxe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSkaldAxe");
                DragonslayerSkaldHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSkaldHammer");
                DragonslayerSkaldSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSkaldSword");
                DragonslayerSkaldTwohandedAxe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSkaldTwohandedAxe");
                DragonslayerSkaldTwohandedHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSkaldTwohandedHammer");
                DragonslayerSkaldTwohandedSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerSkaldTwohandedSword");
                DragonslayerThaneAxe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerThaneAxe");
                DragonslayerThaneHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerThaneHammer");
                DragonslayerThaneSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerThaneSword");
                DragonslayerThaneTwohandedAxe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerThaneTwohandedAxe");
                DragonslayerThaneTwohandedHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerThaneTwohandedHammer");
                DragonslayerThaneTwohandedSword = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerThaneTwohandedSword");
                #endregion
                #region HIBERNIA
                DragonslayerAnimistStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerAnimistStaff");
                DragonslayerBainsheeStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBainsheeStaff");
                DragonslayerEldritchStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerEldritchStaff");
                DragonslayerEnchanterStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerEnchanterStaff");
                DragonslayerMentalistStaff = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerMentalistStaff");
                DragonslayerValewalkerScythe = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerValewalkerScythe");
                VampiirDragonslayerFuarSteel = GameServer.Database.FindObjectByKey<ItemTemplate>("VampiirDragonslayerFuarSteel");
                DragonslayerBardHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBardHammer");
                DragonslayerBardBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBardBlade");
                DragonslayerBardHarp = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBardHarp");
                DragonslayerDruidBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerDruidBlade");
                DragonslayerDruidHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerDruidHammer");
                DragonslayerWardenBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerWardenBlade");
                DragonslayerWardenHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerWardenHammer");
                BlademasterDragonslayerFuarBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("BlademasterDragonslayerFuarBlade");
                BlademasterDragonslayerFuarHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("BlademasterDragonslayerFuarHammer");
                BlademasterDragonslayerFuarSteel = GameServer.Database.FindObjectByKey<ItemTemplate>("BlademasterDragonslayerFuarSteel");
                DragonslayerBlademasterBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBlademasterBlade");
                DragonslayerBlademasterHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBlademasterHammer");
                DragonslayerBlademasterSteel = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerBlademasterSteel");
                DragonslayerChampionBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerChampionBlade");
                DragonslayerChampionHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerChampionHammer");
                DragonslayerChampionSteel = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerChampionSteel");
                DragonslayerChampionWarblade = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerChampionWarblade");
                DragonslayerChampionWarhammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerChampionWarhammer");
                DragonslayerHeroBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHeroBlade");
                DragonslayerHeroHammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHeroHammer");
                DragonslayerHeroSpear = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHeroSpear");
                DragonslayerHeroSteel = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHeroSteel");
                DragonslayerHeroWarblade = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHeroWarblade");
                DragonslayerHeroWarhammer = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerHeroWarhammer");
                DragonslayerNightshadeBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerNightshadeBlade");
                DragonslayerNightshadeSteel = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerNightshadeSteel");
                DragonslayerRangerBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerRangerBlade");
                DragonslayerRangerSteel = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerRangerSteel");
                DragonslayerRecurveBow = GameServer.Database.FindObjectByKey<ItemTemplate>("DragonslayerRecurveBow");
                NightshadeDragonslayerFuarBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("NightshadeDragonslayerFuarBlade");
                NightshadeDragonslayerFuarSteel = GameServer.Database.FindObjectByKey<ItemTemplate>("NightshadeDragonslayerFuarSteel");
                RangerDragonslayerFuarBlade = GameServer.Database.FindObjectByKey<ItemTemplate>("RangerDragonslayerFuarBlade");
                RangerDragonslayerFuarSteel = GameServer.Database.FindObjectByKey<ItemTemplate>("RangerDragonslayerFuarSteel");
                dragonswornbadge = GameServer.Database.FindObjectByKey<ItemTemplate>("dragonswornbadge");
                #endregion
                #region Reset
                if (RESET_DRAGONSLAYERWEAPONS)
                {
                    if (ArmsmanDragonslayerBlade != null) GameServer.Database.DeleteObject(ArmsmanDragonslayerBlade); ArmsmanDragonslayerBlade = null;
                    if (ArmsmanDragonslayerEdge != null) GameServer.Database.DeleteObject(ArmsmanDragonslayerEdge); ArmsmanDragonslayerEdge = null;
                    if (ArmsmanDragonslayerMace != null) GameServer.Database.DeleteObject(ArmsmanDragonslayerMace); ArmsmanDragonslayerMace = null;
                    if (ArmsmanDragonslayerArchMace != null) GameServer.Database.DeleteObject(ArmsmanDragonslayerArchMace); ArmsmanDragonslayerArchMace = null;
                    if (ArmsmanDragonslayerFlamberge != null) GameServer.Database.DeleteObject(ArmsmanDragonslayerFlamberge); ArmsmanDragonslayerFlamberge = null;
                    if (ArmsmanDragonslayerHalberd != null) GameServer.Database.DeleteObject(ArmsmanDragonslayerHalberd); ArmsmanDragonslayerHalberd = null;
                    if (ArmsmanDragonslayerLance != null) GameServer.Database.DeleteObject(ArmsmanDragonslayerLance); ArmsmanDragonslayerLance = null;
                    if (ArmsmanDragonslayerMattock != null) GameServer.Database.DeleteObject(ArmsmanDragonslayerMattock); ArmsmanDragonslayerMattock = null;
                    if (ArmsmanDragonslayerPike != null) GameServer.Database.DeleteObject(ArmsmanDragonslayerPike); ArmsmanDragonslayerPike = null;
                    if (ClericDragonslayerMace != null) GameServer.Database.DeleteObject(ClericDragonslayerMace); ClericDragonslayerMace = null;
                    if (FriarDragonslayerMace != null) GameServer.Database.DeleteObject(FriarDragonslayerMace); FriarDragonslayerMace = null;
                    if (FriarDragonslayerQuarterStaff != null) GameServer.Database.DeleteObject(FriarDragonslayerQuarterStaff); FriarDragonslayerQuarterStaff = null;
                    if (HereticDragonslayerBarbedChain != null) GameServer.Database.DeleteObject(HereticDragonslayerBarbedChain); HereticDragonslayerBarbedChain = null;
                    if (HereticDragonslayerFlail != null) GameServer.Database.DeleteObject(HereticDragonslayerFlail); HereticDragonslayerFlail = null;
                    if (HereticDragonslayerMace != null) GameServer.Database.DeleteObject(HereticDragonslayerMace); HereticDragonslayerMace = null;
                    if (InfiltratorDragonslayerBlade != null) GameServer.Database.DeleteObject(InfiltratorDragonslayerBlade); InfiltratorDragonslayerBlade = null;
                    if (InfiltratorDragonslayerEdge != null) GameServer.Database.DeleteObject(InfiltratorDragonslayerEdge); InfiltratorDragonslayerEdge = null;
                    if (InfiltratorDragonslayerLaevusBlade != null) GameServer.Database.DeleteObject(InfiltratorDragonslayerLaevusBlade); InfiltratorDragonslayerLaevusBlade = null;
                    if (InfiltratorDragonslayerLaevusEdge != null) GameServer.Database.DeleteObject(InfiltratorDragonslayerLaevusEdge); InfiltratorDragonslayerLaevusEdge = null;
                    if (MercenaryDragonslayerBlade != null) GameServer.Database.DeleteObject(MercenaryDragonslayerBlade); MercenaryDragonslayerBlade = null;
                    if (MercenaryDragonslayerEdge != null) GameServer.Database.DeleteObject(MercenaryDragonslayerEdge); MercenaryDragonslayerEdge = null;
                    if (MercenaryDragonslayerMace != null) GameServer.Database.DeleteObject(MercenaryDragonslayerMace); MercenaryDragonslayerMace = null;
                    if (MercenaryDragonslayerLaevusBlade != null) GameServer.Database.DeleteObject(MercenaryDragonslayerLaevusBlade); MercenaryDragonslayerLaevusBlade = null;
                    if (MercenaryDragonslayerLaevusEdge != null) GameServer.Database.DeleteObject(MercenaryDragonslayerLaevusEdge); MercenaryDragonslayerLaevusEdge = null;
                    if (MercenaryDragonslayerLaevusMace != null) GameServer.Database.DeleteObject(MercenaryDragonslayerLaevusMace); MercenaryDragonslayerLaevusMace = null;
                    if (MinstrelDragonslayerBlade != null) GameServer.Database.DeleteObject(MinstrelDragonslayerBlade); MinstrelDragonslayerBlade = null;
                    if (MinstrelDragonslayerEdge != null) GameServer.Database.DeleteObject(MinstrelDragonslayerEdge); MinstrelDragonslayerEdge = null;
                    if (MinstrelDragonslayerHarp != null) GameServer.Database.DeleteObject(MinstrelDragonslayerHarp); MinstrelDragonslayerHarp = null;
                    if (PaladinDragonslayerBlade != null) GameServer.Database.DeleteObject(PaladinDragonslayerBlade); PaladinDragonslayerBlade = null;
                    if (PaladinDragonslayerEdge != null) GameServer.Database.DeleteObject(PaladinDragonslayerEdge); PaladinDragonslayerEdge = null;
                    if (PaladinDragonslayerMace != null) GameServer.Database.DeleteObject(PaladinDragonslayerMace); PaladinDragonslayerMace = null;
                    if (PaladinDragonslayerGreatEdge != null) GameServer.Database.DeleteObject(PaladinDragonslayerGreatEdge); PaladinDragonslayerGreatEdge = null;
                    if (PaladinDragonslayerGreatHammer != null) GameServer.Database.DeleteObject(PaladinDragonslayerGreatHammer); PaladinDragonslayerGreatHammer = null;
                    if (PaladinDragonslayerGreatSword != null) GameServer.Database.DeleteObject(PaladinDragonslayerGreatSword); PaladinDragonslayerGreatSword = null;
                    if (ReaverDragonslayerBarbedChain != null) GameServer.Database.DeleteObject(ReaverDragonslayerBarbedChain); ReaverDragonslayerBarbedChain = null;
                    if (ReaverDragonslayerBlade != null) GameServer.Database.DeleteObject(ReaverDragonslayerBlade); ReaverDragonslayerBlade = null;
                    if (ReaverDragonslayerEdge != null) GameServer.Database.DeleteObject(ReaverDragonslayerEdge); ReaverDragonslayerEdge = null;
                    if (ReaverDragonslayerFlail != null) GameServer.Database.DeleteObject(ReaverDragonslayerFlail); ReaverDragonslayerFlail = null;
                    if (ReaverDragonslayerMace != null) GameServer.Database.DeleteObject(ReaverDragonslayerMace); ReaverDragonslayerMace = null;
                    if (ScoutDragonslayerBlade != null) GameServer.Database.DeleteObject(ScoutDragonslayerBlade); ScoutDragonslayerBlade = null;
                    if (ScoutDragonslayerBow != null) GameServer.Database.DeleteObject(ScoutDragonslayerBow); ScoutDragonslayerBow = null;
                    if (ScoutDragonslayerEdge != null) GameServer.Database.DeleteObject(ScoutDragonslayerEdge); ScoutDragonslayerEdge = null;
                    if (DragonslayerCabalistStaff != null) GameServer.Database.DeleteObject(DragonslayerCabalistStaff); DragonslayerCabalistStaff = null;
                    if (DragonslayerNecromancerStaff != null) GameServer.Database.DeleteObject(DragonslayerNecromancerStaff); DragonslayerNecromancerStaff = null;
                    if (DragonslayerSorcererStaff != null) GameServer.Database.DeleteObject(DragonslayerSorcererStaff); DragonslayerSorcererStaff = null;
                    if (DragonslayerTheurgistStaff != null) GameServer.Database.DeleteObject(DragonslayerTheurgistStaff); DragonslayerTheurgistStaff = null;
                    if (DragonslayerWizardStaff != null) GameServer.Database.DeleteObject(DragonslayerWizardStaff); DragonslayerWizardStaff = null;
                    if (DragonslayerAnimistStaff != null) GameServer.Database.DeleteObject(DragonslayerAnimistStaff); DragonslayerAnimistStaff = null;
                    if (DragonslayerBainsheeStaff != null) GameServer.Database.DeleteObject(DragonslayerBainsheeStaff); DragonslayerBainsheeStaff = null;
                    if (DragonslayerEldritchStaff != null) GameServer.Database.DeleteObject(DragonslayerEldritchStaff); DragonslayerEldritchStaff = null;
                    if (DragonslayerEnchanterStaff != null) GameServer.Database.DeleteObject(DragonslayerEnchanterStaff); DragonslayerEnchanterStaff = null;
                    if (DragonslayerMentalistStaff != null) GameServer.Database.DeleteObject(DragonslayerMentalistStaff); DragonslayerMentalistStaff = null;
                    if (DragonslayerBardHarp != null) GameServer.Database.DeleteObject(DragonslayerBardHarp); DragonslayerBardHarp = null;
                    if (BlademasterDragonslayerFuarBlade != null) GameServer.Database.DeleteObject(BlademasterDragonslayerFuarBlade); BlademasterDragonslayerFuarBlade = null;
                    if (BlademasterDragonslayerFuarHammer != null) GameServer.Database.DeleteObject(BlademasterDragonslayerFuarHammer); BlademasterDragonslayerFuarHammer = null;
                    if (BlademasterDragonslayerFuarSteel != null) GameServer.Database.DeleteObject(BlademasterDragonslayerFuarSteel); BlademasterDragonslayerFuarSteel = null;
                    if (DragonslayerBardBlade != null) GameServer.Database.DeleteObject(DragonslayerBardBlade); DragonslayerBardBlade = null;
                    if (DragonslayerBardHammer != null) GameServer.Database.DeleteObject(DragonslayerBardHammer); DragonslayerBardHammer = null;
                    if (DragonslayerBlademasterBlade != null) GameServer.Database.DeleteObject(DragonslayerBlademasterBlade); DragonslayerBlademasterBlade = null;
                    if (DragonslayerBlademasterHammer != null) GameServer.Database.DeleteObject(DragonslayerBlademasterHammer); DragonslayerBlademasterHammer = null;
                    if (DragonslayerBlademasterSteel != null) GameServer.Database.DeleteObject(DragonslayerBlademasterSteel); DragonslayerBlademasterSteel = null;
                    if (DragonslayerChampionBlade != null) GameServer.Database.DeleteObject(DragonslayerChampionBlade); DragonslayerChampionBlade = null;
                    if (DragonslayerChampionHammer != null) GameServer.Database.DeleteObject(DragonslayerChampionHammer); DragonslayerChampionHammer = null;
                    if (DragonslayerChampionSteel != null) GameServer.Database.DeleteObject(DragonslayerChampionSteel); DragonslayerChampionSteel = null;
                    if (DragonslayerChampionWarblade != null) GameServer.Database.DeleteObject(DragonslayerChampionWarblade); DragonslayerChampionWarblade = null;
                    if (DragonslayerChampionWarhammer != null) GameServer.Database.DeleteObject(DragonslayerChampionWarhammer); DragonslayerChampionWarhammer = null;
                    if (DragonslayerDruidBlade != null) GameServer.Database.DeleteObject(DragonslayerDruidBlade); DragonslayerDruidBlade = null;
                    if (DragonslayerDruidHammer != null) GameServer.Database.DeleteObject(DragonslayerDruidHammer); DragonslayerDruidHammer = null;
                    if (DragonslayerHeroBlade != null) GameServer.Database.DeleteObject(DragonslayerHeroBlade); DragonslayerHeroBlade = null;
                    if (DragonslayerHeroHammer != null) GameServer.Database.DeleteObject(DragonslayerHeroHammer); DragonslayerHeroHammer = null;
                    if (DragonslayerHeroSpear != null) GameServer.Database.DeleteObject(DragonslayerHeroSpear); DragonslayerHeroSpear = null;
                    if (DragonslayerHeroSteel != null) GameServer.Database.DeleteObject(DragonslayerHeroSteel); DragonslayerHeroSteel = null;
                    if (DragonslayerHeroWarblade != null) GameServer.Database.DeleteObject(DragonslayerHeroWarblade); DragonslayerHeroWarblade = null;
                    if (DragonslayerHeroWarhammer != null) GameServer.Database.DeleteObject(DragonslayerHeroWarhammer); DragonslayerHeroWarhammer = null;
                    if (DragonslayerNightshadeBlade != null) GameServer.Database.DeleteObject(DragonslayerNightshadeBlade); DragonslayerNightshadeBlade = null;
                    if (DragonslayerNightshadeSteel != null) GameServer.Database.DeleteObject(DragonslayerNightshadeSteel); DragonslayerNightshadeSteel = null;
                    if (DragonslayerRangerBlade != null) GameServer.Database.DeleteObject(DragonslayerRangerBlade); DragonslayerRangerBlade = null;
                    if (DragonslayerRangerSteel != null) GameServer.Database.DeleteObject(DragonslayerRangerSteel); DragonslayerRangerSteel = null;
                    if (DragonslayerRecurveBow != null) GameServer.Database.DeleteObject(DragonslayerRecurveBow); DragonslayerRecurveBow = null;
                    if (DragonslayerValewalkerScythe != null) GameServer.Database.DeleteObject(DragonslayerValewalkerScythe); DragonslayerValewalkerScythe = null;
                    if (DragonslayerWardenBlade != null) GameServer.Database.DeleteObject(DragonslayerWardenBlade); DragonslayerWardenBlade = null;
                    if (DragonslayerWardenHammer != null) GameServer.Database.DeleteObject(DragonslayerWardenHammer); DragonslayerWardenHammer = null;
                    if (NightshadeDragonslayerFuarBlade != null) GameServer.Database.DeleteObject(NightshadeDragonslayerFuarBlade); NightshadeDragonslayerFuarBlade = null;
                    if (NightshadeDragonslayerFuarSteel != null) GameServer.Database.DeleteObject(NightshadeDragonslayerFuarSteel); NightshadeDragonslayerFuarSteel = null;
                    if (RangerDragonslayerFuarBlade != null) GameServer.Database.DeleteObject(RangerDragonslayerFuarBlade); RangerDragonslayerFuarBlade = null;
                    if (RangerDragonslayerFuarSteel != null) GameServer.Database.DeleteObject(RangerDragonslayerFuarSteel); RangerDragonslayerFuarSteel = null;
                    if (VampiirDragonslayerFuarSteel != null) GameServer.Database.DeleteObject(VampiirDragonslayerFuarSteel); VampiirDragonslayerFuarSteel = null;
                    if (DragonslayerBonedancerStaff != null) GameServer.Database.DeleteObject(DragonslayerBonedancerStaff); DragonslayerBonedancerStaff = null;
                    if (DragonslayerHealerTwohandedHammer != null) GameServer.Database.DeleteObject(DragonslayerHealerTwohandedHammer); DragonslayerHealerTwohandedHammer = null;
                    if (DragonslayerHealerHammer != null) GameServer.Database.DeleteObject(DragonslayerHealerHammer); DragonslayerHealerHammer = null;
                    if (DragonslayerRunemasterStaff != null) GameServer.Database.DeleteObject(DragonslayerRunemasterStaff); DragonslayerRunemasterStaff = null;
                    if (DragonslayerShamanHammer != null) GameServer.Database.DeleteObject(DragonslayerShamanHammer); DragonslayerShamanHammer = null;
                    if (DragonslayerShamanTwohandedHammer != null) GameServer.Database.DeleteObject(DragonslayerShamanTwohandedHammer); DragonslayerShamanTwohandedHammer = null;
                    if (DragonslayerSpiritmasterStaff != null) GameServer.Database.DeleteObject(DragonslayerSpiritmasterStaff); DragonslayerSpiritmasterStaff = null;
                    if (DragonslayerWarlockStaff != null) GameServer.Database.DeleteObject(DragonslayerWarlockStaff); DragonslayerWarlockStaff = null;
                    if (DragonslayerBerserkerAxelh != null) GameServer.Database.DeleteObject(DragonslayerBerserkerAxelh); DragonslayerBerserkerAxelh = null;
                    if (DragonslayerBerserkerAxerh != null) GameServer.Database.DeleteObject(DragonslayerBerserkerAxerh); DragonslayerBerserkerAxerh = null;
                    if (DragonslayerBerserkerHammer != null) GameServer.Database.DeleteObject(DragonslayerBerserkerHammer); DragonslayerBerserkerHammer = null;
                    if (DragonslayerBerserkerSword != null) GameServer.Database.DeleteObject(DragonslayerBerserkerSword); DragonslayerBerserkerSword = null;
                    if (DragonslayerBerserkerTwohandedAxe != null) GameServer.Database.DeleteObject(DragonslayerBerserkerTwohandedAxe); DragonslayerBerserkerTwohandedAxe = null;
                    if (DragonslayerBerserkerTwohandedHammer != null) GameServer.Database.DeleteObject(DragonslayerBerserkerTwohandedHammer); DragonslayerBerserkerTwohandedHammer = null;
                    if (DragonslayerBerserkerTwohandedSword != null) GameServer.Database.DeleteObject(DragonslayerBerserkerTwohandedSword); DragonslayerBerserkerTwohandedSword = null;
                    if (DragonslayerCompoundBow != null) GameServer.Database.DeleteObject(DragonslayerCompoundBow); DragonslayerCompoundBow = null;
                    if (DragonslayerHunterSlashingSpear != null) GameServer.Database.DeleteObject(DragonslayerHunterSlashingSpear); DragonslayerHunterSlashingSpear = null;
                    if (DragonslayerHunterSpear != null) GameServer.Database.DeleteObject(DragonslayerHunterSpear); DragonslayerHunterSpear = null;
                    if (DragonslayerHunterSword != null) GameServer.Database.DeleteObject(DragonslayerHunterSword); DragonslayerHunterSword = null;
                    if (DragonslayerHunterTwohandedSword != null) GameServer.Database.DeleteObject(DragonslayerHunterTwohandedSword); DragonslayerHunterTwohandedSword = null;
                    if (DragonslayerSavageAxe != null) GameServer.Database.DeleteObject(DragonslayerSavageAxe); DragonslayerSavageAxe = null;
                    if (DragonslayerSavageHammer != null) GameServer.Database.DeleteObject(DragonslayerSavageHammer); DragonslayerSavageHammer = null;
                    if (DragonslayerSavageSlashingGlaiverh != null) GameServer.Database.DeleteObject(DragonslayerSavageSlashingGlaiverh); DragonslayerSavageSlashingGlaiverh = null;
                    if (DragonslayerSavageSlashingGlaivelh != null) GameServer.Database.DeleteObject(DragonslayerSavageSlashingGlaivelh); DragonslayerSavageSlashingGlaivelh = null;
                    if (DragonslayerSavageSword != null) GameServer.Database.DeleteObject(DragonslayerSavageSword); DragonslayerSavageSword = null;
                    if (DragonslayerSavageThrashingGlaiverh != null) GameServer.Database.DeleteObject(DragonslayerSavageThrashingGlaiverh); DragonslayerSavageThrashingGlaiverh = null;
                    if (DragonslayerSavageThrashingGlaivelh != null) GameServer.Database.DeleteObject(DragonslayerSavageThrashingGlaivelh); DragonslayerSavageThrashingGlaivelh = null;
                    if (DragonslayerSavageTwohandedAxe != null) GameServer.Database.DeleteObject(DragonslayerSavageTwohandedAxe); DragonslayerSavageTwohandedAxe = null;
                    if (DragonslayerSavageTwohandedHammer != null) GameServer.Database.DeleteObject(DragonslayerSavageTwohandedHammer); DragonslayerSavageTwohandedHammer = null;
                    if (DragonslayerSavageTwohandedSword != null) GameServer.Database.DeleteObject(DragonslayerSavageTwohandedSword); DragonslayerSavageTwohandedSword = null;
                    if (DragonslayerShadowbladeAxe != null) GameServer.Database.DeleteObject(DragonslayerShadowbladeAxe); DragonslayerShadowbladeAxe = null;
                    if (DragonslayerShadowbladeHeavyAxe != null) GameServer.Database.DeleteObject(DragonslayerShadowbladeHeavyAxe); DragonslayerShadowbladeHeavyAxe = null;
                    if (DragonslayerShadowbladeHeavyAxe2 != null) GameServer.Database.DeleteObject(DragonslayerShadowbladeHeavyAxe2); DragonslayerShadowbladeHeavyAxe2 = null;
                    if (DragonslayerShadowbladeHeavySword != null) GameServer.Database.DeleteObject(DragonslayerShadowbladeHeavySword); DragonslayerShadowbladeHeavySword = null;
                    if (DragonslayerShadowbladeSword != null) GameServer.Database.DeleteObject(DragonslayerShadowbladeSword); DragonslayerShadowbladeSword = null;
                    if (DragonslayerSkaldAxe != null) GameServer.Database.DeleteObject(DragonslayerSkaldAxe); DragonslayerSkaldAxe = null;
                    if (DragonslayerSkaldHammer != null) GameServer.Database.DeleteObject(DragonslayerSkaldHammer); DragonslayerSkaldHammer = null;
                    if (DragonslayerSkaldSword != null) GameServer.Database.DeleteObject(DragonslayerSkaldSword); DragonslayerSkaldSword = null;
                    if (DragonslayerSkaldTwohandedAxe != null) GameServer.Database.DeleteObject(DragonslayerSkaldTwohandedAxe); DragonslayerSkaldTwohandedAxe = null;
                    if (DragonslayerSkaldTwohandedHammer != null) GameServer.Database.DeleteObject(DragonslayerSkaldTwohandedHammer); DragonslayerSkaldTwohandedHammer = null;
                    if (DragonslayerSkaldTwohandedSword != null) GameServer.Database.DeleteObject(DragonslayerSkaldTwohandedSword); DragonslayerSkaldTwohandedSword = null;
                    if (DragonslayerThaneAxe != null) GameServer.Database.DeleteObject(DragonslayerThaneAxe); DragonslayerThaneAxe = null;
                    if (DragonslayerThaneHammer != null) GameServer.Database.DeleteObject(DragonslayerThaneHammer); DragonslayerThaneHammer = null;
                    if (DragonslayerThaneSword != null) GameServer.Database.DeleteObject(DragonslayerThaneSword); DragonslayerThaneSword = null;
                    if (DragonslayerThaneTwohandedAxe != null) GameServer.Database.DeleteObject(DragonslayerThaneTwohandedAxe); DragonslayerThaneTwohandedAxe = null;
                    if (DragonslayerThaneTwohandedHammer != null) GameServer.Database.DeleteObject(DragonslayerThaneTwohandedHammer); DragonslayerThaneTwohandedHammer = null;
                    if (DragonslayerThaneTwohandedSword != null) GameServer.Database.DeleteObject(DragonslayerThaneTwohandedSword); DragonslayerThaneTwohandedSword = null;
                    if (DragonslayerValkyrieSlashingSpear != null) GameServer.Database.DeleteObject(DragonslayerValkyrieSlashingSpear); DragonslayerValkyrieSlashingSpear = null;
                    if (DragonslayerValkyrieSword != null) GameServer.Database.DeleteObject(DragonslayerValkyrieSword); DragonslayerValkyrieSword = null;
                    if (DragonslayerValkyrieThrustingSpear != null) GameServer.Database.DeleteObject(DragonslayerValkyrieThrustingSpear); DragonslayerValkyrieThrustingSpear = null;
                    if (DragonslayerValkyrieTwohandedSword != null) GameServer.Database.DeleteObject(DragonslayerValkyrieTwohandedSword); DragonslayerValkyrieTwohandedSword = null;
                    if (DragonslayerWarriorAxe != null) GameServer.Database.DeleteObject(DragonslayerWarriorAxe); DragonslayerWarriorAxe = null;
                    if (DragonslayerWarriorHammer != null) GameServer.Database.DeleteObject(DragonslayerWarriorHammer); DragonslayerWarriorHammer = null;
                    if (DragonslayerWarriorSword != null) GameServer.Database.DeleteObject(DragonslayerWarriorSword); DragonslayerWarriorSword = null;
                    if (DragonslayerWarriorTwohandedAxe != null) GameServer.Database.DeleteObject(DragonslayerWarriorTwohandedAxe); DragonslayerWarriorTwohandedAxe = null;
                    if (DragonslayerWarriorTwohandedHammer != null) GameServer.Database.DeleteObject(DragonslayerWarriorTwohandedHammer); DragonslayerWarriorTwohandedHammer = null;
                    if (DragonslayerWarriorTwohandedSword != null) GameServer.Database.DeleteObject(DragonslayerWarriorTwohandedSword); DragonslayerWarriorTwohandedSword = null;
                    if (dragonswornbadge != null) GameServer.Database.DeleteObject(dragonswornbadge); dragonswornbadge = null;
                }
                #endregion
                #region DragonslayerWeapons
                if (ArmsmanDragonslayerBlade == null)
                {
                    ArmsmanDragonslayerBlade = new ItemTemplate();
                    ArmsmanDragonslayerBlade.Id_nb = "ArmsmanDragonslayerBlade";
                    ArmsmanDragonslayerBlade.Name = "Armsman Dragonslayer Blade";
                    ArmsmanDragonslayerBlade.Level = 51;
                    ArmsmanDragonslayerBlade.IsDropable = true;
                    ArmsmanDragonslayerBlade.IsPickable = true;
                    ArmsmanDragonslayerBlade.IsTradable = false;
                    ArmsmanDragonslayerBlade.Type_Damage = 2;
                    ArmsmanDragonslayerBlade.DPS_AF = 165;
                    ArmsmanDragonslayerBlade.SPD_ABS = 42;
                    ArmsmanDragonslayerBlade.Object_Type = 35;
                    ArmsmanDragonslayerBlade.Quality = 100;
                    ArmsmanDragonslayerBlade.Price = 3500;
                    ArmsmanDragonslayerBlade.Weight = 25;
                    ArmsmanDragonslayerBlade.Bonus = 35;
                    ArmsmanDragonslayerBlade.MaxCondition = 50000;
                    ArmsmanDragonslayerBlade.MaxDurability = 50000;
                    ArmsmanDragonslayerBlade.Condition = 50000;
                    ArmsmanDragonslayerBlade.Durability = 50000;
                    ArmsmanDragonslayerBlade.Object_Type = 3;
                    ArmsmanDragonslayerBlade.Item_Type = 10;
                    ArmsmanDragonslayerBlade.Model = 3972;
                    ArmsmanDragonslayerBlade.Bonus1Type = (int)eResist.Slash;
                    ArmsmanDragonslayerBlade.Bonus1 = 4;
                    ArmsmanDragonslayerBlade.Bonus2Type = (int)eStat.STR;
                    ArmsmanDragonslayerBlade.Bonus2 = 9;
                    ArmsmanDragonslayerBlade.Bonus3Type = (int)eStat.DEX;
                    ArmsmanDragonslayerBlade.Bonus3 = 9;
                    ArmsmanDragonslayerBlade.Bonus4Type = (int)eProperty.StyleDamage;
                    ArmsmanDragonslayerBlade.Bonus4 = 4;
                    ArmsmanDragonslayerBlade.Bonus5Type = (int)eProperty.MeleeDamage;
                    ArmsmanDragonslayerBlade.Bonus5 = 4;
                    ArmsmanDragonslayerBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    ArmsmanDragonslayerBlade.Bonus6 = 5;
                    ArmsmanDragonslayerBlade.Bonus7Type = (int)eProperty.DexCapBonus;
                    ArmsmanDragonslayerBlade.Bonus7 = 5;
                    ArmsmanDragonslayerBlade.SpellID = 32176;
                    ArmsmanDragonslayerBlade.Charges = 100;
                    ArmsmanDragonslayerBlade.MaxCharges = 100;
                    ArmsmanDragonslayerBlade.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ArmsmanDragonslayerBlade);
                }

                if (ArmsmanDragonslayerEdge == null)
                {
                    ArmsmanDragonslayerEdge = new ItemTemplate();
                    ArmsmanDragonslayerEdge.Id_nb = "ArmsmanDragonslayerEdge";
                    ArmsmanDragonslayerEdge.Name = "Armsman Dragonslayer Edge";
                    ArmsmanDragonslayerEdge.Level = 51;
                    ArmsmanDragonslayerEdge.Item_Type = 10;
                    ArmsmanDragonslayerEdge.Model = 3976;
                    ArmsmanDragonslayerEdge.IsDropable = true;
                    ArmsmanDragonslayerEdge.IsPickable = true;
                    ArmsmanDragonslayerEdge.Type_Damage = 3;
                    ArmsmanDragonslayerEdge.DPS_AF = 165;
                    ArmsmanDragonslayerEdge.SPD_ABS = 42;
                    ArmsmanDragonslayerEdge.Object_Type = 4;
                    ArmsmanDragonslayerEdge.Price = 3500;
                    ArmsmanDragonslayerEdge.Quality = 100;
                    ArmsmanDragonslayerEdge.IsTradable = false;
                    ArmsmanDragonslayerEdge.Weight = 25;
                    ArmsmanDragonslayerEdge.Bonus = 35;
                    ArmsmanDragonslayerEdge.MaxCondition = 50000;
                    ArmsmanDragonslayerEdge.MaxDurability = 50000;
                    ArmsmanDragonslayerEdge.Condition = 50000;
                    ArmsmanDragonslayerEdge.Durability = 50000;
                    ArmsmanDragonslayerEdge.Bonus1Type = (int)eResist.Thrust;
                    ArmsmanDragonslayerEdge.Bonus1 = 4;
                    ArmsmanDragonslayerEdge.Bonus2Type = (int)eStat.STR;
                    ArmsmanDragonslayerEdge.Bonus2 = 9;
                    ArmsmanDragonslayerEdge.Bonus3Type = (int)eStat.DEX;
                    ArmsmanDragonslayerEdge.Bonus3 = 9;
                    ArmsmanDragonslayerEdge.Bonus4Type = (int)eProperty.StyleDamage;
                    ArmsmanDragonslayerEdge.Bonus4 = 4;
                    ArmsmanDragonslayerEdge.Bonus5Type = (int)eProperty.MeleeDamage;
                    ArmsmanDragonslayerEdge.Bonus5 = 4;
                    ArmsmanDragonslayerEdge.Bonus6Type = (int)eProperty.StrCapBonus;
                    ArmsmanDragonslayerEdge.Bonus6 = 5;
                    ArmsmanDragonslayerEdge.Bonus7Type = (int)eProperty.DexCapBonus;
                    ArmsmanDragonslayerEdge.Bonus7 = 5;
                    ArmsmanDragonslayerEdge.SpellID = 32176;
                    ArmsmanDragonslayerEdge.Charges = 100;
                    ArmsmanDragonslayerEdge.MaxCharges = 100;
                    ArmsmanDragonslayerEdge.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ArmsmanDragonslayerEdge);
                }

                if (ArmsmanDragonslayerMace == null)
                {
                    ArmsmanDragonslayerMace = new ItemTemplate();
                    ArmsmanDragonslayerMace.Id_nb = "ArmsmanDragonslayerMace";
                    ArmsmanDragonslayerMace.Name = "Armsman Dragonslayer Mace";
                    ArmsmanDragonslayerMace.Level = 51;
                    ArmsmanDragonslayerMace.Item_Type = 10;
                    ArmsmanDragonslayerMace.Model = 3974;
                    ArmsmanDragonslayerMace.IsDropable = true;
                    ArmsmanDragonslayerMace.IsPickable = true;
                    ArmsmanDragonslayerMace.Type_Damage = 1;
                    ArmsmanDragonslayerMace.DPS_AF = 165;
                    ArmsmanDragonslayerMace.SPD_ABS = 42;
                    ArmsmanDragonslayerMace.Price = 3500;
                    ArmsmanDragonslayerMace.Object_Type = 2;
                    ArmsmanDragonslayerMace.Quality = 100;
                    ArmsmanDragonslayerMace.IsTradable = false;
                    ArmsmanDragonslayerMace.Weight = 25;
                    ArmsmanDragonslayerMace.Bonus = 35;
                    ArmsmanDragonslayerMace.MaxCondition = 50000;
                    ArmsmanDragonslayerMace.MaxDurability = 50000;
                    ArmsmanDragonslayerMace.Condition = 50000;
                    ArmsmanDragonslayerMace.Durability = 50000;
                    ArmsmanDragonslayerMace.Bonus1Type = (int)eResist.Crush;
                    ArmsmanDragonslayerMace.Bonus1 = 4;
                    ArmsmanDragonslayerMace.Bonus2Type = (int)eStat.STR;
                    ArmsmanDragonslayerMace.Bonus2 = 9;
                    ArmsmanDragonslayerMace.Bonus3Type = (int)eStat.DEX;
                    ArmsmanDragonslayerMace.Bonus3 = 9;
                    ArmsmanDragonslayerMace.Bonus4Type = (int)eProperty.StyleDamage;
                    ArmsmanDragonslayerMace.Bonus4 = 4;
                    ArmsmanDragonslayerMace.Bonus5Type = (int)eProperty.MeleeDamage;
                    ArmsmanDragonslayerMace.Bonus5 = 4;
                    ArmsmanDragonslayerMace.Bonus6Type = (int)eProperty.StrCapBonus;
                    ArmsmanDragonslayerMace.Bonus6 = 5;
                    ArmsmanDragonslayerMace.Bonus7Type = (int)eProperty.DexCapBonus;
                    ArmsmanDragonslayerMace.Bonus7 = 5;
                    ArmsmanDragonslayerMace.SpellID = 32176;
                    ArmsmanDragonslayerMace.Charges = 100;
                    ArmsmanDragonslayerMace.MaxCharges = 100;
                    ArmsmanDragonslayerMace.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ArmsmanDragonslayerMace);
                }

                if (ArmsmanDragonslayerArchMace == null)
                {
                    ArmsmanDragonslayerArchMace = new ItemTemplate();
                    ArmsmanDragonslayerArchMace.Id_nb = "ArmsmanDragonslayerArchMace";
                    ArmsmanDragonslayerArchMace.Name = "Armsman Dragonslayer Arch-Mace";
                    ArmsmanDragonslayerArchMace.Level = 51;
                    ArmsmanDragonslayerArchMace.Item_Type = 12;
                    ArmsmanDragonslayerArchMace.Hand = 1;
                    ArmsmanDragonslayerArchMace.Model = 3958;
                    ArmsmanDragonslayerArchMace.IsDropable = true;
                    ArmsmanDragonslayerArchMace.IsPickable = true;
                    ArmsmanDragonslayerArchMace.Type_Damage = 1;
                    ArmsmanDragonslayerArchMace.DPS_AF = 165;
                    ArmsmanDragonslayerArchMace.Price = 3500;
                    ArmsmanDragonslayerArchMace.SPD_ABS = 42;
                    ArmsmanDragonslayerArchMace.Object_Type = 6;
                    ArmsmanDragonslayerArchMace.Quality = 100;
                    ArmsmanDragonslayerArchMace.IsTradable = false;
                    ArmsmanDragonslayerArchMace.Weight = 25;
                    ArmsmanDragonslayerArchMace.Bonus = 35;
                    ArmsmanDragonslayerArchMace.MaxCondition = 50000;
                    ArmsmanDragonslayerArchMace.MaxDurability = 50000;
                    ArmsmanDragonslayerArchMace.Condition = 50000;
                    ArmsmanDragonslayerArchMace.Durability = 50000;
                    ArmsmanDragonslayerArchMace.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    ArmsmanDragonslayerArchMace.Bonus1 = 4;
                    ArmsmanDragonslayerArchMace.Bonus2Type = (int)eStat.STR;
                    ArmsmanDragonslayerArchMace.Bonus2 = 12;
                    ArmsmanDragonslayerArchMace.Bonus3Type = (int)eStat.QUI;
                    ArmsmanDragonslayerArchMace.Bonus3 = 12;
                    ArmsmanDragonslayerArchMace.Bonus4Type = (int)eProperty.StyleDamage;
                    ArmsmanDragonslayerArchMace.Bonus4 = 4;
                    ArmsmanDragonslayerArchMace.Bonus5Type = (int)eProperty.MeleeDamage;
                    ArmsmanDragonslayerArchMace.Bonus5 = 4;
                    ArmsmanDragonslayerArchMace.Bonus6Type = (int)eProperty.StrCapBonus;
                    ArmsmanDragonslayerArchMace.Bonus6 = 8;
                    ArmsmanDragonslayerArchMace.SpellID = 32176;
                    ArmsmanDragonslayerArchMace.Charges = 100;
                    ArmsmanDragonslayerArchMace.MaxCharges = 100;
                    ArmsmanDragonslayerArchMace.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ArmsmanDragonslayerArchMace);
                }

                if (ArmsmanDragonslayerFlamberge == null)
                {
                    ArmsmanDragonslayerFlamberge = new ItemTemplate();
                    ArmsmanDragonslayerFlamberge.Id_nb = "ArmsmanDragonslayerFlamberge";
                    ArmsmanDragonslayerFlamberge.Name = "Armsman Dragonslayer Flamberge";
                    ArmsmanDragonslayerFlamberge.Level = 51;
                    ArmsmanDragonslayerFlamberge.Item_Type = 12;
                    ArmsmanDragonslayerFlamberge.Model = 3955;
                    ArmsmanDragonslayerFlamberge.Hand = 1;
                    ArmsmanDragonslayerFlamberge.IsDropable = true;
                    ArmsmanDragonslayerFlamberge.IsPickable = true;
                    ArmsmanDragonslayerFlamberge.Type_Damage = 2;
                    ArmsmanDragonslayerFlamberge.DPS_AF = 165;
                    ArmsmanDragonslayerFlamberge.SPD_ABS = 56;
                    ArmsmanDragonslayerFlamberge.Object_Type = 6;
                    ArmsmanDragonslayerFlamberge.Price = 3500;
                    ArmsmanDragonslayerFlamberge.Quality = 100;
                    ArmsmanDragonslayerFlamberge.IsTradable = false;
                    ArmsmanDragonslayerFlamberge.Weight = 25;
                    ArmsmanDragonslayerFlamberge.Bonus = 35;
                    ArmsmanDragonslayerFlamberge.MaxCondition = 50000;
                    ArmsmanDragonslayerFlamberge.MaxDurability = 50000;
                    ArmsmanDragonslayerFlamberge.Condition = 50000;
                    ArmsmanDragonslayerFlamberge.Durability = 50000;
                    ArmsmanDragonslayerFlamberge.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    ArmsmanDragonslayerFlamberge.Bonus1 = 4;
                    ArmsmanDragonslayerFlamberge.Bonus2Type = (int)eStat.STR;
                    ArmsmanDragonslayerFlamberge.Bonus2 = 12;
                    ArmsmanDragonslayerFlamberge.Bonus3Type = (int)eStat.QUI;
                    ArmsmanDragonslayerFlamberge.Bonus3 = 12;
                    ArmsmanDragonslayerFlamberge.Bonus4Type = (int)eProperty.StyleDamage;
                    ArmsmanDragonslayerFlamberge.Bonus4 = 4;
                    ArmsmanDragonslayerFlamberge.Bonus5Type = (int)eProperty.MeleeDamage;
                    ArmsmanDragonslayerFlamberge.Bonus5 = 4;
                    ArmsmanDragonslayerFlamberge.Bonus6Type = (int)eProperty.StrCapBonus;
                    ArmsmanDragonslayerFlamberge.Bonus6 = 8;
                    ArmsmanDragonslayerFlamberge.SpellID = 32176;
                    ArmsmanDragonslayerFlamberge.Charges = 100;
                    ArmsmanDragonslayerFlamberge.MaxCharges = 100;
                    ArmsmanDragonslayerFlamberge.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ArmsmanDragonslayerFlamberge);
                }

                if (ArmsmanDragonslayerHalberd == null)
                {
                    ArmsmanDragonslayerHalberd = new ItemTemplate();
                    ArmsmanDragonslayerHalberd.Id_nb = "ArmsmanDragonslayerHalberd";
                    ArmsmanDragonslayerHalberd.Name = "Armsman Dragonslayer Halberd";
                    ArmsmanDragonslayerHalberd.Level = 51;
                    ArmsmanDragonslayerHalberd.Item_Type = 12;
                    ArmsmanDragonslayerHalberd.Model = 3969;
                    ArmsmanDragonslayerHalberd.Hand = 1;
                    ArmsmanDragonslayerHalberd.IsDropable = true;
                    ArmsmanDragonslayerHalberd.IsPickable = true;
                    ArmsmanDragonslayerHalberd.Type_Damage = 2;
                    ArmsmanDragonslayerHalberd.DPS_AF = 165;
                    ArmsmanDragonslayerHalberd.Price = 3500;
                    ArmsmanDragonslayerHalberd.SPD_ABS = 58;
                    ArmsmanDragonslayerHalberd.Object_Type = 7;
                    ArmsmanDragonslayerHalberd.Quality = 100;
                    ArmsmanDragonslayerHalberd.IsTradable = false;
                    ArmsmanDragonslayerHalberd.Weight = 25;
                    ArmsmanDragonslayerHalberd.Bonus = 35;
                    ArmsmanDragonslayerHalberd.MaxCondition = 50000;
                    ArmsmanDragonslayerHalberd.MaxDurability = 50000;
                    ArmsmanDragonslayerHalberd.Condition = 50000;
                    ArmsmanDragonslayerHalberd.Durability = 50000;
                    ArmsmanDragonslayerHalberd.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    ArmsmanDragonslayerHalberd.Bonus1 = 4;
                    ArmsmanDragonslayerHalberd.Bonus2Type = (int)eStat.STR;
                    ArmsmanDragonslayerHalberd.Bonus2 = 12;
                    ArmsmanDragonslayerHalberd.Bonus3Type = (int)eStat.QUI;
                    ArmsmanDragonslayerHalberd.Bonus3 = 12;
                    ArmsmanDragonslayerHalberd.Bonus4Type = (int)eProperty.StyleDamage;
                    ArmsmanDragonslayerHalberd.Bonus4 = 4;
                    ArmsmanDragonslayerHalberd.Bonus5Type = (int)eProperty.MeleeDamage;
                    ArmsmanDragonslayerHalberd.Bonus5 = 4;
                    ArmsmanDragonslayerHalberd.Bonus6Type = (int)eProperty.StrCapBonus;
                    ArmsmanDragonslayerHalberd.Bonus6 = 8;
                    ArmsmanDragonslayerHalberd.SpellID = 32176;
                    ArmsmanDragonslayerHalberd.Charges = 100;
                    ArmsmanDragonslayerHalberd.MaxCharges = 100;
                    ArmsmanDragonslayerHalberd.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ArmsmanDragonslayerHalberd);
                }

                if (ArmsmanDragonslayerLance == null)
                {
                    ArmsmanDragonslayerLance = new ItemTemplate();
                    ArmsmanDragonslayerLance.Id_nb = "ArmsmanDragonslayerLance";
                    ArmsmanDragonslayerLance.Name = "Armsman Dragonslayer Lance";
                    ArmsmanDragonslayerLance.Level = 51;
                    ArmsmanDragonslayerLance.Item_Type = 12;
                    ArmsmanDragonslayerLance.Model = 3954;
                    ArmsmanDragonslayerLance.Hand = 1;
                    ArmsmanDragonslayerLance.IsDropable = true;
                    ArmsmanDragonslayerLance.IsPickable = true;
                    ArmsmanDragonslayerLance.Type_Damage = 3;
                    ArmsmanDragonslayerLance.DPS_AF = 165;
                    ArmsmanDragonslayerLance.SPD_ABS = 56;
                    ArmsmanDragonslayerLance.Price = 3500;
                    ArmsmanDragonslayerLance.Object_Type = 6;
                    ArmsmanDragonslayerLance.Quality = 100;
                    ArmsmanDragonslayerLance.IsTradable = false;
                    ArmsmanDragonslayerLance.Weight = 25;
                    ArmsmanDragonslayerLance.Bonus = 35;
                    ArmsmanDragonslayerLance.MaxCondition = 50000;
                    ArmsmanDragonslayerLance.MaxDurability = 50000;
                    ArmsmanDragonslayerLance.Condition = 50000;
                    ArmsmanDragonslayerLance.Durability = 50000;
                    ArmsmanDragonslayerLance.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    ArmsmanDragonslayerLance.Bonus1 = 4;
                    ArmsmanDragonslayerLance.Bonus2Type = (int)eStat.STR;
                    ArmsmanDragonslayerLance.Bonus2 = 12;
                    ArmsmanDragonslayerLance.Bonus3Type = (int)eStat.QUI;
                    ArmsmanDragonslayerLance.Bonus3 = 12;
                    ArmsmanDragonslayerLance.Bonus4Type = (int)eProperty.StyleDamage;
                    ArmsmanDragonslayerLance.Bonus4 = 4;
                    ArmsmanDragonslayerLance.Bonus5Type = (int)eProperty.MeleeDamage;
                    ArmsmanDragonslayerLance.Bonus5 = 4;
                    ArmsmanDragonslayerLance.Bonus6Type = (int)eProperty.StrCapBonus;
                    ArmsmanDragonslayerLance.Bonus6 = 8;
                    ArmsmanDragonslayerLance.SpellID = 32176;
                    ArmsmanDragonslayerLance.Charges = 100;
                    ArmsmanDragonslayerLance.MaxCharges = 100;
                    ArmsmanDragonslayerLance.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ArmsmanDragonslayerLance);
                }

                if (ArmsmanDragonslayerPike == null)
                {
                    ArmsmanDragonslayerPike = new ItemTemplate();
                    ArmsmanDragonslayerPike.Id_nb = "ArmsmanDragonslayerPike";
                    ArmsmanDragonslayerPike.Name = "Armsman Dragonslayer Pike";
                    ArmsmanDragonslayerPike.Level = 51;
                    ArmsmanDragonslayerPike.Item_Type = 12;
                    ArmsmanDragonslayerPike.Model = 3968;
                    ArmsmanDragonslayerPike.Hand = 1;
                    ArmsmanDragonslayerPike.IsDropable = true;
                    ArmsmanDragonslayerPike.IsPickable = true;
                    ArmsmanDragonslayerPike.Type_Damage = 3;
                    ArmsmanDragonslayerPike.DPS_AF = 165;
                    ArmsmanDragonslayerPike.SPD_ABS = 58;
                    ArmsmanDragonslayerPike.Price = 3500;
                    ArmsmanDragonslayerPike.Object_Type = 7;
                    ArmsmanDragonslayerPike.Quality = 100;
                    ArmsmanDragonslayerPike.IsTradable = false;
                    ArmsmanDragonslayerPike.Weight = 25;
                    ArmsmanDragonslayerPike.Bonus = 35;
                    ArmsmanDragonslayerPike.MaxCondition = 50000;
                    ArmsmanDragonslayerPike.MaxDurability = 50000;
                    ArmsmanDragonslayerPike.Condition = 50000;
                    ArmsmanDragonslayerPike.Durability = 50000;
                    ArmsmanDragonslayerPike.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    ArmsmanDragonslayerPike.Bonus1 = 4;
                    ArmsmanDragonslayerPike.Bonus2Type = (int)eStat.STR;
                    ArmsmanDragonslayerPike.Bonus2 = 12;
                    ArmsmanDragonslayerPike.Bonus3Type = (int)eStat.QUI;
                    ArmsmanDragonslayerPike.Bonus3 = 12;
                    ArmsmanDragonslayerPike.Bonus4Type = (int)eProperty.StyleDamage;
                    ArmsmanDragonslayerPike.Bonus4 = 4;
                    ArmsmanDragonslayerPike.Bonus5Type = (int)eProperty.MeleeDamage;
                    ArmsmanDragonslayerPike.Bonus5 = 4;
                    ArmsmanDragonslayerPike.Bonus6Type = (int)eProperty.StrCapBonus;
                    ArmsmanDragonslayerPike.Bonus6 = 8;
                    ArmsmanDragonslayerPike.SpellID = 32176;
                    ArmsmanDragonslayerPike.Charges = 100;
                    ArmsmanDragonslayerPike.MaxCharges = 100;
                    ArmsmanDragonslayerPike.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ArmsmanDragonslayerPike);
                }

                if (ArmsmanDragonslayerMattock == null)
                {
                    ArmsmanDragonslayerMattock = new ItemTemplate();
                    ArmsmanDragonslayerMattock.Id_nb = "ArmsmanDragonslayerMattock";
                    ArmsmanDragonslayerMattock.Name = "Armsman Dragonslayer Mattock";
                    ArmsmanDragonslayerMattock.Level = 51;
                    ArmsmanDragonslayerMattock.Item_Type = 12;
                    ArmsmanDragonslayerMattock.Hand = 1;
                    ArmsmanDragonslayerMattock.Model = 3970;
                    ArmsmanDragonslayerMattock.IsDropable = true;
                    ArmsmanDragonslayerMattock.IsPickable = true;
                    ArmsmanDragonslayerMattock.Type_Damage = 1;
                    ArmsmanDragonslayerMattock.Price = 3500;
                    ArmsmanDragonslayerMattock.DPS_AF = 165;
                    ArmsmanDragonslayerMattock.SPD_ABS = 58;
                    ArmsmanDragonslayerMattock.Object_Type = 7;
                    ArmsmanDragonslayerMattock.Quality = 100;
                    ArmsmanDragonslayerMattock.IsTradable = false;
                    ArmsmanDragonslayerMattock.Weight = 25;
                    ArmsmanDragonslayerMattock.Bonus = 35;
                    ArmsmanDragonslayerMattock.MaxCondition = 50000;
                    ArmsmanDragonslayerMattock.MaxDurability = 50000;
                    ArmsmanDragonslayerMattock.Condition = 50000;
                    ArmsmanDragonslayerMattock.Durability = 50000;
                    ArmsmanDragonslayerMattock.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    ArmsmanDragonslayerMattock.Bonus1 = 4;
                    ArmsmanDragonslayerMattock.Bonus2Type = (int)eStat.STR;
                    ArmsmanDragonslayerMattock.Bonus2 = 12;
                    ArmsmanDragonslayerMattock.Bonus3Type = (int)eStat.QUI;
                    ArmsmanDragonslayerMattock.Bonus3 = 12;
                    ArmsmanDragonslayerMattock.Bonus4Type = (int)eProperty.StyleDamage;
                    ArmsmanDragonslayerMattock.Bonus4 = 4;
                    ArmsmanDragonslayerMattock.Bonus5Type = (int)eProperty.MeleeDamage;
                    ArmsmanDragonslayerMattock.Bonus5 = 4;
                    ArmsmanDragonslayerMattock.Bonus6Type = (int)eProperty.StrCapBonus;
                    ArmsmanDragonslayerMattock.Bonus6 = 8;
                    ArmsmanDragonslayerMattock.SpellID = 32176;
                    ArmsmanDragonslayerMattock.Charges = 100;
                    ArmsmanDragonslayerMattock.MaxCharges = 100;
                    ArmsmanDragonslayerMattock.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ArmsmanDragonslayerMattock);
                }

                if (FriarDragonslayerQuarterStaff == null)
                {
                    FriarDragonslayerQuarterStaff = new ItemTemplate();
                    FriarDragonslayerQuarterStaff.Id_nb = "FriarDragonslayerQuarterStaff";
                    FriarDragonslayerQuarterStaff.Name = "Friar Dragonslayer Quarter-Staff";
                    FriarDragonslayerQuarterStaff.Level = 51;
                    FriarDragonslayerQuarterStaff.Item_Type = 12;
                    FriarDragonslayerQuarterStaff.Model = 3963;
                    FriarDragonslayerQuarterStaff.Hand = 1;
                    FriarDragonslayerQuarterStaff.IsDropable = true;
                    FriarDragonslayerQuarterStaff.IsPickable = true;
                    FriarDragonslayerQuarterStaff.Type_Damage = 1;
                    FriarDragonslayerQuarterStaff.DPS_AF = 165;
                    FriarDragonslayerQuarterStaff.Price = 3500;
                    FriarDragonslayerQuarterStaff.SPD_ABS = 35;
                    FriarDragonslayerQuarterStaff.Object_Type = 8;
                    FriarDragonslayerQuarterStaff.Quality = 100;
                    FriarDragonslayerQuarterStaff.IsTradable = false;
                    FriarDragonslayerQuarterStaff.Weight = 25;
                    FriarDragonslayerQuarterStaff.Bonus = 35;
                    FriarDragonslayerQuarterStaff.MaxCondition = 50000;
                    FriarDragonslayerQuarterStaff.MaxDurability = 50000;
                    FriarDragonslayerQuarterStaff.Condition = 50000;
                    FriarDragonslayerQuarterStaff.Durability = 50000;
                    FriarDragonslayerQuarterStaff.Bonus1 = 4;
                    FriarDragonslayerQuarterStaff.Bonus1Type = (int)eProperty.Skill_Staff;
                    FriarDragonslayerQuarterStaff.Bonus2 = 9;
                    FriarDragonslayerQuarterStaff.Bonus2Type = (int)eStat.DEX;
                    FriarDragonslayerQuarterStaff.Bonus3 = 16;
                    FriarDragonslayerQuarterStaff.Bonus3Type = (int)eProperty.MaxHealth;
                    FriarDragonslayerQuarterStaff.Bonus4 = 4;
                    FriarDragonslayerQuarterStaff.Bonus4Type = (int)eProperty.MeleeDamage;
                    FriarDragonslayerQuarterStaff.Bonus5 = 4;
                    FriarDragonslayerQuarterStaff.Bonus5Type = (int)eProperty.StyleDamage;
                    FriarDragonslayerQuarterStaff.Bonus6 = 6;
                    FriarDragonslayerQuarterStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    FriarDragonslayerQuarterStaff.Bonus7 = 6;
                    FriarDragonslayerQuarterStaff.Bonus7Type = (int)eProperty.HealingEffectiveness;
                    FriarDragonslayerQuarterStaff.Bonus8 = 4;
                    FriarDragonslayerQuarterStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    FriarDragonslayerQuarterStaff.SpellID = 32179;
                    FriarDragonslayerQuarterStaff.Charges = 100;
                    FriarDragonslayerQuarterStaff.MaxCharges = 100;
                    FriarDragonslayerQuarterStaff.SpellID1 = 32178;
                    FriarDragonslayerQuarterStaff.Charges1 = 100;
                    FriarDragonslayerQuarterStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(FriarDragonslayerQuarterStaff);
                }

                if (DragonslayerCabalistStaff == null)
                {
                    DragonslayerCabalistStaff = new ItemTemplate();
                    DragonslayerCabalistStaff.Id_nb = "DragonslayerCabalistStaff";
                    DragonslayerCabalistStaff.Name = "Dragonslayer Cabalist Staff";
                    DragonslayerCabalistStaff.Level = 51;
                    DragonslayerCabalistStaff.Item_Type = 12;
                    DragonslayerCabalistStaff.Hand = 1;
                    DragonslayerCabalistStaff.Model = 3964;
                    DragonslayerCabalistStaff.IsDropable = true;
                    DragonslayerCabalistStaff.IsPickable = true;
                    DragonslayerCabalistStaff.Type_Damage = 1;
                    DragonslayerCabalistStaff.DPS_AF = 165;
                    DragonslayerCabalistStaff.Price = 3500;
                    DragonslayerCabalistStaff.SPD_ABS = 50;
                    DragonslayerCabalistStaff.Object_Type = 8;
                    DragonslayerCabalistStaff.Quality = 100;
                    DragonslayerCabalistStaff.IsTradable = false;
                    DragonslayerCabalistStaff.Weight = 25;
                    DragonslayerCabalistStaff.Bonus = 35;
                    DragonslayerCabalistStaff.MaxCondition = 50000;
                    DragonslayerCabalistStaff.MaxDurability = 50000;
                    DragonslayerCabalistStaff.Condition = 50000;
                    DragonslayerCabalistStaff.Durability = 50000;
                    DragonslayerCabalistStaff.Bonus1 = 3;
                    DragonslayerCabalistStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerCabalistStaff.Bonus2 = 6;
                    DragonslayerCabalistStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerCabalistStaff.Bonus3 = 6;
                    DragonslayerCabalistStaff.Bonus3Type = (int)eStat.DEX;
                    DragonslayerCabalistStaff.Bonus4 = 50;
                    DragonslayerCabalistStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerCabalistStaff.Bonus5 = 4;
                    DragonslayerCabalistStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerCabalistStaff.Bonus6 = 6;
                    DragonslayerCabalistStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerCabalistStaff.Bonus7 = 6;
                    DragonslayerCabalistStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerCabalistStaff.Bonus8 = 4;
                    DragonslayerCabalistStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerCabalistStaff.SpellID = 32175;
                    DragonslayerCabalistStaff.Charges = 100;
                    DragonslayerCabalistStaff.MaxCharges = 100;
                    DragonslayerCabalistStaff.SpellID1 = 32182;
                    DragonslayerCabalistStaff.Charges1 = 100;
                    DragonslayerCabalistStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerCabalistStaff);
                }

                if (DragonslayerNecromancerStaff == null)
                {
                    DragonslayerNecromancerStaff = new ItemTemplate();
                    DragonslayerNecromancerStaff.Id_nb = "DragonslayerNecromancerStaff";
                    DragonslayerNecromancerStaff.Name = "Dragonslayer Necromancer Staff";
                    DragonslayerNecromancerStaff.Level = 51;
                    DragonslayerNecromancerStaff.Item_Type = 12;
                    DragonslayerNecromancerStaff.Hand = 1;
                    DragonslayerNecromancerStaff.Model = 3964;
                    DragonslayerNecromancerStaff.IsDropable = true;
                    DragonslayerNecromancerStaff.IsPickable = true;
                    DragonslayerNecromancerStaff.Type_Damage = 1;
                    DragonslayerNecromancerStaff.DPS_AF = 165;
                    DragonslayerNecromancerStaff.SPD_ABS = 50;
                    DragonslayerNecromancerStaff.Object_Type = 8;
                    DragonslayerNecromancerStaff.Price = 3500;
                    DragonslayerNecromancerStaff.Quality = 100;
                    DragonslayerNecromancerStaff.IsTradable = false;
                    DragonslayerNecromancerStaff.Weight = 25;
                    DragonslayerNecromancerStaff.Bonus = 35;
                    DragonslayerNecromancerStaff.MaxCondition = 50000;
                    DragonslayerNecromancerStaff.MaxDurability = 50000;
                    DragonslayerNecromancerStaff.Condition = 50000;
                    DragonslayerNecromancerStaff.Durability = 50000;
                    DragonslayerNecromancerStaff.Bonus1 = 2;
                    DragonslayerNecromancerStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerNecromancerStaff.Bonus2 = 5;
                    DragonslayerNecromancerStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerNecromancerStaff.Bonus3 = 6;
                    DragonslayerNecromancerStaff.Bonus3Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerNecromancerStaff.Bonus4 = 50;
                    DragonslayerNecromancerStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerNecromancerStaff.Bonus5 = 4;
                    DragonslayerNecromancerStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerNecromancerStaff.Bonus6 = 6;
                    DragonslayerNecromancerStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerNecromancerStaff.Bonus7 = 6;
                    DragonslayerNecromancerStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerNecromancerStaff.Bonus8 = 4;
                    DragonslayerNecromancerStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerNecromancerStaff.SpellID = 32175;
                    DragonslayerNecromancerStaff.Charges = 100;
                    DragonslayerNecromancerStaff.MaxCharges = 100;
                    GameServer.Database.AddObject(DragonslayerNecromancerStaff);
                }

                if (DragonslayerSorcererStaff == null)
                {
                    DragonslayerSorcererStaff = new ItemTemplate();
                    DragonslayerSorcererStaff.Id_nb = "DragonslayerSorcererStaff";
                    DragonslayerSorcererStaff.Name = "Dragonslayer Sorcerer Staff";
                    DragonslayerSorcererStaff.Level = 51;
                    DragonslayerSorcererStaff.Item_Type = 12;
                    DragonslayerSorcererStaff.Hand = 1;
                    DragonslayerSorcererStaff.Model = 3964;
                    DragonslayerSorcererStaff.IsDropable = true;
                    DragonslayerSorcererStaff.IsPickable = true;
                    DragonslayerSorcererStaff.Type_Damage = 1;
                    DragonslayerSorcererStaff.Price = 3500;
                    DragonslayerSorcererStaff.DPS_AF = 165;
                    DragonslayerSorcererStaff.SPD_ABS = 50;
                    DragonslayerSorcererStaff.Object_Type = 8;
                    DragonslayerSorcererStaff.Quality = 100;
                    DragonslayerSorcererStaff.IsTradable = false;
                    DragonslayerSorcererStaff.Weight = 25;
                    DragonslayerSorcererStaff.Bonus = 35;
                    DragonslayerSorcererStaff.MaxCondition = 50000;
                    DragonslayerSorcererStaff.MaxDurability = 50000;
                    DragonslayerSorcererStaff.Condition = 50000;
                    DragonslayerSorcererStaff.Durability = 50000;
                    DragonslayerSorcererStaff.Bonus1 = 3;
                    DragonslayerSorcererStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerSorcererStaff.Bonus2 = 5;
                    DragonslayerSorcererStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerSorcererStaff.Bonus3 = 6;
                    DragonslayerSorcererStaff.Bonus3Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerSorcererStaff.Bonus4 = 50;
                    DragonslayerSorcererStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerSorcererStaff.Bonus5 = 4;
                    DragonslayerSorcererStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerSorcererStaff.Bonus6 = 6;
                    DragonslayerSorcererStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerSorcererStaff.Bonus7 = 6;
                    DragonslayerSorcererStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerSorcererStaff.Bonus8 = 4;
                    DragonslayerSorcererStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerSorcererStaff.SpellID = 32175;
                    DragonslayerSorcererStaff.Charges = 100;
                    DragonslayerSorcererStaff.MaxCharges = 100;
                    DragonslayerSorcererStaff.SpellID1 = 32182;
                    DragonslayerSorcererStaff.Charges1 = 100;
                    DragonslayerSorcererStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerSorcererStaff);
                }

                if (DragonslayerTheurgistStaff == null)
                {
                    DragonslayerTheurgistStaff = new ItemTemplate();
                    DragonslayerTheurgistStaff.Id_nb = "DragonslayerTheurgistStaff";
                    DragonslayerTheurgistStaff.Name = "Dragonslayer Theurgist Staff";
                    DragonslayerTheurgistStaff.Level = 51;
                    DragonslayerTheurgistStaff.Item_Type = 12;
                    DragonslayerTheurgistStaff.Hand = 1;
                    DragonslayerTheurgistStaff.Model = 3964;
                    DragonslayerTheurgistStaff.IsDropable = true;
                    DragonslayerTheurgistStaff.IsPickable = true;
                    DragonslayerTheurgistStaff.Type_Damage = 1;
                    DragonslayerTheurgistStaff.DPS_AF = 165;
                    DragonslayerTheurgistStaff.SPD_ABS = 50;
                    DragonslayerTheurgistStaff.Object_Type = 8;
                    DragonslayerTheurgistStaff.Quality = 100;
                    DragonslayerTheurgistStaff.IsTradable = false;
                    DragonslayerTheurgistStaff.Weight = 25;
                    DragonslayerTheurgistStaff.Price = 3500;
                    DragonslayerTheurgistStaff.Bonus = 35;
                    DragonslayerTheurgistStaff.MaxCondition = 50000;
                    DragonslayerTheurgistStaff.MaxDurability = 50000;
                    DragonslayerTheurgistStaff.Condition = 50000;
                    DragonslayerTheurgistStaff.Durability = 50000;
                    DragonslayerTheurgistStaff.Bonus1 = 2;
                    DragonslayerTheurgistStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerTheurgistStaff.Bonus2 = 5;
                    DragonslayerTheurgistStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerTheurgistStaff.Bonus3 = 6;
                    DragonslayerTheurgistStaff.Bonus3Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerTheurgistStaff.Bonus4 = 50;
                    DragonslayerTheurgistStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerTheurgistStaff.Bonus5 = 4;
                    DragonslayerTheurgistStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerTheurgistStaff.Bonus6 = 6;
                    DragonslayerTheurgistStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerTheurgistStaff.Bonus7 = 6;
                    DragonslayerTheurgistStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerTheurgistStaff.Bonus8 = 4;
                    DragonslayerTheurgistStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerTheurgistStaff.SpellID = 32175;
                    DragonslayerTheurgistStaff.Charges = 100;
                    DragonslayerTheurgistStaff.MaxCharges = 100;
                    DragonslayerTheurgistStaff.SpellID1 = 32182;
                    DragonslayerTheurgistStaff.Charges1 = 100;
                    DragonslayerTheurgistStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerTheurgistStaff);
                }

                if (DragonslayerWizardStaff == null)
                {
                    DragonslayerWizardStaff = new ItemTemplate();
                    DragonslayerWizardStaff.Id_nb = "DragonslayerWizardStaff";
                    DragonslayerWizardStaff.Name = "Dragonslayer Wizard Staff";
                    DragonslayerWizardStaff.Level = 51;
                    DragonslayerWizardStaff.Item_Type = 12;
                    DragonslayerWizardStaff.Hand = 1;
                    DragonslayerWizardStaff.Model = 3964;
                    DragonslayerWizardStaff.IsDropable = true;
                    DragonslayerWizardStaff.IsPickable = true;
                    DragonslayerWizardStaff.Type_Damage = 1;
                    DragonslayerWizardStaff.DPS_AF = 165;
                    DragonslayerWizardStaff.SPD_ABS = 50;
                    DragonslayerWizardStaff.Object_Type = 8;
                    DragonslayerWizardStaff.Quality = 100;
                    DragonslayerWizardStaff.Price = 3500;
                    DragonslayerWizardStaff.IsTradable = false;
                    DragonslayerWizardStaff.Weight = 25;
                    DragonslayerWizardStaff.Bonus = 35;
                    DragonslayerWizardStaff.MaxCondition = 50000;
                    DragonslayerWizardStaff.MaxDurability = 50000;
                    DragonslayerWizardStaff.Condition = 50000;
                    DragonslayerWizardStaff.Durability = 50000;
                    DragonslayerWizardStaff.Bonus1 = 3;
                    DragonslayerWizardStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerWizardStaff.Bonus2 = 6;
                    DragonslayerWizardStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerWizardStaff.Bonus3 = 6;
                    DragonslayerWizardStaff.Bonus3Type = (int)eStat.DEX;
                    DragonslayerWizardStaff.Bonus4 = 50;
                    DragonslayerWizardStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerWizardStaff.Bonus5 = 4;
                    DragonslayerWizardStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerWizardStaff.Bonus6 = 6;
                    DragonslayerWizardStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerWizardStaff.Bonus7 = 6;
                    DragonslayerWizardStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerWizardStaff.Bonus8 = 4;
                    DragonslayerWizardStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerWizardStaff.SpellID = 32175;
                    DragonslayerWizardStaff.Charges = 100;
                    DragonslayerWizardStaff.MaxCharges = 100;
                    DragonslayerWizardStaff.SpellID1 = 32182;
                    DragonslayerWizardStaff.Charges1 = 100;
                    DragonslayerWizardStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerWizardStaff);
                }

                if (DragonslayerBonedancerStaff == null)
                {
                    DragonslayerBonedancerStaff = new ItemTemplate();
                    DragonslayerBonedancerStaff.Id_nb = "DragonslayerBonedancerStaff";
                    DragonslayerBonedancerStaff.Name = "Dragonslayer Bonedancer Staff";
                    DragonslayerBonedancerStaff.Level = 51;
                    DragonslayerBonedancerStaff.Item_Type = 12;
                    DragonslayerBonedancerStaff.Hand = 1;
                    DragonslayerBonedancerStaff.Model = 3928;
                    DragonslayerBonedancerStaff.IsDropable = true;
                    DragonslayerBonedancerStaff.IsPickable = true;
                    DragonslayerBonedancerStaff.Type_Damage = 1;
                    DragonslayerBonedancerStaff.DPS_AF = 165;
                    DragonslayerBonedancerStaff.SPD_ABS = 50;
                    DragonslayerBonedancerStaff.Price = 3500;
                    DragonslayerBonedancerStaff.Object_Type = 8;
                    DragonslayerBonedancerStaff.Quality = 100;
                    DragonslayerBonedancerStaff.IsTradable = false;
                    DragonslayerBonedancerStaff.Weight = 25;
                    DragonslayerBonedancerStaff.Bonus = 35;
                    DragonslayerBonedancerStaff.MaxCondition = 50000;
                    DragonslayerBonedancerStaff.MaxDurability = 50000;
                    DragonslayerBonedancerStaff.Condition = 50000;
                    DragonslayerBonedancerStaff.Durability = 50000;
                    DragonslayerBonedancerStaff.Bonus1 = 2;
                    DragonslayerBonedancerStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerBonedancerStaff.Bonus2 = 5;
                    DragonslayerBonedancerStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerBonedancerStaff.Bonus3 = 6;
                    DragonslayerBonedancerStaff.Bonus3Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerBonedancerStaff.Bonus4 = 50;
                    DragonslayerBonedancerStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerBonedancerStaff.Bonus5 = 4;
                    DragonslayerBonedancerStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerBonedancerStaff.Bonus6 = 6;
                    DragonslayerBonedancerStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerBonedancerStaff.Bonus7 = 6;
                    DragonslayerBonedancerStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerBonedancerStaff.Bonus8 = 4;
                    DragonslayerBonedancerStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerBonedancerStaff.SpellID = 32175;
                    DragonslayerBonedancerStaff.Charges = 100;
                    DragonslayerBonedancerStaff.MaxCharges = 100;
                    DragonslayerBonedancerStaff.SpellID1 = 32182;
                    DragonslayerBonedancerStaff.Charges1 = 100;
                    DragonslayerBonedancerStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerBonedancerStaff);
                }

                if (DragonslayerRunemasterStaff == null)
                {
                    DragonslayerRunemasterStaff = new ItemTemplate();
                    DragonslayerRunemasterStaff.Id_nb = "DragonslayerRunemasterStaff";
                    DragonslayerRunemasterStaff.Name = "Dragonslayer Runemaster Staff";
                    DragonslayerRunemasterStaff.Level = 51;
                    DragonslayerRunemasterStaff.Item_Type = 12;
                    DragonslayerRunemasterStaff.Hand = 1;
                    DragonslayerRunemasterStaff.Model = 3928;
                    DragonslayerRunemasterStaff.IsDropable = true;
                    DragonslayerRunemasterStaff.IsPickable = true;
                    DragonslayerRunemasterStaff.Type_Damage = 1;
                    DragonslayerRunemasterStaff.Price = 3500;
                    DragonslayerRunemasterStaff.DPS_AF = 165;
                    DragonslayerRunemasterStaff.SPD_ABS = 50;
                    DragonslayerRunemasterStaff.Object_Type = 8;
                    DragonslayerRunemasterStaff.Quality = 100;
                    DragonslayerRunemasterStaff.IsTradable = false;
                    DragonslayerRunemasterStaff.Weight = 25;
                    DragonslayerRunemasterStaff.Bonus = 35;
                    DragonslayerRunemasterStaff.MaxCondition = 50000;
                    DragonslayerRunemasterStaff.MaxDurability = 50000;
                    DragonslayerRunemasterStaff.Condition = 50000;
                    DragonslayerRunemasterStaff.Durability = 50000;
                    DragonslayerRunemasterStaff.Bonus1 = 3;
                    DragonslayerRunemasterStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerRunemasterStaff.Bonus2 = 6;
                    DragonslayerRunemasterStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerRunemasterStaff.Bonus3 = 6;
                    DragonslayerRunemasterStaff.Bonus3Type = (int)eStat.DEX;
                    DragonslayerRunemasterStaff.Bonus4 = 50;
                    DragonslayerRunemasterStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerRunemasterStaff.Bonus5 = 4;
                    DragonslayerRunemasterStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerRunemasterStaff.Bonus6 = 6;
                    DragonslayerRunemasterStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerRunemasterStaff.Bonus7 = 6;
                    DragonslayerRunemasterStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerRunemasterStaff.Bonus8 = 4;
                    DragonslayerRunemasterStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerRunemasterStaff.SpellID = 32175;
                    DragonslayerRunemasterStaff.Charges = 100;
                    DragonslayerRunemasterStaff.MaxCharges = 100;
                    DragonslayerRunemasterStaff.SpellID1 = 32182;
                    DragonslayerRunemasterStaff.Charges1 = 100;
                    DragonslayerRunemasterStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerRunemasterStaff);
                }

                if (DragonslayerSpiritmasterStaff == null)
                {
                    DragonslayerSpiritmasterStaff = new ItemTemplate();
                    DragonslayerSpiritmasterStaff.Id_nb = "DragonslayerSpiritmasterStaff";
                    DragonslayerSpiritmasterStaff.Name = "Dragonslayer Spiritmaster Staff";
                    DragonslayerSpiritmasterStaff.Level = 51;
                    DragonslayerSpiritmasterStaff.Item_Type = 12;
                    DragonslayerSpiritmasterStaff.Hand = 1;
                    DragonslayerSpiritmasterStaff.Model = 3928;
                    DragonslayerSpiritmasterStaff.IsDropable = true;
                    DragonslayerSpiritmasterStaff.IsPickable = true;
                    DragonslayerSpiritmasterStaff.Type_Damage = 1;
                    DragonslayerSpiritmasterStaff.DPS_AF = 165;
                    DragonslayerSpiritmasterStaff.SPD_ABS = 50;
                    DragonslayerSpiritmasterStaff.Object_Type = 8;
                    DragonslayerSpiritmasterStaff.Price = 3500;
                    DragonslayerSpiritmasterStaff.Quality = 100;
                    DragonslayerSpiritmasterStaff.IsTradable = false;
                    DragonslayerSpiritmasterStaff.Weight = 25;
                    DragonslayerSpiritmasterStaff.Bonus = 35;
                    DragonslayerSpiritmasterStaff.MaxCondition = 50000;
                    DragonslayerSpiritmasterStaff.MaxDurability = 50000;
                    DragonslayerSpiritmasterStaff.Condition = 50000;
                    DragonslayerSpiritmasterStaff.Durability = 50000;
                    DragonslayerSpiritmasterStaff.Bonus1 = 3;
                    DragonslayerSpiritmasterStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerSpiritmasterStaff.Bonus2 = 6;
                    DragonslayerSpiritmasterStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerSpiritmasterStaff.Bonus3 = 6;
                    DragonslayerSpiritmasterStaff.Bonus3Type = (int)eStat.DEX;
                    DragonslayerSpiritmasterStaff.Bonus4 = 50;
                    DragonslayerSpiritmasterStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerSpiritmasterStaff.Bonus5 = 4;
                    DragonslayerSpiritmasterStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerSpiritmasterStaff.Bonus6 = 6;
                    DragonslayerSpiritmasterStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerSpiritmasterStaff.Bonus7 = 6;
                    DragonslayerSpiritmasterStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerSpiritmasterStaff.Bonus8 = 4;
                    DragonslayerSpiritmasterStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerSpiritmasterStaff.SpellID = 32175;
                    DragonslayerSpiritmasterStaff.Charges = 100;
                    DragonslayerSpiritmasterStaff.MaxCharges = 100;
                    DragonslayerSpiritmasterStaff.SpellID1 = 32182;
                    DragonslayerSpiritmasterStaff.Charges1 = 100;
                    DragonslayerSpiritmasterStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerSpiritmasterStaff);
                }

                if (DragonslayerWarlockStaff == null)
                {
                    DragonslayerWarlockStaff = new ItemTemplate();
                    DragonslayerWarlockStaff.Id_nb = "DragonslayerWarlockStaff";
                    DragonslayerWarlockStaff.Name = "Dragonslayer Warlock Staff";
                    DragonslayerWarlockStaff.Level = 51;
                    DragonslayerWarlockStaff.Item_Type = 12;
                    DragonslayerWarlockStaff.Hand = 1;
                    DragonslayerWarlockStaff.Model = 3928;
                    DragonslayerWarlockStaff.IsDropable = true;
                    DragonslayerWarlockStaff.IsPickable = true;
                    DragonslayerWarlockStaff.Type_Damage = 1;
                    DragonslayerWarlockStaff.DPS_AF = 165;
                    DragonslayerWarlockStaff.Price = 3500;
                    DragonslayerWarlockStaff.SPD_ABS = 50;
                    DragonslayerWarlockStaff.Object_Type = 8;
                    DragonslayerWarlockStaff.Quality = 100;
                    DragonslayerWarlockStaff.IsTradable = false;
                    DragonslayerWarlockStaff.Weight = 25;
                    DragonslayerWarlockStaff.Bonus = 35;
                    DragonslayerWarlockStaff.MaxCondition = 50000;
                    DragonslayerWarlockStaff.MaxDurability = 50000;
                    DragonslayerWarlockStaff.Condition = 50000;
                    DragonslayerWarlockStaff.Durability = 50000;
                    DragonslayerWarlockStaff.Bonus1 = 3;
                    DragonslayerWarlockStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerWarlockStaff.Bonus2 = 6;
                    DragonslayerWarlockStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerWarlockStaff.Bonus3 = 6;
                    DragonslayerWarlockStaff.Bonus3Type = (int)eStat.DEX;
                    DragonslayerWarlockStaff.Bonus4 = 50;
                    DragonslayerWarlockStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerWarlockStaff.Bonus5 = 4;
                    DragonslayerWarlockStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerWarlockStaff.Bonus6 = 6;
                    DragonslayerWarlockStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerWarlockStaff.Bonus7 = 6;
                    DragonslayerWarlockStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerWarlockStaff.Bonus8 = 4;
                    DragonslayerWarlockStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerWarlockStaff.SpellID = 32175;
                    DragonslayerWarlockStaff.Charges = 100;
                    DragonslayerWarlockStaff.MaxCharges = 100;
                    DragonslayerWarlockStaff.SpellID1 = 32182;
                    DragonslayerWarlockStaff.Charges1 = 100;
                    DragonslayerWarlockStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerWarlockStaff);
                }

                if (DragonslayerAnimistStaff == null)
                {
                    DragonslayerAnimistStaff = new ItemTemplate();
                    DragonslayerAnimistStaff.Id_nb = "DragonslayerAnimistStaff";
                    DragonslayerAnimistStaff.Name = "Dragonslayer Animist Staff";
                    DragonslayerAnimistStaff.Level = 51;
                    DragonslayerAnimistStaff.Item_Type = 12;
                    DragonslayerAnimistStaff.Hand = 1;
                    DragonslayerAnimistStaff.Model = 3887;
                    DragonslayerAnimistStaff.IsDropable = true;
                    DragonslayerAnimistStaff.IsPickable = true;
                    DragonslayerAnimistStaff.Type_Damage = 1;
                    DragonslayerAnimistStaff.DPS_AF = 165;
                    DragonslayerAnimistStaff.SPD_ABS = 50;
                    DragonslayerAnimistStaff.Object_Type = 8;
                    DragonslayerAnimistStaff.Quality = 100;
                    DragonslayerAnimistStaff.IsTradable = false;
                    DragonslayerAnimistStaff.Weight = 25;
                    DragonslayerAnimistStaff.Price = 3500;
                    DragonslayerAnimistStaff.Bonus = 35;
                    DragonslayerAnimistStaff.MaxCondition = 50000;
                    DragonslayerAnimistStaff.MaxDurability = 50000;
                    DragonslayerAnimistStaff.Condition = 50000;
                    DragonslayerAnimistStaff.Durability = 50000;
                    DragonslayerAnimistStaff.Bonus1 = 3;
                    DragonslayerAnimistStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerAnimistStaff.Bonus2 = 6;
                    DragonslayerAnimistStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerAnimistStaff.Bonus3 = 6;
                    DragonslayerAnimistStaff.Bonus3Type = (int)eStat.DEX;
                    DragonslayerAnimistStaff.Bonus4 = 50;
                    DragonslayerAnimistStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerAnimistStaff.Bonus5 = 4;
                    DragonslayerAnimistStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerAnimistStaff.Bonus6 = 6;
                    DragonslayerAnimistStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerAnimistStaff.Bonus7 = 6;
                    DragonslayerAnimistStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerAnimistStaff.Bonus8 = 4;
                    DragonslayerAnimistStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerAnimistStaff.SpellID = 32175;
                    DragonslayerAnimistStaff.Charges = 100;
                    DragonslayerAnimistStaff.MaxCharges = 100;
                    DragonslayerAnimistStaff.SpellID1 = 32182;
                    DragonslayerAnimistStaff.Charges1 = 100;
                    DragonslayerAnimistStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerAnimistStaff);
                }

                if (DragonslayerBainsheeStaff == null)
                {
                    DragonslayerBainsheeStaff = new ItemTemplate();
                    DragonslayerBainsheeStaff.Id_nb = "DragonslayerBainsheeStaff";
                    DragonslayerBainsheeStaff.Name = "Dragonslayer Bainshee Staff";
                    DragonslayerBainsheeStaff.Level = 51;
                    DragonslayerBainsheeStaff.Item_Type = 12;
                    DragonslayerBainsheeStaff.Hand = 1;
                    DragonslayerBainsheeStaff.Model = 3887;
                    DragonslayerBainsheeStaff.IsDropable = true;
                    DragonslayerBainsheeStaff.IsPickable = true;
                    DragonslayerBainsheeStaff.Type_Damage = 1;
                    DragonslayerBainsheeStaff.DPS_AF = 165;
                    DragonslayerBainsheeStaff.SPD_ABS = 50;
                    DragonslayerBainsheeStaff.Price = 3500;
                    DragonslayerBainsheeStaff.Object_Type = 8;
                    DragonslayerBainsheeStaff.Quality = 100;
                    DragonslayerBainsheeStaff.IsTradable = false;
                    DragonslayerBainsheeStaff.Weight = 25;
                    DragonslayerBainsheeStaff.Bonus = 35;
                    DragonslayerBainsheeStaff.MaxCondition = 50000;
                    DragonslayerBainsheeStaff.MaxDurability = 50000;
                    DragonslayerBainsheeStaff.Condition = 50000;
                    DragonslayerBainsheeStaff.Durability = 50000;
                    DragonslayerBainsheeStaff.Bonus1 = 2;
                    DragonslayerBainsheeStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerBainsheeStaff.Bonus2 = 5;
                    DragonslayerBainsheeStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerBainsheeStaff.Bonus3 = 6;
                    DragonslayerBainsheeStaff.Bonus3Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerBainsheeStaff.Bonus4 = 50;
                    DragonslayerBainsheeStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerBainsheeStaff.Bonus5 = 4;
                    DragonslayerBainsheeStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerBainsheeStaff.Bonus6 = 6;
                    DragonslayerBainsheeStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerBainsheeStaff.Bonus7 = 6;
                    DragonslayerBainsheeStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerBainsheeStaff.Bonus8 = 4;
                    DragonslayerBainsheeStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerBainsheeStaff.SpellID = 32175;
                    DragonslayerBainsheeStaff.Charges = 100;
                    DragonslayerBainsheeStaff.MaxCharges = 100;
                    DragonslayerBainsheeStaff.SpellID1 = 32182;
                    DragonslayerBainsheeStaff.Charges1 = 100;
                    DragonslayerBainsheeStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerBainsheeStaff);
                }

                if (DragonslayerEldritchStaff == null)
                {
                    DragonslayerEldritchStaff = new ItemTemplate();
                    DragonslayerEldritchStaff.Id_nb = "DragonslayerEldritchStaff";
                    DragonslayerEldritchStaff.Name = "Dragonslayer Eldritch Staff";
                    DragonslayerEldritchStaff.Level = 51;
                    DragonslayerEldritchStaff.Item_Type = 12;
                    DragonslayerEldritchStaff.Hand = 1;
                    DragonslayerEldritchStaff.Model = 3887;
                    DragonslayerEldritchStaff.IsDropable = true;
                    DragonslayerEldritchStaff.IsPickable = true;
                    DragonslayerEldritchStaff.Type_Damage = 1;
                    DragonslayerEldritchStaff.DPS_AF = 165;
                    DragonslayerEldritchStaff.SPD_ABS = 50;
                    DragonslayerEldritchStaff.Object_Type = 8;
                    DragonslayerEldritchStaff.Quality = 100;
                    DragonslayerEldritchStaff.Price = 3500;
                    DragonslayerEldritchStaff.IsTradable = false;
                    DragonslayerEldritchStaff.Weight = 25;
                    DragonslayerEldritchStaff.Bonus = 35;
                    DragonslayerEldritchStaff.MaxCondition = 50000;
                    DragonslayerEldritchStaff.MaxDurability = 50000;
                    DragonslayerEldritchStaff.Condition = 50000;
                    DragonslayerEldritchStaff.Durability = 50000;
                    DragonslayerEldritchStaff.Bonus1 = 3;
                    DragonslayerEldritchStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerEldritchStaff.Bonus2 = 6;
                    DragonslayerEldritchStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerEldritchStaff.Bonus3 = 6;
                    DragonslayerEldritchStaff.Bonus3Type = (int)eStat.DEX;
                    DragonslayerEldritchStaff.Bonus4 = 50;
                    DragonslayerEldritchStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerEldritchStaff.Bonus5 = 4;
                    DragonslayerEldritchStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerEldritchStaff.Bonus6 = 6;
                    DragonslayerEldritchStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerEldritchStaff.Bonus7 = 6;
                    DragonslayerEldritchStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerEldritchStaff.Bonus8 = 4;
                    DragonslayerEldritchStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerEldritchStaff.SpellID = 32175;
                    DragonslayerEldritchStaff.Charges = 100;
                    DragonslayerEldritchStaff.MaxCharges = 100;
                    DragonslayerEldritchStaff.SpellID1 = 32182;
                    DragonslayerEldritchStaff.Charges1 = 100;
                    DragonslayerEldritchStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerEldritchStaff);
                }

                if (DragonslayerEnchanterStaff == null)
                {
                    DragonslayerEnchanterStaff = new ItemTemplate();
                    DragonslayerEnchanterStaff.Id_nb = "DragonslayerEnchanterStaff";
                    DragonslayerEnchanterStaff.Name = "Dragonslayer Enchanter Staff";
                    DragonslayerEnchanterStaff.Level = 51;
                    DragonslayerEnchanterStaff.Item_Type = 12;
                    DragonslayerEnchanterStaff.Hand = 1;
                    DragonslayerEnchanterStaff.Model = 3887;
                    DragonslayerEnchanterStaff.IsDropable = true;
                    DragonslayerEnchanterStaff.IsPickable = true;
                    DragonslayerEnchanterStaff.Type_Damage = 1;
                    DragonslayerEnchanterStaff.DPS_AF = 165;
                    DragonslayerEnchanterStaff.SPD_ABS = 50;
                    DragonslayerEnchanterStaff.Object_Type = 8;
                    DragonslayerEnchanterStaff.Quality = 100;
                    DragonslayerEnchanterStaff.IsTradable = false;
                    DragonslayerEnchanterStaff.Weight = 25;
                    DragonslayerEnchanterStaff.Bonus = 35;
                    DragonslayerEnchanterStaff.Price = 3500;
                    DragonslayerEnchanterStaff.MaxCondition = 50000;
                    DragonslayerEnchanterStaff.MaxDurability = 50000;
                    DragonslayerEnchanterStaff.Condition = 50000;
                    DragonslayerEnchanterStaff.Durability = 50000;
                    DragonslayerEnchanterStaff.Bonus1 = 2;
                    DragonslayerEnchanterStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerEnchanterStaff.Bonus2 = 5;
                    DragonslayerEnchanterStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerEnchanterStaff.Bonus3 = 6;
                    DragonslayerEnchanterStaff.Bonus3Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerEnchanterStaff.Bonus4 = 50;
                    DragonslayerEnchanterStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerEnchanterStaff.Bonus5 = 4;
                    DragonslayerEnchanterStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerEnchanterStaff.Bonus6 = 6;
                    DragonslayerEnchanterStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerEnchanterStaff.Bonus7 = 6;
                    DragonslayerEnchanterStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerEnchanterStaff.Bonus8 = 4;
                    DragonslayerEnchanterStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerEnchanterStaff.SpellID = 32175;
                    DragonslayerEnchanterStaff.Charges = 100;
                    DragonslayerEnchanterStaff.MaxCharges = 100;
                    DragonslayerEnchanterStaff.SpellID1 = 32182;
                    DragonslayerEnchanterStaff.Charges1 = 100;
                    DragonslayerEnchanterStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerEnchanterStaff);
                }

                if (DragonslayerMentalistStaff == null)
                {
                    DragonslayerMentalistStaff = new ItemTemplate();
                    DragonslayerMentalistStaff.Id_nb = "DragonslayerMentalistStaff";
                    DragonslayerMentalistStaff.Name = "Dragonslayer Mentalist Staff";
                    DragonslayerMentalistStaff.Level = 51;
                    DragonslayerMentalistStaff.Item_Type = 12;
                    DragonslayerMentalistStaff.Hand = 1;
                    DragonslayerMentalistStaff.Model = 3887;
                    DragonslayerMentalistStaff.IsDropable = true;
                    DragonslayerMentalistStaff.IsPickable = true;
                    DragonslayerMentalistStaff.Type_Damage = 1;
                    DragonslayerMentalistStaff.DPS_AF = 165;
                    DragonslayerMentalistStaff.SPD_ABS = 50;
                    DragonslayerMentalistStaff.Object_Type = 8;
                    DragonslayerMentalistStaff.Quality = 100;
                    DragonslayerMentalistStaff.IsTradable = false;
                    DragonslayerMentalistStaff.Weight = 25;
                    DragonslayerMentalistStaff.Price = 3500;
                    DragonslayerMentalistStaff.Bonus = 35;
                    DragonslayerMentalistStaff.MaxCondition = 50000;
                    DragonslayerMentalistStaff.MaxDurability = 50000;
                    DragonslayerMentalistStaff.Condition = 50000;
                    DragonslayerMentalistStaff.Durability = 50000;
                    DragonslayerMentalistStaff.Bonus1 = 3;
                    DragonslayerMentalistStaff.Bonus1Type = (int)eProperty.AllMagicSkills;
                    DragonslayerMentalistStaff.Bonus2 = 6;
                    DragonslayerMentalistStaff.Bonus2Type = (int)eProperty.PowerPool;
                    DragonslayerMentalistStaff.Bonus3 = 6;
                    DragonslayerMentalistStaff.Bonus3Type = (int)eStat.DEX;
                    DragonslayerMentalistStaff.Bonus4 = 50;
                    DragonslayerMentalistStaff.Bonus4Type = (int)eProperty.AllFocusLevels;
                    DragonslayerMentalistStaff.Bonus5 = 4;
                    DragonslayerMentalistStaff.Bonus5Type = (int)eProperty.CastingSpeed;
                    DragonslayerMentalistStaff.Bonus6 = 6;
                    DragonslayerMentalistStaff.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerMentalistStaff.Bonus7 = 6;
                    DragonslayerMentalistStaff.Bonus7Type = (int)eProperty.AcuCapBonus;
                    DragonslayerMentalistStaff.Bonus8 = 4;
                    DragonslayerMentalistStaff.Bonus8Type = (int)eProperty.SpellDamage;
                    DragonslayerMentalistStaff.SpellID = 32175;
                    DragonslayerMentalistStaff.Charges = 100;
                    DragonslayerMentalistStaff.MaxCharges = 100;
                    DragonslayerMentalistStaff.SpellID1 = 32182;
                    DragonslayerMentalistStaff.Charges1 = 100;
                    DragonslayerMentalistStaff.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerMentalistStaff);
                }

                if (DragonslayerWarriorAxe == null)
                {
                    DragonslayerWarriorAxe = new ItemTemplate();
                    DragonslayerWarriorAxe.Id_nb = "DragonslayerWarriorAxe";
                    DragonslayerWarriorAxe.Name = "Dragonslayer Warrior Axe";
                    DragonslayerWarriorAxe.Level = 51;
                    DragonslayerWarriorAxe.Item_Type = 10;
                    DragonslayerWarriorAxe.Model = 3942;
                    DragonslayerWarriorAxe.IsDropable = true;
                    DragonslayerWarriorAxe.IsPickable = true;
                    DragonslayerWarriorAxe.Type_Damage = 2;
                    DragonslayerWarriorAxe.DPS_AF = 165;
                    DragonslayerWarriorAxe.SPD_ABS = 43;
                    DragonslayerWarriorAxe.Price = 3500;
                    DragonslayerWarriorAxe.Object_Type = 13;
                    DragonslayerWarriorAxe.Quality = 100;
                    DragonslayerWarriorAxe.IsTradable = false;
                    DragonslayerWarriorAxe.Weight = 25;
                    DragonslayerWarriorAxe.Bonus = 35;
                    DragonslayerWarriorAxe.MaxCondition = 50000;
                    DragonslayerWarriorAxe.MaxDurability = 50000;
                    DragonslayerWarriorAxe.Condition = 50000;
                    DragonslayerWarriorAxe.Durability = 50000;
                    DragonslayerWarriorAxe.Bonus1 = 4;
                    DragonslayerWarriorAxe.Bonus1Type = (int)eProperty.Skill_Axe;
                    DragonslayerWarriorAxe.Bonus2 = 10;
                    DragonslayerWarriorAxe.Bonus2Type = (int)eStat.STR;
                    DragonslayerWarriorAxe.Bonus3 = 10;
                    DragonslayerWarriorAxe.Bonus3Type = (int)eStat.QUI;
                    DragonslayerWarriorAxe.Bonus4 = 3;
                    DragonslayerWarriorAxe.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerWarriorAxe.Bonus5 = 3;
                    DragonslayerWarriorAxe.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerWarriorAxe.Bonus6 = 8;
                    DragonslayerWarriorAxe.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerWarriorAxe.Bonus7 = 3;
                    DragonslayerWarriorAxe.Bonus7Type = (int)eProperty.MeleeSpeed;
                    DragonslayerWarriorAxe.SpellID = 32176;
                    DragonslayerWarriorAxe.Charges = 100;
                    DragonslayerWarriorAxe.MaxCharges = 100;
                    DragonslayerWarriorAxe.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerWarriorAxe);
                }

                if (DragonslayerWarriorTwohandedAxe == null)
                {
                    DragonslayerWarriorTwohandedAxe = new ItemTemplate();
                    DragonslayerWarriorTwohandedAxe.Id_nb = "DragonslayerWarriorTwohandedAxe";
                    DragonslayerWarriorTwohandedAxe.Name = "Dragonslayer Warrior Two-handed Axe";
                    DragonslayerWarriorTwohandedAxe.Level = 51;
                    DragonslayerWarriorTwohandedAxe.Item_Type = 12;
                    DragonslayerWarriorTwohandedAxe.Hand = 1;
                    DragonslayerWarriorTwohandedAxe.Model = 3923;
                    DragonslayerWarriorTwohandedAxe.IsDropable = true;
                    DragonslayerWarriorTwohandedAxe.IsPickable = true;
                    DragonslayerWarriorTwohandedAxe.Type_Damage = 2;
                    DragonslayerWarriorTwohandedAxe.DPS_AF = 165;
                    DragonslayerWarriorTwohandedAxe.SPD_ABS = 57;
                    DragonslayerWarriorTwohandedAxe.Object_Type = 13;
                    DragonslayerWarriorTwohandedAxe.Quality = 100;
                    DragonslayerWarriorTwohandedAxe.Price = 3500;
                    DragonslayerWarriorTwohandedAxe.IsTradable = false;
                    DragonslayerWarriorTwohandedAxe.Weight = 25;
                    DragonslayerWarriorTwohandedAxe.Bonus = 35;
                    DragonslayerWarriorTwohandedAxe.MaxCondition = 50000;
                    DragonslayerWarriorTwohandedAxe.MaxDurability = 50000;
                    DragonslayerWarriorTwohandedAxe.Condition = 50000;
                    DragonslayerWarriorTwohandedAxe.Durability = 50000;
                    DragonslayerWarriorTwohandedAxe.Bonus1 = 4;
                    DragonslayerWarriorTwohandedAxe.Bonus1Type = (int)eProperty.Skill_Axe;
                    DragonslayerWarriorTwohandedAxe.Bonus2 = 10;
                    DragonslayerWarriorTwohandedAxe.Bonus2Type = (int)eStat.STR;
                    DragonslayerWarriorTwohandedAxe.Bonus3 = 10;
                    DragonslayerWarriorTwohandedAxe.Bonus3Type = (int)eStat.QUI;
                    DragonslayerWarriorTwohandedAxe.Bonus4 = 3;
                    DragonslayerWarriorTwohandedAxe.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerWarriorTwohandedAxe.Bonus5 = 3;
                    DragonslayerWarriorTwohandedAxe.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerWarriorTwohandedAxe.Bonus6 = 8;
                    DragonslayerWarriorTwohandedAxe.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerWarriorTwohandedAxe.Bonus7 = 3;
                    DragonslayerWarriorTwohandedAxe.Bonus7Type = (int)eProperty.MeleeSpeed;
                    DragonslayerWarriorTwohandedAxe.SpellID = 32176;
                    DragonslayerWarriorTwohandedAxe.Charges = 100;
                    DragonslayerWarriorTwohandedAxe.MaxCharges = 100;
                    DragonslayerWarriorTwohandedAxe.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerWarriorTwohandedAxe);
                }

                if (DragonslayerWarriorSword == null)
                {
                    DragonslayerWarriorSword = new ItemTemplate();
                    DragonslayerWarriorSword.Id_nb = "DragonslayerWarriorSword";
                    DragonslayerWarriorSword.Name = "Dragonslayer Warrior Sword";
                    DragonslayerWarriorSword.Level = 51;
                    DragonslayerWarriorSword.Item_Type = 10;
                    DragonslayerWarriorSword.Model = 3936;
                    DragonslayerWarriorSword.IsDropable = true;
                    DragonslayerWarriorSword.IsPickable = true;
                    DragonslayerWarriorSword.Type_Damage = 2;
                    DragonslayerWarriorSword.DPS_AF = 165;
                    DragonslayerWarriorSword.SPD_ABS = 43;
                    DragonslayerWarriorSword.Object_Type = 11;
                    DragonslayerWarriorSword.Quality = 100;
                    DragonslayerWarriorSword.IsTradable = false;
                    DragonslayerWarriorSword.Weight = 25;
                    DragonslayerWarriorSword.Price = 3500;
                    DragonslayerWarriorSword.Bonus = 35;
                    DragonslayerWarriorSword.MaxCondition = 50000;
                    DragonslayerWarriorSword.MaxDurability = 50000;
                    DragonslayerWarriorSword.Condition = 50000;
                    DragonslayerWarriorSword.Durability = 50000;
                    DragonslayerWarriorSword.Bonus1 = 4;
                    DragonslayerWarriorSword.Bonus1Type = (int)eProperty.Skill_Sword;
                    DragonslayerWarriorSword.Bonus2 = 10;
                    DragonslayerWarriorSword.Bonus2Type = (int)eStat.STR;
                    DragonslayerWarriorSword.Bonus3 = 10;
                    DragonslayerWarriorSword.Bonus3Type = (int)eStat.QUI;
                    DragonslayerWarriorSword.Bonus4 = 3;
                    DragonslayerWarriorSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerWarriorSword.Bonus5 = 3;
                    DragonslayerWarriorSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerWarriorSword.Bonus6 = 8;
                    DragonslayerWarriorSword.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerWarriorSword.Bonus7 = 3;
                    DragonslayerWarriorSword.Bonus7Type = (int)eProperty.MeleeSpeed;
                    DragonslayerWarriorSword.SpellID = 32176;
                    DragonslayerWarriorSword.Charges = 100;
                    DragonslayerWarriorSword.MaxCharges = 100;
                    DragonslayerWarriorSword.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerWarriorSword);
                }

                if (DragonslayerWarriorTwohandedSword == null)
                {
                    DragonslayerWarriorTwohandedSword = new ItemTemplate();
                    DragonslayerWarriorTwohandedSword.Id_nb = "DragonslayerWarriorTwohandedSword";
                    DragonslayerWarriorTwohandedSword.Name = "Dragonslayer Warrior Two-handed Sword";
                    DragonslayerWarriorTwohandedSword.Level = 51;
                    DragonslayerWarriorTwohandedSword.Item_Type = 12;
                    DragonslayerWarriorTwohandedSword.Hand = 1;
                    DragonslayerWarriorTwohandedSword.Model = 3919;
                    DragonslayerWarriorTwohandedSword.IsDropable = true;
                    DragonslayerWarriorTwohandedSword.IsPickable = true;
                    DragonslayerWarriorTwohandedSword.Type_Damage = 2;
                    DragonslayerWarriorTwohandedSword.DPS_AF = 165;
                    DragonslayerWarriorTwohandedSword.SPD_ABS = 57;
                    DragonslayerWarriorTwohandedSword.Object_Type = 11;
                    DragonslayerWarriorTwohandedSword.Price = 3500;
                    DragonslayerWarriorTwohandedSword.Quality = 100;
                    DragonslayerWarriorTwohandedSword.IsTradable = false;
                    DragonslayerWarriorTwohandedSword.Weight = 25;
                    DragonslayerWarriorTwohandedSword.Bonus = 35;
                    DragonslayerWarriorTwohandedSword.MaxCondition = 50000;
                    DragonslayerWarriorTwohandedSword.MaxDurability = 50000;
                    DragonslayerWarriorTwohandedSword.Condition = 50000;
                    DragonslayerWarriorTwohandedSword.Durability = 50000;
                    DragonslayerWarriorTwohandedSword.Bonus1 = 4;
                    DragonslayerWarriorTwohandedSword.Bonus1Type = (int)eProperty.Skill_Sword;
                    DragonslayerWarriorTwohandedSword.Bonus2 = 10;
                    DragonslayerWarriorTwohandedSword.Bonus2Type = (int)eStat.STR;
                    DragonslayerWarriorTwohandedSword.Bonus3 = 10;
                    DragonslayerWarriorTwohandedSword.Bonus3Type = (int)eStat.QUI;
                    DragonslayerWarriorTwohandedSword.Bonus4 = 3;
                    DragonslayerWarriorTwohandedSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerWarriorTwohandedSword.Bonus5 = 3;
                    DragonslayerWarriorTwohandedSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerWarriorTwohandedSword.Bonus6 = 8;
                    DragonslayerWarriorTwohandedSword.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerWarriorTwohandedSword.Bonus7 = 3;
                    DragonslayerWarriorTwohandedSword.Bonus7Type = (int)eProperty.MeleeSpeed;
                    DragonslayerWarriorTwohandedSword.SpellID = 32176;
                    DragonslayerWarriorTwohandedSword.Charges = 100;
                    DragonslayerWarriorTwohandedSword.MaxCharges = 100;
                    DragonslayerWarriorTwohandedSword.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerWarriorTwohandedSword);
                }

                if (DragonslayerWarriorHammer == null)
                {
                    DragonslayerWarriorHammer = new ItemTemplate();
                    DragonslayerWarriorHammer.Id_nb = "DragonslayerWarriorHammer";
                    DragonslayerWarriorHammer.Name = "Dragonslayer Warrior Hammer";
                    DragonslayerWarriorHammer.Level = 51;
                    DragonslayerWarriorHammer.Item_Type = 10;
                    DragonslayerWarriorHammer.Model = 3938;
                    DragonslayerWarriorHammer.IsDropable = true;
                    DragonslayerWarriorHammer.IsPickable = true;
                    DragonslayerWarriorHammer.Type_Damage = 1;
                    DragonslayerWarriorHammer.DPS_AF = 165;
                    DragonslayerWarriorHammer.SPD_ABS = 43;
                    DragonslayerWarriorHammer.Price = 3500;
                    DragonslayerWarriorHammer.Object_Type = 12;
                    DragonslayerWarriorHammer.Quality = 100;
                    DragonslayerWarriorHammer.IsTradable = false;
                    DragonslayerWarriorHammer.Weight = 25;
                    DragonslayerWarriorHammer.Bonus = 35;
                    DragonslayerWarriorHammer.MaxCondition = 50000;
                    DragonslayerWarriorHammer.MaxDurability = 50000;
                    DragonslayerWarriorHammer.Condition = 50000;
                    DragonslayerWarriorHammer.Durability = 50000;
                    DragonslayerWarriorHammer.Bonus1 = 4;
                    DragonslayerWarriorHammer.Bonus1Type = (int)eProperty.Skill_Hammer;
                    DragonslayerWarriorHammer.Bonus2 = 10;
                    DragonslayerWarriorHammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerWarriorHammer.Bonus3 = 10;
                    DragonslayerWarriorHammer.Bonus3Type = (int)eStat.QUI;
                    DragonslayerWarriorHammer.Bonus4 = 3;
                    DragonslayerWarriorHammer.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerWarriorHammer.Bonus5 = 3;
                    DragonslayerWarriorHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerWarriorHammer.Bonus6 = 8;
                    DragonslayerWarriorHammer.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerWarriorHammer.Bonus7 = 3;
                    DragonslayerWarriorHammer.Bonus7Type = (int)eProperty.MeleeSpeed;
                    DragonslayerWarriorHammer.SpellID = 32176;
                    DragonslayerWarriorHammer.Charges = 100;
                    DragonslayerWarriorHammer.MaxCharges = 100;
                    DragonslayerWarriorHammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerWarriorHammer);
                }

                if (DragonslayerWarriorTwohandedHammer == null)
                {
                    DragonslayerWarriorTwohandedHammer = new ItemTemplate();
                    DragonslayerWarriorTwohandedHammer.Id_nb = "DragonslayerWarriorTwohandedHammer";
                    DragonslayerWarriorTwohandedHammer.Name = "Dragonslayer Warrior Two-handed Hammer";
                    DragonslayerWarriorTwohandedHammer.Level = 51;
                    DragonslayerWarriorTwohandedHammer.Item_Type = 12;
                    DragonslayerWarriorTwohandedHammer.Hand = 1;
                    DragonslayerWarriorTwohandedHammer.Model = 3922;
                    DragonslayerWarriorTwohandedHammer.IsDropable = true;
                    DragonslayerWarriorTwohandedHammer.IsPickable = true;
                    DragonslayerWarriorTwohandedHammer.Type_Damage = 1;
                    DragonslayerWarriorTwohandedHammer.DPS_AF = 165;
                    DragonslayerWarriorTwohandedHammer.SPD_ABS = 57;
                    DragonslayerWarriorTwohandedHammer.Object_Type = 12;
                    DragonslayerWarriorTwohandedHammer.Quality = 100;
                    DragonslayerWarriorTwohandedHammer.IsTradable = false;
                    DragonslayerWarriorTwohandedHammer.Weight = 25;
                    DragonslayerWarriorTwohandedHammer.Price = 3500;
                    DragonslayerWarriorTwohandedHammer.Bonus = 35;
                    DragonslayerWarriorTwohandedHammer.MaxCondition = 50000;
                    DragonslayerWarriorTwohandedHammer.MaxDurability = 50000;
                    DragonslayerWarriorTwohandedHammer.Condition = 50000;
                    DragonslayerWarriorTwohandedHammer.Durability = 50000;
                    DragonslayerWarriorTwohandedHammer.Bonus1 = 4;
                    DragonslayerWarriorTwohandedHammer.Bonus1Type = (int)eProperty.Skill_Hammer;
                    DragonslayerWarriorTwohandedHammer.Bonus2 = 10;
                    DragonslayerWarriorTwohandedHammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerWarriorTwohandedHammer.Bonus3 = 10;
                    DragonslayerWarriorTwohandedHammer.Bonus3Type = (int)eStat.QUI;
                    DragonslayerWarriorTwohandedHammer.Bonus4 = 3;
                    DragonslayerWarriorTwohandedHammer.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerWarriorTwohandedHammer.Bonus5 = 3;
                    DragonslayerWarriorTwohandedHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerWarriorTwohandedHammer.Bonus6 = 8;
                    DragonslayerWarriorTwohandedHammer.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerWarriorTwohandedHammer.Bonus7 = 3;
                    DragonslayerWarriorTwohandedHammer.Bonus7Type = (int)eProperty.MeleeSpeed;
                    DragonslayerWarriorTwohandedHammer.SpellID = 32176;
                    DragonslayerWarriorTwohandedHammer.Charges = 100;
                    DragonslayerWarriorTwohandedHammer.MaxCharges = 100;
                    DragonslayerWarriorTwohandedHammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerWarriorTwohandedHammer);
                }

                if (ClericDragonslayerMace == null)
                {
                    ClericDragonslayerMace = new ItemTemplate();
                    ClericDragonslayerMace.Id_nb = "ClericDragonslayerMace";
                    ClericDragonslayerMace.Name = "Cleric Dragonslayer Mace";
                    ClericDragonslayerMace.Level = 51;
                    ClericDragonslayerMace.Item_Type = 10;
                    ClericDragonslayerMace.Model = 3974;
                    ClericDragonslayerMace.IsDropable = true;
                    ClericDragonslayerMace.IsPickable = true;
                    ClericDragonslayerMace.Type_Damage = 1;
                    ClericDragonslayerMace.DPS_AF = 165;
                    ClericDragonslayerMace.SPD_ABS = 42;
                    ClericDragonslayerMace.Object_Type = 2;
                    ClericDragonslayerMace.Quality = 100;
                    ClericDragonslayerMace.Price = 3500;
                    ClericDragonslayerMace.IsTradable = false;
                    ClericDragonslayerMace.Weight = 25;
                    ClericDragonslayerMace.Bonus = 35;
                    ClericDragonslayerMace.MaxCondition = 50000;
                    ClericDragonslayerMace.MaxDurability = 50000;
                    ClericDragonslayerMace.Condition = 50000;
                    ClericDragonslayerMace.Durability = 50000;
                    ClericDragonslayerMace.Bonus1 = 6;
                    ClericDragonslayerMace.Bonus1Type = (int)eProperty.PowerPool;
                    ClericDragonslayerMace.Bonus2 = 4;
                    ClericDragonslayerMace.Bonus2Type = (int)eProperty.CastingSpeed;
                    ClericDragonslayerMace.Bonus3 = 4;
                    ClericDragonslayerMace.Bonus3Type = (int)eProperty.SpellRange;
                    ClericDragonslayerMace.Bonus4 = 5;
                    ClericDragonslayerMace.Bonus4Type = (int)eProperty.PowerPoolCapBonus;
                    ClericDragonslayerMace.Bonus5 = 6;
                    ClericDragonslayerMace.Bonus5Type = (int)eProperty.HealingEffectiveness;
                    ClericDragonslayerMace.Bonus6 = 4;
                    ClericDragonslayerMace.Bonus6Type = (int)eProperty.QuiCapBonus;
                    ClericDragonslayerMace.Bonus7 = 4;
                    ClericDragonslayerMace.Bonus7Type = (int)eProperty.QuiCapBonus;
                    ClericDragonslayerMace.SpellID = 32175;
                    ClericDragonslayerMace.Charges = 100;
                    ClericDragonslayerMace.MaxCharges = 100;
                    ClericDragonslayerMace.SpellID1 = 32182;
                    ClericDragonslayerMace.Charges1 = 100;
                    ClericDragonslayerMace.MaxCharges1 = 100;
                    GameServer.Database.AddObject(ClericDragonslayerMace);
                }

                if (FriarDragonslayerMace == null)
                {
                    FriarDragonslayerMace = new ItemTemplate();
                    FriarDragonslayerMace.Id_nb = "FriarDragonslayerMace";
                    FriarDragonslayerMace.Name = "Friar Dragonslayer Mace";
                    FriarDragonslayerMace.Level = 51;
                    FriarDragonslayerMace.Item_Type = 10;
                    FriarDragonslayerMace.Model = 3974;
                    FriarDragonslayerMace.IsDropable = true;
                    FriarDragonslayerMace.IsPickable = true;
                    FriarDragonslayerMace.Type_Damage = 1;
                    FriarDragonslayerMace.DPS_AF = 165;
                    FriarDragonslayerMace.SPD_ABS = 40;
                    FriarDragonslayerMace.Object_Type = 2;
                    FriarDragonslayerMace.Quality = 100;
                    FriarDragonslayerMace.Price = 3500;
                    FriarDragonslayerMace.IsTradable = false;
                    FriarDragonslayerMace.Weight = 25;
                    FriarDragonslayerMace.Bonus = 35;
                    FriarDragonslayerMace.MaxCondition = 50000;
                    FriarDragonslayerMace.MaxDurability = 50000;
                    FriarDragonslayerMace.Condition = 50000;
                    FriarDragonslayerMace.Durability = 50000;
                    FriarDragonslayerMace.Bonus1 = 7;
                    FriarDragonslayerMace.Bonus1Type = (int)eProperty.PowerPool;
                    FriarDragonslayerMace.Bonus2 = 9;
                    FriarDragonslayerMace.Bonus2Type = (int)eStat.DEX;
                    FriarDragonslayerMace.Bonus3 = 16;
                    FriarDragonslayerMace.Bonus3Type = (int)eProperty.MaxHealth;
                    FriarDragonslayerMace.Bonus4 = 4;
                    FriarDragonslayerMace.Bonus4Type = (int)eProperty.CastingSpeed;
                    FriarDragonslayerMace.Bonus5 = 4;
                    FriarDragonslayerMace.Bonus5Type = (int)eProperty.SpellRange;
                    FriarDragonslayerMace.Bonus6 = 6;
                    FriarDragonslayerMace.Bonus6Type = (int)eProperty.DexCapBonus;
                    FriarDragonslayerMace.Bonus7 = 6;
                    FriarDragonslayerMace.Bonus7Type = (int)eProperty.HealingEffectiveness;
                    FriarDragonslayerMace.SpellID = 32179;
                    FriarDragonslayerMace.Charges = 100;
                    FriarDragonslayerMace.MaxCharges = 100;
                    FriarDragonslayerMace.SpellID1 = 32178;
                    FriarDragonslayerMace.Charges1 = 100;
                    FriarDragonslayerMace.MaxCharges1 = 100;
                    GameServer.Database.AddObject(FriarDragonslayerMace);
                }

                if (DragonslayerValewalkerScythe == null)
                {
                    DragonslayerValewalkerScythe = new ItemTemplate();
                    DragonslayerValewalkerScythe.Id_nb = "DragonslayerValewalkerScythe";
                    DragonslayerValewalkerScythe.Name = "Dragonslayer Valewalker Scythe";
                    DragonslayerValewalkerScythe.Level = 51;
                    DragonslayerValewalkerScythe.Item_Type = 12;
                    DragonslayerValewalkerScythe.Hand = 1;
                    DragonslayerValewalkerScythe.Model = 3885;
                    DragonslayerValewalkerScythe.IsDropable = true;
                    DragonslayerValewalkerScythe.IsPickable = true;
                    DragonslayerValewalkerScythe.Type_Damage = 2;
                    DragonslayerValewalkerScythe.Price = 3500;
                    DragonslayerValewalkerScythe.DPS_AF = 165;
                    DragonslayerValewalkerScythe.SPD_ABS = 55;
                    DragonslayerValewalkerScythe.Object_Type = 26;
                    DragonslayerValewalkerScythe.Quality = 100;
                    DragonslayerValewalkerScythe.IsTradable = false;
                    DragonslayerValewalkerScythe.Weight = 25;
                    DragonslayerValewalkerScythe.Bonus = 35;
                    DragonslayerValewalkerScythe.MaxCondition = 50000;
                    DragonslayerValewalkerScythe.MaxDurability = 50000;
                    DragonslayerValewalkerScythe.Condition = 50000;
                    DragonslayerValewalkerScythe.Durability = 50000;
                    DragonslayerValewalkerScythe.Bonus1 = 4;
                    DragonslayerValewalkerScythe.Bonus1Type = (int)eProperty.Skill_Scythe;
                    DragonslayerValewalkerScythe.Bonus2 = 18;
                    DragonslayerValewalkerScythe.Bonus2Type = (int)eStat.STR;
                    DragonslayerValewalkerScythe.Bonus3 = 4;
                    DragonslayerValewalkerScythe.Bonus3Type = (int)eProperty.MeleeDamage;
                    DragonslayerValewalkerScythe.Bonus4 = 4;
                    DragonslayerValewalkerScythe.Bonus4Type = (int)eProperty.StyleDamage;
                    DragonslayerValewalkerScythe.Bonus5 = 9;
                    DragonslayerValewalkerScythe.Bonus5Type = (int)eProperty.StrCapBonus;
                    DragonslayerValewalkerScythe.SpellID = 32178;
                    DragonslayerValewalkerScythe.Charges = 100;
                    DragonslayerValewalkerScythe.MaxCharges = 100;
                    DragonslayerValewalkerScythe.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(DragonslayerValewalkerScythe);
                }

                if (VampiirDragonslayerFuarSteel == null)
                {
                    VampiirDragonslayerFuarSteel = new ItemTemplate();
                    VampiirDragonslayerFuarSteel.Id_nb = "VampiirDragonslayerFuarSteel";
                    VampiirDragonslayerFuarSteel.Name = "Vampiir Dragonslayer Fuar Steel";
                    VampiirDragonslayerFuarSteel.Level = 51;
                    VampiirDragonslayerFuarSteel.Item_Type = 10;
                    VampiirDragonslayerFuarSteel.Model = 3899;
                    VampiirDragonslayerFuarSteel.IsDropable = true;
                    VampiirDragonslayerFuarSteel.IsPickable = true;
                    VampiirDragonslayerFuarSteel.Type_Damage = 3;
                    VampiirDragonslayerFuarSteel.DPS_AF = 165;
                    VampiirDragonslayerFuarSteel.SPD_ABS = 42;
                    VampiirDragonslayerFuarSteel.Object_Type = 21;
                    VampiirDragonslayerFuarSteel.Quality = 100;
                    VampiirDragonslayerFuarSteel.Price = 3500;
                    VampiirDragonslayerFuarSteel.IsTradable = false;
                    VampiirDragonslayerFuarSteel.Weight = 25;
                    VampiirDragonslayerFuarSteel.Bonus = 35;
                    VampiirDragonslayerFuarSteel.MaxCondition = 50000;
                    VampiirDragonslayerFuarSteel.MaxDurability = 50000;
                    VampiirDragonslayerFuarSteel.Condition = 50000;
                    VampiirDragonslayerFuarSteel.Durability = 50000;
                    VampiirDragonslayerFuarSteel.Bonus1 = 4;
                    VampiirDragonslayerFuarSteel.Bonus1Type = (int)eProperty.Skill_Piercing;
                    VampiirDragonslayerFuarSteel.Bonus2 = 9;
                    VampiirDragonslayerFuarSteel.Bonus2Type = (int)eStat.DEX;
                    VampiirDragonslayerFuarSteel.Bonus3 = 7;
                    VampiirDragonslayerFuarSteel.Bonus3Type = (int)eStat.STR;
                    VampiirDragonslayerFuarSteel.Bonus4 = 4;
                    VampiirDragonslayerFuarSteel.Bonus4Type = (int)eProperty.MeleeDamage;
                    VampiirDragonslayerFuarSteel.Bonus5 = 4;
                    VampiirDragonslayerFuarSteel.Bonus5Type = (int)eProperty.StyleDamage;
                    VampiirDragonslayerFuarSteel.Bonus6 = 6;
                    VampiirDragonslayerFuarSteel.Bonus6Type = (int)eProperty.DexCapBonus;
                    VampiirDragonslayerFuarSteel.Bonus7 = 6;
                    VampiirDragonslayerFuarSteel.Bonus7Type = (int)eProperty.StrCapBonus;
                    VampiirDragonslayerFuarSteel.ProcSpellID = 32183;
                    VampiirDragonslayerFuarSteel.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(VampiirDragonslayerFuarSteel);
                }

                if (DragonslayerValkyrieSword == null)
                {
                    DragonslayerValkyrieSword = new ItemTemplate();
                    DragonslayerValkyrieSword.Id_nb = "DragonslayerValkyrieSword";
                    DragonslayerValkyrieSword.Name = "Dragonslayer Valkyrie Sword";
                    DragonslayerValkyrieSword.Level = 51;
                    DragonslayerValkyrieSword.Item_Type = 10;
                    DragonslayerValkyrieSword.Model = 3936;
                    DragonslayerValkyrieSword.IsDropable = true;
                    DragonslayerValkyrieSword.IsPickable = true;
                    DragonslayerValkyrieSword.Type_Damage = 2;
                    DragonslayerValkyrieSword.DPS_AF = 165;
                    DragonslayerValkyrieSword.SPD_ABS = 43;
                    DragonslayerValkyrieSword.Price = 3500;
                    DragonslayerValkyrieSword.Object_Type = 11;
                    DragonslayerValkyrieSword.Quality = 100;
                    DragonslayerValkyrieSword.IsTradable = false;
                    DragonslayerValkyrieSword.Weight = 25;
                    DragonslayerValkyrieSword.Bonus = 35;
                    DragonslayerValkyrieSword.MaxCondition = 50000;
                    DragonslayerValkyrieSword.MaxDurability = 50000;
                    DragonslayerValkyrieSword.Condition = 50000;
                    DragonslayerValkyrieSword.Durability = 50000;
                    DragonslayerValkyrieSword.Bonus1 = 4;
                    DragonslayerValkyrieSword.Bonus1Type = (int)eProperty.Skill_Sword;
                    DragonslayerValkyrieSword.Bonus2 = 12;
                    DragonslayerValkyrieSword.Bonus2Type = (int)eStat.QUI;
                    DragonslayerValkyrieSword.Bonus3 = 12;
                    DragonslayerValkyrieSword.Bonus3Type = (int)eStat.STR;
                    DragonslayerValkyrieSword.Bonus4 = 3;
                    DragonslayerValkyrieSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerValkyrieSword.Bonus5 = 3;
                    DragonslayerValkyrieSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerValkyrieSword.Bonus6 = 3;
                    DragonslayerValkyrieSword.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerValkyrieSword.Bonus7 = 6;
                    DragonslayerValkyrieSword.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerValkyrieSword.ProcSpellID = 32184;
                    DragonslayerValkyrieSword.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(DragonslayerValkyrieSword);
                }

                if (DragonslayerValkyrieTwohandedSword == null)
                {
                    DragonslayerValkyrieTwohandedSword = new ItemTemplate();
                    DragonslayerValkyrieTwohandedSword.Id_nb = "DragonslayerValkyrieTwohandedSword";
                    DragonslayerValkyrieTwohandedSword.Name = "Dragonslayer Valkyrie Two-handed Sword";
                    DragonslayerValkyrieTwohandedSword.Level = 51;
                    DragonslayerValkyrieTwohandedSword.Item_Type = 12;
                    DragonslayerValkyrieTwohandedSword.Hand = 1;
                    DragonslayerValkyrieTwohandedSword.Model = 3919;
                    DragonslayerValkyrieTwohandedSword.IsDropable = true;
                    DragonslayerValkyrieTwohandedSword.IsPickable = true;
                    DragonslayerValkyrieTwohandedSword.Type_Damage = 2;
                    DragonslayerValkyrieTwohandedSword.DPS_AF = 165;
                    DragonslayerValkyrieTwohandedSword.SPD_ABS = 43;
                    DragonslayerValkyrieTwohandedSword.Object_Type = 11;
                    DragonslayerValkyrieTwohandedSword.Quality = 100;
                    DragonslayerValkyrieTwohandedSword.Price = 3500;
                    DragonslayerValkyrieTwohandedSword.IsTradable = false;
                    DragonslayerValkyrieTwohandedSword.Weight = 25;
                    DragonslayerValkyrieTwohandedSword.Bonus = 35;
                    DragonslayerValkyrieTwohandedSword.MaxCondition = 50000;
                    DragonslayerValkyrieTwohandedSword.MaxDurability = 50000;
                    DragonslayerValkyrieTwohandedSword.Condition = 50000;
                    DragonslayerValkyrieTwohandedSword.Durability = 50000;
                    DragonslayerValkyrieTwohandedSword.Bonus1 = 4;
                    DragonslayerValkyrieTwohandedSword.Bonus1Type = (int)eProperty.Skill_Sword;
                    DragonslayerValkyrieTwohandedSword.Bonus2 = 12;
                    DragonslayerValkyrieTwohandedSword.Bonus2Type = (int)eStat.QUI;
                    DragonslayerValkyrieTwohandedSword.Bonus3 = 12;
                    DragonslayerValkyrieTwohandedSword.Bonus3Type = (int)eStat.STR;
                    DragonslayerValkyrieTwohandedSword.Bonus4 = 3;
                    DragonslayerValkyrieTwohandedSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerValkyrieTwohandedSword.Bonus5 = 3;
                    DragonslayerValkyrieTwohandedSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerValkyrieTwohandedSword.Bonus6 = 3;
                    DragonslayerValkyrieTwohandedSword.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerValkyrieTwohandedSword.Bonus7 = 6;
                    DragonslayerValkyrieTwohandedSword.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerValkyrieTwohandedSword.ProcSpellID = 32184;
                    DragonslayerValkyrieTwohandedSword.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(DragonslayerValkyrieTwohandedSword);
                }

                if (DragonslayerValkyrieSlashingSpear == null)
                {
                    DragonslayerValkyrieSlashingSpear = new ItemTemplate();
                    DragonslayerValkyrieSlashingSpear.Id_nb = "DragonslayerValkyrieSlashingSpear";
                    DragonslayerValkyrieSlashingSpear.Name = "Dragonslayer Valkyrie Slashing Spear";
                    DragonslayerValkyrieSlashingSpear.Level = 51;
                    DragonslayerValkyrieSlashingSpear.Item_Type = 12;
                    DragonslayerValkyrieSlashingSpear.Hand = 1;
                    DragonslayerValkyrieSlashingSpear.Model = 3921;
                    DragonslayerValkyrieSlashingSpear.IsDropable = true;
                    DragonslayerValkyrieSlashingSpear.IsPickable = true;
                    DragonslayerValkyrieSlashingSpear.Type_Damage = 2;
                    DragonslayerValkyrieSlashingSpear.DPS_AF = 165;
                    DragonslayerValkyrieSlashingSpear.SPD_ABS = 43;
                    DragonslayerValkyrieSlashingSpear.Object_Type = 14;
                    DragonslayerValkyrieSlashingSpear.Quality = 100;
                    DragonslayerValkyrieSlashingSpear.IsTradable = false;
                    DragonslayerValkyrieSlashingSpear.Weight = 25;
                    DragonslayerValkyrieSlashingSpear.Bonus = 35;
                    DragonslayerValkyrieSlashingSpear.MaxCondition = 50000;
                    DragonslayerValkyrieSlashingSpear.MaxDurability = 50000;
                    DragonslayerValkyrieSlashingSpear.Condition = 50000;
                    DragonslayerValkyrieSlashingSpear.Price = 3500;
                    DragonslayerValkyrieSlashingSpear.Durability = 50000;
                    DragonslayerValkyrieSlashingSpear.Bonus1 = 4;
                    DragonslayerValkyrieSlashingSpear.Bonus1Type = (int)eProperty.Skill_Spear;
                    DragonslayerValkyrieSlashingSpear.Bonus2 = 7;
                    DragonslayerValkyrieSlashingSpear.Bonus2Type = (int)eStat.DEX;
                    DragonslayerValkyrieSlashingSpear.Bonus3 = 7;
                    DragonslayerValkyrieSlashingSpear.Bonus3Type = (int)eStat.STR;
                    DragonslayerValkyrieSlashingSpear.Bonus4 = 3;
                    DragonslayerValkyrieSlashingSpear.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerValkyrieSlashingSpear.Bonus5 = 3;
                    DragonslayerValkyrieSlashingSpear.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerValkyrieSlashingSpear.Bonus6 = 3;
                    DragonslayerValkyrieSlashingSpear.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerValkyrieSlashingSpear.Bonus7 = 5;
                    DragonslayerValkyrieSlashingSpear.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerValkyrieSlashingSpear.Bonus8 = 5;
                    DragonslayerValkyrieSlashingSpear.Bonus8Type = (int)eProperty.DexCapBonus;
                    DragonslayerValkyrieSlashingSpear.ProcSpellID = 32184;
                    DragonslayerValkyrieSlashingSpear.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(DragonslayerValkyrieSlashingSpear);
                }

                if (DragonslayerValkyrieThrustingSpear == null)
                {
                    DragonslayerValkyrieThrustingSpear = new ItemTemplate();
                    DragonslayerValkyrieThrustingSpear.Id_nb = "DragonslayerValkyrieThrustingSpear";
                    DragonslayerValkyrieThrustingSpear.Name = "Dragonslayer Valkyrie Thrusting Spear";
                    DragonslayerValkyrieThrustingSpear.Level = 51;
                    DragonslayerValkyrieThrustingSpear.Item_Type = 12;
                    DragonslayerValkyrieThrustingSpear.Hand = 1;
                    DragonslayerValkyrieThrustingSpear.Model = 3920;
                    DragonslayerValkyrieThrustingSpear.IsDropable = true;
                    DragonslayerValkyrieThrustingSpear.IsPickable = true;
                    DragonslayerValkyrieThrustingSpear.Type_Damage = 3;
                    DragonslayerValkyrieThrustingSpear.DPS_AF = 165;
                    DragonslayerValkyrieThrustingSpear.Price = 3500;
                    DragonslayerValkyrieThrustingSpear.SPD_ABS = 43;
                    DragonslayerValkyrieThrustingSpear.Object_Type = 14;
                    DragonslayerValkyrieThrustingSpear.Quality = 100;
                    DragonslayerValkyrieThrustingSpear.IsTradable = false;
                    DragonslayerValkyrieThrustingSpear.Weight = 25;
                    DragonslayerValkyrieThrustingSpear.Bonus = 35;
                    DragonslayerValkyrieThrustingSpear.MaxCondition = 50000;
                    DragonslayerValkyrieThrustingSpear.MaxDurability = 50000;
                    DragonslayerValkyrieThrustingSpear.Condition = 50000;
                    DragonslayerValkyrieThrustingSpear.Durability = 50000;
                    DragonslayerValkyrieThrustingSpear.Bonus1 = 4;
                    DragonslayerValkyrieThrustingSpear.Bonus1Type = (int)eProperty.Skill_Spear;
                    DragonslayerValkyrieThrustingSpear.Bonus2 = 7;
                    DragonslayerValkyrieThrustingSpear.Bonus2Type = (int)eStat.DEX;
                    DragonslayerValkyrieThrustingSpear.Bonus3 = 7;
                    DragonslayerValkyrieThrustingSpear.Bonus3Type = (int)eStat.STR;
                    DragonslayerValkyrieThrustingSpear.Bonus4 = 3;
                    DragonslayerValkyrieThrustingSpear.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerValkyrieThrustingSpear.Bonus5 = 3;
                    DragonslayerValkyrieThrustingSpear.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerValkyrieThrustingSpear.Bonus6 = 3;
                    DragonslayerValkyrieThrustingSpear.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerValkyrieThrustingSpear.Bonus7 = 5;
                    DragonslayerValkyrieThrustingSpear.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerValkyrieThrustingSpear.Bonus8 = 5;
                    DragonslayerValkyrieThrustingSpear.Bonus8Type = (int)eProperty.DexCapBonus;
                    DragonslayerValkyrieThrustingSpear.ProcSpellID = 32184;
                    DragonslayerValkyrieThrustingSpear.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(DragonslayerValkyrieThrustingSpear);
                }

                if (DragonslayerHealerHammer == null)
                {
                    DragonslayerHealerHammer = new ItemTemplate();
                    DragonslayerHealerHammer.Id_nb = "DragonslayerHealerHammer";
                    DragonslayerHealerHammer.Name = "Dragonslayer Healer Hammer";
                    DragonslayerHealerHammer.Level = 51;
                    DragonslayerHealerHammer.Item_Type = 10;
                    DragonslayerHealerHammer.Model = 3938;
                    DragonslayerHealerHammer.IsDropable = true;
                    DragonslayerHealerHammer.IsPickable = true;
                    DragonslayerHealerHammer.Type_Damage = 1;
                    DragonslayerHealerHammer.DPS_AF = 165;
                    DragonslayerHealerHammer.Price = 3500;
                    DragonslayerHealerHammer.SPD_ABS = 43;
                    DragonslayerHealerHammer.Object_Type = 12;
                    DragonslayerHealerHammer.Quality = 100;
                    DragonslayerHealerHammer.IsTradable = false;
                    DragonslayerHealerHammer.Weight = 25;
                    DragonslayerHealerHammer.Bonus = 35;
                    DragonslayerHealerHammer.MaxCondition = 50000;
                    DragonslayerHealerHammer.MaxDurability = 50000;
                    DragonslayerHealerHammer.Condition = 50000;
                    DragonslayerHealerHammer.Durability = 50000;
                    DragonslayerHealerHammer.Bonus1 = 6;
                    DragonslayerHealerHammer.Bonus1Type = (int)eProperty.PowerPool;
                    DragonslayerHealerHammer.Bonus2 = 4;
                    DragonslayerHealerHammer.Bonus2Type = (int)eProperty.CastingSpeed;
                    DragonslayerHealerHammer.Bonus3 = 4;
                    DragonslayerHealerHammer.Bonus3Type = (int)eProperty.SpellRange;
                    DragonslayerHealerHammer.Bonus4 = 5;
                    DragonslayerHealerHammer.Bonus4Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerHealerHammer.Bonus5 = 6;
                    DragonslayerHealerHammer.Bonus5Type = (int)eProperty.HealingEffectiveness;
                    DragonslayerHealerHammer.Bonus6 = 4;
                    DragonslayerHealerHammer.Bonus6Type = (int)eProperty.AcuCapBonus;
                    DragonslayerHealerHammer.Bonus7 = 4;
                    DragonslayerHealerHammer.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerHealerHammer.SpellID = 32175;
                    DragonslayerHealerHammer.Charges = 100;
                    DragonslayerHealerHammer.MaxCharges = 100;
                    DragonslayerHealerHammer.SpellID1 = 32185;
                    DragonslayerHealerHammer.Charges1 = 100;
                    DragonslayerHealerHammer.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerHealerHammer);
                }

                if (DragonslayerHealerTwohandedHammer == null)
                {
                    DragonslayerHealerTwohandedHammer = new ItemTemplate();
                    DragonslayerHealerTwohandedHammer.Id_nb = "DragonslayerHealerTwohandedHammer";
                    DragonslayerHealerTwohandedHammer.Name = "Dragonslayer Healer Two-handed Hammer";
                    DragonslayerHealerTwohandedHammer.Level = 51;
                    DragonslayerHealerTwohandedHammer.Item_Type = 12;
                    DragonslayerHealerTwohandedHammer.Hand = 1;
                    DragonslayerHealerTwohandedHammer.Model = 3922;
                    DragonslayerHealerTwohandedHammer.IsDropable = true;
                    DragonslayerHealerTwohandedHammer.IsPickable = true;
                    DragonslayerHealerTwohandedHammer.Type_Damage = 1;
                    DragonslayerHealerTwohandedHammer.DPS_AF = 165;
                    DragonslayerHealerTwohandedHammer.SPD_ABS = 57;
                    DragonslayerHealerTwohandedHammer.Price = 3500;
                    DragonslayerHealerTwohandedHammer.Object_Type = 12;
                    DragonslayerHealerTwohandedHammer.Quality = 100;
                    DragonslayerHealerTwohandedHammer.IsTradable = false;
                    DragonslayerHealerTwohandedHammer.Weight = 25;
                    DragonslayerHealerTwohandedHammer.Bonus = 35;
                    DragonslayerHealerTwohandedHammer.MaxCondition = 50000;
                    DragonslayerHealerTwohandedHammer.MaxDurability = 50000;
                    DragonslayerHealerTwohandedHammer.Condition = 50000;
                    DragonslayerHealerTwohandedHammer.Durability = 50000;
                    DragonslayerHealerTwohandedHammer.Bonus1 = 6;
                    DragonslayerHealerTwohandedHammer.Bonus1Type = (int)eProperty.PowerPool;
                    DragonslayerHealerTwohandedHammer.Bonus2 = 4;
                    DragonslayerHealerTwohandedHammer.Bonus2Type = (int)eProperty.CastingSpeed;
                    DragonslayerHealerTwohandedHammer.Bonus3 = 4;
                    DragonslayerHealerTwohandedHammer.Bonus3Type = (int)eProperty.SpellRange;
                    DragonslayerHealerTwohandedHammer.Bonus4 = 5;
                    DragonslayerHealerTwohandedHammer.Bonus4Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerHealerTwohandedHammer.Bonus5 = 6;
                    DragonslayerHealerTwohandedHammer.Bonus5Type = (int)eProperty.HealingEffectiveness;
                    DragonslayerHealerTwohandedHammer.Bonus6 = 4;
                    DragonslayerHealerTwohandedHammer.Bonus6Type = (int)eProperty.AcuCapBonus;
                    DragonslayerHealerTwohandedHammer.Bonus7 = 4;
                    DragonslayerHealerTwohandedHammer.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerHealerTwohandedHammer.SpellID = 32175;
                    DragonslayerHealerTwohandedHammer.Charges = 100;
                    DragonslayerHealerTwohandedHammer.MaxCharges = 100;
                    DragonslayerHealerTwohandedHammer.SpellID1 = 32185;
                    DragonslayerHealerTwohandedHammer.Charges1 = 100;
                    DragonslayerHealerTwohandedHammer.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerHealerTwohandedHammer);
                }

                if (DragonslayerShamanHammer == null)
                {
                    DragonslayerShamanHammer = new ItemTemplate();
                    DragonslayerShamanHammer.Id_nb = "DragonslayerShamanHammer";
                    DragonslayerShamanHammer.Name = "Dragonslayer Shaman Hammer";
                    DragonslayerShamanHammer.Level = 51;
                    DragonslayerShamanHammer.Item_Type = 10;
                    DragonslayerShamanHammer.Model = 3938;
                    DragonslayerShamanHammer.IsDropable = true;
                    DragonslayerShamanHammer.IsPickable = true;
                    DragonslayerShamanHammer.Type_Damage = 1;
                    DragonslayerShamanHammer.DPS_AF = 165;
                    DragonslayerShamanHammer.Price = 3500;
                    DragonslayerShamanHammer.SPD_ABS = 43;
                    DragonslayerShamanHammer.Object_Type = 12;
                    DragonslayerShamanHammer.Quality = 100;
                    DragonslayerShamanHammer.IsTradable = false;
                    DragonslayerShamanHammer.Weight = 25;
                    DragonslayerShamanHammer.Bonus = 35;
                    DragonslayerShamanHammer.MaxCondition = 50000;
                    DragonslayerShamanHammer.MaxDurability = 50000;
                    DragonslayerShamanHammer.Condition = 50000;
                    DragonslayerShamanHammer.Durability = 50000;
                    DragonslayerShamanHammer.Bonus1 = 6;
                    DragonslayerShamanHammer.Bonus1Type = (int)eProperty.PowerPool;
                    DragonslayerShamanHammer.Bonus2 = 4;
                    DragonslayerShamanHammer.Bonus2Type = (int)eProperty.CastingSpeed;
                    DragonslayerShamanHammer.Bonus3 = 4;
                    DragonslayerShamanHammer.Bonus3Type = (int)eProperty.SpellRange;
                    DragonslayerShamanHammer.Bonus4 = 5;
                    DragonslayerShamanHammer.Bonus4Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerShamanHammer.Bonus5 = 6;
                    DragonslayerShamanHammer.Bonus5Type = (int)eProperty.HealingEffectiveness;
                    DragonslayerShamanHammer.Bonus6 = 4;
                    DragonslayerShamanHammer.Bonus6Type = (int)eProperty.AcuCapBonus;
                    DragonslayerShamanHammer.Bonus7 = 4;
                    DragonslayerShamanHammer.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerShamanHammer.SpellID = 32175;
                    DragonslayerShamanHammer.Charges = 100;
                    DragonslayerShamanHammer.MaxCharges = 100;
                    DragonslayerShamanHammer.SpellID1 = 32185;
                    DragonslayerShamanHammer.Charges1 = 100;
                    DragonslayerShamanHammer.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerShamanHammer);
                }

                if (DragonslayerShamanTwohandedHammer == null)
                {
                    DragonslayerShamanTwohandedHammer = new ItemTemplate();
                    DragonslayerShamanTwohandedHammer.Id_nb = "DragonslayerShamanTwohandedHammer";
                    DragonslayerShamanTwohandedHammer.Name = "Dragonslayer Shaman Two-handed Hammer";
                    DragonslayerShamanTwohandedHammer.Level = 51;
                    DragonslayerShamanTwohandedHammer.Item_Type = 12;
                    DragonslayerShamanTwohandedHammer.Hand = 1;
                    DragonslayerShamanTwohandedHammer.Model = 3922;
                    DragonslayerShamanTwohandedHammer.IsDropable = true;
                    DragonslayerShamanTwohandedHammer.IsPickable = true;
                    DragonslayerShamanTwohandedHammer.Type_Damage = 1;
                    DragonslayerShamanTwohandedHammer.DPS_AF = 165;
                    DragonslayerShamanTwohandedHammer.SPD_ABS = 57;
                    DragonslayerShamanTwohandedHammer.Price = 3500;
                    DragonslayerShamanTwohandedHammer.Object_Type = 12;
                    DragonslayerShamanTwohandedHammer.Quality = 100;
                    DragonslayerShamanTwohandedHammer.IsTradable = false;
                    DragonslayerShamanTwohandedHammer.Weight = 25;
                    DragonslayerShamanTwohandedHammer.Bonus = 35;
                    DragonslayerShamanTwohandedHammer.MaxCondition = 50000;
                    DragonslayerShamanTwohandedHammer.MaxDurability = 50000;
                    DragonslayerShamanTwohandedHammer.Condition = 50000;
                    DragonslayerShamanTwohandedHammer.Durability = 50000;
                    DragonslayerShamanTwohandedHammer.Bonus1 = 6;
                    DragonslayerShamanTwohandedHammer.Bonus1Type = (int)eProperty.PowerPool;
                    DragonslayerShamanTwohandedHammer.Bonus2 = 4;
                    DragonslayerShamanTwohandedHammer.Bonus2Type = (int)eProperty.CastingSpeed;
                    DragonslayerShamanTwohandedHammer.Bonus3 = 4;
                    DragonslayerShamanTwohandedHammer.Bonus3Type = (int)eProperty.SpellRange;
                    DragonslayerShamanTwohandedHammer.Bonus4 = 5;
                    DragonslayerShamanTwohandedHammer.Bonus4Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerShamanTwohandedHammer.Bonus5 = 6;
                    DragonslayerShamanTwohandedHammer.Bonus5Type = (int)eProperty.HealingEffectiveness;
                    DragonslayerShamanTwohandedHammer.Bonus6 = 4;
                    DragonslayerShamanTwohandedHammer.Bonus6Type = (int)eProperty.AcuCapBonus;
                    DragonslayerShamanTwohandedHammer.Bonus7 = 4;
                    DragonslayerShamanTwohandedHammer.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerShamanTwohandedHammer.SpellID = 32175;
                    DragonslayerShamanTwohandedHammer.Charges = 100;
                    DragonslayerShamanTwohandedHammer.MaxCharges = 100;
                    DragonslayerShamanTwohandedHammer.SpellID1 = 32185;
                    DragonslayerShamanTwohandedHammer.Charges1 = 100;
                    DragonslayerShamanTwohandedHammer.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerShamanTwohandedHammer);
                }

                if (HereticDragonslayerBarbedChain == null)
                {
                    HereticDragonslayerBarbedChain = new ItemTemplate();
                    HereticDragonslayerBarbedChain.Id_nb = "HereticDragonslayerBarbedChain";
                    HereticDragonslayerBarbedChain.Name = "Heretic Dragonslayer Barbed Chain";
                    HereticDragonslayerBarbedChain.Level = 51;
                    HereticDragonslayerBarbedChain.Item_Type = 10;
                    HereticDragonslayerBarbedChain.Model = 3951;
                    HereticDragonslayerBarbedChain.IsDropable = true;
                    HereticDragonslayerBarbedChain.IsPickable = true;
                    HereticDragonslayerBarbedChain.Type_Damage = 2;
                    HereticDragonslayerBarbedChain.DPS_AF = 165;
                    HereticDragonslayerBarbedChain.SPD_ABS = 35;
                    HereticDragonslayerBarbedChain.Price = 3500;
                    HereticDragonslayerBarbedChain.Object_Type = 24;
                    HereticDragonslayerBarbedChain.Quality = 100;
                    HereticDragonslayerBarbedChain.IsTradable = false;
                    HereticDragonslayerBarbedChain.Weight = 25;
                    HereticDragonslayerBarbedChain.Bonus = 35;
                    HereticDragonslayerBarbedChain.MaxCondition = 50000;
                    HereticDragonslayerBarbedChain.MaxDurability = 50000;
                    HereticDragonslayerBarbedChain.Condition = 50000;
                    HereticDragonslayerBarbedChain.Durability = 50000;
                    HereticDragonslayerBarbedChain.Bonus1 = 12;
                    HereticDragonslayerBarbedChain.Bonus1Type = (int)eStat.DEX;
                    HereticDragonslayerBarbedChain.Bonus2 = 12;
                    HereticDragonslayerBarbedChain.Bonus2Type = (int)eStat.STR;
                    HereticDragonslayerBarbedChain.Bonus3 = 4;
                    HereticDragonslayerBarbedChain.Bonus3Type = (int)eProperty.MeleeDamage;
                    HereticDragonslayerBarbedChain.Bonus4 = 4;
                    HereticDragonslayerBarbedChain.Bonus4Type = (int)eProperty.SpellDamage;
                    HereticDragonslayerBarbedChain.Bonus5 = 8;
                    HereticDragonslayerBarbedChain.Bonus5Type = (int)eProperty.DexCapBonus;
                    HereticDragonslayerBarbedChain.SpellID = 32175;
                    HereticDragonslayerBarbedChain.Charges = 100;
                    HereticDragonslayerBarbedChain.MaxCharges = 100;
                    HereticDragonslayerBarbedChain.SpellID1 = 32182;
                    HereticDragonslayerBarbedChain.Charges1 = 100;
                    HereticDragonslayerBarbedChain.MaxCharges1 = 100;
                    GameServer.Database.AddObject(HereticDragonslayerBarbedChain);
                }

                if (HereticDragonslayerFlail == null)
                {
                    HereticDragonslayerFlail = new ItemTemplate();
                    HereticDragonslayerFlail.Id_nb = "HereticDragonslayerFlail";
                    HereticDragonslayerFlail.Name = "Heretic Dragonslayer Flail";
                    HereticDragonslayerFlail.Level = 51;
                    HereticDragonslayerFlail.Item_Type = 10;
                    HereticDragonslayerFlail.Model = 3952;
                    HereticDragonslayerFlail.IsDropable = true;
                    HereticDragonslayerFlail.IsPickable = true;
                    HereticDragonslayerFlail.Type_Damage = 1;
                    HereticDragonslayerFlail.DPS_AF = 165;
                    HereticDragonslayerFlail.SPD_ABS = 35;
                    HereticDragonslayerFlail.Price = 3500;
                    HereticDragonslayerFlail.Object_Type = 24;
                    HereticDragonslayerFlail.Quality = 100;
                    HereticDragonslayerFlail.IsTradable = false;
                    HereticDragonslayerFlail.Weight = 25;
                    HereticDragonslayerFlail.Bonus = 35;
                    HereticDragonslayerFlail.MaxCondition = 50000;
                    HereticDragonslayerFlail.MaxDurability = 50000;
                    HereticDragonslayerFlail.Condition = 50000;
                    HereticDragonslayerFlail.Durability = 50000;
                    HereticDragonslayerFlail.Bonus1 = 12;
                    HereticDragonslayerFlail.Bonus1Type = (int)eStat.DEX;
                    HereticDragonslayerFlail.Bonus2 = 12;
                    HereticDragonslayerFlail.Bonus2Type = (int)eStat.STR;
                    HereticDragonslayerFlail.Bonus3 = 4;
                    HereticDragonslayerFlail.Bonus3Type = (int)eProperty.MeleeDamage;
                    HereticDragonslayerFlail.Bonus4 = 4;
                    HereticDragonslayerFlail.Bonus4Type = (int)eProperty.SpellDamage;
                    HereticDragonslayerFlail.Bonus5 = 8;
                    HereticDragonslayerFlail.Bonus5Type = (int)eProperty.DexCapBonus;
                    HereticDragonslayerFlail.Bonus6 = 7;
                    HereticDragonslayerFlail.Bonus6Type = (int)eProperty.StrCapBonus;
                    HereticDragonslayerFlail.SpellID = 32175;
                    HereticDragonslayerFlail.Charges = 100;
                    HereticDragonslayerFlail.MaxCharges = 100;
                    HereticDragonslayerFlail.SpellID1 = 32182;
                    HereticDragonslayerFlail.Charges1 = 100;
                    HereticDragonslayerFlail.MaxCharges1 = 100;
                    GameServer.Database.AddObject(HereticDragonslayerFlail);
                }

                if (HereticDragonslayerMace == null)
                {
                    HereticDragonslayerMace = new ItemTemplate();
                    HereticDragonslayerMace.Id_nb = "HereticDragonslayerMace";
                    HereticDragonslayerMace.Name = "Heretic Dragonslayer Mace";
                    HereticDragonslayerMace.Level = 51;
                    HereticDragonslayerMace.Item_Type = 10;
                    HereticDragonslayerMace.Model = 3974;
                    HereticDragonslayerMace.IsDropable = true;
                    HereticDragonslayerMace.IsPickable = true;
                    HereticDragonslayerMace.Type_Damage = 1;
                    HereticDragonslayerMace.DPS_AF = 165;
                    HereticDragonslayerMace.SPD_ABS = 42;
                    HereticDragonslayerMace.Object_Type = 2;
                    HereticDragonslayerMace.Quality = 100;
                    HereticDragonslayerMace.Price = 3500;
                    HereticDragonslayerMace.IsTradable = false;
                    HereticDragonslayerMace.Weight = 25;
                    HereticDragonslayerMace.Bonus = 35;
                    HereticDragonslayerMace.MaxCondition = 50000;
                    HereticDragonslayerMace.MaxDurability = 50000;
                    HereticDragonslayerMace.Condition = 50000;
                    HereticDragonslayerMace.Durability = 50000;
                    HereticDragonslayerMace.Bonus1 = 8;
                    HereticDragonslayerMace.Bonus1Type = (int)eProperty.PowerPool;
                    HereticDragonslayerMace.Bonus2 = 9;
                    HereticDragonslayerMace.Bonus2Type = (int)eProperty.Acuity;
                    HereticDragonslayerMace.Bonus3 = 4;
                    HereticDragonslayerMace.Bonus3Type = (int)eProperty.MeleeSpeed;
                    HereticDragonslayerMace.Bonus4 = 4;
                    HereticDragonslayerMace.Bonus4Type = (int)eProperty.SpellDamage;
                    HereticDragonslayerMace.Bonus5 = 8;
                    HereticDragonslayerMace.Bonus5Type = (int)eProperty.HealingEffectiveness;
                    HereticDragonslayerMace.Bonus6 = 4;
                    HereticDragonslayerMace.Bonus6Type = (int)eProperty.SpellDuration;
                    HereticDragonslayerMace.SpellID = 32175;
                    HereticDragonslayerMace.Charges = 100;
                    HereticDragonslayerMace.MaxCharges = 100;
                    HereticDragonslayerMace.SpellID1 = 32182;
                    HereticDragonslayerMace.Charges1 = 100;
                    HereticDragonslayerMace.MaxCharges1 = 100;
                    GameServer.Database.AddObject(HereticDragonslayerMace);
                }

                if (ReaverDragonslayerBlade == null)
                {
                    ReaverDragonslayerBlade = new ItemTemplate();
                    ReaverDragonslayerBlade.Id_nb = "ReaverDragonslayerBlade";
                    ReaverDragonslayerBlade.Name = "Reaver Dragonslayer Blade";
                    ReaverDragonslayerBlade.Level = 51;
                    ReaverDragonslayerBlade.Item_Type = 3;
                    ReaverDragonslayerBlade.Model = 3972;
                    ReaverDragonslayerBlade.IsDropable = true;
                    ReaverDragonslayerBlade.IsPickable = true;
                    ReaverDragonslayerBlade.Type_Damage = 1;
                    ReaverDragonslayerBlade.DPS_AF = 165;
                    ReaverDragonslayerBlade.SPD_ABS = 42;
                    ReaverDragonslayerBlade.Price = 3500;
                    ReaverDragonslayerBlade.Object_Type = 2;
                    ReaverDragonslayerBlade.Quality = 100;
                    ReaverDragonslayerBlade.IsTradable = false;
                    ReaverDragonslayerBlade.Weight = 25;
                    ReaverDragonslayerBlade.Bonus = 35;
                    ReaverDragonslayerBlade.MaxCondition = 50000;
                    ReaverDragonslayerBlade.MaxDurability = 50000;
                    ReaverDragonslayerBlade.Condition = 50000;
                    ReaverDragonslayerBlade.Durability = 50000;
                    ReaverDragonslayerBlade.Bonus1 = 4;
                    ReaverDragonslayerBlade.Bonus1Type = (int)eProperty.Skill_Slashing;
                    ReaverDragonslayerBlade.Bonus2 = 12;
                    ReaverDragonslayerBlade.Bonus2Type = (int)eStat.STR;
                    ReaverDragonslayerBlade.Bonus3 = 12;
                    ReaverDragonslayerBlade.Bonus3Type = (int)eStat.QUI;
                    ReaverDragonslayerBlade.Bonus4 = 3;
                    ReaverDragonslayerBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    ReaverDragonslayerBlade.Bonus5 = 3;
                    ReaverDragonslayerBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    ReaverDragonslayerBlade.Bonus6 = 3;
                    ReaverDragonslayerBlade.Bonus6Type = (int)eProperty.SpellDamage;
                    ReaverDragonslayerBlade.Bonus7 = 7;
                    ReaverDragonslayerBlade.Bonus7Type = (int)eProperty.StrCapBonus;
                    ReaverDragonslayerBlade.SpellID = 32178;
                    ReaverDragonslayerBlade.Charges = 100;
                    ReaverDragonslayerBlade.MaxCharges = 100;
                    ReaverDragonslayerBlade.ProcSpellID = 32186;
                    GameServer.Database.AddObject(ReaverDragonslayerBlade);
                }

                if (ReaverDragonslayerEdge == null)
                {
                    ReaverDragonslayerEdge = new ItemTemplate();
                    ReaverDragonslayerEdge.Id_nb = "ReaverDragonslayerEdge";
                    ReaverDragonslayerEdge.Name = "Reaver Dragonslayer Edge";
                    ReaverDragonslayerEdge.Level = 51;
                    ReaverDragonslayerEdge.Item_Type = 10;
                    ReaverDragonslayerEdge.Model = 3976;
                    ReaverDragonslayerEdge.IsDropable = true;
                    ReaverDragonslayerEdge.IsPickable = true;
                    ReaverDragonslayerEdge.Type_Damage = 3;
                    ReaverDragonslayerEdge.DPS_AF = 165;
                    ReaverDragonslayerEdge.SPD_ABS = 42;
                    ReaverDragonslayerEdge.Object_Type = 4;
                    ReaverDragonslayerEdge.Price = 3500;
                    ReaverDragonslayerEdge.Quality = 100;
                    ReaverDragonslayerEdge.IsTradable = false;
                    ReaverDragonslayerEdge.Weight = 25;
                    ReaverDragonslayerEdge.Bonus = 35;
                    ReaverDragonslayerEdge.MaxCondition = 50000;
                    ReaverDragonslayerEdge.MaxDurability = 50000;
                    ReaverDragonslayerEdge.Condition = 50000;
                    ReaverDragonslayerEdge.Durability = 50000;
                    ReaverDragonslayerEdge.Bonus1 = 4;
                    ReaverDragonslayerEdge.Bonus1Type = (int)eProperty.Skill_Thrusting;
                    ReaverDragonslayerEdge.Bonus2 = 7;
                    ReaverDragonslayerEdge.Bonus2Type = (int)eStat.STR;
                    ReaverDragonslayerEdge.Bonus3 = 7;
                    ReaverDragonslayerEdge.Bonus3Type = (int)eStat.QUI;
                    ReaverDragonslayerEdge.Bonus4 = 3;
                    ReaverDragonslayerEdge.Bonus4Type = (int)eProperty.MeleeDamage;
                    ReaverDragonslayerEdge.Bonus5 = 3;
                    ReaverDragonslayerEdge.Bonus5Type = (int)eProperty.StyleDamage;
                    ReaverDragonslayerEdge.Bonus6 = 3;
                    ReaverDragonslayerEdge.Bonus6Type = (int)eProperty.SpellDamage;
                    ReaverDragonslayerEdge.Bonus7 = 5;
                    ReaverDragonslayerEdge.Bonus7Type = (int)eProperty.StrCapBonus;
                    ReaverDragonslayerEdge.Bonus8 = 5;
                    ReaverDragonslayerEdge.Bonus8Type = (int)eProperty.DexCapBonus;
                    ReaverDragonslayerEdge.SpellID = 32178;
                    ReaverDragonslayerEdge.Charges = 100;
                    ReaverDragonslayerEdge.MaxCharges = 100;
                    ReaverDragonslayerEdge.ProcSpellID = 32186;
                    GameServer.Database.AddObject(ReaverDragonslayerEdge);
                }

                if (ReaverDragonslayerMace == null)
                {
                    ReaverDragonslayerMace = new ItemTemplate();
                    ReaverDragonslayerMace.Id_nb = "ReaverDragonslayerMace";
                    ReaverDragonslayerMace.Name = "Reaver Dragonslayer Mace";
                    ReaverDragonslayerMace.Level = 51;
                    ReaverDragonslayerMace.Item_Type = 10;
                    ReaverDragonslayerMace.Model = 3974;
                    ReaverDragonslayerMace.IsDropable = true;
                    ReaverDragonslayerMace.IsPickable = true;
                    ReaverDragonslayerMace.Type_Damage = 1;
                    ReaverDragonslayerMace.DPS_AF = 165;
                    ReaverDragonslayerMace.Price = 3500;
                    ReaverDragonslayerMace.SPD_ABS = 42;
                    ReaverDragonslayerMace.Object_Type = 2;
                    ReaverDragonslayerMace.Quality = 100;
                    ReaverDragonslayerMace.IsTradable = false;
                    ReaverDragonslayerMace.Weight = 25;
                    ReaverDragonslayerMace.Bonus = 35;
                    ReaverDragonslayerMace.MaxCondition = 50000;
                    ReaverDragonslayerMace.MaxDurability = 50000;
                    ReaverDragonslayerMace.Condition = 50000;
                    ReaverDragonslayerMace.Durability = 50000;
                    ReaverDragonslayerMace.Bonus1 = 4;
                    ReaverDragonslayerMace.Bonus1Type = (int)eProperty.Skill_Crushing;
                    ReaverDragonslayerMace.Bonus2 = 12;
                    ReaverDragonslayerMace.Bonus2Type = (int)eStat.STR;
                    ReaverDragonslayerMace.Bonus3 = 12;
                    ReaverDragonslayerMace.Bonus3Type = (int)eStat.QUI;
                    ReaverDragonslayerMace.Bonus4 = 3;
                    ReaverDragonslayerMace.Bonus4Type = (int)eProperty.MeleeDamage;
                    ReaverDragonslayerMace.Bonus5 = 3;
                    ReaverDragonslayerMace.Bonus5Type = (int)eProperty.StyleDamage;
                    ReaverDragonslayerMace.Bonus6 = 3;
                    ReaverDragonslayerMace.Bonus6Type = (int)eProperty.SpellDamage;
                    ReaverDragonslayerMace.Bonus7 = 7;
                    ReaverDragonslayerMace.Bonus7Type = (int)eProperty.StrCapBonus;
                    ReaverDragonslayerMace.SpellID = 32178;
                    ReaverDragonslayerMace.Charges = 100;
                    ReaverDragonslayerMace.MaxCharges = 100;
                    ReaverDragonslayerMace.ProcSpellID = 32186;
                    GameServer.Database.AddObject(ReaverDragonslayerMace);
                }

                if (ReaverDragonslayerBarbedChain == null)
                {
                    ReaverDragonslayerBarbedChain = new ItemTemplate();
                    ReaverDragonslayerBarbedChain.Id_nb = "ReaverDragonslayerBarbedChain";
                    ReaverDragonslayerBarbedChain.Name = "Reaver Dragonslayer Barbed Chain";
                    ReaverDragonslayerBarbedChain.Level = 51;
                    ReaverDragonslayerBarbedChain.Item_Type = 10;
                    ReaverDragonslayerBarbedChain.Model = 3951;
                    ReaverDragonslayerBarbedChain.IsDropable = true;
                    ReaverDragonslayerBarbedChain.IsPickable = true;
                    ReaverDragonslayerBarbedChain.Type_Damage = 2;
                    ReaverDragonslayerBarbedChain.DPS_AF = 165;
                    ReaverDragonslayerBarbedChain.SPD_ABS = 35;
                    ReaverDragonslayerBarbedChain.Object_Type = 24;
                    ReaverDragonslayerBarbedChain.Quality = 100;
                    ReaverDragonslayerBarbedChain.Price = 3500;
                    ReaverDragonslayerBarbedChain.IsTradable = false;
                    ReaverDragonslayerBarbedChain.Weight = 25;
                    ReaverDragonslayerBarbedChain.Bonus = 35;
                    ReaverDragonslayerBarbedChain.MaxCondition = 50000;
                    ReaverDragonslayerBarbedChain.MaxDurability = 50000;
                    ReaverDragonslayerBarbedChain.Condition = 50000;
                    ReaverDragonslayerBarbedChain.Durability = 50000;
                    ReaverDragonslayerBarbedChain.Bonus1 = 4;
                    ReaverDragonslayerBarbedChain.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    ReaverDragonslayerBarbedChain.Bonus2 = 7;
                    ReaverDragonslayerBarbedChain.Bonus2Type = (int)eStat.STR;
                    ReaverDragonslayerBarbedChain.Bonus3 = 7;
                    ReaverDragonslayerBarbedChain.Bonus3Type = (int)eStat.DEX;
                    ReaverDragonslayerBarbedChain.Bonus4 = 3;
                    ReaverDragonslayerBarbedChain.Bonus4Type = (int)eProperty.MeleeDamage;
                    ReaverDragonslayerBarbedChain.Bonus5 = 3;
                    ReaverDragonslayerBarbedChain.Bonus5Type = (int)eProperty.StyleDamage;
                    ReaverDragonslayerBarbedChain.Bonus6 = 3;
                    ReaverDragonslayerBarbedChain.Bonus6Type = (int)eProperty.SpellDamage;
                    ReaverDragonslayerBarbedChain.Bonus7 = 5;
                    ReaverDragonslayerBarbedChain.Bonus7Type = (int)eProperty.StrCapBonus;
                    ReaverDragonslayerBarbedChain.Bonus8 = 5;
                    ReaverDragonslayerBarbedChain.Bonus8Type = (int)eProperty.DexCapBonus;
                    ReaverDragonslayerBarbedChain.SpellID = 32178;
                    ReaverDragonslayerBarbedChain.Charges = 100;
                    ReaverDragonslayerBarbedChain.MaxCharges = 100;
                    ReaverDragonslayerBarbedChain.ProcSpellID = 32186;
                    GameServer.Database.AddObject(ReaverDragonslayerBarbedChain);
                }

                if (ReaverDragonslayerFlail == null)
                {
                    ReaverDragonslayerFlail = new ItemTemplate();
                    ReaverDragonslayerFlail.Id_nb = "ReaverDragonslayerFlail";
                    ReaverDragonslayerFlail.Name = "Reaver Dragonslayer Flail";
                    ReaverDragonslayerFlail.Level = 51;
                    ReaverDragonslayerFlail.Item_Type = 10;
                    ReaverDragonslayerFlail.Model = 3952;
                    ReaverDragonslayerFlail.IsDropable = true;
                    ReaverDragonslayerFlail.IsPickable = true;
                    ReaverDragonslayerFlail.Type_Damage = 1;
                    ReaverDragonslayerFlail.DPS_AF = 165;
                    ReaverDragonslayerFlail.SPD_ABS = 35;
                    ReaverDragonslayerFlail.Object_Type = 24;
                    ReaverDragonslayerFlail.Quality = 100;
                    ReaverDragonslayerFlail.IsTradable = false;
                    ReaverDragonslayerFlail.Weight = 25;
                    ReaverDragonslayerFlail.Price = 3500;
                    ReaverDragonslayerFlail.Bonus = 35;
                    ReaverDragonslayerFlail.MaxCondition = 50000;
                    ReaverDragonslayerFlail.MaxDurability = 50000;
                    ReaverDragonslayerFlail.Condition = 50000;
                    ReaverDragonslayerFlail.Durability = 50000;
                    ReaverDragonslayerFlail.Bonus1 = 4;
                    ReaverDragonslayerFlail.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    ReaverDragonslayerFlail.Bonus2 = 7;
                    ReaverDragonslayerFlail.Bonus2Type = (int)eStat.STR;
                    ReaverDragonslayerFlail.Bonus3 = 7;
                    ReaverDragonslayerFlail.Bonus3Type = (int)eStat.DEX;
                    ReaverDragonslayerFlail.Bonus4 = 3;
                    ReaverDragonslayerFlail.Bonus4Type = (int)eProperty.MeleeDamage;
                    ReaverDragonslayerFlail.Bonus5 = 3;
                    ReaverDragonslayerFlail.Bonus5Type = (int)eProperty.StyleDamage;
                    ReaverDragonslayerFlail.Bonus6 = 3;
                    ReaverDragonslayerFlail.Bonus6Type = (int)eProperty.SpellDamage;
                    ReaverDragonslayerFlail.Bonus7 = 5;
                    ReaverDragonslayerFlail.Bonus7Type = (int)eProperty.StrCapBonus;
                    ReaverDragonslayerFlail.Bonus8 = 5;
                    ReaverDragonslayerFlail.Bonus8Type = (int)eProperty.DexCapBonus;
                    ReaverDragonslayerFlail.SpellID = 32178;
                    ReaverDragonslayerFlail.Charges = 100;
                    ReaverDragonslayerFlail.MaxCharges = 100;
                    ReaverDragonslayerFlail.ProcSpellID = 32186;
                    GameServer.Database.AddObject(ReaverDragonslayerFlail);
                }

                if (DragonslayerBardHammer == null)
                {
                    DragonslayerBardHammer = new ItemTemplate();
                    DragonslayerBardHammer.Id_nb = "DragonslayerBardHammer";
                    DragonslayerBardHammer.Name = "Dragonslayer Bard Hammer";
                    DragonslayerBardHammer.Level = 51;
                    DragonslayerBardHammer.Item_Type = 10;
                    DragonslayerBardHammer.Model = 3897;
                    DragonslayerBardHammer.IsDropable = true;
                    DragonslayerBardHammer.IsPickable = true;
                    DragonslayerBardHammer.Type_Damage = 1;
                    DragonslayerBardHammer.DPS_AF = 165;
                    DragonslayerBardHammer.Price = 3500;
                    DragonslayerBardHammer.SPD_ABS = 42;
                    DragonslayerBardHammer.Object_Type = 20;
                    DragonslayerBardHammer.Quality = 100;
                    DragonslayerBardHammer.IsTradable = false;
                    DragonslayerBardHammer.Weight = 25;
                    DragonslayerBardHammer.Bonus = 35;
                    DragonslayerBardHammer.MaxCondition = 50000;
                    DragonslayerBardHammer.MaxDurability = 50000;
                    DragonslayerBardHammer.Condition = 50000;
                    DragonslayerBardHammer.Durability = 50000;
                    DragonslayerBardHammer.Bonus1 = 4;
                    DragonslayerBardHammer.Bonus1Type = (int)eProperty.Skill_Blunt;
                    DragonslayerBardHammer.Bonus2 = 3;
                    DragonslayerBardHammer.Bonus2Type = (int)eProperty.MeleeDamage;
                    DragonslayerBardHammer.Bonus3 = 3;
                    DragonslayerBardHammer.Bonus3Type = (int)eProperty.MeleeSpeed;
                    DragonslayerBardHammer.Bonus4 = 3;
                    DragonslayerBardHammer.Bonus4Type = (int)eProperty.StyleDamage;
                    DragonslayerBardHammer.Bonus5 = 5;
                    DragonslayerBardHammer.Bonus5Type = (int)eProperty.StrCapBonus;
                    DragonslayerBardHammer.Bonus6 = 5;
                    DragonslayerBardHammer.Bonus6Type = (int)eProperty.SpellDuration;
                    DragonslayerBardHammer.Bonus7 = 5;
                    DragonslayerBardHammer.Bonus7Type = (int)eProperty.HealingEffectiveness;
                    DragonslayerBardHammer.SpellID = 32187;
                    DragonslayerBardHammer.Charges = 100;
                    DragonslayerBardHammer.MaxCharges = 100;
                    DragonslayerBardHammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBardHammer);
                }

                if (DragonslayerBardBlade == null)
                {
                    DragonslayerBardBlade = new ItemTemplate();
                    DragonslayerBardBlade.Id_nb = "DragonslayerBardBlade";
                    DragonslayerBardBlade.Name = "Dragonslayer Bard Blade";
                    DragonslayerBardBlade.Level = 51;
                    DragonslayerBardBlade.Item_Type = 10;
                    DragonslayerBardBlade.Model = 3895;
                    DragonslayerBardBlade.IsDropable = true;
                    DragonslayerBardBlade.IsPickable = true;
                    DragonslayerBardBlade.Type_Damage = 2;
                    DragonslayerBardBlade.DPS_AF = 165;
                    DragonslayerBardBlade.SPD_ABS = 42;
                    DragonslayerBardBlade.Price = 3500;
                    DragonslayerBardBlade.Object_Type = 19;
                    DragonslayerBardBlade.Quality = 100;
                    DragonslayerBardBlade.IsTradable = false;
                    DragonslayerBardBlade.Weight = 25;
                    DragonslayerBardBlade.Bonus = 35;
                    DragonslayerBardBlade.MaxCondition = 50000;
                    DragonslayerBardBlade.MaxDurability = 50000;
                    DragonslayerBardBlade.Condition = 50000;
                    DragonslayerBardBlade.Durability = 50000;
                    DragonslayerBardBlade.Bonus1 = 4;
                    DragonslayerBardBlade.Bonus1Type = (int)eProperty.Skill_Blades;
                    DragonslayerBardBlade.Bonus2 = 3;
                    DragonslayerBardBlade.Bonus2Type = (int)eProperty.MeleeDamage;
                    DragonslayerBardBlade.Bonus3 = 3;
                    DragonslayerBardBlade.Bonus3Type = (int)eProperty.MeleeSpeed;
                    DragonslayerBardBlade.Bonus4 = 3;
                    DragonslayerBardBlade.Bonus4Type = (int)eProperty.StyleDamage;
                    DragonslayerBardBlade.Bonus5 = 5;
                    DragonslayerBardBlade.Bonus5Type = (int)eProperty.StrCapBonus;
                    DragonslayerBardBlade.Bonus6 = 5;
                    DragonslayerBardBlade.Bonus6Type = (int)eProperty.SpellDuration;
                    DragonslayerBardBlade.Bonus7 = 5;
                    DragonslayerBardBlade.Bonus7Type = (int)eProperty.HealingEffectiveness;
                    DragonslayerBardBlade.SpellID = 32187;
                    DragonslayerBardBlade.Charges = 100;
                    DragonslayerBardBlade.MaxCharges = 100;
                    DragonslayerBardBlade.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBardBlade);
                }


                if (DragonslayerBardHarp == null)
                {
                    DragonslayerBardHarp = new ItemTemplate();
                    DragonslayerBardHarp.Id_nb = "DragonslayerBardHarp";
                    DragonslayerBardHarp.Name = "Dragonslayer Harp";
                    DragonslayerBardHarp.Level = 50;
                    DragonslayerBardHarp.Durability = 50000;
                    DragonslayerBardHarp.MaxDurability = 50000;
                    DragonslayerBardHarp.Condition = 50000;
                    DragonslayerBardHarp.MaxCondition = 50000;
                    DragonslayerBardHarp.Quality = 100;
                    DragonslayerBardHarp.Hand = 1;
                    DragonslayerBardHarp.Object_Type = 45;
                    DragonslayerBardHarp.Item_Type = 13;
                    DragonslayerBardHarp.Weight = 20;
                    DragonslayerBardHarp.Model = 3908;
                    DragonslayerBardHarp.Price = 3500;
                    DragonslayerBardHarp.Bonus = 35;
                    DragonslayerBardHarp.Bonus1 = 15;
                    DragonslayerBardHarp.Bonus2 = 15;
                    DragonslayerBardHarp.Bonus3 = 5;
                    DragonslayerBardHarp.Bonus4 = 1;
                    DragonslayerBardHarp.Bonus5 = 1;
                    DragonslayerBardHarp.Bonus6 = 1;
                    DragonslayerBardHarp.Bonus7 = 1;
                    DragonslayerBardHarp.Bonus8 = 10;
                    DragonslayerBardHarp.Bonus9 = 10;
                    DragonslayerBardHarp.Bonus10 = 4;
                    DragonslayerBardHarp.Bonus1Type = 2;
                    DragonslayerBardHarp.Bonus2Type = 156;
                    DragonslayerBardHarp.Bonus3Type = 196;
                    DragonslayerBardHarp.Bonus4Type = 17;
                    DragonslayerBardHarp.Bonus5Type = 13;
                    DragonslayerBardHarp.Bonus6Type = 19;
                    DragonslayerBardHarp.Bonus7Type = 15;
                    DragonslayerBardHarp.Bonus8Type = 202;
                    DragonslayerBardHarp.Bonus9Type = 209;
                    DragonslayerBardHarp.Bonus10Type = 153;
                    DragonslayerBardHarp.IsPickable = true;
                    DragonslayerBardHarp.IsDropable = true;
                    DragonslayerBardHarp.CanDropAsLoot = false;
                    DragonslayerBardHarp.IsTradable = false;
                    DragonslayerBardHarp.MaxCount = 1;
                    DragonslayerBardHarp.PackSize = 1;
                    DragonslayerBardHarp.Charges = 100;
                    DragonslayerBardHarp.MaxCharges = 100;
                    DragonslayerBardHarp.Charges1 = 100;
                    DragonslayerBardHarp.MaxCharges1 = 100;
                    DragonslayerBardHarp.SpellID = 1092;
                    DragonslayerBardHarp.SpellID1 = 1094;
                    GameServer.Database.AddObject(DragonslayerBardHarp);
                }


                if (DragonslayerDruidBlade == null)
                {
                    DragonslayerDruidBlade = new ItemTemplate();
                    DragonslayerDruidBlade.Id_nb = "DragonslayerDruidBlade";
                    DragonslayerDruidBlade.Name = "Dragonslayer Druid Blade";
                    DragonslayerDruidBlade.Level = 51;
                    DragonslayerDruidBlade.Item_Type = 10;
                    DragonslayerDruidBlade.Model = 3895;
                    DragonslayerDruidBlade.IsDropable = true;
                    DragonslayerDruidBlade.IsPickable = true;
                    DragonslayerDruidBlade.Type_Damage = 2;
                    DragonslayerDruidBlade.DPS_AF = 165;
                    DragonslayerDruidBlade.SPD_ABS = 42;
                    DragonslayerDruidBlade.Price = 3500;
                    DragonslayerDruidBlade.Object_Type = 19;
                    DragonslayerDruidBlade.Quality = 100;
                    DragonslayerDruidBlade.IsTradable = false;
                    DragonslayerDruidBlade.Weight = 25;
                    DragonslayerDruidBlade.Bonus = 35;
                    DragonslayerDruidBlade.MaxCondition = 50000;
                    DragonslayerDruidBlade.MaxDurability = 50000;
                    DragonslayerDruidBlade.Condition = 50000;
                    DragonslayerDruidBlade.Durability = 50000;
                    DragonslayerDruidBlade.Bonus1 = 6;
                    DragonslayerDruidBlade.Bonus1Type = (int)eProperty.PowerPool;
                    DragonslayerDruidBlade.Bonus2 = 4;
                    DragonslayerDruidBlade.Bonus2Type = (int)eProperty.CastingSpeed;
                    DragonslayerDruidBlade.Bonus3 = 4;
                    DragonslayerDruidBlade.Bonus3Type = (int)eProperty.SpellRange;
                    DragonslayerDruidBlade.Bonus4 = 5;
                    DragonslayerDruidBlade.Bonus4Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerDruidBlade.Bonus5 = 6;
                    DragonslayerDruidBlade.Bonus5Type = (int)eProperty.HealingEffectiveness;
                    DragonslayerDruidBlade.Bonus6 = 4;
                    DragonslayerDruidBlade.Bonus6Type = (int)eProperty.AcuCapBonus;
                    DragonslayerDruidBlade.Bonus7 = 4;
                    DragonslayerDruidBlade.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerDruidBlade.SpellID = 32175;
                    DragonslayerDruidBlade.Charges = 100;
                    DragonslayerDruidBlade.MaxCharges = 100;
                    DragonslayerDruidBlade.SpellID1 = 32182;
                    DragonslayerDruidBlade.Charges1 = 100;
                    DragonslayerDruidBlade.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerDruidBlade);
                }

                if (DragonslayerDruidHammer == null)
                {
                    DragonslayerDruidHammer = new ItemTemplate();
                    DragonslayerDruidHammer.Id_nb = "DragonslayerDruidHammer";
                    DragonslayerDruidHammer.Name = "Dragonslayer Druid Hammer";
                    DragonslayerDruidHammer.Level = 51;
                    DragonslayerDruidHammer.Item_Type = 10;
                    DragonslayerDruidHammer.Model = 3897;
                    DragonslayerDruidHammer.IsDropable = true;
                    DragonslayerDruidHammer.IsPickable = true;
                    DragonslayerDruidHammer.Type_Damage = 1;
                    DragonslayerDruidHammer.DPS_AF = 165;
                    DragonslayerDruidHammer.SPD_ABS = 42;
                    DragonslayerDruidHammer.Object_Type = 20;
                    DragonslayerDruidHammer.Quality = 100;
                    DragonslayerDruidHammer.IsTradable = false;
                    DragonslayerDruidHammer.Weight = 25;
                    DragonslayerDruidHammer.Price = 3500;
                    DragonslayerDruidHammer.Bonus = 35;
                    DragonslayerDruidHammer.MaxCondition = 50000;
                    DragonslayerDruidHammer.MaxDurability = 50000;
                    DragonslayerDruidHammer.Condition = 50000;
                    DragonslayerDruidHammer.Durability = 50000;
                    DragonslayerDruidHammer.Bonus1 = 6;
                    DragonslayerDruidHammer.Bonus1Type = (int)eProperty.PowerPool;
                    DragonslayerDruidHammer.Bonus2 = 4;
                    DragonslayerDruidHammer.Bonus2Type = (int)eProperty.CastingSpeed;
                    DragonslayerDruidHammer.Bonus3 = 4;
                    DragonslayerDruidHammer.Bonus3Type = (int)eProperty.SpellRange;
                    DragonslayerDruidHammer.Bonus4 = 5;
                    DragonslayerDruidHammer.Bonus4Type = (int)eProperty.PowerPoolCapBonus;
                    DragonslayerDruidHammer.Bonus5 = 6;
                    DragonslayerDruidHammer.Bonus5Type = (int)eProperty.HealingEffectiveness;
                    DragonslayerDruidHammer.Bonus6 = 4;
                    DragonslayerDruidHammer.Bonus6Type = (int)eProperty.AcuCapBonus;
                    DragonslayerDruidHammer.Bonus7 = 4;
                    DragonslayerDruidHammer.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerDruidHammer.SpellID = 32175;
                    DragonslayerDruidHammer.Charges = 100;
                    DragonslayerDruidHammer.MaxCharges = 100;
                    DragonslayerDruidHammer.SpellID1 = 32182;
                    DragonslayerDruidHammer.Charges1 = 100;
                    DragonslayerDruidHammer.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerDruidHammer);
                }

                if (DragonslayerWardenBlade == null)
                {
                    DragonslayerWardenBlade = new ItemTemplate();
                    DragonslayerWardenBlade.Id_nb = "DragonslayerWardenBlade";
                    DragonslayerWardenBlade.Name = "Dragonslayer Warden Blade";
                    DragonslayerWardenBlade.Level = 51;
                    DragonslayerWardenBlade.Item_Type = 10;
                    DragonslayerWardenBlade.Model = 3895;
                    DragonslayerWardenBlade.IsDropable = true;
                    DragonslayerWardenBlade.IsPickable = true;
                    DragonslayerWardenBlade.Type_Damage = 2;
                    DragonslayerWardenBlade.DPS_AF = 165;
                    DragonslayerWardenBlade.SPD_ABS = 42;
                    DragonslayerWardenBlade.Object_Type = 19;
                    DragonslayerWardenBlade.Price = 3500;
                    DragonslayerWardenBlade.Quality = 100;
                    DragonslayerWardenBlade.IsTradable = false;
                    DragonslayerWardenBlade.Weight = 25;
                    DragonslayerWardenBlade.Bonus = 35;
                    DragonslayerWardenBlade.MaxCondition = 50000;
                    DragonslayerWardenBlade.MaxDurability = 50000;
                    DragonslayerWardenBlade.Condition = 50000;
                    DragonslayerWardenBlade.Durability = 50000;
                    DragonslayerWardenBlade.Bonus1 = 4;
                    DragonslayerWardenBlade.Bonus1Type = (int)eProperty.Skill_Blades;
                    DragonslayerWardenBlade.Bonus2 = 3;
                    DragonslayerWardenBlade.Bonus2Type = (int)eProperty.MeleeDamage;
                    DragonslayerWardenBlade.Bonus3 = 3;
                    DragonslayerWardenBlade.Bonus3Type = (int)eProperty.CastingSpeed;
                    DragonslayerWardenBlade.Bonus4 = 3;
                    DragonslayerWardenBlade.Bonus4Type = (int)eProperty.StyleDamage;
                    DragonslayerWardenBlade.Bonus5 = 5;
                    DragonslayerWardenBlade.Bonus5Type = (int)eProperty.StrCapBonus;
                    DragonslayerWardenBlade.Bonus6 = 5;
                    DragonslayerWardenBlade.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerWardenBlade.Bonus7 = 5;
                    DragonslayerWardenBlade.Bonus7Type = (int)eProperty.HealingEffectiveness;
                    DragonslayerWardenBlade.SpellID = 32178;
                    DragonslayerWardenBlade.Charges = 100;
                    DragonslayerWardenBlade.MaxCharges = 100;
                    DragonslayerWardenBlade.SpellID1 = 32187;
                    DragonslayerWardenBlade.Charges1 = 100;
                    DragonslayerWardenBlade.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerWardenBlade);
                }

                if (DragonslayerWardenHammer == null)
                {
                    DragonslayerWardenHammer = new ItemTemplate();
                    DragonslayerWardenHammer.Id_nb = "DragonslayerWardenHammer";
                    DragonslayerWardenHammer.Name = "Dragonslayer Warden Hammer";
                    DragonslayerWardenHammer.Level = 51;
                    DragonslayerWardenHammer.Item_Type = 10;
                    DragonslayerWardenHammer.Model = 3897;
                    DragonslayerWardenHammer.IsDropable = true;
                    DragonslayerWardenHammer.IsPickable = true;
                    DragonslayerWardenHammer.Type_Damage = 1;
                    DragonslayerWardenHammer.DPS_AF = 165;
                    DragonslayerWardenHammer.SPD_ABS = 42;
                    DragonslayerWardenHammer.Price = 3500;
                    DragonslayerWardenHammer.Object_Type = 20;
                    DragonslayerWardenHammer.Quality = 100;
                    DragonslayerWardenHammer.IsTradable = false;
                    DragonslayerWardenHammer.Weight = 25;
                    DragonslayerWardenHammer.Bonus = 35;
                    DragonslayerWardenHammer.MaxCondition = 50000;
                    DragonslayerWardenHammer.MaxDurability = 50000;
                    DragonslayerWardenHammer.Condition = 50000;
                    DragonslayerWardenHammer.Durability = 50000;
                    DragonslayerWardenHammer.Bonus1 = 4;
                    DragonslayerWardenHammer.Bonus1Type = (int)eProperty.Skill_Blunt;
                    DragonslayerWardenHammer.Bonus2 = 3;
                    DragonslayerWardenHammer.Bonus2Type = (int)eProperty.MeleeDamage;
                    DragonslayerWardenHammer.Bonus3 = 3;
                    DragonslayerWardenHammer.Bonus3Type = (int)eProperty.CastingSpeed;
                    DragonslayerWardenHammer.Bonus4 = 3;
                    DragonslayerWardenHammer.Bonus4Type = (int)eProperty.StyleDamage;
                    DragonslayerWardenHammer.Bonus5 = 5;
                    DragonslayerWardenHammer.Bonus5Type = (int)eProperty.StrCapBonus;
                    DragonslayerWardenHammer.Bonus6 = 5;
                    DragonslayerWardenHammer.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerWardenHammer.Bonus7 = 5;
                    DragonslayerWardenHammer.Bonus7Type = (int)eProperty.HealingEffectiveness;
                    DragonslayerWardenHammer.SpellID = 32178;
                    DragonslayerWardenHammer.Charges = 100;
                    DragonslayerWardenHammer.MaxCharges = 100;
                    DragonslayerWardenHammer.SpellID1 = 32187;
                    DragonslayerWardenHammer.Charges1 = 100;
                    DragonslayerWardenHammer.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerWardenHammer);
                }

                if (PaladinDragonslayerBlade == null)
                {
                    PaladinDragonslayerBlade = new ItemTemplate();
                    PaladinDragonslayerBlade.Id_nb = "PaladinDragonslayerBlade";
                    PaladinDragonslayerBlade.Name = "Paladin Dragonslayer Blade";
                    PaladinDragonslayerBlade.Level = 51;
                    PaladinDragonslayerBlade.Item_Type = 10;
                    PaladinDragonslayerBlade.Model = 3972;
                    PaladinDragonslayerBlade.IsDropable = true;
                    PaladinDragonslayerBlade.IsPickable = true;
                    PaladinDragonslayerBlade.Type_Damage = 2;
                    PaladinDragonslayerBlade.DPS_AF = 165;
                    PaladinDragonslayerBlade.SPD_ABS = 42;
                    PaladinDragonslayerBlade.Object_Type = 3;
                    PaladinDragonslayerBlade.Quality = 100;
                    PaladinDragonslayerBlade.Price = 3500;
                    PaladinDragonslayerBlade.IsTradable = false;
                    PaladinDragonslayerBlade.Weight = 25;
                    PaladinDragonslayerBlade.Bonus = 35;
                    PaladinDragonslayerBlade.MaxCondition = 50000;
                    PaladinDragonslayerBlade.MaxDurability = 50000;
                    PaladinDragonslayerBlade.Condition = 50000;
                    PaladinDragonslayerBlade.Durability = 50000;
                    PaladinDragonslayerBlade.Bonus1 = 4;
                    PaladinDragonslayerBlade.Bonus1Type = (int)eProperty.Skill_Slashing;
                    PaladinDragonslayerBlade.Bonus2 = 9;
                    PaladinDragonslayerBlade.Bonus2Type = (int)eStat.STR;
                    PaladinDragonslayerBlade.Bonus3 = 9;
                    PaladinDragonslayerBlade.Bonus3Type = (int)eStat.DEX;
                    PaladinDragonslayerBlade.Bonus4 = 4;
                    PaladinDragonslayerBlade.Bonus4Type = (int)eProperty.StyleDamage;
                    PaladinDragonslayerBlade.Bonus5 = 4;
                    PaladinDragonslayerBlade.Bonus5Type = (int)eProperty.MeleeDamage;
                    PaladinDragonslayerBlade.Bonus6 = 5;
                    PaladinDragonslayerBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    PaladinDragonslayerBlade.Bonus7 = 5;
                    PaladinDragonslayerBlade.Bonus7Type = (int)eProperty.DexCapBonus;
                    PaladinDragonslayerBlade.SpellID = 32178;
                    PaladinDragonslayerBlade.Charges = 100;
                    PaladinDragonslayerBlade.MaxCharges = 100;
                    PaladinDragonslayerBlade.SpellID1 = 32187;
                    PaladinDragonslayerBlade.Charges1 = 100;
                    PaladinDragonslayerBlade.MaxCharges1 = 100;
                    GameServer.Database.AddObject(PaladinDragonslayerBlade);
                }

                if (PaladinDragonslayerEdge == null)
                {
                    PaladinDragonslayerEdge = new ItemTemplate();
                    PaladinDragonslayerEdge.Id_nb = "PaladinDragonslayerEdge";
                    PaladinDragonslayerEdge.Name = "Paladin Dragonslayer Edge";
                    PaladinDragonslayerEdge.Level = 51;
                    PaladinDragonslayerEdge.Item_Type = 10;
                    PaladinDragonslayerEdge.Model = 3976;
                    PaladinDragonslayerEdge.IsDropable = true;
                    PaladinDragonslayerEdge.IsPickable = true;
                    PaladinDragonslayerEdge.Type_Damage = 3;
                    PaladinDragonslayerEdge.DPS_AF = 165;
                    PaladinDragonslayerEdge.SPD_ABS = 42;
                    PaladinDragonslayerEdge.Object_Type = 4;
                    PaladinDragonslayerEdge.Quality = 100;
                    PaladinDragonslayerEdge.Price = 3500;
                    PaladinDragonslayerEdge.IsTradable = false;
                    PaladinDragonslayerEdge.Weight = 25;
                    PaladinDragonslayerEdge.Bonus = 35;
                    PaladinDragonslayerEdge.MaxCondition = 50000;
                    PaladinDragonslayerEdge.MaxDurability = 50000;
                    PaladinDragonslayerEdge.Condition = 50000;
                    PaladinDragonslayerEdge.Durability = 50000;
                    PaladinDragonslayerEdge.Bonus1 = 4;
                    PaladinDragonslayerEdge.Bonus1Type = (int)eProperty.Skill_Thrusting;
                    PaladinDragonslayerEdge.Bonus2 = 9;
                    PaladinDragonslayerEdge.Bonus2Type = (int)eStat.STR;
                    PaladinDragonslayerEdge.Bonus3 = 9;
                    PaladinDragonslayerEdge.Bonus3Type = (int)eStat.DEX;
                    PaladinDragonslayerEdge.Bonus4 = 4;
                    PaladinDragonslayerEdge.Bonus4Type = (int)eProperty.StyleDamage;
                    PaladinDragonslayerEdge.Bonus5 = 4;
                    PaladinDragonslayerEdge.Bonus5Type = (int)eProperty.MeleeDamage;
                    PaladinDragonslayerEdge.Bonus6 = 5;
                    PaladinDragonslayerEdge.Bonus6Type = (int)eProperty.StrCapBonus;
                    PaladinDragonslayerEdge.Bonus7 = 5;
                    PaladinDragonslayerEdge.Bonus7Type = (int)eProperty.DexCapBonus;
                    PaladinDragonslayerEdge.SpellID = 32178;
                    PaladinDragonslayerEdge.Charges = 100;
                    PaladinDragonslayerEdge.MaxCharges = 100;
                    PaladinDragonslayerEdge.SpellID1 = 32187;
                    PaladinDragonslayerEdge.Charges1 = 100;
                    PaladinDragonslayerEdge.MaxCharges1 = 100;
                    GameServer.Database.AddObject(PaladinDragonslayerEdge);
                }

                if (PaladinDragonslayerMace == null)
                {
                    PaladinDragonslayerMace = new ItemTemplate();
                    PaladinDragonslayerMace.Id_nb = "PaladinDragonslayerMace";
                    PaladinDragonslayerMace.Name = "Paladin Dragonslayer Mace";
                    PaladinDragonslayerMace.Level = 51;
                    PaladinDragonslayerMace.Item_Type = 10;
                    PaladinDragonslayerMace.Model = 3974;
                    PaladinDragonslayerMace.IsDropable = true;
                    PaladinDragonslayerMace.IsPickable = true;
                    PaladinDragonslayerMace.Type_Damage = 1;
                    PaladinDragonslayerMace.DPS_AF = 165;
                    PaladinDragonslayerMace.SPD_ABS = 42;
                    PaladinDragonslayerMace.Object_Type = 2;
                    PaladinDragonslayerMace.Quality = 100;
                    PaladinDragonslayerMace.IsTradable = false;
                    PaladinDragonslayerMace.Weight = 25;
                    PaladinDragonslayerMace.Bonus = 35;
                    PaladinDragonslayerMace.Price = 3500;
                    PaladinDragonslayerMace.MaxCondition = 50000;
                    PaladinDragonslayerMace.MaxDurability = 50000;
                    PaladinDragonslayerMace.Condition = 50000;
                    PaladinDragonslayerMace.Durability = 50000;
                    PaladinDragonslayerMace.Bonus1 = 4;
                    PaladinDragonslayerMace.Bonus1Type = (int)eProperty.Skill_Crushing;
                    PaladinDragonslayerMace.Bonus2 = 9;
                    PaladinDragonslayerMace.Bonus2Type = (int)eStat.STR;
                    PaladinDragonslayerMace.Bonus3 = 9;
                    PaladinDragonslayerMace.Bonus3Type = (int)eStat.DEX;
                    PaladinDragonslayerMace.Bonus4 = 4;
                    PaladinDragonslayerMace.Bonus4Type = (int)eProperty.StyleDamage;
                    PaladinDragonslayerMace.Bonus5 = 4;
                    PaladinDragonslayerMace.Bonus5Type = (int)eProperty.MeleeDamage;
                    PaladinDragonslayerMace.Bonus6 = 5;
                    PaladinDragonslayerMace.Bonus6Type = (int)eProperty.StrCapBonus;
                    PaladinDragonslayerMace.Bonus7 = 5;
                    PaladinDragonslayerMace.Bonus7Type = (int)eProperty.DexCapBonus;
                    PaladinDragonslayerMace.SpellID = 32178;
                    PaladinDragonslayerMace.Charges = 100;
                    PaladinDragonslayerMace.MaxCharges = 100;
                    PaladinDragonslayerMace.SpellID1 = 32187;
                    PaladinDragonslayerMace.Charges1 = 100;
                    PaladinDragonslayerMace.MaxCharges1 = 100;
                    GameServer.Database.AddObject(PaladinDragonslayerMace);
                }

                if (PaladinDragonslayerGreatEdge == null)
                {
                    PaladinDragonslayerGreatEdge = new ItemTemplate();
                    PaladinDragonslayerGreatEdge.Id_nb = "PaladinDragonslayerGreatEdge";
                    PaladinDragonslayerGreatEdge.Name = "Paladin Dragonslayer Great-Edge";
                    PaladinDragonslayerGreatEdge.Level = 51;
                    PaladinDragonslayerGreatEdge.Item_Type = 12;
                    PaladinDragonslayerGreatEdge.Hand = 1;
                    PaladinDragonslayerGreatEdge.Model = 3954;
                    PaladinDragonslayerGreatEdge.IsDropable = true;
                    PaladinDragonslayerGreatEdge.IsPickable = true;
                    PaladinDragonslayerGreatEdge.Type_Damage = 3;
                    PaladinDragonslayerGreatEdge.DPS_AF = 165;
                    PaladinDragonslayerGreatEdge.SPD_ABS = 56;
                    PaladinDragonslayerGreatEdge.Price = 3500;
                    PaladinDragonslayerGreatEdge.Object_Type = 6;
                    PaladinDragonslayerGreatEdge.Quality = 100;
                    PaladinDragonslayerGreatEdge.IsTradable = false;
                    PaladinDragonslayerGreatEdge.Weight = 25;
                    PaladinDragonslayerGreatEdge.Bonus = 35;
                    PaladinDragonslayerGreatEdge.MaxCondition = 50000;
                    PaladinDragonslayerGreatEdge.MaxDurability = 50000;
                    PaladinDragonslayerGreatEdge.Condition = 50000;
                    PaladinDragonslayerGreatEdge.Durability = 50000;
                    PaladinDragonslayerGreatEdge.Bonus1 = 4;
                    PaladinDragonslayerGreatEdge.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    PaladinDragonslayerGreatEdge.Bonus2 = 12;
                    PaladinDragonslayerGreatEdge.Bonus2Type = (int)eStat.STR;
                    PaladinDragonslayerGreatEdge.Bonus3 = 12;
                    PaladinDragonslayerGreatEdge.Bonus3Type = (int)eStat.QUI;
                    PaladinDragonslayerGreatEdge.Bonus4 = 4;
                    PaladinDragonslayerGreatEdge.Bonus4Type = (int)eProperty.StyleDamage;
                    PaladinDragonslayerGreatEdge.Bonus5 = 4;
                    PaladinDragonslayerGreatEdge.Bonus5Type = (int)eProperty.MeleeDamage;
                    PaladinDragonslayerGreatEdge.Bonus6 = 8;
                    PaladinDragonslayerGreatEdge.Bonus6Type = (int)eProperty.StrCapBonus;
                    PaladinDragonslayerGreatEdge.SpellID = 32178;
                    PaladinDragonslayerGreatEdge.Charges = 100;
                    PaladinDragonslayerGreatEdge.MaxCharges = 100;
                    PaladinDragonslayerGreatEdge.SpellID1 = 32187;
                    PaladinDragonslayerGreatEdge.Charges1 = 100;
                    PaladinDragonslayerGreatEdge.MaxCharges1 = 100;
                    GameServer.Database.AddObject(PaladinDragonslayerGreatEdge);
                }

                if (PaladinDragonslayerGreatHammer == null)
                {
                    PaladinDragonslayerGreatHammer = new ItemTemplate();
                    PaladinDragonslayerGreatHammer.Id_nb = "PaladinDragonslayerGreatHammer";
                    PaladinDragonslayerGreatHammer.Name = "Paladin Dragonslayer Great-Hammer";
                    PaladinDragonslayerGreatHammer.Level = 51;
                    PaladinDragonslayerGreatHammer.Item_Type = 12;
                    PaladinDragonslayerGreatHammer.Hand = 1;
                    PaladinDragonslayerGreatHammer.Model = 3958;
                    PaladinDragonslayerGreatHammer.IsDropable = true;
                    PaladinDragonslayerGreatHammer.IsPickable = true;
                    PaladinDragonslayerGreatHammer.Type_Damage = 1;
                    PaladinDragonslayerGreatHammer.DPS_AF = 165;
                    PaladinDragonslayerGreatHammer.SPD_ABS = 56;
                    PaladinDragonslayerGreatHammer.Price = 3500;
                    PaladinDragonslayerGreatHammer.Object_Type = 6;
                    PaladinDragonslayerGreatHammer.Quality = 100;
                    PaladinDragonslayerGreatHammer.IsTradable = false;
                    PaladinDragonslayerGreatHammer.Weight = 25;
                    PaladinDragonslayerGreatHammer.Bonus = 35;
                    PaladinDragonslayerGreatHammer.MaxCondition = 50000;
                    PaladinDragonslayerGreatHammer.MaxDurability = 50000;
                    PaladinDragonslayerGreatHammer.Condition = 50000;
                    PaladinDragonslayerGreatHammer.Durability = 50000;
                    PaladinDragonslayerGreatHammer.Bonus1 = 4;
                    PaladinDragonslayerGreatHammer.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    PaladinDragonslayerGreatHammer.Bonus2 = 12;
                    PaladinDragonslayerGreatHammer.Bonus2Type = (int)eStat.STR;
                    PaladinDragonslayerGreatHammer.Bonus3 = 12;
                    PaladinDragonslayerGreatHammer.Bonus3Type = (int)eStat.QUI;
                    PaladinDragonslayerGreatHammer.Bonus4 = 4;
                    PaladinDragonslayerGreatHammer.Bonus4Type = (int)eProperty.StyleDamage;
                    PaladinDragonslayerGreatHammer.Bonus5 = 4;
                    PaladinDragonslayerGreatHammer.Bonus5Type = (int)eProperty.MeleeDamage;
                    PaladinDragonslayerGreatHammer.Bonus6 = 8;
                    PaladinDragonslayerGreatHammer.Bonus6Type = (int)eProperty.StrCapBonus;
                    PaladinDragonslayerGreatHammer.SpellID = 32178;
                    PaladinDragonslayerGreatHammer.Charges = 100;
                    PaladinDragonslayerGreatHammer.MaxCharges = 100;
                    PaladinDragonslayerGreatHammer.SpellID1 = 32187;
                    PaladinDragonslayerGreatHammer.Charges1 = 100;
                    PaladinDragonslayerGreatHammer.MaxCharges1 = 100;
                    GameServer.Database.AddObject(PaladinDragonslayerGreatHammer);
                }

                if (PaladinDragonslayerGreatSword == null)
                {
                    PaladinDragonslayerGreatSword = new ItemTemplate();
                    PaladinDragonslayerGreatSword.Id_nb = "PaladinDragonslayerGreatSword";
                    PaladinDragonslayerGreatSword.Name = "Paladin Dragonslayer Great-Sword";
                    PaladinDragonslayerGreatSword.Level = 51;
                    PaladinDragonslayerGreatSword.Item_Type = 12;
                    PaladinDragonslayerGreatSword.Hand = 1;
                    PaladinDragonslayerGreatSword.Model = 3955;
                    PaladinDragonslayerGreatSword.IsDropable = true;
                    PaladinDragonslayerGreatSword.IsPickable = true;
                    PaladinDragonslayerGreatSword.Type_Damage = 2;
                    PaladinDragonslayerGreatSword.DPS_AF = 165;
                    PaladinDragonslayerGreatSword.SPD_ABS = 56;
                    PaladinDragonslayerGreatSword.Object_Type = 3;
                    PaladinDragonslayerGreatSword.Quality = 100;
                    PaladinDragonslayerGreatSword.Price = 3500;
                    PaladinDragonslayerGreatSword.IsTradable = false;
                    PaladinDragonslayerGreatSword.Weight = 25;
                    PaladinDragonslayerGreatSword.Bonus = 35;
                    PaladinDragonslayerGreatSword.MaxCondition = 50000;
                    PaladinDragonslayerGreatSword.MaxDurability = 50000;
                    PaladinDragonslayerGreatSword.Condition = 50000;
                    PaladinDragonslayerGreatSword.Durability = 50000;
                    PaladinDragonslayerGreatSword.Bonus1 = 4;
                    PaladinDragonslayerGreatSword.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    PaladinDragonslayerGreatSword.Bonus2 = 12;
                    PaladinDragonslayerGreatSword.Bonus2Type = (int)eStat.STR;
                    PaladinDragonslayerGreatSword.Bonus3 = 12;
                    PaladinDragonslayerGreatSword.Bonus3Type = (int)eStat.QUI;
                    PaladinDragonslayerGreatSword.Bonus4 = 4;
                    PaladinDragonslayerGreatSword.Bonus4Type = (int)eProperty.StyleDamage;
                    PaladinDragonslayerGreatSword.Bonus5 = 4;
                    PaladinDragonslayerGreatSword.Bonus5Type = (int)eProperty.MeleeDamage;
                    PaladinDragonslayerGreatSword.Bonus6 = 8;
                    PaladinDragonslayerGreatSword.Bonus6Type = (int)eProperty.StrCapBonus;
                    PaladinDragonslayerGreatSword.SpellID = 32178;
                    PaladinDragonslayerGreatSword.Charges = 100;
                    PaladinDragonslayerGreatSword.MaxCharges = 100;
                    PaladinDragonslayerGreatSword.SpellID1 = 32187;
                    PaladinDragonslayerGreatSword.Charges1 = 100;
                    PaladinDragonslayerGreatSword.MaxCharges1 = 100;
                    GameServer.Database.AddObject(PaladinDragonslayerGreatSword);
                }

                if (ScoutDragonslayerBlade == null)
                {
                    ScoutDragonslayerBlade = new ItemTemplate();
                    ScoutDragonslayerBlade.Id_nb = "ScoutDragonslayerBlade";
                    ScoutDragonslayerBlade.Name = "Scout Dragonslayer Blade";
                    ScoutDragonslayerBlade.Level = 51;
                    ScoutDragonslayerBlade.Item_Type = 10;
                    ScoutDragonslayerBlade.Model = 3972;
                    ScoutDragonslayerBlade.IsDropable = true;
                    ScoutDragonslayerBlade.IsPickable = true;
                    ScoutDragonslayerBlade.Type_Damage = 2;
                    ScoutDragonslayerBlade.DPS_AF = 165;
                    ScoutDragonslayerBlade.SPD_ABS = 42;
                    ScoutDragonslayerBlade.Price = 3500;
                    ScoutDragonslayerBlade.Object_Type = 3;
                    ScoutDragonslayerBlade.Quality = 100;
                    ScoutDragonslayerBlade.IsTradable = false;
                    ScoutDragonslayerBlade.Weight = 25;
                    ScoutDragonslayerBlade.Bonus = 35;
                    ScoutDragonslayerBlade.MaxCondition = 50000;
                    ScoutDragonslayerBlade.MaxDurability = 50000;
                    ScoutDragonslayerBlade.Condition = 50000;
                    ScoutDragonslayerBlade.Durability = 50000;
                    ScoutDragonslayerBlade.Bonus1 = 4;
                    ScoutDragonslayerBlade.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    ScoutDragonslayerBlade.Bonus2 = 12;
                    ScoutDragonslayerBlade.Bonus2Type = (int)eStat.STR;
                    ScoutDragonslayerBlade.Bonus3 = 12;
                    ScoutDragonslayerBlade.Bonus3Type = (int)eStat.QUI;
                    ScoutDragonslayerBlade.Bonus4 = 4;
                    ScoutDragonslayerBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    ScoutDragonslayerBlade.Bonus5 = 4;
                    ScoutDragonslayerBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    ScoutDragonslayerBlade.Bonus6 = 8;
                    ScoutDragonslayerBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    ScoutDragonslayerBlade.SpellID = 32178;
                    ScoutDragonslayerBlade.Charges = 100;
                    ScoutDragonslayerBlade.MaxCharges = 100;
                    ScoutDragonslayerBlade.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ScoutDragonslayerBlade);
                }

                if (ScoutDragonslayerBow == null)
                {
                    ScoutDragonslayerBow = new ItemTemplate();
                    ScoutDragonslayerBow.Id_nb = "ScoutDragonslayerBow";
                    ScoutDragonslayerBow.Name = "Scout Dragonslayer Bow";
                    ScoutDragonslayerBow.Level = 51;
                    ScoutDragonslayerBow.Item_Type = 13;
                    ScoutDragonslayerBow.Hand = 1;
                    ScoutDragonslayerBow.Model = 3960;
                    ScoutDragonslayerBow.IsDropable = true;
                    ScoutDragonslayerBow.IsPickable = true;
                    ScoutDragonslayerBow.Type_Damage = 0;
                    ScoutDragonslayerBow.DPS_AF = 165;
                    ScoutDragonslayerBow.SPD_ABS = 56;
                    ScoutDragonslayerBow.Price = 3500;
                    ScoutDragonslayerBow.Object_Type = 9;
                    ScoutDragonslayerBow.Quality = 100;
                    ScoutDragonslayerBow.IsTradable = false;
                    ScoutDragonslayerBow.Weight = 25;
                    ScoutDragonslayerBow.Bonus = 35;
                    ScoutDragonslayerBow.MaxCondition = 50000;
                    ScoutDragonslayerBow.MaxDurability = 50000;
                    ScoutDragonslayerBow.Condition = 50000;
                    ScoutDragonslayerBow.Durability = 50000;
                    ScoutDragonslayerBow.Bonus1 = 4;
                    ScoutDragonslayerBow.Bonus1Type = (int)eProperty.Skill_Long_bows;
                    ScoutDragonslayerBow.Bonus2 = 15;
                    ScoutDragonslayerBow.Bonus2Type = (int)eStat.DEX;
                    ScoutDragonslayerBow.Bonus3 = 3;
                    ScoutDragonslayerBow.Bonus3Type = (int)eProperty.RangedDamage;
                    ScoutDragonslayerBow.Bonus4 = 3;
                    ScoutDragonslayerBow.Bonus4Type = (int)eProperty.ArcheryRange;
                    ScoutDragonslayerBow.Bonus5 = 3;
                    ScoutDragonslayerBow.Bonus5Type = (int)eProperty.ArcherySpeed;
                    ScoutDragonslayerBow.Bonus6 = 9;
                    ScoutDragonslayerBow.Bonus6Type = (int)eProperty.DexCapBonus;
                    ScoutDragonslayerBow.SpellID = 32178;
                    ScoutDragonslayerBow.Charges = 100;
                    ScoutDragonslayerBow.MaxCharges = 100;
                    ScoutDragonslayerBow.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ScoutDragonslayerBow);
                }

                if (ScoutDragonslayerEdge == null)
                {
                    ScoutDragonslayerEdge = new ItemTemplate();
                    ScoutDragonslayerEdge.Id_nb = "ScoutDragonslayerEdge";
                    ScoutDragonslayerEdge.Name = "Scout Dragonslayer Edge";
                    ScoutDragonslayerEdge.Level = 51;
                    ScoutDragonslayerEdge.Item_Type = 10;
                    ScoutDragonslayerEdge.Model = 3976;
                    ScoutDragonslayerEdge.IsDropable = true;
                    ScoutDragonslayerEdge.IsPickable = true;
                    ScoutDragonslayerEdge.Type_Damage = 3;
                    ScoutDragonslayerEdge.Price = 3500;
                    ScoutDragonslayerEdge.DPS_AF = 165;
                    ScoutDragonslayerEdge.SPD_ABS = 42;
                    ScoutDragonslayerEdge.Object_Type = 4;
                    ScoutDragonslayerEdge.Quality = 100;
                    ScoutDragonslayerEdge.IsTradable = false;
                    ScoutDragonslayerEdge.Weight = 25;
                    ScoutDragonslayerEdge.Bonus = 35;
                    ScoutDragonslayerEdge.MaxCondition = 50000;
                    ScoutDragonslayerEdge.MaxDurability = 50000;
                    ScoutDragonslayerEdge.Condition = 50000;
                    ScoutDragonslayerEdge.Durability = 50000;
                    ScoutDragonslayerEdge.Bonus1 = 4;
                    ScoutDragonslayerEdge.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    ScoutDragonslayerEdge.Bonus2 = 9;
                    ScoutDragonslayerEdge.Bonus2Type = (int)eStat.DEX;
                    ScoutDragonslayerEdge.Bonus3 = 9;
                    ScoutDragonslayerEdge.Bonus3Type = (int)eStat.STR;
                    ScoutDragonslayerEdge.Bonus4 = 4;
                    ScoutDragonslayerEdge.Bonus4Type = (int)eProperty.MeleeDamage;
                    ScoutDragonslayerEdge.Bonus5 = 4;
                    ScoutDragonslayerEdge.Bonus5Type = (int)eProperty.StyleDamage;
                    ScoutDragonslayerEdge.Bonus6 = 5;
                    ScoutDragonslayerEdge.Bonus6Type = (int)eProperty.DexCapBonus;
                    ScoutDragonslayerEdge.Bonus7 = 5;
                    ScoutDragonslayerEdge.Bonus7Type = (int)eProperty.StrCapBonus;
                    ScoutDragonslayerEdge.SpellID = 32178;
                    ScoutDragonslayerEdge.Charges = 100;
                    ScoutDragonslayerEdge.MaxCharges = 100;
                    ScoutDragonslayerEdge.ProcSpellID = 32177;
                    GameServer.Database.AddObject(ScoutDragonslayerEdge);
                }

                if (MinstrelDragonslayerEdge == null)
                {
                    MinstrelDragonslayerEdge = new ItemTemplate();
                    MinstrelDragonslayerEdge.Id_nb = "MinstrelDragonslayerEdge";
                    MinstrelDragonslayerEdge.Name = "Minstrel Dragonslayer Edge";
                    MinstrelDragonslayerEdge.Level = 51;
                    MinstrelDragonslayerEdge.Item_Type = 10;
                    MinstrelDragonslayerEdge.Model = 3976;
                    MinstrelDragonslayerEdge.IsDropable = true;
                    MinstrelDragonslayerEdge.Price = 3500;
                    MinstrelDragonslayerEdge.IsPickable = true;
                    MinstrelDragonslayerEdge.Type_Damage = 3;
                    MinstrelDragonslayerEdge.DPS_AF = 165;
                    MinstrelDragonslayerEdge.SPD_ABS = 42;
                    MinstrelDragonslayerEdge.Object_Type = 4;
                    MinstrelDragonslayerEdge.Quality = 100;
                    MinstrelDragonslayerEdge.IsTradable = false;
                    MinstrelDragonslayerEdge.Weight = 25;
                    MinstrelDragonslayerEdge.Bonus = 35;
                    MinstrelDragonslayerEdge.MaxCondition = 50000;
                    MinstrelDragonslayerEdge.MaxDurability = 50000;
                    MinstrelDragonslayerEdge.Condition = 50000;
                    MinstrelDragonslayerEdge.Durability = 50000;
                    MinstrelDragonslayerEdge.Bonus1 = 4;
                    MinstrelDragonslayerEdge.Bonus1Type = (int)eProperty.Skill_Slashing;
                    MinstrelDragonslayerEdge.Bonus2 = 12;
                    MinstrelDragonslayerEdge.Bonus2Type = (int)eStat.STR;
                    MinstrelDragonslayerEdge.Bonus3 = 12;
                    MinstrelDragonslayerEdge.Bonus3Type = (int)eStat.QUI;
                    MinstrelDragonslayerEdge.Bonus4 = 3;
                    MinstrelDragonslayerEdge.Bonus4Type = (int)eProperty.MeleeDamage;
                    MinstrelDragonslayerEdge.Bonus5 = 3;
                    MinstrelDragonslayerEdge.Bonus5Type = (int)eProperty.StyleDamage;
                    MinstrelDragonslayerEdge.Bonus6 = 3;
                    MinstrelDragonslayerEdge.Bonus6Type = (int)eProperty.SpellDamage;
                    MinstrelDragonslayerEdge.Bonus7 = 7;
                    MinstrelDragonslayerEdge.Bonus7Type = (int)eProperty.StrCapBonus;
                    MinstrelDragonslayerEdge.SpellID = 32187;
                    MinstrelDragonslayerEdge.Charges = 100;
                    MinstrelDragonslayerEdge.MaxCharges = 100;
                    MinstrelDragonslayerEdge.ProcSpellID = 32183;
                    GameServer.Database.AddObject(MinstrelDragonslayerEdge);
                }

                if (MinstrelDragonslayerBlade == null)
                {
                    MinstrelDragonslayerBlade = new ItemTemplate();
                    MinstrelDragonslayerBlade.Id_nb = "MinstrelDragonslayerBlade";
                    MinstrelDragonslayerBlade.Name = "Minstrel Dragonslayer Blade";
                    MinstrelDragonslayerBlade.Level = 51;
                    MinstrelDragonslayerBlade.Item_Type = 10;
                    MinstrelDragonslayerBlade.Model = 3972;
                    MinstrelDragonslayerBlade.IsDropable = true;
                    MinstrelDragonslayerBlade.IsPickable = true;
                    MinstrelDragonslayerBlade.Type_Damage = 2;
                    MinstrelDragonslayerBlade.DPS_AF = 165;
                    MinstrelDragonslayerBlade.SPD_ABS = 42;
                    MinstrelDragonslayerBlade.Price = 3500;
                    MinstrelDragonslayerBlade.Object_Type = 3;
                    MinstrelDragonslayerBlade.Quality = 100;
                    MinstrelDragonslayerBlade.IsTradable = false;
                    MinstrelDragonslayerBlade.Weight = 25;
                    MinstrelDragonslayerBlade.Bonus = 35;
                    MinstrelDragonslayerBlade.MaxCondition = 50000;
                    MinstrelDragonslayerBlade.MaxDurability = 50000;
                    MinstrelDragonslayerBlade.Condition = 50000;
                    MinstrelDragonslayerBlade.Durability = 50000;
                    MinstrelDragonslayerBlade.Bonus1 = 4;
                    MinstrelDragonslayerBlade.Bonus1Type = (int)eProperty.Skill_Slashing;
                    MinstrelDragonslayerBlade.Bonus2 = 12;
                    MinstrelDragonslayerBlade.Bonus2Type = (int)eStat.STR;
                    MinstrelDragonslayerBlade.Bonus3 = 12;
                    MinstrelDragonslayerBlade.Bonus3Type = (int)eStat.QUI;
                    MinstrelDragonslayerBlade.Bonus4 = 3;
                    MinstrelDragonslayerBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    MinstrelDragonslayerBlade.Bonus5 = 3;
                    MinstrelDragonslayerBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    MinstrelDragonslayerBlade.Bonus6 = 3;
                    MinstrelDragonslayerBlade.Bonus6Type = (int)eProperty.SpellDamage;
                    MinstrelDragonslayerBlade.Bonus7 = 7;
                    MinstrelDragonslayerBlade.Bonus7Type = (int)eProperty.StrCapBonus;
                    MinstrelDragonslayerBlade.SpellID = 32187;
                    MinstrelDragonslayerBlade.Charges = 100;
                    MinstrelDragonslayerBlade.MaxCharges = 100;
                    MinstrelDragonslayerBlade.ProcSpellID = 32183;
                    GameServer.Database.AddObject(MinstrelDragonslayerBlade);
                }

                if (MinstrelDragonslayerHarp == null)
                {
                    MinstrelDragonslayerHarp = new ItemTemplate();
                    MinstrelDragonslayerHarp.Id_nb = "MinstrelDragonslayerHarp";
                    MinstrelDragonslayerHarp.Name = "Dragonslayer Harp";
                    MinstrelDragonslayerHarp.Level = 50;
                    MinstrelDragonslayerHarp.Durability = 50000;
                    MinstrelDragonslayerHarp.MaxDurability = 50000;
                    MinstrelDragonslayerHarp.Condition = 50000;
                    MinstrelDragonslayerHarp.MaxCondition = 50000;
                    MinstrelDragonslayerHarp.Quality = 100;
                    MinstrelDragonslayerHarp.Hand = 1;
                    MinstrelDragonslayerHarp.Object_Type = 45;
                    MinstrelDragonslayerHarp.Item_Type = 13;
                    MinstrelDragonslayerHarp.Weight = 20;
                    MinstrelDragonslayerHarp.Model = 3985;
                    MinstrelDragonslayerHarp.Price = 3500;
                    MinstrelDragonslayerHarp.Bonus = 35;
                    MinstrelDragonslayerHarp.Bonus1 = 15;
                    MinstrelDragonslayerHarp.Bonus2 = 15;
                    MinstrelDragonslayerHarp.Bonus3 = 5;
                    MinstrelDragonslayerHarp.Bonus4 = 1;
                    MinstrelDragonslayerHarp.Bonus5 = 1;
                    MinstrelDragonslayerHarp.Bonus6 = 1;
                    MinstrelDragonslayerHarp.Bonus7 = 1;
                    MinstrelDragonslayerHarp.Bonus8 = 10;
                    MinstrelDragonslayerHarp.Bonus9 = 10;
                    MinstrelDragonslayerHarp.Bonus10 = 4;
                    MinstrelDragonslayerHarp.Bonus1Type = 2;
                    MinstrelDragonslayerHarp.Bonus2Type = 156;
                    MinstrelDragonslayerHarp.Bonus3Type = 196;
                    MinstrelDragonslayerHarp.Bonus4Type = 17;
                    MinstrelDragonslayerHarp.Bonus5Type = 13;
                    MinstrelDragonslayerHarp.Bonus6Type = 19;
                    MinstrelDragonslayerHarp.Bonus7Type = 15;
                    MinstrelDragonslayerHarp.Bonus8Type = 202;
                    MinstrelDragonslayerHarp.Bonus9Type = 209;
                    MinstrelDragonslayerHarp.Bonus10Type = 153;
                    MinstrelDragonslayerHarp.IsPickable = true;
                    MinstrelDragonslayerHarp.IsDropable = true;
                    MinstrelDragonslayerHarp.CanDropAsLoot = false;
                    MinstrelDragonslayerHarp.IsTradable = false;
                    MinstrelDragonslayerHarp.MaxCount = 1;
                    MinstrelDragonslayerHarp.PackSize = 1;
                    MinstrelDragonslayerHarp.Charges = 100;
                    MinstrelDragonslayerHarp.MaxCharges = 100;
                    MinstrelDragonslayerHarp.Charges1 = 100;
                    MinstrelDragonslayerHarp.MaxCharges1 = 100;
                    MinstrelDragonslayerHarp.SpellID = 1092;
                    MinstrelDragonslayerHarp.SpellID1 = 1094;
                    GameServer.Database.AddObject(MinstrelDragonslayerHarp);
                }

                if (MercenaryDragonslayerLaevusMace == null)
                {
                    MercenaryDragonslayerLaevusMace = new ItemTemplate();
                    MercenaryDragonslayerLaevusMace.Id_nb = "MercenaryDragonslayerLaevusMace";
                    MercenaryDragonslayerLaevusMace.Name = "Mercenary Dragonslayer Laevus Mace";
                    MercenaryDragonslayerLaevusMace.Level = 51;
                    MercenaryDragonslayerLaevusMace.Item_Type = 10;
                    MercenaryDragonslayerLaevusMace.Hand = 2;
                    MercenaryDragonslayerLaevusMace.Model = 3973;
                    MercenaryDragonslayerLaevusMace.IsDropable = true;
                    MercenaryDragonslayerLaevusMace.IsPickable = true;
                    MercenaryDragonslayerLaevusMace.Type_Damage = 1;
                    MercenaryDragonslayerLaevusMace.DPS_AF = 165;
                    MercenaryDragonslayerLaevusMace.SPD_ABS = 42;
                    MercenaryDragonslayerLaevusMace.Object_Type = 2;
                    MercenaryDragonslayerLaevusMace.Quality = 100;
                    MercenaryDragonslayerLaevusMace.IsTradable = false;
                    MercenaryDragonslayerLaevusMace.Price = 3500;
                    MercenaryDragonslayerLaevusMace.Weight = 25;
                    MercenaryDragonslayerLaevusMace.Bonus = 35;
                    MercenaryDragonslayerLaevusMace.MaxCondition = 50000;
                    MercenaryDragonslayerLaevusMace.MaxDurability = 50000;
                    MercenaryDragonslayerLaevusMace.Condition = 50000;
                    MercenaryDragonslayerLaevusMace.Durability = 50000;
                    MercenaryDragonslayerLaevusMace.Bonus1 = 4;
                    MercenaryDragonslayerLaevusMace.Bonus1Type = (int)eProperty.Skill_Dual_Wield;
                    MercenaryDragonslayerLaevusMace.Bonus2 = 12;
                    MercenaryDragonslayerLaevusMace.Bonus2Type = (int)eStat.STR;
                    MercenaryDragonslayerLaevusMace.Bonus3 = 12;
                    MercenaryDragonslayerLaevusMace.Bonus3Type = (int)eStat.QUI;
                    MercenaryDragonslayerLaevusMace.Bonus4 = 4;
                    MercenaryDragonslayerLaevusMace.Bonus4Type = (int)eProperty.MeleeDamage;
                    MercenaryDragonslayerLaevusMace.Bonus5 = 4;
                    MercenaryDragonslayerLaevusMace.Bonus5Type = (int)eProperty.StyleDamage;
                    MercenaryDragonslayerLaevusMace.Bonus6 = 8;
                    MercenaryDragonslayerLaevusMace.Bonus6Type = (int)eProperty.StrCapBonus;
                    MercenaryDragonslayerLaevusMace.ProcSpellID = 32184;
                    MercenaryDragonslayerLaevusMace.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(MercenaryDragonslayerLaevusMace);
                }

                if (MercenaryDragonslayerLaevusEdge == null)
                {
                    MercenaryDragonslayerLaevusEdge = new ItemTemplate();
                    MercenaryDragonslayerLaevusEdge.Id_nb = "MercenaryDragonslayerLaevusEdge";
                    MercenaryDragonslayerLaevusEdge.Name = "Mercenary Dragonslayer Laevus Edge";
                    MercenaryDragonslayerLaevusEdge.Level = 51;
                    MercenaryDragonslayerLaevusEdge.Item_Type = 10;
                    MercenaryDragonslayerLaevusEdge.Hand = 2;
                    MercenaryDragonslayerLaevusEdge.Model = 3975;
                    MercenaryDragonslayerLaevusEdge.IsDropable = true;
                    MercenaryDragonslayerLaevusEdge.IsPickable = true;
                    MercenaryDragonslayerLaevusEdge.Type_Damage = 3;
                    MercenaryDragonslayerLaevusEdge.DPS_AF = 165;
                    MercenaryDragonslayerLaevusEdge.SPD_ABS = 34;
                    MercenaryDragonslayerLaevusEdge.Price = 3500;
                    MercenaryDragonslayerLaevusEdge.Object_Type = 4;
                    MercenaryDragonslayerLaevusEdge.Quality = 100;
                    MercenaryDragonslayerLaevusEdge.IsTradable = false;
                    MercenaryDragonslayerLaevusEdge.Weight = 25;
                    MercenaryDragonslayerLaevusEdge.Bonus = 35;
                    MercenaryDragonslayerLaevusEdge.MaxCondition = 50000;
                    MercenaryDragonslayerLaevusEdge.MaxDurability = 50000;
                    MercenaryDragonslayerLaevusEdge.Condition = 50000;
                    MercenaryDragonslayerLaevusEdge.Durability = 50000;
                    MercenaryDragonslayerLaevusEdge.Bonus1 = 4;
                    MercenaryDragonslayerLaevusEdge.Bonus1Type = (int)eProperty.Skill_Dual_Wield;
                    MercenaryDragonslayerLaevusEdge.Bonus2 = 9;
                    MercenaryDragonslayerLaevusEdge.Bonus2Type = (int)eStat.STR;
                    MercenaryDragonslayerLaevusEdge.Bonus3 = 9;
                    MercenaryDragonslayerLaevusEdge.Bonus3Type = (int)eStat.DEX;
                    MercenaryDragonslayerLaevusEdge.Bonus4 = 4;
                    MercenaryDragonslayerLaevusEdge.Bonus4Type = (int)eProperty.MeleeDamage;
                    MercenaryDragonslayerLaevusEdge.Bonus5 = 4;
                    MercenaryDragonslayerLaevusEdge.Bonus5Type = (int)eProperty.StyleDamage;
                    MercenaryDragonslayerLaevusEdge.Bonus6 = 5;
                    MercenaryDragonslayerLaevusEdge.Bonus6Type = (int)eProperty.StrCapBonus;
                    MercenaryDragonslayerLaevusEdge.Bonus7 = 5;
                    MercenaryDragonslayerLaevusEdge.Bonus7Type = (int)eProperty.DexCapBonus;
                    MercenaryDragonslayerLaevusEdge.ProcSpellID = 32184;
                    MercenaryDragonslayerLaevusEdge.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(MercenaryDragonslayerLaevusEdge);
                }

                if (MercenaryDragonslayerLaevusBlade == null)
                {
                    MercenaryDragonslayerLaevusBlade = new ItemTemplate();
                    MercenaryDragonslayerLaevusBlade.Id_nb = "MercenaryDragonslayerLaevusBlade";
                    MercenaryDragonslayerLaevusBlade.Name = "Mercenary Dragonslayer Laevus Blade";
                    MercenaryDragonslayerLaevusBlade.Level = 51;
                    MercenaryDragonslayerLaevusBlade.Item_Type = 11;
                    MercenaryDragonslayerLaevusBlade.Hand = 2;
                    MercenaryDragonslayerLaevusBlade.Model = 3971;
                    MercenaryDragonslayerLaevusBlade.IsDropable = true;
                    MercenaryDragonslayerLaevusBlade.IsPickable = true;
                    MercenaryDragonslayerLaevusBlade.Type_Damage = 2;
                    MercenaryDragonslayerLaevusBlade.DPS_AF = 165;
                    MercenaryDragonslayerLaevusBlade.SPD_ABS = 40;
                    MercenaryDragonslayerLaevusBlade.Price = 3500;
                    MercenaryDragonslayerLaevusBlade.Object_Type = 3;
                    MercenaryDragonslayerLaevusBlade.Quality = 100;
                    MercenaryDragonslayerLaevusBlade.IsTradable = false;
                    MercenaryDragonslayerLaevusBlade.Weight = 25;
                    MercenaryDragonslayerLaevusBlade.Bonus = 35;
                    MercenaryDragonslayerLaevusBlade.MaxCondition = 50000;
                    MercenaryDragonslayerLaevusBlade.MaxDurability = 50000;
                    MercenaryDragonslayerLaevusBlade.Condition = 50000;
                    MercenaryDragonslayerLaevusBlade.Durability = 50000;
                    MercenaryDragonslayerLaevusBlade.Bonus1 = 4;
                    MercenaryDragonslayerLaevusBlade.Bonus1Type = (int)eProperty.Skill_Dual_Wield;
                    MercenaryDragonslayerLaevusBlade.Bonus2 = 12;
                    MercenaryDragonslayerLaevusBlade.Bonus2Type = (int)eStat.STR;
                    MercenaryDragonslayerLaevusBlade.Bonus3 = 12;
                    MercenaryDragonslayerLaevusBlade.Bonus3Type = (int)eStat.QUI;
                    MercenaryDragonslayerLaevusBlade.Bonus4 = 4;
                    MercenaryDragonslayerLaevusBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    MercenaryDragonslayerLaevusBlade.Bonus5 = 4;
                    MercenaryDragonslayerLaevusBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    MercenaryDragonslayerLaevusBlade.Bonus6 = 8;
                    MercenaryDragonslayerLaevusBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    MercenaryDragonslayerLaevusBlade.ProcSpellID = 32184;
                    MercenaryDragonslayerLaevusBlade.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(MercenaryDragonslayerLaevusBlade);
                }

                if (MercenaryDragonslayerMace == null)
                {
                    MercenaryDragonslayerMace = new ItemTemplate();
                    MercenaryDragonslayerMace.Id_nb = "MercenaryDragonslayerMace";
                    MercenaryDragonslayerMace.Name = "Mercenary Dragonslayer Mace";
                    MercenaryDragonslayerMace.Level = 51;
                    MercenaryDragonslayerMace.Item_Type = 10;
                    MercenaryDragonslayerMace.Model = 3974;
                    MercenaryDragonslayerMace.IsDropable = true;
                    MercenaryDragonslayerMace.IsPickable = true;
                    MercenaryDragonslayerMace.Type_Damage = 1;
                    MercenaryDragonslayerMace.DPS_AF = 165;
                    MercenaryDragonslayerMace.SPD_ABS = 42;
                    MercenaryDragonslayerMace.Price = 3500;
                    MercenaryDragonslayerMace.Object_Type = 2;
                    MercenaryDragonslayerMace.Quality = 100;
                    MercenaryDragonslayerMace.IsTradable = false;
                    MercenaryDragonslayerMace.Weight = 25;
                    MercenaryDragonslayerMace.Bonus = 35;
                    MercenaryDragonslayerMace.MaxCondition = 50000;
                    MercenaryDragonslayerMace.MaxDurability = 50000;
                    MercenaryDragonslayerMace.Condition = 50000;
                    MercenaryDragonslayerMace.Durability = 50000;
                    MercenaryDragonslayerMace.Bonus1 = 4;
                    MercenaryDragonslayerMace.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    MercenaryDragonslayerMace.Bonus2 = 12;
                    MercenaryDragonslayerMace.Bonus2Type = (int)eStat.STR;
                    MercenaryDragonslayerMace.Bonus3 = 12;
                    MercenaryDragonslayerMace.Bonus3Type = (int)eStat.QUI;
                    MercenaryDragonslayerMace.Bonus4 = 4;
                    MercenaryDragonslayerMace.Bonus4Type = (int)eProperty.MeleeDamage;
                    MercenaryDragonslayerMace.Bonus5 = 4;
                    MercenaryDragonslayerMace.Bonus5Type = (int)eProperty.StyleDamage;
                    MercenaryDragonslayerMace.Bonus6 = 8;
                    MercenaryDragonslayerMace.Bonus6Type = (int)eProperty.StrCapBonus;
                    MercenaryDragonslayerMace.ProcSpellID = 32184;
                    MercenaryDragonslayerMace.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(MercenaryDragonslayerMace);
                }

                if (MercenaryDragonslayerEdge == null)
                {
                    MercenaryDragonslayerEdge = new ItemTemplate();
                    MercenaryDragonslayerEdge.Id_nb = "MercenaryDragonslayerEdge";
                    MercenaryDragonslayerEdge.Name = "Mercenary Dragonslayer Edge";
                    MercenaryDragonslayerEdge.Level = 51;
                    MercenaryDragonslayerEdge.Item_Type = 10;
                    MercenaryDragonslayerEdge.Model = 3976;
                    MercenaryDragonslayerEdge.IsDropable = true;
                    MercenaryDragonslayerEdge.IsPickable = true;
                    MercenaryDragonslayerEdge.Type_Damage = 3;
                    MercenaryDragonslayerEdge.DPS_AF = 165;
                    MercenaryDragonslayerEdge.Price = 3500;
                    MercenaryDragonslayerEdge.SPD_ABS = 42;
                    MercenaryDragonslayerEdge.Object_Type = 4;
                    MercenaryDragonslayerEdge.Quality = 100;
                    MercenaryDragonslayerEdge.IsTradable = false;
                    MercenaryDragonslayerEdge.Weight = 25;
                    MercenaryDragonslayerEdge.Bonus = 35;
                    MercenaryDragonslayerEdge.MaxCondition = 50000;
                    MercenaryDragonslayerEdge.MaxDurability = 50000;
                    MercenaryDragonslayerEdge.Condition = 50000;
                    MercenaryDragonslayerEdge.Durability = 50000;
                    MercenaryDragonslayerEdge.Bonus1 = 4;
                    MercenaryDragonslayerEdge.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    MercenaryDragonslayerEdge.Bonus2 = 9;
                    MercenaryDragonslayerEdge.Bonus2Type = (int)eStat.STR;
                    MercenaryDragonslayerEdge.Bonus3 = 9;
                    MercenaryDragonslayerEdge.Bonus3Type = (int)eStat.DEX;
                    MercenaryDragonslayerEdge.Bonus4 = 4;
                    MercenaryDragonslayerEdge.Bonus4Type = (int)eProperty.MeleeDamage;
                    MercenaryDragonslayerEdge.Bonus5 = 4;
                    MercenaryDragonslayerEdge.Bonus5Type = (int)eProperty.StyleDamage;
                    MercenaryDragonslayerEdge.Bonus6 = 5;
                    MercenaryDragonslayerEdge.Bonus6Type = (int)eProperty.StrCapBonus;
                    MercenaryDragonslayerEdge.Bonus7 = 5;
                    MercenaryDragonslayerEdge.Bonus7Type = (int)eProperty.DexCapBonus;
                    MercenaryDragonslayerEdge.ProcSpellID = 32184;
                    MercenaryDragonslayerEdge.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(MercenaryDragonslayerEdge);
                }

                if (MercenaryDragonslayerBlade == null)
                {
                    MercenaryDragonslayerBlade = new ItemTemplate();
                    MercenaryDragonslayerBlade.Id_nb = "MercenaryDragonslayerBlade";
                    MercenaryDragonslayerBlade.Name = "Mercenary Dragonslayer Blade";
                    MercenaryDragonslayerBlade.Level = 51;
                    MercenaryDragonslayerBlade.Item_Type = 10;
                    MercenaryDragonslayerBlade.Model = 3972;
                    MercenaryDragonslayerBlade.IsDropable = true;
                    MercenaryDragonslayerBlade.IsPickable = true;
                    MercenaryDragonslayerBlade.Type_Damage = 2;
                    MercenaryDragonslayerBlade.DPS_AF = 165;
                    MercenaryDragonslayerBlade.Price = 3500;
                    MercenaryDragonslayerBlade.SPD_ABS = 42;
                    MercenaryDragonslayerBlade.Object_Type = 3;
                    MercenaryDragonslayerBlade.Quality = 100;
                    MercenaryDragonslayerBlade.IsTradable = false;
                    MercenaryDragonslayerBlade.Weight = 25;
                    MercenaryDragonslayerBlade.Bonus = 35;
                    MercenaryDragonslayerBlade.MaxCondition = 50000;
                    MercenaryDragonslayerBlade.MaxDurability = 50000;
                    MercenaryDragonslayerBlade.Condition = 50000;
                    MercenaryDragonslayerBlade.Durability = 50000;
                    MercenaryDragonslayerBlade.Bonus1 = 4;
                    MercenaryDragonslayerBlade.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    MercenaryDragonslayerBlade.Bonus2 = 12;
                    MercenaryDragonslayerBlade.Bonus2Type = (int)eStat.STR;
                    MercenaryDragonslayerBlade.Bonus3 = 12;
                    MercenaryDragonslayerBlade.Bonus3Type = (int)eStat.QUI;
                    MercenaryDragonslayerBlade.Bonus4 = 4;
                    MercenaryDragonslayerBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    MercenaryDragonslayerBlade.Bonus5 = 4;
                    MercenaryDragonslayerBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    MercenaryDragonslayerBlade.Bonus6 = 8;
                    MercenaryDragonslayerBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    MercenaryDragonslayerBlade.ProcSpellID = 32184;
                    MercenaryDragonslayerBlade.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(MercenaryDragonslayerBlade);
                }

                if (InfiltratorDragonslayerBlade == null)
                {
                    InfiltratorDragonslayerBlade = new ItemTemplate();
                    InfiltratorDragonslayerBlade.Id_nb = "InfiltratorDragonslayerBlade";
                    InfiltratorDragonslayerBlade.Name = "Infiltrator Dragonslayer Blade";
                    InfiltratorDragonslayerBlade.Level = 51;
                    InfiltratorDragonslayerBlade.Item_Type = 10;
                    InfiltratorDragonslayerBlade.Model = 3972;
                    InfiltratorDragonslayerBlade.IsDropable = true;
                    InfiltratorDragonslayerBlade.IsPickable = true;
                    InfiltratorDragonslayerBlade.Type_Damage = 2;
                    InfiltratorDragonslayerBlade.DPS_AF = 165;
                    InfiltratorDragonslayerBlade.Price = 3500;
                    InfiltratorDragonslayerBlade.SPD_ABS = 42;
                    InfiltratorDragonslayerBlade.Object_Type = 3;
                    InfiltratorDragonslayerBlade.Quality = 100;
                    InfiltratorDragonslayerBlade.IsTradable = false;
                    InfiltratorDragonslayerBlade.Weight = 25;
                    InfiltratorDragonslayerBlade.Bonus = 35;
                    InfiltratorDragonslayerBlade.MaxCondition = 50000;
                    InfiltratorDragonslayerBlade.MaxDurability = 50000;
                    InfiltratorDragonslayerBlade.Condition = 50000;
                    InfiltratorDragonslayerBlade.Durability = 50000;
                    InfiltratorDragonslayerBlade.Bonus1 = 4;
                    InfiltratorDragonslayerBlade.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    InfiltratorDragonslayerBlade.Bonus2 = 12;
                    InfiltratorDragonslayerBlade.Bonus2Type = (int)eStat.STR;
                    InfiltratorDragonslayerBlade.Bonus3 = 12;
                    InfiltratorDragonslayerBlade.Bonus3Type = (int)eStat.QUI;
                    InfiltratorDragonslayerBlade.Bonus4 = 4;
                    InfiltratorDragonslayerBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    InfiltratorDragonslayerBlade.Bonus5 = 4;
                    InfiltratorDragonslayerBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    InfiltratorDragonslayerBlade.Bonus6 = 8;
                    InfiltratorDragonslayerBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    InfiltratorDragonslayerBlade.ProcSpellID = 32183;
                    InfiltratorDragonslayerBlade.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(InfiltratorDragonslayerBlade);
                }

                if (InfiltratorDragonslayerEdge == null)
                {
                    InfiltratorDragonslayerEdge = new ItemTemplate();
                    InfiltratorDragonslayerEdge.Id_nb = "InfiltratorDragonslayerEdge";
                    InfiltratorDragonslayerEdge.Name = "Infiltrator Dragonslayer Edge";
                    InfiltratorDragonslayerEdge.Level = 51;
                    InfiltratorDragonslayerEdge.Item_Type = 10;
                    InfiltratorDragonslayerEdge.Model = 3976;
                    InfiltratorDragonslayerEdge.IsDropable = true;
                    InfiltratorDragonslayerEdge.IsPickable = true;
                    InfiltratorDragonslayerEdge.Type_Damage = 3;
                    InfiltratorDragonslayerEdge.DPS_AF = 165;
                    InfiltratorDragonslayerEdge.Price = 3500;
                    InfiltratorDragonslayerEdge.SPD_ABS = 42;
                    InfiltratorDragonslayerEdge.Object_Type = 4;
                    InfiltratorDragonslayerEdge.Quality = 100;
                    InfiltratorDragonslayerEdge.IsTradable = false;
                    InfiltratorDragonslayerEdge.Weight = 25;
                    InfiltratorDragonslayerEdge.Bonus = 35;
                    InfiltratorDragonslayerEdge.MaxCondition = 50000;
                    InfiltratorDragonslayerEdge.MaxDurability = 50000;
                    InfiltratorDragonslayerEdge.Condition = 50000;
                    InfiltratorDragonslayerEdge.Durability = 50000;
                    InfiltratorDragonslayerEdge.Bonus1 = 4;
                    InfiltratorDragonslayerEdge.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    InfiltratorDragonslayerEdge.Bonus2 = 9;
                    InfiltratorDragonslayerEdge.Bonus2Type = (int)eStat.STR;
                    InfiltratorDragonslayerEdge.Bonus3 = 9;
                    InfiltratorDragonslayerEdge.Bonus3Type = (int)eStat.QUI;
                    InfiltratorDragonslayerEdge.Bonus4 = 4;
                    InfiltratorDragonslayerEdge.Bonus4Type = (int)eProperty.MeleeDamage;
                    InfiltratorDragonslayerEdge.Bonus5 = 4;
                    InfiltratorDragonslayerEdge.Bonus5Type = (int)eProperty.StyleDamage;
                    InfiltratorDragonslayerEdge.Bonus6 = 5;
                    InfiltratorDragonslayerEdge.Bonus6Type = (int)eProperty.StrCapBonus;
                    InfiltratorDragonslayerEdge.Bonus7 = 5;
                    InfiltratorDragonslayerEdge.Bonus7Type = (int)eProperty.DexCapBonus;
                    InfiltratorDragonslayerEdge.ProcSpellID = 32183;
                    InfiltratorDragonslayerEdge.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(InfiltratorDragonslayerEdge);
                }

                if (InfiltratorDragonslayerLaevusBlade == null)
                {
                    InfiltratorDragonslayerLaevusBlade = new ItemTemplate();
                    InfiltratorDragonslayerLaevusBlade.Id_nb = "InfiltratorDragonslayerLaevusBlade";
                    InfiltratorDragonslayerLaevusBlade.Name = "Infiltrator Dragonslayer Laevus Blade";
                    InfiltratorDragonslayerLaevusBlade.Level = 51;
                    InfiltratorDragonslayerLaevusBlade.Item_Type = 11;
                    InfiltratorDragonslayerLaevusBlade.Hand = 2;
                    InfiltratorDragonslayerLaevusBlade.Model = 3971;
                    InfiltratorDragonslayerLaevusBlade.IsDropable = true;
                    InfiltratorDragonslayerLaevusBlade.IsPickable = true;
                    InfiltratorDragonslayerLaevusBlade.Type_Damage = 2;
                    InfiltratorDragonslayerLaevusBlade.DPS_AF = 165;
                    InfiltratorDragonslayerLaevusBlade.SPD_ABS = 42;
                    InfiltratorDragonslayerLaevusBlade.Object_Type = 3;
                    InfiltratorDragonslayerLaevusBlade.Price = 3500;
                    InfiltratorDragonslayerLaevusBlade.Quality = 100;
                    InfiltratorDragonslayerLaevusBlade.IsTradable = false;
                    InfiltratorDragonslayerLaevusBlade.Weight = 25;
                    InfiltratorDragonslayerLaevusBlade.Bonus = 35;
                    InfiltratorDragonslayerLaevusBlade.MaxCondition = 50000;
                    InfiltratorDragonslayerLaevusBlade.MaxDurability = 50000;
                    InfiltratorDragonslayerLaevusBlade.Condition = 50000;
                    InfiltratorDragonslayerLaevusBlade.Durability = 50000;
                    InfiltratorDragonslayerLaevusBlade.Bonus1 = 4;
                    InfiltratorDragonslayerLaevusBlade.Bonus1Type = (int)eProperty.Skill_Dual_Wield;
                    InfiltratorDragonslayerLaevusBlade.Bonus2 = 12;
                    InfiltratorDragonslayerLaevusBlade.Bonus2Type = (int)eStat.STR;
                    InfiltratorDragonslayerLaevusBlade.Bonus3 = 12;
                    InfiltratorDragonslayerLaevusBlade.Bonus3Type = (int)eStat.QUI;
                    InfiltratorDragonslayerLaevusBlade.Bonus4 = 4;
                    InfiltratorDragonslayerLaevusBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    InfiltratorDragonslayerLaevusBlade.Bonus5 = 4;
                    InfiltratorDragonslayerLaevusBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    InfiltratorDragonslayerLaevusBlade.Bonus6 = 8;
                    InfiltratorDragonslayerLaevusBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    InfiltratorDragonslayerLaevusBlade.ProcSpellID = 32183;
                    InfiltratorDragonslayerLaevusBlade.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(InfiltratorDragonslayerLaevusBlade);
                }

                if (InfiltratorDragonslayerLaevusEdge == null)
                {
                    InfiltratorDragonslayerLaevusEdge = new ItemTemplate();
                    InfiltratorDragonslayerLaevusEdge.Id_nb = "InfiltratorDragonslayerLaevusEdge";
                    InfiltratorDragonslayerLaevusEdge.Name = "Infiltrator Dragonslayer Laevus Edge";
                    InfiltratorDragonslayerLaevusEdge.Level = 51;
                    InfiltratorDragonslayerLaevusEdge.Item_Type = 11;
                    InfiltratorDragonslayerLaevusEdge.Hand = 2;
                    InfiltratorDragonslayerLaevusEdge.Model = 3975;
                    InfiltratorDragonslayerLaevusEdge.IsDropable = true;
                    InfiltratorDragonslayerLaevusEdge.IsPickable = true;
                    InfiltratorDragonslayerLaevusEdge.Type_Damage = 3;
                    InfiltratorDragonslayerLaevusEdge.Price = 3500;
                    InfiltratorDragonslayerLaevusEdge.DPS_AF = 165;
                    InfiltratorDragonslayerLaevusEdge.SPD_ABS = 34;
                    InfiltratorDragonslayerLaevusEdge.Object_Type = 4;
                    InfiltratorDragonslayerLaevusEdge.Quality = 100;
                    InfiltratorDragonslayerLaevusEdge.IsTradable = false;
                    InfiltratorDragonslayerLaevusEdge.Weight = 25;
                    InfiltratorDragonslayerLaevusEdge.Bonus = 35;
                    InfiltratorDragonslayerLaevusEdge.MaxCondition = 50000;
                    InfiltratorDragonslayerLaevusEdge.MaxDurability = 50000;
                    InfiltratorDragonslayerLaevusEdge.Condition = 50000;
                    InfiltratorDragonslayerLaevusEdge.Durability = 50000;
                    InfiltratorDragonslayerLaevusEdge.Bonus1 = 4;
                    InfiltratorDragonslayerLaevusEdge.Bonus1Type = (int)eProperty.Skill_Dual_Wield;
                    InfiltratorDragonslayerLaevusEdge.Bonus2 = 9;
                    InfiltratorDragonslayerLaevusEdge.Bonus2Type = (int)eStat.STR;
                    InfiltratorDragonslayerLaevusEdge.Bonus3 = 9;
                    InfiltratorDragonslayerLaevusEdge.Bonus3Type = (int)eStat.QUI;
                    InfiltratorDragonslayerLaevusEdge.Bonus4 = 4;
                    InfiltratorDragonslayerLaevusEdge.Bonus4Type = (int)eProperty.MeleeDamage;
                    InfiltratorDragonslayerLaevusEdge.Bonus5 = 4;
                    InfiltratorDragonslayerLaevusEdge.Bonus5Type = (int)eProperty.StyleDamage;
                    InfiltratorDragonslayerLaevusEdge.Bonus6 = 5;
                    InfiltratorDragonslayerLaevusEdge.Bonus6Type = (int)eProperty.StrCapBonus;
                    InfiltratorDragonslayerLaevusEdge.Bonus7 = 5;
                    InfiltratorDragonslayerLaevusEdge.Bonus7Type = (int)eProperty.DexCapBonus;
                    InfiltratorDragonslayerLaevusEdge.ProcSpellID = 32183;
                    InfiltratorDragonslayerLaevusEdge.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(InfiltratorDragonslayerLaevusEdge);
                }

                if (BlademasterDragonslayerFuarBlade == null)
                {
                    BlademasterDragonslayerFuarBlade = new ItemTemplate();
                    BlademasterDragonslayerFuarBlade.Id_nb = "BlademasterDragonslayerFuarBlade";
                    BlademasterDragonslayerFuarBlade.Name = "Blademaster Dragonslayer Fuar Blade";
                    BlademasterDragonslayerFuarBlade.Level = 51;
                    BlademasterDragonslayerFuarBlade.Item_Type = 10;
                    BlademasterDragonslayerFuarBlade.Model = 3895;
                    BlademasterDragonslayerFuarBlade.IsDropable = true;
                    BlademasterDragonslayerFuarBlade.IsPickable = true;
                    BlademasterDragonslayerFuarBlade.Type_Damage = 2;
                    BlademasterDragonslayerFuarBlade.Price = 3500;
                    BlademasterDragonslayerFuarBlade.DPS_AF = 165;
                    BlademasterDragonslayerFuarBlade.SPD_ABS = 42;
                    BlademasterDragonslayerFuarBlade.Object_Type = 19;
                    BlademasterDragonslayerFuarBlade.Quality = 100;
                    BlademasterDragonslayerFuarBlade.IsTradable = false;
                    BlademasterDragonslayerFuarBlade.Weight = 25;
                    BlademasterDragonslayerFuarBlade.Bonus = 35;
                    BlademasterDragonslayerFuarBlade.MaxCondition = 50000;
                    BlademasterDragonslayerFuarBlade.MaxDurability = 50000;
                    BlademasterDragonslayerFuarBlade.Condition = 50000;
                    BlademasterDragonslayerFuarBlade.Durability = 50000;
                    BlademasterDragonslayerFuarBlade.Bonus1 = 4;
                    BlademasterDragonslayerFuarBlade.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    BlademasterDragonslayerFuarBlade.Bonus2 = 12;
                    BlademasterDragonslayerFuarBlade.Bonus2Type = (int)eStat.STR;
                    BlademasterDragonslayerFuarBlade.Bonus3 = 12;
                    BlademasterDragonslayerFuarBlade.Bonus3Type = (int)eStat.QUI;
                    BlademasterDragonslayerFuarBlade.Bonus4 = 4;
                    BlademasterDragonslayerFuarBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    BlademasterDragonslayerFuarBlade.Bonus5 = 4;
                    BlademasterDragonslayerFuarBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    BlademasterDragonslayerFuarBlade.Bonus6 = 8;
                    BlademasterDragonslayerFuarBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    BlademasterDragonslayerFuarBlade.SpellID = 32188;
                    BlademasterDragonslayerFuarBlade.Charges = 100;
                    BlademasterDragonslayerFuarBlade.MaxCharges = 100;
                    BlademasterDragonslayerFuarBlade.ProcSpellID = 32177;
                    GameServer.Database.AddObject(BlademasterDragonslayerFuarBlade);
                }

                if (BlademasterDragonslayerFuarHammer == null)
                {
                    BlademasterDragonslayerFuarHammer = new ItemTemplate();
                    BlademasterDragonslayerFuarHammer.Id_nb = "BlademasterDragonslayerFuarHammer";
                    BlademasterDragonslayerFuarHammer.Name = "Blademaster Dragonslayer Fuar Hammer";
                    BlademasterDragonslayerFuarHammer.Level = 51;
                    BlademasterDragonslayerFuarHammer.Item_Type = 10;
                    BlademasterDragonslayerFuarHammer.Model = 3897;
                    BlademasterDragonslayerFuarHammer.IsDropable = true;
                    BlademasterDragonslayerFuarHammer.IsPickable = true;
                    BlademasterDragonslayerFuarHammer.Type_Damage = 1;
                    BlademasterDragonslayerFuarHammer.DPS_AF = 165;
                    BlademasterDragonslayerFuarHammer.Price = 3500;
                    BlademasterDragonslayerFuarHammer.SPD_ABS = 42;
                    BlademasterDragonslayerFuarHammer.Object_Type = 20;
                    BlademasterDragonslayerFuarHammer.Quality = 100;
                    BlademasterDragonslayerFuarHammer.IsTradable = false;
                    BlademasterDragonslayerFuarHammer.Weight = 25;
                    BlademasterDragonslayerFuarHammer.Bonus = 35;
                    BlademasterDragonslayerFuarHammer.MaxCondition = 50000;
                    BlademasterDragonslayerFuarHammer.MaxDurability = 50000;
                    BlademasterDragonslayerFuarHammer.Condition = 50000;
                    BlademasterDragonslayerFuarHammer.Durability = 50000;
                    BlademasterDragonslayerFuarHammer.Bonus1 = 4;
                    BlademasterDragonslayerFuarHammer.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    BlademasterDragonslayerFuarHammer.Bonus2 = 12;
                    BlademasterDragonslayerFuarHammer.Bonus2Type = (int)eStat.STR;
                    BlademasterDragonslayerFuarHammer.Bonus3 = 12;
                    BlademasterDragonslayerFuarHammer.Bonus3Type = (int)eStat.DEX;
                    BlademasterDragonslayerFuarHammer.Bonus4 = 4;
                    BlademasterDragonslayerFuarHammer.Bonus4Type = (int)eProperty.MeleeDamage;
                    BlademasterDragonslayerFuarHammer.Bonus5 = 4;
                    BlademasterDragonslayerFuarHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    BlademasterDragonslayerFuarHammer.Bonus6 = 8;
                    BlademasterDragonslayerFuarHammer.Bonus6Type = (int)eProperty.StrCapBonus;
                    BlademasterDragonslayerFuarHammer.SpellID = 32188;
                    BlademasterDragonslayerFuarHammer.Charges = 100;
                    BlademasterDragonslayerFuarHammer.MaxCharges = 100;
                    BlademasterDragonslayerFuarHammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(BlademasterDragonslayerFuarHammer);
                }

                if (BlademasterDragonslayerFuarSteel == null)
                {
                    BlademasterDragonslayerFuarSteel = new ItemTemplate();
                    BlademasterDragonslayerFuarSteel.Id_nb = "BlademasterDragonslayerFuarSteel";
                    BlademasterDragonslayerFuarSteel.Name = "Blademaster Dragonslayer Fuar Steel";
                    BlademasterDragonslayerFuarSteel.Level = 51;
                    BlademasterDragonslayerFuarSteel.Item_Type = 10;
                    BlademasterDragonslayerFuarSteel.Model = 3899;
                    BlademasterDragonslayerFuarSteel.IsDropable = true;
                    BlademasterDragonslayerFuarSteel.IsPickable = true;
                    BlademasterDragonslayerFuarSteel.Type_Damage = 1;
                    BlademasterDragonslayerFuarSteel.Price = 3500;
                    BlademasterDragonslayerFuarSteel.DPS_AF = 165;
                    BlademasterDragonslayerFuarSteel.SPD_ABS = 42;
                    BlademasterDragonslayerFuarSteel.Object_Type = 11;
                    BlademasterDragonslayerFuarSteel.Quality = 100;
                    BlademasterDragonslayerFuarSteel.IsTradable = false;
                    BlademasterDragonslayerFuarSteel.Weight = 25;
                    BlademasterDragonslayerFuarSteel.Bonus = 35;
                    BlademasterDragonslayerFuarSteel.MaxCondition = 50000;
                    BlademasterDragonslayerFuarSteel.MaxDurability = 50000;
                    BlademasterDragonslayerFuarSteel.Condition = 50000;
                    BlademasterDragonslayerFuarSteel.Durability = 50000;
                    BlademasterDragonslayerFuarSteel.Bonus1 = 4;
                    BlademasterDragonslayerFuarSteel.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    BlademasterDragonslayerFuarSteel.Bonus2 = 7;
                    BlademasterDragonslayerFuarSteel.Bonus2Type = (int)eStat.STR;
                    BlademasterDragonslayerFuarSteel.Bonus3 = 9;
                    BlademasterDragonslayerFuarSteel.Bonus3Type = (int)eStat.DEX;
                    BlademasterDragonslayerFuarSteel.Bonus4 = 4;
                    BlademasterDragonslayerFuarSteel.Bonus4Type = (int)eProperty.MeleeDamage;
                    BlademasterDragonslayerFuarSteel.Bonus5 = 4;
                    BlademasterDragonslayerFuarSteel.Bonus5Type = (int)eProperty.StyleDamage;
                    BlademasterDragonslayerFuarSteel.Bonus6 = 5;
                    BlademasterDragonslayerFuarSteel.Bonus6Type = (int)eProperty.StrCapBonus;
                    BlademasterDragonslayerFuarSteel.Bonus7 = 6;
                    BlademasterDragonslayerFuarSteel.Bonus7Type = (int)eProperty.DexCapBonus;
                    BlademasterDragonslayerFuarSteel.SpellID = 32188;
                    BlademasterDragonslayerFuarSteel.Charges = 100;
                    BlademasterDragonslayerFuarSteel.MaxCharges = 100;
                    BlademasterDragonslayerFuarSteel.ProcSpellID = 32177;
                    GameServer.Database.AddObject(BlademasterDragonslayerFuarSteel);
                }

                if (DragonslayerBlademasterBlade == null)
                {
                    DragonslayerBlademasterBlade = new ItemTemplate();
                    DragonslayerBlademasterBlade.Id_nb = "DragonslayerBlademasterBlade";
                    DragonslayerBlademasterBlade.Name = "Dragonslayer Blademaster Blade";
                    DragonslayerBlademasterBlade.Level = 51;
                    DragonslayerBlademasterBlade.Item_Type = 11;
                    DragonslayerBlademasterBlade.Hand = 2;
                    DragonslayerBlademasterBlade.Model = 3894;
                    DragonslayerBlademasterBlade.IsDropable = true;
                    DragonslayerBlademasterBlade.IsPickable = true;
                    DragonslayerBlademasterBlade.Type_Damage = 2;
                    DragonslayerBlademasterBlade.DPS_AF = 165;
                    DragonslayerBlademasterBlade.Price = 3500;
                    DragonslayerBlademasterBlade.SPD_ABS = 42;
                    DragonslayerBlademasterBlade.Object_Type = 19;
                    DragonslayerBlademasterBlade.Quality = 100;
                    DragonslayerBlademasterBlade.IsTradable = false;
                    DragonslayerBlademasterBlade.Weight = 25;
                    DragonslayerBlademasterBlade.Bonus = 35;
                    DragonslayerBlademasterBlade.MaxCondition = 50000;
                    DragonslayerBlademasterBlade.MaxDurability = 50000;
                    DragonslayerBlademasterBlade.Condition = 50000;
                    DragonslayerBlademasterBlade.Durability = 50000;
                    DragonslayerBlademasterBlade.Bonus1 = 4;
                    DragonslayerBlademasterBlade.Bonus1Type = (int)eProperty.Skill_Celtic_Dual;
                    DragonslayerBlademasterBlade.Bonus2 = 12;
                    DragonslayerBlademasterBlade.Bonus2Type = (int)eStat.STR;
                    DragonslayerBlademasterBlade.Bonus3 = 12;
                    DragonslayerBlademasterBlade.Bonus3Type = (int)eStat.QUI;
                    DragonslayerBlademasterBlade.Bonus4 = 4;
                    DragonslayerBlademasterBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerBlademasterBlade.Bonus5 = 4;
                    DragonslayerBlademasterBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerBlademasterBlade.Bonus6 = 8;
                    DragonslayerBlademasterBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerBlademasterBlade.SpellID = 32188;
                    DragonslayerBlademasterBlade.Charges = 100;
                    DragonslayerBlademasterBlade.MaxCharges = 100;
                    DragonslayerBlademasterBlade.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBlademasterBlade);
                }

                if (DragonslayerBlademasterHammer == null)
                {
                    DragonslayerBlademasterHammer = new ItemTemplate();
                    DragonslayerBlademasterHammer.Id_nb = "DragonslayerBlademasterHammer";
                    DragonslayerBlademasterHammer.Name = "Dragonslayer Blademaster Hammer";
                    DragonslayerBlademasterHammer.Level = 51;
                    DragonslayerBlademasterHammer.Item_Type = 11;
                    DragonslayerBlademasterHammer.Hand = 2;
                    DragonslayerBlademasterHammer.Model = 3896;
                    DragonslayerBlademasterHammer.IsDropable = true;
                    DragonslayerBlademasterHammer.IsPickable = true;
                    DragonslayerBlademasterHammer.Type_Damage = 1;
                    DragonslayerBlademasterHammer.DPS_AF = 165;
                    DragonslayerBlademasterHammer.SPD_ABS = 40;
                    DragonslayerBlademasterHammer.Object_Type = 20;
                    DragonslayerBlademasterHammer.Price = 3500;
                    DragonslayerBlademasterHammer.Quality = 100;
                    DragonslayerBlademasterHammer.IsTradable = false;
                    DragonslayerBlademasterHammer.Weight = 25;
                    DragonslayerBlademasterHammer.Bonus = 35;
                    DragonslayerBlademasterHammer.MaxCondition = 50000;
                    DragonslayerBlademasterHammer.MaxDurability = 50000;
                    DragonslayerBlademasterHammer.Condition = 50000;
                    DragonslayerBlademasterHammer.Durability = 50000;
                    DragonslayerBlademasterHammer.Bonus1 = 4;
                    DragonslayerBlademasterHammer.Bonus1Type = (int)eProperty.Skill_Celtic_Dual;
                    DragonslayerBlademasterHammer.Bonus2 = 12;
                    DragonslayerBlademasterHammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerBlademasterHammer.Bonus3 = 12;
                    DragonslayerBlademasterHammer.Bonus3Type = (int)eStat.DEX;
                    DragonslayerBlademasterHammer.Bonus4 = 4;
                    DragonslayerBlademasterHammer.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerBlademasterHammer.Bonus5 = 4;
                    DragonslayerBlademasterHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerBlademasterHammer.Bonus6 = 8;
                    DragonslayerBlademasterHammer.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerBlademasterHammer.SpellID = 32188;
                    DragonslayerBlademasterHammer.Charges = 100;
                    DragonslayerBlademasterHammer.MaxCharges = 100;
                    DragonslayerBlademasterHammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBlademasterHammer);
                }

                if (DragonslayerBlademasterSteel == null)
                {
                    DragonslayerBlademasterSteel = new ItemTemplate();
                    DragonslayerBlademasterSteel.Id_nb = "DragonslayerBlademasterSteel";
                    DragonslayerBlademasterSteel.Name = "Dragonslayer Blademaster Steel";
                    DragonslayerBlademasterSteel.Level = 51;
                    DragonslayerBlademasterSteel.Item_Type = 11;
                    DragonslayerBlademasterSteel.Hand = 2;
                    DragonslayerBlademasterSteel.Model = 3898;
                    DragonslayerBlademasterSteel.IsDropable = true;
                    DragonslayerBlademasterSteel.IsPickable = true;
                    DragonslayerBlademasterSteel.Type_Damage = 3;
                    DragonslayerBlademasterSteel.Price = 3500;
                    DragonslayerBlademasterSteel.DPS_AF = 165;
                    DragonslayerBlademasterSteel.SPD_ABS = 34;
                    DragonslayerBlademasterSteel.Object_Type = 21;
                    DragonslayerBlademasterSteel.Quality = 100;
                    DragonslayerBlademasterSteel.IsTradable = false;
                    DragonslayerBlademasterSteel.Weight = 25;
                    DragonslayerBlademasterSteel.Bonus = 35;
                    DragonslayerBlademasterSteel.MaxCondition = 50000;
                    DragonslayerBlademasterSteel.MaxDurability = 50000;
                    DragonslayerBlademasterSteel.Condition = 50000;
                    DragonslayerBlademasterSteel.Durability = 50000;
                    DragonslayerBlademasterSteel.Bonus1 = 4;
                    DragonslayerBlademasterSteel.Bonus1Type = (int)eProperty.Skill_Celtic_Dual;
                    DragonslayerBlademasterSteel.Bonus2 = 7;
                    DragonslayerBlademasterSteel.Bonus2Type = (int)eStat.STR;
                    DragonslayerBlademasterSteel.Bonus3 = 9;
                    DragonslayerBlademasterSteel.Bonus3Type = (int)eStat.DEX;
                    DragonslayerBlademasterSteel.Bonus4 = 4;
                    DragonslayerBlademasterSteel.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerBlademasterSteel.Bonus5 = 4;
                    DragonslayerBlademasterSteel.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerBlademasterSteel.Bonus6 = 5;
                    DragonslayerBlademasterSteel.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerBlademasterSteel.Bonus7 = 6;
                    DragonslayerBlademasterSteel.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerBlademasterSteel.SpellID = 32188;
                    DragonslayerBlademasterSteel.Charges = 100;
                    DragonslayerBlademasterSteel.MaxCharges = 100;
                    DragonslayerBlademasterSteel.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBlademasterSteel);
                }

                if (DragonslayerChampionBlade == null)
                {
                    DragonslayerChampionBlade = new ItemTemplate();
                    DragonslayerChampionBlade.Id_nb = "DragonslayerChampionBlade";
                    DragonslayerChampionBlade.Name = "Dragonslayer Champion Blade";
                    DragonslayerChampionBlade.Level = 51;
                    DragonslayerChampionBlade.Item_Type = 10;
                    DragonslayerChampionBlade.Model = 3895;
                    DragonslayerChampionBlade.IsDropable = true;
                    DragonslayerChampionBlade.IsPickable = true;
                    DragonslayerChampionBlade.Type_Damage = 2;
                    DragonslayerChampionBlade.DPS_AF = 165;
                    DragonslayerChampionBlade.Price = 3500;
                    DragonslayerChampionBlade.SPD_ABS = 42;
                    DragonslayerChampionBlade.Object_Type = 19;
                    DragonslayerChampionBlade.Quality = 100;
                    DragonslayerChampionBlade.IsTradable = false;
                    DragonslayerChampionBlade.Weight = 25;
                    DragonslayerChampionBlade.Bonus = 35;
                    DragonslayerChampionBlade.MaxCondition = 50000;
                    DragonslayerChampionBlade.MaxDurability = 50000;
                    DragonslayerChampionBlade.Condition = 50000;
                    DragonslayerChampionBlade.Durability = 50000;
                    DragonslayerChampionBlade.Bonus1 = 4;
                    DragonslayerChampionBlade.Bonus1Type = (int)eProperty.Skill_Blades;
                    DragonslayerChampionBlade.Bonus2 = 7;
                    DragonslayerChampionBlade.Bonus2Type = (int)eStat.DEX;
                    DragonslayerChampionBlade.Bonus3 = 3;
                    DragonslayerChampionBlade.Bonus3Type = (int)eProperty.MeleeSpeed;
                    DragonslayerChampionBlade.Bonus4 = 3;
                    DragonslayerChampionBlade.Bonus4Type = (int)eProperty.SpellDamage;
                    DragonslayerChampionBlade.Bonus5 = 3;
                    DragonslayerChampionBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerChampionBlade.Bonus6 = 4;
                    DragonslayerChampionBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerChampionBlade.Bonus7 = 4;
                    DragonslayerChampionBlade.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerChampionBlade.Bonus8 = 5;
                    DragonslayerChampionBlade.Bonus8Type = (int)eProperty.DebuffEffectivness;
                    DragonslayerChampionBlade.SpellID = 32179;
                    DragonslayerChampionBlade.Charges = 100;
                    DragonslayerChampionBlade.MaxCharges = 100;
                    DragonslayerChampionBlade.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerChampionBlade);
                }

                if (DragonslayerChampionHammer == null)
                {
                    DragonslayerChampionHammer = new ItemTemplate();
                    DragonslayerChampionHammer.Id_nb = "DragonslayerChampionHammer";
                    DragonslayerChampionHammer.Name = "Dragonslayer Champion Hammer";
                    DragonslayerChampionHammer.Level = 51;
                    DragonslayerChampionHammer.Item_Type = 10;
                    DragonslayerChampionHammer.Model = 3897;
                    DragonslayerChampionHammer.Price = 3500;
                    DragonslayerChampionHammer.IsDropable = true;
                    DragonslayerChampionHammer.IsPickable = true;
                    DragonslayerChampionHammer.Type_Damage = 1;
                    DragonslayerChampionHammer.DPS_AF = 165;
                    DragonslayerChampionHammer.SPD_ABS = 42;
                    DragonslayerChampionHammer.Object_Type = 20;
                    DragonslayerChampionHammer.Quality = 100;
                    DragonslayerChampionHammer.IsTradable = false;
                    DragonslayerChampionHammer.Weight = 25;
                    DragonslayerChampionHammer.Bonus = 35;
                    DragonslayerChampionHammer.MaxCondition = 50000;
                    DragonslayerChampionHammer.MaxDurability = 50000;
                    DragonslayerChampionHammer.Condition = 50000;
                    DragonslayerChampionHammer.Durability = 50000;
                    DragonslayerChampionHammer.Bonus1 = 4;
                    DragonslayerChampionHammer.Bonus1Type = (int)eProperty.Skill_Blunt;
                    DragonslayerChampionHammer.Bonus2 = 7;
                    DragonslayerChampionHammer.Bonus2Type = (int)eStat.DEX;
                    DragonslayerChampionHammer.Bonus3 = 3;
                    DragonslayerChampionHammer.Bonus3Type = (int)eProperty.MeleeSpeed;
                    DragonslayerChampionHammer.Bonus4 = 3;
                    DragonslayerChampionHammer.Bonus4Type = (int)eProperty.SpellDamage;
                    DragonslayerChampionHammer.Bonus5 = 3;
                    DragonslayerChampionHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerChampionHammer.Bonus6 = 4;
                    DragonslayerChampionHammer.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerChampionHammer.Bonus7 = 4;
                    DragonslayerChampionHammer.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerChampionHammer.Bonus8 = 5;
                    DragonslayerChampionHammer.Bonus8Type = (int)eProperty.DebuffEffectivness;
                    DragonslayerChampionHammer.SpellID = 32179;
                    DragonslayerChampionHammer.Charges = 100;
                    DragonslayerChampionHammer.MaxCharges = 100;
                    DragonslayerChampionHammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerChampionHammer);
                }

                if (DragonslayerChampionSteel == null)
                {
                    DragonslayerChampionSteel = new ItemTemplate();
                    DragonslayerChampionSteel.Id_nb = "DragonslayerChampionSteel";
                    DragonslayerChampionSteel.Name = "Dragonslayer Champion Steel";
                    DragonslayerChampionSteel.Level = 51;
                    DragonslayerChampionSteel.Item_Type = 10;
                    DragonslayerChampionSteel.Model = 3899;
                    DragonslayerChampionSteel.IsDropable = true;
                    DragonslayerChampionSteel.IsPickable = true;
                    DragonslayerChampionSteel.Type_Damage = 3;
                    DragonslayerChampionSteel.DPS_AF = 165;
                    DragonslayerChampionSteel.Price = 3500;
                    DragonslayerChampionSteel.SPD_ABS = 42;
                    DragonslayerChampionSteel.Object_Type = 21;
                    DragonslayerChampionSteel.Quality = 100;
                    DragonslayerChampionSteel.IsTradable = false;
                    DragonslayerChampionSteel.Weight = 25;
                    DragonslayerChampionSteel.Bonus = 35;
                    DragonslayerChampionSteel.MaxCondition = 50000;
                    DragonslayerChampionSteel.MaxDurability = 50000;
                    DragonslayerChampionSteel.Condition = 50000;
                    DragonslayerChampionSteel.Durability = 50000;
                    DragonslayerChampionSteel.Bonus1 = 4;
                    DragonslayerChampionSteel.Bonus1Type = (int)eProperty.Skill_Piercing;
                    DragonslayerChampionSteel.Bonus2 = 7;
                    DragonslayerChampionSteel.Bonus2Type = (int)eStat.DEX;
                    DragonslayerChampionSteel.Bonus3 = 3;
                    DragonslayerChampionSteel.Bonus3Type = (int)eProperty.MeleeSpeed;
                    DragonslayerChampionSteel.Bonus4 = 3;
                    DragonslayerChampionSteel.Bonus4Type = (int)eProperty.SpellDamage;
                    DragonslayerChampionSteel.Bonus5 = 3;
                    DragonslayerChampionSteel.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerChampionSteel.Bonus6 = 4;
                    DragonslayerChampionSteel.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerChampionSteel.Bonus7 = 4;
                    DragonslayerChampionSteel.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerChampionSteel.Bonus8 = 5;
                    DragonslayerChampionSteel.Bonus8Type = (int)eProperty.DebuffEffectivness;
                    DragonslayerChampionSteel.SpellID = 32179;
                    DragonslayerChampionSteel.Charges = 100;
                    DragonslayerChampionSteel.MaxCharges = 100;
                    DragonslayerChampionSteel.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerChampionSteel);
                }

                if (DragonslayerChampionWarblade == null)
                {
                    DragonslayerChampionWarblade = new ItemTemplate();
                    DragonslayerChampionWarblade.Id_nb = "DragonslayerChampionWarblade";
                    DragonslayerChampionWarblade.Name = "Dragonslayer Champion Warblade";
                    DragonslayerChampionWarblade.Level = 51;
                    DragonslayerChampionWarblade.Item_Type = 12;
                    DragonslayerChampionWarblade.Hand = 1;
                    DragonslayerChampionWarblade.Model = 3878;
                    DragonslayerChampionWarblade.IsDropable = true;
                    DragonslayerChampionWarblade.IsPickable = true;
                    DragonslayerChampionWarblade.Type_Damage = 2;
                    DragonslayerChampionWarblade.DPS_AF = 165;
                    DragonslayerChampionWarblade.SPD_ABS = 56;
                    DragonslayerChampionWarblade.Object_Type = 22;
                    DragonslayerChampionWarblade.Quality = 100;
                    DragonslayerChampionWarblade.IsTradable = false;
                    DragonslayerChampionWarblade.Weight = 25;
                    DragonslayerChampionWarblade.Price = 3500;
                    DragonslayerChampionWarblade.Bonus = 35;
                    DragonslayerChampionWarblade.MaxCondition = 50000;
                    DragonslayerChampionWarblade.MaxDurability = 50000;
                    DragonslayerChampionWarblade.Condition = 50000;
                    DragonslayerChampionWarblade.Durability = 50000;
                    DragonslayerChampionWarblade.Bonus1 = 4;
                    DragonslayerChampionWarblade.Bonus1Type = (int)eProperty.Skill_Large_Weapon;
                    DragonslayerChampionWarblade.Bonus2 = 7;
                    DragonslayerChampionWarblade.Bonus2Type = (int)eStat.STR;
                    DragonslayerChampionWarblade.Bonus3 = 7;
                    DragonslayerChampionWarblade.Bonus3Type = (int)eStat.QUI;
                    DragonslayerChampionWarblade.Bonus4 = 3;
                    DragonslayerChampionWarblade.Bonus4Type = (int)eProperty.MeleeSpeed;
                    DragonslayerChampionWarblade.Bonus5 = 3;
                    DragonslayerChampionWarblade.Bonus5Type = (int)eProperty.MeleeDamage;
                    DragonslayerChampionWarblade.Bonus6 = 3;
                    DragonslayerChampionWarblade.Bonus6Type = (int)eProperty.StyleDamage;
                    DragonslayerChampionWarblade.Bonus7 = 5;
                    DragonslayerChampionWarblade.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerChampionWarblade.Bonus8 = 5;
                    DragonslayerChampionWarblade.Bonus8Type = (int)eProperty.DebuffEffectivness;
                    DragonslayerChampionWarblade.SpellID = 32179;
                    DragonslayerChampionWarblade.Charges = 100;
                    DragonslayerChampionWarblade.MaxCharges = 100;
                    DragonslayerChampionWarblade.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerChampionWarblade);
                }

                if (DragonslayerChampionWarhammer == null)
                {
                    DragonslayerChampionWarhammer = new ItemTemplate();
                    DragonslayerChampionWarhammer.Id_nb = "DragonslayerChampionWarhammer";
                    DragonslayerChampionWarhammer.Name = "Dragonslayer Champion Warhammer";
                    DragonslayerChampionWarhammer.Level = 51;
                    DragonslayerChampionWarhammer.Item_Type = 12;
                    DragonslayerChampionWarhammer.Hand = 1;
                    DragonslayerChampionWarhammer.Model = 3881;
                    DragonslayerChampionWarhammer.IsDropable = true;
                    DragonslayerChampionWarhammer.IsPickable = true;
                    DragonslayerChampionWarhammer.Type_Damage = 1;
                    DragonslayerChampionWarhammer.DPS_AF = 165;
                    DragonslayerChampionWarhammer.SPD_ABS = 56;
                    DragonslayerChampionWarhammer.Object_Type = 22;
                    DragonslayerChampionWarhammer.Quality = 100;
                    DragonslayerChampionWarhammer.IsTradable = false;
                    DragonslayerChampionWarhammer.Weight = 25;
                    DragonslayerChampionWarhammer.Price = 3500;
                    DragonslayerChampionWarhammer.Bonus = 35;
                    DragonslayerChampionWarhammer.MaxCondition = 50000;
                    DragonslayerChampionWarhammer.MaxDurability = 50000;
                    DragonslayerChampionWarhammer.Condition = 50000;
                    DragonslayerChampionWarhammer.Durability = 50000;
                    DragonslayerChampionWarhammer.Bonus1 = 4;
                    DragonslayerChampionWarhammer.Bonus1Type = (int)eProperty.Skill_Large_Weapon;
                    DragonslayerChampionWarhammer.Bonus2 = 7;
                    DragonslayerChampionWarhammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerChampionWarhammer.Bonus3 = 7;
                    DragonslayerChampionWarhammer.Bonus3Type = (int)eStat.QUI;
                    DragonslayerChampionWarhammer.Bonus4 = 3;
                    DragonslayerChampionWarhammer.Bonus4Type = (int)eProperty.MeleeSpeed;
                    DragonslayerChampionWarhammer.Bonus5 = 3;
                    DragonslayerChampionWarhammer.Bonus5Type = (int)eProperty.MeleeDamage;
                    DragonslayerChampionWarhammer.Bonus6 = 3;
                    DragonslayerChampionWarhammer.Bonus6Type = (int)eProperty.StyleDamage;
                    DragonslayerChampionWarhammer.Bonus7 = 5;
                    DragonslayerChampionWarhammer.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerChampionWarhammer.Bonus8 = 5;
                    DragonslayerChampionWarhammer.Bonus8Type = (int)eProperty.DebuffEffectivness;
                    DragonslayerChampionWarhammer.SpellID = 32179;
                    DragonslayerChampionWarhammer.Charges = 100;
                    DragonslayerChampionWarhammer.MaxCharges = 100;
                    DragonslayerChampionWarhammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerChampionWarhammer);
                }

                if (DragonslayerHeroBlade == null)
                {
                    DragonslayerHeroBlade = new ItemTemplate();
                    DragonslayerHeroBlade.Id_nb = "DragonslayerHeroBlade";
                    DragonslayerHeroBlade.Name = "Dragonslayer Hero Blade";
                    DragonslayerHeroBlade.Level = 51;
                    DragonslayerHeroBlade.Item_Type = 10;
                    DragonslayerHeroBlade.Model = 3895;
                    DragonslayerHeroBlade.IsDropable = true;
                    DragonslayerHeroBlade.IsPickable = true;
                    DragonslayerHeroBlade.Type_Damage = 2;
                    DragonslayerHeroBlade.DPS_AF = 165;
                    DragonslayerHeroBlade.SPD_ABS = 42;
                    DragonslayerHeroBlade.Object_Type = 19;
                    DragonslayerHeroBlade.Price = 3500;
                    DragonslayerHeroBlade.Quality = 100;
                    DragonslayerHeroBlade.IsTradable = false;
                    DragonslayerHeroBlade.Weight = 25;
                    DragonslayerHeroBlade.Bonus = 35;
                    DragonslayerHeroBlade.MaxCondition = 50000;
                    DragonslayerHeroBlade.MaxDurability = 50000;
                    DragonslayerHeroBlade.Condition = 50000;
                    DragonslayerHeroBlade.Durability = 50000;
                    DragonslayerHeroBlade.Bonus1 = 4;
                    DragonslayerHeroBlade.Bonus1Type = (int)eProperty.Skill_Blades;
                    DragonslayerHeroBlade.Bonus2 = 7;
                    DragonslayerHeroBlade.Bonus2Type = (int)eStat.STR;
                    DragonslayerHeroBlade.Bonus3 = 7;
                    DragonslayerHeroBlade.Bonus3Type = (int)eStat.DEX;
                    DragonslayerHeroBlade.Bonus4 = 3;
                    DragonslayerHeroBlade.Bonus4Type = (int)eProperty.MeleeSpeed;
                    DragonslayerHeroBlade.Bonus5 = 3;
                    DragonslayerHeroBlade.Bonus5Type = (int)eProperty.MeleeDamage;
                    DragonslayerHeroBlade.Bonus6 = 3;
                    DragonslayerHeroBlade.Bonus6Type = (int)eProperty.StyleDamage;
                    DragonslayerHeroBlade.Bonus7 = 5;
                    DragonslayerHeroBlade.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerHeroBlade.Bonus8 = 5;
                    DragonslayerHeroBlade.Bonus8Type = (int)eProperty.DexCapBonus;
                    DragonslayerHeroBlade.SpellID = 32176;
                    DragonslayerHeroBlade.Charges = 100;
                    DragonslayerHeroBlade.MaxCharges = 100;
                    DragonslayerHeroBlade.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerHeroBlade);
                }

                if (DragonslayerHeroHammer == null)
                {
                    DragonslayerHeroHammer = new ItemTemplate();
                    DragonslayerHeroHammer.Id_nb = "DragonslayerHeroHammer";
                    DragonslayerHeroHammer.Name = "Dragonslayer Hero Hammer";
                    DragonslayerHeroHammer.Level = 51;
                    DragonslayerHeroHammer.Item_Type = 10;
                    DragonslayerHeroHammer.Model = 3897;
                    DragonslayerHeroHammer.IsDropable = true;
                    DragonslayerHeroHammer.IsPickable = true;
                    DragonslayerHeroHammer.Type_Damage = 1;
                    DragonslayerHeroHammer.DPS_AF = 165;
                    DragonslayerHeroHammer.Price = 3500;
                    DragonslayerHeroHammer.SPD_ABS = 42;
                    DragonslayerHeroHammer.Object_Type = 20;
                    DragonslayerHeroHammer.Quality = 100;
                    DragonslayerHeroHammer.IsTradable = false;
                    DragonslayerHeroHammer.Weight = 25;
                    DragonslayerHeroHammer.Bonus = 35;
                    DragonslayerHeroHammer.MaxCondition = 50000;
                    DragonslayerHeroHammer.MaxDurability = 50000;
                    DragonslayerHeroHammer.Condition = 50000;
                    DragonslayerHeroHammer.Durability = 50000;
                    DragonslayerHeroHammer.Bonus1 = 4;
                    DragonslayerHeroHammer.Bonus1Type = (int)eProperty.Skill_Blunt;
                    DragonslayerHeroHammer.Bonus2 = 7;
                    DragonslayerHeroHammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerHeroHammer.Bonus3 = 7;
                    DragonslayerHeroHammer.Bonus3Type = (int)eStat.DEX;
                    DragonslayerHeroHammer.Bonus4 = 3;
                    DragonslayerHeroHammer.Bonus4Type = (int)eProperty.MeleeSpeed;
                    DragonslayerHeroHammer.Bonus5 = 3;
                    DragonslayerHeroHammer.Bonus5Type = (int)eProperty.MeleeDamage;
                    DragonslayerHeroHammer.Bonus6 = 3;
                    DragonslayerHeroHammer.Bonus6Type = (int)eProperty.StyleDamage;
                    DragonslayerHeroHammer.Bonus7 = 5;
                    DragonslayerHeroHammer.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerHeroHammer.Bonus8 = 5;
                    DragonslayerHeroHammer.Bonus8Type = (int)eProperty.DexCapBonus;
                    DragonslayerHeroHammer.SpellID = 32176;
                    DragonslayerHeroHammer.Charges = 100;
                    DragonslayerHeroHammer.MaxCharges = 100;
                    DragonslayerHeroHammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerHeroHammer);
                }

                if (DragonslayerHeroSpear == null)
                {
                    DragonslayerHeroSpear = new ItemTemplate();
                    DragonslayerHeroSpear.Id_nb = "DragonslayerHeroSpear";
                    DragonslayerHeroSpear.Name = "Dragonslayer Hero Spear";
                    DragonslayerHeroSpear.Level = 51;
                    DragonslayerHeroSpear.Item_Type = 12;
                    DragonslayerHeroSpear.Hand = 1;
                    DragonslayerHeroSpear.Model = 3880;
                    DragonslayerHeroSpear.IsDropable = true;
                    DragonslayerHeroSpear.IsPickable = true;
                    DragonslayerHeroSpear.Type_Damage = 3;
                    DragonslayerHeroSpear.DPS_AF = 165;
                    DragonslayerHeroSpear.SPD_ABS = 56;
                    DragonslayerHeroSpear.Price = 3500;
                    DragonslayerHeroSpear.Object_Type = 23;
                    DragonslayerHeroSpear.Quality = 100;
                    DragonslayerHeroSpear.IsTradable = false;
                    DragonslayerHeroSpear.Weight = 25;
                    DragonslayerHeroSpear.Bonus = 35;
                    DragonslayerHeroSpear.MaxCondition = 50000;
                    DragonslayerHeroSpear.MaxDurability = 50000;
                    DragonslayerHeroSpear.Condition = 50000;
                    DragonslayerHeroSpear.Durability = 50000;
                    DragonslayerHeroSpear.Bonus1 = 4;
                    DragonslayerHeroSpear.Bonus1Type = (int)eProperty.Skill_Large_Weapon;
                    DragonslayerHeroSpear.Bonus2 = 12;
                    DragonslayerHeroSpear.Bonus2Type = (int)eStat.STR;
                    DragonslayerHeroSpear.Bonus3 = 12;
                    DragonslayerHeroSpear.Bonus3Type = (int)eStat.DEX;
                    DragonslayerHeroSpear.Bonus4 = 9;
                    DragonslayerHeroSpear.Bonus4Type = (int)eStat.QUI;
                    DragonslayerHeroSpear.Bonus5 = 3;
                    DragonslayerHeroSpear.Bonus5Type = (int)eProperty.MeleeSpeed;
                    DragonslayerHeroSpear.Bonus6 = 3;
                    DragonslayerHeroSpear.Bonus6Type = (int)eProperty.MeleeDamage;
                    DragonslayerHeroSpear.Bonus7 = 3;
                    DragonslayerHeroSpear.Bonus7Type = (int)eProperty.StyleDamage;
                    DragonslayerHeroSpear.Bonus8 = 7;
                    DragonslayerHeroSpear.Bonus8Type = (int)eProperty.StrCapBonus;
                    DragonslayerHeroSpear.SpellID = 32176;
                    DragonslayerHeroSpear.Charges = 100;
                    DragonslayerHeroSpear.MaxCharges = 100;
                    DragonslayerHeroSpear.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerHeroSpear);
                }

                if (DragonslayerHeroSteel == null)
                {
                    DragonslayerHeroSteel = new ItemTemplate();
                    DragonslayerHeroSteel.Id_nb = "DragonslayerHeroSteel";
                    DragonslayerHeroSteel.Name = "Dragonslayer Hero Steel";
                    DragonslayerHeroSteel.Level = 51;
                    DragonslayerHeroSteel.Item_Type = 10;
                    DragonslayerHeroSteel.Model = 3899;
                    DragonslayerHeroSteel.IsDropable = true;
                    DragonslayerHeroSteel.IsPickable = true;
                    DragonslayerHeroSteel.Type_Damage = 3;
                    DragonslayerHeroSteel.DPS_AF = 165;
                    DragonslayerHeroSteel.SPD_ABS = 42;
                    DragonslayerHeroSteel.Object_Type = 21;
                    DragonslayerHeroSteel.Quality = 100;
                    DragonslayerHeroSteel.Price = 3500;
                    DragonslayerHeroSteel.IsTradable = false;
                    DragonslayerHeroSteel.Weight = 25;
                    DragonslayerHeroSteel.Bonus = 35;
                    DragonslayerHeroSteel.MaxCondition = 50000;
                    DragonslayerHeroSteel.MaxDurability = 50000;
                    DragonslayerHeroSteel.Condition = 50000;
                    DragonslayerHeroSteel.Durability = 50000;
                    DragonslayerHeroSteel.Bonus1 = 4;
                    DragonslayerHeroSteel.Bonus1Type = (int)eProperty.Skill_Piercing;
                    DragonslayerHeroSteel.Bonus2 = 7;
                    DragonslayerHeroSteel.Bonus2Type = (int)eStat.STR;
                    DragonslayerHeroSteel.Bonus3 = 7;
                    DragonslayerHeroSteel.Bonus3Type = (int)eStat.DEX;
                    DragonslayerHeroSteel.Bonus4 = 3;
                    DragonslayerHeroSteel.Bonus4Type = (int)eProperty.MeleeSpeed;
                    DragonslayerHeroSteel.Bonus5 = 3;
                    DragonslayerHeroSteel.Bonus5Type = (int)eProperty.MeleeDamage;
                    DragonslayerHeroSteel.Bonus6 = 3;
                    DragonslayerHeroSteel.Bonus6Type = (int)eProperty.StyleDamage;
                    DragonslayerHeroSteel.Bonus7 = 5;
                    DragonslayerHeroSteel.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerHeroSteel.Bonus8 = 5;
                    DragonslayerHeroSteel.Bonus8Type = (int)eProperty.DexCapBonus;
                    DragonslayerHeroSteel.SpellID = 32176;
                    DragonslayerHeroSteel.Charges = 100;
                    DragonslayerHeroSteel.MaxCharges = 100;
                    DragonslayerHeroSteel.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerHeroSteel);
                }

                if (DragonslayerHeroWarblade == null)
                {
                    DragonslayerHeroWarblade = new ItemTemplate();
                    DragonslayerHeroWarblade.Id_nb = "DragonslayerHeroWarblade";
                    DragonslayerHeroWarblade.Name = "Dragonslayer Hero Warblade";
                    DragonslayerHeroWarblade.Level = 51;
                    DragonslayerHeroWarblade.Item_Type = 12;
                    DragonslayerHeroWarblade.Hand = 1;
                    DragonslayerHeroWarblade.Model = 3878;
                    DragonslayerHeroWarblade.IsDropable = true;
                    DragonslayerHeroWarblade.IsPickable = true;
                    DragonslayerHeroWarblade.Type_Damage = 2;
                    DragonslayerHeroWarblade.DPS_AF = 165;
                    DragonslayerHeroWarblade.SPD_ABS = 56;
                    DragonslayerHeroWarblade.Object_Type = 22;
                    DragonslayerHeroWarblade.Quality = 100;
                    DragonslayerHeroWarblade.Price = 3500;
                    DragonslayerHeroWarblade.IsTradable = false;
                    DragonslayerHeroWarblade.Weight = 25;
                    DragonslayerHeroWarblade.Bonus = 35;
                    DragonslayerHeroWarblade.MaxCondition = 50000;
                    DragonslayerHeroWarblade.MaxDurability = 50000;
                    DragonslayerHeroWarblade.Condition = 50000;
                    DragonslayerHeroWarblade.Durability = 50000;
                    DragonslayerHeroWarblade.Bonus1 = 4;
                    DragonslayerHeroWarblade.Bonus1Type = (int)eProperty.Skill_Large_Weapon;
                    DragonslayerHeroWarblade.Bonus2 = 9;
                    DragonslayerHeroWarblade.Bonus2Type = (int)eStat.STR;
                    DragonslayerHeroWarblade.Bonus3 = 9;
                    DragonslayerHeroWarblade.Bonus3Type = (int)eStat.DEX;
                    DragonslayerHeroWarblade.Bonus4 = 9;
                    DragonslayerHeroWarblade.Bonus4Type = (int)eStat.QUI;
                    DragonslayerHeroWarblade.Bonus5 = 3;
                    DragonslayerHeroWarblade.Bonus5Type = (int)eProperty.MeleeSpeed;
                    DragonslayerHeroWarblade.Bonus6 = 3;
                    DragonslayerHeroWarblade.Bonus6Type = (int)eProperty.MeleeDamage;
                    DragonslayerHeroWarblade.Bonus7 = 3;
                    DragonslayerHeroWarblade.Bonus7Type = (int)eProperty.StyleDamage;
                    DragonslayerHeroWarblade.Bonus8 = 6;
                    DragonslayerHeroWarblade.Bonus8Type = (int)eProperty.StrCapBonus;
                    DragonslayerHeroWarblade.SpellID = 32176;
                    DragonslayerHeroWarblade.Charges = 100;
                    DragonslayerHeroWarblade.MaxCharges = 100;
                    DragonslayerHeroWarblade.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerHeroWarblade);
                }

                if (DragonslayerHeroWarhammer == null)
                {
                    DragonslayerHeroWarhammer = new ItemTemplate();
                    DragonslayerHeroWarhammer.Id_nb = "DragonslayerHeroWarhammer";
                    DragonslayerHeroWarhammer.Name = "Dragonslayer Hero Warhammer";
                    DragonslayerHeroWarhammer.Level = 51;
                    DragonslayerHeroWarhammer.Item_Type = 12;
                    DragonslayerHeroWarhammer.Hand = 1;
                    DragonslayerHeroWarhammer.Model = 3881;
                    DragonslayerHeroWarhammer.IsDropable = true;
                    DragonslayerHeroWarhammer.IsPickable = true;
                    DragonslayerHeroWarhammer.Type_Damage = 1;
                    DragonslayerHeroWarhammer.DPS_AF = 165;
                    DragonslayerHeroWarhammer.SPD_ABS = 56;
                    DragonslayerHeroWarhammer.Object_Type = 22;
                    DragonslayerHeroWarhammer.Quality = 100;
                    DragonslayerHeroWarhammer.Price = 3500;
                    DragonslayerHeroWarhammer.IsTradable = false;
                    DragonslayerHeroWarhammer.Weight = 25;
                    DragonslayerHeroWarhammer.Bonus = 35;
                    DragonslayerHeroWarhammer.MaxCondition = 50000;
                    DragonslayerHeroWarhammer.MaxDurability = 50000;
                    DragonslayerHeroWarhammer.Condition = 50000;
                    DragonslayerHeroWarhammer.Durability = 50000;
                    DragonslayerHeroWarhammer.Bonus1 = 4;
                    DragonslayerHeroWarhammer.Bonus1Type = (int)eProperty.Skill_Large_Weapon;
                    DragonslayerHeroWarhammer.Bonus2 = 9;
                    DragonslayerHeroWarhammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerHeroWarhammer.Bonus3 = 9;
                    DragonslayerHeroWarhammer.Bonus3Type = (int)eStat.DEX;
                    DragonslayerHeroWarhammer.Bonus4 = 9;
                    DragonslayerHeroWarhammer.Bonus4Type = (int)eStat.QUI;
                    DragonslayerHeroWarhammer.Bonus5 = 3;
                    DragonslayerHeroWarhammer.Bonus5Type = (int)eProperty.MeleeSpeed;
                    DragonslayerHeroWarhammer.Bonus6 = 3;
                    DragonslayerHeroWarhammer.Bonus6Type = (int)eProperty.MeleeDamage;
                    DragonslayerHeroWarhammer.Bonus7 = 3;
                    DragonslayerHeroWarhammer.Bonus7Type = (int)eProperty.StyleDamage;
                    DragonslayerHeroWarhammer.Bonus8 = 6;
                    DragonslayerHeroWarhammer.Bonus8Type = (int)eProperty.StrCapBonus;
                    DragonslayerHeroWarhammer.SpellID = 32176;
                    DragonslayerHeroWarhammer.Charges = 100;
                    DragonslayerHeroWarhammer.MaxCharges = 100;
                    DragonslayerHeroWarhammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerHeroWarhammer);
                }

                if (DragonslayerNightshadeBlade == null)
                {
                    DragonslayerNightshadeBlade = new ItemTemplate();
                    DragonslayerNightshadeBlade.Id_nb = "DragonslayerNightshadeBlade";
                    DragonslayerNightshadeBlade.Name = "Dragonslayer Nightshade Blade";
                    DragonslayerNightshadeBlade.Level = 51;
                    DragonslayerNightshadeBlade.Item_Type = 11;
                    DragonslayerNightshadeBlade.Hand = 2;
                    DragonslayerNightshadeBlade.Model = 3894;
                    DragonslayerNightshadeBlade.IsDropable = true;
                    DragonslayerNightshadeBlade.IsPickable = true;
                    DragonslayerNightshadeBlade.Type_Damage = 2;
                    DragonslayerNightshadeBlade.DPS_AF = 165;
                    DragonslayerNightshadeBlade.SPD_ABS = 40;
                    DragonslayerNightshadeBlade.Price = 3500;
                    DragonslayerNightshadeBlade.Object_Type = 19;
                    DragonslayerNightshadeBlade.Quality = 100;
                    DragonslayerNightshadeBlade.IsTradable = false;
                    DragonslayerNightshadeBlade.Weight = 25;
                    DragonslayerNightshadeBlade.Bonus = 35;
                    DragonslayerNightshadeBlade.MaxCondition = 50000;
                    DragonslayerNightshadeBlade.MaxDurability = 50000;
                    DragonslayerNightshadeBlade.Condition = 50000;
                    DragonslayerNightshadeBlade.Durability = 50000;
                    DragonslayerNightshadeBlade.Bonus1 = 4;
                    DragonslayerNightshadeBlade.Bonus1Type = (int)eProperty.Skill_Celtic_Dual;
                    DragonslayerNightshadeBlade.Bonus2 = 12;
                    DragonslayerNightshadeBlade.Bonus2Type = (int)eStat.QUI;
                    DragonslayerNightshadeBlade.Bonus3 = 12;
                    DragonslayerNightshadeBlade.Bonus3Type = (int)eStat.STR;
                    DragonslayerNightshadeBlade.Bonus4 = 4;
                    DragonslayerNightshadeBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerNightshadeBlade.Bonus5 = 4;
                    DragonslayerNightshadeBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerNightshadeBlade.Bonus6 = 8;
                    DragonslayerNightshadeBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerNightshadeBlade.ProcSpellID = 32183;
                    DragonslayerNightshadeBlade.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(DragonslayerNightshadeBlade);
                }

                if (DragonslayerNightshadeSteel == null)
                {
                    DragonslayerNightshadeSteel = new ItemTemplate();
                    DragonslayerNightshadeSteel.Id_nb = "DragonslayerNightshadeSteel";
                    DragonslayerNightshadeSteel.Name = "Dragonslayer Nightshade Steel";
                    DragonslayerNightshadeSteel.Level = 51;
                    DragonslayerNightshadeSteel.Item_Type = 11;
                    DragonslayerNightshadeSteel.Hand = 2;
                    DragonslayerNightshadeSteel.Model = 3898;
                    DragonslayerNightshadeSteel.IsDropable = true;
                    DragonslayerNightshadeSteel.IsPickable = true;
                    DragonslayerNightshadeSteel.Type_Damage = 3;
                    DragonslayerNightshadeSteel.DPS_AF = 165;
                    DragonslayerNightshadeSteel.SPD_ABS = 34;
                    DragonslayerNightshadeSteel.Object_Type = 21;
                    DragonslayerNightshadeSteel.Quality = 100;
                    DragonslayerNightshadeSteel.Price = 3500;
                    DragonslayerNightshadeSteel.IsTradable = false;
                    DragonslayerNightshadeSteel.Weight = 25;
                    DragonslayerNightshadeSteel.Bonus = 35;
                    DragonslayerNightshadeSteel.MaxCondition = 50000;
                    DragonslayerNightshadeSteel.MaxDurability = 50000;
                    DragonslayerNightshadeSteel.Condition = 50000;
                    DragonslayerNightshadeSteel.Durability = 50000;
                    DragonslayerNightshadeSteel.Bonus1 = 4;
                    DragonslayerNightshadeSteel.Bonus1Type = (int)eProperty.Skill_Celtic_Dual;
                    DragonslayerNightshadeSteel.Bonus2 = 9;
                    DragonslayerNightshadeSteel.Bonus2Type = (int)eStat.DEX;
                    DragonslayerNightshadeSteel.Bonus3 = 7;
                    DragonslayerNightshadeSteel.Bonus3Type = (int)eStat.STR;
                    DragonslayerNightshadeSteel.Bonus4 = 4;
                    DragonslayerNightshadeSteel.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerNightshadeSteel.Bonus5 = 4;
                    DragonslayerNightshadeSteel.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerNightshadeSteel.Bonus6 = 5;
                    DragonslayerNightshadeSteel.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerNightshadeSteel.Bonus7 = 6;
                    DragonslayerNightshadeSteel.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerNightshadeSteel.ProcSpellID = 32183;
                    DragonslayerNightshadeSteel.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(DragonslayerNightshadeSteel);
                }

                if (DragonslayerRangerBlade == null)
                {
                    DragonslayerRangerBlade = new ItemTemplate();
                    DragonslayerRangerBlade.Id_nb = "DragonslayerRangerBlade";
                    DragonslayerRangerBlade.Name = "Dragonslayer Ranger Blade";
                    DragonslayerRangerBlade.Level = 51;
                    DragonslayerRangerBlade.Item_Type = 11;
                    DragonslayerRangerBlade.Hand = 2;
                    DragonslayerRangerBlade.Model = 3894;
                    DragonslayerRangerBlade.IsDropable = true;
                    DragonslayerRangerBlade.IsPickable = true;
                    DragonslayerRangerBlade.Type_Damage = 2;
                    DragonslayerRangerBlade.DPS_AF = 165;
                    DragonslayerRangerBlade.SPD_ABS = 40;
                    DragonslayerRangerBlade.Object_Type = 19;
                    DragonslayerRangerBlade.Quality = 100;
                    DragonslayerRangerBlade.IsTradable = false;
                    DragonslayerRangerBlade.Weight = 25;
                    DragonslayerRangerBlade.Price = 3500;
                    DragonslayerRangerBlade.Bonus = 35;
                    DragonslayerRangerBlade.MaxCondition = 50000;
                    DragonslayerRangerBlade.MaxDurability = 50000;
                    DragonslayerRangerBlade.Condition = 50000;
                    DragonslayerRangerBlade.Durability = 50000;
                    DragonslayerRangerBlade.Bonus1 = 4;
                    DragonslayerRangerBlade.Bonus1Type = (int)eProperty.Skill_Celtic_Dual;
                    DragonslayerRangerBlade.Bonus2 = 12;
                    DragonslayerRangerBlade.Bonus2Type = (int)eStat.STR;
                    DragonslayerRangerBlade.Bonus3 = 12;
                    DragonslayerRangerBlade.Bonus3Type = (int)eStat.QUI;
                    DragonslayerRangerBlade.Bonus4 = 4;
                    DragonslayerRangerBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerRangerBlade.Bonus5 = 4;
                    DragonslayerRangerBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerRangerBlade.Bonus6 = 8;
                    DragonslayerRangerBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerRangerBlade.SpellID = 32178;
                    DragonslayerRangerBlade.Charges = 100;
                    DragonslayerRangerBlade.MaxCharges = 100;
                    DragonslayerRangerBlade.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerRangerBlade);
                }

                if (DragonslayerRangerSteel == null)
                {
                    DragonslayerRangerSteel = new ItemTemplate();
                    DragonslayerRangerSteel.Id_nb = "DragonslayerRangerSteel";
                    DragonslayerRangerSteel.Name = "Dragonslayer Ranger Steel";
                    DragonslayerRangerSteel.Level = 51;
                    DragonslayerRangerSteel.Item_Type = 11;
                    DragonslayerRangerSteel.Hand = 2;
                    DragonslayerRangerSteel.Model = 3898;
                    DragonslayerRangerSteel.IsDropable = true;
                    DragonslayerRangerSteel.IsPickable = true;
                    DragonslayerRangerSteel.Type_Damage = 3;
                    DragonslayerRangerSteel.DPS_AF = 165;
                    DragonslayerRangerSteel.SPD_ABS = 34;
                    DragonslayerRangerSteel.Object_Type = 21;
                    DragonslayerRangerSteel.Quality = 100;
                    DragonslayerRangerSteel.IsTradable = false;
                    DragonslayerRangerSteel.Weight = 25;
                    DragonslayerRangerSteel.Price = 3500;
                    DragonslayerRangerSteel.Bonus = 35;
                    DragonslayerRangerSteel.MaxCondition = 50000;
                    DragonslayerRangerSteel.MaxDurability = 50000;
                    DragonslayerRangerSteel.Condition = 50000;
                    DragonslayerRangerSteel.Durability = 50000;
                    DragonslayerRangerSteel.Bonus1 = 4;
                    DragonslayerRangerSteel.Bonus1Type = (int)eProperty.Skill_Celtic_Dual;
                    DragonslayerRangerSteel.Bonus2 = 7;
                    DragonslayerRangerSteel.Bonus2Type = (int)eStat.STR;
                    DragonslayerRangerSteel.Bonus3 = 9;
                    DragonslayerRangerSteel.Bonus3Type = (int)eStat.QUI;
                    DragonslayerRangerSteel.Bonus4 = 4;
                    DragonslayerRangerSteel.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerRangerSteel.Bonus5 = 4;
                    DragonslayerRangerSteel.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerRangerSteel.Bonus6 = 5;
                    DragonslayerRangerSteel.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerRangerSteel.Bonus7 = 6;
                    DragonslayerRangerSteel.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerRangerSteel.SpellID = 32178;
                    DragonslayerRangerSteel.Charges = 100;
                    DragonslayerRangerSteel.MaxCharges = 100;
                    DragonslayerRangerSteel.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerRangerSteel);
                }

                if (DragonslayerRecurveBow == null)
                {
                    DragonslayerRecurveBow = new ItemTemplate();
                    DragonslayerRecurveBow.Id_nb = "DragonslayerRecurveBow";
                    DragonslayerRecurveBow.Name = "Dragonslayer Recurve Bow";
                    DragonslayerRecurveBow.Level = 51;
                    DragonslayerRecurveBow.Item_Type = 13;
                    DragonslayerRecurveBow.Hand = 1;
                    DragonslayerRecurveBow.Model = 3883;
                    DragonslayerRecurveBow.IsDropable = true;
                    DragonslayerRecurveBow.IsPickable = true;
                    DragonslayerRecurveBow.Type_Damage = 0;
                    DragonslayerRecurveBow.DPS_AF = 165;
                    DragonslayerRecurveBow.SPD_ABS = 57;
                    DragonslayerRecurveBow.Object_Type = 18;
                    DragonslayerRecurveBow.Quality = 100;
                    DragonslayerRecurveBow.IsTradable = false;
                    DragonslayerRecurveBow.Weight = 25;
                    DragonslayerRecurveBow.Bonus = 35;
                    DragonslayerRecurveBow.Price = 3500;
                    DragonslayerRecurveBow.MaxCondition = 50000;
                    DragonslayerRecurveBow.MaxDurability = 50000;
                    DragonslayerRecurveBow.Condition = 50000;
                    DragonslayerRecurveBow.Durability = 50000;
                    DragonslayerRecurveBow.Bonus1 = 4;
                    DragonslayerRecurveBow.Bonus1Type = (int)eProperty.Skill_RecurvedBow;
                    DragonslayerRecurveBow.Bonus2 = 15;
                    DragonslayerRecurveBow.Bonus2Type = (int)eStat.DEX;
                    DragonslayerRecurveBow.Bonus3 = 3;
                    DragonslayerRecurveBow.Bonus3Type = (int)eProperty.RangedDamage;
                    DragonslayerRecurveBow.Bonus4 = 3;
                    DragonslayerRecurveBow.Bonus4Type = (int)eProperty.ArcheryRange;
                    DragonslayerRecurveBow.Bonus5 = 3;
                    DragonslayerRecurveBow.Bonus5Type = (int)eProperty.ArcherySpeed;
                    DragonslayerRecurveBow.Bonus6 = 9;
                    DragonslayerRecurveBow.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerRecurveBow.SpellID = 32176;
                    DragonslayerRecurveBow.Charges = 100;
                    DragonslayerRecurveBow.MaxCharges = 100;
                    GameServer.Database.AddObject(DragonslayerRecurveBow);
                }

                if (NightshadeDragonslayerFuarBlade == null)
                {
                    NightshadeDragonslayerFuarBlade = new ItemTemplate();
                    NightshadeDragonslayerFuarBlade.Id_nb = "NightshadeDragonslayerFuarBlade";
                    NightshadeDragonslayerFuarBlade.Name = "Nightshade Dragonslayer Fuar Blade";
                    NightshadeDragonslayerFuarBlade.Level = 51;
                    NightshadeDragonslayerFuarBlade.Item_Type = 10;
                    NightshadeDragonslayerFuarBlade.Model = 3895;
                    NightshadeDragonslayerFuarBlade.IsDropable = true;
                    NightshadeDragonslayerFuarBlade.IsPickable = true;
                    NightshadeDragonslayerFuarBlade.Type_Damage = 2;
                    NightshadeDragonslayerFuarBlade.DPS_AF = 165;
                    NightshadeDragonslayerFuarBlade.SPD_ABS = 42;
                    NightshadeDragonslayerFuarBlade.Price = 3500;
                    NightshadeDragonslayerFuarBlade.Object_Type = 19;
                    NightshadeDragonslayerFuarBlade.Quality = 100;
                    NightshadeDragonslayerFuarBlade.IsTradable = false;
                    NightshadeDragonslayerFuarBlade.Weight = 25;
                    NightshadeDragonslayerFuarBlade.Bonus = 35;
                    NightshadeDragonslayerFuarBlade.MaxCondition = 50000;
                    NightshadeDragonslayerFuarBlade.MaxDurability = 50000;
                    NightshadeDragonslayerFuarBlade.Condition = 50000;
                    NightshadeDragonslayerFuarBlade.Durability = 50000;
                    NightshadeDragonslayerFuarBlade.Bonus1 = 4;
                    NightshadeDragonslayerFuarBlade.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    NightshadeDragonslayerFuarBlade.Bonus2 = 12;
                    NightshadeDragonslayerFuarBlade.Bonus2Type = (int)eStat.STR;
                    NightshadeDragonslayerFuarBlade.Bonus3 = 12;
                    NightshadeDragonslayerFuarBlade.Bonus3Type = (int)eStat.DEX;
                    NightshadeDragonslayerFuarBlade.Bonus4 = 4;
                    NightshadeDragonslayerFuarBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    NightshadeDragonslayerFuarBlade.Bonus5 = 4;
                    NightshadeDragonslayerFuarBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    NightshadeDragonslayerFuarBlade.Bonus6 = 8;
                    NightshadeDragonslayerFuarBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    NightshadeDragonslayerFuarBlade.ProcSpellID = 32183;
                    NightshadeDragonslayerFuarBlade.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(NightshadeDragonslayerFuarBlade);
                }

                if (NightshadeDragonslayerFuarSteel == null)
                {
                    NightshadeDragonslayerFuarSteel = new ItemTemplate();
                    NightshadeDragonslayerFuarSteel.Id_nb = "NightshadeDragonslayerFuarSteel";
                    NightshadeDragonslayerFuarSteel.Name = "Nightshade Dragonslayer Fuar Steel";
                    NightshadeDragonslayerFuarSteel.Level = 51;
                    NightshadeDragonslayerFuarSteel.Item_Type = 10;
                    NightshadeDragonslayerFuarSteel.Model = 3899;
                    NightshadeDragonslayerFuarSteel.IsDropable = true;
                    NightshadeDragonslayerFuarSteel.IsPickable = true;
                    NightshadeDragonslayerFuarSteel.Type_Damage = 3;
                    NightshadeDragonslayerFuarSteel.DPS_AF = 165;
                    NightshadeDragonslayerFuarSteel.SPD_ABS = 42;
                    NightshadeDragonslayerFuarSteel.Object_Type = 21;
                    NightshadeDragonslayerFuarSteel.Quality = 100;
                    NightshadeDragonslayerFuarSteel.IsTradable = false;
                    NightshadeDragonslayerFuarSteel.Weight = 25;
                    NightshadeDragonslayerFuarSteel.Price = 3500;
                    NightshadeDragonslayerFuarSteel.Bonus = 35;
                    NightshadeDragonslayerFuarSteel.MaxCondition = 50000;
                    NightshadeDragonslayerFuarSteel.MaxDurability = 50000;
                    NightshadeDragonslayerFuarSteel.Condition = 50000;
                    NightshadeDragonslayerFuarSteel.Durability = 50000;
                    NightshadeDragonslayerFuarSteel.Bonus1 = 4;
                    NightshadeDragonslayerFuarSteel.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    NightshadeDragonslayerFuarSteel.Bonus2 = 7;
                    NightshadeDragonslayerFuarSteel.Bonus2Type = (int)eStat.STR;
                    NightshadeDragonslayerFuarSteel.Bonus3 = 9;
                    NightshadeDragonslayerFuarSteel.Bonus3Type = (int)eStat.DEX;
                    NightshadeDragonslayerFuarSteel.Bonus4 = 4;
                    NightshadeDragonslayerFuarSteel.Bonus4Type = (int)eProperty.MeleeDamage;
                    NightshadeDragonslayerFuarSteel.Bonus5 = 4;
                    NightshadeDragonslayerFuarSteel.Bonus5Type = (int)eProperty.StyleDamage;
                    NightshadeDragonslayerFuarSteel.Bonus6 = 5;
                    NightshadeDragonslayerFuarSteel.Bonus6Type = (int)eProperty.StrCapBonus;
                    NightshadeDragonslayerFuarSteel.Bonus7 = 6;
                    NightshadeDragonslayerFuarSteel.Bonus7Type = (int)eProperty.DexCapBonus;
                    NightshadeDragonslayerFuarSteel.ProcSpellID = 32183;
                    NightshadeDragonslayerFuarSteel.ProcSpellID1 = 32177;
                    GameServer.Database.AddObject(NightshadeDragonslayerFuarSteel);
                }

                if (RangerDragonslayerFuarBlade == null)
                {
                    RangerDragonslayerFuarBlade = new ItemTemplate();
                    RangerDragonslayerFuarBlade.Id_nb = "RangerDragonslayerFuarBlade";
                    RangerDragonslayerFuarBlade.Name = "Ranger Dragonslayer Fuar Blade";
                    RangerDragonslayerFuarBlade.Level = 51;
                    RangerDragonslayerFuarBlade.Item_Type = 10;
                    RangerDragonslayerFuarBlade.Model = 3895;
                    RangerDragonslayerFuarBlade.IsDropable = true;
                    RangerDragonslayerFuarBlade.IsPickable = true;
                    RangerDragonslayerFuarBlade.Type_Damage = 2;
                    RangerDragonslayerFuarBlade.DPS_AF = 165;
                    RangerDragonslayerFuarBlade.SPD_ABS = 42;
                    RangerDragonslayerFuarBlade.Price = 3500;
                    RangerDragonslayerFuarBlade.Object_Type = 19;
                    RangerDragonslayerFuarBlade.Quality = 100;
                    RangerDragonslayerFuarBlade.IsTradable = false;
                    RangerDragonslayerFuarBlade.Weight = 25;
                    RangerDragonslayerFuarBlade.Bonus = 35;
                    RangerDragonslayerFuarBlade.MaxCondition = 50000;
                    RangerDragonslayerFuarBlade.MaxDurability = 50000;
                    RangerDragonslayerFuarBlade.Condition = 50000;
                    RangerDragonslayerFuarBlade.Durability = 50000;
                    RangerDragonslayerFuarBlade.Bonus1 = 4;
                    RangerDragonslayerFuarBlade.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    RangerDragonslayerFuarBlade.Bonus2 = 12;
                    RangerDragonslayerFuarBlade.Bonus2Type = (int)eStat.STR;
                    RangerDragonslayerFuarBlade.Bonus3 = 12;
                    RangerDragonslayerFuarBlade.Bonus3Type = (int)eStat.QUI;
                    RangerDragonslayerFuarBlade.Bonus4 = 4;
                    RangerDragonslayerFuarBlade.Bonus4Type = (int)eProperty.MeleeDamage;
                    RangerDragonslayerFuarBlade.Bonus5 = 4;
                    RangerDragonslayerFuarBlade.Bonus5Type = (int)eProperty.StyleDamage;
                    RangerDragonslayerFuarBlade.Bonus6 = 8;
                    RangerDragonslayerFuarBlade.Bonus6Type = (int)eProperty.StrCapBonus;
                    RangerDragonslayerFuarBlade.SpellID = 32178;
                    RangerDragonslayerFuarBlade.Charges = 100;
                    RangerDragonslayerFuarBlade.MaxCharges = 100;
                    RangerDragonslayerFuarBlade.ProcSpellID = 32177;
                    GameServer.Database.AddObject(RangerDragonslayerFuarBlade);
                }

                if (RangerDragonslayerFuarSteel == null)
                {
                    RangerDragonslayerFuarSteel = new ItemTemplate();
                    RangerDragonslayerFuarSteel.Id_nb = "RangerDragonslayerFuarSteel";
                    RangerDragonslayerFuarSteel.Name = "Ranger Dragonslayer Fuar Steel";
                    RangerDragonslayerFuarSteel.Level = 51;
                    RangerDragonslayerFuarSteel.Item_Type = 10;
                    RangerDragonslayerFuarSteel.Model = 3899;
                    RangerDragonslayerFuarSteel.IsDropable = true;
                    RangerDragonslayerFuarSteel.IsPickable = true;
                    RangerDragonslayerFuarSteel.Price = 3500;
                    RangerDragonslayerFuarSteel.Type_Damage = 3;
                    RangerDragonslayerFuarSteel.DPS_AF = 165;
                    RangerDragonslayerFuarSteel.SPD_ABS = 42;
                    RangerDragonslayerFuarSteel.Object_Type = 21;
                    RangerDragonslayerFuarSteel.Quality = 100;
                    RangerDragonslayerFuarSteel.IsTradable = false;
                    RangerDragonslayerFuarSteel.Weight = 25;
                    RangerDragonslayerFuarSteel.Bonus = 35;
                    RangerDragonslayerFuarSteel.MaxCondition = 50000;
                    RangerDragonslayerFuarSteel.MaxDurability = 50000;
                    RangerDragonslayerFuarSteel.Condition = 50000;
                    RangerDragonslayerFuarSteel.Durability = 50000;
                    RangerDragonslayerFuarSteel.Bonus1 = 4;
                    RangerDragonslayerFuarSteel.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    RangerDragonslayerFuarSteel.Bonus2 = 7;
                    RangerDragonslayerFuarSteel.Bonus2Type = (int)eStat.STR;
                    RangerDragonslayerFuarSteel.Bonus3 = 9;
                    RangerDragonslayerFuarSteel.Bonus3Type = (int)eStat.DEX;
                    RangerDragonslayerFuarSteel.Bonus4 = 4;
                    RangerDragonslayerFuarSteel.Bonus4Type = (int)eProperty.MeleeDamage;
                    RangerDragonslayerFuarSteel.Bonus5 = 4;
                    RangerDragonslayerFuarSteel.Bonus5Type = (int)eProperty.StyleDamage;
                    RangerDragonslayerFuarSteel.Bonus6 = 5;
                    RangerDragonslayerFuarSteel.Bonus6Type = (int)eProperty.StrCapBonus;
                    RangerDragonslayerFuarSteel.Bonus7 = 6;
                    RangerDragonslayerFuarSteel.Bonus7Type = (int)eProperty.DexCapBonus;
                    RangerDragonslayerFuarSteel.SpellID = 32178;
                    RangerDragonslayerFuarSteel.Charges = 100;
                    RangerDragonslayerFuarSteel.MaxCharges = 100;
                    RangerDragonslayerFuarSteel.ProcSpellID = 32177;
                    GameServer.Database.AddObject(RangerDragonslayerFuarSteel);
                }

                if (DragonslayerBerserkerAxelh == null)
                {
                    DragonslayerBerserkerAxelh = new ItemTemplate();
                    DragonslayerBerserkerAxelh.Id_nb = "DragonslayerBerserkerAxelh"; //Left hand
                    DragonslayerBerserkerAxelh.Name = "Dragonslayer Berserker Left Axe";
                    DragonslayerBerserkerAxelh.Level = 51;
                    DragonslayerBerserkerAxelh.Item_Type = 11;
                    DragonslayerBerserkerAxelh.Hand = 2;
                    DragonslayerBerserkerAxelh.Model = 3941;
                    DragonslayerBerserkerAxelh.IsDropable = true;
                    DragonslayerBerserkerAxelh.IsPickable = true;
                    DragonslayerBerserkerAxelh.Type_Damage = 2;
                    DragonslayerBerserkerAxelh.DPS_AF = 165;
                    DragonslayerBerserkerAxelh.SPD_ABS = 40;
                    DragonslayerBerserkerAxelh.Object_Type = 17;
                    DragonslayerBerserkerAxelh.Quality = 100;
                    DragonslayerBerserkerAxelh.IsTradable = false;
                    DragonslayerBerserkerAxelh.Weight = 25;
                    DragonslayerBerserkerAxelh.Price = 3500;
                    DragonslayerBerserkerAxelh.Bonus = 35;
                    DragonslayerBerserkerAxelh.MaxCondition = 50000;
                    DragonslayerBerserkerAxelh.MaxDurability = 50000;
                    DragonslayerBerserkerAxelh.Condition = 50000;
                    DragonslayerBerserkerAxelh.Durability = 50000;
                    DragonslayerBerserkerAxelh.Bonus1 = 4;
                    DragonslayerBerserkerAxelh.Bonus1Type = (int)eProperty.Skill_Left_Axe;
                    DragonslayerBerserkerAxelh.Bonus2 = 10;
                    DragonslayerBerserkerAxelh.Bonus2Type = (int)eStat.STR;
                    DragonslayerBerserkerAxelh.Bonus3 = 10;
                    DragonslayerBerserkerAxelh.Bonus3Type = (int)eStat.QUI;
                    DragonslayerBerserkerAxelh.Bonus4 = 3;
                    DragonslayerBerserkerAxelh.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerBerserkerAxelh.Bonus5 = 3;
                    DragonslayerBerserkerAxelh.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerBerserkerAxelh.Bonus6 = 3;
                    DragonslayerBerserkerAxelh.Bonus6Type = (int)eProperty.MeleeSpeed;
                    DragonslayerBerserkerAxelh.Bonus7 = 8;
                    DragonslayerBerserkerAxelh.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerBerserkerAxelh.SpellID = 32188;
                    DragonslayerBerserkerAxelh.Charges = 100;
                    DragonslayerBerserkerAxelh.MaxCharges = 100;
                    DragonslayerBerserkerAxelh.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBerserkerAxelh);
                }

                if (DragonslayerBerserkerAxerh == null)
                {
                    DragonslayerBerserkerAxerh = new ItemTemplate();
                    DragonslayerBerserkerAxerh.Id_nb = "DragonslayerBerserkerAxerh"; //Right hand
                    DragonslayerBerserkerAxerh.Name = "Dragonslayer Berserker Axe";
                    DragonslayerBerserkerAxerh.Level = 51;
                    DragonslayerBerserkerAxerh.Item_Type = 10;
                    DragonslayerBerserkerAxerh.Model = 3942;
                    DragonslayerBerserkerAxerh.IsDropable = true;
                    DragonslayerBerserkerAxerh.IsPickable = true;
                    DragonslayerBerserkerAxerh.Price = 3500;
                    DragonslayerBerserkerAxerh.Type_Damage = 2;
                    DragonslayerBerserkerAxerh.DPS_AF = 165;
                    DragonslayerBerserkerAxerh.SPD_ABS = 43;
                    DragonslayerBerserkerAxerh.Object_Type = 13;
                    DragonslayerBerserkerAxerh.Quality = 100;
                    DragonslayerBerserkerAxerh.IsTradable = false;
                    DragonslayerBerserkerAxerh.Weight = 25;
                    DragonslayerBerserkerAxerh.Bonus = 35;
                    DragonslayerBerserkerAxerh.MaxCondition = 50000;
                    DragonslayerBerserkerAxerh.MaxDurability = 50000;
                    DragonslayerBerserkerAxerh.Condition = 50000;
                    DragonslayerBerserkerAxerh.Durability = 50000;
                    DragonslayerBerserkerAxerh.Bonus1 = 4;
                    DragonslayerBerserkerAxerh.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    DragonslayerBerserkerAxerh.Bonus2 = 10;
                    DragonslayerBerserkerAxerh.Bonus2Type = (int)eStat.STR;
                    DragonslayerBerserkerAxerh.Bonus3 = 10;
                    DragonslayerBerserkerAxerh.Bonus3Type = (int)eStat.QUI;
                    DragonslayerBerserkerAxerh.Bonus4 = 3;
                    DragonslayerBerserkerAxerh.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerBerserkerAxerh.Bonus5 = 3;
                    DragonslayerBerserkerAxerh.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerBerserkerAxerh.Bonus6 = 3;
                    DragonslayerBerserkerAxerh.Bonus6Type = (int)eProperty.MeleeSpeed;
                    DragonslayerBerserkerAxerh.Bonus7 = 8;
                    DragonslayerBerserkerAxerh.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerBerserkerAxerh.SpellID = 32188;
                    DragonslayerBerserkerAxerh.Charges = 100;
                    DragonslayerBerserkerAxerh.MaxCharges = 100;
                    DragonslayerBerserkerAxerh.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBerserkerAxerh);
                }

                if (DragonslayerBerserkerHammer == null)
                {
                    DragonslayerBerserkerHammer = new ItemTemplate();
                    DragonslayerBerserkerHammer.Id_nb = "DragonslayerBerserkerHammer";
                    DragonslayerBerserkerHammer.Name = "Dragonslayer Berserker Hammer";
                    DragonslayerBerserkerHammer.Level = 51;
                    DragonslayerBerserkerHammer.Item_Type = 10;
                    DragonslayerBerserkerHammer.Model = 3938;
                    DragonslayerBerserkerHammer.IsDropable = true;
                    DragonslayerBerserkerHammer.IsPickable = true;
                    DragonslayerBerserkerHammer.Price = 3500;
                    DragonslayerBerserkerHammer.Type_Damage = 1;
                    DragonslayerBerserkerHammer.DPS_AF = 165;
                    DragonslayerBerserkerHammer.SPD_ABS = 43;
                    DragonslayerBerserkerHammer.Object_Type = 12;
                    DragonslayerBerserkerHammer.Quality = 100;
                    DragonslayerBerserkerHammer.IsTradable = false;
                    DragonslayerBerserkerHammer.Weight = 25;
                    DragonslayerBerserkerHammer.Bonus = 35;
                    DragonslayerBerserkerHammer.MaxCondition = 50000;
                    DragonslayerBerserkerHammer.MaxDurability = 50000;
                    DragonslayerBerserkerHammer.Condition = 50000;
                    DragonslayerBerserkerHammer.Durability = 50000;
                    DragonslayerBerserkerHammer.Bonus1 = 4;
                    DragonslayerBerserkerHammer.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    DragonslayerBerserkerHammer.Bonus2 = 10;
                    DragonslayerBerserkerHammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerBerserkerHammer.Bonus3 = 10;
                    DragonslayerBerserkerHammer.Bonus3Type = (int)eStat.QUI;
                    DragonslayerBerserkerHammer.Bonus4 = 3;
                    DragonslayerBerserkerHammer.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerBerserkerHammer.Bonus5 = 3;
                    DragonslayerBerserkerHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerBerserkerHammer.Bonus6 = 3;
                    DragonslayerBerserkerHammer.Bonus6Type = (int)eProperty.MeleeSpeed;
                    DragonslayerBerserkerHammer.Bonus7 = 8;
                    DragonslayerBerserkerHammer.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerBerserkerHammer.SpellID = 32188;
                    DragonslayerBerserkerHammer.Charges = 100;
                    DragonslayerBerserkerHammer.MaxCharges = 100;
                    DragonslayerBerserkerHammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBerserkerHammer);
                }

                if (DragonslayerBerserkerSword == null)
                {
                    DragonslayerBerserkerSword = new ItemTemplate();
                    DragonslayerBerserkerSword.Id_nb = "DragonslayerBerserkerSword";
                    DragonslayerBerserkerSword.Name = "Dragonslayer Berserker Sword";
                    DragonslayerBerserkerSword.Level = 51;
                    DragonslayerBerserkerSword.Item_Type = 10;
                    DragonslayerBerserkerSword.Model = 3936;
                    DragonslayerBerserkerSword.IsDropable = true;
                    DragonslayerBerserkerSword.IsPickable = true;
                    DragonslayerBerserkerSword.Type_Damage = 2;
                    DragonslayerBerserkerSword.DPS_AF = 165;
                    DragonslayerBerserkerSword.Price = 3500;
                    DragonslayerBerserkerSword.SPD_ABS = 43;
                    DragonslayerBerserkerSword.Object_Type = 11;
                    DragonslayerBerserkerSword.Quality = 100;
                    DragonslayerBerserkerSword.IsTradable = false;
                    DragonslayerBerserkerSword.Weight = 25;
                    DragonslayerBerserkerSword.Bonus = 35;
                    DragonslayerBerserkerSword.MaxCondition = 50000;
                    DragonslayerBerserkerSword.MaxDurability = 50000;
                    DragonslayerBerserkerSword.Condition = 50000;
                    DragonslayerBerserkerSword.Durability = 50000;
                    DragonslayerBerserkerSword.Bonus1 = 4;
                    DragonslayerBerserkerSword.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    DragonslayerBerserkerSword.Bonus2 = 10;
                    DragonslayerBerserkerSword.Bonus2Type = (int)eStat.STR;
                    DragonslayerBerserkerSword.Bonus3 = 10;
                    DragonslayerBerserkerSword.Bonus3Type = (int)eStat.QUI;
                    DragonslayerBerserkerSword.Bonus4 = 3;
                    DragonslayerBerserkerSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerBerserkerSword.Bonus5 = 3;
                    DragonslayerBerserkerSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerBerserkerSword.Bonus6 = 3;
                    DragonslayerBerserkerSword.Bonus6Type = (int)eProperty.MeleeSpeed;
                    DragonslayerBerserkerSword.Bonus7 = 8;
                    DragonslayerBerserkerSword.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerBerserkerSword.SpellID = 32188;
                    DragonslayerBerserkerSword.Charges = 100;
                    DragonslayerBerserkerSword.MaxCharges = 100;
                    DragonslayerBerserkerSword.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBerserkerSword);
                }

                if (DragonslayerBerserkerTwohandedAxe == null)
                {
                    DragonslayerBerserkerTwohandedAxe = new ItemTemplate();
                    DragonslayerBerserkerTwohandedAxe.Id_nb = "DragonslayerBerserkerTwohandedAxe";
                    DragonslayerBerserkerTwohandedAxe.Name = "Dragonslayer Berserker Two-handed Axe";
                    DragonslayerBerserkerTwohandedAxe.Level = 51;
                    DragonslayerBerserkerTwohandedAxe.Item_Type = 12;
                    DragonslayerBerserkerTwohandedAxe.Hand = 1;
                    DragonslayerBerserkerTwohandedAxe.Model = 3923;
                    DragonslayerBerserkerTwohandedAxe.IsDropable = true;
                    DragonslayerBerserkerTwohandedAxe.IsPickable = true;
                    DragonslayerBerserkerTwohandedAxe.Type_Damage = 2;
                    DragonslayerBerserkerTwohandedAxe.DPS_AF = 165;
                    DragonslayerBerserkerTwohandedAxe.Price = 3500;
                    DragonslayerBerserkerTwohandedAxe.SPD_ABS = 57;
                    DragonslayerBerserkerTwohandedAxe.Object_Type = 13;
                    DragonslayerBerserkerTwohandedAxe.Quality = 100;
                    DragonslayerBerserkerTwohandedAxe.IsTradable = false;
                    DragonslayerBerserkerTwohandedAxe.Weight = 25;
                    DragonslayerBerserkerTwohandedAxe.Bonus = 35;
                    DragonslayerBerserkerTwohandedAxe.MaxCondition = 50000;
                    DragonslayerBerserkerTwohandedAxe.MaxDurability = 50000;
                    DragonslayerBerserkerTwohandedAxe.Condition = 50000;
                    DragonslayerBerserkerTwohandedAxe.Durability = 50000;
                    DragonslayerBerserkerTwohandedAxe.Bonus1 = 4;
                    DragonslayerBerserkerTwohandedAxe.Bonus1Type = (int)eProperty.Skill_Axe;
                    DragonslayerBerserkerTwohandedAxe.Bonus2 = 10;
                    DragonslayerBerserkerTwohandedAxe.Bonus2Type = (int)eStat.STR;
                    DragonslayerBerserkerTwohandedAxe.Bonus3 = 10;
                    DragonslayerBerserkerTwohandedAxe.Bonus3Type = (int)eStat.QUI;
                    DragonslayerBerserkerTwohandedAxe.Bonus4 = 3;
                    DragonslayerBerserkerTwohandedAxe.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerBerserkerTwohandedAxe.Bonus5 = 3;
                    DragonslayerBerserkerTwohandedAxe.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerBerserkerTwohandedAxe.Bonus6 = 3;
                    DragonslayerBerserkerTwohandedAxe.Bonus6Type = (int)eProperty.MeleeSpeed;
                    DragonslayerBerserkerTwohandedAxe.Bonus7 = 8;
                    DragonslayerBerserkerTwohandedAxe.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerBerserkerTwohandedAxe.SpellID = 32188;
                    DragonslayerBerserkerTwohandedAxe.Charges = 100;
                    DragonslayerBerserkerTwohandedAxe.MaxCharges = 100;
                    DragonslayerBerserkerTwohandedAxe.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBerserkerTwohandedAxe);
                }

                if (DragonslayerBerserkerTwohandedHammer == null)
                {
                    DragonslayerBerserkerTwohandedHammer = new ItemTemplate();
                    DragonslayerBerserkerTwohandedHammer.Id_nb = "DragonslayerBerserkerTwohandedHammer";
                    DragonslayerBerserkerTwohandedHammer.Name = "Dragonslayer Berserker Two-handed Hammer";
                    DragonslayerBerserkerTwohandedHammer.Level = 51;
                    DragonslayerBerserkerTwohandedHammer.Item_Type = 12;
                    DragonslayerBerserkerTwohandedHammer.Hand = 1;
                    DragonslayerBerserkerTwohandedHammer.Model = 3922;
                    DragonslayerBerserkerTwohandedHammer.IsDropable = true;
                    DragonslayerBerserkerTwohandedHammer.IsPickable = true;
                    DragonslayerBerserkerTwohandedHammer.Type_Damage = 1;
                    DragonslayerBerserkerTwohandedHammer.DPS_AF = 165;
                    DragonslayerBerserkerTwohandedHammer.SPD_ABS = 57;
                    DragonslayerBerserkerTwohandedHammer.Price = 3500;
                    DragonslayerBerserkerTwohandedHammer.Object_Type = 12;
                    DragonslayerBerserkerTwohandedHammer.Quality = 100;
                    DragonslayerBerserkerTwohandedHammer.IsTradable = false;
                    DragonslayerBerserkerTwohandedHammer.Weight = 25;
                    DragonslayerBerserkerTwohandedHammer.Bonus = 35;
                    DragonslayerBerserkerTwohandedHammer.MaxCondition = 50000;
                    DragonslayerBerserkerTwohandedHammer.MaxDurability = 50000;
                    DragonslayerBerserkerTwohandedHammer.Condition = 50000;
                    DragonslayerBerserkerTwohandedHammer.Durability = 50000;
                    DragonslayerBerserkerTwohandedHammer.Bonus1 = 4;
                    DragonslayerBerserkerTwohandedHammer.Bonus1Type = (int)eProperty.Skill_Hammer;
                    DragonslayerBerserkerTwohandedHammer.Bonus2 = 10;
                    DragonslayerBerserkerTwohandedHammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerBerserkerTwohandedHammer.Bonus3 = 10;
                    DragonslayerBerserkerTwohandedHammer.Bonus3Type = (int)eStat.QUI;
                    DragonslayerBerserkerTwohandedHammer.Bonus4 = 3;
                    DragonslayerBerserkerTwohandedHammer.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerBerserkerTwohandedHammer.Bonus5 = 3;
                    DragonslayerBerserkerTwohandedHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerBerserkerTwohandedHammer.Bonus6 = 3;
                    DragonslayerBerserkerTwohandedHammer.Bonus6Type = (int)eProperty.MeleeSpeed;
                    DragonslayerBerserkerTwohandedHammer.Bonus7 = 8;
                    DragonslayerBerserkerTwohandedHammer.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerBerserkerTwohandedHammer.SpellID = 32188;
                    DragonslayerBerserkerTwohandedHammer.Charges = 100;
                    DragonslayerBerserkerTwohandedHammer.MaxCharges = 100;
                    DragonslayerBerserkerTwohandedHammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBerserkerTwohandedHammer);
                }

                if (DragonslayerBerserkerTwohandedSword == null)
                {
                    DragonslayerBerserkerTwohandedSword = new ItemTemplate();
                    DragonslayerBerserkerTwohandedSword.Id_nb = "DragonslayerBerserkerTwohandedSword";
                    DragonslayerBerserkerTwohandedSword.Name = "Dragonslayer Berserker Two-handed Sword";
                    DragonslayerBerserkerTwohandedSword.Level = 51;
                    DragonslayerBerserkerTwohandedSword.Item_Type = 12;
                    DragonslayerBerserkerTwohandedSword.Hand = 1;
                    DragonslayerBerserkerTwohandedSword.Model = 3919;
                    DragonslayerBerserkerTwohandedSword.IsDropable = true;
                    DragonslayerBerserkerTwohandedSword.IsPickable = true;
                    DragonslayerBerserkerTwohandedSword.Type_Damage = 2;
                    DragonslayerBerserkerTwohandedSword.DPS_AF = 165;
                    DragonslayerBerserkerTwohandedSword.Price = 3500;
                    DragonslayerBerserkerTwohandedSword.SPD_ABS = 57;
                    DragonslayerBerserkerTwohandedSword.Object_Type = 11;
                    DragonslayerBerserkerTwohandedSword.Quality = 100;
                    DragonslayerBerserkerTwohandedSword.IsTradable = false;
                    DragonslayerBerserkerTwohandedSword.Weight = 25;
                    DragonslayerBerserkerTwohandedSword.Bonus = 35;
                    DragonslayerBerserkerTwohandedSword.MaxCondition = 50000;
                    DragonslayerBerserkerTwohandedSword.MaxDurability = 50000;
                    DragonslayerBerserkerTwohandedSword.Condition = 50000;
                    DragonslayerBerserkerTwohandedSword.Durability = 50000;
                    DragonslayerBerserkerTwohandedSword.Bonus1 = 4;
                    DragonslayerBerserkerTwohandedSword.Bonus1Type = (int)eProperty.Skill_Sword;
                    DragonslayerBerserkerTwohandedSword.Bonus2 = 10;
                    DragonslayerBerserkerTwohandedSword.Bonus2Type = (int)eStat.STR;
                    DragonslayerBerserkerTwohandedSword.Bonus3 = 10;
                    DragonslayerBerserkerTwohandedSword.Bonus3Type = (int)eStat.QUI;
                    DragonslayerBerserkerTwohandedSword.Bonus4 = 3;
                    DragonslayerBerserkerTwohandedSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerBerserkerTwohandedSword.Bonus5 = 3;
                    DragonslayerBerserkerTwohandedSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerBerserkerTwohandedSword.Bonus6 = 3;
                    DragonslayerBerserkerTwohandedSword.Bonus6Type = (int)eProperty.MeleeSpeed;
                    DragonslayerBerserkerTwohandedSword.Bonus7 = 8;
                    DragonslayerBerserkerTwohandedSword.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerBerserkerTwohandedSword.SpellID = 32188;
                    DragonslayerBerserkerTwohandedSword.Charges = 100;
                    DragonslayerBerserkerTwohandedSword.MaxCharges = 100;
                    DragonslayerBerserkerTwohandedSword.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerBerserkerTwohandedSword);
                }

                if (DragonslayerCompoundBow == null)
                {
                    DragonslayerCompoundBow = new ItemTemplate();
                    DragonslayerCompoundBow.Id_nb = "DragonslayerCompoundBow";
                    DragonslayerCompoundBow.Name = "Dragonslayer Compound Bow";
                    DragonslayerCompoundBow.Level = 51;
                    DragonslayerCompoundBow.Item_Type = 13;
                    DragonslayerCompoundBow.Hand = 1;
                    DragonslayerCompoundBow.Model = 3924;
                    DragonslayerCompoundBow.IsDropable = true;
                    DragonslayerCompoundBow.IsPickable = true;
                    DragonslayerCompoundBow.Type_Damage = 0;
                    DragonslayerCompoundBow.DPS_AF = 165;
                    DragonslayerCompoundBow.Price = 3500;
                    DragonslayerCompoundBow.SPD_ABS = 53;
                    DragonslayerCompoundBow.Object_Type = 15;
                    DragonslayerCompoundBow.Quality = 100;
                    DragonslayerCompoundBow.IsTradable = false;
                    DragonslayerCompoundBow.Weight = 25;
                    DragonslayerCompoundBow.Bonus = 35;
                    DragonslayerCompoundBow.MaxCondition = 50000;
                    DragonslayerCompoundBow.MaxDurability = 50000;
                    DragonslayerCompoundBow.Condition = 50000;
                    DragonslayerCompoundBow.Durability = 50000;
                    DragonslayerCompoundBow.Bonus1 = 4;
                    DragonslayerCompoundBow.Bonus1Type = (int)eProperty.Skill_Composite;
                    DragonslayerCompoundBow.Bonus2 = 15;
                    DragonslayerCompoundBow.Bonus2Type = (int)eStat.DEX;
                    DragonslayerCompoundBow.Bonus3 = 3;
                    DragonslayerCompoundBow.Bonus3Type = (int)eProperty.RangedDamage;
                    DragonslayerCompoundBow.Bonus4 = 3;
                    DragonslayerCompoundBow.Bonus4Type = (int)eProperty.ArcheryRange;
                    DragonslayerCompoundBow.Bonus5 = 3;
                    DragonslayerCompoundBow.Bonus5Type = (int)eProperty.ArcherySpeed;
                    DragonslayerCompoundBow.Bonus6 = 9;
                    DragonslayerCompoundBow.Bonus6Type = (int)eProperty.DexCapBonus;
                    DragonslayerCompoundBow.SpellID = 32176;
                    DragonslayerCompoundBow.Charges = 100;
                    DragonslayerCompoundBow.MaxCharges = 100;
                    GameServer.Database.AddObject(DragonslayerCompoundBow);
                }

                if (DragonslayerHunterSlashingSpear == null)
                {
                    DragonslayerHunterSlashingSpear = new ItemTemplate();
                    DragonslayerHunterSlashingSpear.Id_nb = "DragonslayerHunterSlashingSpear";
                    DragonslayerHunterSlashingSpear.Name = "Dragonslayer Hunter Slashing Spear";
                    DragonslayerHunterSlashingSpear.Level = 51;
                    DragonslayerHunterSlashingSpear.Item_Type = 12;
                    DragonslayerHunterSlashingSpear.Hand = 1;
                    DragonslayerHunterSlashingSpear.Model = 3921;
                    DragonslayerHunterSlashingSpear.IsDropable = true;
                    DragonslayerHunterSlashingSpear.IsPickable = true;
                    DragonslayerHunterSlashingSpear.Type_Damage = 2;
                    DragonslayerHunterSlashingSpear.DPS_AF = 165;
                    DragonslayerHunterSlashingSpear.SPD_ABS = 45;
                    DragonslayerHunterSlashingSpear.Object_Type = 14;
                    DragonslayerHunterSlashingSpear.Price = 3500;
                    DragonslayerHunterSlashingSpear.Quality = 100;
                    DragonslayerHunterSlashingSpear.IsTradable = false;
                    DragonslayerHunterSlashingSpear.Weight = 25;
                    DragonslayerHunterSlashingSpear.Bonus = 35;
                    DragonslayerHunterSlashingSpear.MaxCondition = 50000;
                    DragonslayerHunterSlashingSpear.MaxDurability = 50000;
                    DragonslayerHunterSlashingSpear.Condition = 50000;
                    DragonslayerHunterSlashingSpear.Durability = 50000;
                    DragonslayerHunterSlashingSpear.Bonus1 = 9;
                    DragonslayerHunterSlashingSpear.Bonus1Type = (int)eStat.DEX;
                    DragonslayerHunterSlashingSpear.Bonus2 = 4;
                    DragonslayerHunterSlashingSpear.Bonus2Type = (int)eProperty.Skill_Spear;
                    DragonslayerHunterSlashingSpear.Bonus3 = 7;
                    DragonslayerHunterSlashingSpear.Bonus3Type = (int)eStat.STR;
                    DragonslayerHunterSlashingSpear.Bonus4 = 4;
                    DragonslayerHunterSlashingSpear.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerHunterSlashingSpear.Bonus5 = 4;
                    DragonslayerHunterSlashingSpear.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerHunterSlashingSpear.Bonus6 = 5;
                    DragonslayerHunterSlashingSpear.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerHunterSlashingSpear.Bonus7 = 6;
                    DragonslayerHunterSlashingSpear.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerHunterSlashingSpear.SpellID = 32178;
                    DragonslayerHunterSlashingSpear.Charges = 100;
                    DragonslayerHunterSlashingSpear.MaxCharges = 100;
                    DragonslayerHunterSlashingSpear.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerHunterSlashingSpear);
                }

                if (DragonslayerHunterSpear == null)
                {
                    DragonslayerHunterSpear = new ItemTemplate();
                    DragonslayerHunterSpear.Id_nb = "DragonslayerHunterSpear";
                    DragonslayerHunterSpear.Name = "Dragonslayer Hunter Spear";
                    DragonslayerHunterSpear.Level = 51;
                    DragonslayerHunterSpear.Item_Type = 12;
                    DragonslayerHunterSpear.Hand = 1;
                    DragonslayerHunterSpear.Model = 3920;
                    DragonslayerHunterSpear.IsDropable = true;
                    DragonslayerHunterSpear.Price = 3500;
                    DragonslayerHunterSpear.IsPickable = true;
                    DragonslayerHunterSpear.Type_Damage = 3;
                    DragonslayerHunterSpear.DPS_AF = 165;
                    DragonslayerHunterSpear.SPD_ABS = 50;
                    DragonslayerHunterSpear.Object_Type = 14;
                    DragonslayerHunterSpear.Quality = 100;
                    DragonslayerHunterSpear.IsTradable = false;
                    DragonslayerHunterSpear.Weight = 25;
                    DragonslayerHunterSpear.Bonus = 35;
                    DragonslayerHunterSpear.MaxCondition = 50000;
                    DragonslayerHunterSpear.MaxDurability = 50000;
                    DragonslayerHunterSpear.Condition = 50000;
                    DragonslayerHunterSpear.Durability = 50000;
                    DragonslayerHunterSpear.Bonus1 = 9;
                    DragonslayerHunterSpear.Bonus1Type = (int)eStat.DEX;
                    DragonslayerHunterSpear.Bonus2 = 4;
                    DragonslayerHunterSpear.Bonus2Type = (int)eProperty.Skill_Spear;
                    DragonslayerHunterSpear.Bonus3 = 7;
                    DragonslayerHunterSpear.Bonus3Type = (int)eStat.STR;
                    DragonslayerHunterSpear.Bonus4 = 4;
                    DragonslayerHunterSpear.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerHunterSpear.Bonus5 = 4;
                    DragonslayerHunterSpear.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerHunterSpear.Bonus6 = 5;
                    DragonslayerHunterSpear.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerHunterSpear.Bonus7 = 6;
                    DragonslayerHunterSpear.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerHunterSpear.SpellID = 32178;
                    DragonslayerHunterSpear.Charges = 100;
                    DragonslayerHunterSpear.MaxCharges = 100;
                    DragonslayerHunterSpear.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerHunterSpear);
                }

                if (DragonslayerHunterSword == null)
                {
                    DragonslayerHunterSword = new ItemTemplate();
                    DragonslayerHunterSword.Id_nb = "DragonslayerHunterSword";
                    DragonslayerHunterSword.Name = "Dragonslayer Hunter Sword";
                    DragonslayerHunterSword.Level = 51;
                    DragonslayerHunterSword.Item_Type = 10;
                    DragonslayerHunterSword.Model = 3936;
                    DragonslayerHunterSword.IsDropable = true;
                    DragonslayerHunterSword.IsPickable = true;
                    DragonslayerHunterSword.Type_Damage = 2;
                    DragonslayerHunterSword.DPS_AF = 165;
                    DragonslayerHunterSword.SPD_ABS = 43;
                    DragonslayerHunterSword.Object_Type = 11;
                    DragonslayerHunterSword.Quality = 100;
                    DragonslayerHunterSword.Price = 3500;
                    DragonslayerHunterSword.IsTradable = false;
                    DragonslayerHunterSword.Weight = 25;
                    DragonslayerHunterSword.Bonus = 35;
                    DragonslayerHunterSword.MaxCondition = 50000;
                    DragonslayerHunterSword.MaxDurability = 50000;
                    DragonslayerHunterSword.Condition = 50000;
                    DragonslayerHunterSword.Durability = 50000;
                    DragonslayerHunterSword.Bonus1 = 12;
                    DragonslayerHunterSword.Bonus1Type = (int)eStat.QUI;
                    DragonslayerHunterSword.Bonus2 = 4;
                    DragonslayerHunterSword.Bonus2Type = (int)eProperty.AllMeleeWeaponSkills;
                    DragonslayerHunterSword.Bonus3 = 12;
                    DragonslayerHunterSword.Bonus3Type = (int)eStat.STR;
                    DragonslayerHunterSword.Bonus4 = 4;
                    DragonslayerHunterSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerHunterSword.Bonus5 = 4;
                    DragonslayerHunterSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerHunterSword.Bonus6 = 8;
                    DragonslayerHunterSword.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerHunterSword.SpellID = 32178;
                    DragonslayerHunterSword.Charges = 100;
                    DragonslayerHunterSword.MaxCharges = 100;
                    DragonslayerHunterSword.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerHunterSword);
                }

                if (DragonslayerHunterTwohandedSword == null)
                {
                    DragonslayerHunterTwohandedSword = new ItemTemplate();
                    DragonslayerHunterTwohandedSword.Id_nb = "DragonslayerHunterTwohandedSword";
                    DragonslayerHunterTwohandedSword.Name = "Dragonslayer Hunter Two-handed Sword";
                    DragonslayerHunterTwohandedSword.Level = 51;
                    DragonslayerHunterTwohandedSword.Item_Type = 12;
                    DragonslayerHunterTwohandedSword.Hand = 1;
                    DragonslayerHunterTwohandedSword.Model = 3919;
                    DragonslayerHunterTwohandedSword.IsDropable = true;
                    DragonslayerHunterTwohandedSword.IsPickable = true;
                    DragonslayerHunterTwohandedSword.Type_Damage = 2;
                    DragonslayerHunterTwohandedSword.DPS_AF = 165;
                    DragonslayerHunterTwohandedSword.SPD_ABS = 57;
                    DragonslayerHunterTwohandedSword.Price = 3500;
                    DragonslayerHunterTwohandedSword.Object_Type = 11;
                    DragonslayerHunterTwohandedSword.Quality = 100;
                    DragonslayerHunterTwohandedSword.IsTradable = false;
                    DragonslayerHunterTwohandedSword.Weight = 25;
                    DragonslayerHunterTwohandedSword.Bonus = 35;
                    DragonslayerHunterTwohandedSword.MaxCondition = 50000;
                    DragonslayerHunterTwohandedSword.MaxDurability = 50000;
                    DragonslayerHunterTwohandedSword.Condition = 50000;
                    DragonslayerHunterTwohandedSword.Durability = 50000;
                    DragonslayerHunterTwohandedSword.Bonus1 = 12;
                    DragonslayerHunterTwohandedSword.Bonus1Type = (int)eStat.QUI;
                    DragonslayerHunterTwohandedSword.Bonus2 = 4;
                    DragonslayerHunterTwohandedSword.Bonus2Type = (int)eProperty.AllMeleeWeaponSkills;
                    DragonslayerHunterTwohandedSword.Bonus3 = 12;
                    DragonslayerHunterTwohandedSword.Bonus3Type = (int)eStat.STR;
                    DragonslayerHunterTwohandedSword.Bonus4 = 4;
                    DragonslayerHunterTwohandedSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerHunterTwohandedSword.Bonus5 = 4;
                    DragonslayerHunterTwohandedSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerHunterTwohandedSword.Bonus6 = 8;
                    DragonslayerHunterTwohandedSword.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerHunterTwohandedSword.SpellID = 32178;
                    DragonslayerHunterTwohandedSword.Charges = 100;
                    DragonslayerHunterTwohandedSword.MaxCharges = 100;
                    DragonslayerHunterTwohandedSword.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerHunterTwohandedSword);
                }

                if (DragonslayerSavageAxe == null)
                {
                    DragonslayerSavageAxe = new ItemTemplate();
                    DragonslayerSavageAxe.Id_nb = "DragonslayerSavageAxe";
                    DragonslayerSavageAxe.Name = "Dragonslayer Savage Axe";
                    DragonslayerSavageAxe.Level = 51;
                    DragonslayerSavageAxe.Item_Type = 10;
                    DragonslayerSavageAxe.Model = 3942;
                    DragonslayerSavageAxe.IsDropable = true;
                    DragonslayerSavageAxe.IsPickable = true;
                    DragonslayerSavageAxe.Type_Damage = 2;
                    DragonslayerSavageAxe.DPS_AF = 165;
                    DragonslayerSavageAxe.SPD_ABS = 42;
                    DragonslayerSavageAxe.Price = 3500;
                    DragonslayerSavageAxe.Object_Type = 13;
                    DragonslayerSavageAxe.Quality = 100;
                    DragonslayerSavageAxe.IsTradable = false;
                    DragonslayerSavageAxe.Weight = 25;
                    DragonslayerSavageAxe.Bonus = 35;
                    DragonslayerSavageAxe.MaxCondition = 50000;
                    DragonslayerSavageAxe.MaxDurability = 50000;
                    DragonslayerSavageAxe.Condition = 50000;
                    DragonslayerSavageAxe.Durability = 50000;
                    DragonslayerSavageAxe.Bonus1 = 4;
                    DragonslayerSavageAxe.Bonus1Type = (int)eProperty.Skill_Axe;
                    DragonslayerSavageAxe.Bonus2 = 9;
                    DragonslayerSavageAxe.Bonus2Type = (int)eStat.STR;
                    DragonslayerSavageAxe.Bonus3 = 9;
                    DragonslayerSavageAxe.Bonus3Type = (int)eStat.DEX;
                    DragonslayerSavageAxe.Bonus4 = 9;
                    DragonslayerSavageAxe.Bonus4Type = (int)eStat.QUI;
                    DragonslayerSavageAxe.Bonus5 = 4;
                    DragonslayerSavageAxe.Bonus5Type = (int)eProperty.MeleeDamage;
                    DragonslayerSavageAxe.Bonus6 = 4;
                    DragonslayerSavageAxe.Bonus6Type = (int)eProperty.StyleDamage;
                    DragonslayerSavageAxe.Bonus7 = 7;
                    DragonslayerSavageAxe.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSavageAxe.SpellID = 32178;
                    DragonslayerSavageAxe.Charges = 100;
                    DragonslayerSavageAxe.MaxCharges = 100;
                    DragonslayerSavageAxe.ProcSpellID = 32183;
                    GameServer.Database.AddObject(DragonslayerSavageAxe);
                }

                if (DragonslayerSavageHammer == null)
                {
                    DragonslayerSavageHammer = new ItemTemplate();
                    DragonslayerSavageHammer.Id_nb = "DragonslayerSavageHammer";
                    DragonslayerSavageHammer.Name = "Dragonslayer Savage Hammer";
                    DragonslayerSavageHammer.Level = 51;
                    DragonslayerSavageHammer.Item_Type = 10;
                    DragonslayerSavageHammer.Model = 3938;
                    DragonslayerSavageHammer.Price = 3500;
                    DragonslayerSavageHammer.IsDropable = true;
                    DragonslayerSavageHammer.IsPickable = true;
                    DragonslayerSavageHammer.Type_Damage = 1;
                    DragonslayerSavageHammer.DPS_AF = 165;
                    DragonslayerSavageHammer.SPD_ABS = 43;
                    DragonslayerSavageHammer.Object_Type = 12;
                    DragonslayerSavageHammer.Quality = 100;
                    DragonslayerSavageHammer.IsTradable = false;
                    DragonslayerSavageHammer.Weight = 25;
                    DragonslayerSavageHammer.Bonus = 35;
                    DragonslayerSavageHammer.MaxCondition = 50000;
                    DragonslayerSavageHammer.MaxDurability = 50000;
                    DragonslayerSavageHammer.Condition = 50000;
                    DragonslayerSavageHammer.Durability = 50000;
                    DragonslayerSavageHammer.Bonus1 = 4;
                    DragonslayerSavageHammer.Bonus1Type = (int)eProperty.Skill_Hammer;
                    DragonslayerSavageHammer.Bonus2 = 9;
                    DragonslayerSavageHammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerSavageHammer.Bonus3 = 9;
                    DragonslayerSavageHammer.Bonus3Type = (int)eStat.DEX;
                    DragonslayerSavageHammer.Bonus4 = 9;
                    DragonslayerSavageHammer.Bonus4Type = (int)eStat.QUI;
                    DragonslayerSavageHammer.Bonus5 = 4;
                    DragonslayerSavageHammer.Bonus5Type = (int)eProperty.MeleeDamage;
                    DragonslayerSavageHammer.Bonus6 = 4;
                    DragonslayerSavageHammer.Bonus6Type = (int)eProperty.StyleDamage;
                    DragonslayerSavageHammer.Bonus7 = 7;
                    DragonslayerSavageHammer.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSavageHammer.SpellID = 32178;
                    DragonslayerSavageHammer.Charges = 100;
                    DragonslayerSavageHammer.MaxCharges = 100;
                    DragonslayerSavageHammer.ProcSpellID = 32183;
                    GameServer.Database.AddObject(DragonslayerSavageHammer);
                }

                if (DragonslayerSavageSlashingGlaiverh == null)
                {
                    DragonslayerSavageSlashingGlaiverh = new ItemTemplate();
                    DragonslayerSavageSlashingGlaiverh.Id_nb = "DragonslayerSavageSlashingGlaiverh"; //Right hand
                    DragonslayerSavageSlashingGlaiverh.Name = "Dragonslayer Savage Slashing Glaive";
                    DragonslayerSavageSlashingGlaiverh.Level = 51;
                    DragonslayerSavageSlashingGlaiverh.Item_Type = 10;
                    DragonslayerSavageSlashingGlaiverh.Model = 3944;
                    DragonslayerSavageSlashingGlaiverh.IsDropable = true;
                    DragonslayerSavageSlashingGlaiverh.IsPickable = true;
                    DragonslayerSavageSlashingGlaiverh.Type_Damage = 2;
                    DragonslayerSavageSlashingGlaiverh.DPS_AF = 165;
                    DragonslayerSavageSlashingGlaiverh.SPD_ABS = 42;
                    DragonslayerSavageSlashingGlaiverh.Object_Type = 25;
                    DragonslayerSavageSlashingGlaiverh.Quality = 100;
                    DragonslayerSavageSlashingGlaiverh.Price = 3500;
                    DragonslayerSavageSlashingGlaiverh.IsTradable = false;
                    DragonslayerSavageSlashingGlaiverh.Weight = 25;
                    DragonslayerSavageSlashingGlaiverh.Bonus = 35;
                    DragonslayerSavageSlashingGlaiverh.MaxCondition = 50000;
                    DragonslayerSavageSlashingGlaiverh.MaxDurability = 50000;
                    DragonslayerSavageSlashingGlaiverh.Condition = 50000;
                    DragonslayerSavageSlashingGlaiverh.Durability = 50000;
                    DragonslayerSavageSlashingGlaiverh.Bonus1 = 4;
                    DragonslayerSavageSlashingGlaiverh.Bonus1Type = (int)eProperty.Skill_HandToHand;
                    DragonslayerSavageSlashingGlaiverh.Bonus2 = 9;
                    DragonslayerSavageSlashingGlaiverh.Bonus2Type = (int)eStat.STR;
                    DragonslayerSavageSlashingGlaiverh.Bonus3 = 9;
                    DragonslayerSavageSlashingGlaiverh.Bonus3Type = (int)eStat.DEX;
                    DragonslayerSavageSlashingGlaiverh.Bonus4 = 4;
                    DragonslayerSavageSlashingGlaiverh.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSavageSlashingGlaiverh.Bonus5 = 4;
                    DragonslayerSavageSlashingGlaiverh.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSavageSlashingGlaiverh.Bonus6 = 5;
                    DragonslayerSavageSlashingGlaiverh.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerSavageSlashingGlaiverh.Bonus7 = 5;
                    DragonslayerSavageSlashingGlaiverh.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerSavageSlashingGlaiverh.SpellID = 32178;
                    DragonslayerSavageSlashingGlaiverh.Charges = 100;
                    DragonslayerSavageSlashingGlaiverh.MaxCharges = 100;
                    DragonslayerSavageSlashingGlaiverh.ProcSpellID = 32183;
                    GameServer.Database.AddObject(DragonslayerSavageSlashingGlaiverh);
                }

                if (DragonslayerSavageSlashingGlaivelh == null)
                {
                    DragonslayerSavageSlashingGlaivelh = new ItemTemplate();
                    DragonslayerSavageSlashingGlaivelh.Id_nb = "DragonslayerSavageSlashingGlaivelh"; //Left hand
                    DragonslayerSavageSlashingGlaivelh.Name = "Dragonslayer Savage Slashing Left Glaive";
                    DragonslayerSavageSlashingGlaivelh.Level = 51;
                    DragonslayerSavageSlashingGlaivelh.Item_Type = 11;
                    DragonslayerSavageSlashingGlaivelh.Hand = 2;
                    DragonslayerSavageSlashingGlaivelh.Model = 3943;
                    DragonslayerSavageSlashingGlaivelh.IsDropable = true;
                    DragonslayerSavageSlashingGlaivelh.IsPickable = true;
                    DragonslayerSavageSlashingGlaivelh.Type_Damage = 2;
                    DragonslayerSavageSlashingGlaivelh.DPS_AF = 165;
                    DragonslayerSavageSlashingGlaivelh.Price = 3500;
                    DragonslayerSavageSlashingGlaivelh.SPD_ABS = 40;
                    DragonslayerSavageSlashingGlaivelh.Object_Type = 25;
                    DragonslayerSavageSlashingGlaivelh.Quality = 100;
                    DragonslayerSavageSlashingGlaivelh.IsTradable = false;
                    DragonslayerSavageSlashingGlaivelh.Weight = 25;
                    DragonslayerSavageSlashingGlaivelh.Bonus = 35;
                    DragonslayerSavageSlashingGlaivelh.MaxCondition = 50000;
                    DragonslayerSavageSlashingGlaivelh.MaxDurability = 50000;
                    DragonslayerSavageSlashingGlaivelh.Condition = 50000;
                    DragonslayerSavageSlashingGlaivelh.Durability = 50000;
                    DragonslayerSavageSlashingGlaivelh.Bonus1 = 4;
                    DragonslayerSavageSlashingGlaivelh.Bonus1Type = (int)eProperty.Skill_Axe;
                    DragonslayerSavageSlashingGlaivelh.Bonus2 = 9;
                    DragonslayerSavageSlashingGlaivelh.Bonus2Type = (int)eStat.STR;
                    DragonslayerSavageSlashingGlaivelh.Bonus3 = 9;
                    DragonslayerSavageSlashingGlaivelh.Bonus3Type = (int)eStat.DEX;
                    DragonslayerSavageSlashingGlaivelh.Bonus4 = 9;
                    DragonslayerSavageSlashingGlaivelh.Bonus4Type = (int)eStat.QUI;
                    DragonslayerSavageSlashingGlaivelh.Bonus5 = 4;
                    DragonslayerSavageSlashingGlaivelh.Bonus5Type = (int)eProperty.MeleeDamage;
                    DragonslayerSavageSlashingGlaivelh.Bonus6 = 4;
                    DragonslayerSavageSlashingGlaivelh.Bonus6Type = (int)eProperty.StyleDamage;
                    DragonslayerSavageSlashingGlaivelh.Bonus7 = 7;
                    DragonslayerSavageSlashingGlaivelh.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSavageSlashingGlaivelh.SpellID = 32178;
                    DragonslayerSavageSlashingGlaivelh.Charges = 100;
                    DragonslayerSavageSlashingGlaivelh.MaxCharges = 100;
                    DragonslayerSavageSlashingGlaivelh.ProcSpellID = 32183;
                    GameServer.Database.AddObject(DragonslayerSavageSlashingGlaivelh);
                }

                if (DragonslayerSavageSword == null)
                {
                    DragonslayerSavageSword = new ItemTemplate();
                    DragonslayerSavageSword.Id_nb = "DragonslayerSavageSword";
                    DragonslayerSavageSword.Name = "Dragonslayer Savage Sword";
                    DragonslayerSavageSword.Level = 51;
                    DragonslayerSavageSword.Item_Type = 10;
                    DragonslayerSavageSword.Model = 3936;
                    DragonslayerSavageSword.IsDropable = true;
                    DragonslayerSavageSword.IsPickable = true;
                    DragonslayerSavageSword.Type_Damage = 2;
                    DragonslayerSavageSword.DPS_AF = 165;
                    DragonslayerSavageSword.Price = 3500;
                    DragonslayerSavageSword.SPD_ABS = 42;
                    DragonslayerSavageSword.Object_Type = 11;
                    DragonslayerSavageSword.Quality = 100;
                    DragonslayerSavageSword.IsTradable = false;
                    DragonslayerSavageSword.Weight = 25;
                    DragonslayerSavageSword.Bonus = 35;
                    DragonslayerSavageSword.MaxCondition = 50000;
                    DragonslayerSavageSword.MaxDurability = 50000;
                    DragonslayerSavageSword.Condition = 50000;
                    DragonslayerSavageSword.Durability = 50000;
                    DragonslayerSavageSword.Bonus1 = 4;
                    DragonslayerSavageSword.Bonus1Type = (int)eProperty.Skill_Sword;
                    DragonslayerSavageSword.Bonus2 = 9;
                    DragonslayerSavageSword.Bonus2Type = (int)eStat.STR;
                    DragonslayerSavageSword.Bonus3 = 9;
                    DragonslayerSavageSword.Bonus3Type = (int)eStat.DEX;
                    DragonslayerSavageSword.Bonus4 = 9;
                    DragonslayerSavageSword.Bonus4Type = (int)eStat.QUI;
                    DragonslayerSavageSword.Bonus5 = 4;
                    DragonslayerSavageSword.Bonus5Type = (int)eProperty.MeleeDamage;
                    DragonslayerSavageSword.Bonus6 = 4;
                    DragonslayerSavageSword.Bonus6Type = (int)eProperty.StyleDamage;
                    DragonslayerSavageSword.Bonus7 = 7;
                    DragonslayerSavageSword.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSavageSword.SpellID = 32178;
                    DragonslayerSavageSword.Charges = 100;
                    DragonslayerSavageSword.MaxCharges = 100;
                    DragonslayerSavageSword.ProcSpellID = 32183;
                    GameServer.Database.AddObject(DragonslayerSavageSword);
                }

                if (DragonslayerSavageThrashingGlaiverh == null)
                {
                    DragonslayerSavageThrashingGlaiverh = new ItemTemplate();
                    DragonslayerSavageThrashingGlaiverh.Id_nb = "DragonslayerSavageThrashingGlaiverh"; //Right hand
                    DragonslayerSavageThrashingGlaiverh.Name = "Dragonslayer Savage Thrashing Glaive";
                    DragonslayerSavageThrashingGlaiverh.Level = 51;
                    DragonslayerSavageThrashingGlaiverh.Item_Type = 10;
                    DragonslayerSavageThrashingGlaiverh.Model = 3948;
                    DragonslayerSavageThrashingGlaiverh.IsDropable = true;
                    DragonslayerSavageThrashingGlaiverh.IsPickable = true;
                    DragonslayerSavageThrashingGlaiverh.Type_Damage = 3;
                    DragonslayerSavageThrashingGlaiverh.DPS_AF = 165;
                    DragonslayerSavageThrashingGlaiverh.SPD_ABS = 42;
                    DragonslayerSavageThrashingGlaiverh.Price = 3500;
                    DragonslayerSavageThrashingGlaiverh.Object_Type = 25;
                    DragonslayerSavageThrashingGlaiverh.Quality = 100;
                    DragonslayerSavageThrashingGlaiverh.IsTradable = false;
                    DragonslayerSavageThrashingGlaiverh.Weight = 25;
                    DragonslayerSavageThrashingGlaiverh.Bonus = 35;
                    DragonslayerSavageThrashingGlaiverh.MaxCondition = 50000;
                    DragonslayerSavageThrashingGlaiverh.MaxDurability = 50000;
                    DragonslayerSavageThrashingGlaiverh.Condition = 50000;
                    DragonslayerSavageThrashingGlaiverh.Durability = 50000;
                    DragonslayerSavageThrashingGlaiverh.Bonus1 = 4;
                    DragonslayerSavageThrashingGlaiverh.Bonus1Type = (int)eProperty.Skill_HandToHand;
                    DragonslayerSavageThrashingGlaiverh.Bonus2 = 9;
                    DragonslayerSavageThrashingGlaiverh.Bonus2Type = (int)eStat.STR;
                    DragonslayerSavageThrashingGlaiverh.Bonus3 = 9;
                    DragonslayerSavageThrashingGlaiverh.Bonus3Type = (int)eStat.DEX;
                    DragonslayerSavageThrashingGlaiverh.Bonus4 = 4;
                    DragonslayerSavageThrashingGlaiverh.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSavageThrashingGlaiverh.Bonus5 = 4;
                    DragonslayerSavageThrashingGlaiverh.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSavageThrashingGlaiverh.Bonus6 = 5;
                    DragonslayerSavageThrashingGlaiverh.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerSavageThrashingGlaiverh.Bonus7 = 5;
                    DragonslayerSavageThrashingGlaiverh.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerSavageThrashingGlaiverh.SpellID = 32178;
                    DragonslayerSavageThrashingGlaiverh.Charges = 100;
                    DragonslayerSavageThrashingGlaiverh.MaxCharges = 100;
                    DragonslayerSavageThrashingGlaiverh.ProcSpellID = 32183;
                    GameServer.Database.AddObject(DragonslayerSavageThrashingGlaiverh);
                }

                if (DragonslayerSavageThrashingGlaivelh == null)
                {
                    DragonslayerSavageThrashingGlaivelh = new ItemTemplate();
                    DragonslayerSavageThrashingGlaivelh.Id_nb = "DragonslayerSavageThrashingGlaivelh"; //Left hand
                    DragonslayerSavageThrashingGlaivelh.Name = "Dragonslayer Savage Thrashing Left Glaive";
                    DragonslayerSavageThrashingGlaivelh.Level = 51;
                    DragonslayerSavageThrashingGlaivelh.Item_Type = 11;
                    DragonslayerSavageThrashingGlaivelh.Hand = 2;
                    DragonslayerSavageThrashingGlaivelh.Model = 3947;
                    DragonslayerSavageThrashingGlaivelh.IsDropable = true;
                    DragonslayerSavageThrashingGlaivelh.IsPickable = true;
                    DragonslayerSavageThrashingGlaivelh.Type_Damage = 3;
                    DragonslayerSavageThrashingGlaivelh.DPS_AF = 165;
                    DragonslayerSavageThrashingGlaivelh.SPD_ABS = 40;
                    DragonslayerSavageThrashingGlaivelh.Object_Type = 25;
                    DragonslayerSavageThrashingGlaivelh.Quality = 100;
                    DragonslayerSavageThrashingGlaivelh.IsTradable = false;
                    DragonslayerSavageThrashingGlaivelh.Weight = 25;
                    DragonslayerSavageThrashingGlaivelh.Bonus = 35;
                    DragonslayerSavageThrashingGlaivelh.Price = 3500;
                    DragonslayerSavageThrashingGlaivelh.MaxCondition = 50000;
                    DragonslayerSavageThrashingGlaivelh.MaxDurability = 50000;
                    DragonslayerSavageThrashingGlaivelh.Condition = 50000;
                    DragonslayerSavageThrashingGlaivelh.Durability = 50000;
                    DragonslayerSavageThrashingGlaivelh.Bonus1 = 4;
                    DragonslayerSavageThrashingGlaivelh.Bonus1Type = (int)eProperty.Skill_HandToHand;
                    DragonslayerSavageThrashingGlaivelh.Bonus2 = 9;
                    DragonslayerSavageThrashingGlaivelh.Bonus2Type = (int)eStat.STR;
                    DragonslayerSavageThrashingGlaivelh.Bonus3 = 9;
                    DragonslayerSavageThrashingGlaivelh.Bonus3Type = (int)eStat.DEX;
                    DragonslayerSavageThrashingGlaivelh.Bonus4 = 4;
                    DragonslayerSavageThrashingGlaivelh.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSavageThrashingGlaivelh.Bonus5 = 4;
                    DragonslayerSavageThrashingGlaivelh.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSavageThrashingGlaivelh.Bonus6 = 5;
                    DragonslayerSavageThrashingGlaivelh.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerSavageThrashingGlaivelh.Bonus7 = 5;
                    DragonslayerSavageThrashingGlaivelh.Bonus7Type = (int)eProperty.DexCapBonus;
                    DragonslayerSavageThrashingGlaivelh.SpellID = 32178;
                    DragonslayerSavageThrashingGlaivelh.Charges = 100;
                    DragonslayerSavageThrashingGlaivelh.MaxCharges = 100;
                    DragonslayerSavageThrashingGlaivelh.ProcSpellID = 32183;
                    GameServer.Database.AddObject(DragonslayerSavageThrashingGlaivelh);
                }

                if (DragonslayerSavageTwohandedAxe == null)
                {
                    DragonslayerSavageTwohandedAxe = new ItemTemplate();
                    DragonslayerSavageTwohandedAxe.Id_nb = "DragonslayerSavageTwohandedAxe";
                    DragonslayerSavageTwohandedAxe.Name = "Dragonslayer Savage Two-handed Axe";
                    DragonslayerSavageTwohandedAxe.Level = 51;
                    DragonslayerSavageTwohandedAxe.Item_Type = 12;
                    DragonslayerSavageTwohandedAxe.Hand = 1;
                    DragonslayerSavageTwohandedAxe.Model = 3923;
                    DragonslayerSavageTwohandedAxe.IsDropable = true;
                    DragonslayerSavageTwohandedAxe.IsPickable = true;
                    DragonslayerSavageTwohandedAxe.Type_Damage = 2;
                    DragonslayerSavageTwohandedAxe.DPS_AF = 165;
                    DragonslayerSavageTwohandedAxe.SPD_ABS = 42;
                    DragonslayerSavageTwohandedAxe.Object_Type = 13;
                    DragonslayerSavageTwohandedAxe.Quality = 100;
                    DragonslayerSavageTwohandedAxe.Price = 3500;
                    DragonslayerSavageTwohandedAxe.IsTradable = false;
                    DragonslayerSavageTwohandedAxe.Weight = 25;
                    DragonslayerSavageTwohandedAxe.Bonus = 35;
                    DragonslayerSavageTwohandedAxe.MaxCondition = 50000;
                    DragonslayerSavageTwohandedAxe.MaxDurability = 50000;
                    DragonslayerSavageTwohandedAxe.Condition = 50000;
                    DragonslayerSavageTwohandedAxe.Durability = 50000;
                    DragonslayerSavageTwohandedAxe.Bonus1 = 4;
                    DragonslayerSavageTwohandedAxe.Bonus1Type = (int)eProperty.Skill_Axe;
                    DragonslayerSavageTwohandedAxe.Bonus2 = 10;
                    DragonslayerSavageTwohandedAxe.Bonus2Type = (int)eStat.DEX;
                    DragonslayerSavageTwohandedAxe.Bonus3 = 10;
                    DragonslayerSavageTwohandedAxe.Bonus3Type = (int)eStat.QUI;
                    DragonslayerSavageTwohandedAxe.Bonus4 = 3;
                    DragonslayerSavageTwohandedAxe.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSavageTwohandedAxe.Bonus5 = 3;
                    DragonslayerSavageTwohandedAxe.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSavageTwohandedAxe.Bonus6 = 3;
                    DragonslayerSavageTwohandedAxe.Bonus6Type = (int)eProperty.MeleeSpeed;
                    DragonslayerSavageTwohandedAxe.Bonus7 = 8;
                    DragonslayerSavageTwohandedAxe.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSavageTwohandedAxe.SpellID = 32178;
                    DragonslayerSavageTwohandedAxe.Charges = 100;
                    DragonslayerSavageTwohandedAxe.MaxCharges = 100;
                    DragonslayerSavageTwohandedAxe.ProcSpellID = 32183;
                    GameServer.Database.AddObject(DragonslayerSavageTwohandedAxe);
                }

                if (DragonslayerSavageTwohandedHammer == null)
                {
                    DragonslayerSavageTwohandedHammer = new ItemTemplate();
                    DragonslayerSavageTwohandedHammer.Id_nb = "DragonslayerSavageTwohandedHammer";
                    DragonslayerSavageTwohandedHammer.Name = "Dragonslayer Savage Two-handed Hammer";
                    DragonslayerSavageTwohandedHammer.Level = 51;
                    DragonslayerSavageTwohandedHammer.Item_Type = 12;
                    DragonslayerSavageTwohandedHammer.Hand = 1;
                    DragonslayerSavageTwohandedHammer.Model = 3922;
                    DragonslayerSavageTwohandedHammer.IsDropable = true;
                    DragonslayerSavageTwohandedHammer.IsPickable = true;
                    DragonslayerSavageTwohandedHammer.Type_Damage = 1;
                    DragonslayerSavageTwohandedHammer.DPS_AF = 165;
                    DragonslayerSavageTwohandedHammer.Price = 3500;
                    DragonslayerSavageTwohandedHammer.SPD_ABS = 42;
                    DragonslayerSavageTwohandedHammer.Object_Type = 12;
                    DragonslayerSavageTwohandedHammer.Quality = 100;
                    DragonslayerSavageTwohandedHammer.IsTradable = false;
                    DragonslayerSavageTwohandedHammer.Weight = 25;
                    DragonslayerSavageTwohandedHammer.Bonus = 35;
                    DragonslayerSavageTwohandedHammer.MaxCondition = 50000;
                    DragonslayerSavageTwohandedHammer.MaxDurability = 50000;
                    DragonslayerSavageTwohandedHammer.Condition = 50000;
                    DragonslayerSavageTwohandedHammer.Durability = 50000;
                    DragonslayerSavageTwohandedHammer.Bonus1 = 4;
                    DragonslayerSavageTwohandedHammer.Bonus1Type = (int)eProperty.Skill_Hammer;
                    DragonslayerSavageTwohandedHammer.Bonus2 = 10;
                    DragonslayerSavageTwohandedHammer.Bonus2Type = (int)eStat.DEX;
                    DragonslayerSavageTwohandedHammer.Bonus3 = 10;
                    DragonslayerSavageTwohandedHammer.Bonus3Type = (int)eStat.QUI;
                    DragonslayerSavageTwohandedHammer.Bonus4 = 3;
                    DragonslayerSavageTwohandedHammer.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSavageTwohandedHammer.Bonus5 = 3;
                    DragonslayerSavageTwohandedHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSavageTwohandedHammer.Bonus6 = 3;
                    DragonslayerSavageTwohandedHammer.Bonus6Type = (int)eProperty.MeleeSpeed;
                    DragonslayerSavageTwohandedHammer.Bonus7 = 8;
                    DragonslayerSavageTwohandedHammer.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSavageTwohandedHammer.SpellID = 32178;
                    DragonslayerSavageTwohandedHammer.Charges = 100;
                    DragonslayerSavageTwohandedHammer.MaxCharges = 100;
                    DragonslayerSavageTwohandedHammer.ProcSpellID = 32183;
                    GameServer.Database.AddObject(DragonslayerSavageTwohandedHammer);
                }

                if (DragonslayerSavageTwohandedSword == null)
                {
                    DragonslayerSavageTwohandedSword = new ItemTemplate();
                    DragonslayerSavageTwohandedSword.Id_nb = "DragonslayerSavageTwohandedSword";
                    DragonslayerSavageTwohandedSword.Name = "Dragonslayer Savage Two-handed Sword";
                    DragonslayerSavageTwohandedSword.Level = 51;
                    DragonslayerSavageTwohandedSword.Item_Type = 12;
                    DragonslayerSavageTwohandedSword.Hand = 1;
                    DragonslayerSavageTwohandedSword.Model = 3919;
                    DragonslayerSavageTwohandedSword.IsDropable = true;
                    DragonslayerSavageTwohandedSword.IsPickable = true;
                    DragonslayerSavageTwohandedSword.Type_Damage = 2;
                    DragonslayerSavageTwohandedSword.DPS_AF = 165;
                    DragonslayerSavageTwohandedSword.SPD_ABS = 42;
                    DragonslayerSavageTwohandedSword.Price = 3500;
                    DragonslayerSavageTwohandedSword.Object_Type = 11;
                    DragonslayerSavageTwohandedSword.Quality = 100;
                    DragonslayerSavageTwohandedSword.IsTradable = false;
                    DragonslayerSavageTwohandedSword.Weight = 25;
                    DragonslayerSavageTwohandedSword.Bonus = 35;
                    DragonslayerSavageTwohandedSword.MaxCondition = 50000;
                    DragonslayerSavageTwohandedSword.MaxDurability = 50000;
                    DragonslayerSavageTwohandedSword.Condition = 50000;
                    DragonslayerSavageTwohandedSword.Durability = 50000;
                    DragonslayerSavageTwohandedSword.Bonus1 = 4;
                    DragonslayerSavageTwohandedSword.Bonus1Type = (int)eProperty.Skill_Sword;
                    DragonslayerSavageTwohandedSword.Bonus2 = 10;
                    DragonslayerSavageTwohandedSword.Bonus2Type = (int)eStat.DEX;
                    DragonslayerSavageTwohandedSword.Bonus3 = 10;
                    DragonslayerSavageTwohandedSword.Bonus3Type = (int)eStat.QUI;
                    DragonslayerSavageTwohandedSword.Bonus4 = 3;
                    DragonslayerSavageTwohandedSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSavageTwohandedSword.Bonus5 = 3;
                    DragonslayerSavageTwohandedSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSavageTwohandedSword.Bonus6 = 3;
                    DragonslayerSavageTwohandedSword.Bonus6Type = (int)eProperty.MeleeSpeed;
                    DragonslayerSavageTwohandedSword.Bonus7 = 8;
                    DragonslayerSavageTwohandedSword.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSavageTwohandedSword.SpellID = 32178;
                    DragonslayerSavageTwohandedSword.Charges = 100;
                    DragonslayerSavageTwohandedSword.MaxCharges = 100;
                    DragonslayerSavageTwohandedSword.ProcSpellID = 32183;
                    GameServer.Database.AddObject(DragonslayerSavageTwohandedSword);
                }

                if (DragonslayerShadowbladeAxe == null)
                {
                    DragonslayerShadowbladeAxe = new ItemTemplate();
                    DragonslayerShadowbladeAxe.Id_nb = "DragonslayerShadowbladeAxe";
                    DragonslayerShadowbladeAxe.Name = "Dragonslayer Shadowblade Left Axe";
                    DragonslayerShadowbladeAxe.Level = 51;
                    DragonslayerShadowbladeAxe.Item_Type = 11;
                    DragonslayerShadowbladeAxe.Hand = 1;
                    DragonslayerShadowbladeAxe.Model = 3941;
                    DragonslayerShadowbladeAxe.IsDropable = true;
                    DragonslayerShadowbladeAxe.IsPickable = true;
                    DragonslayerShadowbladeAxe.Type_Damage = 2;
                    DragonslayerShadowbladeAxe.DPS_AF = 165;
                    DragonslayerShadowbladeAxe.SPD_ABS = 40;
                    DragonslayerShadowbladeAxe.Object_Type = 17;
                    DragonslayerShadowbladeAxe.Price = 3500;
                    DragonslayerShadowbladeAxe.Quality = 100;
                    DragonslayerShadowbladeAxe.IsTradable = false;
                    DragonslayerShadowbladeAxe.Weight = 25;
                    DragonslayerShadowbladeAxe.Bonus = 35;
                    DragonslayerShadowbladeAxe.MaxCondition = 50000;
                    DragonslayerShadowbladeAxe.MaxDurability = 50000;
                    DragonslayerShadowbladeAxe.Condition = 50000;
                    DragonslayerShadowbladeAxe.Durability = 50000;
                    DragonslayerShadowbladeAxe.Bonus1 = 4;
                    DragonslayerShadowbladeAxe.Bonus1Type = (int)eProperty.Skill_Left_Axe;
                    DragonslayerShadowbladeAxe.Bonus2 = 13;
                    DragonslayerShadowbladeAxe.Bonus2Type = (int)eStat.STR;
                    DragonslayerShadowbladeAxe.Bonus3 = 13;
                    DragonslayerShadowbladeAxe.Bonus3Type = (int)eStat.QUI;
                    DragonslayerShadowbladeAxe.Bonus4 = 4;
                    DragonslayerShadowbladeAxe.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerShadowbladeAxe.Bonus5 = 4;
                    DragonslayerShadowbladeAxe.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerShadowbladeAxe.Bonus6 = 7;
                    DragonslayerShadowbladeAxe.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerShadowbladeAxe.SpellID = 32179;
                    DragonslayerShadowbladeAxe.Charges = 100;
                    DragonslayerShadowbladeAxe.MaxCharges = 100;
                    DragonslayerShadowbladeAxe.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerShadowbladeAxe);
                }

                if (DragonslayerShadowbladeHeavyAxe == null)
                {
                    DragonslayerShadowbladeHeavyAxe = new ItemTemplate();
                    DragonslayerShadowbladeHeavyAxe.Id_nb = "DragonslayerShadowbladeHeavyAxe";
                    DragonslayerShadowbladeHeavyAxe.Name = "Dragonslayer Shadowblade Heavy Axe"; // 2 handed axe
                    DragonslayerShadowbladeHeavyAxe.Level = 51;
                    DragonslayerShadowbladeHeavyAxe.Item_Type = 12;
                    DragonslayerShadowbladeHeavyAxe.Hand = 1;
                    DragonslayerShadowbladeHeavyAxe.Model = 3923;
                    DragonslayerShadowbladeHeavyAxe.IsDropable = true;
                    DragonslayerShadowbladeHeavyAxe.IsPickable = true;
                    DragonslayerShadowbladeHeavyAxe.Type_Damage = 2;
                    DragonslayerShadowbladeHeavyAxe.DPS_AF = 165;
                    DragonslayerShadowbladeHeavyAxe.SPD_ABS = 57;
                    DragonslayerShadowbladeHeavyAxe.Price = 3500;
                    DragonslayerShadowbladeHeavyAxe.Object_Type = 13;
                    DragonslayerShadowbladeHeavyAxe.Quality = 100;
                    DragonslayerShadowbladeHeavyAxe.IsTradable = false;
                    DragonslayerShadowbladeHeavyAxe.Weight = 25;
                    DragonslayerShadowbladeHeavyAxe.Bonus = 35;
                    DragonslayerShadowbladeHeavyAxe.MaxCondition = 50000;
                    DragonslayerShadowbladeHeavyAxe.MaxDurability = 50000;
                    DragonslayerShadowbladeHeavyAxe.Condition = 50000;
                    DragonslayerShadowbladeHeavyAxe.Durability = 50000;
                    DragonslayerShadowbladeHeavyAxe.Bonus1 = 4;
                    DragonslayerShadowbladeHeavyAxe.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    DragonslayerShadowbladeHeavyAxe.Bonus2 = 13;
                    DragonslayerShadowbladeHeavyAxe.Bonus2Type = (int)eStat.STR;
                    DragonslayerShadowbladeHeavyAxe.Bonus3 = 13;
                    DragonslayerShadowbladeHeavyAxe.Bonus3Type = (int)eStat.QUI;
                    DragonslayerShadowbladeHeavyAxe.Bonus4 = 4;
                    DragonslayerShadowbladeHeavyAxe.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerShadowbladeHeavyAxe.Bonus5 = 4;
                    DragonslayerShadowbladeHeavyAxe.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerShadowbladeHeavyAxe.Bonus6 = 7;
                    DragonslayerShadowbladeHeavyAxe.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerShadowbladeHeavyAxe.SpellID = 32179;
                    DragonslayerShadowbladeHeavyAxe.Charges = 100;
                    DragonslayerShadowbladeHeavyAxe.MaxCharges = 100;
                    DragonslayerShadowbladeHeavyAxe.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerShadowbladeHeavyAxe);
                }

                if (DragonslayerShadowbladeHeavyAxe2 == null)
                {
                    DragonslayerShadowbladeHeavyAxe2 = new ItemTemplate();
                    DragonslayerShadowbladeHeavyAxe2.Id_nb = "DragonslayerShadowbladeHeavyAxe2";
                    DragonslayerShadowbladeHeavyAxe2.Name = "Dragonslayer Shadowblade Axe"; // 1 hand axe
                    DragonslayerShadowbladeHeavyAxe2.Level = 51;
                    DragonslayerShadowbladeHeavyAxe2.Item_Type = 10;
                    DragonslayerShadowbladeHeavyAxe2.Model = 3942;
                    DragonslayerShadowbladeHeavyAxe2.IsDropable = true;
                    DragonslayerShadowbladeHeavyAxe2.IsPickable = true;
                    DragonslayerShadowbladeHeavyAxe2.Type_Damage = 2;
                    DragonslayerShadowbladeHeavyAxe2.DPS_AF = 165;
                    DragonslayerShadowbladeHeavyAxe2.SPD_ABS = 57;
                    DragonslayerShadowbladeHeavyAxe2.Object_Type = 13;
                    DragonslayerShadowbladeHeavyAxe2.Quality = 100;
                    DragonslayerShadowbladeHeavyAxe2.Price = 3500;
                    DragonslayerShadowbladeHeavyAxe2.IsTradable = false;
                    DragonslayerShadowbladeHeavyAxe2.Weight = 25;
                    DragonslayerShadowbladeHeavyAxe2.Bonus = 35;
                    DragonslayerShadowbladeHeavyAxe2.MaxCondition = 50000;
                    DragonslayerShadowbladeHeavyAxe2.MaxDurability = 50000;
                    DragonslayerShadowbladeHeavyAxe2.Condition = 50000;
                    DragonslayerShadowbladeHeavyAxe2.Durability = 50000;
                    DragonslayerShadowbladeHeavyAxe2.Bonus1 = 4;
                    DragonslayerShadowbladeHeavyAxe2.Bonus1Type = (int)eProperty.Skill_Left_Axe;
                    DragonslayerShadowbladeHeavyAxe2.Bonus2 = 13;
                    DragonslayerShadowbladeHeavyAxe2.Bonus2Type = (int)eStat.STR;
                    DragonslayerShadowbladeHeavyAxe2.Bonus3 = 13;
                    DragonslayerShadowbladeHeavyAxe2.Bonus3Type = (int)eStat.QUI;
                    DragonslayerShadowbladeHeavyAxe2.Bonus4 = 4;
                    DragonslayerShadowbladeHeavyAxe2.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerShadowbladeHeavyAxe2.Bonus5 = 4;
                    DragonslayerShadowbladeHeavyAxe2.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerShadowbladeHeavyAxe2.Bonus6 = 7;
                    DragonslayerShadowbladeHeavyAxe2.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerShadowbladeHeavyAxe2.SpellID = 32179;
                    DragonslayerShadowbladeHeavyAxe2.Charges = 100;
                    DragonslayerShadowbladeHeavyAxe2.MaxCharges = 100;
                    DragonslayerShadowbladeHeavyAxe2.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerShadowbladeHeavyAxe2);
                }

                if (DragonslayerShadowbladeHeavySword == null)
                {
                    DragonslayerShadowbladeHeavySword = new ItemTemplate();
                    DragonslayerShadowbladeHeavySword.Id_nb = "DragonslayerShadowbladeHeavySword";
                    DragonslayerShadowbladeHeavySword.Name = "Dragonslayer Shadowblade Heavy Sword";
                    DragonslayerShadowbladeHeavySword.Level = 51;
                    DragonslayerShadowbladeHeavySword.Item_Type = 12;
                    DragonslayerShadowbladeHeavySword.Hand = 1;
                    DragonslayerShadowbladeHeavySword.Model = 3919;
                    DragonslayerShadowbladeHeavySword.IsDropable = true;
                    DragonslayerShadowbladeHeavySword.IsPickable = true;
                    DragonslayerShadowbladeHeavySword.Type_Damage = 2;
                    DragonslayerShadowbladeHeavySword.DPS_AF = 165;
                    DragonslayerShadowbladeHeavySword.SPD_ABS = 57;
                    DragonslayerShadowbladeHeavySword.Object_Type = 11;
                    DragonslayerShadowbladeHeavySword.Price = 3500;
                    DragonslayerShadowbladeHeavySword.Quality = 100;
                    DragonslayerShadowbladeHeavySword.IsTradable = false;
                    DragonslayerShadowbladeHeavySword.Weight = 25;
                    DragonslayerShadowbladeHeavySword.Bonus = 35;
                    DragonslayerShadowbladeHeavySword.MaxCondition = 50000;
                    DragonslayerShadowbladeHeavySword.MaxDurability = 50000;
                    DragonslayerShadowbladeHeavySword.Condition = 50000;
                    DragonslayerShadowbladeHeavySword.Durability = 50000;
                    DragonslayerShadowbladeHeavySword.Bonus1 = 4;
                    DragonslayerShadowbladeHeavySword.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    DragonslayerShadowbladeHeavySword.Bonus2 = 13;
                    DragonslayerShadowbladeHeavySword.Bonus2Type = (int)eStat.STR;
                    DragonslayerShadowbladeHeavySword.Bonus3 = 13;
                    DragonslayerShadowbladeHeavySword.Bonus3Type = (int)eStat.QUI;
                    DragonslayerShadowbladeHeavySword.Bonus4 = 4;
                    DragonslayerShadowbladeHeavySword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerShadowbladeHeavySword.Bonus5 = 4;
                    DragonslayerShadowbladeHeavySword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerShadowbladeHeavySword.Bonus6 = 7;
                    DragonslayerShadowbladeHeavySword.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerShadowbladeHeavySword.SpellID = 32179;
                    DragonslayerShadowbladeHeavySword.Charges = 100;
                    DragonslayerShadowbladeHeavySword.MaxCharges = 100;
                    DragonslayerShadowbladeHeavySword.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerShadowbladeHeavySword);
                }

                if (DragonslayerShadowbladeSword == null)
                {
                    DragonslayerShadowbladeSword = new ItemTemplate();
                    DragonslayerShadowbladeSword.Id_nb = "DragonslayerShadowbladeSword";
                    DragonslayerShadowbladeSword.Name = "Dragonslayer Shadowblade Sword";
                    DragonslayerShadowbladeSword.Level = 51;
                    DragonslayerShadowbladeSword.Item_Type = 10;
                    DragonslayerShadowbladeSword.Model = 3936;
                    DragonslayerShadowbladeSword.IsDropable = true;
                    DragonslayerShadowbladeSword.IsPickable = true;
                    DragonslayerShadowbladeSword.Type_Damage = 2;
                    DragonslayerShadowbladeSword.Price = 3500;
                    DragonslayerShadowbladeSword.DPS_AF = 165;
                    DragonslayerShadowbladeSword.SPD_ABS = 43;
                    DragonslayerShadowbladeSword.Object_Type = 11;
                    DragonslayerShadowbladeSword.Quality = 100;
                    DragonslayerShadowbladeSword.IsTradable = false;
                    DragonslayerShadowbladeSword.Weight = 25;
                    DragonslayerShadowbladeSword.Bonus = 35;
                    DragonslayerShadowbladeSword.MaxCondition = 50000;
                    DragonslayerShadowbladeSword.MaxDurability = 50000;
                    DragonslayerShadowbladeSword.Condition = 50000;
                    DragonslayerShadowbladeSword.Durability = 50000;
                    DragonslayerShadowbladeSword.Bonus1 = 4;
                    DragonslayerShadowbladeSword.Bonus1Type = (int)eProperty.AllMeleeWeaponSkills;
                    DragonslayerShadowbladeSword.Bonus2 = 13;
                    DragonslayerShadowbladeSword.Bonus2Type = (int)eStat.STR;
                    DragonslayerShadowbladeSword.Bonus3 = 13;
                    DragonslayerShadowbladeSword.Bonus3Type = (int)eStat.QUI;
                    DragonslayerShadowbladeSword.Bonus4 = 4;
                    DragonslayerShadowbladeSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerShadowbladeSword.Bonus5 = 4;
                    DragonslayerShadowbladeSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerShadowbladeSword.Bonus6 = 7;
                    DragonslayerShadowbladeSword.Bonus6Type = (int)eProperty.StrCapBonus;
                    DragonslayerShadowbladeSword.SpellID = 32179;
                    DragonslayerShadowbladeSword.Charges = 100;
                    DragonslayerShadowbladeSword.MaxCharges = 100;
                    DragonslayerShadowbladeSword.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerShadowbladeSword);
                }

                if (DragonslayerSkaldAxe == null)
                {
                    DragonslayerSkaldAxe = new ItemTemplate();
                    DragonslayerSkaldAxe.Id_nb = "DragonslayerSkaldAxe";
                    DragonslayerSkaldAxe.Name = "Dragonslayer Skald Axe";
                    DragonslayerSkaldAxe.Level = 51;
                    DragonslayerSkaldAxe.Item_Type = 10;
                    DragonslayerSkaldAxe.Model = 3942;
                    DragonslayerSkaldAxe.IsDropable = true;
                    DragonslayerSkaldAxe.IsPickable = true;
                    DragonslayerSkaldAxe.Type_Damage = 2;
                    DragonslayerSkaldAxe.DPS_AF = 165;
                    DragonslayerSkaldAxe.SPD_ABS = 43;
                    DragonslayerSkaldAxe.Price = 3500;
                    DragonslayerSkaldAxe.Object_Type = 13;
                    DragonslayerSkaldAxe.Quality = 100;
                    DragonslayerSkaldAxe.IsTradable = false;
                    DragonslayerSkaldAxe.Weight = 25;
                    DragonslayerSkaldAxe.Bonus = 35;
                    DragonslayerSkaldAxe.MaxCondition = 50000;
                    DragonslayerSkaldAxe.MaxDurability = 50000;
                    DragonslayerSkaldAxe.Condition = 50000;
                    DragonslayerSkaldAxe.Durability = 50000;
                    DragonslayerSkaldAxe.Bonus1 = 4;
                    DragonslayerSkaldAxe.Bonus1Type = (int)eProperty.Skill_Axe;
                    DragonslayerSkaldAxe.Bonus2 = 7;
                    DragonslayerSkaldAxe.Bonus2Type = (int)eStat.STR;
                    DragonslayerSkaldAxe.Bonus3 = 7;
                    DragonslayerSkaldAxe.Bonus3Type = (int)eStat.QUI;
                    DragonslayerSkaldAxe.Bonus4 = 3;
                    DragonslayerSkaldAxe.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSkaldAxe.Bonus5 = 3;
                    DragonslayerSkaldAxe.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSkaldAxe.Bonus6 = 3;
                    DragonslayerSkaldAxe.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerSkaldAxe.Bonus7 = 5;
                    DragonslayerSkaldAxe.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSkaldAxe.Bonus8 = 5;
                    DragonslayerSkaldAxe.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerSkaldAxe.SpellID = 32187;
                    DragonslayerSkaldAxe.Charges = 100;
                    DragonslayerSkaldAxe.MaxCharges = 100;
                    DragonslayerSkaldAxe.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerSkaldAxe);
                }

                if (DragonslayerSkaldHammer == null)
                {
                    DragonslayerSkaldHammer = new ItemTemplate();
                    DragonslayerSkaldHammer.Id_nb = "DragonslayerSkaldHammer";
                    DragonslayerSkaldHammer.Name = "Dragonslayer Skald Hammer";
                    DragonslayerSkaldHammer.Level = 51;
                    DragonslayerSkaldHammer.Item_Type = 10;
                    DragonslayerSkaldHammer.Model = 3938;
                    DragonslayerSkaldHammer.IsDropable = true;
                    DragonslayerSkaldHammer.IsPickable = true;
                    DragonslayerSkaldHammer.Type_Damage = 1;
                    DragonslayerSkaldHammer.Price = 3500;
                    DragonslayerSkaldHammer.DPS_AF = 165;
                    DragonslayerSkaldHammer.SPD_ABS = 43;
                    DragonslayerSkaldHammer.Object_Type = 12;
                    DragonslayerSkaldHammer.Quality = 100;
                    DragonslayerSkaldHammer.IsTradable = false;
                    DragonslayerSkaldHammer.Weight = 25;
                    DragonslayerSkaldHammer.Bonus = 35;
                    DragonslayerSkaldHammer.MaxCondition = 50000;
                    DragonslayerSkaldHammer.MaxDurability = 50000;
                    DragonslayerSkaldHammer.Condition = 50000;
                    DragonslayerSkaldHammer.Durability = 50000;
                    DragonslayerSkaldHammer.Bonus1 = 4;
                    DragonslayerSkaldHammer.Bonus1Type = (int)eProperty.Skill_Hammer;
                    DragonslayerSkaldHammer.Bonus2 = 7;
                    DragonslayerSkaldHammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerSkaldHammer.Bonus3 = 7;
                    DragonslayerSkaldHammer.Bonus3Type = (int)eStat.QUI;
                    DragonslayerSkaldHammer.Bonus4 = 3;
                    DragonslayerSkaldHammer.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSkaldHammer.Bonus5 = 3;
                    DragonslayerSkaldHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSkaldHammer.Bonus6 = 3;
                    DragonslayerSkaldHammer.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerSkaldHammer.Bonus7 = 5;
                    DragonslayerSkaldHammer.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSkaldHammer.Bonus8 = 5;
                    DragonslayerSkaldHammer.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerSkaldHammer.SpellID = 32187;
                    DragonslayerSkaldHammer.Charges = 100;
                    DragonslayerSkaldHammer.MaxCharges = 100;
                    DragonslayerSkaldHammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerSkaldHammer);
                }

                if (DragonslayerSkaldSword == null)
                {
                    DragonslayerSkaldSword = new ItemTemplate();
                    DragonslayerSkaldSword.Id_nb = "DragonslayerSkaldSword";
                    DragonslayerSkaldSword.Name = "Dragonslayer Skald Sword";
                    DragonslayerSkaldSword.Level = 51;
                    DragonslayerSkaldSword.Item_Type = 10;
                    DragonslayerSkaldSword.Model = 3936;
                    DragonslayerSkaldSword.IsDropable = true;
                    DragonslayerSkaldSword.IsPickable = true;
                    DragonslayerSkaldSword.Type_Damage = 2;
                    DragonslayerSkaldSword.DPS_AF = 165;
                    DragonslayerSkaldSword.Price = 3500;
                    DragonslayerSkaldSword.SPD_ABS = 43;
                    DragonslayerSkaldSword.Object_Type = 11;
                    DragonslayerSkaldSword.Quality = 100;
                    DragonslayerSkaldSword.IsTradable = false;
                    DragonslayerSkaldSword.Weight = 25;
                    DragonslayerSkaldSword.Bonus = 35;
                    DragonslayerSkaldSword.MaxCondition = 50000;
                    DragonslayerSkaldSword.MaxDurability = 50000;
                    DragonslayerSkaldSword.Condition = 50000;
                    DragonslayerSkaldSword.Durability = 50000;
                    DragonslayerSkaldSword.Bonus1 = 4;
                    DragonslayerSkaldSword.Bonus1Type = (int)eProperty.Skill_Sword;
                    DragonslayerSkaldSword.Bonus2 = 7;
                    DragonslayerSkaldSword.Bonus2Type = (int)eStat.STR;
                    DragonslayerSkaldSword.Bonus3 = 7;
                    DragonslayerSkaldSword.Bonus3Type = (int)eStat.QUI;
                    DragonslayerSkaldSword.Bonus4 = 3;
                    DragonslayerSkaldSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSkaldSword.Bonus5 = 3;
                    DragonslayerSkaldSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSkaldSword.Bonus6 = 3;
                    DragonslayerSkaldSword.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerSkaldSword.Bonus7 = 5;
                    DragonslayerSkaldSword.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSkaldSword.Bonus8 = 5;
                    DragonslayerSkaldSword.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerSkaldSword.SpellID = 32187;
                    DragonslayerSkaldSword.Charges = 100;
                    DragonslayerSkaldSword.MaxCharges = 100;
                    DragonslayerSkaldSword.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerSkaldSword);
                }

                if (DragonslayerSkaldTwohandedAxe == null)
                {
                    DragonslayerSkaldTwohandedAxe = new ItemTemplate();
                    DragonslayerSkaldTwohandedAxe.Id_nb = "DragonslayerSkaldTwohandedAxe";
                    DragonslayerSkaldTwohandedAxe.Name = "Dragonslayer Skald Two-handed Axe";
                    DragonslayerSkaldTwohandedAxe.Level = 51;
                    DragonslayerSkaldTwohandedAxe.Item_Type = 12;
                    DragonslayerSkaldTwohandedAxe.Hand = 1;
                    DragonslayerSkaldTwohandedAxe.Model = 3923;
                    DragonslayerSkaldTwohandedAxe.IsDropable = true;
                    DragonslayerSkaldTwohandedAxe.IsPickable = true;
                    DragonslayerSkaldTwohandedAxe.Type_Damage = 2;
                    DragonslayerSkaldTwohandedAxe.DPS_AF = 165;
                    DragonslayerSkaldTwohandedAxe.SPD_ABS = 57;
                    DragonslayerSkaldTwohandedAxe.Object_Type = 13;
                    DragonslayerSkaldTwohandedAxe.Price = 3500;
                    DragonslayerSkaldTwohandedAxe.Quality = 100;
                    DragonslayerSkaldTwohandedAxe.IsTradable = false;
                    DragonslayerSkaldTwohandedAxe.Weight = 25;
                    DragonslayerSkaldTwohandedAxe.Bonus = 35;
                    DragonslayerSkaldTwohandedAxe.MaxCondition = 50000;
                    DragonslayerSkaldTwohandedAxe.MaxDurability = 50000;
                    DragonslayerSkaldTwohandedAxe.Condition = 50000;
                    DragonslayerSkaldTwohandedAxe.Durability = 50000;
                    DragonslayerSkaldTwohandedAxe.Bonus1 = 4;
                    DragonslayerSkaldTwohandedAxe.Bonus1Type = (int)eProperty.Skill_Axe;
                    DragonslayerSkaldTwohandedAxe.Bonus2 = 7;
                    DragonslayerSkaldTwohandedAxe.Bonus2Type = (int)eStat.STR;
                    DragonslayerSkaldTwohandedAxe.Bonus3 = 7;
                    DragonslayerSkaldTwohandedAxe.Bonus3Type = (int)eStat.QUI;
                    DragonslayerSkaldTwohandedAxe.Bonus4 = 3;
                    DragonslayerSkaldTwohandedAxe.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSkaldTwohandedAxe.Bonus5 = 3;
                    DragonslayerSkaldTwohandedAxe.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSkaldTwohandedAxe.Bonus6 = 3;
                    DragonslayerSkaldTwohandedAxe.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerSkaldTwohandedAxe.Bonus7 = 5;
                    DragonslayerSkaldTwohandedAxe.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSkaldTwohandedAxe.Bonus8 = 5;
                    DragonslayerSkaldTwohandedAxe.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerSkaldTwohandedAxe.SpellID = 32187;
                    DragonslayerSkaldTwohandedAxe.Charges = 100;
                    DragonslayerSkaldTwohandedAxe.MaxCharges = 100;
                    DragonslayerSkaldTwohandedAxe.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerSkaldTwohandedAxe);
                }

                if (DragonslayerSkaldTwohandedHammer == null)
                {
                    DragonslayerSkaldTwohandedHammer = new ItemTemplate();
                    DragonslayerSkaldTwohandedHammer.Id_nb = "DragonslayerSkaldTwohandedHammer";
                    DragonslayerSkaldTwohandedHammer.Name = "Dragonslayer Skald Two-handed Hammer";
                    DragonslayerSkaldTwohandedHammer.Level = 51;
                    DragonslayerSkaldTwohandedHammer.Item_Type = 12;
                    DragonslayerSkaldTwohandedHammer.Hand = 1;
                    DragonslayerSkaldTwohandedHammer.Model = 3922;
                    DragonslayerSkaldTwohandedHammer.IsDropable = true;
                    DragonslayerSkaldTwohandedHammer.IsPickable = true;
                    DragonslayerSkaldTwohandedHammer.Price = 3500;
                    DragonslayerSkaldTwohandedHammer.Type_Damage = 1;
                    DragonslayerSkaldTwohandedHammer.DPS_AF = 165;
                    DragonslayerSkaldTwohandedHammer.SPD_ABS = 57;
                    DragonslayerSkaldTwohandedHammer.Object_Type = 12;
                    DragonslayerSkaldTwohandedHammer.Quality = 100;
                    DragonslayerSkaldTwohandedHammer.IsTradable = false;
                    DragonslayerSkaldTwohandedHammer.Weight = 25;
                    DragonslayerSkaldTwohandedHammer.Bonus = 35;
                    DragonslayerSkaldTwohandedHammer.MaxCondition = 50000;
                    DragonslayerSkaldTwohandedHammer.MaxDurability = 50000;
                    DragonslayerSkaldTwohandedHammer.Condition = 50000;
                    DragonslayerSkaldTwohandedHammer.Durability = 50000;
                    DragonslayerSkaldTwohandedHammer.Bonus1 = 4;
                    DragonslayerSkaldTwohandedHammer.Bonus1Type = (int)eProperty.Skill_Hammer;
                    DragonslayerSkaldTwohandedHammer.Bonus2 = 7;
                    DragonslayerSkaldTwohandedHammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerSkaldTwohandedHammer.Bonus3 = 7;
                    DragonslayerSkaldTwohandedHammer.Bonus3Type = (int)eStat.QUI;
                    DragonslayerSkaldTwohandedHammer.Bonus4 = 3;
                    DragonslayerSkaldTwohandedHammer.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSkaldTwohandedHammer.Bonus5 = 3;
                    DragonslayerSkaldTwohandedHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSkaldTwohandedHammer.Bonus6 = 3;
                    DragonslayerSkaldTwohandedHammer.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerSkaldTwohandedHammer.Bonus7 = 5;
                    DragonslayerSkaldTwohandedHammer.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSkaldTwohandedHammer.Bonus8 = 5;
                    DragonslayerSkaldTwohandedHammer.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerSkaldTwohandedHammer.SpellID = 32187;
                    DragonslayerSkaldTwohandedHammer.Charges = 100;
                    DragonslayerSkaldTwohandedHammer.MaxCharges = 100;
                    DragonslayerSkaldTwohandedHammer.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerSkaldTwohandedHammer);
                }

                if (DragonslayerSkaldTwohandedSword == null)
                {
                    DragonslayerSkaldTwohandedSword = new ItemTemplate();
                    DragonslayerSkaldTwohandedSword.Id_nb = "DragonslayerSkaldTwohandedSword";
                    DragonslayerSkaldTwohandedSword.Name = "Dragonslayer Skald Two-handed Sword";
                    DragonslayerSkaldTwohandedSword.Level = 51;
                    DragonslayerSkaldTwohandedSword.Item_Type = 12;
                    DragonslayerSkaldTwohandedSword.Hand = 1;
                    DragonslayerSkaldTwohandedSword.Model = 3919;
                    DragonslayerSkaldTwohandedSword.IsDropable = true;
                    DragonslayerSkaldTwohandedSword.IsPickable = true;
                    DragonslayerSkaldTwohandedSword.Type_Damage = 2;
                    DragonslayerSkaldTwohandedSword.DPS_AF = 165;
                    DragonslayerSkaldTwohandedSword.Price = 3500;
                    DragonslayerSkaldTwohandedSword.SPD_ABS = 57;
                    DragonslayerSkaldTwohandedSword.Object_Type = 11;
                    DragonslayerSkaldTwohandedSword.Quality = 100;
                    DragonslayerSkaldTwohandedSword.IsTradable = false;
                    DragonslayerSkaldTwohandedSword.Weight = 25;
                    DragonslayerSkaldTwohandedSword.Bonus = 35;
                    DragonslayerSkaldTwohandedSword.MaxCondition = 50000;
                    DragonslayerSkaldTwohandedSword.MaxDurability = 50000;
                    DragonslayerSkaldTwohandedSword.Condition = 50000;
                    DragonslayerSkaldTwohandedSword.Durability = 50000;
                    DragonslayerSkaldTwohandedSword.Bonus1 = 4;
                    DragonslayerSkaldTwohandedSword.Bonus1Type = (int)eProperty.Skill_Sword;
                    DragonslayerSkaldTwohandedSword.Bonus2 = 7;
                    DragonslayerSkaldTwohandedSword.Bonus2Type = (int)eStat.STR;
                    DragonslayerSkaldTwohandedSword.Bonus3 = 7;
                    DragonslayerSkaldTwohandedSword.Bonus3Type = (int)eStat.QUI;
                    DragonslayerSkaldTwohandedSword.Bonus4 = 3;
                    DragonslayerSkaldTwohandedSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerSkaldTwohandedSword.Bonus5 = 3;
                    DragonslayerSkaldTwohandedSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerSkaldTwohandedSword.Bonus6 = 3;
                    DragonslayerSkaldTwohandedSword.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerSkaldTwohandedSword.Bonus7 = 5;
                    DragonslayerSkaldTwohandedSword.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerSkaldTwohandedSword.Bonus8 = 5;
                    DragonslayerSkaldTwohandedSword.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerSkaldTwohandedSword.SpellID = 32187;
                    DragonslayerSkaldTwohandedSword.Charges = 100;
                    DragonslayerSkaldTwohandedSword.MaxCharges = 100;
                    DragonslayerSkaldTwohandedSword.ProcSpellID = 32177;
                    GameServer.Database.AddObject(DragonslayerSkaldTwohandedSword);
                }

                if (DragonslayerThaneAxe == null)
                {
                    DragonslayerThaneAxe = new ItemTemplate();
                    DragonslayerThaneAxe.Id_nb = "DragonslayerThaneAxe";
                    DragonslayerThaneAxe.Name = "Dragonslayer Thane Axe";
                    DragonslayerThaneAxe.Level = 51;
                    DragonslayerThaneAxe.Item_Type = 10;
                    DragonslayerThaneAxe.Model = 3942;
                    DragonslayerThaneAxe.IsDropable = true;
                    DragonslayerThaneAxe.IsPickable = true;
                    DragonslayerThaneAxe.Type_Damage = 2;
                    DragonslayerThaneAxe.DPS_AF = 165;
                    DragonslayerThaneAxe.SPD_ABS = 43;
                    DragonslayerThaneAxe.Price = 3500;
                    DragonslayerThaneAxe.Object_Type = 13;
                    DragonslayerThaneAxe.Quality = 100;
                    DragonslayerThaneAxe.IsTradable = false;
                    DragonslayerThaneAxe.Weight = 25;
                    DragonslayerThaneAxe.Bonus = 35;
                    DragonslayerThaneAxe.MaxCondition = 50000;
                    DragonslayerThaneAxe.MaxDurability = 50000;
                    DragonslayerThaneAxe.Condition = 50000;
                    DragonslayerThaneAxe.Durability = 50000;
                    DragonslayerThaneAxe.Bonus1 = 4;
                    DragonslayerThaneAxe.Bonus1Type = (int)eProperty.Skill_Axe;
                    DragonslayerThaneAxe.Bonus2 = 7;
                    DragonslayerThaneAxe.Bonus2Type = (int)eStat.STR;
                    DragonslayerThaneAxe.Bonus3 = 7;
                    DragonslayerThaneAxe.Bonus3Type = (int)eStat.DEX;
                    DragonslayerThaneAxe.Bonus4 = 3;
                    DragonslayerThaneAxe.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerThaneAxe.Bonus5 = 3;
                    DragonslayerThaneAxe.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerThaneAxe.Bonus6 = 3;
                    DragonslayerThaneAxe.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerThaneAxe.Bonus7 = 5;
                    DragonslayerThaneAxe.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerThaneAxe.Bonus8 = 5;
                    DragonslayerThaneAxe.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerThaneAxe.SpellID = 32178;
                    DragonslayerThaneAxe.Charges = 100;
                    DragonslayerThaneAxe.MaxCharges = 100;
                    DragonslayerThaneAxe.SpellID1 = 32179;
                    DragonslayerThaneAxe.Charges1 = 100;
                    DragonslayerThaneAxe.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerThaneAxe);
                }

                if (DragonslayerThaneHammer == null)
                {
                    DragonslayerThaneHammer = new ItemTemplate();
                    DragonslayerThaneHammer.Id_nb = "DragonslayerThaneHammer";
                    DragonslayerThaneHammer.Name = "Dragonslayer Thane Hammer";
                    DragonslayerThaneHammer.Level = 51;
                    DragonslayerThaneHammer.Item_Type = 10;
                    DragonslayerThaneHammer.Model = 3938;
                    DragonslayerThaneHammer.IsDropable = true;
                    DragonslayerThaneHammer.IsPickable = true;
                    DragonslayerThaneHammer.Type_Damage = 1;
                    DragonslayerThaneHammer.DPS_AF = 165;
                    DragonslayerThaneHammer.Price = 3500;
                    DragonslayerThaneHammer.SPD_ABS = 43;
                    DragonslayerThaneHammer.Object_Type = 12;
                    DragonslayerThaneHammer.Quality = 100;
                    DragonslayerThaneHammer.IsTradable = false;
                    DragonslayerThaneHammer.Weight = 25;
                    DragonslayerThaneHammer.Bonus = 35;
                    DragonslayerThaneHammer.MaxCondition = 50000;
                    DragonslayerThaneHammer.MaxDurability = 50000;
                    DragonslayerThaneHammer.Condition = 50000;
                    DragonslayerThaneHammer.Durability = 50000;
                    DragonslayerThaneHammer.Bonus1 = 4;
                    DragonslayerThaneHammer.Bonus1Type = (int)eProperty.Skill_Hammer;
                    DragonslayerThaneHammer.Bonus2 = 7;
                    DragonslayerThaneHammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerThaneHammer.Bonus3 = 7;
                    DragonslayerThaneHammer.Bonus3Type = (int)eStat.DEX;
                    DragonslayerThaneHammer.Bonus4 = 3;
                    DragonslayerThaneHammer.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerThaneHammer.Bonus5 = 3;
                    DragonslayerThaneHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerThaneHammer.Bonus6 = 3;
                    DragonslayerThaneHammer.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerThaneHammer.Bonus7 = 5;
                    DragonslayerThaneHammer.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerThaneHammer.Bonus8 = 5;
                    DragonslayerThaneHammer.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerThaneHammer.SpellID = 32178;
                    DragonslayerThaneHammer.Charges = 100;
                    DragonslayerThaneHammer.MaxCharges = 100;
                    DragonslayerThaneHammer.SpellID1 = 32179;
                    DragonslayerThaneHammer.Charges1 = 100;
                    DragonslayerThaneHammer.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerThaneHammer);
                }

                if (DragonslayerThaneSword == null)
                {
                    DragonslayerThaneSword = new ItemTemplate();
                    DragonslayerThaneSword.Id_nb = "DragonslayerThaneSword";
                    DragonslayerThaneSword.Name = "Dragonslayer Thane Sword";
                    DragonslayerThaneSword.Level = 51;
                    DragonslayerThaneSword.Item_Type = 10;
                    DragonslayerThaneSword.Model = 3936;
                    DragonslayerThaneSword.IsDropable = true;
                    DragonslayerThaneSword.IsPickable = true;
                    DragonslayerThaneSword.Type_Damage = 2;
                    DragonslayerThaneSword.Price = 3500;
                    DragonslayerThaneSword.DPS_AF = 165;
                    DragonslayerThaneSword.SPD_ABS = 43;
                    DragonslayerThaneSword.Object_Type = 11;
                    DragonslayerThaneSword.Quality = 100;
                    DragonslayerThaneSword.IsTradable = false;
                    DragonslayerThaneSword.Weight = 25;
                    DragonslayerThaneSword.Bonus = 35;
                    DragonslayerThaneSword.MaxCondition = 50000;
                    DragonslayerThaneSword.MaxDurability = 50000;
                    DragonslayerThaneSword.Condition = 50000;
                    DragonslayerThaneSword.Durability = 50000;
                    DragonslayerThaneSword.Bonus1 = 4;
                    DragonslayerThaneSword.Bonus1Type = (int)eProperty.Skill_Sword;
                    DragonslayerThaneSword.Bonus2 = 7;
                    DragonslayerThaneSword.Bonus2Type = (int)eStat.STR;
                    DragonslayerThaneSword.Bonus3 = 7;
                    DragonslayerThaneSword.Bonus3Type = (int)eStat.DEX;
                    DragonslayerThaneSword.Bonus4 = 3;
                    DragonslayerThaneSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerThaneSword.Bonus5 = 3;
                    DragonslayerThaneSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerThaneSword.Bonus6 = 3;
                    DragonslayerThaneSword.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerThaneSword.Bonus7 = 5;
                    DragonslayerThaneSword.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerThaneSword.Bonus8 = 5;
                    DragonslayerThaneSword.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerThaneSword.SpellID = 32178;
                    DragonslayerThaneSword.Charges = 100;
                    DragonslayerThaneSword.MaxCharges = 100;
                    DragonslayerThaneSword.SpellID1 = 32179;
                    DragonslayerThaneSword.Charges1 = 100;
                    DragonslayerThaneSword.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerThaneSword);
                }

                if (DragonslayerThaneTwohandedAxe == null)
                {
                    DragonslayerThaneTwohandedAxe = new ItemTemplate();
                    DragonslayerThaneTwohandedAxe.Id_nb = "DragonslayerThaneTwohandedAxe";
                    DragonslayerThaneTwohandedAxe.Name = "Dragonslayer Thane Two-handed Axe";
                    DragonslayerThaneTwohandedAxe.Level = 51;
                    DragonslayerThaneTwohandedAxe.Item_Type = 12;
                    DragonslayerThaneTwohandedAxe.Hand = 1;
                    DragonslayerThaneTwohandedAxe.Model = 3959;
                    DragonslayerThaneTwohandedAxe.IsDropable = true;
                    DragonslayerThaneTwohandedAxe.IsPickable = true;
                    DragonslayerThaneTwohandedAxe.Type_Damage = 2;
                    DragonslayerThaneTwohandedAxe.DPS_AF = 165;
                    DragonslayerThaneTwohandedAxe.SPD_ABS = 57;
                    DragonslayerThaneTwohandedAxe.Object_Type = 13;
                    DragonslayerThaneTwohandedAxe.Quality = 100;
                    DragonslayerThaneTwohandedAxe.Price = 3500;
                    DragonslayerThaneTwohandedAxe.IsTradable = false;
                    DragonslayerThaneTwohandedAxe.Weight = 25;
                    DragonslayerThaneTwohandedAxe.Bonus = 35;
                    DragonslayerThaneTwohandedAxe.MaxCondition = 50000;
                    DragonslayerThaneTwohandedAxe.MaxDurability = 50000;
                    DragonslayerThaneTwohandedAxe.Condition = 50000;
                    DragonslayerThaneTwohandedAxe.Durability = 50000;
                    DragonslayerThaneTwohandedAxe.Bonus1 = 4;
                    DragonslayerThaneTwohandedAxe.Bonus1Type = (int)eProperty.Skill_Axe;
                    DragonslayerThaneTwohandedAxe.Bonus2 = 7;
                    DragonslayerThaneTwohandedAxe.Bonus2Type = (int)eStat.STR;
                    DragonslayerThaneTwohandedAxe.Bonus3 = 7;
                    DragonslayerThaneTwohandedAxe.Bonus3Type = (int)eStat.DEX;
                    DragonslayerThaneTwohandedAxe.Bonus4 = 3;
                    DragonslayerThaneTwohandedAxe.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerThaneTwohandedAxe.Bonus5 = 3;
                    DragonslayerThaneTwohandedAxe.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerThaneTwohandedAxe.Bonus6 = 3;
                    DragonslayerThaneTwohandedAxe.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerThaneTwohandedAxe.Bonus7 = 5;
                    DragonslayerThaneTwohandedAxe.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerThaneTwohandedAxe.Bonus8 = 5;
                    DragonslayerThaneTwohandedAxe.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerThaneTwohandedAxe.SpellID = 32178;
                    DragonslayerThaneTwohandedAxe.Charges = 100;
                    DragonslayerThaneTwohandedAxe.MaxCharges = 100;
                    DragonslayerThaneTwohandedAxe.SpellID1 = 32179;
                    DragonslayerThaneTwohandedAxe.Charges1 = 100;
                    DragonslayerThaneTwohandedAxe.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerThaneTwohandedAxe);
                }

                if (DragonslayerThaneTwohandedHammer == null)
                {
                    DragonslayerThaneTwohandedHammer = new ItemTemplate();
                    DragonslayerThaneTwohandedHammer.Id_nb = "DragonslayerThaneTwohandedHammer";
                    DragonslayerThaneTwohandedHammer.Name = "Dragonslayer Thane Two-handed Hammer";
                    DragonslayerThaneTwohandedHammer.Level = 51;
                    DragonslayerThaneTwohandedHammer.Item_Type = 12;
                    DragonslayerThaneTwohandedHammer.Hand = 1;
                    DragonslayerThaneTwohandedHammer.Model = 3958;
                    DragonslayerThaneTwohandedHammer.IsDropable = true;
                    DragonslayerThaneTwohandedHammer.IsPickable = true;
                    DragonslayerThaneTwohandedHammer.Type_Damage = 1;
                    DragonslayerThaneTwohandedHammer.DPS_AF = 165;
                    DragonslayerThaneTwohandedHammer.SPD_ABS = 57;
                    DragonslayerThaneTwohandedHammer.Object_Type = 12;
                    DragonslayerThaneTwohandedHammer.Quality = 100;
                    DragonslayerThaneTwohandedHammer.IsTradable = false;
                    DragonslayerThaneTwohandedHammer.Weight = 25;
                    DragonslayerThaneTwohandedHammer.Price = 3500;
                    DragonslayerThaneTwohandedHammer.Bonus = 35;
                    DragonslayerThaneTwohandedHammer.MaxCondition = 50000;
                    DragonslayerThaneTwohandedHammer.MaxDurability = 50000;
                    DragonslayerThaneTwohandedHammer.Condition = 50000;
                    DragonslayerThaneTwohandedHammer.Durability = 50000;
                    DragonslayerThaneTwohandedHammer.Bonus1 = 4;
                    DragonslayerThaneTwohandedHammer.Bonus1Type = (int)eProperty.Skill_Hammer;
                    DragonslayerThaneTwohandedHammer.Bonus2 = 7;
                    DragonslayerThaneTwohandedHammer.Bonus2Type = (int)eStat.STR;
                    DragonslayerThaneTwohandedHammer.Bonus3 = 7;
                    DragonslayerThaneTwohandedHammer.Bonus3Type = (int)eStat.DEX;
                    DragonslayerThaneTwohandedHammer.Bonus4 = 3;
                    DragonslayerThaneTwohandedHammer.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerThaneTwohandedHammer.Bonus5 = 3;
                    DragonslayerThaneTwohandedHammer.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerThaneTwohandedHammer.Bonus6 = 3;
                    DragonslayerThaneTwohandedHammer.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerThaneTwohandedHammer.Bonus7 = 5;
                    DragonslayerThaneTwohandedHammer.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerThaneTwohandedHammer.Bonus8 = 5;
                    DragonslayerThaneTwohandedHammer.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerThaneTwohandedHammer.SpellID = 32178;
                    DragonslayerThaneTwohandedHammer.Charges = 100;
                    DragonslayerThaneTwohandedHammer.MaxCharges = 100;
                    DragonslayerThaneTwohandedHammer.SpellID1 = 32179;
                    DragonslayerThaneTwohandedHammer.Charges1 = 100;
                    DragonslayerThaneTwohandedHammer.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerThaneTwohandedHammer);
                }

                if (DragonslayerThaneTwohandedSword == null)
                {
                    DragonslayerThaneTwohandedSword = new ItemTemplate();
                    DragonslayerThaneTwohandedSword.Id_nb = "DragonslayerThaneTwohandedSword";
                    DragonslayerThaneTwohandedSword.Name = "Dragonslayer Thane Two-handed Sword";
                    DragonslayerThaneTwohandedSword.Level = 51;
                    DragonslayerThaneTwohandedSword.Item_Type = 12;
                    DragonslayerThaneTwohandedSword.Hand = 1;
                    DragonslayerThaneTwohandedSword.Model = 3955;
                    DragonslayerThaneTwohandedSword.IsDropable = true;
                    DragonslayerThaneTwohandedSword.IsPickable = true;
                    DragonslayerThaneTwohandedSword.Type_Damage = 2;
                    DragonslayerThaneTwohandedSword.DPS_AF = 165;
                    DragonslayerThaneTwohandedSword.SPD_ABS = 57;
                    DragonslayerThaneTwohandedSword.Object_Type = 11;
                    DragonslayerThaneTwohandedSword.Quality = 100;
                    DragonslayerThaneTwohandedSword.Price = 3500;
                    DragonslayerThaneTwohandedSword.IsTradable = false;
                    DragonslayerThaneTwohandedSword.Weight = 25;
                    DragonslayerThaneTwohandedSword.Bonus = 35;
                    DragonslayerThaneTwohandedSword.MaxCondition = 50000;
                    DragonslayerThaneTwohandedSword.MaxDurability = 50000;
                    DragonslayerThaneTwohandedSword.Condition = 50000;
                    DragonslayerThaneTwohandedSword.Durability = 50000;
                    DragonslayerThaneTwohandedSword.Bonus1 = 4;
                    DragonslayerThaneTwohandedSword.Bonus1Type = (int)eProperty.Skill_Sword;
                    DragonslayerThaneTwohandedSword.Bonus2 = 7;
                    DragonslayerThaneTwohandedSword.Bonus2Type = (int)eStat.STR;
                    DragonslayerThaneTwohandedSword.Bonus3 = 7;
                    DragonslayerThaneTwohandedSword.Bonus3Type = (int)eStat.DEX;
                    DragonslayerThaneTwohandedSword.Bonus4 = 3;
                    DragonslayerThaneTwohandedSword.Bonus4Type = (int)eProperty.MeleeDamage;
                    DragonslayerThaneTwohandedSword.Bonus5 = 5;
                    DragonslayerThaneTwohandedSword.Bonus5Type = (int)eProperty.StyleDamage;
                    DragonslayerThaneTwohandedSword.Bonus6 = 3;
                    DragonslayerThaneTwohandedSword.Bonus6Type = (int)eProperty.SpellDamage;
                    DragonslayerThaneTwohandedSword.Bonus7 = 3;
                    DragonslayerThaneTwohandedSword.Bonus7Type = (int)eProperty.StrCapBonus;
                    DragonslayerThaneTwohandedSword.Bonus8 = 5;
                    DragonslayerThaneTwohandedSword.Bonus8Type = (int)eProperty.AcuCapBonus;
                    DragonslayerThaneTwohandedSword.SpellID = 32178;
                    DragonslayerThaneTwohandedSword.Charges = 100;
                    DragonslayerThaneTwohandedSword.MaxCharges = 100;
                    DragonslayerThaneTwohandedSword.SpellID1 = 32179;
                    DragonslayerThaneTwohandedSword.Charges1 = 100;
                    DragonslayerThaneTwohandedSword.MaxCharges1 = 100;
                    GameServer.Database.AddObject(DragonslayerThaneTwohandedSword);
                }

                #endregion DragonslayerWeapons
                #region Dragonsworn Badge
                if (dragonswornbadge == null)
                {
                    dragonswornbadge = new ItemTemplate();
                    dragonswornbadge.Id_nb = "dragonswornbadge";
                    dragonswornbadge.Name = "Dragonsworn Badge";
                    dragonswornbadge.Level = 1;
                    dragonswornbadge.Item_Type = 40;
                    dragonswornbadge.Model = 509;
                    dragonswornbadge.IsDropable = true;
                    dragonswornbadge.IsPickable = true;
                    dragonswornbadge.Object_Type = 0;
                    dragonswornbadge.Quality = 0;
                    dragonswornbadge.Price = 50;
                    dragonswornbadge.Weight = 0;
                    dragonswornbadge.Bonus = 0;
                    dragonswornbadge.MaxCount = 100;
                    dragonswornbadge.PackSize = 0;
                    dragonswornbadge.MaxCondition = 50000;
                    dragonswornbadge.MaxDurability = 50000;
                    dragonswornbadge.Condition = 50000;
                    dragonswornbadge.Durability = 50000;
                    GameServer.Database.AddObject(dragonswornbadge);
                }

                #endregion Dragonsworn Badge
                #region MerchantItems
                ItemTemplate item = null;

                MerchantItem m_item = null;
                m_item = GameServer.Database.SelectObject<MerchantItem>("ItemListID='AlbionDragonWeapons'");
                if (m_item == null)
                {
                    #region Albion Merchant Items

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ArmsmanDragonslayerBlade";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 0;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ArmsmanDragonslayerEdge";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 1;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ArmsmanDragonslayerMace";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 2;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ArmsmanDragonslayerArchMace";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 3;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ArmsmanDragonslayerFlamberge";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 4;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ArmsmanDragonslayerHalberd";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 5;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ArmsmanDragonslayerLance";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 6;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ArmsmanDragonslayerPike";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 7;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ArmsmanDragonslayerMattock";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 8;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "FriarDragonslayerQuarterStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 10;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "FriarDragonslayerMace";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 11;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerCabalistStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 13;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerNecromancerStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 14;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSorcererStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 15;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerTheurgistStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 16;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerWizardStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 17;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ClericDragonslayerMace";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 0;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "HereticDragonslayerBarbedChain";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 2;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "HereticDragonslayerFlail";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 3;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "HereticDragonslayerMace";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 4;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ReaverDragonslayerBlade";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 6;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ReaverDragonslayerEdge";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 7;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ReaverDragonslayerMace";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 8;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ReaverDragonslayerBarbedChain";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 9;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ReaverDragonslayerFlail";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 10;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "PaladinDragonslayerBlade";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 12;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "PaladinDragonslayerEdge";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 13;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "PaladinDragonslayerMace";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 14;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "PaladinDragonslayerGreatEdge";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 15;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "PaladinDragonslayerGreatHammer";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 16;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "PaladinDragonslayerGreatSword";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 17;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ScoutDragonslayerBlade";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 0;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ScoutDragonslayerBow";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 1;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "ScoutDragonslayerEdge";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 2;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "MinstrelDragonslayerEdge";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 4;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "MinstrelDragonslayerBlade";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 5;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "MinstrelDragonslayerHarp";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 6;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "MercenaryDragonslayerLaevusMace";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 8;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "MercenaryDragonslayerLaevusEdge";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 9;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "MercenaryDragonslayerLaevusBlade";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 10;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "MercenaryDragonslayerMace";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 11;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "MercenaryDragonslayerEdge";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 12;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "MercenaryDragonslayerBlade";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 13;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "InfiltratorDragonslayerBlade";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 15;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "InfiltratorDragonslayerEdge";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 16;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "InfiltratorDragonslayerLaevusBlade";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 17;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "AlbionDragonWeapons";
                    m_item.ItemTemplateID = "InfiltratorDragonslayerLaevusEdge";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 18;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    #endregion Albion Merchant Items
                }
                item = null;

                m_item = GameServer.Database.SelectObject<MerchantItem>("ItemListID='MidgardDragonWeapons'");
                if (m_item == null)
                {
                    #region Midgard Merchant Items

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBonedancerStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 0;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerRunemasterStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 1;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSpiritmasterStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 2;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerWarlockStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 3;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerWarriorAxe";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 5;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerWarriorTwohandedAxe";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 6;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerWarriorSword";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 7;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerWarriorTwohandedSword";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 8;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerWarriorHammer";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 9;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerWarriorTwohandedHammer";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 10;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerValkyrieSword";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 12;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerValkyrieTwohandedSword";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 13;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerValkyrieSlashingSpear";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 14;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerValkyrieThrustingSpear";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 15;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHealerHammer";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 17;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHealerTwohandedHammer";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 18;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerShamanHammer";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 0;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerShamanTwohandedHammer";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 1;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBerserkerAxelh";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 3;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBerserkerAxerh";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 4;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBerserkerHammer";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 5;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBerserkerSword";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 6;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBerserkerTwohandedAxe";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 7;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBerserkerTwohandedHammer";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 8;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBerserkerTwohandedSword";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 9;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerCompoundBow";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 11;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHunterSlashingSpear";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 12;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHunterSpear";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 13;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHunterSword";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 14;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHunterTwohandedSword";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 15;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSavageAxe";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 0;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSavageHammer";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 1;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSavageSlashingGlaiverh";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 2;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSavageSlashingGlaivelh";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 3;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSavageSword";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 4;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSavageThrashingGlaiverh";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 5;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSavageThrashingGlaivelh";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 6;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSavageTwohandedAxe";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 7;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSavageTwohandedHammer";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 8;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSavageTwohandedSword";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 9;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerShadowbladeAxe";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 11;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerShadowbladeHeavyAxe";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 12;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerShadowbladeHeavyAxe2";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 13;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerShadowbladeHeavySword";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 14;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerShadowbladeSword";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 15;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSkaldAxe";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 0;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSkaldHammer";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 1;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSkaldSword";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 2;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSkaldTwohandedAxe";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 3;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSkaldTwohandedHammer";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 4;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerSkaldTwohandedSword";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 5;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerThaneAxe";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 7;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerThaneHammer";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 8;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerThaneSword";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 9;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerThaneTwohandedAxe";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 10;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerThaneTwohandedHammer";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 11;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "MidgardDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerThaneTwohandedSword";
                    m_item.PageNumber = 3;
                    m_item.SlotPosition = 12;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    #endregion Midgard Merchant Items
                }
                item = null;

                m_item = GameServer.Database.SelectObject<MerchantItem>("ItemListID='HiberniaDragonWeapons'");
                if (m_item == null)
                {
                    #region Hibernia Merchant Items

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerAnimistStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 0;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBainsheeStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 1;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerEldritchStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 2;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerEnchanterStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 3;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerMentalistStaff";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 4;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerValewalkerScythe";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 6;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "VampiirDragonslayerFuarSteel";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 8;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBardHammer";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 10;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBardBlade";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 11;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBardHarp";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 12;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerDruidBlade";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 14;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerDruidHammer";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 15;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerWardenBlade";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 17;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerWardenHammer";
                    m_item.PageNumber = 0;
                    m_item.SlotPosition = 18;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "BlademasterDragonslayerFuarBlade";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 0;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "BlademasterDragonslayerFuarHammer";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 1;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "BlademasterDragonslayerFuarSteel";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 2;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBlademasterBlade";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 3;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBlademasterHammer";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 4;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerBlademasterSteel";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 5;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerChampionBlade";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 7;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerChampionHammer";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 8;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerChampionSteel";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 9;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerChampionWarblade";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 10;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerChampionWarhammer";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 11;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHeroBlade";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 13;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHeroHammer";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 14;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHeroSpear";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 15;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHeroSteel";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 16;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHeroWarblade";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 17;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerHeroWarhammer";
                    m_item.PageNumber = 1;
                    m_item.SlotPosition = 18;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerNightshadeBlade";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 0;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerNightshadeSteel";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 1;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "NightshadeDragonslayerFuarBlade";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 2;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "NightshadeDragonslayerFuarSteel";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 3;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerRangerBlade";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 5;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerRangerSteel";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 6;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "DragonslayerRecurveBow";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 7;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "RangerDragonslayerFuarBlade";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 8;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    m_item = new MerchantItem();
                    m_item.ItemListID = "HiberniaDragonWeapons";
                    m_item.ItemTemplateID = "RangerDragonslayerFuarSteel";
                    m_item.PageNumber = 2;
                    m_item.SlotPosition = 9;
                    m_item.AllowAdd = true;
                    GameServer.Database.AddObject(m_item);
                    item = null;

                    #endregion Hibernia Merchant Items
                }
                item = null;
                #endregion

                log.Info("Dragonslayer weapons initialised :");
            }
            catch (Exception ex)
            {
                log.Error("[ScriptLoadedEvent] failed Initialization: ", ex);
            }
        }
    }
}

