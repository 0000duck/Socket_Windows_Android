using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
//_______________________________
using System;
using System.Threading;
using Android.Content;
using Android.Runtime;
using Android.Views;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Android_Client
{
	public partial class MainActivity
	{

		private EditText T_Message { get; set; }

		private EditText TxtIP { get { return FindViewById<EditText>(Resource.Id.TXT_IP); } }

		private EditText TxtPort
		{
			get
			{
				return FindViewById<EditText>(Resource.Id.TXT_PORT);
			}
		
		}

		private TextView T_Roomi { get; set; }

		private Button B_Connect { get; set; }

		private Button B_Send { get; set; }

		private Socket SocketClient { get; set; }

		private EndPoint Ipeserver { get; set; }

		private int Port => int.Parse(TxtPort.Text);

		public IPAddress IP => IPAddress.Parse(TxtIP.Text);

		private byte[] buffer = new byte[1024];

		public string ID { get { return "User_Client"; } }

		private void MainRun()
		{
			T_Roomi = FindViewById<TextView>(Resource.Id.TXT_ROOM);
			T_Message = FindViewById<EditText>(Resource.Id.TXT_MESSAGE);
			B_Connect = FindViewById<Button>(Resource.Id.BTN_CONNECT);
			B_Send = FindViewById<Button>(Resource.Id.BTN_SEND);
			//TxtIP = FindViewById<EditText>(Resource.Id.TXT_IP);
			//TxtPort = FindViewById<EditText>(Resource.Id.TXT_PORT);
			B_Connect.Click += B_Connect_Click;
			B_Send.Click += B_Send_Click;

			SetupConnection();
		}

		#region Event

		private void B_Send_Click(object sender, EventArgs e)
		{
			if (T_Message.Text != string.Empty)
			{
				SendPM();
			}
		}

		private void B_Connect_Click(object sender, EventArgs e)
		{
			SetupConnection();
		}

		#endregion

		#region Connecte
		private void SetupConnection()
		{
			try
			{
				SocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				Ipeserver = new IPEndPoint(IP, Port);
				SocketClient.BeginConnect(Ipeserver, new AsyncCallback(ConnectCallback), SocketClient);
			}
			catch (Exception ex)
			{
				ToastUtils.Show(this, ex.Message);
			}

		}

		private void ConnectCallback(IAsyncResult ar)
		{
			Socket socket = (Socket)ar.AsyncState;
			try
			{
				socket.EndConnect(ar);

				T_Roomi.Text +=
					string.Format("{0} {1}", DateTime.Now.ToString("hh,mm,ss"), "Connected Server\n");

				SocketClient.BeginReceive(buffer, 0, buffer.Length,
					SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);

			}
			catch (Exception ex)
			{
				ToastUtils.Show(this, ex.Message);

			}
		}

		#endregion

		#region RecivePm

		private void ReceiveCallback(IAsyncResult ar)
		{
			Socket socket = (Socket)ar.AsyncState;
			try
			{
				int recive = socket.EndReceive(ar);
				string reciveMessage = Encoding.Unicode.GetString(buffer, 0, recive);

				MessageForm(reciveMessage + "\n");

				SocketClient.BeginReceive(buffer, 0, buffer.Length,
					SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
			}
			catch (Exception ex)
			{
				//Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
				ToastUtils.Show(this, ex.Message);

			}
		}

		#endregion

		#region Send

		private void SendPM()
		{
			if (T_Message.Text != null)
			{

				string sendmsg = ID + " : " + T_Message.Text + "\n";

				SendData(SocketClient, sendmsg);

				MessageForm(sendmsg);

			}
		}

		private void SendData(Socket socket, string msg)
		{
			try
			{
				buffer = Encoding.Unicode.GetBytes(msg);

				socket.BeginSend(buffer, 0, buffer.Length,
					SocketFlags.None, new AsyncCallback(SendCallback), socket);
			}
			catch (Exception ex)
			{
				//Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
				ToastUtils.Show(this, ex.Message);

			}
		}
		private void SendCallback(IAsyncResult ar)
		{
			Socket socket = (Socket)ar.AsyncState;

			socket.EndSend(ar);
		}

		#endregion

		#region Other
		private void MessageForm(string messagee)
		{
			try
			{
				T_Roomi.Text += messagee;
			}
			catch (Exception ex)
			{
				ToastUtils.Show(this, ex.Message);
			}
		}


		#endregion

	}
}