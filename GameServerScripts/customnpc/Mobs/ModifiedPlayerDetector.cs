/*
 * Author: Supgee
 * Date: August 30th, 2007.
 * Description: This NPC here detects all modded players that are currently playing. Every 15 seconds, he will punt anybody found with modified stats.
 * The maximum allowed stats or skill points is totally up to the server administrator. Just edit the constant integers set for each Max Stats. Thanks!
 * - Supgee
 */
using System;
using System.Reflection;
using DOL.Events;
using DOL.GS;
using DOL.GS.PacketHandler;
using log4net;

namespace DOL.GS.Scripts
{
    public class ModdedPlayerDetector : GameNPC
    {
        public ModdedPlayerDetector()
            : base()
        {
            Flags |= GameNPC.eFlags.PEACE;
        }
        public const int INTERVAL = 15 * 1000; 
        
        int totaloffenses;
        
        public const int MaxStrength = 475; 
        public const int MaxDexterity = 475;
        public const int MaxConstitution = 400;
        public const int MaxQuickness = 300;
        public const int MaxEmpathy = 400;
        public const int MaxCharisma = 400;
        public const int MaxPiety = 400; 
        public const int MaxIntelligence = 400;
        public const int MaxLevel = 50;
        public const int MaxSpecPoints = 3000;

