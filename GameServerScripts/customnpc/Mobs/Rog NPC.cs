using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using DOL.Events;
using DOL.Database;
using DOL.GS.PacketHandler;

using log4net;
namespace DOL.GS
{
    public enum eSlot
    {
        HORSEARMOR = 7,
        HORSEBARDING = 8,
        HORSE = 9,
        RIGHTHAND = 10,
        LEFTHAND = 11,
        TWOHAND = 12,
        RANGED = 13,
        FIRSTQUIVER = 14,
        SECONDQUIVER = 15,
        THIRDQUIVER = 16,
        FOURTHQUIVER = 17,
        HELM = 21,
        HANDS = 22,
        FEET = 23,
        JEWELRY = 24,
        TORSO = 25,
        CLOAK = 26,
        LEGS = 27,
        ARMS = 28,
        NECK = 29,
        FOREARMS = 30,
        SHIELD = 31,
        WAIST = 32,
        LEFTWRIST = 33,
        RIGHTWRIST = 34,
        LEFTRING = 35,
        RIGHTRING = 36,
        MYTHICAL = 37
    }
    public class ROGNPC : GameNPC
    {
        string ROG_OBJECT_TYPE = "ROG_OBJECT_TYPE";
        public ROGNPC()
        {
        }
        public override bool Interact(GamePlayer player)
        {
            TurnTo(player, 500);
            string str = "Hello, I sell ROG for BP! Choose which object you wish to create!\n\n";
            if (player.BountyPoints < 100)
            {
                str += "It seems you do not have enough BP to use my service, you need atleast 100!";
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
            player.RemoveBountyPoints(100);
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
    }
}