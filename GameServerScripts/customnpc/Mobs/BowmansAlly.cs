/* Code by: Leetz
 * For: TITANGATES PvP
 * Quality NPC to set quality of an item to 100% for a cost; default price is free.
 * Date: 1.19.06
 */

using System;
using DOL;
using DOL.GS;
using DOL.GS.PacketHandler;
using DOL.Database;

namespace DOL.GS.Scripts
{
    [NPCGuildScript("Bowmans Ally NPC")]
	public class BowmansAlly : GameNPC
	{
		public long Cost = Money.GetMoney(0,0,0,0,0); // Currently Free; Edit to change. (mith/plat/gold/silver/copper)

        public override bool AddToWorld()
        {
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            switch (Realm)
            {
                case eRealm.Albion:
                    template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2230); break;
                case eRealm.Midgard:
                    template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2232);
                    template.AddNPCEquipment(eInventorySlot.ArmsArmor, 2233);
                    template.AddNPCEquipment(eInventorySlot.LegsArmor, 2234);
                    template.AddNPCEquipment(eInventorySlot.HandsArmor, 2235);
                    template.AddNPCEquipment(eInventorySlot.FeetArmor, 2236);
                    break;
                case eRealm.Hibernia:
                    template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2231); ; break;
            }

            Inventory = template.CloseTemplate();
            Flags |= GameNPC.eFlags.PEACE;
            return base.AddToWorld();
        }
		public override bool Interact(GamePlayer player)
		{
			if(!base.Interact(player)) return false;
			
			TurnTo(player.X,player.Y);
			Reply(player, "Hello " +player.Name+"! I am the Bowmans Ally, you can give me your Bow and I will enchant it."+
					"Once enchanted the Bow will strike the enemy harder.  My service is free");
					
			return true;
		}
		
		public override bool ReceiveItem(GameLiving source, InventoryItem item)
		{
		
			GamePlayer player = source as GamePlayer;
			if(player == null || item == null) return false;

            if (player.BountyPoints < 0)
			{
				Reply(player, "Not enough money!");
				return false;
			}

            if ((player.BountyPoints >= 0) && (item.Object_Type == 9) || (item.Object_Type == 15) || (item.Object_Type == 18))
            {
                item.Name = "Bolstered" + item.Name;
 // Fix this at later date               item.CrafterName = this.Name;
                item.Bonus1 = 0;
                item.Bonus1Type = 0;
                item.Bonus2 = 0;
                item.Bonus2Type = 0;
                item.Bonus3 = 0;
                item.Bonus3Type = 0;
                item.Bonus4 = 0;
                item.Bonus4Type = 0;
                item.Bonus5 = 0;
                item.Bonus5Type = 0;
                item.Bonus6 = 0;
                item.Bonus6Type = 0;
                item.Bonus7 = 0;
                item.Bonus7Type = 0;
                item.Bonus8 = 0;
                item.Bonus8Type = 0;
                item.Bonus9 = 0;
                item.Bonus9Type = 0;
                item.Bonus10 = 100;
                item.Bonus10Type = 212;
                item.Quality = 100;
                item.MaxDurability = 50000;
                item.Durability = 50000;
                item.MaxCondition = 50000;
                item.Condition = 50000;
                player.RemoveBountyPoints(0);
                return true;
            }
            else Reply(player, "This is not a bow!");
            return false;
        }
		
		public void Reply(GamePlayer player, string message)
		{
			player.Out.SendMessage(message, eChatType.CT_System, eChatLoc.CL_PopupWindow);
		}
	}
}
			
