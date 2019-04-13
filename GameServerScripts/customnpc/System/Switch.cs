using System;
using System.Collections;
using DOL.GS.Commands;
using DOL.Database;
using DOL.GS.PacketHandler;

namespace DOL.GS.Scripts.Commands
{
    [CmdAttribute(
        "&switch",
        ePrivLevel.Player,
        "Switch from 1st inventory slot to the requested weapon slot.",
        "/switch <weapon slot>")]
    public class SwitchCommandHandler : ICommandHandler
    {
        private static ItemTemplate item = null;

        public void OnCommand(GameClient client, string[] args)
        {
            GamePlayer player = client.Player as GamePlayer;

            if (args.Length != 1)
            {
                var items = player.Inventory.GetItemRange(eInventorySlot.FirstBackpack, eInventorySlot.LastBackpack);

                if (item != null)
                {
                    if (args[1] == "1")
                    {
                        if ((item.Item_Type == 10) || (item.Item_Type == 11))
                        {
                            player.Inventory.MoveItem(eInventorySlot.FirstBackpack, eInventorySlot.RightHandWeapon, 1);
                        }
                        else
                        {
                            SendReply(player, "Your first inventory slot item must be a right hand item!");
                        }
                    }
                    if (args[1] == "2")
                    {
                        if (item.Item_Type == 11)
                        {
                            player.Inventory.MoveItem(eInventorySlot.FirstBackpack, eInventorySlot.LeftHandWeapon, 1);
                        }
                        else
                        {
                            SendReply(player, "Your first inventory slot item must be a left hand item!");
                        }
                    }
                    if (args[1] == "3")
                    {
                        if ((item.Item_Type == 12)||(item.Item_Type == 11)||(item.Item_Type == 10))
                        {
                            player.Inventory.MoveItem(eInventorySlot.FirstBackpack, eInventorySlot.TwoHandWeapon, 1);
                        }
                        else
                        {
                            SendReply(player, "Your first inventory slot item must be a two hand item!");
                        }
                    }
                    if (args[1] == "4")
                    {
                        if (item.Item_Type == 13)
                        {
                            player.Inventory.MoveItem(eInventorySlot.FirstBackpack, eInventorySlot.DistanceWeapon, 1);
                        }
                        else
                        {
                            SendReply(player, "Your first inventory slot item must be a ranged item!");
                        }
                    }
                }
                else
                {
                    SendReply(player, "You must have an item in the first slot of your inventory!");
                }
            }
            else
            {
                SendReply(player, "Use: '/switch X'. Replace 'X' by:\n" +
                "1=RightHand\n"+
                "2=LeftHand\n"+
                "3=TwoHanded\n"+
                "4=Range\n");
            }
        }

        private void SendReply(GamePlayer target, string msg)
        {
            target.Out.SendMessage(
                msg,
                eChatType.CT_System, eChatLoc.CL_SystemWindow);
        }
    }
}