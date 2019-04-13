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
using System;
using System.Reflection;
using DOL.GS.PacketHandler;
using System.Collections.Generic;
using DOL.Database;
using log4net;
using DOL;
using DOL.GS;
using DOL.Events;
using System.Collections;

namespace DOL.GS
{
    public class TreasureChest : GameStaticItemTimed
    {
        static uint minutesToDecay = 10;
        static int TreasureChestRecastDelay = 10;

        int lootTreasureChestTimer = 10;

        static int numberOfChests = 15;

        static int startX = 556779;
        static int startY = 557287;
        static int radius = 10000;

        static ushort currentregionID = 235;
        string targetName = "";

        IList<ItemTemplate> rewards;

        IList<GamePlayer> players;
        public TreasureChest(IList<ItemTemplate> items)
            : base(minutesToDecay * 60 * 1000)
        {
            rewards = items;

            this.Name = "Treasure Chest";
        }
        public override bool AddToWorld()
        {
            if (!base.AddToWorld()) return false;
            if (m_removeItemAction == null)
                m_removeItemAction = new RemoveItemAction(this);
            m_removeItemAction.Start((int)m_removeDelay);
            return true;
        }
        public void GiveRewards(GamePlayer player)
        {
            if (rewards == null)
                return;
            try
            {
                ItemTemplate[] array = new ItemTemplate[rewards.Count];
                if (array == null)
                    return;
                int current = 0;
                foreach (ItemTemplate temp in rewards)
                {
                    if ((player.Realm == (eRealm)temp.Realm) || (temp.Realm == 0))
                    {
                        array[current] = temp;
                        current += 1;
                    }
                }
                InventoryItem item = GameInventoryItem.Create<ItemTemplate>(array[Util.Random(0, array.Length - 2)]);
                if (item != null)
                {
                    if (player.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, item))
                    {
                        player.Out.SendMessage("You receive " + item.GetName(0, false) + " from " + this.GetName(0, false) + ".", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    }
                    else
                    {
                        player.CreateItemOnTheGround(item);
                        player.Out.SendMessage("Your Inventory is full. You couldn't recieve the " + item.Name + ", so it's been placed on the ground. Pick it up as soon as possible or it will vanish in a few minutes.", eChatType.CT_Important, eChatLoc.CL_PopupWindow);
                    }
                }
                else
                {
                    player.Out.SendMessage("There seems to be a bug with this chest!", eChatType.CT_Important, eChatLoc.CL_SystemWindow);
                }
            }
            catch { }


        }
        public virtual bool Interact(GamePlayer player)
        {
            if (!this.IsWithinRadius(player, WorldMgr.INTERACT_DISTANCE, true))
                return false;

            DoStuff(player);

            return true;
        }
        public void DoStuff(GamePlayer player)
        {
            if (targetName != "" && targetName != player.Name)
            {
                SendReply(player, "Someone else is tryin' t' take my loot, shiver me timbers! do somethin'");
                return;
            }
            if (!player.InCombat)
            {
                StartPickupTimer(lootTreasureChestTimer);
                player.Out.SendTimerWindow("Looting Treasure Chest", lootTreasureChestTimer);
                targetName = player.Name;
                return;
            }
            else
            {
                SendReply(player, "Arrr, you can't take my booty in combat");
            }
        }
        public void SendReply(GamePlayer player, string msg)
        {
            player.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }
        private RegionTimer m_pickup;
        /// <summary>
        /// Starts a new pickuptimer with the given time (in seconds)
        /// </summary>
        /// <param name="time"></param>
        public void StartPickupTimer(int time)
        {
            if (m_pickup != null)
            {
                m_pickup.Stop();
                m_pickup = null;
            }
            m_pickup = new RegionTimer(this, new RegionTimerCallback(CallBack), time * 1000);
        }
        public override bool RemoveFromWorld()
        {
            if (ObjectState == eObjectState.Active)
            {
                foreach (GamePlayer player in GetPlayersInRadius(10000))
                {
                    player.Out.SendObjectRemove(this);
                }
            }
            return true;
        }
        private int CallBack(RegionTimer timer)
        {
            if (targetName == "")
            {
                Console.WriteLine("targetname == \"\"");
                return 0;
            }
            GamePlayer target = null;
            foreach (GameClient client in WorldMgr.GetAllPlayingClients())
            {
                if (client.Player.Name == targetName)
                {
                    Console.WriteLine("Found player");
                    target = client.Player;
                }
            }
            if (m_pickup == null)
            {
                return 0;
            }
            if (target == null)
            {
                targetName = "";
                return 0;
            }
            if (this == null)
            {
                target.Out.SendCloseTimerWindow();
                return 0;
            }
            if (target.InCombat)
            {
                SendReply(target, "You can not steal my loot while in combat, argh! ");
                targetName = "";
                return 0;
            }
            if (!this.IsWithinRadius(target, WorldMgr.INTERACT_DISTANCE, true))
            {
                targetName = "";
                return 0;
            }
            target.Out.SendCloseTimerWindow();
            GiveRewards(target);
            targetName = "";

            m_pickup.Stop();

            this.Model = 1;
            this.Name = "Used";
            this.RemoveFromWorld();

            return 0;
        }
        [ScriptLoadedEvent]
        public static void ScriptLoaded(DOLEvent e, object sender, EventArgs args)
        {
            Mob mob = GameServer.Database.SelectObject<Mob>("Name = '" + GameServer.Database.Escape("Redemption") + "'");
            if (mob != null)
            {
                GameNPC npc = new GameNPC();
                npc.LoadFromDatabase(mob);
                Console.WriteLine("Treasure Chests created");
                new RegionTimer(npc, new RegionTimerCallback(SpawnChests), (1 * 60 * 1000));
            }
        }
        public static int SpawnChests(RegionTimer timer)
        {
            Console.WriteLine("Treasure Chests created");
            IList<ItemTemplate> items = GameServer.Database.SelectObjects<ItemTemplate>("PackageID = '" + GameServer.Database.Escape("DragonWeapons") + "' OR PackageID = '" + GameServer.Database.Escape("LabWeaps") + "' OR PackageID = '" + GameServer.Database.Escape("Artifacts") + "'");
            for (int i = 0; i < numberOfChests; i++)
            {
                TreasureChest chest = new TreasureChest(items);
                //15k
                chest.X = Util.Random(startX - radius, startX + radius);
                chest.Y = Util.Random(startY - radius, startY + radius);
                chest.Z = 10000;
                chest.Heading = 13;
                chest.CurrentRegionID = currentregionID;
                chest.Model = 1596;
                chest.AddToWorld();
            }
            foreach (GameClient client in WorldMgr.GetAllPlayingClients())
            {
                client.Player.TempProperties.removeProperty("Treasure_Chest");
                client.Out.SendMessage(numberOfChests + " Treasure Chests created in this zone", eChatType.CT_ScreenCenter, eChatLoc.CL_SystemWindow);
                client.Out.SendMessage(numberOfChests + " Treasure Chests created in this zone", eChatType.CT_ScreenCenter, eChatLoc.CL_SystemWindow);
                client.Out.SendMessage(numberOfChests + " Treasure Chests created in this zone", eChatType.CT_ScreenCenter, eChatLoc.CL_SystemWindow);
            }
            Mob mob = GameServer.Database.SelectObject<Mob>("Name = '" + GameServer.Database.Escape("Redemption") + "'");
            if (mob != null)
            {
                GameNPC npc = new GameNPC();
                npc.LoadFromDatabase(mob);
                new RegionTimer(npc, new RegionTimerCallback(SpawnChests), (TreasureChestRecastDelay * 60 * 1000));
            }
            return 0;
        }
    }
}