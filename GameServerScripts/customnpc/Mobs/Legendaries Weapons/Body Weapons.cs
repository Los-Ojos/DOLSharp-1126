/* ------------------------
 * Legendary Body Weapons
 * ------------------------
 * Total Weapons: 42
 * 
 * Albion Weapons: 17
 * Midgard Weapons: 12
 * Hibernia Weapons: 13
 * ------------------------
 * Remade by Yemla (Started by Andriy)
*/

using System;
using System.Reflection;

using DOL.GS.PacketHandler;
using DOL.Database;
using DOL.Events;

using log4net;

namespace DOL.GS.Items
{
    public class LegendaryBodyWeapons
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            ItemTemplate item = null;


            // Albion Weapons

            #region bodified_glaive

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_glaive");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_glaive";
                item.Name = "bodified Glaive";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.PolearmWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1933;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_glaive

            #region bodified_rapier

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_rapier");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_rapier";
                item.Name = "bodified Rapier";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 39;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.ThrustWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 18;
                item.Model = 1957;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_rapier

            #region bodified_war_pick

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_war_pick");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_war_pick";
                item.Name = "bodified War Pick";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1897;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_war_pick

            #region bodified_falchion

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_falchion");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_falchion";
                item.Name = "bodified Falchion";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.SlashingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 19;
                item.Model = 1945;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_falchion

            #region bodified_long_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_long_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_long_bow";
                item.Name = "bodified Long Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Longbow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 1909;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_long_bow

            #region bodified_stiletto

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_stiletto");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_stiletto";
                item.Name = "bodified Stiletto";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.ThrustWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1953;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_stiletto

            #region bodified_pick_flail

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_pick_flail");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_pick_flail";
                item.Name = "bodified Pick Flail";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 36;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Flexible;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1925;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_pick_flail

            #region bodified_short_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_short_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_short_sword";
                item.Name = "bodified Short Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 32;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.SlashingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1941;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_short_sword

            #region bodified_coffin_mace

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_coffin_mace");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_coffin_mace";
                item.Name = "bodified Coffin Mace";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.CrushingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1917;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_coffin_mace

            #region bodified_great_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_great_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_great_sword";
                item.Name = "bodified Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1901;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_great_sword

            #region bodified_magus_staff

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_magus_staff");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_magus_staff";
                item.Name = "bodified Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 40;
                item.Model = 1965;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 10;
                item.MaxCharges = 10;
                item.SpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_magus_staff

            #region bodified_bishops_mace

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_bishops_mace");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_bishops_mace";
                item.Name = "bodified Bishops Mace";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 38;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.CrushingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1913;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_bishops_mace

            #region bodified_great_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_great_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_great_hammer";
                item.Name = "bodified Great Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1893;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_great_hammer

            #region bodified_quarterstaff

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_quarterstaff");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_quarterstaff";
                item.Name = "bodified Quarterstaff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 42;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1949;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_quarterstaff

            #region bodified_spiked_flail

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_spiked_flail");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_spiked_flail";
                item.Name = "bodified Spiked Flail";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 39;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Flexible;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 30;
                item.Model = 1921;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_spiked_flail

            #region bodified_military_fork

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_military_fork");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_military_fork";
                item.Name = "bodified Military Fork";
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
                item.Model = 1929;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_military_fork

            #region bodified_lucerne_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_lucerne_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_lucerne_hammer";
                item.Name = "bodified Lucerne Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 56;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.PolearmWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1937;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_lucerne_hammer



            // Midgard Weapons

            #region bodified_war_axe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_war_axe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_war_axe";
                item.Name = "bodified War Axe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 26;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2029;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_war_axe

            #region bodified_battleaxe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_battleaxe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_battleaxe";
                item.Name = "bodified Battleaxe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2049;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_battleaxe

            #region bodified_longsword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_longsword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_longsword";
                item.Name = "bodified Longsword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2033;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_longsword

            #region bodified_moon_claw

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_moon_claw");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_moon_claw";
                item.Name = "bodified Moon Claw";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 38;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.HandToHand;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2021;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_moon_claw

            #region bodified_war_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_war_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_war_hammer";
                item.Name = "bodified War Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Hammer;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2041;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_war_hammer

            #region bodified_great_club

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_great_club");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_great_club";
                item.Name = "bodified Great Club";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 54;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Hammer;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2053;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_great_club

