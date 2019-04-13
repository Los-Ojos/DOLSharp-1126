using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace IRC
{
	public class Client
	{
		private static Regex rxFullNick = new Regex(@"^([^!]+)!([^@]*)@(.*)$", RegexOptions.Compiled);
		public static bool IsFullNick(string nick)
		{
			return rxFullNick.IsMatch(nick);
		}

		public void AssignNick(string nick)
		{
			Match tmp = rxFullNick.Match(nick);

			if (tmp.Success)
			{
				Nick = tmp.Groups[1].Value;
				Ident = tmp.Groups[2].Value;
				Host = tmp.Groups[3].Value;
			}
			else
				Nick = nick;
		}

		private string m_Nick;

		public string Nick
		{
			get { return m_Nick; }
			set { m_Nick = value; }
		}

		private string m_RealName;

		public string RealName
		{
			get { return m_RealName; }
			set { m_RealName = value; }
		}

		private string m_Host;

		public string Host
		{
			get { return m_Host; }
			set { m_Host = value; }
		}

		private string m_Ident;

		public string Ident
		{
			get { return m_Ident; }
			set { m_Ident = value; }
		}

		private Dictionary<string, Channel> m_Channels = new Dictionary<string, Channel>();

		public Dictionary<string, Channel> Channels
		{
			get { return m_Channels; }
		}

		public override string ToString()
		{
			return Nick;
		}
	}

	public class Channel
	{
		private string m_Name;

		public string Name
		{
			get { return m_Name; }
			set { m_Name = value; }
		}

		private string m_Topic;

		public string Topic
		{
			get { return m_Topic; }
			set { m_Topic = value; }
		}

		private Dictionary<string, Client> m_Clients = new Dictionary<string, Client>();

		public Dictionary<string, Client> Clients
		{
			get { return m_Clients; }
		}

		private List<string> m_Modes = new List<string>();

		public List<string> Modes
		{
			get { return m_Modes; }
		}

		public void ModeUpdate(string update)
		{
			m_Modes.Clear();
			string premode = "";
			int pos = 1;
			string[] split = update.Split(' ');

			foreach (char c in split[0])
			{
				if (c == '+')
					premode = "+";
				else if (c == '-')
					premode = "-";
				else
				{
					string suf = "";

					if (c == 'k')
					{
						suf = " " + split[pos];
						pos++;
					}
					m_Modes.Add(premode + c + suf);
				}
			}
		}

		public override string ToString()
		{
			return Name;
		}
	}

	public class IRCClient
	{
		public IRCClient()
		{
			//Initialise a standard TCP Socket Stream
			m_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			//Initialise SendQueue
			m_SendQueue = new Queue<string>();

			//Initialise ClientList
			m_Clients = new Dictionary<string, Client>();

			//Chan List
			m_Channels = new Dictionary<string, Channel>();
		}

		public enum eState
		{
			Disconnected,
			Connected,
			Connecting,
			Disconnecting
		}

		private Socket m_Socket = null;
		private Queue<string> m_SendQueue = null;
		private Match regex = null;

		#region Properties
		private eState m_State = eState.Disconnected;

		public eState State
		{
			get { return m_State; }
		}

		private string m_Server = "";
		private int m_Port = 0;

		public string Server
		{
			get { return m_Server; }
		}

		public int Port
		{
			get { return m_Port; }
		}

		private string m_Nick = "";
		private string m_RealName;
		private string m_Ident;

		public string Nick
		{
			get { return m_Nick; }
			set
			{
				//TODO
				m_Nick = value;
			}
		}

		public string RealName
		{
			get
			{
				if (string.IsNullOrEmpty(m_RealName))
					return Nick;

				return m_RealName;
			}
			set { m_RealName = value; }
		}

		public string Ident
		{
			get
			{
				if (string.IsNullOrEmpty(m_Ident))
					return Nick;
				return m_Ident;
			}
			set { m_Ident = value; }
		}

		private int m_SendDelay = 500;
		private int m_ReceiveBuffer = 512;

		public int SendDelay
		{
			get { return m_SendDelay; }
			set { m_SendDelay = value; }
		}

		public int ReceiveBuffer
		{
			get { return m_SendDelay; }
			set { m_SendDelay = value; }
		}

		private bool m_Debug = false;

		public bool Debug
		{
			get { return m_Debug; }
			set { m_Debug = value; }
		}

		private Dictionary<string, Client> m_Clients;

		public Dictionary<string, Client> Clients
		{
			get { return m_Clients; }
		}

		private Dictionary<string, Channel> m_Channels;

		public Dictionary<string, Channel> Channels
		{
			get { return m_Channels; }
		}

		private Client m_ThisClient;

		public Client ThisClient
		{
			get { return m_ThisClient; }
			set { m_ThisClient = value; }
		}
		#endregion

		#region Functions
		public bool Connect()
		{
			if (string.IsNullOrEmpty(m_Server) || m_Port == 0)
				return false;

			return Connect(m_Server, m_Port);
		}
		public bool Connect(string server, int port)
		{
			if (string.IsNullOrEmpty(m_Nick))
				return false;
			if (m_State != eState.Disconnected)
				return false;

			m_Server = server;
			m_Port = port;
			m_State = eState.Connecting;
			m_Socket.BeginConnect(server, port, new AsyncCallback(AsyncConnect), null);

			return true;
		}
		public bool Disconnect()
		{
			return Disconnect("");
		}
		public bool Disconnect(string message)
		{
			if (m_State != eState.Connected)
				return false;

			//Set State
			m_State = eState.Disconnecting;

			//First we will clear our current buffer
			//m_SendQueue.Clear();

			//Set Delay to zero
			int old = m_SendDelay;
			m_SendDelay = 0;

			//Then we will fire our disconnect events
			_OnDisconnect();

			//Now just send our quit message
			Send("QUIT :{0}", message);

			//Then just wait some ms
			while (m_SendQueue.Count > 0)
				Thread.Sleep(50);

			Thread.Sleep(200);

			m_SendDelay = old;

			//Start real disconnect
			m_Socket.BeginDisconnect(true, new AsyncCallback(AsyncDisconnect), null);

			return true;
		}

		public void HandleCommand(string source, string cmd, string paras)
		{
			//First, parse the source
			//We will have to determine if it is the server or a nick who did the action
			//If it was a user, we will have to get the nick
			Client clt = null;

			if (Client.IsFullNick(source))
				clt = GetClient(source);

			//So now, handle the command
			//Check if it is a RAW
			int raw;
			if (int.TryParse(cmd, out raw))
			{
				_OnRaw(raw, paras);
				return;
			}

			string[] split = paras.Split(' ');

			switch (cmd)
			{
				default:
					{
						if (Debug)
							Console.WriteLine("Unknown command: " + cmd);
					}
					break;
				case "JOIN":
					{
						if (OnJoin != null)
							OnJoin(this, clt, GetChannel(paras));

						//<- :[n8]Metty!~unknown@p508D088C.dip0.t-ipconnect.de JOIN #orden-der-seraphim
						if (clt.Nick == Nick)
							SendMode(split[0]);

						if (!clt.Channels.ContainsKey(paras))
							clt.Channels.Add(paras, GetChannel(paras));
						if (!GetChannel(paras).Clients.ContainsKey(clt.Nick))
							GetChannel(paras).Clients.Add(clt.Nick, clt);
					}
					break;
				case "PRIVMSG":
					{
						//:Doitsch!~Ge.Heim@p54904571.dip.t-dialin.net PRIVMSG #Uthgard :.skill
						string chanS = split[0];
						string txt = paras.Split(new char[] { ':' }, 2)[1];

						object target;

						if (chanS != Nick)
							target = GetChannel(chanS);
						else
							target = clt;

						if (txt.StartsWith(C().ToString()) && txt.EndsWith(C().ToString()))
						{
							if (txt.Trim(C()).ToLower() == "version")
								SendCTCP(clt,
										 "VERSION " + B() + "C# IRC Framework by Metty" + B()
										 + " (ver: 2.0; 23.07.2006)");

							if (OnCTCP != null)
								OnCTCP(this, clt, target, txt.Trim(C()));
						}
						else
						{
							if (OnMessage != null)
								OnMessage(this, clt, target, txt);
						}
					}
					break;
				case "NOTICE":
					{
						//:Doitsch!~Ge.Heim@p54904571.dip.t-dialin.net NOTICE #Uthgard :.skill
						string chanS = split[0];
						string txt = paras.Split(new char[] { ':' }, 2)[1];

						object target;

						if (chanS != Nick)
							target = GetChannel(chanS);
						else
							target = clt;

						if (OnNotice != null)
							OnNotice(this, clt, target, txt);
					}
					break;
				case "PART":
					{
						if (OnPart != null)
							OnPart(this, clt, GetChannel(paras));

						if (clt.Channels.ContainsKey(paras))
							clt.Channels.Remove(paras);
						if (GetChannel(paras).Clients.ContainsKey(clt.Nick))
							GetChannel(paras).Clients.Remove(clt.Nick);
					}
					break;
				case "NICK":
					{
						string old = clt.Nick;
						string nick = paras.Split(new char[] { ':' }, 2)[1];

						Clients.Remove(clt.Nick);
						clt.Nick = nick;
						Clients.Add(nick, clt);

						foreach (Channel chan in Channels.Values)
						{
							if (chan.Clients.ContainsKey(old))
							{
								chan.Clients.Remove(old);
								chan.Clients.Add(nick, clt);
							}
						}

						if (OnNick != null)
							OnNick(this, clt, old, nick);
					}
					break;
				case "QUIT":
					{
						string msg = paras.Split(new char[] { ':' }, 2)[1];

						if (OnQuit != null)
							OnQuit(this, clt, msg);

						foreach (Channel chan in Channels.Values)
						{
							if (chan.Clients.ContainsKey(clt.Nick))
								chan.Clients.Remove(clt.Nick);
						}
						Clients.Remove(clt.Nick);
					}
					break;
				case "MODE":
					{
						string[] ms = paras.Split(new char[] { ' ' }, 2);
						object loc;

						if (ms[0] == Nick)
							loc = ThisClient;
						else
							loc = GetChannel(ms[0]);

						string premode = "";
						int pos = 1;
						string[] s = ms[1].Split(' ');

						if (OnMode != null)
						{
							foreach (char c in s[0])
							{
								if (c == '+')
									premode = "+";
								else if (c == '-')
									premode = "-";
								else
								{
									string suf = "";

									if (c == 'k')
									{
										suf = " " + s[pos];
										pos++;
									}

									OnMode(this, clt, loc, (premode + c + suf));
								}
							}
						}
					}
					break;
			}
		}
		#endregion

		#region AsyncMethods
		private void AsyncConnect(IAsyncResult res)
		{
			try
			{
				m_Socket.EndConnect(res);
			}
			catch (SocketException e)
			{
				_OnConnectFailed(e);
				return;
			}

			//Now the socket is connected, now start our send/write "loops"
			m_State = eState.Connected;
			_OnSocketOpen();
			m_Socket.BeginSend(new byte[0], 0, 0, SocketFlags.None, new AsyncCallback(AsyncSend), null);
			m_Socket.BeginReceive(new byte[0], 0, 0, SocketFlags.None, new AsyncCallback(AsyncReceive), null);
		}
		private void AsyncDisconnect(IAsyncResult res)
		{
			try
			{
				m_Socket.EndDisconnect(res);
			}
			catch (Exception) { }

			//Now we are disconnected
			m_State = eState.Disconnected;
			Channels.Clear();
			Clients.Clear();
		}
		private void AsyncSend(IAsyncResult res)
		{
			if (State == eState.Disconnected)
				return;

			try
			{
				m_Socket.EndSend(res);
			}
			catch (SocketException e)
			{
				_OnSocketError(e);
				return;
			}

			//Waittime here...
			Thread.Sleep(m_SendDelay);

			//Create a new buffer
			byte[] buffer;

			if (m_SendQueue.Count == 0)
				buffer = new byte[0];
			else
				buffer = Encoding.ASCII.GetBytes(m_SendQueue.Dequeue());

			if (buffer.Length > 0)
				_OnSend(buffer);

			//Send it
			try
			{
				m_Socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(AsyncSend), null);
			}
			catch (SocketException e)
			{
				_OnSocketError(e);
				return;
			}
		}
		private void AsyncReceive(IAsyncResult res)
		{
			if (State == eState.Disconnected || State == eState.Disconnecting)
				return;

			try
			{
				m_Socket.EndReceive(res);
			}
			catch (SocketException e)
			{
				_OnSocketError(e);
				return;
			}

			byte[] buffer = new byte[m_ReceiveBuffer];
			int pos = 0;

			if (res.AsyncState != null)
			{
				byte[] old = (byte[])res.AsyncState;
				string text = Encoding.ASCII.GetString(old);
				text = text.Trim('\0');
				text = text.Replace("\r", "");

				_OnReceive(old);

				//Check for a line break;
				if (text.Contains("\n")) //Yep there is a line break; so we have a "full" command
				{
					string[] split = text.Split('\n');
					for (int a = 0; a < split.Length - 1; a++) //last 'line' does not count; as it isn't completed
					{
						string cmd = split[a];
						_OnCommand(cmd);
					}
					byte[] newBuff = Encoding.ASCII.GetBytes(split[split.Length - 1]);
					newBuff.CopyTo(buffer, 0);
					pos += newBuff.Length;
				}
			}

			//Receive
			try
			{
				m_Socket.BeginReceive(buffer, pos, buffer.Length - pos, SocketFlags.None,
									  new AsyncCallback(AsyncReceive), buffer);
			}
			catch (SocketException e)
			{
				_OnSocketError(e);
				return;
			}
		}
		#endregion

		#region RegExes
		private static Regex rxCMDlow = new Regex(@"^([^:]+) :(.*)$", RegexOptions.Compiled);
		private static Regex rxCMDnorm = new Regex(@"^:([^ ]+) ([^ ]+) (.*)$", RegexOptions.Compiled);
		#endregion

		#region Events
		public delegate void Handler(IRCClient sender);

		public delegate void ErrorHandler(IRCClient sender, Exception e);

		public delegate void BufferHandler(IRCClient sender, byte[] buffer);

		public delegate void StringHandler(IRCClient sender, string text);

		public delegate void RawHandler(IRCClient sender, int raw, string paras);

		public event ErrorHandler OnConnectFailed;
		public event ErrorHandler OnSocketError;
		public event BufferHandler OnSend;
		public event BufferHandler OnReceive;
		public event StringHandler OnCommand;
		public event Handler OnSocketOpen;
		public event StringHandler OnPing;
		public event RawHandler OnRaw;
		public event Handler OnConnect;
		public event Handler OnDisconnect;

		public delegate void JoinHandler(IRCClient sender, Client clt, Channel chan);

		public event JoinHandler OnJoin;
		public event JoinHandler OnPart;

		public delegate void MessageHandler(IRCClient sender, Client source, object target, string message);

		public event MessageHandler OnMessage;
		public event MessageHandler OnNotice;
		public event MessageHandler OnCTCP;

		public delegate void NickHandler(IRCClient sender, Client client, string oldnick, string newnick);

		public event NickHandler OnNick;

		public delegate void QuitHandler(IRCClient sender, Client client, string msg);

		public event QuitHandler OnQuit;

		public delegate void ModeHandler(IRCClient sender, Client source, object target, string mode);

		public event ModeHandler OnMode;



		private void _OnConnectFailed(Exception e)
		{
			if (Debug)
				Console.WriteLine("con fail: " + e);

			if (OnConnectFailed != null)
				OnConnectFailed(this, e);
		}
		private void _OnSocketError(Exception e)
		{
			if (Debug)
				Console.WriteLine("soc err: " + e);

			if (State != eState.Disconnected && State != eState.Disconnecting)
				AsyncDisconnect(null);

			if (OnSocketError != null)
				OnSocketError(this, e);
		}
		private void _OnSend(byte[] buffer)
		{
			if (Debug)
				Console.WriteLine("send: " + Encoding.ASCII.GetString(buffer).Trim('\0', '\r', '\n'));

			if (OnSend != null)
				OnSend(this, buffer);
		}
		private void _OnReceive(byte[] buffer)
		{
			if (OnReceive != null)
				OnReceive(this, buffer);
		}
		private void _OnCommand(string cmd)
		{
			if (Debug)
				Console.WriteLine("cmd: " + cmd);

			//Our CMD Handling will start here
			//As there are two command types (low level and standard), we will have to check which it is

			#region LowLevel
			if ((regex = rxCMDlow.Match(cmd)).Success)
			{
				//Yep we have a low level command
				string type = regex.Groups[1].Value;
				string para = regex.Groups[2].Value;

				//Low level commands are "hardcoded"
				switch (type)
				{
					default:
						{
							if (Debug)
								Console.WriteLine("Unknown Command: " + type);
						}
						break;
					case "NOTICE AUTH":
						{
							//nothing important...dont do anything
						}
						break;
					case "PING":
						{
							_OnPing(para);
						}
						break;
				}
			}
			#endregion

			#region Normal
			if ((regex = rxCMDnorm.Match(cmd)).Success)
			{
				string source = regex.Groups[1].Value;
				string type = regex.Groups[2].Value;
				string paras = regex.Groups[3].Value;
				HandleCommand(source, type, paras);
			}
			#endregion

			if (OnCommand != null)
				OnCommand(this, cmd);
		}
		private void _OnSocketOpen()
		{
			if (Debug)
				Console.WriteLine("sock open");

			SendUserInfo();

			if (OnSocketOpen != null)
				OnSocketOpen(this);
		}
		private void _OnPing(string id)
		{
			SendPingReply(id);

			if (OnPing != null)
				OnPing(this, id);
		}
		private void _OnRaw(int id, string paras)
		{
			string[] split = paras.Split(' ');
			switch (id)
			{
				case 1:
					//We are connected
					_OnConnect();
					break;
				case 324:
					{
						//Chan mode update
						//[n8]Metty #Uthgard +tnCN
						Channel c = GetChannel(split[1]);
						c.ModeUpdate(split[2]);
					}
					break;
				case 332:
					{
						//Topic update
						//[n8]Metty #uthgard.staff :xyz
						Channel c = GetChannel(split[1]);
						c.Topic = split[2].Remove(0, 1);
					}
					break;
				case 353:
					{
						//User List
						/*
						 <- :port80c.se.quakenet.org 353 [n8]Metty = #Uthgard :[n8]Metty Joyzer|Zakk MettysBot SUI`[Uth]ypsl [Sera]Arwen cucola +[Uth]Solidus quagliox [OoL]Darth [RW]Malle [OoL]Jibiel Aestiva [VR]Gorm [Epona]Aira [TC]Alandrian Industrial [MB]Johnnie |Gaucar| DanGer_ GoldenArrow [SW]Cherub [LD]Shaden @Metty @TheSchaf rotze [MB]Anionda Salpi^Cassim Adminoror BilboOo|AFK [rev43R] LordXar Souli2k @GuildBot @UthBot [AW]Cadrach|AFK Migga Friskey Toxocara +[zZz]Yako @bartmaN Cambot Celeborn sMiFfY |-souLi-|
						 <- :port80c.se.quakenet.org 353 [n8]Metty = #Uthgard :Dealer^off Indiana ServOff|Dealer [eXi`oFF] +Baldrug [SW]A`Cerian @Q Sn4k3
						 * */
						string param = paras.Split(new char[] { ':' }, 2)[1];
						Channel c = GetChannel(split[2]);

						foreach (string n in param.Split(' '))
						{
							Client clt = GetClient(n);
							if (!c.Clients.ContainsKey(clt.Nick))
								c.Clients.Add(clt.Nick, clt);
							if (!clt.Channels.ContainsKey(c.Name))
								clt.Channels.Add(c.Name, c);
						}
					}
					break;
			}

			if (OnRaw != null)
				OnRaw(this, id, paras);
		}
		private void _OnConnect()
		{
			ThisClient = GetClient(Nick);

			if (OnConnect != null)
				OnConnect(this);
		}
		private void _OnDisconnect()
		{
			if (OnDisconnect != null)
				OnDisconnect(this);
		}
		#endregion

		#region Send
		public void Send(string txt, params object[] format)
		{
			Send(string.Format(txt, format));
		}
		public void Send(string text)
		{
			m_SendQueue.Enqueue(text + "\r\n");
		}
		public void SendUserInfo()
		{
			Send("NICK " + Nick);
			Send("USER " + Ident + " \"" + RealName /*Email*/+ "\" \"" + Server + "\" :" + RealName);
		}
		public void SendPingReply(string id)
		{
			Send("PONG :{0}", id);
		}
		public void SendJoin(object chan)
		{
			Send("JOIN {0}", chan.ToString());
		}
		public void SendPart(object chan)
		{
			SendPart(chan, "");
		}
		public void SendPart(object chan, string msg)
		{
			Send("PART {0} :{1}", chan.ToString(), msg);
		}
		public void SendMode(object chan)
		{
			Channel c = GetChannel(chan.ToString());

			foreach (Client clt in c.Clients.Values)
				clt.Channels.Remove(c.Name);

			c.Clients.Clear();

			Send("MODE {0}", chan);
		}
		public void SendMode(object target, string mode)
		{
			Send("MODE {0} {1}", target, mode);
		}
		public void SendMessage(object target, string msg, params object[] format)
		{
			SendMessage(target, string.Format(msg, format));
		}
		public void SendMessage(object target, string message)
		{
			Send("PRIVMSG {0} :{1}", target.ToString(), message);
		}
		public void SendNotice(object target, string msg)
		{
			Send("NOTICE {0} :{1}", target, msg);
		}
		public void SendNotice(object target, string msg, params object[] format)
		{
			SendNotice(target, string.Format(msg, format));
		}
		public void SendCTCP(object target, string msg)
		{
			SendMessage(target, C() + msg + C());
		}
		public void SendCTCP(object target, string msg, params object[] format)
		{
			SendCTCP(target, string.Format(msg, format));
		}
		public void SendTopic(Channel chan, string topic)
		{
			Send("TOPIC {0} :{1}", chan, topic);
		}
		public void SendKick(Channel chan, Client client)
		{
			SendKick(chan, client, "");
		}
		public void SendKick(Channel chan, Client client, string msg)
		{
			Send("KICK {0} {1} :{2}", chan, client, msg);
		}
		#endregion

		#region Helpers
		public Client GetClient(string nick)
		{
			string n = nick;

			//first determine what sort of nick it is
			if (Client.IsFullNick(nick))
			{
				//not the clean way :P
				Client c = new Client();
				c.AssignNick(nick);
				n = c.Nick;
			}

			if (Clients.ContainsKey(n))
				return Clients[n];
			else
			{
				Client c = new Client();
				c.AssignNick(nick);
				Clients.Add(n, c);
				return c;
			}
		}
		public Channel GetChannel(string chan)
		{
			if (m_Channels.ContainsKey(chan))
				return m_Channels[chan];
			else
			{
				Channel c = new Channel();
				c.Name = chan;
				m_Channels.Add(chan, c);
				return c;
			}
		}
		public static char B()
		{
			return (char)2;
		}
		public static string B(string txt)
		{
			return string.Format("{0}{1}{0}", B(), txt);
		}
		public static char U()
		{
			return (char)31;
		}
		public static string U(string txt)
		{
			return string.Format("{0}{1}{0}", U(), txt);
		}
		public static char R()
		{
			return (char)22;
		}
		public static string R(string txt)
		{
			return string.Format("{0}{1}{0}", R(), txt);
		}
		public static char K()
		{
			return (char)3;
		}
		public static string K(int v, int b, string txt)
		{
			return string.Format("{0}{1},{2}{3}{0}", K(), v, b, txt);
		}
		public static string K(int v, string txt)
		{
			return string.Format("{0}{1}{2}{0}", K(), v, txt);
		}
		public static char C()
		{
			return (char)1;
		}
		#endregion

		public static void Main(string[] args)
		{
			IRCClient c = new IRCClient();
			c.Debug = true;
			c.Nick = "MettysBot";
			c.RealName = "RealName";
			c.Ident = "Ident";
			c.Connect("irc.quakenet.org", 6666);

			c.OnConnect += new Handler(_Con);
			c.OnJoin += new JoinHandler(_Join);
			c.OnMessage += new MessageHandler((_Msg));
			c.OnPart += new JoinHandler((_Part));
			c.OnMode += new ModeHandler((_Mode));

			while (true)
				Thread.Sleep(100);
		}
		public static void _Con(IRCClient sender)
		{
			sender.SendJoin("#uthgard");
		}
		public static void _Join(IRCClient sender, Client clt, Channel chan)
		{
			if (clt.Nick == sender.Nick)
				sender.SendMessage(chan, "Hey! I just joined " + chan);
			else
				sender.SendMessage(chan, "Hey " + clt + "! Welcome in " + chan + " :)");
		}
		public static void _Part(IRCClient sender, Client clt, Channel chan)
		{
			if (clt.Nick != sender.Nick)
				sender.SendMessage(chan, "Bye, bye {0}", clt);
		}
		public static void _Mode(IRCClient sender, Client clt, object loc, string mode)
		{
			sender.SendMessage(loc, B(clt + " set mode: " + mode));
		}
		public static void _Msg(IRCClient sender, Client clt, object target, string msg)
		{
			if (msg.ToLower().StartsWith(sender.Nick.ToLower() + " "))
			{
				string m = msg.Remove(0, sender.Nick.Length + 1).ToLower();
				string[] split = m.Split(new char[] { ' ' }, 2);
				switch (split[0])
				{
					case "quit":
						if (clt.Nick != "Metty")
						{
							sender.SendKick(target as Channel, clt, "Fuck off!");
							return;
						}

						sender.SendMessage(target, "Yes, SIR!");
						sender.Disconnect("Executing order 666 from " + clt);
						break;
					case "join":
						if (split.Length < 2)
							return;
						sender.SendMessage(target, "I'll do so!");
						sender.SendJoin(split[1]);
						break;
					case "part":
						if (split.Length < 2)
							return;
						sender.SendMessage(target, ":/ .... okay " + clt);
						sender.SendMessage(split[1], ":(...goodbye!");
						sender.SendPart(split[1]);
						break;
					default:
						sender.SendMessage(target, "Mhmhmh " + clt + "?");
						break;
				}
			}
			else if (msg.ToLower() == sender.Nick.ToLower())
				sender.SendMessage(target, "Yep " + clt + "?");
		}
	}
}