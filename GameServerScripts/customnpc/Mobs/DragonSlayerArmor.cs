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
 ** Made by dragonfire, i believe.
 *
 * Updated by deathwish  14/07/2010
 * Fixed couple items
 * For BPS Merchant. Items Price are set to 2500 = 2500 Bps
 * 
 * 1 Price (copper) = 1 badge. soo 100 badges per item would be 100 copper or 1 silver. 150 badges = 150 copper or 1 silver 50 copper
 */

using System;
using System.Reflection;

using DOL.GS.PacketHandler;
using DOL.Database;
using DOL.Events;

using log4net;

namespace DOL.GS.Items
{
    #region Albion Dragonslayer Items

    public class AlbionDragonItems
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            ItemTemplate item = null;

            //This checks and adds the Albion Dragonslayer Armors to your itemtemplate table.

            #region Albion Armors

            #region Albion Cloak of Magic

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Albion_Cloak_of_Magic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Albion_Cloak_of_Magic";
                item.Name = "Albion Cloak of Magic";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 32;
                item.Item_Type = 26;
                item.Weight = 20;
                item.Model = 3800;
                item.Bonus = 35;
                item.Bonus1 = 1;
                item.Bonus2 = 1;
                item.Bonus3 = 40;
                item.Bonus4 = 1;
                item.Bonus5 = 3;
                item.Bonus6 = 40;
                item.Bonus7 = 6;
                item.Bonus8 = 6;
                item.Bonus9 = 6;
                item.Bonus10 = 1;
                item.Bonus1Type = 13;
                item.Bonus2Type = 17;
                item.Bonus3Type = 10;
                item.Bonus4Type = 19;
                item.Bonus5Type = 163;
                item.Bonus6Type = 210;
                item.Bonus7Type = 3;
                item.Bonus8Type = 2;
                item.Bonus9Type = 156;
                item.Bonus10Type = 198;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Albion Cloak of Magic

            #region Albion Cloak of Might

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Albion_Cloak_of_Might");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Albion_Cloak_of_Might";
                item.Name = "Albion Cloak of Might";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 32;
                item.Item_Type = 26;
                item.Weight = 20;
                item.Model = 3800;
                item.Bonus = 35;
                item.Bonus1 = 1;
                item.Bonus2 = 1;
                item.Bonus3 = 40;
                item.Bonus4 = 1;
                item.Bonus5 = 3;
                item.Bonus6 = 40;
                item.Bonus7 = 6;
                item.Bonus8 = 6;
                item.Bonus9 = 6;
                item.Bonus10 = 1;
                item.Bonus1Type = 16;
                item.Bonus2Type = 18;
                item.Bonus3Type = 10;
                item.Bonus4Type = 14;
                item.Bonus5Type = 164;
                item.Bonus6Type = 210;
                item.Bonus7Type = 3;
                item.Bonus8Type = 2;
                item.Bonus9Type = 1;
                item.Bonus10Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Albion Cloak of Might

            #region Dragonslayer Arawnite Mail Chausses

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Arawnite_Mail_Chausses");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Arawnite_Mail_Chausses";
                item.Name = "Dragonslayer Arawnite Mail Chausses";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 27;
                item.Weight = 46;
                item.Model = 3996;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 202;
                item.Bonus7Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Arawnite Mail Chausses

            #region Dragonslayer Arawnite Mail Hauberk

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Arawnite_Mail_Hauberk");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Arawnite_Mail_Hauberk";
                item.Name = "Dragonslayer Arawnite Mail Hauberk";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 25;
                item.Weight = 47;
                item.Model = 3995;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 173;
                item.Bonus7Type = 200;
                item.Bonus8Type = 198;
                item.Bonus9Type = 153;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Arawnite Mail Hauberk

            #region Dragonslayer Blessed Leather Shoes

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Blessed_Leather_Shoes");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Blessed_Leather_Shoes";
                item.Name = "Dragonslayer Blessed Leather Shoes";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 23;
                item.Weight = 32;
                item.Model = 3994;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 6;
                item.Bonus1Type = 3;
                item.Bonus2Type = 2;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 195;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Blessed Leather Shoes

            #region Dragonslayer Blessed Leather Sleeves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Blessed_Leather_Sleeves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Blessed_Leather_Sleeves";
                item.Name = "Dragonslayer Blessed Leather Sleeves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 28;
                item.Weight = 48;
                item.Model = 3992;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 155;
                item.Bonus7Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Blessed Leather Sleeves

            #region Dragonslayer Blessed Leather Tunic

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Blessed_Leather_Tunic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Blessed_Leather_Tunic";
                item.Name = "Dragonslayer Blessed Leather Tunic";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 3990;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 191;
                item.Bonus7Type = 200;
                item.Bonus8Type = 173;
                item.Bonus9Type = 153;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Blessed Leather Tunic

            #region Dragonslayer Blessed Leather Tunic (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Blessed_Leather_Tunic_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Blessed_Leather_Tunic_classic";
                item.Name = "Dragonslayer Blessed Leather Tunic (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 3990;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 2;
                item.Bonus1Type = 2;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 202;
                item.Bonus7Type = 204;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Blessed Leather Tunic (classic)

            #region Dragonslayer Cloth Breeches

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Cloth_Breeches");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Cloth_Breeches";
                item.Name = "Dragonslayer Cloth Breeches";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 27;
                item.Weight = 14;
                item.Model = 4016;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 1;
                item.Bonus6 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 191;
                item.Bonus6Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Cloth Breeches

            #region Dragonslayer Cloth Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Cloth_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Cloth_Full_Helm";
                item.Name = "Dragonslayer Cloth Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 21;
                item.Weight = 8;
                item.Model = 4056;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Cloth Full Helm

            #region Dragonslayer Cloth Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Cloth_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Cloth_Gloves";
                item.Name = "Dragonslayer Cloth Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 22;
                item.Weight = 8;
                item.Model = 4018;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 40;
                item.Bonus5 = 3;
                item.Bonus6 = 40;
                item.Bonus7 = 6;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 10;
                item.Bonus5Type = 163;
                item.Bonus6Type = 210;
                item.Bonus7Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Cloth Gloves

            #region Dragonslayer Cloth Robes (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Cloth_Robes_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Cloth_Robes_classic";
                item.Name = "Dragonslayer Cloth Robes (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 25;
                item.Weight = 20;
                item.Model = 4015;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 22;
                item.Bonus6 = 5;
                item.Bonus7 = 2;
                item.Bonus8 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 156;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.Bonus8Type = 209;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Cloth Robes (classic)

            #region Dragonslayer Cloth Sleeves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Cloth_Sleeves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Cloth_Sleeves";
                item.Name = "Dragonslayer Cloth Sleeves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 28;
                item.Weight = 12;
                item.Model = 4017;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 40;
                item.Bonus5 = 22;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 10;
                item.Bonus5Type = 156;
                item.Bonus6Type = 191;
                item.Bonus7Type = 209;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Cloth Sleeves

            #region Dragonslayer Cloth Slippers

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Cloth_Slippers");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Cloth_Slippers";
                item.Name = "Dragonslayer Cloth Sleeves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 23;
                item.Weight = 8;
                item.Model = 4019;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 18;
                item.Bonus6 = 6;
                item.Bonus1Type = 2;
                item.Bonus2Type = 13;
                item.Bonus3Type = 17;
                item.Bonus4Type = 19;
                item.Bonus5Type = 156;
                item.Bonus6Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Cloth Slippers

            #region Dragonslayer Hard Leather Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Hard_Leather_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Hard_Leather_Full_Helm";
                item.Name = "Dragonslayer Hard Leather Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 21;
                item.Weight = 32;
                item.Model = 4054;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Hard Leather Full Helm

            #region Dragonslayer Hard Leather Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Hard_Leather_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Hard_Leather_Gloves";
                item.Name = "Dragonslayer Hard Leather Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 22;
                item.Weight = 32;
                item.Model = 3993;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 45;
                item.Bonus5 = 3;
                item.Bonus6 = 40;
                item.Bonus7 = 10;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 10;
                item.Bonus5Type = 164;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Hard Leather Gloves

            #region Dragonslayer Hard Leather Pants

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Hard_Leather_Pants");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Hard_Leather_Pants";
                item.Name = "Dragonslayer Hard Leather Pants";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 27;
                item.Weight = 56;
                item.Model = 3991;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 155;
                item.Bonus7Type = 203;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Hard Leather Pants

            #region Dragonslayer Hard Leather Shoes

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Hard_Leather_Shoes");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Hard_Leather_Shoes";
                item.Name = "Dragonslayer Hard Leather Shoes";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 23;
                item.Weight = 32;
                item.Model = 3994;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 6;
                item.Bonus1Type = 1;
                item.Bonus2Type = 3;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 194;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Hard Leather Shoes

            #region Dragonslayer Hard Leather Sleeves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Hard_Leather_Sleeves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Hard_Leather_Sleeves";
                item.Name = "Dragonslayer Hard Leather Sleeves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 28;
                item.Weight = 48;
                item.Model = 3992;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 201;
                item.Bonus7Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Hard Leather Sleeves

