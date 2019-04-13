using System;
using DOL;
using DOL.GS;
using DOL.Events;
using DOL.Database;
using System.Collections;
using DOL.GS.PacketHandler;
using DOL.GS.Scripts;

namespace DOL.GS.Scripts
{
	public class TrainingDummy : GameNPC
    {
        private int Chance;//Chance for Prefixes
        public override bool AddToWorld()
        {

            if (this.CurrentRegionID == 1 || this.CurrentRegionID == 51)//Alb or Alb SI
            {
                Name = "Training Dummy";
                Model = 2010;
                Realm = 0;
                GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
                template.AddNPCEquipment(eInventorySlot.Cloak, 1727);
                template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2121);
                template.AddNPCEquipment(eInventorySlot.LegsArmor, 984, 43);
                template.AddNPCEquipment(eInventorySlot.ArmsArmor, 985, 43);
                template.AddNPCEquipment(eInventorySlot.HandsArmor, 2492);
                template.AddNPCEquipment(eInventorySlot.FeetArmor, 987, 43);
                template.AddNPCEquipment(eInventorySlot.TwoHandWeapon, 649, 43);
                Inventory = template.CloseTemplate();
            }
            if (this.CurrentRegionID == 100 || this.CurrentRegionID == 151)//Mid or Mid SI
            {
                Name = "Training Dummy";
                Model = 2010;
                Realm = 0;
                GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
                template.AddNPCEquipment(eInventorySlot.Cloak, 1727);
                template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2121);
                template.AddNPCEquipment(eInventorySlot.LegsArmor, 984, 43);
                template.AddNPCEquipment(eInventorySlot.ArmsArmor, 985, 43);
                template.AddNPCEquipment(eInventorySlot.HandsArmor, 2492);
                template.AddNPCEquipment(eInventorySlot.FeetArmor, 987, 43);
                template.AddNPCEquipment(eInventorySlot.TwoHandWeapon, 649, 43);
                Inventory = template.CloseTemplate();
            }
            if (this.CurrentRegionID == 200 || this.CurrentRegionID == 181)//Hib or Hib SI
            {
                Name = "Training Dummy";
                Model = 2010;
                Realm = 0;
                GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
                template.AddNPCEquipment(eInventorySlot.Cloak, 1727);
                template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2121);
                template.AddNPCEquipment(eInventorySlot.LegsArmor, 984, 43);
                template.AddNPCEquipment(eInventorySlot.ArmsArmor, 985, 43);
                template.AddNPCEquipment(eInventorySlot.HandsArmor, 2492);
                template.AddNPCEquipment(eInventorySlot.FeetArmor, 987, 43);
                template.AddNPCEquipment(eInventorySlot.TwoHandWeapon, 649, 43);
                Inventory = template.CloseTemplate();
            }
            else
            {
                if (Chance >= 0 && Chance <= 33)
                {
                    Name = "Training Dummy";
                    Model = 2010;
                    Realm = 0;
                    GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
                    template.AddNPCEquipment(eInventorySlot.Cloak, 1727);
                    template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2121);
                    template.AddNPCEquipment(eInventorySlot.LegsArmor, 984, 43);
                    template.AddNPCEquipment(eInventorySlot.ArmsArmor, 985, 43);
                    template.AddNPCEquipment(eInventorySlot.HandsArmor, 2492);
                    template.AddNPCEquipment(eInventorySlot.FeetArmor, 987, 43);
                    template.AddNPCEquipment(eInventorySlot.TwoHandWeapon, 649, 43);
                    Inventory = template.CloseTemplate();
                }
                if (Chance >= 33 && Chance <= 66)
                {
                    Name = "Training Dummy";
                    Model = 2010;
                    Realm = 0;
                    GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
                    template.AddNPCEquipment(eInventorySlot.Cloak, 1727);
                    template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2121);
                    template.AddNPCEquipment(eInventorySlot.LegsArmor, 984, 43);
                    template.AddNPCEquipment(eInventorySlot.ArmsArmor, 985, 43);
                    template.AddNPCEquipment(eInventorySlot.HandsArmor, 2492);
                    template.AddNPCEquipment(eInventorySlot.FeetArmor, 987, 43);
                    template.AddNPCEquipment(eInventorySlot.TwoHandWeapon, 649, 43);
                }
                if (Chance >= 66 && Chance <= 100)
                {
                    Name = "Training Dummy";
                    Model = 2010;
                    Realm = 0;
                    GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
                    template.AddNPCEquipment(eInventorySlot.Cloak, 1727);
                    template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2121);
                    template.AddNPCEquipment(eInventorySlot.LegsArmor, 984, 43);
                    template.AddNPCEquipment(eInventorySlot.ArmsArmor, 985, 43);
                    template.AddNPCEquipment(eInventorySlot.HandsArmor, 2492);
                    template.AddNPCEquipment(eInventorySlot.FeetArmor, 987, 43);
                    template.AddNPCEquipment(eInventorySlot.TwoHandWeapon, 649, 43);
                }
            }
            GuildName = "Training Dummy";
            Level = 50;
            base.AddToWorld();
            return true;
        }
		public override void TakeDamage(GameObject source, eDamageType damageType, int damageAmount, int criticalAmount)
		{
		}
		
		public override void OnAttackedByEnemy(AttackData ad)
		{
		}
		public override void StartAttack(GameObject attackTarget)
		{
		}
	}
}