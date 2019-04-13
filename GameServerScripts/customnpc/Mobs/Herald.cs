using System;
using System.Collections;
using DOL.GS.PacketHandler;
using DOL.Database;
using System.Collections.Generic;
namespace DOL.GS.Scripts
{
    public class HeraldNPC : GameNPC
    {

        public HeraldNPC() : base() { }
        public override bool AddToWorld()
        {
            base.AddToWorld();

            Flags |= GameNPC.eFlags.PEACE;

            return true;
        }

        public override bool Interact(GamePlayer player)
        {
            if (!base.Interact(player))
                return false;

            DOLCharacters[] chars = (DOLCharacters[])GameServer.Database.SelectObjects<DOLCharacters>("RealmPoints > 0 ORDER BY RealmPoints DESC LIMIT 25");
            List<string> list = new List<string>();
            list.Add("Top 25 Highest Realm Points:\n\n");
            int count = 1;
            foreach (DOLCharacters chr in chars)
            {
                string str = "Rank #" + count.ToString() + ": " + chr.Name + " with " + chr.RealmPoints.ToString() + " realm points\n";
                count++;
                list.Add(str);
            }

            player.Out.SendCustomTextWindow("Realm Point Herald", list);

            return true;
        }
    }
}