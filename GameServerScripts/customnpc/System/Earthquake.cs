using System;
using DOL.GS.PacketHandler;
using DOL.GS.Commands;


namespace DOL.GS.Scripts
{
    [CmdAttribute(
   "&gteq",
   new string[] { "&gteq" },
  ePrivLevel.Admin,
   "gteq [radius] [intensity] [duration] [delay]",
   "/gteq")]
    public class EarthQuakeCommandHandler2 : AbstractCommandHandler, ICommandHandler
    {
        public void OnCommand(GameClient client, string[] args)
        {
            if (client == null || client.Player == null || client.ClientState != DOL.GS.GameClient.eClientState.Playing) return;
          
            uint unk1 = 0;
            float radius, intensity, duration, delay = 0;
            radius = 1200.0f;
            intensity = 50.0f;
            duration = 1000.0f;
            int x, y, z = 0;
            if (client.Player.GroundTarget == null)
            {
                x = client.Player.X;
                y = client.Player.Y;
                //            z = client.Player.Z;
            }
            else
            {
                x = client.Player.GroundTarget.X;
                y = client.Player.GroundTarget.Y;
                z = client.Player.GroundTarget.Z;
            }
            if (args.Length > 1)
            {
                try
                {
                    unk1 = (uint)Convert.ToSingle(args[1]);
                }
                catch { }
            }
            if (args.Length > 2)
            {
                try
                {
                    radius = (float)Convert.ToSingle(args[2]);
                }
                catch { }
            }
            if (args.Length > 3)
            {
                try
                {
                    intensity = (float)Convert.ToSingle(args[3]);
                }
                catch { }
            }
            if (args.Length > 4)
            {
                try
                {
                    duration = (float)Convert.ToSingle(args[4]);
                }
                catch { }
            }
            if (args.Length > 5)
            {
                try
                {
                    delay = (float)Convert.ToSingle(args[5]);
                }
                catch { }
            }
            GSTCPPacketOut pak = new GSTCPPacketOut(0x47);
            pak.WriteIntLowEndian(unk1);
            pak.WriteIntLowEndian((uint)x);
            pak.WriteIntLowEndian((uint)y);
            pak.WriteIntLowEndian((uint)z);
            pak.Write(System.BitConverter.GetBytes(radius), 0, sizeof(System.Single));
            pak.Write(System.BitConverter.GetBytes(intensity), 0, sizeof(System.Single));
            pak.Write(System.BitConverter.GetBytes(duration), 0, sizeof(System.Single));
            pak.Write(System.BitConverter.GetBytes(delay), 0, sizeof(System.Single));
            client.Out.SendTCP(pak);
            return;
        }
    }
}
