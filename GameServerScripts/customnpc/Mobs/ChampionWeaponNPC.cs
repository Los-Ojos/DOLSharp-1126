using System;
using System.Collections;
using System.Timers;
using DOL;
using DOL.AI.Brain;
using DOL.GS;
using DOL.GS.Scripts;
using DOL.GS.GameEvents;
using DOL.GS.PacketHandler;
using DOL.GS.Quests;
using DOL.GS.Spells;
using DOL.GS.Effects;
using DOL.Database;
using DOL.Events;


namespace DOL.GS.Scripts
{

    public class ChampNPC : GameNPC
    {
        public override bool Interact(GamePlayer player)
        {

            TurnTo(player, 100);
            this.TargetObject = player;

            if (!base.Interact(player)) return false;
            if (player.ChampionLevel >= 5)
            {
                player.Out.SendMessage("Hello, I'm the Kings Armsmaster.\n" +
                  "I have [Weapons] if you are truely worthy! But it will cost you 2000 bounty points.\n", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
                return true;
            }
            if (player.ChampionLevel <= 4)
                player.Out.SendMessage("Hello, I'am the Kings Armsmaster.\n" +
               "Reach Champion level 5 and I shall grant you a reward, you are currently Champion Level " + player.ChampionLevel + " !", eChatType.CT_Say, eChatLoc.CL_PopupWindow);
            return true;
        }


        public override bool WhisperReceive(GameLiving player, string str)
        {
            GamePlayer t = (GamePlayer)player;

            switch (str)
            {
                #region Albion Champion Weapons

                case "Weapons":
                    {
                        if (t.CharacterClass.Name == "Wizard" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("UpsilonWizardStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Sorcerer" || t.CharacterClass.Name == "Sorceress" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("UpsilonSorcererStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Cabalist" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("UpsilonCabalistStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Theurgist" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("UpsilonTheurgistStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }
                        if (t.CharacterClass.Name == "Necromancer" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("UpsilonNecromancerStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }
                        if (t.CharacterClass.Name == "Armsman" || t.CharacterClass.Name == "Armswoman" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDexteraBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDexteraEdge");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanDexteraMace");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanSatagoArchMace");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanSatagoFlamberge");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);

                            InventoryItem generic5 = new InventoryItem();
                            ItemTemplate tgeneric5 = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanSatagoHalberd");
                            generic5 = GameInventoryItem.Create<ItemTemplate>(tgeneric5);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic5);

                            InventoryItem generic6 = new InventoryItem();
                            ItemTemplate tgeneric6 = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanSatagoLance");
                            generic6 = GameInventoryItem.Create<ItemTemplate>(tgeneric6);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic6);

                            InventoryItem generic7 = new InventoryItem();
                            ItemTemplate tgeneric7 = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanSatagoMattock");
                            generic7 = GameInventoryItem.Create<ItemTemplate>(tgeneric7);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic7);

                            InventoryItem generic8 = new InventoryItem();
                            ItemTemplate tgeneric8 = GameServer.Database.FindObjectByKey<ItemTemplate>("ArmsmanSatagoPike");
                            generic8 = GameInventoryItem.Create<ItemTemplate>(tgeneric8);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic8);

                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Cleric" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ClericDexteraMace");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Friar" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("FriarDexteraMace");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("FriarSatagoQuarterStaff");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Heretic" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("HereticDexteraBarbedChain");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("HereticDexteraFlail");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("HereticDexteraMace");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Infiltrator" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("InfiltratorDexteraBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("InfiltratorDexteraEdge");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("InfiltratorLaevusBlade");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("InfiltratorLaevusEdge");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Mercenary" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryDexteraBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryDexteraEdge");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryDexteraMace");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryLaevusBlade");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryLaevusEdge");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);

                            InventoryItem generic5 = new InventoryItem();
                            ItemTemplate tgeneric5 = GameServer.Database.FindObjectByKey<ItemTemplate>("MercenaryLaevusMace");
                            generic5 = GameInventoryItem.Create<ItemTemplate>(tgeneric5);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic5);

                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Minstrel" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("MinstrelDexteraBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("MinstrelDexteraEdge");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("MinstrelDexteraHarp");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Paladin" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinDexteraBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinDexteraEdge");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinDexteraMace");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinSatagoGreatEdge");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinSatagoGreatHammer");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);

