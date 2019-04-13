/*
 * BluRaven 2/17/09
 * /Translate command.  It allows players to translate a sentance using google translation from right within the game!
 * Credit goes to: Myself for the idea.  This blog: http://blogs.msdn.com/shahpiyush/archive/2007/06/09/3188246.aspx
 * for the google translation code (which did not work and needed minor tweaking to make it work properly).
 * The dol core for slash command code and the code for preventing the command from being spammed.
 * How to use: place the script in the scripts folder and restart the server.  Go in game and type /translate
 * to get a list of language codes and an example of how to use it.
 * What to check if the script stops working: google may change in the future how it returns the results.
 * If that happens you may need to adjust the line that says "result_box dir=" and "</div>" to what it was changed to.
 * If people find this really useful, perhaps it can be adopted to automatically translate what people say in
 * /broadcast, which would be possible because we already support /language to specify our language we speak.
 * I've put the request to google in a try/catch block so that incase google dosn't reply it won't crash your server.
 * If you modify this script please post your updated version with your notes on what you changed.  Enjoy!  -BluRaven
 */

using System;
using System.Net;
using System.Text;
using System.Collections;
using System.Reflection;
using DOL.Language;
using DOL.GS;
using DOL.GS.ServerProperties;
using DOL.GS.PacketHandler;
using System.Collections.Generic;

namespace DOL.GS.Commands
{
    [CmdAttribute(
        "&translate",
        ePrivLevel.Player,
        "Translate a sentance from a supported language to your client default language.",
        "/translate <input language> <output language> <sentance to translate>",
        "example: /translate fr en Le chat paresseux saute sur le chien dormant")]
    public class TranslateCommandHandler : AbstractCommandHandler, ICommandHandler
    {

        public void OnCommand(GameClient client, string[] args)
        {
            const string TRANS_TICK = "Trans_Tick";

            if (args.Length < 3)
            {
                DisplayUsage(client);
                DisplayLanguages(client);
                return;
            }


            if (client.Player.IsMuted)
            {
                client.Player.Out.SendMessage("You are muted. Spammers are not permitted to use the /translate command.", eChatType.CT_Staff, eChatLoc.CL_ChatWindow);
                return;
            }


            long TransTick = client.Player.TempProperties.getProperty(TRANS_TICK, 0);
            if (TransTick > 0 && TransTick - client.Player.CurrentRegion.Time <= 0)
            {
                client.Player.TempProperties.removeProperty(TRANS_TICK);
            }
            long changeTime = client.Player.CurrentRegion.Time - TransTick;
            if (changeTime < 3200 && TransTick > 0)
            {
                client.Player.Out.SendMessage("Please do not abuse the translate command!  Wait a while and try again.", eChatType.CT_Staff, eChatLoc.CL_ChatWindow);
                client.Player.TempProperties.setProperty(TRANS_TICK, client.Player.CurrentRegion.Time);
                return;
            }
            string message = string.Join(" ", args, 3, args.Length - 3);
            //TODO test args[1] and args[2] are valid language codes before trying to translate.
            string translated = TranslateText(message, args[1], args[2]);
            client.Player.Out.SendMessage("[Translated]: " + translated, eChatType.CT_Staff, eChatLoc.CL_ChatWindow);
            client.Player.TempProperties.setProperty(TRANS_TICK, client.Player.CurrentRegion.Time);
            return;
        }

        /// <summary>
        /// Translate Text using Google Translate
        /// Google URL - http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="inlang">The two letter language code of what is being passed in.
        /// <param name="outlang">The two letter language code of what you want to get back.
        /// E.g. inlang ar and outlang en means to translate from Arabic to English</param>
        /// <returns>Translated to String</returns>
        public static string TranslateText(string input, string inlang, string outlang)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}|{2}", input, inlang, outlang);
            WebClient webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;
            try
            {
                string result = webClient.DownloadString(url);
                //find the translation result and cut off everything before it.
                result = result.Substring(result.IndexOf("result_box dir=") + 21, 500);
                //find the end of the translation and cut off everything after it.
                result = result.Substring(0, result.IndexOf("</div>"));
                //what you should have left is the pure translation result.
                return result;
            }
            catch
            {
                //either google timed out, no internet connection was available, or something else went wrong.
                string result = "An error occurred while translating.  Translation is not available.";
                return result;
            }
        }


        private void DisplayUsage(GameClient client)
        {
            DisplayMessage(client, "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            DisplayMessage(client, "Correct usage: /translate <from code> <to code> <sentance to translate>");
            DisplayMessage(client, "common language codes: en=english, es=spanish, fr=french, de=german");
            DisplayMessage(client, "example: /translate fr en Le chat paresseux saute sur le chien dormant");
            DisplayMessage(client, "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            return;
        }
        private void DisplayLanguages(GameClient client)
        {
            List<string> text = new List<string>();
            text.Add("ar=Arabic, bg=Bulgarian, ca=Catalan, cn=Chinese(Simplified), tw=Chinese(Traditional)," +
            " hr=Croatian, cs=Czech, da=Danish, nl=Dutch, en=English, tl=Filipino, fi=Finnish," +
            " fr=French, de=German, el=Greek, iw=Hebrew, hi=Hindi, id=Indonesian, it=Italian,");
            text.Add(" ja=Japanese, ko=Korean, lv=Latvian, lt=Lithuanian, no=Norwegian, pl=Polish," +
            " BR=Portuguese, ro=Romanian, ru=Russian, sr=Serbian, sk=Slovak, sl=Slovenian," +
            " es=Spanish, sv=Swedish, uk=Ukrainian, vn=Vietnamese.");
            client.Out.SendCustomTextWindow("~*ALL LANGUAGE CODES*~", text);
            return;
        }

    }

}

