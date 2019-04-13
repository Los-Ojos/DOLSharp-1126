using System;
using DOL.GS;
using DOL.Events;
using DOL.GS.PacketHandler;
using log4net;
using DOL;
using DOL.AI.Brain;
using DOL.GS.Scripts;
using DOL.GS.GameEvents;
using DOL.GS.Quests;
using DOL.GS.Spells;
using DOL.GS.Effects;
using DOL.Database;
using System.Reflection;

namespace DOL.GS.Scripts
{
	public class Santa: GameNPC
	{
		private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

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
		public override bool Interact(GamePlayer t)
		{
			if (!base.Interact(t)) return false;
			TurnTo(t.X,t.Y);
			t.Out.SendMessage("Hello "+t.Name+", would you like a [Present]? " +
            "Each Present costs 500 Bounty Points.", eChatType.CT_Say,eChatLoc.CL_PopupWindow);
			return true;
		}
		public override bool WhisperReceive(GameLiving source, string str)
		{
			if(!base.WhisperReceive(source,str)) return false;
		  	if(!(source is GamePlayer)) return false;
			GamePlayer t = (GamePlayer) source;
			TurnTo(t.X,t.Y);
			switch(str)
			{
                

                case "Present":
                    if (t.BountyPoints >= 500)
                    {
                        int RandLottery = Util.Random(1, 7);//Creates a random number between 1 and 7

                        if (RandLottery == 1)
                        {
                            t.ReceiveItem(this, "present1");
                            t.RemoveBountyPoints(500); SendReply(t, "Here is your present!");
                        }
                        else if (RandLottery == 2)
                        {
                            t.ReceiveItem(this, "present2");
                            t.RemoveBountyPoints(500); SendReply(t, "Here is your present!");
                        }
                        else if (RandLottery == 3)
                        {
                            t.ReceiveItem(this, "present3");
                            t.RemoveBountyPoints(500); SendReply(t, "Here is your present!");
                        }
                        else if (RandLottery == 4)
                        {
                            t.ReceiveItem(this, "present4");
                            t.RemoveBountyPoints(500); SendReply(t, "Here is your present!");
                        }
                        else if (RandLottery == 5)
                        {
                            t.ReceiveItem(this, "present5");
                            t.RemoveBountyPoints(500); SendReply(t, "Here is your present!");
                        }
                        else if (RandLottery == 6)
                        {
                            t.ReceiveItem(this, "present6");
                            t.RemoveBountyPoints(500); SendReply(t, "Here is your present!");
                        }
                        else if (RandLottery == 7)
                        {
                            t.ReceiveItem(this, "present7");
                            t.RemoveBountyPoints(500); SendReply(t, "Here is your present!");
                        }
                       
                    }
                    else { t.Client.Out.SendMessage("Your on my noughty list, sorry.", eChatType.CT_Say, eChatLoc.CL_PopupWindow); }
                        break;

                default: break;
			}
			return true;
		}
		private void SendReply(GamePlayer target, string msg)
			{
				target.Client.Out.SendMessage(
					msg,
					eChatType.CT_Say,eChatLoc.CL_PopupWindow);
			}
		[ScriptLoadedEvent]
        public static void OnScriptCompiled(DOLEvent e, object sender, EventArgs args)
        {
            log.Info("\tTeleporter initialized: true");
        }	
    }
	
}
