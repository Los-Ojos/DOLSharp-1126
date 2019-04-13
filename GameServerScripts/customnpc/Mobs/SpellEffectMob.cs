/* Written by BluRaven on 5/25/07
 * This script will take the mob's name, convert it to a
 * spell number, then send that spell animation to all
 * players in it's visibility distance, At a specific
 * interval.  The interval is two seconds.  Game creation
 * command: /mob create DOL.GS.Scripts.SpellEffectMob
 * then do /mob name <number> to set what spell number it
 * should cast on itself.  Then do /mob noname to hide
 * it's name from players.  You might also do want /mob
 * notarget and finally /mob model 1 if you want the mob
 * invisible, so they only see the spell effect.  How to
 * set randomness: /mob guild random will turn randomness
 * on.  Then set the mobs level to how random you want it.
 * Mob level 1 = a 2 in 1 chance (every pulse goes off).
 * Mob level 2 = a 2 in 2 chance (every pulse still goes off),
 * Mob level 3 is a 2 in 3 chance for the pulse to go off.
 * Mob level 4 is a 2 in 4 chance (50% chance) for the pulse
 * to go off.  A Mob level 255 would be a 2 in 255 chance
 * the pulse goes off, if you want to make it very seldom
 * that it goes off.  Experiment with different mob levels
 * to suite your needs. A chance to pulse would happen every
 * 2 seconds, but if it's random it won't pulse every time
 * (unless you set a level of 1, or 2 or turn randomness off)
 * It will pulse if the random number is either a 1 or if the
 * random number = the level of the mob.  You can uncomment
 * the "my random number was" line if you want to see how the
 * randoms work.  I reccommend making a 2nd script with a 10
 * second interval as well because some spell effects are
 * better suited for 10+ seconds inbetween pulses.
 * I've also noticed it helps to move the mob after placing
 * it for the first time to get it to refresh.
 * 
 * To Recap, Set it's name to a spell number, set it's guild
 * to "random" (or "Random" or "RANDOM") if you want random.
 * Set it's level (low number = often, High number = seldom).
 * 
 * Version 2:  added code to keep it from pulsing too much.
 * 
 * Version 3: Now it uses the mob's aggro range for setting the
 * distance at which the effect is visible to the player.
 */

using System;
using DOL.GS;
using DOL.AI;
using DOL.AI.Brain;
using DOL.Database;
using DOL.GS.PacketHandler;
using DOL.GS.Scripts;

namespace DOL.GS.Scripts
{

    public class SpellEffectMob : GameNPC
    {
        public SpellEffectMob()
            : base()
        {
        }
        bool IsRandom = false;
        bool Virgin = true; //touched for the very first time ;)
        public const int INTERVAL = 2 * 1000;
        ushort spellID = 0;
        int random = 0;
        

        protected virtual int Timer(RegionTimer callingTimer)
        {
            int range = ((this.Brain as StandardMobBrain).AggroRange);
            foreach (GamePlayer player in this.GetPlayersInRadius((ushort)range)) //each player that is in Aggro Range distance of the mob
            {
                
                if (Name == "New Mob") { player.Out.SendMessage(Name + " says change my name to a spell number!", eChatType.CT_System, eChatLoc.CL_SystemWindow); return 0; }
                if ((GuildName == "random") || (GuildName == "Random") || (GuildName == "RANDOM")) { IsRandom = true; }
                else { IsRandom = false; }
                if (IsRandom) { random = Util.Random(1, (Level)); }
                
                    spellID = Convert.ToUInt16(Name); //Take the mob's name and convert it to a number and store that in SpellID.

                    //Uncomment the line below to see the randoms in game each time a new one is picked.
                    //player.Out.SendMessage(Name + " says my random number was " + random + "!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    if ((IsRandom) && ((random == 1) || (random == Level)))
                    {

                        player.Out.SendSpellEffectAnimation(this, this, spellID, 0, false, 1);
                        
                    }
                    if (!IsRandom)
                    {
                        player.Out.SendSpellEffectAnimation(this, this, spellID, 0, false, 1);
                        
                    }

          
 
            }
            return INTERVAL;
        }

        public override bool AddToWorld()
        {
            bool success = base.AddToWorld();
            if (Virgin)
            {
                if (success) new RegionTimer(this, new RegionTimerCallback(Timer), INTERVAL);
                Virgin = false; //I'm a dirty girl, this isn't the first time.
            }
                return success;
            
        }

    }
}