            #region Dragonslayer Hard Leather Tunic

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Hard_Leather_Tunic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Hard_Leather_Tunic";
                item.Name = "Dragonslayer Hard Leather Tunic";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 3990;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 173;
                item.Bonus7Type = 200;
                item.Bonus8Type = 198;
                item.Bonus9Type = 153;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Hard Leather Tunic

            #region Dragonslayer Hard Leather Tunic (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Hard_Leather_Tunic_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Hard_Leather_Tunic_classic";
                item.Name = "Dragonslayer Hard Leather Tunic (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 3990;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 2;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 201;
                item.Bonus7Type = 203;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Hard Leather Tunic (classic)

            #region Dragonslayer Holy Mail Armguards

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Mail_Armguards");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Mail_Armguards";
                item.Name = "Dragonslayer Holy Mail Armguards";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 28;
                item.Weight = 38;
                item.Model = 3997;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 40;
                item.Bonus5 = 5;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 10;
                item.Bonus5Type = 15;
                item.Bonus6Type = 191;
                item.Bonus7Type = 209;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Mail Armguards

            #region Dragonslayer Holy Mail Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Mail_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Mail_Boots";
                item.Name = "Dragonslayer Holy Mail Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 23;
                item.Weight = 22;
                item.Model = 3999;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 18;
                item.Bonus6 = 6;
                item.Bonus1Type = 2;
                item.Bonus2Type = 13;
                item.Bonus3Type = 17;
                item.Bonus4Type = 19;
                item.Bonus5Type = 156;
                item.Bonus6Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Mail Boots

            #region Dragonslayer Holy Mail Chausses

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Mail_Chausses");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Mail_Chausses";
                item.Name = "Dragonslayer Holy Mail Chausses";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 27;
                item.Weight = 46;
                item.Model = 3996;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 40;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 3;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 10;
                item.Bonus5Type = 15;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Mail Chausses

            #region Dragonslayer Holy Mail Gauntlets

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Mail_Gauntlets");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Mail_Gauntlets";
                item.Name = "Dragonslayer Holy Mail Gauntlets";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 22;
                item.Weight = 22;
                item.Model = 3998;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 40;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 6;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 10;
                item.Bonus4Type = 15;
                item.Bonus5Type = 191;
                item.Bonus6Type = 190;
                item.Bonus7Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Mail Gauntlets

            #region Dragonslayer Holy Mail Hauberk

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Mail_Hauberk");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Mail_Hauberk";
                item.Name = "Dragonslayer Holy Mail Hauberk";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 3995;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 22;
                item.Bonus5 = 4;
                item.Bonus6 = 4;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 156;
                item.Bonus5Type = 153;
                item.Bonus6Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Mail Hauberk

            #region Dragonslayer Infernal Cloth Breeches

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Infernal_Cloth_Breeches");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Infernal_Cloth_Breeches";
                item.Name = "Dragonslayer Infernal Cloth Breeches";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 27;
                item.Weight = 14;
                item.Model = 4016;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 155;
                item.Bonus7Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Infernal Cloth Breeches

            #region Dragonslayer Infernal Cloth Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Infernal_Cloth_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Infernal_Cloth_Gloves";
                item.Name = "Dragonslayer Infernal Cloth Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 22;
                item.Weight = 8;
                item.Model = 4018;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 45;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 155;
                item.Bonus7Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Infernal Cloth Gloves

            #region Dragonslayer Infernal Cloth Vest

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Infernal_Cloth_Vest");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Infernal_Cloth_Vest";
                item.Name = "Dragonslayer Infernal Cloth Vest";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 25;
                item.Weight = 20;
                item.Model = 4020;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 200;
                item.Bonus7Type = 198;
                item.Bonus8Type = 153;
                item.Bonus9Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Infernal Cloth Vest

            #region Dragonslayer Lamellar Armguards

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Lamellar_Armguards");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Lamellar_Armguards";
                item.Name = "Dragonslayer Lamellar Armguards";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 28;
                item.Weight = 30;
                item.Model = 4012;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Lamellar Armguards

            #region Dragonslayer Lamellar Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Lamellar_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Lamellar_Boots";
                item.Name = "Dragonslayer Lamellar Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 23;
                item.Weight = 20;
                item.Model = 4013;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 20;
                item.Bonus6 = 4;
                item.Bonus1Type = 49;
                item.Bonus2Type = 13;
                item.Bonus3Type = 17;
                item.Bonus4Type = 19;
                item.Bonus5Type = 10;
                item.Bonus6Type = 168;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Lamellar Boots

            #region Dragonslayer Lamellar Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Lamellar_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Lamellar_Full_Helm";
                item.Name = "Dragonslayer Lamellar Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 21;
                item.Weight = 20;
                item.Model = 4055;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Lamellar Full Helm

            #region Dragonslayer Lamellar Gauntlets

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Lamellar_Gauntlets");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Lamellar_Gauntlets";
                item.Name = "Dragonslayer Lamellar Gauntlets";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 22;
                item.Weight = 20;
                item.Model = 4014;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 45;
                item.Bonus5 = 3;
                item.Bonus6 = 45;
                item.Bonus7 = 10;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 10;
                item.Bonus5Type = 168;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Lamellar Gauntlets

            #region Dragonslayer Lamellar Jerkin

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Lamellar_Jerkin");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Lamellar_Jerkin";
                item.Name = "Dragonslayer Lamellar Jerkin";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4010;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 198;
                item.Bonus7Type = 153;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Lamellar Jerkin

            #region Dragonslayer Lamellar Jerkin (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Lamellar_Jerkin_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Lamellar_Jerkin_classic";
                item.Name = "Dragonslayer Lamellar Jerkin (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4010;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 2;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 202;
                item.Bonus7Type = 201;
                item.Bonus8Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Lamellar Jerkin (classic)

            #region Dragonslayer Lamellar Leggings

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Lamellar_Leggings");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Lamellar_Leggings";
                item.Name = "Dragonslayer Lamellar Leggings";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 27;
                item.Weight = 40;
                item.Model = 4011;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Lamellar Leggings

            #region Dragonslayer Lament Mail Chausses

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Lament_Mail_Chausses");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Lament_Mail_Chausses";
                item.Name = "Dragonslayer Lament Mail Chausses";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 27;
                item.Weight = 46;
                item.Model = 3996;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 40;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 22;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 10;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 156;
                item.Bonus6Type = 209;
                item.Bonus7Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Lament Mail Chausses

            #region Dragonslayer Lament Mail Hauberk

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Lament_Mail_Hauberk");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Lament_Mail_Hauberk";
                item.Name = "Dragonslayer Lament Mail Hauberk";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 3995;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 15;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 156;
                item.Bonus6Type = 153;
                item.Bonus7Type = 198;
                item.Bonus8Type = 200;
                item.Bonus9Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Lament Mail Hauberk

            #region Dragonslayer Mail Armguards

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Mail_Armguards");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Mail_Armguards";
                item.Name = "Dragonslayer Mail Armguards";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 28;
                item.Weight = 38;
                item.Model = 3997;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 201;
                item.Bonus7Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Mail Armguards

            #region Dragonslayer Mail Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Mail_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Mail_Boots";
                item.Name = "Dragonslayer Mail Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 23;
                item.Weight = 22;
                item.Model = 3999;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 6;
                item.Bonus1Type = 3;
                item.Bonus2Type = 1;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 194;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Mail Boots

            #region Dragonslayer Mail Chausses

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Mail_Chausses");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Mail_Chausses";
                item.Name = "Dragonslayer Mail Chausses";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 27;
                item.Weight = 46;
                item.Model = 3996;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 203;
                item.Bonus7Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Mail Chausses

            #region Dragonslayer Mail Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Mail_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Mail_Full_Helm";
                item.Name = "Dragonslayer Mail Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 21;
                item.Weight = 22;
                item.Model = 4057;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 40;
                item.Bonus5 = 6;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 10;
                item.Bonus5Type = 14;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Mail Full Helm

            #region Dragonslayer Mail Gauntlets

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Mail_Gauntlets");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Mail_Gauntlets";
                item.Name = "Dragonslayer Mail Gauntlets";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 22;
                item.Weight = 22;
                item.Model = 3998;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 45;
                item.Bonus5 = 3;
                item.Bonus6 = 45;
                item.Bonus7 = 10;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 10;
                item.Bonus5Type = 164;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Mail Gauntlets

            #region Dragonslayer Mail Hauberk

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Mail_Hauberk");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Mail_Hauberk";
                item.Name = "Dragonslayer Mail Hauberk";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 3995;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 2;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 201;
                item.Bonus7Type = 203;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Mail Hauberk

            #region Dragonslayer Plate Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Plate_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Plate_Boots";
                item.Name = "Dragonslayer Plate Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 34;
                item.Object_Type = 36;
                item.Item_Type = 23;
                item.Weight = 40;
                item.Model = 4004;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 6;
                item.Bonus1Type = 1;
                item.Bonus2Type = 3;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 194;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Plate Boots

