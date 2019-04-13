using System;
using DOL.GS;
using DOL.Events;
using DOL.GS.PacketHandler;
using log4net;
using System.Reflection;

namespace DOL.GS.Scripts
{
	public class TeleportMobOut: GameNPC
	{
		private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		
		public override bool AddToWorld()
        {
			Level=50;
            base.AddToWorld();
            return true;
        }
		public override bool Interact(GamePlayer player)
		{
			if (!base.Interact(player)) return false;
			//TurnTo(player.X,player.Y);
			player.Out.SendMessage("Hello "+player.Name+"! Would you like to [RvR], or move to a [Portal Keep]?", eChatType.CT_Say,eChatLoc.CL_PopupWindow);
			return true;
		}
		public override bool WhisperReceive(GameLiving source, string str)
		{
			if(!base.WhisperReceive(source,str)) return false;
		  	if(!(source is GamePlayer)) return false;
			GamePlayer t = (GamePlayer) source;
			//TurnTo(t.X,t.Y);
			switch(str)
			{
                case "Portal Keep":
                    SendReply(t, "Would that be the [Albion] [Midgard] or [Hibernia] portal keep?");
                    break;

                case "Albion":
                    Say("I'm now teleporting you to the Albion portal keep");
                    t.MoveTo(238, 563118, 573761, 5408, 3042);
                    break;

                case "Midgard":
                    Say("I'm now teleporting you to the Midgard portal keep");
                    t.MoveTo(238, 569706, 541223, 5408, 3055);
                    break;

                case "Hibernia":
                    Say("I'm now teleporting you to the Hibernia portal keep");
                    t.MoveTo(238, 534596, 534058, 5408, 488);
                    break;

                case "RvR":
                    if (!t.InCombat)
                    {
                        int RandPvP = Util.Random(1, 5);//Creates a random number between 1 and 5
                        if (RandPvP == 1)
                        {// send you to  the gloc below if number 1 comes up random
                            t.MoveTo(238, 569010, 552070, 5301, 1485);
                        }
                        else if (RandPvP == 2)
                        {
                            t.MoveTo(238, 554329, 543530, 5059, 391);
                        }
                        else if (RandPvP == 3)
                        {
                            t.MoveTo(238, 550016, 563013, 4350, 2737);
                        }
                        else if (RandPvP == 4)
                        {
                            t.MoveTo(238, 543489, 558435, 4144, 2680);
                        }
                        else if (RandPvP == 5)
                        {
                            t.MoveTo(238, 559208, 544046, 4709, 34);
                        }
                    }
                    else { t.Client.Out.SendMessage("You can't port while in combat.", eChatType.CT_Say, eChatLoc.CL_PopupWindow); }
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