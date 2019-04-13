using System;
using System.Reflection;
using DOL.GS.PacketHandler;
using DOL.Events;
using DOL.Database;
using log4net;

// The Labyrinth Weapons by Deathwish, for Dol - Daoc Servers. Version 1.1
//
// How to install: Just place in your script folder and the script will do the rest.
// How to use ingame make your merchant "/merchant create" then /merchant add sell AlbLabWeaps for alb weapons
//                                                                                 MidLabWeaps for mid weapons
//                                                                                 HibLabWeaps for hib weapons
// Info on the Script: <<<<Please Read>>>>
// The following weapons / stats and procs are based of the Allakhazam website.
// If there are any items missing, thats because they are not on the website, or i missed them lol but i will try my best to get them all first time.
// All items are set to the right classes and realms and have a 500Gold Value set on them, Throwing daggers if added are 100g for 100.
// All charges are set to 100 changes and 100 max charges
// Items with haste proc have been set to Angel's Haste of Combat Speed Proc spellid 32170, this is set value of 17 not 40, This is because most dol servers have haste buffs on BB and +40% more be over powered.
// Some items have been tested like Harp to make sure it works with all spells and could more items too, but this script is not fully tested yet!
// Any problem feel free to message me or email me at Deathwish-Dol@hotmail.com.
//
// Also added a mid throwing weapon with the 14358 proc = 125 per tic damage, but i have set it not install as it a made up item i did for my own server, to add this, go to line 5231 and it tell you there how to add it.