        private static ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected virtual int Timer(RegionTimer callingTimer)
        {
            foreach (GameClient client in WorldMgr.GetAllPlayingClients())
            {
                if (client.Player.SkillSpecialtyPoints > MaxSpecPoints)
                {
                    if (client.Player.Client.Account.PrivLevel > 1)
                        return 0;
                    if (client.ClientState == GameClient.eClientState.WorldEnter)
                        // don't kick the player if they are still loading. It causes a weird client bug. Just wait until the next interval, and they will be removed.
                        return 0;
                    else
                    {
                        client.Player.Out.SendMessage("Your amount of specialization points has been detected modified. (" + client.Player.SkillSpecialtyPoints + " points)", eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                        log.Warn(client.Player.Name + " detected with modified specialization points. (" + client.Player.SkillSpecialtyPoints + " points). Kicking Player.");
                        GameServer.Instance.Disconnect(client);
                        totaloffenses++;
                    }
                }
                if (client.Player.Level > MaxLevel)
                {
                    if (client.Player.Client.Account.PrivLevel > 1)
                        return 0;
                    if (client.ClientState == GameClient.eClientState.WorldEnter)
                        // don't kick the player if they are still loading. It causes a weird client bug. Just wait until the next interval, and they will be removed.
                        return 0;
                    else
                    {
                        client.Player.Out.SendMessage("Your level has been detected modified. (Level: " + client.Player.Level + ")", eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                        log.Warn(client.Player.Name + " detected with modified level. (Level: " + client.Player.Level + ")");
                        GameServer.Instance.Disconnect(client);
                        totaloffenses++;
                    }
                }
                if (client.Player.Strength > MaxStrength)
                {
                    if (client.Player.Client.Account.PrivLevel > 1)
                        return 0;
                    if (client.ClientState == GameClient.eClientState.WorldEnter)
                        // don't kick the player if they are still loading. It causes a weird client bug. Just wait until the next interval, and they will be removed.
                        return 0;
                    else
                    {
                        client.Player.Out.SendMessage("Your strength has been detected modified. (" + client.Player.Strength + " strength)", eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                        log.Warn(client.Player.Name + " detected with modified strength. (" + client.Player.Strength + " strength). Kicking Player.");
                        GameServer.Instance.Disconnect(client);
                        totaloffenses++;
                    }
                }
                if (client.Player.Dexterity > MaxDexterity)
                {
                    if (client.Player.Client.Account.PrivLevel > 1)
                        return 0;
                    if (client.ClientState == GameClient.eClientState.WorldEnter)
                        // don't kick the player if they are still loading. It causes a weird client bug. Just wait until the next interval, and they will be removed.
                        return 0;
                    else
                    {
                        client.Player.Out.SendMessage("Your dexterity has been detected modified. (" + client.Player.Dexterity + " dexterity)",eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                        log.Warn(client.Player.Name + " detected with modified dexterity. (" + client.Player.Dexterity + " dexterity). Kicking Player.");
                        GameServer.Instance.Disconnect(client);
                        totaloffenses++;
                    }
                }
                if (client.Player.Constitution > MaxConstitution)
                {
                    if (client.Player.Client.Account.PrivLevel > 1)
                        return 0;
                    if (client.ClientState == GameClient.eClientState.WorldEnter)
                        // don't kick the player if they are still loading. It causes a weird client bug. Just wait until the next interval, and they will be removed.
                        return 0;
                    else
                    {
                        client.Player.Out.SendMessage("Your constitution has been detected modified. (" + client.Player.Constitution + " constitution)",eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                        log.Warn(client.Player.Name + " detected with modified constitution. (" + client.Player.Constitution + " constitution). Kicking Player.");
                        GameServer.Instance.Disconnect(client);
                        totaloffenses++;
                    }
                }
                if (client.Player.Quickness > MaxQuickness)
                {
                    if (client.Player.Client.Account.PrivLevel > 1)
                        return 0;
                    if (client.ClientState == GameClient.eClientState.WorldEnter)
                        // don't kick the player if they are still loading. It causes a weird client bug. Just wait until the next interval, and they will be removed.
                        return 0;
                    else
                    {
                        client.Player.Out.SendMessage("Your quickness has been detected modified. (" + client.Player.Quickness + " quickness)",eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                        log.Warn(client.Player.Name + " detected with modified quickness. (" + client.Player.Quickness + " quickness). Kicking Player.");
                        GameServer.Instance.Disconnect(client);
                        totaloffenses++;
                    }
                }
                if (client.Player.Empathy > MaxEmpathy)
                {
                    if (client.Player.Client.Account.PrivLevel > 1)
                        return 0;
                    if (client.ClientState == GameClient.eClientState.WorldEnter)
                        // don't kick the player if they are still loading. It causes a weird client bug. Just wait until the next interval, and they will be removed.
                        return 0;
                    else
                    {
                        client.Player.Out.SendMessage("Your empathy has been detected modified. (" + client.Player.Empathy + " empathy)",eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                        log.Warn(client.Player.Name + " detected with modified empathy. (" + client.Player.Empathy + " empathy). Kicking Player.");
                        GameServer.Instance.Disconnect(client);
                        totaloffenses++;
                    }
                }
                if (client.Player.Charisma > MaxCharisma)
                {
                    if (client.Player.Client.Account.PrivLevel > 1)
                        return 0;
                    if (client.ClientState == GameClient.eClientState.WorldEnter)
                        // don't kick the player if they are still loading. It causes a weird client bug. Just wait until the next interval, and they will be removed.
                        return 0;
                    else
                    {
                        client.Player.Out.SendMessage("Your charisma has been detected modified. (" + client.Player.Charisma + " charisma)",eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                        log.Warn(client.Player.Name + " detected with modified charisma. (" + client.Player.Charisma + " charisma). Kicking Player.");
                        GameServer.Instance.Disconnect(client);
                        totaloffenses++;
                    }
                }
                if (client.Player.Piety > MaxPiety)
                {
                    if (client.Player.Client.Account.PrivLevel > 1)
                        return 0;
                    if (client.ClientState == GameClient.eClientState.WorldEnter)
                        // don't kick the player if they are still loading. It causes a weird client bug. Just wait until the next interval, and they will be removed.
                        return 0;
                    else
                    {
                        client.Player.Out.SendMessage("Your piety has been detected modified. (" + client.Player.Piety + " piety)",eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                        log.Warn(client.Player.Name + " detected with modified piety. (" + client.Player.Piety + " piety). Kicking Player.");
                        GameServer.Instance.Disconnect(client);
                        totaloffenses++;
                    }
                }
                if (client.Player.Intelligence > MaxIntelligence)
                {
                    if (client.Player.Client.Account.PrivLevel > 1)
                        return 0;
                    if (client.ClientState == GameClient.eClientState.WorldEnter)
                        // don't kick the player if they are still loading. It causes a weird client bug. Just wait until the next interval, and they will be removed.
                        return 0;
                    else
                    {
                        client.Player.Out.SendMessage("Your intelligence has been detected modified. (" + client.Player.Intelligence + " intelligence)",eChatType.CT_Staff, eChatLoc.CL_SystemWindow);
                        log.Warn(client.Player.Name + " detected with modified intelligence. (" + client.Player.Intelligence + " intelligence). Kicking Player.");
                        GameServer.Instance.Disconnect(client);
                        totaloffenses++;
                    }
                }

            }
            return INTERVAL;
        }

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
        
            //if (success) new RegionTimer(this, new RegionTimerCallback(Timer), INTERVAL);
            //return success;
        }
        public override bool Interact(GamePlayer player)
        {
            if (!base.Interact(player))
                return false;

            switch (player.Client.Account.PrivLevel)
            {
                case 1:
                    {
                        player.Out.SendMessage(this.Name + " says, I'm sorry. I'm a tad busy at the moment.", eChatType.CT_Important, eChatLoc.CL_ChatWindow);
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
    }
}
