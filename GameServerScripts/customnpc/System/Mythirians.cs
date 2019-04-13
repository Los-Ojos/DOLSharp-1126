/* ----------------------
 * Mythirians
 * ♥ Yemla ♥
*/

using System;
using System.Reflection;

using DOL.GS.PacketHandler;
using DOL.Database;
using DOL.Events;

using log4net;

namespace DOL.GS.Items
{
    public class Mythirians
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            ItemTemplate item = null;


            //Mythirian CL6

            #region lesser_mythirian_of_health

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_mythirian_of_health");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_mythirian_of_health";
                item.Name = "Lesser Mythirian of Health";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 20;
                item.Bonus1Type = 150;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_mythirian_of_health
            //HP Regen

            #region lesser_mythirian_of_power

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_mythirian_of_power");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_mythirian_of_power";
                item.Name = "Lesser Mythirian of Power";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 5;
                item.Bonus1Type = 151;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_mythirian_of_power
            //Power Regen

            #region lesser_mythirian_of_scathing

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_mythirian_of_scathing");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_mythirian_of_scathing";
                item.Name = "Lesser Mythirian of Scathing ";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 1;
                item.Bonus1Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_mythirian_of_scathing
            //DPS Buff

            #region lesser_mythirian_of_focal

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_mythirian_of_focal");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_mythirian_of_focal";
                item.Name = "Lesser Mythirian of Focal";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 1;
                item.Bonus1Type = 198;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_mythirian_of_focal
            //Spell Buff

            #region lesser_mythirian_of_deflection

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_mythirian_of_deflection");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_mythirian_of_deflection";
                item.Name = "Lesser Mythirian of Deflection";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 2;
                item.Bonus1Type = 171;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_mythirian_of_deflection
            //Parry Buff

            #region lesser_mythirian_of_evasion

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_mythirian_of_evasion");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_mythirian_of_evasion";
                item.Name = "Lesser Mythirian of Evasion";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 2;
                item.Bonus1Type = 169;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_mythirian_of_evasion
            //Evade Buff

            #region lesser_mythirian_of_barricading

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_mythirian_of_barricading");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_mythirian_of_barricading";
                item.Name = "Lesser Mythirian of Barricading";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 2;
                item.Bonus1Type = 170;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_mythirian_of_barricading
            //Block Buff

            #region lesser_mythirian_of_guerdon

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_mythirian_of_guerdon");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_mythirian_of_guerdon";
                item.Name = "Lesser Mythirian of Guerdon";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 2;
                item.Bonus1Type = 253;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_mythirian_of_guerdon
            //Realm Point Increase Buff

            #region lesser_mythirian_of_siphoning

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_mythirian_of_siphoning");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_mythirian_of_siphoning";
                item.Name = "Lesser Mythirian of Siphoning";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 5;
                item.Bonus1Type = 254;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_mythirian_of_siphoning
            //Siphoning Buff

            #region lesser_adroit_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_adroit_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_adroit_mythirian";
                item.Name = "Lesser Adroit Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus1Type = 202;
                item.Bonus2Type = 2;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_adroit_mythirian
            //Dexterity Buff

            #region lesser_insightful_mythirain

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_insightful_mythirain");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_insightful_mythirain";
                item.Name = "Lesser Insightful Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus1Type = 209;
                item.Bonus2Type = 156;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_insightful_mythirain
            //Acuity Buff

            #region lesser_mighty_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_mighty_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_mighty_mythirian";
                item.Name = "Lesser Mighty Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus1Type = 201;
                item.Bonus2Type = 1;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_mighty_mythirian
            //Strength Buff

            #region lesser_speedy_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_speedy_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_speedy_mythirian";
                item.Name = "Lesser Speedy Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus1Type = 204;
                item.Bonus2Type = 4;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_speedy_mythirian
            //Quickness Buff

            #region lesser_tempered_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_tempered_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_tempered_mythirian";
                item.Name = "Lesser Tempered Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus1Type = 203;
                item.Bonus2Type = 3;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_tempered_mythirian
            //Constitution Buff

