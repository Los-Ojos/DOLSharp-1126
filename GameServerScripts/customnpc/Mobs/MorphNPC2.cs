//Developed By Alezzandroz
//V 1.0

using System;
using DOL;
using DOL.GS;
using DOL.Events;
using DOL.Database;
using System.Collections;
using DOL.GS.PacketHandler;

namespace DOL.GS.Scripts
{
    public class MorphNPC2 : GameNPC
    {
        #region Interazione
        public override bool Interact(GamePlayer player)
        {
            if (!base.Interact(player)) return false;
            TurnTo(player, 500);
            SendReply(player, "Hi, If you are rr4 or above i can chenge your [morph]");
            if (player.Client.Account.Name.ToLower() == "bloodseeker1")
            {
                SendReply(player, "I can morph you into a [Ghost]");
            }
            if (player.Client.Account.Name.ToLower() == "recluse")
            {
                SendReply(player, "I can morph you into a [Sexy Lurikeen]");
            }
            if (player.Client.Account.Name.ToLower() == "kakarot")
            {
                SendReply(player, "I can morph you into a [Ugly Wnb Skeleton]");
            }
            return true;
        }
        #endregion
        #region Settaggio
        public override bool WhisperReceive(GameLiving source, string str)
        {
            if (!base.WhisperReceive(source, str)) return false;
            if (!(source is GamePlayer)) return false;
            GamePlayer player = (GamePlayer)source;
            if (str == "Sexy Lurikeen" && player.Client.Account.Name.ToLower() == "recluse")
            {
                player.Model = 327;
                player.SaveIntoDatabase();
            }
            if (str == "Ghost" && player.Client.Account.Name.ToLower() == "bloodseeker1")
            {
                player.Model = 1670;
                player.SaveIntoDatabase();
            }
            if (str == "Ugly Wnb Skeleton" && player.Client.Account.Name.ToLower() == "kakarot")
            {
                player.Model = 24;
                player.SaveIntoDatabase();
            }
            switch (str)
            {
                case "morph":
                    SendReply(player, "[rr4]\n[rr5]\n[rr7+]\n[reset]");
                    return true;
                case "rr4":
                    if (player.RealmPoints >= 213875)
                        SendReply(player, "[Blue Cabalist Pet]\n[Yummy Mummy]\n[Morvalt Lord]");
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "rr5":
                    if (player.RealmPoints >= 513500)
                        SendReply(player, "[Black Skeleton]\n[Dream Sphere Morph]\n[Jinni]\n[Small Sobekite]");
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "rr7+":
                    if (player.RealmPoints >= 1755250)
                        SendReply(player, "[Shade]]\n[Relic Guard]\n[Dwarf Male Stoned]\n[Abomination]");
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "Blue Cabalist Pet":
                    if (player.RealmPoints >= 213875)
                        player.Model = 243;
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "Yummy Mummy":
                    if (player.RealmPoints >= 213875)
                        player.Model = 1388;
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "Morvalt Lord":
                    if (player.RealmPoints >= 213875)
                        player.Model = 840;
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "Black Skeleton":
                    if (player.RealmPoints >= 513500)
                        player.Model = 938;
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "Dream Sphere Morph":
                    if (player.RealmPoints >= 513500)
                        player.Model = 104;
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "Jinni":
                    if (player.RealmPoints >= 513500)
                        player.Model = 1198;
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "Small Sobekite":
                    if (player.RealmPoints >= 513500)
                        player.Model = 1642;
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "Shade":
                    if (player.RealmPoints >= 1755250)
                        player.Model = 1377;
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "aaaaaaaRelaaaaaaaaaaaaaaaaaaaaaaaaaaa44343434343434343aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaiaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaac Guard":
                    if (player.RealmPoints >= 1755250)
                        player.Model = 1265;
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "Dwarf Male Stoned":
                    if (player.RealmPoints >= 1755250)
                        player.Model = 1331;
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "Abomination":
                    if (player.RealmPoints >= 1755250)
                        player.Model = 653;
                    else
                    {
                        SendReply(player, "You have no enought RR for use this morph QQ");
                        return true;
                    }
                    break;
                case "reset":
                    player.Model = (ushort)player.Client.Account.Characters[player.Client.ActiveCharIndex].CreationModel;
                    SayTo(player, eChatLoc.CL_ChatWindow, "Morph resetted!");
                    return true;

                default:
                    SayTo(player, eChatLoc.CL_ChatWindow, "What? :|");
                    break;
            }
            player.SaveIntoDatabase();
            SendReply(player, "Morph Done");
            return true;
        }
        #endregion
        private void SendReply(GamePlayer target, string msg)
        {
            target.Out.SendMessage(
                msg,
                eChatType.CT_Say, eChatLoc.CL_PopupWindow);
        }
    }
}