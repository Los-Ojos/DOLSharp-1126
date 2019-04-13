using System;
using System.Reflection;
using DOL.Events;
using DOL.GS;
using DOL.GS.PacketHandler;
using log4net;
using System.Collections;
using System.Text;
using DOL.Database;
using DOL.Language;
using System.Net;

namespace DOL.GS.Scripts
{
    public class Modded : GameNPC
    {

        public const int MaxSpecPoints = 3810;
        public const int Speed = 625;

        private static ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public const int INTERVAL = 20 * 1000;
        int totaloffenses;

        #region What It Does!
        protected virtual int Timer(RegionTimer callingTimer)
        {
            foreach (GameClient client in WorldMgr.GetAllPlayingClients())
            {
               

                #region Kick Speed Hackers
                //Wont Kick Spectators or Gm/Admins
                if (client.Player.MaxSpeed > Speed && client.Player.Client.Account.PrivLevel == 1)
                {
                    foreach (GameClient player in WorldMgr.GetAllPlayingClients())
                    {
                        player.Out.SendMessage("Auto Kick\n" +
                        client.Player.Name + " From IP (" + client.Account.LastLoginIP + ") Has Been Kicked For Trying To Speed Hack!", eChatType.CT_Staff, eChatLoc.CL_ChatWindow);
                    }
                    StringBuilder builder = new StringBuilder();
                    builder.Append("Class= (" + client.Player.CharacterClass.Name + ") Speed= (" + client.Player.MaxSpeed + ")" + " Name= (" + client.Player.Name + ")" + " Account= (" + client.Account.Name + ") IP= (" + client.Account.LastLoginIP + ")");
                    GameServer.Instance.LogCheatAction(builder.ToString());

                    client.Player.Out.SendMessage("Read The Rules Its Not Hard", eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                    GameServer.Instance.Disconnect(client);
                    totaloffenses++;
                    return INTERVAL;
                }

                if (client.Player.MaxSpeedBase > Speed && client.Player.Client.Account.PrivLevel == 1)
                {
                    foreach (GameClient player in WorldMgr.GetAllPlayingClients())
                    {
                        player.Out.SendMessage("Auto Kick\n" +
                        client.Player.Name + " From IP (" + client.Account.LastLoginIP + ") Has Been Kicked For Trying To Speed Hack!", eChatType.CT_Staff, eChatLoc.CL_ChatWindow);
                    }
                    StringBuilder builder = new StringBuilder();
                    builder.Append("Class= (" + client.Player.CharacterClass.Name + ") Speed Base = (" + client.Player.MaxSpeedBase + ")" + " Name= (" + client.Player.Name + ")" + " Account= (" + client.Account.Name + ") IP= (" + client.Account.LastLoginIP + ")");
                    GameServer.Instance.LogCheatAction(builder.ToString());

                    client.Player.Out.SendMessage("Read The Rules Its Not Hard", eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                    GameServer.Instance.Disconnect(client);
                    totaloffenses++;
                    return INTERVAL;
                }
                #endregion

                

                client.Out.SendSpellCastAnimation(this, 4321, 30);
                RegionTimer timer = new RegionTimer(client.Player, new RegionTimerCallback(ShowEffect), 3000);
            }
            return INTERVAL;
        }
        #endregion

        #region ShowEffect
        public int ShowEffect(RegionTimer timer)
        {
            foreach (GamePlayer player in this.GetPlayersInRadius(WorldMgr.VISIBILITY_DISTANCE))
            {
                player.Out.SendSpellEffectAnimation(this, this, 4321, 0, false, 1);
            }
            foreach (GamePlayer player in this.GetPlayersInRadius(WorldMgr.INFO_DISTANCE))
            {
                player.Out.SendMessage("My job is to find any hackers! (0) hackers in the last 20 seconds.", eChatType.CT_Spell, eChatLoc.CL_SystemWindow);
            }
            timer.Stop();
            timer = null;
            return 0;
        }
        #endregion

        #region AddToWorld
        public override bool AddToWorld()
        {
            GameNpcInventoryTemplate template = new GameNpcInventoryTemplate();
            template.AddNPCEquipment(eInventorySlot.DistanceWeapon, 3356, 134);
            template.AddNPCEquipment(eInventorySlot.TwoHandWeapon, 3356, 134);
            Inventory = template.CloseTemplate();
            Name = "Sherlock Holmes";
            GuildName = "Player Detector";
            Flags |= GameNPC.eFlags.PEACE;
            Model = 1276;
            Size = 50;
            Level = 80;
            MaxSpeedBase = 0;

            bool success = base.AddToWorld();
            if (success) new RegionTimer(this, new RegionTimerCallback(Timer), INTERVAL);
            return success;
        }
        #endregion

        #region Interact
        public override bool Interact(GamePlayer player)
        {
            if (!base.Interact(player))
                return false;

            switch (player.Client.Account.PrivLevel)
            {
                case 1:
                    {
                        player.Out.SendMessage(this.Name + " says, I'm looking for any Modded/Hacking players please go away.", eChatType.CT_Important, eChatLoc.CL_ChatWindow);
                    }
                    break;
                case 2:
                    {
                        player.Out.SendMessage(this.Name + " says, There have been " + totaloffenses + " offenses since last server reboot.", eChatType.CT_Important, eChatLoc.CL_ChatWindow);
                    }
                    break;
                case 3:
                    {
                        player.Out.SendMessage(this.Name + " says, There have been " + totaloffenses + " offenses since last server reboot.", eChatType.CT_Important, eChatLoc.CL_ChatWindow);
                    }
                    break;
                default: break;
            }
            return true;
        }
        #endregion
    }
}
