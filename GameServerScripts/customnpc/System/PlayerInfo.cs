//Author : Unknown

using System;
using System.IO;
using System.Reflection;
using System.Collections;
using DOL;
using DOL.Events;
using DOL.Database;
using DOL.GS;
using DOL.GS.Spells;
using DOL.GS.Effects;
using DOL.GS.PacketHandler;
using DOL.Language;
using log4net;
using System.Collections.Generic;

namespace DOL.GS.Commands
{
    [Cmd("&info", //command to handle
    ePrivLevel.Player, //minimum privelege level
    "Displays a players stats, and equipped items.", //command description
        //usage
    "/info stats",
    "/info equip")]

    public class InfoCommandHandler : AbstractCommandHandler, ICommandHandler
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public void OnCommand(GameClient client, string[] args)
        {
            if (args.Length > 4)
                return;
            if (args.Length == 1)
                return;
            string clientLanguage = client.Account.Language;
            GamePlayer player = client.Player.TargetObject as GamePlayer;
            if (player == null)
            {
                client.Out.SendMessage("You must select a player to view!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                return;
            }
            string targetLanguage = player.Client.Account.Language;
            switch (args[1])
            {
                case "stats":
                    {
                        if (args.Length != 2) return;
                        IList<string> text = new List<string>();
                        text.Add("---------------------------");
                        text.Add(" Player Informations       ");
                        text.Add("---------------------------");
                        text.Add("- Name: " + player.Name);
                        text.Add("- Lastname: " + player.LastName);
                        text.Add("- Class: " + player.CharacterClass.Name);
                        text.Add("- Guild: " + player.GuildName);
                        text.Add("- Realm: " + player.Realm);
                        text.Add("- Realmpoints: " + player.RealmPoints);
                        text.Add("- Realmrank: " + string.Format("{0:#L#} {1}", player.RealmLevel + 10, player.RealmTitle));
                        text.Add("- Speed: " + player.CurrentSpeed + "");
                        text.Add("- Max Speed: " + player.MaxSpeed + "");
                        text.Add("- Max Speed Base: " + player.MaxSpeedBase + "");
                        text.Add("---------------------------");
                        text.Add(" Character Stats           ");
                        text.Add("---------------------------");
                        text.Add("- Strength : " + player.Strength);
                        text.Add("- Dexterity : " + player.Dexterity);
                        text.Add("- Constitution : " + player.Constitution);
                        text.Add("- Quickness : " + player.Quickness);
                        text.Add("- Empathy : " + player.Empathy);
                        text.Add("- Charisma : " + player.Charisma);
                        text.Add("- Piety : " + player.Piety);
                        text.Add("- Intelligence : " + player.Intelligence);
                        text.Add("---------------------------");
                        text.Add(" Account Information       ");
                        text.Add("---------------------------");
                        text.Add("- Priv. Level: " + player.Client.Account.PrivLevel);
                        client.Out.SendCustomTextWindow("~*Player Character Informations*~", text);
                    }
                    break;
                case "equip":
                    {
                        if (args.Length != 2) return;
                        IList<string> text = new List<string>();
                        text.Add("---------------------------");
                        text.Add(" Equiped Items             ");
                        text.Add("---------------------------");
                        if (player.Inventory != null)
                        {
                            foreach (InventoryItem item in player.Inventory.EquippedItems)
                                text.Add("- " + GlobalConstants.SlotToName(item.SlotPosition) + ": " + item.Name);
                        }
                        client.Out.SendCustomTextWindow("~*Players Equipment Informations*~", text);
                    }
                    break;
                default: return;
            }
            return;
        }
    }
}