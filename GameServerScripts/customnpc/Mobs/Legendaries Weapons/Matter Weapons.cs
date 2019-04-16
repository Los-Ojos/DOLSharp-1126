/* ------------------------
 * Legendary Matter Weapons
 * ------------------------
 * Total Weapons: 42
 * 
 * Albion Weapons: 17
 * Midgard Weapons: 12
 * Hibernia Weapons: 13
 * ------------------------
*/

using System;
using System.Reflection;

using DOL.GS.PacketHandler;
using DOL.Database;
using DOL.Events;

using log4net;

namespace DOL.GS.Items
{
    public class LegendaryMatterWeapons
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            ItemTemplate item = null;


            // Albion Weapons

            #region lithic_glaive

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_glaive");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_glaive";
                item.Name = "Lithic Glaive";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.PolearmWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1934;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_glaive

            #region lithic_rapier

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_rapier");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_rapier";
                item.Name = "Lithic Rapier";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 39;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.ThrustWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 18;
                item.Model = 1958;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_rapier

            #region lithic_war_pick

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_war_pick");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_war_pick";
                item.Name = "Lithic War Pick";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1898;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_war_pick

            #region lithic_falchion

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_falchion");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_falchion";
                item.Name = "Lithic Falchion";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.SlashingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 19;
                item.Model = 1946;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_falchion

            #region lithic_long_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_long_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_long_bow";
                item.Name = "Lithic Long Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Longbow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 1910;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllArcherySkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_long_bow

            #region lithic_stiletto

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_stiletto");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_stiletto";
                item.Name = "Lithic Stiletto";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.ThrustWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1954;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_stiletto

            #region lithic_pick_flail

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_pick_flail");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_pick_flail";
                item.Name = "Lithic Pick Flail";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 36;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Flexible;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1926;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_pick_flail

            #region lithic_short_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_short_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_short_sword";
                item.Name = "Lithic Short Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 32;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.SlashingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1942;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_short_sword

            #region lithic_coffin_mace

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_coffin_mace");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_coffin_mace";
                item.Name = "Lithic Coffin Mace";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.CrushingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1918;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_coffin_mace

            #region lithic_great_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_great_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_great_sword";
                item.Name = "Lithic Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1902;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_great_sword

            #region lithic_magus_staff

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_magus_staff");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_magus_staff";
                item.Name = "Lithic Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 40;
                item.Model = 1966;
                item.Bonus1 = 30;
                item.Bonus2 = 10;
                item.Bonus3 = 10;
                item.Bonus4 = 50;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.AllFocusLevels;
                item.Bonus5Type = (int)eProperty.AllMagicSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 10;
                item.MaxCharges = 10;
                item.SpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_magus_staff

            #region lithic_bishops_mace

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_bishops_mace");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_bishops_mace";
                item.Name = "Lithic Bishops Mace";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 38;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.CrushingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1914;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_bishops_mace

            #region lithic_great_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_great_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_great_hammer";
                item.Name = "Lithic Great Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1894;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_great_hammer

            #region lithic_quarterstaff

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_quarterstaff");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_quarterstaff";
                item.Name = "Lithic Quarterstaff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 42;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1950;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_quarterstaff

            #region lithic_spiked_flail

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_spiked_flail");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_spiked_flail";
                item.Name = "Lithic Spiked Flail";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 39;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Flexible;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 30;
                item.Model = 1922;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_spiked_flail

            #region lithic_military_fork

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_military_fork");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_military_fork";
                item.Name = "Lithic Military Fork";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.PolearmWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1930;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_military_fork

            #region lithic_lucerne_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_lucerne_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_lucerne_hammer";
                item.Name = "Lithic Lucerne Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 56;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.PolearmWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1938;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_lucerne_hammer



            // Midgard Weapons

            #region lithic_war_axe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_war_axe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_war_axe";
                item.Name = "Lithic War Axe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 26;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2030;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_war_axe

            #region lithic_battleaxe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_battleaxe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_battleaxe";
                item.Name = "Lithic Battleaxe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2050;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_battleaxe

            #region lithic_longsword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_longsword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_longsword";
                item.Name = "Lithic Longsword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2034;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_longsword

            #region lithic_moon_claw

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_moon_claw");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_moon_claw";
                item.Name = "Lithic Moon Claw";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 38;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.HandToHand;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2022;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_moon_claw

            #region lithic_war_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_war_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_war_hammer";
                item.Name = "Lithic War Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Hammer;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2042;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_war_hammer

            #region lithic_great_club

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_great_club");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_great_club";
                item.Name = "Lithic Great Club";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 54;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Hammer;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2054;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_great_club

            #region lithic_fang_greave

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_fang_greave");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_fang_greave";
                item.Name = "Lithic Fang Greave";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.HandToHand;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2026;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_fang_greave

            #region lithic_great_sword3

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_great_sword3");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_great_sword3";
                item.Name = "Lithic Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2058;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_great_sword3

            #region lithic_hooked_spear

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_hooked_spear");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_hooked_spear";
                item.Name = "Lithic Hooked Spear";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Spear;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2046;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_hooked_spear