            #region Dragonslayer Plate Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Plate_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Plate_Full_Helm";
                item.Name = "Dragonslayer Plate Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 34;
                item.Object_Type = 36;
                item.Item_Type = 21;
                item.Weight = 40;
                item.Model = 4053;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Plate Full Helm

            #region Dragonslayer Plate Gauntlets

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Plate_Gauntlets");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Plate_Gauntlets";
                item.Name = "Dragonslayer Plate Gauntlets";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 34;
                item.Object_Type = 36;
                item.Item_Type = 22;
                item.Weight = 40;
                item.Model = 4003;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 45;
                item.Bonus5 = 3;
                item.Bonus6 = 45;
                item.Bonus7 = 10;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 10;
                item.Bonus5Type = 164;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Plate Gauntlets

            #region Dragonslayer Plate Greaves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Plate_Greaves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Plate_Greaves";
                item.Name = "Dragonslayer Plate Greaves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 34;
                item.Object_Type = 36;
                item.Item_Type = 27;
                item.Weight = 60;
                item.Model = 4001;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 3;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 203;
                item.Bonus7Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Plate Greaves

            #region Dragonslayer Plate Vambraces

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Plate_Vambraces");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Plate_Vambraces";
                item.Name = "Dragonslayer Plate Vambraces";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 34;
                item.Object_Type = 36;
                item.Item_Type = 28;
                item.Weight = 70;
                item.Model = 4002;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 201;
                item.Bonus7Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Plate Vambraces

