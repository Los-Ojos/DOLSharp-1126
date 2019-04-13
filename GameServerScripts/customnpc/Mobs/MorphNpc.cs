/* Made By Kedrik.
 * Majorly Modded by Exde.
 */

using System;
using DOL;
using DOL.GS;
using DOL.Events;
using DOL.Database;
using System.Collections;
using DOL.GS.PacketHandler;

namespace DOL.GS.Scripts
{
	public class MorphNPC: GameNPC
    {
        private int Chance;//Chance for Prefixes
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
            Flags |= eFlags.PEACE;
            return base.AddToWorld();
        }
        private ushort spell = 208; //Spell Casted
        private GamePlayer tplayer = null;

		public override bool Interact(GamePlayer player)
		{	
			if(!base.Interact(player)) return false;
            SendReply(player, "Hello,if You are Realm Rank 7 or above i can turn you into something [Special]! If You Are RR10 or above you can turn into something truely [Legendary], finally I can [Return] you to your original form");
			return true;
		}
		public override bool WhisperReceive(GameLiving source, string str)
		{
			if(!base.WhisperReceive(source,str)) return false;
		  	if(!(source is GamePlayer)) return false;
			GamePlayer t = (GamePlayer) source;
			switch(str)
			{
                case "Return":
                    SendReply(t, "Would you like to [Return to Normal]?");
                    break;
				case "Model":
						SendReply(t, "Which model would you like to change into?\n\n[Midgard Male]\n[Hibernia Male]\n[Albion Male]\n[Midgard Female]\n[Hibernia Female]\n[Albion Female]?");
					break;
				case "Shade":
						SendReply(t, "Which Shade model would you like to change into?\n\n[Midgard Male Shade]\n[Hibernia Male Shade]\n[Albion Male Shade]\n[Midgard Female Shade]\n[Hibernia Female Shade]\n[Albion Female Shade]?");
					break;
				case "Special":
						SendReply(t, "Which model would you like to change into?\n[Wolf]\n[Panther]\n[Spider]\n[Bear]\n[Skellie]\n[Lynx].");
					break;
				case "Legendary":
						SendReply(t, "Which model would you like to change into?\n[High Priest]\n [Morgana]\n [Ogre Lord]\n[Savage Dorf]\n[Valkyrie]\n[Lich Queen]");
					break;
				case "Male":
						SendReply(t, "Which realm model would you like to change into?\n\n[Midgard Male]\n[Hibernia Male]\n[Albion Male]?");
					break;
				case "Female":
						SendReply(t, "Which realm model would you like to change into?\n\n[Midgard Female]\n[Hibernia Female]\n[Albion Female]?");
					break;
				case "Midgard Male":
						SendReply(t, "What type of model would you like to be?\n\n[Male Troll]\n[Male Norse]\n[Male Kobold]\n[Male Dwarf]\n[Male Frostalf]\n[Male Valkyn]");
					break;
				case "Midgard Female":
						SendReply(t, "What type of model would you like to be?\n\n[Female Troll]\n[Female Norse]\n[Female Kobold]\n[Female Dwarf]\n[Female Frostalf]\n[Female Valkyn]");
					break;
				case "Hibernia Male":
						SendReply(t, "What type of model would you like to be?\n\n[Male Elf]\n[Male Lurikeen]\n[Male Firbolg]\n[Male Celt]\n[Male Sylvan]\n[Male Shar]");
					break;
				case "Hibernia Female":
						SendReply(t, "What type of model would you like to be?\n\n[Female Elf]\n[Female Lurikeen]\n[Female Firbolg]\n[Female Celt]\n[Female Sylvan]\n[Female Shar]");
					break;
				case "Albion Male":
						SendReply(t, "What type of model would you like to be?\n\n[Male Briton]\n[Male Highlander]\n[Male Avalonian]\n[Male Saracen]\n[Male Inconnu]\n[Male Half-Ogre]");
					break;
				case "Albion Female":
						SendReply(t, "What type of model would you like to be?\n\n[Female Briton]\n[Female Highlander]\n[Female Avalonian]\n[Female Saracen]\n[Female Inconnu]\n[Female Half-Ogre]");
					break;
				case "Midgard Male Shade":
						SendReply(t, "What type of model would you like to be?\n\n[Male Troll Shade]\n[Male Norse Shade]\n[Male Kobold Shade]\n[Male Dwarf Shade]\n[Male Frostalf Shade]\n[Male Valkyn Shade]");
					break;
				case "Midgard Female Shade":
						SendReply(t, "What type of model would you like to be?\n\n[Female Troll Shade]\n[Female Norse Shade]\n[Female Kobold Shade]\n[Female Dwarf Shade]\n[Female Frostalf Shade]\n[Female Valkyn Shade]");
					break;
				case "Hibernia Male Shade":
						SendReply(t, "What type of model would you like to be?\n\n[Male Elf Shade]\n[Male Lurikeen Shade]\n[Male Firbolg Shade]\n[Male Celt Shade]\n[Male Sylvan Shade]\n[Male Shar Shade]");
					break;
				case "Hibernia Female Shade":
						SendReply(t, "What type of model would you like to be?\n\n[Female Elf Shade]\n[Female Lurikeen Shade]\n[Female Firbolg Shade]\n[Female Celt Shade]\n[Female Sylvan Shade]\n[Female Shar Shade]");
					break;
				case "Albion Male Shade":
						SendReply(t, "What type of model would you like to be?\n\n[Male Briton Shade]\n[Male Highlander Shade]\n[Male Avalonian Shade]\n[Male Saracen Shade]\n[Male Inconnu Shade]\n[Male Half-Ogre Shade]");
					break;
				case "Albion Female Shade":
						SendReply(t, "What type of model would you like to be?\n\n[Female Briton Shade]\n[Female Highlander Shade]\n[Female Avalonian Shade]\n[Female Saracen Shade]\n[Female Inconnu Shade]\n[Female Half-Ogre Shade]");
					break;
                case "Return to Normal":
                    if (t.RealmPoints >= 513500)
                    {
                        SendReply(t, "I have now return you to normal!");
                        t.Model = (ushort)t.Client.Account.Characters[t.Client.ActiveCharIndex].CreationModel;
                    }
                    else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
                    break;
				case "Male Troll":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Troll!");
                        ShowAnimation(t);
						t.Model =140;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Norse":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Norseman!");
                        ShowAnimation(t);
						t.Model =155;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Kobold":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Kobold!");
                        ShowAnimation(t);
						t.Model =172;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Dwarf":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Dwarf!");
                        ShowAnimation(t);
						t.Model =190;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Frostalf":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Frostalf!");
                        ShowAnimation(t);
						t.Model =1055;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Valkyn":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Valkyn!");
                        ShowAnimation(t);
						t.Model =775;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Troll":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Troll!");
                        ShowAnimation(t);
						t.Model =148;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Norse":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Norseman!");
                        ShowAnimation(t);
						t.Model =164;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Kobold":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Kobold!");
                        ShowAnimation(t);
						t.Model =180;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Dwarf":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Dwarf!");
                        ShowAnimation(t);
						t.Model =196;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Frostalf":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Frostalf!");
                        ShowAnimation(t);
						t.Model =1067;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Valkyn":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Valkyn!");
                        ShowAnimation(t);
						t.Model =783;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Elf":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Elf!");
                        ShowAnimation(t);
						t.Model =341;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Lurikeen":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Lurikeen!");
                        ShowAnimation(t);
						t.Model =325;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Celt":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Celt!");
                        ShowAnimation(t);
						t.Model =309;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Firbolg":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Firbolg!");
                        ShowAnimation(t);
						t.Model =293;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Sylvan":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Sylvan!");
                        ShowAnimation(t);
						t.Model =707;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Shar":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Shar!");
                        ShowAnimation(t);
						t.Model =1086;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Elf":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Elf!");
                        ShowAnimation(t);
						t.Model =342;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Lurikeen":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Lurikeen!");
                        ShowAnimation(t);
						t.Model =326;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Celt":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Celt!");
                        ShowAnimation(t);
						t.Model =310;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Firbolg":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Firbolg!");
                        ShowAnimation(t);
						t.Model =294;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Sylvan":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Sylvan!");
                        ShowAnimation(t);
						t.Model =708;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Shar":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Shar!");
                        ShowAnimation(t);
						t.Model =1087;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Briton":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Briton!");
                        ShowAnimation(t);
						t.Model =34;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Saracen":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Saracen!");
                        ShowAnimation(t);
						t.Model =51;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Highlander":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Highlander!");
                        ShowAnimation(t);
						t.Model =42;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Inconnu":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Inconnu!");
                        ShowAnimation(t);
						t.Model =723;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Half-Ogre":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Half-Ogre!");
                        ShowAnimation(t);
						t.Model =1019;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Avalonian":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Avalonian!");
                        ShowAnimation(t);
						t.Model =64;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Briton":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Briton!");
                        ShowAnimation(t);
						t.Model =35;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Saracen":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Saracen!");
                        ShowAnimation(t);
						t.Model =52;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Highlander":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Highlander!");
                        ShowAnimation(t);
						t.Model =43;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Inconnu":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Inconnu!");
                        ShowAnimation(t);
						t.Model =724;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Half-Ogre":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Half-Ogre!");
                        ShowAnimation(t);
						t.Model =1020;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Avalonian":
					if (t.RealmPoints >= 513500)
					{
						SendReply(t, "You are now a Avalonian!");
                        ShowAnimation(t);
						t.Model =65;
					}
					else SendReply(t, "You are not Realm Rank 5 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Troll Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Troll!");
                        ShowAnimation(t);
						t.Model =1363;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Norse Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Norseman!");
                        ShowAnimation(t);
						t.Model =1365;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Kobold Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Kobold!");
                        ShowAnimation(t);
						t.Model =1367;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Dwarf Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Dwarf!");
                        ShowAnimation(t);
						t.Model =1369;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Frostalf Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Frostalf!");
                        ShowAnimation(t);
						t.Model =1373;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Valkyn Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Valkyn!");
                        ShowAnimation(t);
						t.Model =1371;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Troll Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Troll!");
                        ShowAnimation(t);
						t.Model =1364;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Norse Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Norseman!");
                        ShowAnimation(t);
						t.Model =1366;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Kobold Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Kobold!");
                        ShowAnimation(t);
						t.Model =1368;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Dwarf Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Dwarf!");
                        ShowAnimation(t);
						t.Model =1370;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Frostalf Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Frostalf!");
                        ShowAnimation(t);
						t.Model =1374;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Valkyn Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Valkyn!");
                        ShowAnimation(t);
						t.Model =1372;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Inconnu Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Inconnu!");
                        ShowAnimation(t);
						t.Model =1351;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Briton Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Briton!");
                        ShowAnimation(t);
						t.Model =1353;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Highlander Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Highlander!");
                        ShowAnimation(t);
						t.Model =1355;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Saracen Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Saracen!");
                        ShowAnimation(t);
						t.Model =1357;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Avalonian Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Avalonian!");
                        ShowAnimation(t);
						t.Model =1359;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Half-Ogre Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Half-Ogre!");
                        ShowAnimation(t);
						t.Model =1361;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Inconnu Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Inconnu!");
                        ShowAnimation(t);
						t.Model =1352;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Briton Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Briton!");
                        ShowAnimation(t);
						t.Model =1354;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Highlander Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Highlander!");
                        ShowAnimation(t);
						t.Model =1356;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Saracen Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Saracen!");
                        ShowAnimation(t);
						t.Model =1358;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Avalonian Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Avalonian!");
                        ShowAnimation(t);
						t.Model =1360;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Half-Ogre Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Half-Ogre!");
                        ShowAnimation(t);
						t.Model =1362;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Celt Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Celt!");
                        ShowAnimation(t);
						t.Model =1377;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Lurikeen Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Lurikeen!");
                        ShowAnimation(t);
						t.Model =1379;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Elf Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Elf!");
                        ShowAnimation(t);
						t.Model =1381;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Firbolg Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Firbolg!");
                        ShowAnimation(t);
						t.Model =1375;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Sylvan Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Sylvan!");
                        ShowAnimation(t);
						t.Model =1383;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Male Shar Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Shar!");
                        ShowAnimation(t);
						t.Model =1385;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Celt Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Celt!");
                        ShowAnimation(t);
						t.Model =1378;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Lurikeen Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Lurikeen!");
                        ShowAnimation(t);
						t.Model =1380;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Elf Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Elf!");
                        ShowAnimation(t);
						t.Model =1382;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Firbolg Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Firbolg!");
                        ShowAnimation(t);
						t.Model =1376;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Sylvan Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Sylvan!");
                        ShowAnimation(t);
						t.Model =1384;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Female Shar Shade":
					if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Shar!");
                        ShowAnimation(t);
						t.Model =1386;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Wolf":
                    if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Wolf!");
                        ShowAnimation(t);
						t.Model =648;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Panther":
                    if (t.RealmPoints >= 1755250)
					{
                        SendReply(t, "You are now a Panther!");
                        ShowAnimation(t);
						t.Model =104;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Spider":
                    if (t.RealmPoints >= 1755250)
					{
                        SendReply(t, "You are now a Spider!");
                        ShowAnimation(t);
						t.Model =132;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Bear":
                    if (t.RealmPoints >= 1755250)
					{
						SendReply(t, "You are now a Bear!");
                        ShowAnimation(t);
						t.Model =96;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Skellie":
                    if (t.RealmPoints >= 1755250)
					{
                        SendReply(t, "You are now a Skellie!");
                        ShowAnimation(t);
						t.Model =2022;
					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "Lynx":
                    if (t.RealmPoints >= 1755250)
					{
                        SendReply(t, "You are now a Lynx!");
                        ShowAnimation(t);
						t.Model =133;

					}
					else SendReply(t, "You are not Realm Rank 7 or above, come back when you have reached this Realm Rank.");
					break;
				case "High Priest":
                    if (t.RealmPoints >= 5974125)
					{
						SendReply(t, "You are now a High Priest!");
                        ShowAnimation(t);
						t.Model =1824;

					}
					else SendReply(t, "You are not Realm Rank 10 or above, come back when you have reached this Realm Rank.");
					break;
				case "Morgana":
                    if (t.RealmPoints >= 5974125)
					{
						SendReply(t, "You are now Morgana!");
                        ShowAnimation(t);
						t.Model =1935;

					}
					else SendReply(t, "You are not Realm Rank 10 or above, come back when you have reached this Realm Rank.");
					break;

				case "Ogre Lord":
                    if (t.RealmPoints >= 5974125)
					{
                        SendReply(t, "You are now an Ogre Lord!");
                        ShowAnimation(t);
						t.Model =1930;

					}
					else SendReply(t, "You are not Realm Rank 10 or above, come back when you have reached this Realm Rank.");
					break;
				case "Savage Dorf":
                    if (t.RealmPoints >= 5974125)
					{
						SendReply(t, "You are now a Savage Dorf!");
                        ShowAnimation(t);
						t.Model =1933;

					}
					else SendReply(t, "You are not Realm Rank 10 or above, come back when you have reached this Realm Rank.");
					break;
				case "Valkyrie":
                    if (t.RealmPoints >= 5974125)
					{
                        SendReply(t, "You are now a Valkyrie!");
                        ShowAnimation(t);
						t.Model =1904;

					}
                    else SendReply(t, "You are not Realm Rank 10 or above, come back when you have reached this Realm Rank.");
                    break;
                case "Lich Queen":
                    if (t.RealmPoints >= 5974125)
                    {
                        SendReply(t, "You are now the Lich Queen!");
                        ShowAnimation(t);
                        t.Model = 1909;

					}
					else SendReply(t, "You are not Realm Rank 10 or above, come back when you have reached this Realm Rank.");
					break;
				default: break;
			}
			return true;
		}
        public void ShowAnimation(GamePlayer target)
        {
            foreach (GamePlayer vplayer in this.GetPlayersInRadius(WorldMgr.VISIBILITY_DISTANCE))
            {
                vplayer.Out.SendSpellCastAnimation(this, spell, 20); //Caster,SpellID,Duration
            }
            tplayer = target;
            RegionTimer timer = new RegionTimer(tplayer, new RegionTimerCallback(ShowEffect), 2000);//GameObject,ElapsedEvent,Duration in MS
        }

        public int ShowEffect(RegionTimer timer)
        {
            
                foreach (GamePlayer vplayer in this.GetPlayersInRadius(WorldMgr.VISIBILITY_DISTANCE))
                {
                    vplayer.Out.SendSpellEffectAnimation(this, tplayer, spell, 0, false, 1);  //vergessen,GameObject,SpellID,vergessen,vergessen,vergessen
                }
                RegionTimer timer2 = new RegionTimer(tplayer, new RegionTimerCallback(Teleport), 2000);

                timer.Stop();
                timer = null;
                return 0;
            }
        
        public int Teleport(RegionTimer timer2)
        {

                tplayer = null;
                timer2.Stop();
                timer2 = null;
                return 0;
            }
        
		private void SendReply(GamePlayer target, string msg)
		{
			target.Out.SendMessage(
				msg,
				eChatType.CT_Say,eChatLoc.CL_PopupWindow);
		}
	}
}