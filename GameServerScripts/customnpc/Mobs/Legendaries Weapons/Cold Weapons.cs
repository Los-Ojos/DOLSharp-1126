/* ----------------------
 * Legendary Cold Weapons
 * ----------------------
 * Total Weapons: 43
 * 
 * Albion Weapons: 16
 * Midgard Weapons: 14
 * Hibernia Weapons: 13
 * ----------------------
*/

using System;
using System.Reflection;

using DOL.GS.PacketHandler;
using DOL.Database;
using DOL.Events;

using log4net;

namespace DOL.GS.Items
{
    public class LegendaryColdWeapons
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            ItemTemplate item = null;


            // Albion Weapons

            #region benthic_glaive

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_glaive");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_glaive";
                item.Name = "Benthic Glaive";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.PolearmWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1936;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_glaive

            #region benthic_rapier

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_rapier");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_rapier";
                item.Name = "Benthic Rapier";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 39;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.ThrustWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 18;
                item.Model = 1960;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_rapier

            #region benthic_falchion

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_falchion");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_falchion";
                item.Name = "Benthic Falchion";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.SlashingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 19;
                item.Model = 1948;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_falchion

            #region benthic_long_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_long_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_long_bow";
                item.Name = "Benthic Long Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Longbow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 1912;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllArcherySkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_long_bow

            #region benthic_stiletto

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_stiletto");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_stiletto";
                item.Name = "Benthic Stiletto";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.ThrustWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1956;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_stiletto

            #region benthic_war_pick

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_war_pick");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_war_pick";
                item.Name = "Benthic War Pick";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1900;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_war_pick

            #region benthic_pick_flail

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_pick_flail");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_pick_flail";
                item.Name = "Benthic Pick Flail";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 36;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.Flexible;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1928;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_pick_flail

            #region benthic_coffin_mace

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_coffin_mace");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_coffin_mace";
                item.Name = "Benthic Coffin Mace";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.CrushingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1920;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_coffin_mace

            #region benthic_great_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_great_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_great_sword";
                item.Name = "Benthic Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1904;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_great_sword

            #region benthic_magus_staff

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_magus_staff");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_magus_staff";
                item.Name = "Benthic Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Crush;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 40;
                item.Model = 1968;
                item.Bonus1 = 30;
                item.Bonus2 = 10;
                item.Bonus3 = 10;
                item.Bonus4 = 50;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.AllFocusLevels;
                item.Bonus5Type = (int)eProperty.AllMagicSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 10;
                item.MaxCharges = 10;
                item.SpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_magus_staff

            #region benthic_bishops_mace

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_bishops_mace");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_bishops_mace";
                item.Name = "Benthic Bishops Mace";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 38;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.CrushingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1916;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_bishops_mace

            #region benthic_great_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_great_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_great_hammer";
                item.Name = "Benthic Great Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1896;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_great_hammer

            #region benthic_quarterstaff

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_quarterstaff");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_quarterstaff";
                item.Name = "Benthic Quarterstaff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 42;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Crush;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1952;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_quarterstaff

            #region benthic_spiked_flail

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_spiked_flail");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_spiked_flail";
                item.Name = "Benthic Spiked Flail";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 39;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Flexible;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 30;
                item.Model = 1924;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_spiked_flail

            #region benthic_military_fork

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_military_fork");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_military_fork";
                item.Name = "Benthic Military Fork";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.PolearmWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1932;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_military_fork

            #region benthic_lucerne_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_lucerne_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_lucerne_hammer";
                item.Name = "Benthic Lucerne Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 56;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.PolearmWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1940;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_lucerne_hammer



            // Midgard Weapons

            #region benthic_war_axe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_war_axe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_war_axe";
                item.Name = "Benthic War Axe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 26;
                item.Hand = 2;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2032;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_war_axe

            #region benthic_battleaxe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_battleaxe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_battleaxe";
                item.Name = "Benthic Battleaxe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2052;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_battleaxe

            #region benthic_moon_claw

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_moon_claw");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_moon_claw";
                item.Name = "Benthic Moon Claw";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 38;
                item.Hand = 2;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.HandToHand;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2024;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_moon_claw

            #region benthic_great_club

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_great_club");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_great_club";
                item.Name = "Benthic Great Club";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 54;
                item.Hand = 1;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Hammer;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2056;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_great_club

            #region benthic_war_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_war_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_war_hammer";
                item.Name = "Benthic War Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 36;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Hammer;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2044;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_war_hammer

            #region benthic_fang_greave

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_fang_greave");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_fang_greave";
                item.Name = "Benthic Fang Greave";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Hand = 2;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.HandToHand;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2028;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_fang_greave

            #region benthic_long_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_long_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_long_sword2";
                item.Name = "Benthic Long Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2036;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_long_sword2

            #region benthic_great_sword3

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_great_sword3");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_great_sword3";
                item.Name = "Benthic Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2060;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_great_sword3

            #region benthic_hooked_spear

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_hooked_spear");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_hooked_spear";
                item.Name = "Benthic Hooked Spear";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Spear;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2048;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_hooked_spear

