using System;
using System.Collections.Generic;
using System.Text;
using DOL.GS.PacketHandler;

namespace DOL.GS
{
    public class TimerResetNPC : GameNPC
    {
        public const int BP_COST = 750;

        public override bool Interact(GamePlayer player)
        {
            if (!(base.Interact(player)))
                return false;

            SayTo(player, string.Format("I can renew all of your timed abilies (including RAs) " +
                "for a low cost of [{0} Bounty Points]", BP_COST));

            return true;
        }
        public override bool WhisperReceive(GameLiving source, string text)
        {
            if (!(base.WhisperReceive(source, text)))
                return false;

            if (text == string.Format("{0} Bounty Points", BP_COST))
            {
                GamePlayer player = source as GamePlayer;


                if (player.BountyPoints <= BP_COST)
                {
                    SayTo(player, "You can't afford my services. Come back when you can!");
                    return false;
                }

                player.RemoveBountyPoints(BP_COST);
                player.ResetDisabledSkills();
            }

            return true;
        }
    }
}
