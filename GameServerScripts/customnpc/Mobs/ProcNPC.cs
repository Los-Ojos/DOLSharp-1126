//Dawn of Light Version 1.7.48
//12/13/2004
//Written by Gavinius
//based on Nardin and Zjovaz previous script
//08/18/2005
//by sirru
//completely rewrote SetEffect, no duel item things whatsoever left
//compatible with dol 1.7 and added some nice things like more 
//smalltalk, equip, emotes, changing of itemnames and spellcast at the end of process
//plus i added changing of speed and color
//what could be done is trimming the prefixes from the name instead of looking at the db, but i dont know how to do that :)

using System;
using DOL;
using DOL.GS;
using DOL.Events;
using DOL.Database;
using System.Collections;
using DOL.GS.PacketHandler;

namespace DOL.GS.Scripts
{
	[NPCGuildScript("Proc NPC")]
    public class ProcNPC : GameNPC
	{
        public string TempProperty = "ProcNPC1";
	

        public override bool AddToWorld()
        {
            Flags = GameNPC.eFlags.PEACE; ;	// Peace flag.
            return base.AddToWorld();
        }
		public override bool Interact(GamePlayer player)
		{
			if(base.Interact(player))
			{
				TurnTo(player,250);
                SendReply(player, "Greetings " + player.Name + "!\n\n" +
				          			"I will add a proc to your weapons or armor!...\n"+
				          			"It costs only 300 bp (Bounty Points).\n\n"+
				          			"Simply give me the item and i will start my work.");
				return true;
			}
			return false;
		}

        public override bool ReceiveItem(GameLiving source, InventoryItem item)
		{
			GamePlayer t = source as GamePlayer;
			if(t == null || item == null) return false;
			if (GetDistanceTo(t) > WorldMgr.INTERACT_DISTANCE)
			{
				t.Out.SendMessage("You are too far away to give anything to " + GetName(0, false) + ".", eChatType.CT_System, eChatLoc.CL_SystemWindow);
				return false;
			}
			if(t.BountyPoints < 300)
			{
				t.Out.SendMessage("You need more bounty points to use this service!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
				return false;
			}

			if (item.Object_Type > 1 &&  item.Object_Type < 29) //Item is a weapon
				SendReply(t, "Very good, select the type of proc you would like to add:\n"+
								"[Direct Damage]\n"+
								"[Damage over Time]\n"+
								"[Damage Add]\n"+
								"[Lifetap]\n"+
								"[Haste]\n"+
								"[Str/Con Debuff]\n"+
								"[Dex/Quick Debuff]\n");
			else if ((item.Object_Type > 31 && item.Object_Type < 39) || item.Object_Type == 42) //Item is armor or a shield.
				SendReply(t, "Very good, select the type of proc you would like to add:\n"+
								"[Direct Damage]\n"+
								"[Damage over Time]\n"+
								"[Damage Add]\n"+
								"[Lifetap]\n"+
								"[Haste]\n"+
								"[Ablative]\n"+
								"[Armor Factor Buff]\n"+
								"[Damage Shield]\n");
            t.TempProperties.setProperty(TempProperty, item);
			return false;
		}

        public override bool WhisperReceive(GameLiving source, string str)
		{
			if(!base.WhisperReceive(source,str)) return false;

			if(!(source is GamePlayer)) return false;
		
			GamePlayer player = (GamePlayer)source;

			TurnTo(player.X,player.Y);

			switch(str)
			{
				case "Direct Damage":
					SendReply(player, 
					        	"Select a damage type : \n" +
								"[Heat DD]\n" +
								"[Spirit DD]\n" +
								"[Cold DD]\n" +
								"[Energy DD]\n");
					break;
				case "Heat DD":
					SetProc(player, 32124); break;					
				case "Spirit DD":
					SetProc(player, 32127); break;
				case "Cold DD":
					SetProc(player, 32125); break;
				case "Energy DD":
					SetProc(player, 32126); break;
				case "Damage over Time":
					SendReply(player, 
					        	"Select a damage type : \n" +
								"[Heat DoT]\n" +
								"[Matter DoT]\n" +
								"[Energy DoT]\n");
					break;
				case "Heat DoT":
					SetProc(player, 32006); break;
				case "Matter DoT":
					SetProc(player, 32013); break;
				case "Energy DoT":
					SetProc(player, 32012); break;
				case "Damage Add":
					SetProc(player, 32200); break;
				case "Lifetap":
					SetProc(player, 32210); break;
				case "Haste":
					SetProc(player, 32170); break;
				case "Str/Con Debuff":
					SetProc(player, 32220); break;
				case "Dex/Quick Debuff":
					SetProc(player, 32230); break;
				case "Ablative":
					SetProc(player, 32151); break;
				case "Armor Factor Buff":
					SetProc(player, 32161); break;
				case "Damage Shield":
					SetProc(player, 32180); break;
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
            unique.ProcSpellID = proc;
            GameServer.Database.AddObject(unique);

            player.RemoveBountyPoints(300);
            
            InventoryItem newInventoryItem = GameInventoryItem.Create<ItemUnique>(unique);
            player.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, newInventoryItem);
            player.Out.SendInventoryItemsUpdate(new InventoryItem[] { newInventoryItem });
            SendReply(player, "My work upon " + item.Name + " is complete.\n Farewell " + player.Name + ".");
        }
	}
}


