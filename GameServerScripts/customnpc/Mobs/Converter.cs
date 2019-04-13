using System;
using DOL.GS;
using DOL.Events;
using DOL.GS.PacketHandler;
using log4net;
using System.Reflection;

namespace DOL.GS.Scripts
{
	public class Converter: GameNPC
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
            Flags |= eFlags.PEACE;
            return base.AddToWorld();
        }
		public override bool Interact(GamePlayer player)
		{
			if (!base.Interact(player)) return false;
			TurnTo(player.X,player.Y);
			player.Out.SendMessage("Hello "+player.Name+"! I can trade your Bounty Points for [Realm Points].", eChatType.CT_Say,eChatLoc.CL_PopupWindow);
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
            case "Realm Points":
                    SendReply(t, "Would you like [1,000], [10,000], [50,000] or [100,000] Bounty Points exchanged?.");
                    break;

            case "1,000":

                if (t.BountyPoints >= 1000) //You have enough
                {
                    t.RemoveBountyPoints(1000);
                    t.GainRealmPoints(67);
                    t.Out.SendMessage("I have given you " + 67 * 15 + "realmpoints!", eChatType.CT_Important, eChatLoc.CL_SystemWindow);
                    t.SaveIntoDatabase();
                    t.Out.SendUpdatePlayer();
                }
                    else t.Out.SendMessage("You don't have enough Bounty Pounts!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    break;

                case "10,000":

                    if (t.BountyPoints >= 10000) //You have enough
                    {
                        t.RemoveBountyPoints(10000);
                        t.GainRealmPoints(667);
                        t.Out.SendMessage("I have given you " + 667 * 15 + "realmpoints!", eChatType.CT_Important, eChatLoc.CL_SystemWindow);
                        t.SaveIntoDatabase();
                        t.Out.SendUpdatePlayer();
                    }
                    else t.Out.SendMessage("You don't have enough Bounty Pounts!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    break;

                case "50,000":

                    if (t.BountyPoints >= 50000) //You have enough
                    {
                        t.RemoveBountyPoints(50000);
                        t.GainRealmPoints(3333);
                        t.Out.SendMessage("I have given you " + 3333 * 15 + "realmpoints!", eChatType.CT_Important, eChatLoc.CL_SystemWindow);
                        t.SaveIntoDatabase();
                        t.Out.SendUpdatePlayer();
                    }
                    else t.Out.SendMessage("You don't have enough Bounty Pounts!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    break;

                case "100,000":

                    if (t.BountyPoints >= 100000) //You have enough
                    {
                        t.RemoveBountyPoints(100000);
                        t.GainRealmPoints(6667);
                        t.Out.SendMessage("I have given you " + 6667 * 15 + "realmpoints!", eChatType.CT_Important, eChatLoc.CL_SystemWindow);
                        t.SaveIntoDatabase();
                        t.Out.SendUpdatePlayer();
                    }
                    else t.Out.SendMessage("You don't have enough Bounty Pounts!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
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