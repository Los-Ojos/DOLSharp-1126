using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using DOL.AI;
using DOL.AI.Brain;
using DOL.Events;
using DOL.Database;
using DOL.GS.PacketHandler;

using log4net;
namespace DOL.GS.Scripts
{
    public class RogMob : GameNPC
    {
        string ROG_OBJECT_TYPE = "ROG_OBJECT_TYPE";
        public RogMob()
        {
        }
        public override bool Interact(GamePlayer player)
        {
            TurnTo(player, 500);
            string str = "Hello, I sell ROG for BP! Choose which object you wish to create!\n\n";
            if (player.BountyPoints < 2000)
            {
                str += "It seems you do not have enough BP to use my service, you need atleast 2000!";
                SendReply(player,str);
                return false;
            }
            for (eObjectType i = eObjectType._FirstArmor; i <= eObjectType._LastArmor; i++)
            {
                if (i != eObjectType._FirstArmor)
                {
                    str += "[" + i + "]\n";
                }
            }
            for (eObjectType i = eObjectType._FirstWeapon; i <= eObjectType._LastWeapon; i++)
            {
                if (i != eObjectType._FirstWeapon)
                {
                    str += "[" + i + "]\n";
                }
            }
            SendReply(player, str);
            return base.Interact(player);
        }

        public override bool WhisperReceive(GameLiving source, string text)
        {
            GamePlayer player = source as GamePlayer;
            if (player == null)
            {
                return false;
            }
            for (eObjectType i = eObjectType._FirstArmor; i <= eObjectType._LastArmor; i++)
            {
                if (text == i.ToString())
                {
                    player.TempProperties.setProperty(ROG_OBJECT_TYPE, i);
                    string str = "";
                    str += "[Chest]\n";
                    str += "[Helm]\n";
                    str += "[Arms]\n";
                    str += "[Hands]\n";
                    str += "[Legs]\n";
                    str += "[Boots]\n";
                    SendReply(player, str);
                    return true;

                }
            }
            for (eObjectType i = eObjectType._FirstWeapon; i <= eObjectType._LastWeapon; i++)
            {
                if (text == i.ToString())
                {
                    player.TempProperties.setProperty(ROG_OBJECT_TYPE, i);
                    string str = "";
                    str += "[One Handed]\n";
                    str += "[Left Handed]\n";
                    str += "[Two Handed]\n";
                    SendReply(player, str);
                    return true;
                }
            }
            eSlot slot = eSlot.FOURTHQUIVER;
            eObjectType type = eObjectType.AlchemyTincture;
            switch (text)
            {
                case "Chest":
                    slot = eSlot.TORSO;
                    type = player.TempProperties.getProperty<eObjectType>(ROG_OBJECT_TYPE);
                    if (type != null)
                    {
                        GenerateROG(player, type, slot);
                    }
                    break;
                case "Helm":
                    slot = eSlot.HELM;
                    type = player.TempProperties.getProperty<eObjectType>(ROG_OBJECT_TYPE);
                    if (type != null)
                    {
                        GenerateROG(player, type, slot);
                    }
                    break;
                case "Arms":
                    slot = eSlot.ARMS;
                    type = player.TempProperties.getProperty<eObjectType>(ROG_OBJECT_TYPE);
                    if (type != null)
                    {
                        GenerateROG(player, type, slot);
                    }
                    break;
                case "Hands":
                    slot = eSlot.HANDS;
                    type = player.TempProperties.getProperty<eObjectType>(ROG_OBJECT_TYPE);
                    if (type != null)
                    {
                        GenerateROG(player, type, slot);
                    }
                    break;
                case "Legs":
                    slot = eSlot.LEGS;
                    type = player.TempProperties.getProperty<eObjectType>(ROG_OBJECT_TYPE);
                    if (type != null)
                    {
                        GenerateROG(player, type, slot);
                    }
                    break;
                case "Boots":
                    slot = eSlot.FEET;
                    type = player.TempProperties.getProperty<eObjectType>(ROG_OBJECT_TYPE);
                    if (type != null)
                    {
                        GenerateROG(player, type, slot);
                    }
                    break;
                case "One Handed":
                    slot = eSlot.RIGHTHAND;
                    type = player.TempProperties.getProperty<eObjectType>(ROG_OBJECT_TYPE);
                    if (type != null)
                    {
                        GenerateROG(player, type, slot);
                    }
                    break;
                case "Left Handed":
                    slot = eSlot.LEFTHAND;
                    type = player.TempProperties.getProperty<eObjectType>(ROG_OBJECT_TYPE);
                    if (type != null)
                    {
                        GenerateROG(player, type, slot);
                    }
                    break;
                case "Two Handed":
                    slot = eSlot.TWOHAND;
                    type = player.TempProperties.getProperty<eObjectType>(ROG_OBJECT_TYPE);
                    if (type != null)
                    {
                        GenerateROG(player, type, slot);
                    }
                    break;
                    break;
            }
            return base.WhisperReceive(source, text);
        }
        public void GenerateROG(GamePlayer player, eObjectType objectType, eSlot slot)
        {
            player.RemoveBountyPoints(2000);
            GameNPC mob = new GameNPC();
            mob.Name = "Unique Object";
            mob.CurrentRegionID = 1;
            mob.Level = (byte)(player.Level);
            if (mob.Level > 50)
                mob.Level = 51;

            LootList lootlist = new LootList();
            ItemUnique item = null;

            item = new ItemUnique();
            item.Object_Type = (int)objectType;
            item.Item_Type = (int)slot;

            mob.Level = 60;
            mob.Name = "TOA Mob";
            mob.CurrentRegionID = 30;
            mob.Z = 9999;
            lootlist.AddFixed(LootGeneratorUniqueObject.GenerateUniqueItem(mob, player, item), 1);
            foreach (ItemUnique unique in lootlist.GetLoot())
            {
                unique.Price = 0;
                GameServer.Database.AddObject(unique);
                InventoryItem invitem = GameInventoryItem.Create<ItemUnique>(unique);
                player.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, invitem);
                player.Out.SendMessage("Generated: " + unique.Name, eChatType.CT_System, eChatLoc.CL_SystemWindow);
            }
        }
        public void SendReply(GamePlayer player, string msg)
        {
            player.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }
        public override int AttackSpeed(params InventoryItem[] weapon)
        {
            return base.AttackSpeed(weapon) / 2;
        }
        public override double AttackDamage(InventoryItem weapon)
        {
            int multi = 4;
            if (this.PackageID == "Boss")
            {
                multi = 6;
            }
            return base.AttackDamage(weapon) * multi;
        }
        public override void Die(GameObject killer)
        {
            GamePlayer player = killer as GamePlayer;
            if (player != null)
            {
                if (Util.Chance(40))
                {
                    #region rog_stuff

                    GameNPC mob = new GameNPC();
                    mob.Name = "Unique Object";
                    mob.CurrentRegionID = 1;
                    mob.Level = (byte)(player.Level);
                    if (mob.Level > 50)
                        mob.Level = 51;

                    mob.Level = 60;
                    mob.Name = "TOA Mob";
                    mob.CurrentRegionID = 30;
                    mob.Z = 9999;

                    ItemUnique unique = LootGeneratorUniqueObject.GenerateUniqueItem(mob, player, null);
                    GameServer.Database.AddObject(unique);
                    InventoryItem item = GameInventoryItem.Create<ItemUnique>(unique);
                    player.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, item);

                    #endregion
                }
            }
            base.Die(killer);
        }
    }
}