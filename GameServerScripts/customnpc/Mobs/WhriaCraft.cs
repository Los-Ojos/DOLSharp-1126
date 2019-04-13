using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

using DOL;
using DOL.Database;
using DOL.Events;
using DOL.GS;
using DOL.GS.Housing;
using DOL.GS.Spells;
using DOL.GS.PacketHandler;

using log4net;

namespace DOL.GS.Scripts
{
    public class WhriaCraft : GameNPC
    {
        public override bool AddToWorld()
        {
			Name = "WhriaCraft";
			GuildName = Enum.GetName(typeof(eCraftingSkill), Level);
			Size = 50;

            return base.AddToWorld(); // Finish up and add him to the world.
        }

        public override bool Interact(GamePlayer player) // What to do when a player clicks on me
        {
            if (!base.Interact(player)) return false;
			
			TargetObject = player;
			CastSpell(SkillBase.GetSpellByID(2430), SkillBase.GetSpellLine(GlobalSpellsLines.Mob_Spells));

			SayTo(player, "Welcome. I am WhriaCraft.\n You need 10 platinums to get 1000 craftskill values.\n");

			string stMsg="I can raise your craft skill. \n";
			for (int i=1;i<=8;i++)
			{
				if ((Enum.GetName(typeof(eCraftingSkill), i)).Trim()!="")
				stMsg=stMsg + "[" + i + "] " + Enum.GetName(typeof(eCraftingSkill), i) + "\n\n";
			}
			SayTo(player, stMsg);

            return true;
        }
		
		public override bool WhisperReceive(GameLiving source, string str) // What to do when a player whispers me
        {
            if (!base.WhisperReceive(source, str)) return false;
            if (!(source is GamePlayer)) return false;
            GamePlayer player = (GamePlayer)source;
            TurnTo(player.X, player.Y); // Turn to face the player

			int iCraftNum=Convert.ToInt32(str);
			
			if (iCraftNum<=0 || iCraftNum>15) return false;

	
			// 10p
			if (player.GetCurrentMoney() < 100000000)
			{
				SayTo(player, "You need 10p to reach 1000 craft skill");
				return false;
			}

			eCraftingSkill craftingSkillID = (eCraftingSkill)Convert.ToUInt16(iCraftNum);
			if (player.GetCraftingSkillValue(craftingSkillID)>=1000)
			{
				SayTo(player, "You are not newbies. Only newbies can use this.");
				return false;
			}

			player.GainCraftingSkill(craftingSkillID, 1000-player.GetCraftingSkillValue(craftingSkillID));
			
			player.RemoveMoney(100000000);
			player.Out.SendUpdateCraftingSkills();
			player.Out.SendUpdatePlayer();
			player.Out.SendUpdatePoints();
			player.Out.SendCharStatsUpdate();
			player.UpdatePlayerStatus();

			player.SaveIntoDatabase();

			SayTo(player, "I raise you skill. Good Bye !");
			
			return true;

		}
    }
}