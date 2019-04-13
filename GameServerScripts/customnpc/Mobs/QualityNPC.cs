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
	[NPCGuildScript("Quality NPC")]
	public class QualityNPC : GameNPC
	{
		public long Cost = Money.GetMoney(0,1,0,0,0); // Currently Free; Edit to change. (mith/plat/gold/silver/copper)

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
			Reply(player, "Hello " +player.Name+"! I am an Expert Blacksmith and I can repair any item you give"+
					" me to 100% condition and 105% quality for a cost of 1000 Bounty Points");
					
			return true;
		}
		
		public override bool ReceiveItem(GameLiving source, InventoryItem item)
		{
		
			GamePlayer player = source as GamePlayer;
			if(player == null || item == null) return false;

            if (player.BountyPoints < 1000)
			{
				Reply(player, "Not enough money!");
				return false;
			}
			
			//item.Name = "Highly Polished "+item.Name;
			item.Quality = 105;
			item.MaxDurability = 50000;
			item.Durability = 50000;
			item.MaxCondition = 50000;
			item.Condition = 50000;
            player.RemoveBountyPoints(1000);
			
			return true;
		}
		
		public void Reply(GamePlayer player, string message)
		{
			player.Out.SendMessage(message, eChatType.CT_System, eChatLoc.CL_PopupWindow);
		}
	}
}
			
