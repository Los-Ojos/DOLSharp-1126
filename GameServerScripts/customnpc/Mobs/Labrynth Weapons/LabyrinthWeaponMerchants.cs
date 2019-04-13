using System;
using System.Collections;
using DOL.GS.PacketHandler;
using DOL.AI.Brain;
using DOL.Database;
using DOL.Language;

// Merchants for Labyrinth Weapons, For use for all DOL Members.
// For use with Labyrinth Weapons made by Deathwish.
// Download weapons at http://www.dolserver.net/?page=userreleases&view=609
//
// How to install: Place into Scripts folder.
//
// How to use ingame: /mob create DOL.GS.Scripts.ALW  for alb weapons merchant.
////////////////////////////////////////////////.MLW  for mid weapons merchant.
////////////////////////////////////////////////.HLW  for hib weapons merchant.
// For Bps, you need to reprice items in database, or they cost 5million bps as they are set to 500g to buy.
// 1Copper = 1 Bps, 50Copper = 50 Bps, 1Silver = 100 Bps, 10Silver = 1000Bps, 1Gold = 10,000 Bps


namespace DOL.GS.Scripts
{
    public class ALW : GameBountyMerchant //Change GameMerchant to GameBountyMerchant, if you want the items to be bought with Bps not gold.
                                   // Alb Merchant
    {
        #region Constructor

        public ALW()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            int color = Util.Random(0, 86);
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.Cloak, 3800);
            template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2928);
            template.AddNPCEquipment(eInventorySlot.LegsArmor, 2929);
            template.AddNPCEquipment(eInventorySlot.ArmsArmor, 2930);
            template.AddNPCEquipment(eInventorySlot.HandsArmor, 2931);
            template.AddNPCEquipment(eInventorySlot.FeetArmor, 2932);

            Inventory = template.CloseTemplate();
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("AlbLabWeaps");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }

    public class HLW : GameBountyMerchant // Hib Merchant
    {
        #region Constructor

        public HLW() : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            int color = Util.Random(0, 86);
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.Cloak, 3802);
            template.AddNPCEquipment(eInventorySlot.TorsoArmor, 3390);
            template.AddNPCEquipment(eInventorySlot.LegsArmor, 3391);
            template.AddNPCEquipment(eInventorySlot.ArmsArmor, 3392);
            template.AddNPCEquipment(eInventorySlot.HandsArmor, 3393);
            template.AddNPCEquipment(eInventorySlot.FeetArmor, 3394);
            Inventory = template.CloseTemplate();
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("HibLabWeaps");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }

    public class MLW : GameBountyMerchant // Mid Merchant
    {
        #region Constructor

        public MLW()
            : base()
        {
            SetOwnBrain(new BlankBrain());
        }

        #endregion Constructor

        #region AddToWorld

        public override bool AddToWorld()
        {
            int color = Util.Random(0, 86);
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.Cloak, 3801);
            template.AddNPCEquipment(eInventorySlot.TorsoArmor, 2928);
            template.AddNPCEquipment(eInventorySlot.LegsArmor, 2929);
            template.AddNPCEquipment(eInventorySlot.ArmsArmor, 2930);
            template.AddNPCEquipment(eInventorySlot.HandsArmor, 2931);
            template.AddNPCEquipment(eInventorySlot.FeetArmor, 2932);

            Inventory = template.CloseTemplate();
            RespawnInterval = 2000;
            MaxSpeedBase = 0;
            Flags |= eFlags.PEACE;
            TradeItems = new MerchantTradeItems("MidLabWeaps");

            return base.AddToWorld();
        }

        #endregion AddToWorld
    }
}