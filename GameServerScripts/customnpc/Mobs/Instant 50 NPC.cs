/*
 *  Script by Taovil/ Dean *Free Gear*
 *  Modified by Dargion *Instant 50 With Free Gear*
 *  
 *  This npc will give you instant 50 only if you do not have a 50 on your account, 
 *      then give you a set of free armor and weapons
 * 
 */

using System;
using DOL;
using DOL.GS;
using DOL.Events;
using DOL.GS.PacketHandler;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using DOL.Database;
using log4net;


namespace DOL.GS.Scripts
{


    
    public class Instant50NPC : GameNPC
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        
		 public override bool AddToWorld()
        {
			
		
            base.AddToWorld();
            this.Flags = eFlags.PEACE ;
            return true;
        }
        [ScriptLoadedEvent]
        public static void ScriptLoaded(DOLEvent e, object sender, EventArgs args)
        {
            if (log.IsInfoEnabled)
                log.Info("I50 NPC Loading...");
		}
        public void SendReply(GamePlayer player, string msg)
        {
            player.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }
        public override bool Interact(GamePlayer player)
        {
            if (!base.Interact(player))
                return false;

            //FinalFury: Reduced 5000 to 250, causes lag on some systems
           
            player.Out.SendMessage("Hello "+player.Name+", I am able to give your character [Instant] 50.", eChatType.CT_Say, eChatLoc.CL_PopupWindow);


            return true;
        }

        public override bool WhisperReceive(GameLiving source, string str)
        {
            if (!base.WhisperReceive(source, str))
                return false;

            GamePlayer player = source as GamePlayer;

            if (player == null)
                return false;


            if (str == "Instant" && player.Level != 50 && (player.CharacterClass.ID != (byte)eCharacterClass.Fighter || player.CharacterClass.ID != (byte)eCharacterClass.Elementalist || player.CharacterClass.ID != (byte)eCharacterClass.Acolyte || player.CharacterClass.ID != (byte)eCharacterClass.AlbionRogue || player.CharacterClass.ID != (byte)eCharacterClass.Mage ||
                player.CharacterClass.ID != (byte)eCharacterClass.Viking || player.CharacterClass.ID != (byte)eCharacterClass.Seer || player.CharacterClass.ID != (byte)eCharacterClass.Mystic || player.CharacterClass.ID != (byte)eCharacterClass.MidgardRogue ||
                player.CharacterClass.ID != (byte)eCharacterClass.Guardian || player.CharacterClass.ID != (byte)eCharacterClass.Stalker || player.CharacterClass.ID != (byte)eCharacterClass.Magician || player.CharacterClass.ID != (byte)eCharacterClass.Naturalist || player.CharacterClass.ID != (byte)eCharacterClass.Animist ||
                player.CharacterClass.ID != (byte)eCharacterClass.Necromancer || player.CharacterClass.ID != (byte)eCharacterClass.Enchanter || player.CharacterClass.ID != (byte)eCharacterClass.Spiritmaster || player.CharacterClass.ID != (byte)eCharacterClass.Bonedancer || player.CharacterClass.ID != (byte)eCharacterClass.Cabalist || player.CharacterClass.ID != (byte)eCharacterClass.Valkyrie))
            {


                player.Out.SendMessage("Congrats on achieving level 50 you lazy bum!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                player.Level = 50;

                return true;
            }

            else
            {
                player.Out.SendMessage("Your class is not affected by my magic!", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
            }

            if (str == "Weapons")
            {
                
                return true;
            }
            return true;
        }

    }
}