namespace DOL.GS.Items

 {
    public class LabWeapons // Version 1.1
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            ItemTemplate item;

            #region Weapons
            #region 1 Handed weapons
            #region Alb

            #region Foreman's Forged Hammer
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Foremans_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Foremans_Lab_Alb";
                item.Name = "Foreman's Forged Hammer";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Type_Damage = 1;
                item.Object_Type = 2;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3720;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 1;
                item.Bonus2Type = 25;
                item.Bonus3Type = 14;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                //price = gold * 10000 + silver * 100 + copper;
                item.Price = 0 * 10000 + Silver * 100 + 0;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2;6;10;33;11;1;19";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Ifocezase's Vengence Chain
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Ifocezases_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Ifocezases_Lab_Alb";
                item.Name = "Ifocezase's Vengence Chain";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 34;
                item.Type_Damage = 2;
                item.Object_Type = 24;
                item.Item_Type = 10;
                item.Weight = 65;
                item.Model = 3697;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 1;
                item.Bonus2Type = 33;
                item.Bonus3Type = 19;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "33;19";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Indignation
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Indignation_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Indignation_Lab_Alb";
                item.Name = "Indignation";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 32;
                item.Type_Damage = 1;
                item.Object_Type = 24;
                item.Item_Type = 10;
                item.Weight = 65;
                item.Model = 3696;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 1;
                item.Bonus4Type = 33;
                item.Bonus5Type = 11;
                item.Bonus6Type = 12;
                item.Bonus7Type = 15;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "33;19";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Indy Skull Piercer
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Indy_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Indy_Lab_Alb";
                item.Name = "Indy Skull Piercer";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 32;
                item.Type_Damage = 3;
                item.Object_Type = 4;
                item.Item_Type = 10;
                item.Weight = 65;
                item.Model = 3722;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 18;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 50;
                item.Bonus2Type = 2;
                item.Bonus3Type = 17;
                item.Bonus4Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2;9;11;4;1;19;3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Outrage
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Outrage_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Outrage_Lab_Alb";
                item.Name = "Outrage";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Type_Damage = 2;
                item.Object_Type = 24;
                item.Item_Type = 10;
                item.Weight = 50;
                item.Model = 3654;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 1;
                item.Bonus4Type = 33;
                item.Bonus5Type = 11;
                item.Bonus6Type = 12;
                item.Bonus7Type = 15;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 1;
                item.AllowedClasses = "33;19";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Reformation
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Reformation_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Reformation_Lab_Alb";
                item.Name = "Reformation";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Type_Damage = 1;
                item.Object_Type = 2;
                item.Item_Type = 10;
                item.Weight = 50;
                item.Model = 3677;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 2;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 15;
                item.Bonus7 = 5;
                item.Bonus8 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 163;
                item.Bonus3Type = 11;
                item.Bonus4Type = 12;
                item.Bonus5Type = 15;
                item.Bonus6Type = 156;
                item.Bonus7Type = 196;
                item.Bonus8Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                item.Realm = 1;
                item.AllowedClasses = "2;6;10;33;11;1;19";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Revenge
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Revenge_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Revenge_Lab_Alb";
                item.Name = "Revenge";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 35;
                item.Hand = 2;
                item.Type_Damage = 3;
                item.Object_Type = 4;
                item.Item_Type = 11;
                item.Weight = 50;
                item.Model = 3678;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 1;
                item.Bonus4Type = 167;
                item.Bonus5Type = 14;
                item.Bonus6Type = 16;
                item.Bonus7Type = 18;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 11431;
                item.Realm = 1;
                item.AllowedClasses = "2;9;11;4;1;19;3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Swine's Flail
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Swines_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Swines_Lab_Alb";
                item.Name = "Swine's Flail";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 31;
                item.Type_Damage = 1;
                item.Object_Type = 24;
                item.Item_Type = 10;
                item.Weight = 50;
                item.Model = 3653;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 1;
                item.Bonus2Type = 19;
                item.Bonus3Type = 33;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "33;19";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Technomancer Blade
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Technomancer_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Technomancer_Lab_Alb";
                item.Name = "Technomancer Blade";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Type_Damage = 2;
                item.Object_Type = 3;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3718;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 18;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 44;
                item.Bonus2Type = 4;
                item.Bonus3Type = 15;
                item.Bonus4Type = 204;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2;9;11;4;1;19;3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol


            #endregion Alb

            #region Mid
            #region Anger Axe
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Anger_Axe_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Anger_Axe_Lab_Mid";
                item.Name = "Anger Axe";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Type_Damage = 2;
                item.Object_Type = 13;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3681;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 1;
                item.Bonus4Type = 54;
                item.Bonus5Type = 11;
                item.Bonus6Type = 12;
                item.Bonus7Type = 15;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 2;
                item.AllowedClasses = "31;32;23;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Anguish
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Anguish_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Anguish_Lab_Mid";
                item.Name = "Anguish";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Type_Damage = 1;
                item.Object_Type = 12;
                item.Item_Type = 10;
                item.Weight = 40;
                item.Model = 3677;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 12;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus10 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 164;
                item.Bonus4Type = 11;
                item.Bonus5Type = 1;
                item.Bonus6Type = 12;
                item.Bonus7Type = 15;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 2;
                item.AllowedClasses = "31;26;32;28;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Crusher of Ajasoa
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Crusher_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Crusher_Lab_Mid";
                item.Name = "Crusher of Ajasoa";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Type_Damage = 1;
                item.Object_Type = 12;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3720;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 156;
                item.Bonus2Type = 19;
                item.Bonus3Type = 163;
                item.Bonus4Type = 209;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 100;
                item.MaxCharges = 100;
                item.SpellID = 65200;
                item.Realm = 2;
                item.AllowedClasses = "31;26;32;28;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Danger
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Danger_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Danger_Lab_Mid";
                item.Name = "Danger";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Type_Damage = 2;
                item.Object_Type = 11;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3675;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 4;
                item.Bonus4Type = 52;
                item.Bonus5Type = 11;
                item.Bonus6Type = 12;
                item.Bonus7Type = 15;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 2;
                item.AllowedClasses = "31;25;32;23;24;21;34;59";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Foreman's Forged Hammer
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Foremans_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Foremans_Lab_Mid";
                item.Name = "Foreman's Forged Hammer";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Type_Damage = 1;
                item.Object_Type = 12;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3720;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 1;
                item.Bonus2Type = 53;
                item.Bonus3Type = 14;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "31;26;32;28;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Indy Skull Splitter
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Indy_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Indy_Lab_Mid";
                item.Name = "Indy Skull Splitter";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 13;
                item.Item_Type = 11;
                item.Weight = 65;
                item.Model = 3724;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 18;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 54;
                item.Bonus2Type = 1;
                item.Bonus3Type = 11;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "31;23;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Mnevis' Heated Halbred
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Mnevis_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Mnevis_Lab_Mid";
                item.Name = "Mnevis' Heated Halbred";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Type_Damage = 2;
                item.Object_Type = 25;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3726;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 2;
                item.Bonus2Type = 92;
                item.Bonus3Type = 13;
                item.Bonus4Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "32";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Murder
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Murder_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Murder_Lab_Mid";
                item.Name = "Murder";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Type_Damage = 2;
                item.Object_Type = 25;
                item.Item_Type = 10;
                item.Weight = 50;
                item.Model = 3683;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 1;
                item.Bonus4Type = 92;
                item.Bonus5Type = 14;
                item.Bonus6Type = 16;
                item.Bonus7Type = 18;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 2;
                item.AllowedClasses = "32";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Revenge
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Revenge_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Revenge_Lab_Mid";
                item.Name = "Revenge";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 11;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3658;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 2;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 52;
                item.Bonus4Type = 11;
                item.Bonus5Type = 12;
                item.Bonus6Type = 14;
                item.Bonus7Type = 15;
                item.Bonus8Type = 18;
                item.Bonus9Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 2;
                item.AllowedClasses = "31;25;32;23;24;21;34;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Technomancer Blade
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Technomancer_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Technomancer_Lab_Mid";
                item.Name = "Technomancer Blade";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Type_Damage = 2;
                item.Object_Type = 11;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3718;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 18;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 52;
                item.Bonus2Type = 4;
                item.Bonus3Type = 15;
                item.Bonus4Type = 204;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "31;32;23;24;21;34;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region The Moment of Zen
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Moment_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Moment_Lab_Mid";
                item.Name = "The Moment of Zen";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 42;
                item.Type_Damage = 2;
                item.Object_Type = 11;
                item.Item_Type = 10;
                item.Color = 80;
                item.Effect = 12;
                item.Weight = 10;
                item.Model = 670;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 3;
                item.Bonus4 = 5;
                item.Bonus5 = 4;
                item.Bonus6 = 2;
                item.Bonus7 = 4;
                item.Bonus8 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 164;
                item.Bonus4Type = 194;
                item.Bonus5Type = 201;
                item.Bonus6Type = 155;
                item.Bonus7Type = 202;
                item.Bonus8Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                item.Realm = 2;
                item.AllowedClasses = "31;32;23;24;21;34;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #endregion Mid

            #region Hib
            #region Anguish
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Anguish_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Anguish_Lab_Hib";
                item.Name = "Anguish";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 2;
                item.Type_Damage = 1;
                item.Object_Type = 20;
                item.Item_Type = 11;
                item.Weight = 35;
                item.Model = 3676;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 12;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus10 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 167;
                item.Bonus4Type = 18;
                item.Bonus5Type = 1;
                item.Bonus6Type = 14;
                item.Bonus7Type = 16;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 3;
                item.AllowedClasses = "48;43;45;47;44;46";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Crusher of Ajasoa
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Crusher_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Crusher_Lab_Hib";
                item.Name = "Crusher of Ajasoa";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 36;
                item.Type_Damage = 1;
                item.Object_Type = 20;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3720;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 1;
                item.Bonus2Type = 16;
                item.Bonus3Type = 164;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "48;43;45;47;44;46";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Foreman's Forged Hammer
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Foremans_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Foremans_Lab_Hib";
                item.Name = "Foreman's Forged Hammer";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Type_Damage = 1;
                item.Object_Type = 20;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3720;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 14;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "48;45;47;44;46";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Mnevis' Heated Piercer
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Mnevis_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Mnevis_Lab_Hib";
                item.Name = "Mnevis' Heated Halbred";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Type_Damage = 3;
                item.Object_Type = 21;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3722;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 2;
                item.Bonus2Type = 164;
                item.Bonus3Type = 13;
                item.Bonus4Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "43;45;44;49;50;58";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Revenge
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Revenge_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Revenge_Lab_Hib";
                item.Name = "Revenge";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Hand = 2;
                item.Type_Damage = 3;
                item.Object_Type = 21;
                item.Item_Type = 11;
                item.Weight = 50;
                item.Model = 3678;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 1;
                item.Bonus4Type = 74;
                item.Bonus5Type = 14;
                item.Bonus6Type = 16;
                item.Bonus7Type = 18;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 11431;
                item.Realm = 3;
                item.AllowedClasses = "43;45;44;49;50;58";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Technomancer Blade
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Technomancer_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Technomancer_Lab_Hib";
                item.Name = "Technomancer Blade";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Type_Damage = 2;
                item.Object_Type = 19;
                item.Item_Type = 10;
                item.Weight = 30;
                item.Model = 3718;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 18;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 72;
                item.Bonus2Type = 4;
                item.Bonus3Type = 15;
                item.Bonus4Type = 204;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "48;43;45;47;44;49;50;46";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol

            #endregion Hib


            #endregion 1 Handed weapons

            #region 1 Handed Left handed weapons
            #region Alb
            #region Aegbarol
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Aegbarol_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Aegbarol_Lab_Alb";
                item.Name = "Aegbarol Deception Blade";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 36;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 3;
                item.Item_Type = 11;
                item.Weight = 30;
                item.Model = 3718;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 1;
                item.Bonus2Type = 52;
                item.Bonus3Type = 12;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2;9;11;4;1;19;3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Anger
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Anger_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Anger_Lab_Alb";
                item.Name = "Anger";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 3;
                item.Item_Type = 11;
                item.Weight = 30;
                item.Model = 3674;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 1;
                item.Bonus4Type = 44;
                item.Bonus5Type = 11;
                item.Bonus6Type = 12;
                item.Bonus7Type = 15;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 1;
                item.AllowedClasses = "2;9;11;4;1;19;3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Crusher of Ajasoa
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Crusher_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Crusher_Lab_Alb";
                item.Name = "Crusher of Ajasoa";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 35;
                item.Hand = 2;
                item.Type_Damage = 1;
                item.Object_Type = 2;
                item.Item_Type = 11;
                item.Weight = 40;
                item.Model = 3721;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 1;
                item.Bonus2Type = 13;
                item.Bonus3Type = 16;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2;6;10;33;11;1;19";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Danger
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Danger_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Danger_Lab_Alb";
                item.Name = "Danger";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Hand = 2;
                item.Type_Damage = 3;
                item.Object_Type = 4;
                item.Item_Type = 11;
                item.Weight = 30;
                item.Model = 3678;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 4;
                item.Bonus4Type = 50;
                item.Bonus5Type = 12;
                item.Bonus6Type = 11;
                item.Bonus7Type = 15;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 1;
                item.AllowedClasses = "2;9;11;4;1;19;3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Saztsoh's Death Dealer
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Saztsohs_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Saztsohs_Lab_Alb";
                item.Name = "Saztsoh's Death Dealer";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 36;
                item.Hand = 2;
                item.Type_Damage = 3;
                item.Object_Type = 4;
                item.Item_Type = 11;
                item.Weight = 50;
                item.Model = 3674;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 18;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 50;
                item.Bonus2Type = 2;
                item.Bonus3Type = 13;
                item.Bonus4Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2;9;11;4;1;19;3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region The Moment of Zen
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Moment_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Moment_Lab_Alb";
                item.Name = "The Moment of Zen";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 43;
                item.Hand = 0;
                item.Type_Damage = 3;
                item.Object_Type = 4;
                item.Item_Type = 11;
                item.Color = 80;
                item.Effect = 12;
                item.Weight = 10;
                item.Model = 670;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 3;
                item.Bonus4 = 5;
                item.Bonus5 = 4;
                item.Bonus6 = 2;
                item.Bonus7 = 4;
                item.Bonus8 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 164;
                item.Bonus4Type = 194;
                item.Bonus5Type = 201;
                item.Bonus6Type = 155;
                item.Bonus7Type = 202;
                item.Bonus8Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                item.Realm = 1;
                item.AllowedClasses = "2;9;11;4;1;19;3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Torture
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Torture_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Torture_Lab_Alb";
                item.Name = "Torture";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 35;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 3;
                item.Item_Type = 11;
                item.Weight = 13;
                item.Model = 3674;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 4;
                item.Bonus4Type = 167;
                item.Bonus5Type = 16;
                item.Bonus6Type = 14;
                item.Bonus7Type = 18;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32170;
                item.Realm = 1;
                item.AllowedClasses = "2;9;11;4;1;19;3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol


            #endregion Alb

            #region Mid
            #region Aegbarol
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Aegbarol_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Aegbarol_Lab_Mid";
                item.Name = "Aegbarol Deception Blade";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 11;
                item.Item_Type = 11;
                item.Weight = 30;
                item.Model = 3718;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 1;
                item.Bonus2Type = 52;
                item.Bonus3Type = 15;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "31;25;32;23;24;21;34;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Anger Left Axe
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Anger_LeftAxe_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Anger_LeftAxe_Lab_Mid";
                item.Name = "Anger Left Axe";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 17;
                item.Item_Type = 11;
                item.Weight = 30;
                item.Model = 3680;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 1;
                item.Bonus4Type = 55;
                item.Bonus5Type = 11;
                item.Bonus6Type = 12;
                item.Bonus7Type = 15;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 2;
                item.AllowedClasses = "31;32;23";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Hatred
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Hatred_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Hatred_Lab_Mid";
                item.Name = "Hatred";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 39;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 25;
                item.Item_Type = 11;
                item.Weight = 12;
                item.Model = 3682;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 2;
                item.Bonus4Type = 92;
                item.Bonus5Type = 11;
                item.Bonus6Type = 12;
                item.Bonus7Type = 15;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 2;
                item.AllowedClasses = "32";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Kulgah's Scathing Greave
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Kulgahs_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Kulgahs_Lab_Mid";
                item.Name = "Kulgah's Scathing Greave";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Type_Damage = 3;
                item.Object_Type = 25;
                item.Item_Type = 10;
                item.Weight = 35;
                item.Model = 3730;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 3;
                item.Bonus3 = 4;
                item.Bonus4 = 3;
                item.Bonus1Type = 1;
                item.Bonus2Type = 17;
                item.Bonus3Type = 92;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "32";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Saztsoh's Death Dealer
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Saztsohs_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Saztsohs_Lab_Mid";
                item.Name = "Saztsoh's Death Dealer";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 36;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 1;
                item.Item_Type = 11;
                item.Weight = 50;
                item.Model = 3680;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 18;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 167;
                item.Bonus2Type = 1;
                item.Bonus3Type = 13;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "31;25;32;23;24;21;34;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Smash
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Smash_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Smash_Lab_Mid";
                item.Name = "Smash";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 12;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3704;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 13;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "31;26;32;28;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region The One
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "The_One_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "The_One_Lab";
                item.Name = "The One";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 44;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 25;
                item.Item_Type = 11;
                item.Effect = 53;
                item.Weight = 13;
                item.Model = 3726;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 7;
                item.Bonus3 = 15;
                item.Bonus4 = 3;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 2;
                item.Bonus8 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 4;
                item.Bonus4Type = 92;
                item.Bonus5Type = 194;
                item.Bonus6Type = 201;
                item.Bonus7Type = 155;
                item.Bonus8Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32170;
                item.Realm = 2;
                item.AllowedClasses = "32";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol

            #endregion Mid

            #region Hib
            #region Aegbarol
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Aegbarol_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Aegbarol_Lab_Hib";
                item.Name = "Aegbarol Deception Blade";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 36;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 19;
                item.Item_Type = 11;
                item.Weight = 30;
                item.Model = 3718;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 1;
                item.Bonus2Type = 52;
                item.Bonus3Type = 72;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "48;43;45;47;44;49;50;46";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Anger
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Anger_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Anger_Lab_Hib";
                item.Name = "Anger";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 31;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 20;
                item.Item_Type = 11;
                item.Weight = 30;
                item.Model = 3674;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 1;
                item.Bonus4Type = 167;
                item.Bonus5Type = 14;
                item.Bonus6Type = 16;
                item.Bonus7Type = 18;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 3;
                item.AllowedClasses = "48;43;45;47;44;49;50;46";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Danger
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Danger_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Danger_Lab_Hib";
                item.Name = "Danger";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Hand = 2;
                item.Type_Damage = 3;
                item.Object_Type = 21;
                item.Item_Type = 11;
                item.Weight = 30;
                item.Model = 3678;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 4;
                item.Bonus4Type = 167;
                item.Bonus5Type = 18;
                item.Bonus6Type = 14;
                item.Bonus7Type = 16;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 3;
                item.AllowedClasses = "43;45;44;49;50;58";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Fear
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Fear_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Fear_Lab_Hib";
                item.Name = "Fear";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Hand = 2;
                item.Type_Damage = 1;
                item.Object_Type = 20;
                item.Item_Type = 11;
                item.Weight = 25;
                item.Model = 3676;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 4;
                item.Bonus2Type = 1;
                item.Bonus3Type = 2;
                item.Bonus4Type = 73;
                item.Bonus5Type = 11;
                item.Bonus6Type = 12;
                item.Bonus7Type = 15;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 3;
                item.AllowedClasses = "48;43;45;47;44;46";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Saztsoh's Death Dealer
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Saztsohs_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Saztsohs_Lab_Hib";
                item.Name = "Saztsoh's Death Dealer";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 36;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 19;
                item.Item_Type = 11;
                item.Weight = 50;
                item.Model = 3674;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 18;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 164;
                item.Bonus2Type = 4;
                item.Bonus3Type = 13;
                item.Bonus4Type = 204;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "48;43;45;47;44;49;50;46";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Smash
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Smash_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Smash_Lab_Hib";
                item.Name = "Smash";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 22;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3704;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 13;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "45;44";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region The Moment of Zen
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Moment_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Moment_Lab_Hib";
                item.Name = "The Moment of Zen";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 42;
                item.Hand = 0;
                item.Type_Damage = 3;
                item.Object_Type = 21;
                item.Item_Type = 11;
                item.Color = 80;
                item.Effect = 12;
                item.Weight = 10;
                item.Model = 670;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 3;
                item.Bonus4 = 5;
                item.Bonus5 = 4;
                item.Bonus6 = 2;
                item.Bonus7 = 4;
                item.Bonus8 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 164;
                item.Bonus4Type = 194;
                item.Bonus5Type = 201;
                item.Bonus6Type = 155;
                item.Bonus7Type = 202;
                item.Bonus8Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                item.Realm = 3;
                item.AllowedClasses = "43;45;44;49;50;58";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Torture
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Torture_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Torture_Lab_Hib";
                item.Name = "Torture";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 35;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 19;
                item.Item_Type = 11;
                item.Weight = 13;
                item.Model = 3674;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 4;
                item.Bonus4Type = 72;
                item.Bonus5Type = 16;
                item.Bonus6Type = 14;
                item.Bonus7Type = 18;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32170;
                item.Realm = 3;
                item.AllowedClasses = "48;43;45;47;44;49;50;46";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol

            #endregion Hib

            #endregion 1 Handed Left handed weapons

            #region 2 Handed weapons
            #region Alb
            #region Anguish
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Anguish_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Anguish_Lab_Alb";
                item.Name = "Anguish";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 6;
                item.Item_Type = 12;
                item.Weight = 44;
                item.Model = 3658;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 2;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 164;
                item.Bonus4Type = 11;
                item.Bonus5Type = 14;
                item.Bonus6Type = 12;
                item.Bonus7Type = 15;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 1;
                item.AllowedClasses = "2;1";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Aolmo's Sharpened Tine
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Aolmos_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Aolmos_Lab_Alb";
                item.Name = "Aolmo's Sharpened Tine";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 3;
                item.Object_Type = 6;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3702;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 14;
                item.Bonus3Type = 164;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2;1";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Dark Guard Great Sword
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Dark_Guard_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dark_Guard_Lab_Alb";
                item.Name = "Dark Guard Great Sword";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 6;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3701;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 14;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 14;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2;1";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Dark Guard War Spear
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "War_Spear_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "War_Spear_Lab_Alb";
                item.Name = "Dark Guard War Spear";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 3;
                item.Object_Type = 7;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3714;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 18;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Domo's Scorching Blade
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Domos_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Domos_Lab_Alb";
                item.Name = "Domo's Scorching Blade";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 6;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3701;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 13;
                item.Bonus3Type = 164;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2;1";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Fear
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Fear_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Fear_Lab_Alb";
                item.Name = "Fear";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 6;
                item.Item_Type = 12;
                item.Weight = 55;
                item.Model = 3661;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 2;
                item.Bonus1Type = 4;
                item.Bonus2Type = 1;
                item.Bonus3Type = 164;
                item.Bonus4Type = 11;
                item.Bonus5Type = 12;
                item.Bonus6Type = 14;
                item.Bonus7Type = 15;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 1;
                item.AllowedClasses = "2;1";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Hate
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Hate_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Hate_Lab_Alb";
                item.Name = "Hate";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 7;
                item.Item_Type = 12;
                item.Weight = 30;
                item.Model = 3672;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 2;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 164;
                item.Bonus4Type = 11;
                item.Bonus5Type = 12;
                item.Bonus6Type = 14;
                item.Bonus7Type = 15;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 1;
                item.AllowedClasses = "2";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Iapetus's Scathing Spear
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Iapetuss_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Iapetuss_Lab_Alb";
                item.Name = "Iapetus's Scathing Spear";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 3;
                item.Object_Type = 7;
                item.Item_Type = 12;
                item.Weight = 65;
                item.Model = 3714;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 13;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Kulgah's Smashing Rod
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Kulgahs_Rod_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Kulgahs_Rod_Lab";
                item.Name = "Kulgah's Smashing Rod";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 7;
                item.Item_Type = 12;
                item.Weight = 40;
                item.Model = 3716;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 13;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Martello de Ferar
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Martello_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Martello_Lab_Alb";
                item.Name = "Martello de Ferar";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 50;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 6;
                item.Item_Type = 12;
                item.Effect = 47;
                item.Weight = 40;
                item.Model = 3704;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 2;
                item.Bonus4 = 5;
                item.Bonus5 = 2;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 164;
                item.Bonus4Type = 194;
                item.Bonus5Type = 155;
                item.Bonus6Type = 201;
                item.Bonus7Type = 204;
                item.Bonus8Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                item.Realm = 1;
                item.AllowedClasses = "2;1";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Mnevis' Heated Halbred
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Mnevis_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Mnevis_Lab_Alb";
                item.Name = "Mnevis' Heated Halbred";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 7;
                item.Item_Type = 12;
                item.Weight = 40;
                item.Model = 3715;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 13;
                item.Bonus3Type = 164;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Murder
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Murder_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Murder_Lab_Alb";
                item.Name = "Murder";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 7;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3673;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 5;
                item.Bonus1Type = 4;
                item.Bonus2Type = 1;
                item.Bonus3Type = 164;
                item.Bonus4Type = 11;
                item.Bonus5Type = 12;
                item.Bonus6Type = 14;
                item.Bonus7Type = 14;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 1;
                item.AllowedClasses = "2";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Smash
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Smash_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Smash_Lab_Alb";
                item.Name = "Smash";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 6;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3704;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 13;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2;1";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Spite
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Spite_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Spite_Lab_Alb";
                item.Name = "Spite";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = 3;
                item.Object_Type = 6;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3657;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 2;
                item.Bonus1Type = 4;
                item.Bonus2Type = 1;
                item.Bonus3Type = 164;
                item.Bonus4Type = 11;
                item.Bonus5Type = 12;
                item.Bonus6Type = 14;
                item.Bonus7Type = 15;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 1;
                item.AllowedClasses = "2;1";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Technomancer Pick
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Technomancer_Pick_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Technomancer_Pick_Lab_Alb";
                item.Name = "Technomancer Blade";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 41;
                item.Hand = 1;
                item.Type_Damage = 3;
                item.Object_Type = 6;
                item.Item_Type = 12;
                item.Weight = 30;
                item.Model = 3700;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 21;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 164;
                item.Bonus2Type = 1;
                item.Bonus3Type = 17;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "2;1";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol

            #endregion Alb

            #region Mid
            #region Aolmo's Sharpened Battle Axe
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Aolmos_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Aolmos_Lab_Mid";
                item.Name = "Aolmo's Sharpened Battle Axe";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 13;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3705;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 54;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "31;32;23;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Dark Guard Great Sword
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Dark_Guard_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dark_Guard_Lab_Mid";
                item.Name = "Dark Guard Great Sword";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 11;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3701;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 14;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 18;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "31;25;32;23;24;21;34;59";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Dark Guard War Spear
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "War_Spear_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "War_Spear_Lab_Mid";
                item.Name = "Dark Guard War Spear";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 3;
                item.Object_Type = 14;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3714;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 56;
                item.Bonus3Type = 18;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "25;34";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Domo's Scorching Blade
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Domos_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Domos_Lab_Mid";
                item.Name = "Domo's Scorching Blade";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 11;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3701;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 164;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "31;25;32;23;24;21;34;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Fear
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Fear_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Fear_Lab_Mid";
                item.Name = "Fear";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 12;
                item.Item_Type = 12;
                item.Weight = 55;
                item.Model = 3661;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 2;
                item.Bonus1Type = 4;
                item.Bonus2Type = 1;
                item.Bonus3Type = 164;
                item.Bonus4Type = 11;
                item.Bonus5Type = 12;
                item.Bonus6Type = 14;
                item.Bonus7Type = 15;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 2;
                item.AllowedClasses = "31;26;32;28;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Iapetus's Scathing Spear
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Iapetuss_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Iapetuss_Lab_Mid";
                item.Name = "Iapetus's Scathing Spear";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 3;
                item.Object_Type = 14;
                item.Item_Type = 12;
                item.Weight = 65;
                item.Model = 3714;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 56;
                item.Bonus3Type = 13;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "25;34";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Martello de Ferar
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Martello_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Martello_Lab_Mid";
                item.Name = "Martello de Ferar";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 50;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 12;
                item.Item_Type = 12;
                item.Effect = 47;
                item.Weight = 40;
                item.Model = 3704;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 2;
                item.Bonus4 = 5;
                item.Bonus5 = 2;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 164;
                item.Bonus4Type = 194;
                item.Bonus5Type = 155;
                item.Bonus6Type = 201;
                item.Bonus7Type = 204;
                item.Bonus8Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                item.Realm = 2;
                item.AllowedClasses = "31;26;32;28;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Outrage
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Outrage_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Outrage_Lab_Mid";
                item.Name = "Outrage ";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = 3;
                item.Object_Type = 14;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3671;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 2;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 56;
                item.Bonus4Type = 11;
                item.Bonus5Type = 12;
                item.Bonus6Type = 14;
                item.Bonus7Type = 15;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 2;
                item.AllowedClasses = "25;34";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Smash
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Smash_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Smash_Lab_Mid";
                item.Name = "Smash";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 12;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3704;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 13;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "31;26;32;28;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Spite
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Spite_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Spite_Lab_Mid";
                item.Name = "Spite";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Type_Damage = 2;
                item.Object_Type = 12;
                item.Item_Type = 10;
                item.Weight = 50;
                item.Model = 3675;
                item.Bonus = 35;
                item.Bonus1 = 19;
                item.Bonus2 = 2;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 19;
                item.Bonus7 = 5;
                item.Bonus8 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 163;
                item.Bonus3Type = 11;
                item.Bonus4Type = 12;
                item.Bonus5Type = 15;
                item.Bonus6Type = 156;
                item.Bonus7Type = 196;
                item.Bonus8Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 100;
                item.MaxCharges = 100;
                item.SpellID = 65200;
                item.Realm = 2;
                item.AllowedClasses = "31;26;32;28;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Technomancer Great Axe
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Technomancer_Great_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Technomancer_Great_Lab_Mid";
                item.Name = "Technomancer Great Axe";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 13;
                item.Item_Type = 12;
                item.Weight = 30;
                item.Model = 3705;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 21;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 54;
                item.Bonus2Type = 1;
                item.Bonus3Type = 17;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "31;32;23;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Torture
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Torture_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Torture_Lab_Mid";
                item.Name = "Torture";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 35;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 13;
                item.Item_Type = 12;
                item.Weight = 13;
                item.Model = 3662;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 2;
                item.Bonus9 = 3;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 11;
                item.Bonus4Type = 72;
                item.Bonus5Type = 16;
                item.Bonus6Type = 14;
                item.Bonus7Type = 18;
                item.Bonus8Type = 155;
                item.Bonus9Type = 12;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32170;
                item.Realm = 2;
                item.AllowedClasses = "31;32;23;24;21;22";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol


            #endregion Mid

            #region Hib
            #region Aolmo's Sharpened Scythe
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Aolmos_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Aolmos_Lab_Hib";
                item.Name = "Aolmo's Sharpened Scythe";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 26;
                item.Item_Type = 12;
                item.Weight = 40;
                item.Model = 3708;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 13;
                item.Bonus3Type = 164;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "56";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Dark Guard Great Sword
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Dark_Guard_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dark_Guard_Lab_Hib";
                item.Name = "Dark Guard Great Sword";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 22;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3701;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 14;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 14;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "45;44";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Dark Guard War Spear
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "War_Spear_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "War_Spear_Lab_Hib";
                item.Name = "Dark Guard War Spear";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 3;
                item.Object_Type = 23;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3714;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 4;
                item.Bonus2Type = 164;
                item.Bonus3Type = 18;
                item.Bonus4Type = 204;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "44";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Domo's Scorching Blade
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Domos_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Domos_Lab_Hib";
                item.Name = "Domo's Scorching Blade";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 22;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3701;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 13;
                item.Bonus3Type = 164;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "45;44";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Hatred
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Hatred_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Hatred_Lab_Hib";
                item.Name = "Hatred";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 39;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 23;
                item.Item_Type = 12;
                item.Weight = 12;
                item.Model = 3660;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 2;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 82;
                item.Bonus4Type = 11;
                item.Bonus5Type = 12;
                item.Bonus6Type = 14;
                item.Bonus7Type = 15;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 3;
                item.AllowedClasses = "44";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Iapetus's Scathing Spear
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Iapetuss_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Iapetuss_Lab_Hib";
                item.Name = "Iapetus's Scathing Spear";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 3;
                item.Object_Type = 23;
                item.Item_Type = 12;
                item.Weight = 65;
                item.Model = 3714;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 13;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "44";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Kulgah's Scathing Scythe
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Kulgahs_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Kulgahs_Lab_Hib";
                item.Name = "Kulgah's Scathing Scythe";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 46;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 26;
                item.Item_Type = 12;
                item.Weight = 40;
                item.Model = 3708;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 4;
                item.Bonus2Type = 164;
                item.Bonus3Type = 17;
                item.Bonus4Type = 204;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "56";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Martello de Ferar
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Martello_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Martello_Lab_Alb";
                item.Name = "Martello de Ferar";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 50;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 22;
                item.Item_Type = 12;
                item.Effect = 47;
                item.Weight = 40;
                item.Model = 3704;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 2;
                item.Bonus4 = 5;
                item.Bonus5 = 2;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 164;
                item.Bonus4Type = 194;
                item.Bonus5Type = 155;
                item.Bonus6Type = 201;
                item.Bonus7Type = 204;
                item.Bonus8Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                item.Realm = 3;
                item.AllowedClasses = "45;44";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Murder
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Murder_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Murder_Lab_Hib";
                item.Name = "Murder";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 22;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3673;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 2;
                item.Bonus1Type = 4;
                item.Bonus2Type = 1;
                item.Bonus3Type = 164;
                item.Bonus4Type = 11;
                item.Bonus5Type = 12;
                item.Bonus6Type = 14;
                item.Bonus7Type = 14;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 3;
                item.AllowedClasses = "45;44";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Outrage
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Outrage_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Outrage_Lab_Hib";
                item.Name = "Outrage ";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 22;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3661;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 2;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 75;
                item.Bonus4Type = 11;
                item.Bonus5Type = 12;
                item.Bonus6Type = 14;
                item.Bonus7Type = 15;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 3;
                item.AllowedClasses = "45;44";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Smash
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Smash_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Smash_Lab_Hib";
                item.Name = "Smash";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 22;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3704;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 1;
                item.Bonus2Type = 164;
                item.Bonus3Type = 13;
                item.Bonus4Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "45;44";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Spite
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Spite_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Spite_Lab_Hib";
                item.Name = "Spite";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 26;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3665;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 2;
                item.Bonus1Type = 4;
                item.Bonus2Type = 1;
                item.Bonus3Type = 90;
                item.Bonus4Type = 11;
                item.Bonus5Type = 12;
                item.Bonus6Type = 14;
                item.Bonus7Type = 15;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32306;
                item.Realm = 3;
                item.AllowedClasses = "56";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Technomancer Scythe
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Technomancer_Scythe_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Technomancer_Scythe_Lab_Hib";
                item.Name = "Technomancer Scythe";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 2;
                item.Object_Type = 26;
                item.Item_Type = 12;
                item.Weight = 30;
                item.Model = 3708;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 21;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 163;
                item.Bonus2Type = 156;
                item.Bonus3Type = 17;
                item.Bonus4Type = 209;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "56";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #endregion Hib

            #endregion 2 Handed weapons

            #region Bows / CrossBow
            #region Alb
            #region Eous's Crossbow
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Eouss_Crossbow_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Eouss_Crossbow_Lab";
                item.Name = "Eous's Crossbow";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Object_Type = 10;
                item.Item_Type = 13;
                item.Weight = 25;
                item.Model = 3699;
                item.Bonus = 35;
                item.Bonus1 = 7;
                item.Bonus2 = 30;
                item.Bonus1Type = 168;
                item.Bonus2Type = 4;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.AllowedClasses = "2;9";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Eous's Short Bow
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Eouss_Short_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Eouss_Short_Lab";
                item.Name = "Eous's Short Bow";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Hand = 1;
                item.Object_Type = 10;
                item.Item_Type = (int)eInventorySlot.DistanceWeapon; ;
                item.Weight = 25;
                item.Model = 3707;
                item.Bonus = 35;
                item.Bonus1 = 7;
                item.Bonus2 = 30;
                item.Bonus1Type = 168;
                item.Bonus2Type = 2;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.AllowedClasses = "11";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Eous's Long Bow
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Eouss_Long_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Eouss_Long_Lab";
                item.Name = "Eous's Long Bow";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Object_Type = 9;
                item.Item_Type = 13;
                item.Weight = 25;
                item.Model = 3706;
                item.Bonus = 35;
                item.Bonus1 = 7;
                item.Bonus2 = 30;
                item.Bonus1Type = 168;
                item.Bonus2Type = 2;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.AllowedClasses = "3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Galvorne's Perfected Bow
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Perfected_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Perfected_Lab_Alb";
                item.Name = "Galvorne's Perfected Bow ";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Object_Type = 9;
                item.Item_Type = 13;
                item.Weight = 30;
                item.Model = 3706;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 2;
                item.Bonus2Type = 168;
                item.Bonus3Type = 13;
                item.Bonus4Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Remorseless
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Remorseless_Lab_Alb");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Remorseless_Lab_Alb";
                item.Name = "Remorseless";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Object_Type = 9;
                item.Item_Type = 13;
                item.Weight = 50;
                item.Model = 3663;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 39;
                item.Bonus3 = 2;
                item.Bonus4 = 2;
                item.Bonus1Type = 168;
                item.Bonus2Type = 2;
                item.Bonus3Type = 188;
                item.Bonus4Type = 154;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "3";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol


            #endregion Alb

            #region Mid
            #region Eous's Composite Bow
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Eouss_Composite_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Eouss_Composite_Lab";
                item.Name = "Eous's Composite Bow";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Object_Type = 15;
                item.Item_Type = 13;
                item.Weight = 25;
                item.Model = 3706;
                item.Bonus = 35;
                item.Bonus1 = 7;
                item.Bonus2 = 30;
                item.Bonus1Type = 168;
                item.Bonus2Type = 2;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.AllowedClasses = "25";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Galvorne's Perfected Bow
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Perfected_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Perfected_Lab_Mid";
                item.Name = "Galvorne's Perfected Bow";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Object_Type = 15;
                item.Item_Type = 13;
                item.Weight = 30;
                item.Model = 3706;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 2;
                item.Bonus2Type = 168;
                item.Bonus3Type = 13;
                item.Bonus4Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                item.AllowedClasses = "25";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Remorseless
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Remorseless_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Remorseless_Lab_Mid";
                item.Name = "Remorseless";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Object_Type = 15;
                item.Item_Type = 13;
                item.Weight = 50;
                item.Model = 3663;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 39;
                item.Bonus3 = 2;
                item.Bonus4 = 2;
                item.Bonus1Type = 168;
                item.Bonus2Type = 2;
                item.Bonus3Type = 188;
                item.Bonus4Type = 154;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 11431;
                item.Realm = 2;
                item.AllowedClasses = "25";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol

            #endregion Mid

            #region Hib
            #region Eous's Composite Bow
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Eouss_Recurved_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Eouss_Recurved_Lab";
                item.Name = "Eous's Recurved Bow";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 33;
                item.Object_Type = 18;
                item.Item_Type = 13;
                item.Weight = 25;
                item.Model = 3706;
                item.Bonus = 35;
                item.Bonus1 = 37;
                item.Bonus2 = 37;
                item.Bonus1Type = 4;
                item.Bonus2Type = 2;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.AllowedClasses = "50";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Galvorne's Perfected Bow
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Perfected_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Perfected_Lab_Hib";
                item.Name = "Galvorne's Perfected Bow";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Object_Type = 18;
                item.Item_Type = 13;
                item.Weight = 30;
                item.Model = 3706;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 8;
                item.Bonus1Type = 2;
                item.Bonus2Type = 168;
                item.Bonus3Type = 13;
                item.Bonus4Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 3;
                item.AllowedClasses = "50";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Remorseless
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Remorseless_Lab_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Remorseless_Lab_Hib";
                item.Name = "Remorseless";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 57;
                item.Hand = 1;
                item.Object_Type = 18;
                item.Item_Type = 13;
                item.Weight = 50;
                item.Model = 3663;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 39;
                item.Bonus3 = 2;
                item.Bonus4 = 2;
                item.Bonus1Type = 168;
                item.Bonus2Type = 2;
                item.Bonus3Type = 188;
                item.Bonus4Type = 154;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 11431;
                item.Realm = 2;
                item.AllowedClasses = "50";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol


            #endregion Hib

            #endregion Bows

            #region Staffs

            #region Disenchanted
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Disenchanted_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Disenchanted_Lab";
                item.Name = "Disenchanted";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 45;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 8;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3666;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 3;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 15;
                item.Bonus7 = 50;
                item.Bonus8 = 2;
                item.Bonus9 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 163;
                item.Bonus3Type = 11;
                item.Bonus4Type = 12;
                item.Bonus5Type = 15;
                item.Bonus6Type = 156;
                item.Bonus7Type = 165;
                item.Bonus8Type = 191;
                item.Bonus9Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 100;
                item.MaxCharges = 100;
                item.SpellID = 65200;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Nok's Stolen Quarterstaff
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Nok_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Nok_Lab";
                item.Name = "Nok's Stolen Quarterstaff";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 46;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 8;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3709;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 4;
                item.Bonus2Type = 13;
                item.Bonus3Type = 173;
                item.Bonus4Type = 204;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "10";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Nok's Stolen Quarterstaff (classic)
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Noks_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Noks_Lab";
                item.Name = "Nok's Stolen Quarterstaff";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 46;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 8;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3709;
                item.Bonus = 35;
                item.Bonus1 = 21;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 4;
                item.Bonus2Type = 13;
                item.Bonus3Type = 164;
                item.Bonus4Type = 204;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14358;
                item.Realm = 1;
                item.AllowedClasses = "10";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Privere's Punisher
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Punisher_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Punisher_Lab";
                item.Name = "Privere's Punisher";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 53;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 8;
                item.Item_Type = 12;
                item.Effect = 91;
                item.Weight = 50;
                item.Model = 3666;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 2;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus10 = 2;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 48;
                item.Bonus4Type = 163;
                item.Bonus5Type = 155;
                item.Bonus6Type = 148;
                item.Bonus7Type = 196;
                item.Bonus8Type = 202;
                item.Bonus9Type = 204;
                item.Bonus10Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                item.Realm = 1;
                item.AllowedClasses = "10";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Succor
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Succor_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Succor_Lab";
                item.Name = "Succor";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 55;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 12;
                item.Item_Type = 12;
                item.Weight = 50;
                item.Model = 3666;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 3;
                item.Bonus9 = 3;
                item.Bonus10 = 2;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 48;
                item.Bonus4Type = 12;
                item.Bonus5Type = 15;
                item.Bonus6Type = 14;
                item.Bonus7Type = 15;
                item.Bonus8Type = 16;
                item.Bonus9Type = 18;
                item.Bonus10Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                item.Realm = 1;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Pelgar's Insanity Stave
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Pelgars_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Pelgars_Lab";
                item.Name = "Pelgar's Insanity Stave";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Hand = 1;
                item.Type_Damage = 1;
                item.Object_Type = 8;
                item.Item_Type = 12;
                item.Weight = 25;
                item.Model = 3710;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus3 = 21;
                item.Bonus4 = 10;
                item.Bonus5 = 50;
                item.Bonus1Type = 163;
                item.Bonus2Type = 16;
                item.Bonus3Type = 156;
                item.Bonus4Type = 209;
                item.Bonus5Type = 165;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 100;
                item.MaxCharges = 100;
                item.SpellID = 40004;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol

            #endregion Staffs

            #region Harp
            #region Uruo the Inane's Harp
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Uruo_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Uruo_Lab";
                item.Name = "Uruo the Inane's Harp";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 30;
                item.Hand = 0;
                item.Object_Type = 45;
                item.Item_Type = 13;
                item.Weight = 25;
                item.Model = 3731;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 21;
                item.Bonus3 = 4;
                item.Bonus4 = 10;
                item.Bonus1Type = 163;
                item.Bonus2Type = 2;
                item.Bonus3Type = 19;
                item.Bonus4Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Charges = 100;
                item.MaxCharges = 100;
                item.SpellID = 45000;
                item.AllowedClasses = "4;48";
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #endregion Harp

            // New items added YOU NEED TO EDIT POISONED THROWING WEAPONS TO ADD IT!
            #region Poisoned Throwing Dagger
            /* Delete This line to add to database. 
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Throwing_Lab_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Throwing_Lab_Mid";
                item.Name = "Poisoned Throwing Dagger";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 95;
                item.DPS_AF = 165;
                item.SPD_ABS = 40;
                item.Type_Damage = 2;
                item.Object_Type = 16;
                item.Item_Type = 13;
                item.Weight = 1;
                item.Model = 3717;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 3;
                item.Bonus1Type = 91;
                item.Bonus2Type = 154;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                item.Gold = 100;
                item.MaxCount = 100;
                item.PackSize = 100;
                item.ProcSpellID = 14358;
                item.Realm = 2;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            */
            // Delete this line too!
            #endregion Aegbarol
            #endregion weapons

            #region Shields
            #region Small Shields

            #region Engrained Buckler of the Labyrinth
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Buckler_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Buckler_Lab";
                item.Name = "Engrained Buckler of the Labyrinth";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 35;
                item.Hand = 2;
                item.Type_Damage = 1;
                item.Object_Type = 42;
                item.Item_Type = 11;
                item.Weight = 50;
                item.Model = 3668;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 3;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 18;
                item.Bonus7 = 1;
                item.Bonus8 = 3;
                item.Bonus1Type = 2;
                item.Bonus2Type = 163;
                item.Bonus3Type = 14;
                item.Bonus4Type = 16;
                item.Bonus5Type = 18;
                item.Bonus6Type = 156;
                item.Bonus7Type = 191;
                item.Bonus8Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Infused Buckler of the Labyrinth
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Buckler_Aegis_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Buckler_Aegis_Lab";
                item.Name = "Infused Buckler of the Labyrinth";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 32;
                item.Hand = 2;
                item.Type_Damage = 1;
                item.Object_Type = 42;
                item.Item_Type = 11;
                item.Weight = 35;
                item.Model = 3711;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 4;
                item.Bonus2Type = 2;
                item.Bonus3Type = 1;
                item.Bonus4Type = 43;
                item.Bonus5Type = 14;
                item.Bonus6Type = 16;
                item.Bonus7Type = 18;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #endregion Small Shields

            #region Medium Shields

            #region Engrained Aegis of the Labyrinth
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Aegis_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Aegis_Lab";
                item.Name = "Engrained Aegis of the Labyrinth";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 35;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 42;
                item.Item_Type = 11;
                item.Weight = 50;
                item.Model = 3669;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 4;
                item.Bonus4Type = 43;
                item.Bonus5Type = 14;
                item.Bonus6Type = 16;
                item.Bonus7Type = 18;
                item.Bonus8Type = 169;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Infused Aegis of the Labyrinth
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Infused_Aegis_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Infused_Aegis_Lab";
                item.Name = "Infused Aegis of the Labyrinth";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 42;
                item.Item_Type = 11;
                item.Weight = 35;
                item.Model = 3712;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 4;
                item.Bonus2Type = 2;
                item.Bonus3Type = 1;
                item.Bonus4Type = 43;
                item.Bonus5Type = 14;
                item.Bonus6Type = 16;
                item.Bonus7Type = 18;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Infused Guard of the Labyrinth
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Infused_Guard_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Infused_Guard_Lab";
                item.Name = "Infused Guard of the Labyrinth";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 37;
                item.Hand = 2;
                item.Type_Damage = 2;
                item.Object_Type = 42;
                item.Item_Type = 11;
                item.Weight = 35;
                item.Model = 3669;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 3;
                item.Bonus3 = 3;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 18;
                item.Bonus7 = 1;
                item.Bonus8 = 3;
                item.Bonus1Type = 2;
                item.Bonus2Type = 163;
                item.Bonus3Type = 14;
                item.Bonus4Type = 16;
                item.Bonus5Type = 18;
                item.Bonus6Type = 156;
                item.Bonus7Type = 191;
                item.Bonus8Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol

            #endregion Medium Shields

            #region Large Shields

            #region Engrained Protector of the Labyrinth
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Protector_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Protector_Lab";
                item.Name = "Engrained Protector of the Labyrinth";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 35;
                item.Hand = 2;
                item.Type_Damage = 3;
                item.Object_Type = 42;
                item.Item_Type = 11;
                item.Weight = 50;
                item.Model = 3670;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 4;
                item.Bonus4Type = 43;
                item.Bonus5Type = 14;
                item.Bonus6Type = 16;
                item.Bonus7Type = 18;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol
            #region Infused Protector of the Labyrinth
            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>( "Infused_Aegis_Lab");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Infused_Aegis_Lab";
                item.Name = "Infused Protector of the Labyrinth";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 165;
                item.SPD_ABS = 42;
                item.Hand = 2;
                item.Type_Damage = 3;
                item.Object_Type = 42;
                item.Item_Type = 11;
                item.Weight = 35;
                item.Model = 3713;
                item.Bonus = 35;
                item.Bonus1 = 12;
                item.Bonus2 = 12;
                item.Bonus3 = 12;
                item.Bonus4 = 3;
                item.Bonus5 = 3;
                item.Bonus6 = 3;
                item.Bonus7 = 3;
                item.Bonus8 = 1;
                item.Bonus1Type = 4;
                item.Bonus2Type = 2;
                item.Bonus3Type = 1;
                item.Bonus4Type = 43;
                item.Bonus5Type = 14;
                item.Bonus6Type = 16;
                item.Bonus7Type = 18;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.CanDropAsLoot = true;
                item.IsTradable = true;
                int Silver = 50;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 14276;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            #endregion Aegbarol

            #endregion Large Shields
            #endregion Shields

        }

    #region Albion Labyrinth Weapons


    public class AlbLabWeaps
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {

            MerchantItem m_item = null;
            m_item = (MerchantItem)GameServer.Database.SelectObject<MerchantItem> ("ItemListID='AlbLabWeaps'");
            if (m_item == null)
            {
                #region Merchant Items

                #region Page 1 Alb
                // main hand weapons 

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Foremans_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Ifocezases_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Indignation_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Indy_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Outrage_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Reformation_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Revenge_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Swines_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Technomancer_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                // Lefthand weapons

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Aegbarol_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Anger_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Crusher_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Danger_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Saztsohs_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Moment_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Torture_Lab_Alb";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                // Shields

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Buckler_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 18;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Buckler_Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 19;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);




                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 21;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Infused_Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 22;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Infused_Guard_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 23;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Protector_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 25;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Infused_Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 26;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                #endregion Page 1 alb

                #region Page 2 Alb

                // 2 Handed

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Anguish_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Aolmos_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Dark_Guard_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "War_Spear_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Domos_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Fear_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Hate_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Iapetuss_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Kulgahs_Rod_Lab";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Martello_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Mnevis_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Murder_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Smash_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Spite_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Technomancer_Pick_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                #endregion page 2 alb

                #region Page 3 Alb

                // Bows
                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Eouss_Crossbow_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Eouss_Short_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Eous's Long Bow";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Perfected_Lab_Alb";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Remorseless_Lab_Alb";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                // Harp

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Uruo_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                // Staffs

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Disenchanted_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Nok_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Noks_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Punisher_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Succor_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "AlbLabWeaps";
                m_item.ItemTemplateID = "Pelgars_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                #endregion Page 3 Alb


                #endregion Merchant Items
            }


        }
    }
    #endregion

    #region Midgard Labyrinth Weapons

    public class MidLabWeaps
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            MerchantItem m_item = null;
            m_item = (MerchantItem)GameServer.Database.SelectObject<MerchantItem>( "ItemListID='MidLabWeaps'");
            if (m_item == null)
            {
                #region Midgard Merchant Items

                // Main Hand Weapons, Lhand weapons and Shields

                #region Page 1 Mid
                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Anger_Axe_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Anguish_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Crusher_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Danger_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Foremans_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Indy_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Mnevis_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Murder_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Revenge_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Technomancer_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Moment_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                // Weapons that can used in LeftHand

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Aegbarol_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Anger_LeftAxe_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Hatred_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Kulgahs_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Smash_Lab_Mid";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "The_One_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 17;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                // Shields

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Buckler_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 19;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Buckler_Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 20;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);




                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 22;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Infused_Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 23;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Infused_Guard_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 24;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Protector_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 26;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Infused_Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 27;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                #endregion Page 1 Mid

                // 2 Handed Weapons

                #region Page 2 Mid

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Aolmos_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Dark_Guard_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "War_Spear_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Domos_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Fear_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Iapetuss_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Martello_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Outrage_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Smash_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Spite_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Technomancer_Great_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Torture_Lab_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);




                #endregion Page 2 Mid

                // Staffs / Bows / Throwing weapon

                #region Page 3 Mid

                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Eouss_Composite_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Perfected_Lab_Mid";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Remorseless_Lab_Mid";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "MidLabWeaps";
                m_item.ItemTemplateID = "Pelgars_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                /* Delete this line if you want to add Throwing weapons to the merchant!
                m_item = new MerchantItem();
                m_item.ItemListID = "Throwing_Lab_Mid";
                m_item.ItemTemplateID = "Pelgars_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                 
                */
                // Delete this line too!






                #endregion Page 3 Mid

                #endregion Midgard Labyrinth Weapons
            }
        }
    }
    #endregion Midgard Labyrinth Weapons

    #region Hibernia Labyrinth Weapons

    public class HibLabWeaps
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            MerchantItem m_item = null;
            m_item = (MerchantItem)GameServer.Database.SelectObject<MerchantItem>( "ItemListID='HibLabWeaps'");
            if (m_item == null)
            {



                #region Hibernia Merchant Items

                // Main Hand, Lefthand, Shields
                #region Page 1 Hib

                // Main hand weapons
                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Anguish_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Crusher_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Foremans_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Mnevis_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Technomancer_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                // Weapons that can be used in left hand
                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Aegbarol_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Anger_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Danger_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Fear_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Saztsohs_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Smash_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Moment_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Torture_Lab_Hib";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                // Shields

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Buckler_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Buckler_Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);




                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 18;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Infused_Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 19;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Infused_Guard_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 20;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Protector_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 22;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Infused_Aegis_Lab";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 23;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);






                #endregion Page 1 Hib

                // 2 Handed Weapons
                #region Page 2 Hib

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Aolmos_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Dark_Guard_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "War_Spear_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Domos_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Hatred_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Iapetuss_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Kulgahs_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Martello_Lab_Alb";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Murder_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);



                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Outrage_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Smash_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Spite_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Technomancer_Scythe_Lab_Hib";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                #endregion Page 2 Hib

                // Staffs / Bows / Harp
                #region Page 3 Hib

                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Eouss_Recurved_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Perfected_Lab_Hib";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Remorseless_Lab_Hib";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Pelgars_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                m_item = new MerchantItem();
                m_item.ItemListID = "HibLabWeaps";
                m_item.ItemTemplateID = "Uruo_Lab";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);


                #endregion Page 3 Hib

                #endregion Hibernia Merchant Items

            }
        }
    }

    #endregion

    }
}
