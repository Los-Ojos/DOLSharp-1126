/* ----------------------
 * Legendary Heat Weapons
 * ----------------------
 * Total Weapons: 46
 * 
 * Albion Weapons: 16
 * Midgard Weapons: 16
 * Hibernia Weapons: 12
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
    public class LegendaryHeatWeapons
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            ItemTemplate item = null;


            // Albion Weapons

            #region pyroclasmic_long_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_long_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_long_sword2";
                item.Name = "Pyroclasmic Long Sword";
                item.Level = 51;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Type_Damage = (int)eDamageType.Heat;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 15;
                item.Model = 1971;
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
                item.IsTradable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32053;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_long_sword2

            #region pyroclasmic_great_sword_sio

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_great_sword_sio");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_great_sword_sio";
                item.Name = "Pyroclasmic Sword";
                item.Level = 51;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Heat;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 50;
                item.Model = 2059;
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
                item.IsTradable = true;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32053;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_great_sword_sio

            #region pyroclasmic_rapier

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_rapier");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_rapier";
                item.Name = "Pyroclasmic Rapier";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.ThrustWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 18;
                item.Model = 1959;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_rapier

            #region pyroclasmic_glaive

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_glaive");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_glaive";
                item.Name = "Pyroclasmic Glaive";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.PolearmWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1935;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_glaive

            #region pyroclasmic_falchion

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_falchion");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_falchion";
                item.Name = "Pyroclasmic Falchion";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.SlashingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 19;
                item.Model = 1947;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_falchion

            #region pyroclasmic_stiletto

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_stiletto");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_stiletto";
                item.Name = "Pyroclasmic Stiletto";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.ThrustWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1955;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_stiletto

            #region pyroclasmic_war_pick

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_war_pick");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_war_pick";
                item.Name = "Pyroclasmic War Pick";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1899;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_war_pick

            #region pyroclasmic_long_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_long_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_long_bow";
                item.Name = "Pyroclasmic Long Bow";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Longbow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 1911;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_long_bow

            #region pyroclasmic_pick_flail

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_pick_flail");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_pick_flail";
                item.Name = "Pyroclasmic Pick Flail";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Flexible;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1927;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_pick_flail

            #region pyroclasmic_coffin_mace

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_coffin_mace");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_coffin_mace";
                item.Name = "Pyroclasmic Coffin Mace";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.CrushingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1919;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_coffin_mace

            #region pyroclasmic_great_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_great_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_great_sword";
                item.Name = "Pyroclasmic Great Sword";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1903;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_great_sword

            #region pyroclasmic_magus_staff

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_magus_staff");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_magus_staff";
                item.Name = "Pyroclasmic Magus Staff";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Heat;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 40;
                item.Model = 1967;
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
                item.SpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_magus_staff

            #region pyroclasmic_bishops_mace

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_bishops_mace");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_bishops_mace";
                item.Name = "Pyroclasmic Bishops Mace";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.CrushingWeapon;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1915;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_bishops_mace

            #region pyroclasmic_great_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_great_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_great_hammer";
                item.Name = "Pyroclasmic Great Hammer";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.TwoHandedWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1895;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_great_hammer

            #region pyroclasmic_quarterstaff

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_quarterstaff");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_quarterstaff";
                item.Name = "Pyroclasmic Quarterstaff";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Heat;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1951;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_quarterstaff

            #region pyroclasmic_spiked_flail

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_spiked_flail");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_spiked_flail";
                item.Name = "Pyroclasmic Spiked Flail";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Flexible;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 30;
                item.Model = 1923;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_spiked_flail

            #region pyroclasmic_military_fork

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_military_fork");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_military_fork";
                item.Name = "Pyroclasmic Military Fork";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.PolearmWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1931;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_military_fork

            #region pyroclasmic_lucerne_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_lucerne_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_lucerne_hammer";
                item.Name = "Pyroclasmic Lucerne Hammer";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.PolearmWeapon;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1939;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_lucerne_hammer



            // Midgard Weapons

            #region pyroclasmic_war_axe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_war_axe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_war_axe";
                item.Name = "Pyroclasmic War Axe";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Hand = 2;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2031;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_war_axe

            #region pyroclasmic_longsword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_longsword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_longsword";
                item.Name = "Pyroclasmic Longsword";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2035;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_longsword

            #region pyroclasmic_battleaxe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_battleaxe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_battleaxe";
                item.Name = "Pyroclasmic Battleaxe";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2051;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_battleaxe

            #region pyroclasmic_moon_claw

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_moon_claw");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_moon_claw";
                item.Name = "Pyroclasmic Moon Claw";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Hand = 2;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.HandToHand;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2023;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_moon_claw

            #region pyroclasmic_long_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_long_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_long_sword";
                item.Name = "Pyroclasmic Longsword";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2035;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_long_sword

            #region pyroclasmic_great_club

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_great_club");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_great_club";
                item.Name = "Pyroclasmic Great Club";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Hammer;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2055;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_great_club

            #region pyroclasmic_war_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_war_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_war_hammer";
                item.Name = "Pyroclasmic War Hammer";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Hammer;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2043;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_war_hammer

            #region pyroclasmic_short_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_short_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_short_sword";
                item.Name = "Pyroclasmic Short Sword";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Hand = 2;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2035;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_short_sword

            #region pyroclasmic_fang_greave

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_fang_greave");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_fang_greave";
                item.Name = "Pyroclasmic Fang Greave";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Hand = 2;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.HandToHand;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2027;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_fang_greave

            #region pyroclasmic_great_sword3

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_great_sword3");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_great_sword3";
                item.Name = "Pyroclasmic Great Sword";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Sword;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2059;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_great_sword3

            #region pyroclasmic_magus_staff3

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_magus_staff3");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_magus_staff3";
                item.Name = "Pyroclasmic Magus Staff";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Heat;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 40;
                item.Model = 2067;
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
                item.SpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_magus_staff3

            #region pyroclasmic_hooked_spear

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_hooked_spear");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_hooked_spear";
                item.Name = "Pyroclasmic Hooked Spear";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Spear;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2047;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_hooked_spear

            #region pyroclasmic_battle_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_battle_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_battle_hammer";
                item.Name = "Pyroclasmic Battle Hammer";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Hand = 2;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Hammer;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 10;
                item.Model = 2043;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_battle_hammer

            #region pyroclasmic_composite_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_composite_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_composite_bow";
                item.Name = "Pyroclasmic Composite Bow";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.CompositeBow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 2063;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_composite_bow

            #region pyroclasmic_double_bladed_axe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_double_bladed_axe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_double_bladed_axe";
                item.Name = "Pyroclasmic Double Bladed Axe";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2039;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_double_bladed_axe

            #region pyroclasmic_doubled_bladed_axe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_doubled_bladed_axe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_doubled_bladed_axe";
                item.Name = "Pyroclasmic Double Bladed Axe";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Axe;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2039;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_doubled_bladed_axe



            // Hibernia Weapons

            #region pyroclasmic_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_adze";
                item.Name = "Pyroclasmic Adze";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Piercing;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 2011;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_adze

            #region pyroclasmic_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_hammer";
                item.Name = "Pyroclasmic Hammer";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Blunt;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1991;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_hammer

            #region pyroclasmic_war_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_war_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_war_adze";
                item.Name = "Pyroclasmic War Adze";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Piercing;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 24;
                item.Model = 2015;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_war_adze

            #region pyroclasmic_war_scythe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_war_scythe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_war_scythe";
                item.Name = "Pyroclasmic War Scythe";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Scythe;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2003;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_war_scythe

            #region pyroclasmic_battle_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_battle_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_battle_adze";
                item.Name = "Pyroclasmic Battle Adze";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Hand = 2;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Piercing;
                item.Item_Type = (int)eInventorySlot.LeftHandWeapon;
                item.Weight = 24;
                item.Model = 2015;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_battle_adze

            #region pyroclasmic_dire_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_dire_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_dire_hammer";
                item.Name = "Pyroclasmic Dire Hammer";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Blunt;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1987;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_dire_hammer

            #region pyroclasmic_recurve_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_recurve_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_recurve_bow";
                item.Name = "Pyroclasmic Recurve Bow";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.RecurvedBow;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon;
                item.Weight = 10;
                item.Model = 1995;
                item.Bonus = 35;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_recurve_bow

            #region pyroclasmic_great_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_great_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_great_sword2";
                item.Name = "Pyroclasmic Great Sword";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.LargeWeapons;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1983;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_great_sword2

            #region pyroclasmic_magus_staff2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_magus_staff2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_magus_staff2";
                item.Name = "Pyroclasmic Magus Staff";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Heat;
                item.Object_Type = (int)eObjectType.Staff;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 40;
                item.Model = 2019;
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
                item.SpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_magus_staff2

            #region pyroclasmic_short_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_short_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_short_sword2";
                item.Name = "Pyroclasmic Short Sword";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Blades;
                item.Item_Type = (int)eInventorySlot.RightHandWeapon;
                item.Weight = 10;
                item.Model = 1975;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_short_sword2

            #region pyroclasmic_battle_spear

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_battle_spear");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_battle_spear";
                item.Name = "Pyroclasmic Battle Spear";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.Spear;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 2007;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_battle_spear

            #region pyroclasmic_great_hammer2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("pyroclasmic_great_hammer2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "pyroclasmic_great_hammer2";
                item.Name = "Pyroclasmic Great Hammer";
                item.Level = 51;
                item.Durability = 5000000;
                item.MaxDurability = 5000000;
                item.Condition = 5000000;
                item.MaxCondition = 5000000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 13;
                item.Object_Type = (int)eObjectType.LargeWeapons;
                item.Item_Type = (int)eInventorySlot.TwoHandWeapon;
                item.Weight = 10;
                item.Model = 1979;
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
                item.ProcSpellID = 32053;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion pyroclasmic_great_hammer2



            MerchantItem m_item = null;
            m_item = (MerchantItem)GameServer.Database.SelectObject<MerchantItem>("ItemListID='LegendaryHeatWeapons'");
            if (m_item == null)
            {
                #region Merchant Items

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_long_sword2";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_great_sword_sio";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_rapier";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_falchion";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_stiletto";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_pick_flail";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_coffin_mace";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_bishops_mace";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_spiked_flail";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_glaive";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_war_pick";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_great_sword";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_magus_staff";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_great_hammer";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_quarterstaff";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_military_fork";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_lucerne_hammer";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_long_bow";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_longsword";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_long_sword";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_war_hammer";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_double_bladed_axe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_doubled_bladed_axe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_war_axe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_moon_claw";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_short_sword";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_fang_greave";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_battle_hammer";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_battleaxe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_great_club";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_great_sword3";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_magus_staff3";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_hooked_spear";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_composite_bow";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_hammer";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_war_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_dire_hammer";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_short_sword2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_battle_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_war_scythe";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_great_sword2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_magus_staff2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_battle_spear";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_great_hammer2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryHeatWeapons";
                m_item.ItemTemplateID = "pyroclasmic_recurve_bow";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                #endregion Merchant Items
            }
            item = null;
        }
    }
}