            #region lithic_magus_staff3

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_magus_staff3");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_magus_staff3";
                item.Name = "Lithic Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 40;
                item.Model = 2066;
                item.Bonus1 = 30;
                item.Bonus2 = 10;
                item.Bonus3 = 10;
                item.Bonus4 = 50;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.AllFocusLevels;
                item.Bonus5Type = (int)eProperty.AllMagicSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 10;
                item.MaxCharges = 10;
                item.SpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_magus_staff3

            #region lithic_composite_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_composite_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_composite_bow";
                item.Name = "Lithic Composite Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 45;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.CompositeBow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 2062;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllArcherySkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_composite_bow

            #region lithic_double_bladed_axe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_double_bladed_axe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_double_bladed_axe";
                item.Name = "Lithic Double Bladed Axe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2038;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_double_bladed_axe



            // Hibernia Weapons

            #region lithic_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_adze";
                item.Name = "Lithic Adze";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Piercing;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2010;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_adze

            #region lithic_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_hammer";
                item.Name = "Lithic Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Blunt;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1990;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_hammer

            #region lithic_war_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_war_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_war_adze";
                item.Name = "Lithic War Adze";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Piercing;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 24;
                item.Model = 2014;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_war_adze

            #region lithic_war_sythe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_war_sythe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_war_sythe";
                item.Name = "Lithic War Scythe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Scythe;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2002;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_war_sythe

            #region lithic_long_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_long_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_long_sword";
                item.Name = "Lithic Long Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Blades;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1970;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_long_sword

            #region lithic_war_scythe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_war_scythe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_war_scythe";
                item.Name = "Lithic War Scythe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Scythe;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2002;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_war_scythe

            #region lithic_dire_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_dire_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_dire_hammer";
                item.Name = "Lithic Dire Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 42;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Blunt;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1986;
                item.Bonus = 35;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_dire_hammer

            #region lithic_recurve_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_recurve_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_recurve_bow";
                item.Name = "Lithic Recurve Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.RecurvedBow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 1994;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllArcherySkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_recurve_bow

            #region lithic_short_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_short_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_short_sword2";
                item.Name = "Lithic Short Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 32;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Blades;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1974;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_short_sword2

            #region lithic_battle_spear

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_battle_spear");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_battle_spear";
                item.Name = "Lithic Battle Spear";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 56;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Spear;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2006;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_battle_spear

            #region lithic_great_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_great_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_great_sword2";
                item.Name = "Lithic Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.LargeWeapons;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1982;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_great_sword2

            #region lithic_magus_staff2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_magus_staff2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_magus_staff2";
                item.Name = "Lithic Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 40;
                item.Model = 2018;
                item.Bonus1 = 30;
                item.Bonus2 = 10;
                item.Bonus3 = 10;
                item.Bonus4 = 50;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Dexterity;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.AllFocusLevels;
                item.Bonus5Type = (int)eProperty.AllMagicSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 10;
                item.MaxCharges = 10;
                item.SpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_magus_staff2

            #region lithic_great_hammer2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lithic_great_hammer2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lithic_great_hammer2";
                item.Name = "Lithic Great Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Matter;
                item.Object_Type = (int)eObjectType.LargeWeapons;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1978;
                item.Bonus1 = 28;
                item.Bonus2 = 8;
                item.Bonus3 = 8;
                item.Bonus4 = 10;
                item.Bonus5 = 2;
                item.Bonus1Type = (int)eProperty.Strength;
                item.Bonus2Type = (int)eProperty.Resist_Spirit;
                item.Bonus3Type = (int)eProperty.Resist_Matter;
                item.Bonus4Type = (int)eProperty.ArmorFactor;
                item.Bonus5Type = (int)eProperty.AllMeleeWeaponSkills;
                item.IsPickable = true;
                item.IsDropable = true; 
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32051;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lithic_great_hammer2




            MerchantItem m_item = null;
            m_item = (MerchantItem)GameServer.Database.SelectObject<MerchantItem>("ItemListID='LegendaryMatterWeapons'");
            if (m_item == null)
            {
                #region Merchant Items

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_rapier";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_falchion";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_stiletto";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_pick_flail";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_short_sword";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_coffin_mace";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_bishops_mace";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_spiked_flail";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_glaive";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_war_pick";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_great_sword";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_magus_staff";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_great_hammer";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_quarterstaff";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_military_fork";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_lucerne_hammer";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_long_bow";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_double_bladed_axe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_war_axe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_longsword";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_moon_claw";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_war_hammer";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_fang_greave";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_battleaxe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_great_club";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_great_sword3";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_hooked_spear";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_magus_staff3";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_composite_bow";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_hammer";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_long_sword";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_dire_hammer";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_short_sword2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_war_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_war_sythe";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_war_scythe";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_battle_spear";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_great_sword2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_magus_staff2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_great_hammer2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryMatterWeapons";
                m_item.ItemTemplateID = "lithic_recurve_bow";
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