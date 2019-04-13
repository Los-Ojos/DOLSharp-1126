using System;
using System.Collections;

using DOL.GS.PacketHandler;
using DOL.AI.Brain;
using DOL.Database;
using DOL.Language;

namespace DOL.GS.Scripts
{
    [NPCGuildScript("Spirit Weapons")]
    public class LegendarySpiritWeapons : GameBountyMerchant
    {
        #region Constructor

        public LegendarySpiritWeapons() : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            int color = Util.Random(0, 86);
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.TorsoArmor, 746, color, 0, 3);
            template.AddNPCEquipment(eInventorySlot.FeetArmor, 750, color, 0, 3);
            template.AddNPCEquipment(eInventorySlot.HandsArmor, 749, color, 0, 3);
            template.AddNPCEquipment(eInventorySlot.LegsArmor, 747, color);
            template.AddNPCEquipment(eInventorySlot.ArmsArmor, 748, color);
            template.AddNPCEquipment(eInventorySlot.HeadArmor, 1290);
            template.AddNPCEquipment(eInventorySlot.RightHandWeapon, 2684);
            Inventory = template.CloseTemplate();
            Name = "Spiritual Legendaries";
            GuildName = "Spirit Weapons";
            Model = 1642;
            Size = 50;
            Level = 50;
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Realm = 0;
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("LegendarySpiritWeapons");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }
}