                            InventoryItem generic5 = new InventoryItem();
                            ItemTemplate tgeneric5 = GameServer.Database.FindObjectByKey<ItemTemplate>("PaladinSatagoGreatSword");
                            generic5 = GameInventoryItem.Create<ItemTemplate>(tgeneric5);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic5);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Reaver" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ReaverDexteraBarbedChain");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ReaverDexteraBlade");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("ReaverDexteraEdge");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("ReaverDexteraFlail");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("ReaverDexteraMace");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Scout" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ScoutDexteraBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ScoutDexteraBow");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("ScoutDexteraEdge");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }
                #endregion Albion Champion Weapons

                        #region Midgard Champion Weapons

                        if (t.CharacterClass.Name == "Bonedancer" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("AnsuzBonedancerStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Runemaster" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("AnsuzRunemasterStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }
                        if (t.CharacterClass.Name == "Spiritmaster" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("AnsuzSpiritmasterStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Warlock" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("AnsuzWarlockStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Warrior" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazWarriorAxe");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazWarriorHammer");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazWarriorSword");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazWarriorTwohandedAxe");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazWarriorTwohandedHammer");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);

                            InventoryItem generic5 = new InventoryItem();
                            ItemTemplate tgeneric5 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazWarriorTwohandedSword");
                            generic5 = GameInventoryItem.Create<ItemTemplate>(tgeneric5);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic5);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Valkyrie" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazValkyrieSlashingSpear");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazValkyrieSword");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazValkyrieThrustingSpear");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazValkyrieTwohandedSword");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Healer" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazHealerTwohandedHammer");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazHealerHammer");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Shaman" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazShamanHammer");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazShamanTwohandedHammer");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Hunter" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazCompoundBow");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazHunterSlashingSpear");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazHunterSpear");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazHunterSword");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazHunterTwohandedSword");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Savage" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSavageAxe");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSavageHammer");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSavageSlashingGlaiverh");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSavageSlashingGlaivelh");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSavageSword");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);

                            InventoryItem generic5 = new InventoryItem();
                            ItemTemplate tgeneric5 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSavageThrashingGlaiverh");
                            generic5 = GameInventoryItem.Create<ItemTemplate>(tgeneric5);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic5);

                            InventoryItem generic6 = new InventoryItem();
                            ItemTemplate tgeneric6 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSavageThrashingGlaivelh");
                            generic6 = GameInventoryItem.Create<ItemTemplate>(tgeneric6);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic6);

                            InventoryItem generic7 = new InventoryItem();
                            ItemTemplate tgeneric7 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSavageTwohandedAxe");
                            generic7 = GameInventoryItem.Create<ItemTemplate>(tgeneric7);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic7);

                            InventoryItem generic8 = new InventoryItem();
                            ItemTemplate tgeneric8 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSavageTwohandedHammer");
                            generic8 = GameInventoryItem.Create<ItemTemplate>(tgeneric8);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic8);

                            InventoryItem generic9 = new InventoryItem();
                            ItemTemplate tgeneric9 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSavageTwohandedSword");
                            generic9 = GameInventoryItem.Create<ItemTemplate>(tgeneric9);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic9);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Shadowblade" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazShadowbladeAxe");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazShadowbladeHeavyAxe");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazShadowbladeHeavyAxe2");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazShadowbladeHeavySword");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazShadowbladeSword");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Skald" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSkaldAxe");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSkaldHammer");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSkaldSword");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSkaldTwohandedAxe");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSkaldTwohandedHammer");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);

                            InventoryItem generic5 = new InventoryItem();
                            ItemTemplate tgeneric5 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazSkaldTwohandedSword");
                            generic5 = GameInventoryItem.Create<ItemTemplate>(tgeneric5);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic5);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Thane" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazThaneAxe");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazThaneHammer");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazThaneSword");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazThaneTwohandedAxe");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazThaneTwohandedHammer");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);

                            InventoryItem generic5 = new InventoryItem();
                            ItemTemplate tgeneric5 = GameServer.Database.FindObjectByKey<ItemTemplate>("ThurisazThaneTwohandedSword");
                            generic5 = GameInventoryItem.Create<ItemTemplate>(tgeneric5);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic5);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }
                        #endregion Midgard Champion Weapons

                        #region Hibernia Champion Weapons

                        if (t.CharacterClass.Name == "Animist" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DraiochtAnimistStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Bainshee" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DraiochtBainsheeStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Eldritch" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DraiochtEldritchStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Enchanter" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DraiochtEnchanterStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Mentalist" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DraiochtMentalistStaff");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Valewalker" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharValewalkerScythe");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Vampiir" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("VampiirFuarSteel");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Bard" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("BardDocharHarp");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharBardBlade");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharBardHammer");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Druid" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharDruidBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharDruidHammer");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Warden" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharWardenBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharWardenHammer");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Blademaster" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharBlademasterBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharBlademasterHammer");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharBlademasterSteel");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("BlademasterFuarBlade");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("BlademasterFuarHammer");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);

                            InventoryItem generic5 = new InventoryItem();
                            ItemTemplate tgeneric5 = GameServer.Database.FindObjectByKey<ItemTemplate>("BlademasterFuarSteel");
                            generic5 = GameInventoryItem.Create<ItemTemplate>(tgeneric5);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic5);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Champion" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharChampionBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharChampionHammer");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharChampionSteel");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharChampionWarblade");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharChampionWarhammer");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Hero" || t.CharacterClass.Name == "Heroine" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharHeroBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharHeroHammer");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharHeroSpear");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharHeroSteel");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharHeroWarblade");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);

                            InventoryItem generic5 = new InventoryItem();
                            ItemTemplate tgeneric5 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharHeroWarhammer");
                            generic5 = GameInventoryItem.Create<ItemTemplate>(tgeneric5);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic5);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Nightshade" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharNightshadeBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharNightshadeSteel");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("NightshadeFuarBlade");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("NightshadeFuarSteel");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }

                        if (t.CharacterClass.Name == "Ranger" && t.ChampionLevel >= 5)
                        {
                            InventoryItem generic0 = new InventoryItem();
                            ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("RangerFuarBlade");
                            generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                            InventoryItem generic1 = new InventoryItem();
                            ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("RangerFuarSteel");
                            generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                            InventoryItem generic2 = new InventoryItem();
                            ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharRangerBlade");
                            generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                            InventoryItem generic3 = new InventoryItem();
                            ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharRangerSteel");
                            generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                            InventoryItem generic4 = new InventoryItem();
                            ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("DocharRecurveBow");
                            generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                            t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);
                            t.UpdatePlayerStatus();
                            t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                        }
                    }
                    break;
                        #endregion Hibernia Champion Weapons

                #region Champion Jewelry

                case "^*(Jewelry":
                    {
                        InventoryItem generic0 = new InventoryItem();
                        ItemTemplate tgeneric0 = GameServer.Database.FindObjectByKey<ItemTemplate>("ChampionCloak");
                        generic0 = GameInventoryItem.Create<ItemTemplate>(tgeneric0);

                        t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic0);

                        InventoryItem generic1 = new InventoryItem();
                        ItemTemplate tgeneric1 = GameServer.Database.FindObjectByKey<ItemTemplate>("ChampionNecklace");
                        generic1 = GameInventoryItem.Create<ItemTemplate>(tgeneric1);

                        t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic1);

                        InventoryItem generic2 = new InventoryItem();
                        ItemTemplate tgeneric2 = GameServer.Database.FindObjectByKey<ItemTemplate>("ChampionBelt");
                        generic2 = GameInventoryItem.Create<ItemTemplate>(tgeneric2);

                        t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic2);

                        InventoryItem generic3 = new InventoryItem();
                        ItemTemplate tgeneric3 = GameServer.Database.FindObjectByKey<ItemTemplate>("ChampionJewel");
                        generic3 = GameInventoryItem.Create<ItemTemplate>(tgeneric3);

                        t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic3);

                        InventoryItem generic4 = new InventoryItem();
                        ItemTemplate tgeneric4 = GameServer.Database.FindObjectByKey<ItemTemplate>("ChampionRing");
                        generic4 = GameInventoryItem.Create<ItemTemplate>(tgeneric4);

                        t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic4);

                        InventoryItem generic5 = new InventoryItem();
                        ItemTemplate tgeneric5 = GameServer.Database.FindObjectByKey<ItemTemplate>("ChampionBand");
                        generic5 = GameInventoryItem.Create<ItemTemplate>(tgeneric5);

                        t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic5);

                        InventoryItem generic6 = new InventoryItem();
                        ItemTemplate tgeneric6 = GameServer.Database.FindObjectByKey<ItemTemplate>("ChampionBracer");
                        generic6 = GameInventoryItem.Create<ItemTemplate>(tgeneric6);

                        t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic6);

                        InventoryItem generic7 = new InventoryItem();
                        ItemTemplate tgeneric7 = GameServer.Database.FindObjectByKey<ItemTemplate>("ChampionWristBand");
                        generic7 = GameInventoryItem.Create<ItemTemplate>(tgeneric7);

                        t.Inventory.AddItem(eInventorySlot.FirstEmptyBackpack, generic7);
                        t.UpdatePlayerStatus();
                        t.Out.SendMessage("Here you are!", eChatType.CT_System, eChatLoc.CL_SystemWindow);
                    }
                    break;
            }
            return true;
        }
        private void SendReply(GamePlayer target, string msg)
        {
            target.Out.SendMessage(msg, eChatType.CT_System, eChatLoc.CL_PopupWindow);
        }
    }
}
                #endregion Champion Jewelry  