            #region lesser_protection_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_protection_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_protection_mythirian";
                item.Name = "Lesser Protection Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 2;
                item.Bonus2 = 2;
                item.Bonus3 = 2;
                item.Bonus4 = 2;
                item.Bonus5 = 2;
                item.Bonus6 = 2;
                item.Bonus1Type = 213;
                item.Bonus2Type = 13;
                item.Bonus3Type = 227;
                item.Bonus4Type = 17;
                item.Bonus5Type = 229;
                item.Bonus6Type = 19;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_protection_mythirian
            //Thrust-Slash-Crush Buff

            #region reinforcing_bodybender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("reinforcing_bodybender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "reinforcing_bodybender_mythirian";
                item.Name = "Reinforcing Bodybender Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 2;
                item.Bonus2 = 2;
                item.Bonus1Type = 221;
                item.Bonus2Type = 11;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion reinforcing_bodybender_mythirian
            //Body Buff

            #region reinforcing_edgebender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("reinforcing_edgebender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "reinforcing_edgebender_mythirian";
                item.Name = "Reinforcing Edgebender Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 2;
                item.Bonus2 = 2;
                item.Bonus1Type = 224;
                item.Bonus2Type = 14;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion reinforcing_edgebender_mythirian
            //Energy Buff

            #region reinforcing_heatbender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("reinforcing_heatbender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "reinforcing_heatbender_mythirian";
                item.Name = "Reinforcing Heatbender Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 2;
                item.Bonus2 = 2;
                item.Bonus1Type = 225;
                item.Bonus2Type = 15;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion reinforcing_heatbender_mythirian
            //Heat Buff

            #region reinforcing_icebender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("reinforcing_icebender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "reinforcing_icebender_mythirian";
                item.Name = "Reinforcing Icebender Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 2;
                item.Bonus2 = 2;
                item.Bonus1Type = 202;
                item.Bonus2Type = 2;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion reinforcing_icebender_mythirian
            //Cold Buff

            #region reinforcing_matterbender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("reinforcing_matterbender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "reinforcing_matterbender_mythirian";
                item.Name = "Reinforcing Matterbender Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 2;
                item.Bonus2 = 2;
                item.Bonus1Type = 226;
                item.Bonus2Type = 16;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion reinforcing_matterbender_mythirian
            //Matter Buff

            #region reinforcing_spiritbender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("reinforcing_spiritbender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "reinforcing_spiritbender_mythirian";
                item.Name = "Reinforcing Spiritbender Mythirian";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 2;
                item.Bonus2 = 2;
                item.Bonus1Type = 228;
                item.Bonus2Type = 18;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion reinforcing_spiritbender_mythirian
            //Spirit Buff

            #region lesser_warding_mythirian_of_essence

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("lesser_warding_mythirian_of_essence");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "lesser_warding_mythirian_of_essence";
                item.Name = "Lesser Warding Mythirian of Essence";
                item.Level = 6;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 6;
                item.Bonus1Type = 249;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion lesser_warding_mythirian_of_essence
            //Essence Buff



            //Mythirian CL8

            #region Average_mythirian_of_health

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_mythirian_of_health");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_mythirian_of_health";
                item.Name = "Average Mythirian of Health";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 30;
                item.Bonus1Type = 150;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_mythirian_of_health
            //HP Regen

            #region Average_mythirian_of_power

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_mythirian_of_power");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_mythirian_of_power";
                item.Name = "Average Mythirian of Power";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 10;
                item.Bonus1Type = 151;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_mythirian_of_power
            //Power Regen

            #region Average_mythirian_of_scathing

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_mythirian_of_scathing");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_mythirian_of_scathing";
                item.Name = "Average Mythirian of Scathing ";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 2;
                item.Bonus1Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_mythirian_of_scathing
            //DPS Buff

            #region Average_mythirian_of_focal

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_mythirian_of_focal");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_mythirian_of_focal";
                item.Name = "Average Mythirian of Focal";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 2;
                item.Bonus1Type = 198;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_mythirian_of_focal
            //Spell Buff

            #region Average_mythirian_of_deflection

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_mythirian_of_deflection");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_mythirian_of_deflection";
                item.Name = "Average Mythirian of Deflection";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 2;
                item.Bonus1Type = 171;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_mythirian_of_deflection
            //Parry Buff

