using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using DOL.Events;
using DOL.Database;
using DOL.GS.PacketHandler;

using log4net;

namespace DOL.GS.Scripts
{
    public class CraftNPC : GameNPC
    {
        string CRAFT_ITEM = "CRAFT_ITEM";
        public CraftNPC()
        {
        }
        public override bool Interact(GamePlayer player)
        {
            TurnTo(player, 500);
            string str = "Hello, I sell add stats to your armor for BP! \n \n \n";
            if (player.BountyPoints < 300)
            {
                str += "It seems you do not have enough BP to use my service, you need atleast 300!";
            }
            SendReply(player, str);
            return base.Interact(player);
        }
        public override bool ReceiveItem(GameLiving source, InventoryItem item)
        {
            GamePlayer player = source as GamePlayer;
            if (player != null)
            {
                if (CheckSlots(item))
                {
                    player.TempProperties.setProperty(CRAFT_ITEM, item);
                    string str = "";
                    str += "[Strength]\n\n";
                    str += "[Constitution]\n\n";
                    str += "[Dexterity]\n\n";
                    str += "[Quickness]\n\n";
                    str += "[Intelligence]\n\n";
                    str += "[Empathy]\n\n";
                    str += "[Acuity]\n\n";
                    str += "[Charisma\n]\n\n";



                    str += "[Body]\n\n";
                    str += "[Spirit]\n\n";
                    str += "[Matter]\n\n";
                    str += "[Energy]\n\n";
                    str += "[Heat]\n\n";
                    str += "[Cold]\n\n";
                    str += "[Thrust]\n\n";
                    str += "[Slash]\n\n";
                    str += "[Crush]\n\n";
                    SendReply(player, str);
                    return true;

                }
                else
                {
                    SendReply(player, "The first five slots of this item already have stats added.");
                    return false;
                }
            }
            return base.ReceiveItem(source, item);
        }
        public bool CheckSlots(InventoryItem item)
        {
            if (item.Bonus1Type == 0)
            {
                return true;
            }
            if (item.Bonus2Type == 0)
            {
                return true;
            }
            if (item.Bonus3Type == 0)
            {
                return true;
            }
            if (item.Bonus4Type == 0)
            {
                return true;
            }
            if (item.Bonus5Type == 0)
            {
                return true;
            }
            return false;

        }
        public override bool WhisperReceive(GameLiving source, string text)
        {
            GamePlayer player = source as GamePlayer;
            if (player == null)
            {
                return false;
            }
            InventoryItem item = player.TempProperties.getProperty<InventoryItem>(CRAFT_ITEM);
            if (item == null)
            {
                return false;
            }
            switch (text)
            {
                case "Strength":
                case "Constitution":
                case "Dexterity":
                case "Quickness":
                case "Intelligence":
                case "Empathy":
                case "Acuity":
                case "Charisma":
                case "Body":
                case "Spirit":
                case "Matter":
                case "Energy":
                case "Heat":
                case "Cold":
                case "Thrust":
                case "Slash":
                case "Crush":
                    SetBonus(text, item, player);
                    Console.WriteLine(text);
                    break;
            }
            return base.WhisperReceive(source, text);
        }
        public void SetBonus(string propertyName, InventoryItem item, GamePlayer player)
        {
            Console.WriteLine("1");
            eProperty prop = strToProperty(propertyName);
            if (prop == eProperty.MaxSpeed)
            {
                return;
            }
            Console.WriteLine("2");
            ItemUnique unique = new ItemUnique(item.Template);
            player.Inventory.RemoveItem(item);
            player.TempProperties.removeProperty(CRAFT_ITEM);

            int bonusVal = prop >= eProperty.Resist_First && prop <= eProperty.Resist_Last ? 5 : 20;
            if (unique.Bonus1Type == 0)
            {
                unique.Bonus1Type = (int)prop;
                unique.Bonus1 = 20;
            }
            else if (unique.Bonus2Type == 0)
            {
                unique.Bonus2Type = (int)prop;
                unique.Bonus2 = 20;
            }
            else if (unique.Bonus3Type == 0)
            {
                unique.Bonus3Type = (int)prop;
                unique.Bonus3 = 20;
            }
            else if (unique.Bonus4Type == 0)
            {
                unique.Bonus4Type = (int)prop;
                unique.Bonus4 = 20;
            }
            else if (unique.Bonus5Type == 0)
            {
                unique.Bonus5Type = (int)prop;
                unique.Bonus5 = 20;
            }
            Console.WriteLine("3");
            GameServer.Database.AddObject(unique);
            InventoryItem newInventoryItem = GameInventoryItem.Create<ItemUnique>(unique);
            player.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, newInventoryItem);
            SendReply(player, "I have now imbued your " + unique.Name + " with the power of " + propertyName + "!");
            player.Out.SendInventoryItemsUpdate(new InventoryItem[] { newInventoryItem });

        }
        public eProperty strToProperty(string text)
        {
            Console.WriteLine("4");
            switch (text)
            {
                case "Strength":
                    return eProperty.Strength;
                case "Constitution":
                    return eProperty.Constitution;
                case "Dexterity":
                    return eProperty.Dexterity;
                case "Quickness":
                    return eProperty.Quickness;
                case "Intelligence":
                    return eProperty.Intelligence;
                case "Empathy":
                    return eProperty.Empathy;
                case "Acuity":
                    return eProperty.Acuity;
                case "Charisma":
                    return eProperty.Charisma;
                case "Body":
                    return eProperty.Resist_Body;
                case "Spirit":
                    return eProperty.Resist_Spirit;
                case "Matter":
                    return eProperty.Resist_Matter;
                case "Energy":
                    return eProperty.Resist_Energy;
                case "Heat":
                    return eProperty.Resist_Heat;
                case "Cold":
                    return eProperty.Resist_Cold;
                case "Thrust":
                    return eProperty.Resist_Thrust;
                case "Slash":
                    return eProperty.Resist_Slash;
                case "Crush":
                    return eProperty.Resist_Crush;
                default:
                    return eProperty.MaxSpeed;
            }
        }
        public void SendReply(GamePlayer player, string msg)
        {
            player.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }
    }
}