            #region benthic_magus_staff2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_magus_staff2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_magus_staff2";
                item.Name = "Benthic Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 45;
                item.Hand = 3;
                item.Type_Damage = (int)eDamageType.Crush;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1968;
                item.Bonus = 35;
                item.Bonus1 = 30;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 50;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.AllFocusLevels;
                item.Bonus5Type = (int)eProperty.AllMagicSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_magus_staff2

            #region benthic_magus_staff3

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_magus_staff3");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_magus_staff3";
                item.Name = "Benthic Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Crush;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 40;
                item.Model = 2068;
                item.Bonus1 = 30;
                item.Bonus2 = 10;
                item.Bonus3 = 10;
                item.Bonus4 = 50;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.AllFocusLevels;
                item.Bonus5Type = (int)eProperty.AllMagicSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 10;
                item.MaxCharges = 10;
                item.SpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_magus_staff3

            #region benthic_battle_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_battle_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_battle_hammer";
                item.Name = "Benthic Battle Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Hammer;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2044;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_battle_hammer

            #region benthic_composite_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_composite_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_composite_bow";
                item.Name = "Benthic Composite Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 45;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.CompositeBow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 2064;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllArcherySkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_composite_bow

            #region benthic_double_bladed_axe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_double_bladed_axe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_double_bladed_axe";
                item.Name = "Benthic Double Bladed Axe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2040;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_double_bladed_axe



            // Hibernia Weapons

            #region benthic_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_adze";
                item.Name = "Benthic Adze";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.Piercing;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2012;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_adze

            #region benthic_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_hammer";
                item.Name = "Benthic Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.Blunt;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1992;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_hammer

            #region benthic_war_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_war_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_war_adze";
                item.Name = "Benthic War Adze";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 39;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Piercing;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 24;
                item.Model = 2016;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_war_adze

            #region benthic_long_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_long_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_long_sword";
                item.Name = "Benthic Long Sword";
                item.Level = 51;
                item.Durability = 500000;
                item.MaxDurability = 500000;
                item.Condition = 500000;
                item.MaxCondition = 500000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Blades;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Color = 45;
                item.Weight = 10;
                item.Model = 1972;
                item.Bonus = 35;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_long_sword

            #region benthic_war_scythe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_war_scythe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_war_scythe";
                item.Name = "Benthic War Scythe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Scythe;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2004;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_war_scythe

            #region benthic_battle_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_battle_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_battle_adze";
                item.Name = "Benthic Battle Adze";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Piercing;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 24;
                item.Model = 2016;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_battle_adze

            #region benthic_dire_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_dire_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_dire_hammer";
                item.Name = "Benthic Dire Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 42;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.Blunt;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1988;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_dire_hammer

            #region benthic_recurve_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_recurve_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_recurve_bow";
                item.Name = "Benthic Recurve Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.RecurvedBow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 1996;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllArcherySkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_recurve_bow

            #region benthic_short_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_short_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_short_sword";
                item.Name = "Benthic Short Sword";
                item.Level = 51;
                item.Durability = 500000;
                item.MaxDurability = 500000;
                item.Condition = 500000;
                item.MaxCondition = 500000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Blades;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Color = 45;
                item.Weight = 10;
                item.Model = 1944;
                item.Bonus = 35;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_short_sword

            #region benthic_battle_spear

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_battle_spear");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_battle_spear";
                item.Name = "Benthic Battle Spear";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 56;
                item.Hand = 1;
                item.Type_Damage = 11;
                item.Object_Type = (int)eObjectType.Spear;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2008;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_battle_spear

            #region benthic_great_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_great_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_great_sword2";
                item.Name = "Benthic Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.LargeWeapons;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1984;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_great_sword2

            #region benthic_short_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_short_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_short_sword2";
                item.Name = "Benthic Short Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 32;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.Blades;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1976;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_short_sword2

            #region benthic_great_hammer2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("benthic_great_hammer2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "benthic_great_hammer2";
                item.Name = "Benthic Great Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Cold;
                item.Object_Type = (int)eObjectType.LargeWeapons;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1980;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Heat;
                item.Bonus3Type = (int)eProperty.Resist_Cold;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32050;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion benthic_great_hammer2



            MerchantItem m_item = null;
            m_item = (MerchantItem)GameServer.Database.SelectObject<MerchantItem>("ItemListID='LegendaryColdWeapons'");
            if (m_item == null)
            {
                #region Merchant Items

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_rapier";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_falchion";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_stiletto";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_pick_flail";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_coffin_mace";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_bishops_mace";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_spiked_flail";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_glaive";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_war_pick";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_great_sword";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_magus_staff";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_great_hammer";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_quarterstaff";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_military_fork";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_lucerne_hammer";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_long_bow";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_war_hammer";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_long_sword2";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_double_bladed_axe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_war_axe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_moon_claw";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_fang_greave";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_battle_hammer";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_battleaxe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_great_club";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_great_sword3";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_hooked_spear";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_magus_staff2";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_magus_staff3";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_composite_bow";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_hammer";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_war_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_long_sword";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_dire_hammer";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_short_sword2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_battle_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_short_sword";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_war_scythe";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_battle_spear";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_great_sword2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_great_hammer2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryColdWeapons";
                m_item.ItemTemplateID = "benthic_recurve_bow";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                #endregion Merchant Items
            }
            item = null;
        }
    }
}