            #region Average_mythirian_of_evasion

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_mythirian_of_evasion");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_mythirian_of_evasion";
                item.Name = "Average Mythirian of Evasion";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 4;
                item.Bonus1Type = 169;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_mythirian_of_evasion
            //Evade Buff

            #region Average_mythirian_of_barricading

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_mythirian_of_barricading");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_mythirian_of_barricading";
                item.Name = "Average Mythirian of Barricading";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 4;
                item.Bonus1Type = 170;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_mythirian_of_barricading
            //Block Buff

            #region Average_mythirian_of_guerdon

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_mythirian_of_guerdon");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_mythirian_of_guerdon";
                item.Name = "Average Mythirian of Guerdon";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 4;
                item.Bonus1Type = 253;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_mythirian_of_guerdon
            //Realm Point Increase Buff

            #region Average_mythirian_of_siphoning

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_mythirian_of_siphoning");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_mythirian_of_siphoning";
                item.Name = "Average Mythirian of Siphoning";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 10;
                item.Bonus1Type = 254;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_mythirian_of_siphoning
            //Siphoning Buff

            #region Average_adroit_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_adroit_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_adroit_mythirian";
                item.Name = "Average Adroit Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 6;
                item.Bonus2 = 6;
                item.Bonus1Type = 202;
                item.Bonus2Type = 2;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_adroit_mythirian
            //Dexterity Buff

            #region Average_insightful_mythirain

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_insightful_mythirain");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_insightful_mythirain";
                item.Name = "Average Insightful Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 6;
                item.Bonus2 = 6;
                item.Bonus1Type = 209;
                item.Bonus2Type = 156;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_insightful_mythirain
            //Acuity Buff

            #region Average_mighty_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_mighty_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_mighty_mythirian";
                item.Name = "Average Mighty Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 6;
                item.Bonus2 = 6;
                item.Bonus1Type = 201;
                item.Bonus2Type = 1;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_mighty_mythirian
            //Strength Buff

            #region Average_speedy_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_speedy_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_speedy_mythirian";
                item.Name = "Average Speedy Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 6;
                item.Bonus2 = 6;
                item.Bonus1Type = 204;
                item.Bonus2Type = 4;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_speedy_mythirian
            //Quickness Buff

            #region Average_tempered_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_tempered_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_tempered_mythirian";
                item.Name = "Average Tempered Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 6;
                item.Bonus2 = 6;
                item.Bonus1Type = 203;
                item.Bonus2Type = 3;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_tempered_mythirian
            //Constitution Buff

            #region Average_protection_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_protection_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_protection_mythirian";
                item.Name = "Average Protection Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus3 = 4;
                item.Bonus4 = 4;
                item.Bonus5 = 4;
                item.Bonus6 = 4;
                item.Bonus1Type = 213;
                item.Bonus2Type = 13;
                item.Bonus3Type = 227;
                item.Bonus4Type = 17;
                item.Bonus5Type = 229;
                item.Bonus6Type = 19;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_protection_mythirian
            //Thrust-Slash-Crush Buff

            #region protector's_bodybender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("protector's_bodybender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "protector's_bodybender_mythirian";
                item.Name = "Protector's Bodybender Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus1Type = 221;
                item.Bonus2Type = 11;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion protector's_bodybender_mythirian
            //Body Buff

            #region protector's_edgebender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("protector's_edgebender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "protector's_edgebender_mythirian";
                item.Name = "Protector's Edgebender Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus1Type = 224;
                item.Bonus2Type = 14;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion protector's_edgebender_mythirian
            //Energy Buff

            #region protector's_heatbender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("protector's_heatbender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "protector's_heatbender_mythirian";
                item.Name = "Protector's Heatbender Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus1Type = 225;
                item.Bonus2Type = 15;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion protector's_heatbender_mythirian
            //Heat Buff

            #region protector's_icebender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("protector's_icebender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "protector's_icebender_mythirian";
                item.Name = "Protector's Icebender Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus1Type = 202;
                item.Bonus2Type = 2;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion protector's_icebender_mythirian
            //Cold Buff