            #region Dragonslayer Plate Breast

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Plate_Breastplate");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Plate_Breastplate";
                item.Name = "Dragonslayer Plate Breastplate";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 34;
                item.Object_Type = 36;
                item.Item_Type = 25;
                item.Weight = 100;
                item.Model = 4000;
                item.Extension = 0;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 0;
                item.Bonus9 = 0;
                item.Bonus10 = 0;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 200;
                item.Bonus7Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.ProcSpellID = 32193;
                item.ProcSpellID1 = 40006;
                item.Realm = (int)eRealm.Albion;
                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled) log.Debug("Added " + item.Id_nb);
            }
            item = null;
            #endregion Dragonslayer Plate Breast Plate

            #region Dragonslayer Soft Leather Pants

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Soft_Leather_Pants");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Soft_Leather_Pants";
                item.Name = "Dragonslayer Soft Leather Pants";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 27;
                item.Weight = 56;
                item.Model = 3991;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 55;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 155;
                item.Bonus7Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Soft Leather Pants

            #region Dragonslayer Soft Leather Shoes

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Soft_Leather_Shoes");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Soft_Leather_Shoes";
                item.Name = "Dragonslayer Soft Leather Shoes";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 23;
                item.Weight = 32;
                item.Model = 3994;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 3;
                item.Bonus2 = 3;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 20;
                item.Bonus7 = 3;
                item.Bonus1Type = 23;
                item.Bonus2Type = 49;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 10;
                item.Bonus7Type = 164;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Soft Leather Shoes

            #region Dragonslayer Soft Leather Tunic

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Soft_Leather_Tunic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Soft_Leather_Tunic";
                item.Name = "Dragonslayer Soft Leather Tunic";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 3990;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 200;
                item.Bonus7Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Albion;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Soft Leather Tunic

            #endregion Albion Armors

            //This creates and stores all the items for your merchant windows.

            MerchantItem m_item = null;
            m_item = GameServer.Database.SelectObject<MerchantItem>("ItemListID='AlbionDragonItems'");
            if (m_item == null)
            {
                #region Merchant Items

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Albion_Cloak_of_Magic";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Albion_Cloak_of_Might";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Arawnite_Mail_Chausses";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Arawnite_Mail_Hauberk";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Blessed_Leather_Shoes";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Blessed_Leather_Sleeves";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Blessed_Leather_Tunic";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Blessed_Leather_Tunic_classic";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Cloth_Breeches";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Cloth_Full_Helm";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Cloth_Gloves";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Cloth_Robes_classic";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Cloth_Sleeves";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Cloth_Slippers";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Hard_Leather_Full_Helm";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Hard_Leather_Gloves";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Hard_Leather_Pants";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Hard_Leather_Shoes";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Hard_Leather_Sleeves";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Hard_Leather_Tunic";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Hard_Leather_Tunic_classic";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Mail_Armguards";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Mail_Boots";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Mail_Chausses";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Mail_Gauntlets";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Mail_Hauberk";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Infernal_Cloth_Breeches";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Infernal_Cloth_Gloves";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Infernal_Cloth_Vest";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Lamellar_Armguards";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Lamellar_Boots";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Lamellar_Full_Helm";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Lamellar_Gauntlets";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Lamellar_Jerkin";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Lamellar_Jerkin_classic";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Lamellar_Leggings";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Lament_Mail_Chausses";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Lament_Mail_Hauberk";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Mail_Armguards";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Mail_Boots";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Mail_Chausses";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Mail_Full_Helm";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 17;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Mail_Gauntlets";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 18;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Mail_Hauberk";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 19;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Plate_Boots";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Plate_Breastplate";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Plate_Full_Helm";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Plate_Gauntlets";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Plate_Greaves";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Plate_Vambraces";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Soft_Leather_Pants";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Soft_Leather_Shoes";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                m_item = new MerchantItem();
                m_item.ItemListID = "AlbionDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Soft_Leather_Tunic";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);
                item = null;

                #endregion Merchant Items
            }
            item = null;
        }
    }
    #endregion Albion Dragonslayer Items

    #region Midgard Dragonslayer Items

    public class MidgardDragonItems
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            ItemTemplate item = null;

            //This checks and adds the Midgard Dragonslayer Armors to your itemtemplate table.

            #region Midgard Armors

            #region Midgard Cloak of Magic

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Midgard_Cloak_of_Magic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Midgard_Cloak_of_Magic";
                item.Name = "Midgard Cloak of Magic";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 32;
                item.Item_Type = 26;
                item.Weight = 20;
                item.Model = 3801;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 1;
                item.Bonus2 = 1;
                item.Bonus3 = 40;
                item.Bonus4 = 1;
                item.Bonus5 = 3;
                item.Bonus6 = 40;
                item.Bonus7 = 6;
                item.Bonus8 = 6;
                item.Bonus9 = 6;
                item.Bonus10 = 1;
                item.Bonus1Type = 13;
                item.Bonus2Type = 17;
                item.Bonus3Type = 10;
                item.Bonus4Type = 19;
                item.Bonus5Type = 163;
                item.Bonus6Type = 210;
                item.Bonus7Type = 3;
                item.Bonus8Type = 2;
                item.Bonus9Type = 156;
                item.Bonus10Type = 198;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Midgard Cloak of Magic

            #region Midgard Cloak of Might

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Midgard_Cloak_of_Might");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Midgard_Cloak_of_Might";
                item.Name = "Midgard Cloak of Might";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 32;
                item.Item_Type = 26;
                item.Weight = 20;
                item.Model = 3801;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 1;
                item.Bonus2 = 1;
                item.Bonus3 = 40;
                item.Bonus4 = 1;
                item.Bonus5 = 3;
                item.Bonus6 = 40;
                item.Bonus7 = 6;
                item.Bonus8 = 6;
                item.Bonus9 = 6;
                item.Bonus10 = 1;
                item.Bonus1Type = 16;
                item.Bonus2Type = 18;
                item.Bonus3Type = 10;
                item.Bonus4Type = 14;
                item.Bonus5Type = 164;
                item.Bonus6Type = 210;
                item.Bonus7Type = 3;
                item.Bonus8Type = 2;
                item.Bonus9Type = 1;
                item.Bonus10Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Midgard Cloak of Might

            #region Dragonslayer Bragi Starkakedja Hauberk

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Bragi_Starkakedja_Hauberk");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Bragi_Starkakedja_Hauberk";
                item.Name = "Dragonslayer Bragi Starkakedja Hauberk";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 4026;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 156;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 153;
                item.Bonus7Type = 173;
                item.Bonus8Type = 198;
                item.Bonus9Type = 200;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Bragi Starkakedja Hauberk

            #region Dragonslayer Feral Starkaskodd Arms

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Feral_Starkaskodd_Arms");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Feral_Starkaskodd_Arms";
                item.Name = "Dragonslayer Feral Starkaskodd Arms";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 28;
                item.Weight = 30;
                item.Model = 4043;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Feral Starkaskodd Arms

            #region Dragonslayer Feral Starkaskodd Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Feral_Starkaskodd_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Feral_Starkaskodd_Boots";
                item.Name = "Dragonslayer Feral Starkaskodd Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 23;
                item.Weight = 20;
                item.Model = 4044;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 20;
                item.Bonus6 = 4;
                item.Bonus1Type = 49;
                item.Bonus2Type = 13;
                item.Bonus3Type = 17;
                item.Bonus4Type = 19;
                item.Bonus5Type = 10;
                item.Bonus6Type = 168;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Feral Starkaskodd Boots

            #region Dragonslayer Feral Starkaskodd Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Feral_Starkaskodd_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Feral_Starkaskodd_Full_Helm";
                item.Name = "Dragonslayer Feral Starkaskodd Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 21;
                item.Weight = 20;
                item.Model = 4069;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Feral Starkaskodd Full Helm

            #region Dragonslayer Feral Starkaskodd Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Feral_Starkaskodd_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Feral_Starkaskodd_Gloves";
                item.Name = "Dragonslayer Feral Starkaskodd Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 22;
                item.Weight = 20;
                item.Model = 4045;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 45;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 3;
                item.Bonus6 = 45;
                item.Bonus7 = 10;
                item.Bonus1Type = 10;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 168;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Feral Starkaskodd Gloves

            #region Dragonslayer Feral Starkaskodd Jerkin

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Feral_Starkaskodd_Jerkin");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Feral_Starkaskodd_Jerkin";
                item.Name = "Dragonslayer Feral Starkaskodd Jerkin";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4041;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 153;
                item.Bonus7Type = 198;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Feral Starkaskodd Jerkin

            #region Dragonslayer Feral Starkaskodd Jerkin (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Feral_Starkaskodd_Jerkin_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Feral_Starkaskodd_Jerkin_classic";
                item.Name = "Dragonslayer Feral Starkaskodd Jerkin (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4041;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 2;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 202;
                item.Bonus7Type = 201;
                item.Bonus8Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Feral Starkaskodd Jerkin (classic)

            #region Dragonslayer Feral Starkaskodd Legs

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Feral_Starkaskodd_Legs");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Feral_Starkaskodd_Legs";
                item.Name = "Dragonslayer Feral Starkaskodd Legs";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 27;
                item.Weight = 40;
                item.Model = 4042;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Feral Starkaskodd Legs

            #region Dragonslayer Hard Starklaedar Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Hard_Starklaedar_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Hard_Starklaedar_Gloves";
                item.Name = "Dragonslayer Hard Starklaedar Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 22;
                item.Weight = 32;
                item.Model = 4024;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 45;
                item.Bonus5 = 3;
                item.Bonus6 = 10;
                item.Bonus7 = 45;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 10;
                item.Bonus5Type = 164;
                item.Bonus6Type = 148;
                item.Bonus7Type = 210;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Hard Starklaedar Gloves

            #region Dragonslayer Hard Starklaedar Pants

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Hard_Starklaedar_Pants");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Hard_Starklaedar_Pants";
                item.Name = "Dragonslayer Hard Starklaedar Pants";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 27;
                item.Weight = 56;
                item.Model = 4022;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 155;
                item.Bonus7Type = 203;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Hard Starklaedar Pants

            #region Dragonslayer Hard Starklaedar Sleeves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Hard_Starklaedar_Sleeves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Hard_Starklaedar_Sleeves";
                item.Name = "Dragonslayer Hard Starklaedar Sleeves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 28;
                item.Weight = 48;
                item.Model = 4023;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 155;
                item.Bonus7Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Hard Starklaedar Sleeves

            #region Dragonslayer Hard Starklaedar Tunic (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Hard_Starklaedar_Tunic_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Hard_Starklaedar_Tunic_classic";
                item.Name = "Dragonslayer Hard Starklaedar Tunic (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4021;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 2;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 201;
                item.Bonus7Type = 203;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Hard Starklaedar Tunic (classic)

            #region Dragonslayer Odin Starkakedja Chausses

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Odin_Starkakedja_Chausses");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Odin_Starkakedja_Chausses";
                item.Name = "Dragonslayer Odin Starkakedja Chausses";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 27;
                item.Weight = 46;
                item.Model = 4027;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 155;
                item.Bonus7Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Odin Starkakedja Chausses

            #region Dragonslayer Odin Starkakedja Hauberk

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Odin_Starkakedja_Hauberk");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Odin_Starkakedja_Hauberk";
                item.Name = "Dragonslayer Odin Starkakedja Hauberk";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 4026;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 200;
                item.Bonus7Type = 198;
                item.Bonus8Type = 153;
                item.Bonus9Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Odin Starkakedja Hauberk

            #region Dragonslayer Padded Breeches (Mid)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Padded_Breeches_Mid");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Padded_Breeches_Mid";
                item.Name = "Dragonslayer Padded Breeches (Mid)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 27;
                item.Weight = 14;
                item.Model = 4047;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 191;
                item.Bonus7Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Padded Breeches (Mid)

            #region Dragonslayer Padded Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Padded_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Padded_Full_Helm";
                item.Name = "Dragonslayer Padded Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 21;
                item.Weight = 8;
                item.Model = 4070;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 40;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 148;
                item.Bonus7Type = 210;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Padded Full Helm

            #region Dragonslayer Padded Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Padded_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Padded_Gloves";
                item.Name = "Dragonslayer Padded Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 22;
                item.Weight = 8;
                item.Model = 4049;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 40;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 3;
                item.Bonus6 = 40;
                item.Bonus7 = 6;
                item.Bonus1Type = 10;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 163;
                item.Bonus6Type = 210;
                item.Bonus7Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Padded Gloves

            #region Dragonslayer Padded Robes

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Padded_Robes");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Padded_Robes";
                item.Name = "Dragonslayer Padded Robes";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 25;
                item.Weight = 20;
                item.Model = 4046;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 22;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 156;
                item.Bonus6Type = 153;
                item.Bonus7Type = 198;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Padded Robes

            #region Dragonslayer Padded Robes (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Padded_Robes_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Padded_Robes_classic";
                item.Name = "Dragonslayer Padded Robes (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 25;
                item.Weight = 20;
                item.Model = 4046;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 22;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 156;
                item.Bonus6Type = 209;
                item.Bonus7Type = 202;
                item.Bonus8Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Padded Robes (classic)

            #region Dragonslayer Padded Sleeves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Padded_Sleeves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Padded_Sleeves";
                item.Name = "Dragonslayer Padded Sleeves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 28;
                item.Weight = 12;
                item.Model = 4048;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 156;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 191;
                item.Bonus7Type = 209;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Padded Sleeves

            #region Dragonslayer Padded Slippers

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Padded_Slippers");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Padded_Slippers";
                item.Name = "Dragonslayer Padded Slippers";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 23;
                item.Weight = 8;
                item.Model = 4050;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 18;
                item.Bonus6 = 6;
                item.Bonus1Type = 2;
                item.Bonus2Type = 13;
                item.Bonus3Type = 17;
                item.Bonus4Type = 19;
                item.Bonus5Type = 156;
                item.Bonus6Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Padded Slippers

            #region Dragonslayer Savage Starkaskodd Jerkin

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Savage_Starkaskodd_Jerkin");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Savage_Starkaskodd_Jerkin";
                item.Name = "Dragonslayer Savage Starkaskodd Jerkin";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4041;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 2;
                item.Bonus2Type = 1;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 173;
                item.Bonus7Type = 200;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Savage Starkaskodd Jerkin

            #region Dragonslayer Seer Starkakedja Arms

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Seer_Starkakedja_Arms");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Seer_Starkakedja_Arms";
                item.Name = "Dragonslayer Seer Starkakedja Arms";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 28;
                item.Weight = 38;
                item.Model = 4028;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 22;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 156;
                item.Bonus5Type = 10;
                item.Bonus6Type = 209;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Seer Starkakedja Arms

            #region Dragonslayer Seer Starkakedja Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Seer_Starkakedja_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Seer_Starkakedja_Boots";
                item.Name = "Dragonslayer Seer Starkakedja Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 23;
                item.Weight = 22;
                item.Model = 4030;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 18;
                item.Bonus6 = 6;
                item.Bonus1Type = 2;
                item.Bonus2Type = 13;
                item.Bonus3Type = 19;
                item.Bonus4Type = 17;
                item.Bonus5Type = 156;
                item.Bonus6Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Seer Starkakedja Boots

            #region Dragonslayer Seer Starkakedja Chausses

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Seer_Starkakedja_Chausses");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Seer_Starkakedja_Chausses";
                item.Name = "Dragonslayer Seer Starkakedja Chausses";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 27;
                item.Weight = 46;
                item.Model = 4027;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Seer Starkakedja Chausses

            #region Dragonslayer Seer Starkakedja Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Seer_Starkakedja_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Seer_Starkakedja_Full_Helm";
                item.Name = "Dragonslayer Seer Starkakedja Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 21;
                item.Weight = 22;
                item.Model = 4072;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 40;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 148;
                item.Bonus7Type = 210;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Seer Starkakedja Full Helm

            #region Dragonslayer Seer Starkakedja Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Seer_Starkakedja_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Seer_Starkakedja_Gloves";
                item.Name = "Dragonslayer Seer Starkakedja Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 22;
                item.Weight = 22;
                item.Model = 4029;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 40;
                item.Bonus5 = 6;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 10;
                item.Bonus5Type = 196;
                item.Bonus6Type = 195;
                item.Bonus7Type = 190;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Seer Starkakedja Gloves

            #region Dragonslayer Seer Starkakedja Hauberk

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Seer_Starkakedja_Hauberk");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Seer_Starkakedja_Hauberk";
                item.Name = "Dragonslayer Seer Starkakedja Hauberk";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 4026;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 22;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 156;
                item.Bonus6Type = 153;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Seer Starkakedja Hauberk

            #region Dragonslayer Seer Starkakedja Hauberk (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Seer_Starkakedja_Hauberk_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Seer_Starkakedja_Hauberk_classic";
                item.Name = "Dragonslayer Seer Starkakedja Hauberk (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 4026;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 2;
                item.Bonus1Type = 1;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 209;
                item.Bonus7Type = 202;
                item.Bonus8Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Seer Starkakedja Hauberk (classic)

            #region Dragonslayer Shadow Starklaedar Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Shadow_Starklaedar_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Shadow_Starklaedar_Gloves";
                item.Name = "Dragonslayer Shadow Starklaedar Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 22;
                item.Weight = 32;
                item.Model = 4024;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 45;
                item.Bonus5 = 3;
                item.Bonus6 = 45;
                item.Bonus7 = 10;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 10;
                item.Bonus5Type = 164;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Shadow Starklaedar Gloves

            #region Dragonslayer Shadow Starklaedar Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Shadow_Starklaedar_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Shadow_Starklaedar_Helm";
                item.Name = "Dragonslayer Shadow Starklaedar Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 21;
                item.Weight = 32;
                item.Model = 4068;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Shadow Starklaedar Helm

            #region Dragonslayer Shadow Starklaedar Pants

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Shadow_Starklaedar_Pants");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Shadow_Starklaedar_Pants";
                item.Name = "Dragonslayer Shadow Starklaedar Pants";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 27;
                item.Weight = 56;
                item.Model = 4022;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 3;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 203;
                item.Bonus7Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Shadow Starklaedar Pants

            #region Dragonslayer Shadow Starklaedar Sleeves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Shadow_Starklaedar_Sleeves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Shadow_Starklaedar_Sleeves";
                item.Name = "Dragonslayer Shadow Starklaedar Sleeves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 28;
                item.Weight = 48;
                item.Model = 4023;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 155;
                item.Bonus7Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Shadow Starklaedar Sleeves

            #region Dragonslayer Shadow Starklaedar Tunic

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Shadow_Starklaedar_Tunic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Shadow_Starklaedar_Tunic";
                item.Name = "Dragonslayer Shadow Starklaedar Tunic";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4021;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 173;
                item.Bonus7Type = 200;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Shadow Starklaedar Tunic

            #region Dragonslayer Soft Starklaedar Shoes

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Soft_Starklaedar_Shoes");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Soft_Starklaedar_Shoes";
                item.Name = "Dragonslayer Soft Starklaedar Shoes";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 23;
                item.Weight = 32;
                item.Model = 4025;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 3;
                item.Bonus2 = 3;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 20;
                item.Bonus7 = 3;
                item.Bonus8 = 5;
                item.Bonus1Type = 23;
                item.Bonus2Type = 49;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 10;
                item.Bonus7Type = 164;
                item.Bonus8Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Soft Starklaedar Shoes

            #region Dragonslayer Starkakedja Armguards

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starkakedja_Armguards");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starkakedja_Armguards";
                item.Name = "Dragonslayer Starkakedja Armguards";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 21;
                item.Weight = 22;
                item.Model = 4028;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 155;
                item.Bonus7Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starkakedja Armguards

            #region Dragonslayer Starkakedja Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starkakedja_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starkakedja_Boots";
                item.Name = "Dragonslayer Starkakedja Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 23;
                item.Weight = 22;
                item.Model = 4030;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 6;
                item.Bonus1Type = 3;
                item.Bonus2Type = 1;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 194;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starkakedja Boots

            #region Dragonslayer Starkakedja Chausses

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starkakedja_Chausses");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starkakedja_Chausses";
                item.Name = "Dragonslayer Starkakedja Chausses";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 27;
                item.Weight = 46;
                item.Model = 4027;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 155;
                item.Bonus7Type = 203;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starkakedja Chausses

            #region Dragonslayer Starkakedja Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starkakedja_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starkakedja_Full_Helm";
                item.Name = "Dragonslayer Starkakedja Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 33;
                item.Item_Type = 21;
                item.Weight = 32;
                item.Model = 4068;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 40;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 148;
                item.Bonus7Type = 210;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starkakedja Full Helm

            #region Dragonslayer Starkakedja Hauberk

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starkakedja_Hauberk");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starkakedja_Hauberk";
                item.Name = "Dragonslayer Starkakedja Hauberk";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 4026;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 156;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 200;
                item.Bonus7Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starkakedja Hauberk

            #region Dragonslayer Starkaskodd Armguards

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starkaskodd_Armguards");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starkaskodd_Armguards";
                item.Name = "Dragonslayer Starkaskodd Armguards";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 28;
                item.Weight = 30;
                item.Model = 4043;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 201;
                item.Bonus7Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starkaskodd Armguards

            #region Dragonslayer Starkaskodd Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starkaskodd_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starkaskodd_Boots";
                item.Name = "Dragonslayer Starkaskodd Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 23;
                item.Weight = 20;
                item.Model = 4044;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 6;
                item.Bonus1Type = 1;
                item.Bonus2Type = 3;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 194;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starkaskodd Boots

            #region Dragonslayer Starkaskodd Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starkaskodd_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starkaskodd_Full_Helm";
                item.Name = "Dragonslayer Starkaskodd Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 21;
                item.Weight = 20;
                item.Model = 4069;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starkaskodd Full Helm

            #region Dragonslayer Starkaskodd Gauntlets

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starkaskodd_Gauntlets");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starkaskodd_Gauntlets";
                item.Name = "Dragonslayer Starkaskodd Gauntlets";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 22;
                item.Weight = 20;
                item.Model = 4045;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 45;
                item.Bonus5 = 3;
                item.Bonus6 = 45;
                item.Bonus7 = 10;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 10;
                item.Bonus5Type = 164;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starkaskodd Gauntlets

            #region Dragonslayer Starkaskodd Jerkin

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starkaskodd_Jerkin");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starkaskodd_Jerkin";
                item.Name = "Dragonslayer Starkaskodd Jerkin";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4041;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 173;
                item.Bonus7Type = 200;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starkaskodd Jerkin

            #region Dragonslayer Starkaskodd Leggings

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starkaskodd_Leggings");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starkaskodd_Leggings";
                item.Name = "Dragonslayer Starkaskodd Leggings";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 34;
                item.Item_Type = 27;
                item.Weight = 40;
                item.Model = 4042;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 3;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 203;
                item.Bonus7Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starkaskodd Leggings

            #region Dragonslayer Starklaedar Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Starklaedar_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Starklaedar_Full_Helm";
                item.Name = "Dragonslayer Starklaedar Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 22;
                item.Weight = 32;
                item.Model = 4068;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 40;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 148;
                item.Bonus7Type = 210;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Starklaedar Full Helm

            #region Dragonslayer Storm Starkakedja Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Storm_Starkakedja_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Storm_Starkakedja_Gloves";
                item.Name = "Dragonslayer Storm Starkakedja Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 35;
                item.Item_Type = 22;
                item.Weight = 22;
                item.Model = 4029;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 1;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 201;
                item.Bonus7Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Midgard;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Storm Starkakedja Gloves

            #endregion Midgard Armors

            //This creates and stores all the items for your merchant windows.

            MerchantItem m_item = null;
            m_item = GameServer.Database.SelectObject<MerchantItem>("ItemListID='MidgardDragonItems'");
            if (m_item == null)
            {
                #region Midgard Merchant Items

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Midgard_Cloak_of_Magic";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Midgard_Cloak_of_Might";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Bragi_Starkakedja_Hauberk";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Feral_Starkaskodd_Arms";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Feral_Starkaskodd_Boots";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Feral_Starkaskodd_Full_Helm";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Feral_Starkaskodd_Gloves";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Feral_Starkaskodd_Jerkin";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Feral_Starkaskodd_Jerkin_classic";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Feral_Starkaskodd_Legs";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Hard_Starklaedar_Gloves";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Hard_Starklaedar_Pants";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Hard_Starklaedar_Sleeves";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Hard_Starklaedar_Tunic_classic";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Odin_Starkakedja_Chausses";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 18;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Odin_Starkakedja_Hauberk";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 19;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Padded_Breeches_Mid";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Padded_Full_Helm";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Padded_Gloves";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Padded_Robes";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Padded_Robes_classic";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Padded_Sleeves";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Padded_Slippers";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Savage_Starkaskodd_Jerkin";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Seer_Starkakedja_Arms";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Seer_Starkakedja_Boots";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Seer_Starkakedja_Chausses";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Seer_Starkakedja_Full_Helm";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Seer_Starkakedja_Gloves";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Seer_Starkakedja_Hauberk";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Seer_Starkakedja_Hauberk_classic";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Shadow_Starklaedar_Gloves";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Shadow_Starklaedar_Helm";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Shadow_Starklaedar_Pants";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Shadow_Starklaedar_Sleeves";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Shadow_Starklaedar_Tunic";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Soft_Starklaedar_Shoes";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starkakedja_Armguards";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starkakedja_Boots";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starkakedja_Chausses";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starkakedja_Full_Helm";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starkakedja_Hauberk";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starkaskodd_Armguards";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starkaskodd_Boots";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starkaskodd_Full_Helm";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starkaskodd_Gauntlets";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 17;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starkaskodd_Jerkin";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 18;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starkaskodd_Leggings";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 19;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Starklaedar_Full_Helm";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "MidgardDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Storm_Starkakedja_Gloves";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                #endregion Midgard Merchant Items
            }
        }
    }
    #endregion Midgard Dragonslayer Items

    #region Hibernia Dragonslayer Items

    public class HiberniaDragonItems
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        [GameServerStartedEvent]
        public static void OnServerStartup(DOLEvent e, object sender, EventArgs args)
        {
            ItemTemplate item = null;

            //This checks and adds the Hibernia Dragonslayer Armors to your itemtemplate table.

            #region Hibernia Armors

            #region Hibernian Cloak of Magic

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Hibernian_Cloak_of_Magic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Hibernian_Cloak_of_Magic";
                item.Name = "Hibernian Cloak of Magic";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 32;
                item.Item_Type = 26;
                item.Weight = 20;
                item.Model = 3802;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 1;
                item.Bonus2 = 1;
                item.Bonus3 = 40;
                item.Bonus4 = 1;
                item.Bonus5 = 3;
                item.Bonus6 = 40;
                item.Bonus7 = 6;
                item.Bonus8 = 6;
                item.Bonus9 = 6;
                item.Bonus10 = 1;
                item.Bonus1Type = 13;
                item.Bonus2Type = 17;
                item.Bonus3Type = 10;
                item.Bonus4Type = 19;
                item.Bonus5Type = 163;
                item.Bonus6Type = 210;
                item.Bonus7Type = 3;
                item.Bonus8Type = 2;
                item.Bonus9Type = 1;
                item.Bonus10Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Hibernian Cloak of Magic

            #region Hibernian Cloak of Might

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Hibernian_Cloak_of_Might");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Hibernian_Cloak_of_Might";
                item.Name = "Hibernian Cloak of Might";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.Object_Type = 32;
                item.Item_Type = 26;
                item.Weight = 20;
                item.Model = 3802;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 1;
                item.Bonus2 = 1;
                item.Bonus3 = 40;
                item.Bonus4 = 1;
                item.Bonus5 = 3;
                item.Bonus6 = 40;
                item.Bonus7 = 6;
                item.Bonus8 = 6;
                item.Bonus9 = 6;
                item.Bonus10 = 1;
                item.Bonus1Type = 16;
                item.Bonus2Type = 18;
                item.Bonus3Type = 10;
                item.Bonus4Type = 14;
                item.Bonus5Type = 164;
                item.Bonus6Type = 210;
                item.Bonus7Type = 3;
                item.Bonus8Type = 2;
                item.Bonus9Type = 1;
                item.Bonus10Type = 173;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Hibernian Cloak of Might

            #region Dragonslayer Cailiocht Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Cailiocht_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Cailiocht_Full_Helm";
                item.Name = "Dragonslayer Cailiocht Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 21;
                item.Weight = 70;
                item.Model = 4089;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 10;
                item.Bonus3Type = 16;
                item.Bonus4Type = 11;
                item.Bonus5Type = 14;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Cailiocht Full Helm

            #region Dragonslayer Cruaigh Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Cruaigh_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Cruaigh_Full_Helm";
                item.Name = "Dragonslayer Cruaigh Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 21;
                item.Weight = 32;
                item.Model = 4061;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 48;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 40;
                item.Bonus7 = 10;
                item.Bonus1Type = 3;
                item.Bonus2Type = 10;
                item.Bonus3Type = 16;
                item.Bonus4Type = 11;
                item.Bonus5Type = 14;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Cruaigh Full Helm

            #region Dragonslayer Cruaigh Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Cruaigh_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Cruaigh_Gloves";
                item.Name = "Dragonslayer Cruaigh Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 22;
                item.Weight = 32;
                item.Model = 4077;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 3;
                item.Bonus2 = 45;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 45;
                item.Bonus7 = 10;
                item.Bonus1Type = 164;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Cruaigh Gloves

            #region Dragonslayer Cruaigh Sleeves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Cruaigh_Sleeves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Cruaigh_Sleeves";
                item.Name = "Dragonslayer Cruaigh Sleeves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 28;
                item.Weight = 48;
                item.Model = 4076;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 155;
                item.Bonus7Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Cruaigh Sleeves

            #region Dragonslayer Cruaigh Shoes

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Cruaig_Shoes");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Cruaig_Shoes";
                item.Name = "Dragonslayer Cruaigh Shoes";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 23;
                item.Weight = 32;
                item.Model = 4078;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 6;
                item.Bonus1Type = 1;
                item.Bonus2Type = 3;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 194;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Cruaigh Shoes

            #region Dragonslayer Defiant Osnadurtha Vest

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Defiant_Osnadurtha_Vest");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Defiant_Osnadurtha_Vest";
                item.Name = "Dragonslayer Defiant Osnadurtha Vest";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 4089;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 153;
                item.Bonus7Type = 200;
                item.Bonus8Type = 173;
                item.Bonus9Type = 198;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Defiant Osnadurtha Vest

            #region Dragonslayer Dirge Cailiocht Arms

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Dirge_Cailiocht_Arms");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Dirge_Cailiocht_Arms";
                item.Name = "Dragonslayer Dirge Cailiocht Arms";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 28;
                item.Weight = 40;
                item.Model = 4096;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 156;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 209;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Dirge Cailiocht Arms

            #region Dragonslayer Dirge Cailiocht Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Dirge_Cailiocht_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Dirge_Cailiocht_Boots";
                item.Name = "Dragonslayer Dirge Cailiocht Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 23;
                item.Weight = 20;
                item.Model = 4097;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 6;
                item.Bonus1Type = 2;
                item.Bonus2Type = 156;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Dirge Cailiocht Boots

            #region Dragonslayer Dirge Cailiocht Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Dirge_Cailiocht_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Dirge_Cailiocht_Full_Helm";
                item.Name = "Dragonslayer Dirge Cailiocht Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 21;
                item.Weight = 20;
                item.Model = 4062;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 10;
                item.Bonus3Type = 16;
                item.Bonus4Type = 11;
                item.Bonus5Type = 14;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Dirge Cailiocht Full Helm

            #region Dragonslayer Dirge Cailiocht Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Dirge_Cailiocht_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Dirge_Cailiocht_Gloves";
                item.Name = "Dragonslayer Dirge Cailiocht Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 22;
                item.Weight = 20;
                item.Model = 4098;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 40;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 6;
                item.Bonus7 = 5;
                item.Bonus1Type = 10;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 190;
                item.Bonus6Type = 196;
                item.Bonus7Type = 195;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Dirge Cailiocht Gloves

            #region Dragonslayer Dirge Cailiocht Jerkin

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Dirge_Cailiocht_Jerkin");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Dirge_Cailiocht_Jerkin";
                item.Name = "Dragonslayer Dirge Cailiocht Jerkin";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4094;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 2;
                item.Bonus2Type = 156;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 153;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Dirge Cailiocht Jerkin

            #region Dragonslayer Dirge Cailiocht Jerkin (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Dirge_Cailiocht_Jerkin_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Dirge_Cailiocht_Jerkin_classic";
                item.Name = "Dragonslayer Dirge Cailiocht Jerkin (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4094;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 2;
                item.Bonus8 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 156;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.Bonus8Type = 209;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Dirge Cailiocht Jerkin (classic)

            #region Dragonslayer Dirge Cailiocht Legs

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Dirge_Cailiocht_Legs");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Dirge_Cailiocht_Legs";
                item.Name = "Dragonslayer Dirge Cailiocht Legs";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 27;
                item.Weight = 40;
                item.Model = 4095;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 191;
                item.Bonus7Type = 2;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Dirge Cailiocht Legs

            #region Dragonslayer Holy Osnadurtha Arms

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Osnadurtha_Arms");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Osnadurtha_Arms";
                item.Name = "Dragonslayer Holy Osnadurtha Arms";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 28;
                item.Weight = 38;
                item.Model = 4091;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 156;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 209;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Osnadurtha Arms

            #region Dragonslayer Holy Osnadurtha Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Osnadurtha_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Osnadurtha_Boots";
                item.Name = "Dragonslayer Holy Osnadurtha Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 23;
                item.Weight = 22;
                item.Model = 4093;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 6;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Osnadurtha Boots

            #region Dragonslayer Holy Osnadurtha Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Osnadurtha_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Osnadurtha_Full_Helm";
                item.Name = "Dragonslayer Holy Osnadurtha Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 21;
                item.Weight = 22;
                item.Model = 4062;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 6;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 40;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 16;
                item.Bonus3Type = 11;
                item.Bonus4Type = 14;
                item.Bonus5Type = 10;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Osnadurtha Full Helm

            #region Dragonslayer Holy Osnadurtha Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Osnadurtha_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Osnadurtha_Gloves";
                item.Name = "Dragonslayer Holy Osnadurtha Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 22;
                item.Weight = 22;
                item.Model = 4092;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 5;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 40;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 6;
                item.Bonus1Type = 12;
                item.Bonus2Type = 18;
                item.Bonus3Type = 15;
                item.Bonus4Type = 10;
                item.Bonus5Type = 190;
                item.Bonus6Type = 195;
                item.Bonus7Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Osnadurtha Gloves

            #region Dragonslayer Holy Osnadurtha Hauberk

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Osnadurtha_Hauberk");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Osnadurtha_Hauberk";
                item.Name = "Dragonslayer Holy Osnadurtha Hauberk";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 4089;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 2;
                item.Bonus2Type = 156;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 153;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Osnadurtha Hauberk

            #region Dragonslayer Holy Osnadurtha Hauberk (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Osnadurtha_Hauberk_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Osnadurtha_Hauberk_classic";
                item.Name = "Dragonslayer Holy Osnadurtha Hauberk (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 4089;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 2;
                item.Bonus8 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 156;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 209;
                item.Bonus7Type = 191;
                item.Bonus8Type = 209;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Osnadurtha Hauberk (classic)

            #region Dragonslayer Holy Osnadurtha Legs

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Holy_Osnadurtha_Legs");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Holy_Osnadurtha_Legs";
                item.Name = "Dragonslayer Holy Osnadurtha Legs";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 27;
                item.Weight = 46;
                item.Model = 4090;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 5;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 40;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 12;
                item.Bonus3Type = 18;
                item.Bonus4Type = 15;
                item.Bonus5Type = 10;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Holy Osnadurtha Legs

            #region Dragonslayer Moss Padded Pants

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Moss_Padded_Pants");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Moss_Padded_Pants";
                item.Name = "Dragonslayer Moss Padded Pants";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 27;
                item.Weight = 14;
                item.Model = 4100;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 155;
                item.Bonus7Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Moss Padded Pants

            #region Dragonslayer Moss Woven Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Moss_Woven_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Moss_Woven_Gloves";
                item.Name = "Dragonslayer Moss Woven Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 22;
                item.Weight = 8;
                item.Model = 4102;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 155;
                item.Bonus7Type = 201;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Moss Woven Gloves

            #region Dragonslayer Moss Woven Vest

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Moss_Woven_Vest");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Moss_Woven_Vest";
                item.Name = "Dragonslayer Moss Woven Vest";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 25;
                item.Weight = 20;
                item.Model = 4104;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 153;
                item.Bonus7Type = 200;
                item.Bonus8Type = 173;
                item.Bonus9Type = 198;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Moss Woven Vest

            #region Dragonslayer Nature Cailiocht Arms

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Nature_Cailiocht_Arms");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Nature_Cailiocht_Arms";
                item.Name = "Dragonslayer Nature Cailiocht Arms";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 28;
                item.Weight = 40;
                item.Model = 4096;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Nature Cailiocht Arms

            #region Dragonslayer Nature Cailiocht Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Nature_Cailiocht_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Nature_Cailiocht_Boots";
                item.Name = "Dragonslayer Nature Cailiocht Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 23;
                item.Weight = 20;
                item.Model = 4097;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 4;
                item.Bonus2 = 20;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 4;
                item.Bonus1Type = 49;
                item.Bonus2Type = 10;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 168;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Nature Cailiocht Boots

            #region Dragonslayer Nature Cailiocht Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Nature_Cailiocht_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Nature_Cailiocht_Gloves";
                item.Name = "Dragonslayer Nature Cailiocht Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 22;
                item.Weight = 20;
                item.Model = 4098;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 3;
                item.Bonus2 = 45;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 45;
                item.Bonus7 = 10;
                item.Bonus1Type = 168;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Nature Cailiocht Gloves

            #region Dragonslayer Nature Cailiocht Jerkin

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Nature_Cailiocht_Jerkin");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Nature_Cailiocht_Jerkin";
                item.Name = "Dragonslayer Nature Cailiocht Jerkin";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4094;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 153;
                item.Bonus7Type = 198;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Nature Cailiocht Jerkin

            #region Dragonslayer Nature Cailiocht Jerkin (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Nature_Cailiocht_Jerkin_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Nature_Cailiocht_Jerkin_classic";
                item.Name = "Dragonslayer Nature Cailiocht Jerkin (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 19;
                item.Object_Type = 37;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4094;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 5;
                item.Bonus8 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 202;
                item.Bonus7Type = 201;
                item.Bonus8Type = 188;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Nature Cailiocht Jerkin (classic)

            #region Dragonslayer Osnadurtha Boots

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Osnadurtha_Boots");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Osnadurtha_Boots";
                item.Name = "Dragonslayer Osnadurtha Boots";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 23;
                item.Weight = 22;
                item.Model = 4093;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 6;
                item.Bonus1Type = 3;
                item.Bonus2Type = 1;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 194;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Osnadurtha Boots

            #region Dragonslayer Osnadurtha Chausses

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Osnadurtha_Chausses");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Osnadurtha_Chausses";
                item.Name = "Dragonslayer Osnadurtha Chausses";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 27;
                item.Weight = 46;
                item.Model = 4090;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 3;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 155;
                item.Bonus7Type = 203;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Osnadurtha Chausses

            #region Dragonslayer Osnadurtha Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Osnadurtha_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Osnadurtha_Full_Helm";
                item.Name = "Dragonslayer Osnadurtha Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 21;
                item.Weight = 22;
                item.Model = 4066;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 5;
                item.Bonus7 = 40;
                item.Bonus1Type = 3;
                item.Bonus2Type = 10;
                item.Bonus3Type = 11;
                item.Bonus4Type = 16;
                item.Bonus5Type = 14;
                item.Bonus6Type = 148;
                item.Bonus7Type = 210;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Osnadurtha Full Helm

            #region Dragonslayer Osnadurtha Gauntlets

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Osnadurtha_Gauntlets");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Osnadurtha_Gauntlets";
                item.Name = "Dragonslayer Osnadurtha Gauntlets";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 22;
                item.Weight = 22;
                item.Model = 4092;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 3;
                item.Bonus2 = 45;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 10;
                item.Bonus7 = 45;
                item.Bonus1Type = 164;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 148;
                item.Bonus7Type = 210;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Osnadurtha Gauntlets

            #region Dragonslayer Osnadurtha Hauberk

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Osnadurtha_Hauberk");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Osnadurtha_Hauberk";
                item.Name = "Dragonslayer Osnadurtha Hauberk";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 4089;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 173;
                item.Bonus7Type = 200;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Osnadurtha Hauberk

            #region Dragonslayer Osnadurtha Hauberk (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Osnadurtha_Hauberk_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Osnadurtha_Hauberk_classic";
                item.Name = "Dragonslayer Osnadurtha Hauberk (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 4089;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 2;
                item.Bonus7 = 5;
                item.Bonus8 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 4;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 201;
                item.Bonus7Type = 203;
                item.Bonus8Type = 155;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Osnadurtha Hauberk (classic)

            #region Dragonslayer Osnadurtha Vambraces

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Osnadurtha_Vambraces");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Osnadurtha_Vambraces";
                item.Name = "Dragonslayer Osnadurtha Vambraces";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 28;
                item.Weight = 38;
                item.Model = 4091;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 1;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 155;
                item.Bonus7Type = 1;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Osnadurtha Vambraces

            #region Dragonslayer Padded Breeches (Hib)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Padded_Breeches_Hib");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Padded_Breeches_Hib";
                item.Name = "Dragonslayer Padded Breeches (Hib)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 27;
                item.Weight = 14;
                item.Model = 4100;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 40;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 2;
                item.Bonus7 = 5;
                item.Bonus1Type = 10;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 191;
                item.Bonus7Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Padded Breeches (Hib)

            #region Dragonslayer Regrown Osnadurtha Legs

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Regrown_Osnadurtha_Legs");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Regrown_Osnadurtha_Legs";
                item.Name = "Dragonslayer Regrown Osnadurtha Legs";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 27;
                item.Weight = 46;
                item.Model = 4090;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 1;
                item.Bonus1Type = 2;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Regrown Osnadurtha Legs

            #region Dragonslayer Regrown Osnadurtha Vest

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Regrown_Osnadurtha_Vest");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Regrown_Osnadurtha_Vest";
                item.Name = "Dragonslayer Regrown Osnadurtha Vest";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 27;
                item.Object_Type = 38;
                item.Item_Type = 25;
                item.Weight = 70;
                item.Model = 4089;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 1;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 173;
                item.Bonus7Type = 191;
                item.Bonus8Type = 153;
                item.Bonus9Type = 200;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Regrown Osnadurtha Vest

            #region Dragonslayer Shadowy Cruaigh Pants

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Shadowy_Cruaigh_Pants");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Shadowy_Cruaigh_Pants";
                item.Name = "Dragonslayer Shadowy Cruaigh Pants";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 27;
                item.Weight = 56;
                item.Model = 4075;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 40;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 10;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 155;
                item.Bonus7Type = 202;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Shadowy Cruaigh Pants

            #region Dragonslayer Soft Cruaigh Shoes

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Soft_Cruaigh_Shoes");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Soft_Cruaigh_Shoes";
                item.Name = "Dragonslayer Soft Cruaigh Shoes";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 23;
                item.Weight = 32;
                item.Model = 4078;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 3;
                item.Bonus2 = 3;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 20;
                item.Bonus7 = 3;
                item.Bonus8 = 5;
                item.Bonus1Type = 23;
                item.Bonus2Type = 49;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 10;
                item.Bonus7Type = 164;
                item.Bonus8Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Soft Cruaigh Shoes

            #region Dragonslayer Soft Cruaigh Tunic

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Soft_Cruaigh_Tunic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Soft_Cruaigh_Tunic";
                item.Name = "Dragonslayer Soft Cruaigh Tunic";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 102;
                item.SPD_ABS = 10;
                item.Object_Type = 33;
                item.Item_Type = 25;
                item.Weight = 80;
                item.Model = 4074;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 15;
                item.Bonus2 = 15;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus8 = 4;
                item.Bonus9 = 4;
                item.Bonus1Type = 1;
                item.Bonus2Type = 2;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 153;
                item.Bonus7Type = 198;
                item.Bonus8Type = 173;
                item.Bonus9Type = 200;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Soft Cruaigh Tunic

            #region Dragonslayer Woven Full Helm

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Woven_Full_Helm");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Woven_Full_Helm";
                item.Name = "Dragonslayer Woven Full Helm";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 21;
                item.Weight = 8;
                item.Model = 4063;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 40;
                item.Bonus2 = 22;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 40;
                item.Bonus7 = 5;
                item.Bonus1Type = 10;
                item.Bonus2Type = 3;
                item.Bonus3Type = 16;
                item.Bonus4Type = 11;
                item.Bonus5Type = 14;
                item.Bonus6Type = 210;
                item.Bonus7Type = 148;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Woven Full Helm

            #region Dragonslayer Woven Gloves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Woven_Gloves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Woven_Gloves";
                item.Name = "Dragonslayer Woven Gloves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 22;
                item.Weight = 8;
                item.Model = 4102;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 40;
                item.Bonus2 = 3;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 6;
                item.Bonus7 = 40;
                item.Bonus1Type = 10;
                item.Bonus2Type = 163;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 196;
                item.Bonus7Type = 210;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Woven Gloves

            #region Dragonslayer Woven Robe

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Woven_Robe");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Woven_Robe";
                item.Name = "Dragonslayer Woven Robe";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 25;
                item.Weight = 20;
                item.Model = 4099;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 4;
                item.Bonus7 = 4;
                item.Bonus1Type = 2;
                item.Bonus2Type = 156;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 198;
                item.Bonus7Type = 153;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Woven Robe

            #region Dragonslayer Woven Robe (classic)

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Woven_Robe_classic");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Woven_Robe_classic";
                item.Name = "Dragonslayer Woven Robe (classic)";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 25;
                item.Weight = 20;
                item.Model = 4099;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 22;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 5;
                item.Bonus7 = 2;
                item.Bonus8 = 5;
                item.Bonus1Type = 2;
                item.Bonus2Type = 156;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 202;
                item.Bonus7Type = 191;
                item.Bonus8Type = 209;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Woven Robe (classic)

            #region Dragonslayer Woven Sleeves

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Woven_Sleeves");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Woven_Sleeves";
                item.Name = "Dragonslayer Woven Sleeves";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 28;
                item.Weight = 12;
                item.Model = 4101;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 40;
                item.Bonus2 = 22;
                item.Bonus3 = 5;
                item.Bonus4 = 5;
                item.Bonus5 = 5;
                item.Bonus6 = 1;
                item.Bonus7 = 5;
                item.Bonus1Type = 10;
                item.Bonus2Type = 156;
                item.Bonus3Type = 12;
                item.Bonus4Type = 18;
                item.Bonus5Type = 15;
                item.Bonus6Type = 191;
                item.Bonus7Type = 209;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Woven Sleeves

            #region Dragonslayer Woven Slippers

            item = GameServer.Database.FindObjectByKey<ItemTemplate>("Dragonslayer_Woven_Slippers");
            if (item == null)
            {
                item = new ItemTemplate();
                item.Id_nb = "Dragonslayer_Woven_Slippers";
                item.Name = "Dragonslayer Woven Slippers";
                item.Level = 50;
                item.Durability = 50000;
                item.MaxDurability = 50000;
                item.Condition = 50000;
                item.MaxCondition = 50000;
                item.Quality = 100;
                item.DPS_AF = 51;
                item.Object_Type = 32;
                item.Item_Type = 23;
                item.Weight = 8;
                item.Model = 4103;
                item.Extension = 4;
                item.Bonus = 35;
                item.Bonus1 = 18;
                item.Bonus2 = 18;
                item.Bonus3 = 6;
                item.Bonus4 = 6;
                item.Bonus5 = 6;
                item.Bonus6 = 6;
                item.Bonus1Type = 2;
                item.Bonus2Type = 156;
                item.Bonus3Type = 13;
                item.Bonus4Type = 17;
                item.Bonus5Type = 19;
                item.Bonus6Type = 196;
                item.IsPickable = true;
                item.IsDropable = true;
                item.Price = 2500;
                item.MaxCount = 1;
                item.PackSize = 1;
                item.Realm = (int)eRealm.Hibernia;

                GameServer.Database.AddObject(item);
                if (log.IsDebugEnabled)
                    log.Debug("Added " + item.Id_nb);
            }
            item = null;

            #endregion Dragonslayer Woven Slippers

            #endregion Hibernia Armors

            //This creates and stores all the items for your merchant windows.

            MerchantItem m_item = null;
            m_item = GameServer.Database.SelectObject<MerchantItem>("ItemListID='HiberniaDragonItems'");
            if (m_item == null)
            {
                #region Hibernia Merchant Items

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Hibernian_Cloak_of_Magic";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Hibernian_Cloak_of_Might";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Cailiocht_Full_Helm";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Cruaigh_Full_Helm";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Cruaigh_Gloves";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Cruaigh_Sleeves";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 7;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Cruaig_Shoes";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Defiant_Osnadurtha_Vest";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Dirge_Cailiocht_Arms";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Dirge_Cailiocht_Boots";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Dirge_Cailiocht_Full_Helm";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Dirge_Cailiocht_Gloves";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Dirge_Cailiocht_Jerkin";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Dirge_Cailiocht_Jerkin_classic";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 17;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Dirge_Cailiocht_Legs";
                m_item.PageNumber = 0;
                m_item.SlotPosition = 18;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Osnadurtha_Arms";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Osnadurtha_Boots";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Osnadurtha_Full_Helm";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Osnadurtha_Gloves";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Osnadurtha_Hauberk";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Osnadurtha_Hauberk_classic";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Holy_Osnadurtha_Legs";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Moss_Padded_Pants";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Moss_Woven_Gloves";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 9;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Moss_Woven_Vest";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Nature_Cailiocht_Arms";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 12;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Nature_Cailiocht_Boots";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Nature_Cailiocht_Gloves";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 14;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Nature_Cailiocht_Jerkin";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Nature_Cailiocht_Jerkin_classic";
                m_item.PageNumber = 1;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Osnadurtha_Boots";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Osnadurtha_Chausses";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Osnadurtha_Full_Helm";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Osnadurtha_Gauntlets";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Osnadurtha_Hauberk";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Osnadurtha_Hauberk_classic";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Osnadurtha_Vambraces";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 6;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Padded_Breeches_Hib";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 8;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Regrown_Osnadurtha_Legs";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 10;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Regrown_Osnadurtha_Vest";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 11;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Shadowy_Cruaigh_Pants";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 13;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Soft_Cruaigh_Shoes";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 15;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Soft_Cruaigh_Tunic";
                m_item.PageNumber = 2;
                m_item.SlotPosition = 16;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Woven_Full_Helm";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 0;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Woven_Gloves";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 1;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Woven_Robe";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 2;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Woven_Robe_classic";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 3;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Woven_Sleeves";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 4;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                m_item = new MerchantItem();
                m_item.ItemListID = "HiberniaDragonItems";
                m_item.ItemTemplateID = "Dragonslayer_Woven_Slippers";
                m_item.PageNumber = 3;
                m_item.SlotPosition = 5;
                m_item.AllowAdd = true;
                GameServer.Database.AddObject(m_item);

                #endregion Hibernia Merchant Items
            }
        }
    }
    #endregion Midgard Dragonslayer Items
}