            #region bodified_fang_greave

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_fang_greave");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_fang_greave";
                item.Name = "bodified Fang Greave";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.HandToHand;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2025;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_fang_greave

            #region bodified_great_sword3

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_great_sword3");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_great_sword3";
                item.Name = "bodified Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2057;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_great_sword3

            #region bodified_hooked_spear

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_hooked_spear");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_hooked_spear";
                item.Name = "bodified Hooked Spear";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Spear;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2045;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_hooked_spear

            #region bodified_magus_staff3

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_magus_staff3");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_magus_staff3";
                item.Name = "bodified Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 40;
                item.Model = 2065;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 10;
                item.MaxCharges = 10;
                item.SpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_magus_staff3

            #region bodified_composite_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_composite_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_composite_bow";
                item.Name = "bodified Composite Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 45;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.CompositeBow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 2061;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_composite_bow

            #region bodified_double_bladed_axe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_double_bladed_axe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_double_bladed_axe";
                item.Name = "bodified Double Bladed Axe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2037;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_double_bladed_axe



            // Hibernia Weapons

            #region bodified_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_adze";
                item.Name = "bodified Adze";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Piercing;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2009;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_adze

            #region bodified_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_hammer";
                item.Name = "bodified Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Blunt;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1989;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_hammer

            #region bodified_war_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_war_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_war_adze";
                item.Name = "bodified War Adze";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Piercing;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 24;
                item.Model = 2013;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_war_adze

            #region bodified_war_sythe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_war_sythe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_war_sythe";
                item.Name = "bodified War Scythe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Scythe;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2001;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_war_sythe

            #region bodified_long_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_long_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_long_sword";
                item.Name = "bodified Long Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Blades;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1969;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_long_sword

            #region bodified_war_scythe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_war_scythe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_war_scythe";
                item.Name = "bodified War Scythe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Scythe;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2001;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_war_scythe

            #region bodified_dire_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_dire_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_dire_hammer";
                item.Name = "bodified Dire Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 42;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Blunt;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1985;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_dire_hammer

            #region bodified_recurve_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_recurve_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_recurve_bow";
                item.Name = "bodified Recurve Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.RecurvedBow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 1993;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_recurve_bow

            #region bodified_short_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_short_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_short_sword2";
                item.Name = "bodified Short Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 32;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Blades;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1973;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_short_sword2

            #region bodified_battle_spear

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_battle_spear");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_battle_spear";
                item.Name = "bodified Battle Spear";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 56;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Spear;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2005;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_battle_spear

            #region bodified_great_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_great_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_great_sword2";
                item.Name = "bodified Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.LargeWeapons;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1981;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_great_sword2

            #region bodified_magus_staff2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_magus_staff2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_magus_staff2";
                item.Name = "bodified Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 40;
                item.Model = 2017;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 10;
                item.MaxCharges = 10;
                item.SpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_magus_staff2

            #region bodified_great_hammer2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("bodified_great_hammer2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "bodified_great_hammer2";
                item.Name = "bodified Great Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Body;
                item.Object_Type = (int)eObjectType.LargeWeapons;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1977;
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
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion bodified_great_hammer2




            MerchantItem m_item = null;
            m_item = (MerchantItem)GameServer.Database.SelectObject<MerchantItem>("ItemListID='LegendaryBodyWeapons'");
            if (m_item == null)
            {
                #region Merchant Items

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_rapier";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_falchion";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_stiletto";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_pick_flail";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_short_sword";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_coffin_mace";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_bishops_mace";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_spiked_flail";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_glaive";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_war_pick";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_great_sword";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_magus_staff";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_great_hammer";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_quarterstaff";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_military_fork";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_lucerne_hammer";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_long_bow";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_double_bladed_axe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_war_axe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_longsword";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_moon_claw";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_war_hammer";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_fang_greave";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_battleaxe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_great_club";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_great_sword3";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_hooked_spear";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_magus_staff3";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_composite_bow";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_hammer";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_long_sword";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_dire_hammer";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_short_sword2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_war_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_war_sythe";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_war_scythe";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_battle_spear";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_great_sword2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_magus_staff2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_great_hammer2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryBodyWeapons";
                m_item.ItemTemplateID = "bodified_recurve_bow";
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