//Dawn of Light Version 1.7.48
//12/13/2004
//Written by Gavinius
//based on Nardin and Zjovaz previous script
//24/06/2008
//by Stormcrow

using System;
using DOL;
using DOL.GS;
using DOL.Events;
using DOL.Database;
using System.Collections;
using DOL.GS.PacketHandler;

namespace DOL.GS.Scripts
{
    [NPCGuildScript("ProcNPC2")]
    public class ProcNPC2 : GameNPC
    {
        public string TempProperty = "ProcNPC2";

        public override bool Interact(GamePlayer player)
        {

            if (base.Interact(player))
            {
                TurnTo(player, 250);
                SendReply(player, "Greetings" + player.Name + "!\n\n" +
                                    "I will add a proc or a charge to your weapons or armor!\n" +
                                    "It costs only 500 bp (Bounty Points), or 1000 bp if you choose the Omni-Drain\n\n" +
                                    "Simply give me the item and i will start my work.\n\n" +
                                    "But choose well, be careful, because your choice will not be able to be changed in the future!\n");


                return true;
            }
            return false;
        }
            
        
            
        #region AddToWorld

        public override bool AddToWorld()
        {
            return base.AddToWorld();
        }

        #endregion AddToWorld
        public override bool ReceiveItem(GameLiving source, InventoryItem item)
        {
            GamePlayer t = source as GamePlayer;
            if (t == null || item == null) return false;
            if (GetDistanceTo(t) > WorldMgr.INTERACT_DISTANCE)
            {
                t.Out.SendMessage("You are too far away to give anything to " + GetName(0, false) + ".", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                return false;
            }
            if (t.BountyPoints < 500)
            {
                t.Out.SendMessage("You need more bounty points to use this service!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                return false;
            }

            if (item.ProcSpellID1 != 0 || item.SpellID1 != 0)
            {
                TurnTo(t, 5000);
                Emote(eEmote.Rofl);
                SendReply(t, "You already have a bonus of that type on this armor!");

                return false;
            }

            if (item.Object_Type > 1 && item.Object_Type < 29) //Item is a weapon
            {
                //Sigil, Rune, Bespelled, Enchanted, Enticing, Embroidered, Ensorcelled, Ornamented, Blazed, Decorated, Spell Marked, Spell Etched, Spell Riddled, Etched, Ensorcelled

                {
                    SendReply(t, "Very good, would you like a Proc or a Charge?:\n" +
                                "Proc List\n" +
                                "[Proc - Direct Damage]\n" +
                                "[Proc - Damage over Time]\n" +
                                "[Proc - Damage Add]\n" +
                                "[Proc - Lifetap]\n" +
                "[Proc - Nearsight]\n" +			// galatea 30138
                "[Proc - Snare]\n" +				// galatea 30135
                                "[Proc - Haste]\n" +
                                "[Proc - Str/Con Debuff]\n" +
                                "[Proc - Dex/Quick Debuff]\n" +
                                "NEW - [ML10 Pet Proc Illusion] - Costs 100k BP\n" + 

                                "Charge List\n" +
                                "[Charge - Direct Damage]\n" +
                                "[Charge - Damage over Time]\n" +
                                "[Charge - Damage Add]\n" +
                                "[Charge - Lifetap]\n" +
                                "[Charge - Haste]\n" +
                                "[Charge - Str/Con Debuff]\n" +
                                "[Charge - Dex/Quick Debuff]\n\n");
                    t.TempProperties.setProperty(TempProperty, item);
                    return true;
            
                }
            }
            if ((item.Object_Type > 31 && item.Object_Type < 39) || item.Object_Type == 42) //Item is armor or a shield.
            {
                SendReply(t, "Very good, would you like a Proc or a Charge?:\n" +
                            "Proc List\n" +
                            "[Proc - Direct Damage]\n" +
                            "[Proc - Damage over Time]\n" +
                            "[Proc - Damage Add]\n" +
                            "[Proc - Lifetap]\n" +
            "[Proc - Nearsight]\n" +			// galatea 30138
            "[Proc - Snare]\n" +				// galatea 30135
                            "[Proc - Haste]\n" +
                            "[Proc - Str/Con Debuff]\n" +
                            "[Proc - Dex/Quick Debuff]\n" +
                            "[Proc - Omni-Drain]\n\n" +
                            "Charge List\n" +
                            "[Charge - Direct Damage]\n" +
                            "[Charge - Damage over Time]\n" +
                            "[Charge - Damage Add]\n" +
                            "[Charge - Lifetap]\n" +
                            "[Charge - Haste]\n" +
                            "[Charge - Str/Con Debuff]\n" +
                            "[Charge - Dex/Quick Debuff]\n\n");
                t.TempProperties.setProperty(TempProperty, item);
                return true;
          
                
            }
            if (item.Object_Type > 39)
            {
                SendReply(t, "Sorry, I only accept Armorcrafter NPC stuff!");
            }

            t.TempProperties.setProperty(TempProperty, item);
            return false;
        }

        public override bool WhisperReceive(GameLiving source, string str)
        {
            if (!base.WhisperReceive(source, str)) return false;

            if (!(source is GamePlayer)) return false;

            GamePlayer player = (GamePlayer)source;

            TurnTo(player.X, player.Y);

            switch (str)
            {

                case "Proc - Direct Damage":
                    SendReply(player,
                                "Select a damage type : \n" +
                                "[Proc - Heat DD]\n" +
                                "[Proc - Spirit DD]\n" +
                                "[Proc - Cold DD]\n" +
                                "[Proc - Energy DD]\n");
                    break;
                case "Proc - Heat DD":
                    SetProc(player, 32124); break;
                case "Proc - Spirit DD":
                    SetProc(player, 32127); break;
                case "Proc - Cold DD":
                    SetProc(player, 32125); break;
                case "Proc - Energy DD":
                    SetProc(player, 32126); break;
                case "Proc - Damage over Time":
                    SendReply(player,
                                "Select a damage type : \n" +
                                "[Proc - Heat DoT]\n" +
                                "[Proc - Matter DoT]\n" +
                                "[Proc - Energy DoT]\n");
                    break;
                case "Proc - Heat DoT":
                    SetProc(player, 32006); break;
                case "Proc - Matter DoT":
                    SetProc(player, 32013); break;
                case "Proc - Energy DoT":
                    SetProc(player, 32012); break;


                case "Proc - Damage Add":
                    SetProc(player, 32200); break;
                case "Proc - Lifetap":
                    SetProc(player, 32210); break;
                case "Proc - Nearsight":			// addo i proc
                    SetProc(player, 30138); break;		// 
                case "Proc - Snare":				//
                    SetProc(player, 30135); break;		// galatea			
                case "Proc - Haste":
                    SetProc(player, 32170); break;
                case "Proc - Str/Con Debuff":
                    SetProc(player, 32220); break;
                case "Proc - Dex/Quick Debuff":
                    SetProc(player, 32230); break;
                case "Proc - Alblative":
                    SetProc(player, 32151); break;
                case "Proc - Armor Factor Buff":
                    SetProc(player, 32161); break;
                case "Proc - Damage Shield":
                    SetProc(player, 32180); break;
                case "Proc - Omni-Drain":
                    SetProc(player, 42430); break;
                case "ML10 Pet Proc Illusion":
                    {
                        if (player.BountyPoints < 100000)
                        {
                            SendReply(player, "You need 100k BP to get this proc!");
                            return false;
                        }
                        SetProc(player, 71980);
                    }
                    break;

                case "Charge - Direct Damage":
                    SendReply(player,
                                "Select a damage type : \n" +
                                "[Charge - Heat DD]\n" +
                                "[Charge - Spirit DD]\n" +
                                "[Charge - Cold DD]\n" +
                                "[Charge - Energy DD]\n");
                    break;
                case "Charge - Heat DD":
                    SetCharge(player, 32124); break;
                case "Charge - Spirit DD":
                    SetCharge(player, 32127); break;
                case "Charge - Cold DD":
                    SetCharge(player, 32125); break;
                case "Charge - Energy DD":
                    SetCharge(player, 32126); break;
                case "Charge - Damage over Time":
                    SendReply(player,
                                "Select a damage type : \n" +
                                "[Charge - Heat DoT]\n" +
                                "[Charge - Matter DoT]\n" +
                                "[Charge - Energy DoT]\n");
                    break;
                case "Charge - Heat DoT":
                    SetCharge(player, 32006); break;
                case "Charge - Matter DoT":
                    SetCharge(player, 32013); break;
                case "Charge - Energy DoT":
                    SetCharge(player, 32012); break;


                case "Charge - Damage Add":
                    SetCharge(player, 32200); break;
                case "Charge - Lifetap":
                    SetCharge(player, 32210); break;
                case "Charge - Haste":
                    SetCharge(player, 32170); break;
                case "Charge - Str/Con Debuff":
                    SetCharge(player, 32220); break;
                case "Charge - Dex/Quick Debuff":
                    SetCharge(player, 32230); break;
                case "Charge - Alblative":
                    SetCharge(player, 32151); break;
                case "Charge - Armor Factor Buff":
                    SetCharge(player, 32161); break;
                case "Charge - Damage Shield":
                    SetCharge(player, 32180); break;
            }

            return true;
        }

        public void SendReply(GamePlayer player, string msg)
        {
            player.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }

        public void SetProc(GamePlayer player, int proc)
        {
            InventoryItem item = player.TempProperties.getProperty<InventoryItem>(TempProperty);
            player.TempProperties.removeProperty(TempProperty);

            if (item == null || item.OwnerID != player.InternalID || item.OwnerID == null)
                return;

            player.Inventory.RemoveItem(item);

            ItemUnique unique = new ItemUnique(item.Template);
            unique.ProcSpellID1 = proc;
            GameServer.Database.AddObject(unique);

            player.RemoveBountyPoints(500);
            if (proc == 30113)
                player.RemoveBountyPoints(500);
            if (proc == 30138)
                player.RemoveBountyPoints(500);
            if (proc == 71980)
                player.RemoveBountyPoints(100000);

            InventoryItem newInventoryItem = GameInventoryItem.Create<ItemUnique>(unique);
            player.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, newInventoryItem);
            player.Out.SendInventoryItemsUpdate(new InventoryItem[] { newInventoryItem });
            SendReply(player, "My work upon " + item.Name + " is complete. Farewell adventurer.");
        }

        public void SetCharge(GamePlayer player, int charge)
        {
            InventoryItem item = player.TempProperties.getProperty<InventoryItem>(TempProperty);
            player.TempProperties.removeProperty(TempProperty);

            if (item == null || item.OwnerID != player.InternalID || item.OwnerID == null)
                return;

            player.Inventory.RemoveItem(item);

            ItemUnique unique = new ItemUnique(item.Template);
            unique.SpellID1 = charge;
            unique.Charges = 10;
            unique.MaxCharges = 10;
            GameServer.Database.AddObject(unique);

            if (charge == 30113)
                player.RemoveBountyPoints(500);
            if (charge == 32169)				
                player.RemoveBountyPoints(500);

            InventoryItem newInventoryItem = GameInventoryItem.Create<ItemUnique>(unique);
            player.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, newInventoryItem);
            player.Out.SendInventoryItemsUpdate(new InventoryItem[] { newInventoryItem });
            SendReply(player, "My work upon " + item.Name + " is complete. Farewell " + player.Name + ".");
        }
    }
}


