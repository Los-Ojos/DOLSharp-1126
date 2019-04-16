/* ------------------------
 * Legendary Energy Weapons
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
    public class LegendaryEnergyWeapons
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            ItemTemplate item = null;


            // Albion Weapons

            #region energetic_glaive

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_glaive");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_glaive";
                item.Name = "energetic Glaive";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_glaive

            #region energetic_rapier

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_rapier");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_rapier";
                item.Name = "energetic Rapier";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 39;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_rapier

            #region energetic_war_pick

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_war_pick");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_war_pick";
                item.Name = "energetic War Pick";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_war_pick

            #region energetic_falchion

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_falchion");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_falchion";
                item.Name = "energetic Falchion";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_falchion

            #region energetic_long_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_long_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_long_bow";
                item.Name = "energetic Long Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_long_bow

            #region energetic_stiletto

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_stiletto");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_stiletto";
                item.Name = "energetic Stiletto";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_stiletto

            #region energetic_pick_flail

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_pick_flail");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_pick_flail";
                item.Name = "energetic Pick Flail";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 36;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_pick_flail

            #region energetic_short_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_short_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_short_sword";
                item.Name = "energetic Short Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 32;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_short_sword

            #region energetic_coffin_mace

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_coffin_mace");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_coffin_mace";
                item.Name = "energetic Coffin Mace";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_coffin_mace

            #region energetic_great_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_great_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_great_sword";
                item.Name = "energetic Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_great_sword

            #region energetic_magus_staff

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_magus_staff");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_magus_staff";
                item.Name = "energetic Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
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

            #endregion energetic_magus_staff

            #region energetic_bishops_mace

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_bishops_mace");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_bishops_mace";
                item.Name = "energetic Bishops Mace";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 38;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_bishops_mace

            #region energetic_great_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_great_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_great_hammer";
                item.Name = "energetic Great Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_great_hammer

            #region energetic_quarterstaff

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_quarterstaff");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_quarterstaff";
                item.Name = "energetic Quarterstaff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 42;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_quarterstaff

            #region energetic_spiked_flail

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_spiked_flail");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_spiked_flail";
                item.Name = "energetic Spiked Flail";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 39;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_spiked_flail

            #region energetic_military_fork

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_military_fork");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_military_fork";
                item.Name = "energetic Military Fork";
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_military_fork

            #region energetic_lucerne_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_lucerne_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_lucerne_hammer";
                item.Name = "energetic Lucerne Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 56;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_lucerne_hammer



            // Midgard Weapons

            #region energetic_war_axe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_war_axe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_war_axe";
                item.Name = "energetic War Axe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 26;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_war_axe

            #region energetic_battleaxe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_battleaxe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_battleaxe";
                item.Name = "energetic Battleaxe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_battleaxe

            #region energetic_longsword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_longsword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_longsword";
                item.Name = "energetic Longsword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_longsword

            #region energetic_moon_claw

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_moon_claw");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_moon_claw";
                item.Name = "energetic Moon Claw";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 38;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_moon_claw

            #region energetic_war_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_war_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_war_hammer";
                item.Name = "energetic War Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_war_hammer

            #region energetic_great_club

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_great_club");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_great_club";
                item.Name = "energetic Great Club";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 54;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_great_club

            #region energetic_fang_greave

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_fang_greave");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_fang_greave";
                item.Name = "energetic Fang Greave";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_fang_greave

            #region energetic_great_sword3

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_great_sword3");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_great_sword3";
                item.Name = "energetic Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_great_sword3

            #region energetic_hooked_spear

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_hooked_spear");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_hooked_spear";
                item.Name = "energetic Hooked Spear";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_hooked_spear

            #region energetic_magus_staff3

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_magus_staff3");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_magus_staff3";
                item.Name = "energetic Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
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

            #endregion energetic_magus_staff3

            #region energetic_composite_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_composite_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_composite_bow";
                item.Name = "energetic Composite Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 45;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_composite_bow

            #region energetic_double_bladed_axe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_double_bladed_axe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_double_bladed_axe";
                item.Name = "energetic Double Bladed Axe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_double_bladed_axe



            // Hibernia Weapons

            #region energetic_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_adze";
                item.Name = "energetic Adze";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_adze

            #region energetic_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_hammer";
                item.Name = "energetic Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_hammer

            #region energetic_war_adze

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_war_adze");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_war_adze";
                item.Name = "energetic War Adze";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 2;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_war_adze

            #region energetic_war_sythe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_war_sythe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_war_sythe";
                item.Name = "energetic War Scythe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_war_sythe

            #region energetic_long_sword

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_long_sword");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_long_sword";
                item.Name = "energetic Long Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_long_sword

            #region energetic_war_scythe

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_war_scythe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_war_scythe";
                item.Name = "energetic War Scythe";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_war_scythe

            #region energetic_dire_hammer

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_dire_hammer");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_dire_hammer";
                item.Name = "energetic Dire Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 42;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_dire_hammer

            #region energetic_recurve_bow

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_recurve_bow");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_recurve_bow";
                item.Name = "energetic Recurve Bow";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 52;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_recurve_bow

            #region energetic_short_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_short_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_short_sword2";
                item.Name = "energetic Short Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 32;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_short_sword2

            #region energetic_battle_spear

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_battle_spear");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_battle_spear";
                item.Name = "energetic Battle Spear";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 56;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_battle_spear

            #region energetic_great_sword2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_great_sword2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_great_sword2";
                item.Name = "energetic Great Sword";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_great_sword2

            #region energetic_magus_staff2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_magus_staff2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_magus_staff2";
                item.Name = "energetic Magus Staff";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
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

            #endregion energetic_magus_staff2

            #region energetic_great_hammer2

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("energetic_great_hammer2");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "energetic_great_hammer2";
                item.Name = "energetic Great Hammer";
                item.Level = 51;
                item.Durability = 100;
                item.MaxDurability = 100;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 51;
                item.Hand = 1;
                item.Type_Damage = (int)eDamageType.Energy;
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
			    item.Price = 5000;
                
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32052;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion energetic_great_hammer2




            MerchantItem m_item = null;
            m_item = (MerchantItem)GameServer.Database.SelectObject<MerchantItem>("ItemListID='LegendaryEnergyWeapons'");
            if (m_item == null)
            {
                #region Merchant Items

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_rapier";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_falchion";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_stiletto";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_pick_flail";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_short_sword";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_coffin_mace";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_bishops_mace";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_spiked_flail";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_glaive";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_war_pick";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_great_sword";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_magus_staff";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_great_hammer";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_quarterstaff";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_military_fork";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_lucerne_hammer";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_long_bow";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_double_bladed_axe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_war_axe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_longsword";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_moon_claw";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_war_hammer";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_fang_greave";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_battleaxe";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_great_club";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_great_sword3";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_hooked_spear";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_magus_staff3";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_composite_bow";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_hammer";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_long_sword";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_dire_hammer";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_short_sword2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_war_adze";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_war_sythe";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_war_scythe";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_battle_spear";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_great_sword2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_magus_staff2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_great_hammer2";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "LegendaryEnergyWeapons";
                m_item.ItemTemplateID = "energetic_recurve_bow";
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