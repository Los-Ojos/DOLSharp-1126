// A little script to help with the missing Jump Points in some clients... by jaystar
// Using Mob name and case to port to xyz locs.





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOL.Database;

using DOL.GS.Keeps;
using DOL.GS;
using DOL.GS.Spells;
using DOL.GS.PacketHandler;
using DOL.GS.Effects;
using DOL.AI.Brain;

namespace DOL.GS.Scripts
{
    public class RadiusPorter : GameNPC
    {
        public const int INTERVAL = 2 * 1000;

        protected virtual int Timer(RegionTimer callingTimer)
        {
            int range = ((this.Brain as StandardMobBrain).AggroRange);
            foreach (GamePlayer player in this.GetPlayersInRadius((500))) //500 units seems to be a good range, but change to your needs
            {
                switch (Name)
                {
                    case "SVASUDNF":
                        player.MoveTo(163, 651951, 313721, 9432, 1006);
                        break;
                    case "DLNF":
                        player.MoveTo(163, 396561, 618476, 9825, 1966);
                        break;
                }
                



            }
            return INTERVAL;
        }

        public override bool AddToWorld()
        {
            
            new RegionTimer(this, new RegionTimerCallback(Timer), INTERVAL);
            return base.AddToWorld();

        }
       
    }
}