            #region protector's_matterbender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("protector's_matterbender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "protector's_matterbender_mythirian";
                item.Name = "Protector's Matterbender Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus1Type = 226;
                item.Bonus2Type = 16;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion protector's_matterbender_mythirian
            //Matter Buff

            #region protector's_spiritbender_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("protector's_spiritbender_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "protector's_spiritbender_mythirian";
                item.Name = "Protector's Spiritbender Mythirian";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 4;
                item.Bonus2 = 4;
                item.Bonus1Type = 228;
                item.Bonus2Type = 18;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion protector's_spiritbender_mythirian
            //Spirit Buff

            #region Average_warding_mythirian_of_essence

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("Average_warding_mythirian_of_essence");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Average_warding_mythirian_of_essence";
                item.Name = "Average Warding Mythirian of Essence";
                item.Level = 8;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3552;
                item.Bonus1 = 12;
                item.Bonus1Type = 249;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 1000;
                item.Price = 500;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Average_warding_mythirian_of_essence
            //Essence Buff



            //Mythirian CL10

            #region greater_mythirian_of_health

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_mythirian_of_health");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_mythirian_of_health";
                item.Name = "Greater Mythirian of Health";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 50;
                item.Bonus1Type = 150;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_mythirian_of_health
            //HP Regen

            #region greater_mythirian_of_power

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_mythirian_of_power");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_mythirian_of_power";
                item.Name = "Greater Mythirian of Power";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 20;
                item.Bonus1Type = 151;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_mythirian_of_power
            //Power Regen

            #region mythirian_of_endurance

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("mythirian_of_endurance");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "mythirian_of_endurance";
                item.Name = "Mythirian of Endurance";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 1;
                item.Bonus1Type = 152;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion mythirian_of_endurance
            //Endurance Regen

            #region greater_mythirian_of_scathing

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_mythirian_of_scathing");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_mythirian_of_scathing";
                item.Name = "Greater Mythirian of Scathing ";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 3;
                item.Bonus1Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_mythirian_of_scathing
            //DPS Buff

            #region greater_mythirian_of_focal

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_mythirian_of_focal");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_mythirian_of_focal";
                item.Name = "Greater Mythirian of Focal";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 3;
                item.Bonus1Type = 198;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_mythirian_of_focal
            //Spell Buff

            #region greater_mythirian_of_deflection

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_mythirian_of_deflection");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_mythirian_of_deflection";
                item.Name = "Greater Mythirian of Deflection";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 6;
                item.Bonus1Type = 171;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_mythirian_of_deflection
            //Parry Buff

            #region greater_mythirian_of_evasion

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_mythirian_of_evasion");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_mythirian_of_evasion";
                item.Name = "Greater Mythirian of Evasion";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 6;
                item.Bonus1Type = 169;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_mythirian_of_evasion
            //Evade Buff

            #region greater_mythirian_of_barricading

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_mythirian_of_barricading");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_mythirian_of_barricading";
                item.Name = "Greater Mythirian of Barricading";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 6;
                item.Bonus1Type = 170;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_mythirian_of_barricading
            //Block Buff

            #region greater_mythirian_of_guerdon

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_mythirian_of_guerdon");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_mythirian_of_guerdon";
                item.Name = "Greater Mythirian of Guerdon";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 6;
                item.Bonus1Type = 253;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_mythirian_of_guerdon
            //Realm Point Increase Buff

            #region greater_mythirian_of_siphoning

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_mythirian_of_siphoning");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_mythirian_of_siphoning";
                item.Name = "Greater Mythirian of Siphoning";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 15;
                item.Bonus1Type = 254;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_mythirian_of_siphoning
            //Siphoning Buff

            #region greater_adroit_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_adroit_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_adroit_mythirian";
                item.Name = "Greater Adroit Mythirian";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3551;
                item.Bonus1 = 8;
                item.Bonus2 = 8;
                item.Bonus1Type = 202;
                item.Bonus2Type = 2;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_adroit_mythirian
            //Dexterity Buff

            #region greater_insightful_mythirain

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_insightful_mythirain");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_insightful_mythirain";
                item.Name = "Greater Insightful Mythirian";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 8;
                item.Bonus2 = 8;
                item.Bonus1Type = 209;
                item.Bonus2Type = 156;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_insightful_mythirain
            //Acuity Buff

            #region greater_mighty_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_mighty_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_mighty_mythirian";
                item.Name = "Greater Mighty Mythirian";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 8;
                item.Bonus2 = 8;
                item.Bonus1Type = 201;
                item.Bonus2Type = 1;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_mighty_mythirian
            //Strength Buff

            #region greater_speedy_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_speedy_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_speedy_mythirian";
                item.Name = "Greater Speedy Mythirian";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 8;
                item.Bonus2 = 8;
                item.Bonus1Type = 204;
                item.Bonus2Type = 4;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_speedy_mythirian
            //Quickness Buff

            #region greater_tempered_mythirian

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_tempered_mythirian");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_tempered_mythirian";
                item.Name = "Greater Tempered Mythirian";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 8;
                item.Bonus2 = 8;
                item.Bonus1Type = 203;
                item.Bonus2Type = 3;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_tempered_mythirian
            //Constitution Buff

            #region greater_warding_mythirian_of_essence

            item = (ItemTemplate)GameServer.Database.FindObjectByKey<ItemTemplate>("greater_warding_mythirian_of_essence");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "greater_warding_mythirian_of_essence";
                item.Name = "Greater Warding Mythirian of Essence";
                item.Level = 10;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 41;
                item.Item_Type = 37;
                item.Weight = 10;
                item.Model = 3553;
                item.Bonus1 = 18;
                item.Bonus1Type = 249;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2000;
                item.MaxCount = 1;
                item.PackSize = 1;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion greater_warding_mythirian_of_essence
            //Essence Buff



            MerchantItem m_item = null;
            m_item = (MerchantItem)GameServer.Database.SelectObject<MerchantItem>("ItemListID='Mythirians'");
            if (m_item == null)
            {
                #region Merchant Items

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_mythirian_of_health";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_mythirian_of_power";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_mythirian_of_scathing";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 2;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_mythirian_of_focal";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_mythirian_of_deflection";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 4;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_mythirian_of_evasion";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 5;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_mythirian_of_barricading";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_mythirian_of_guerdon";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_mythirian_of_siphoning";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_adroit_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 10;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_insightful_mythirain";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 11;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_mighty_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_speedy_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_tempered_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_protection_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 16;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "reinforcing_bodybender_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 17;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "reinforcing_edgebender_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 18;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "reinforcing_heatbender_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 19;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "reinforcing_icebender_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 20;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "reinforcing_matterbender_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 21;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "reinforcing_spiritbender_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 22;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_warding_mythirian_of_essence";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 23;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_mythirian_of_health";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_mythirian_of_power";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_mythirian_of_scathing";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "lesser_mythirian_of_focal";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_mythirian_of_deflection";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_mythirian_of_evasion";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_mythirian_of_barricading";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_mythirian_of_guerdon";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 7;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_mythirian_of_siphoning";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_adroit_mythirian";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 10;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_insightful_mythirain";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 11;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_mighty_mythirian";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 12;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_speedy_mythirian";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 13;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_tempered_mythirian";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 14;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_protection_mythirian";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 16;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "protector's_bodybender_mythirian";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 17;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "protector's_edgebender_mythirian";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 18;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "protector's_heatbender_mythirian";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 19;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "protector's_icebender_mythirian";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 20;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "protector's_matterbender_mythirian";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 21;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "protector's_spiritbender_mythirian";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 22;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "Average_warding_mythirian_of_essence";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 23;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_mythirian_of_health";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_mythirian_of_power";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "mythirian_of_endurance";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 2;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_mythirian_of_scathing";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_mythirian_of_focal";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 4;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_mythirian_of_deflection";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 5;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_mythirian_of_evasion";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_mythirian_of_barricading";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_mythirian_of_guerdon";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_mythirian_of_siphoning";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 9;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_adroit_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 11;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_insightful_mythirain";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_mighty_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_speedy_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_tempered_mythirian";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "Mythirians";
                m_item.ItemTemplateID = "greater_warding_mythirian_of_essence";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 16;
                //m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                #endregion Merchant Items
            }
            item = null;
        }
    }
}