using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClient
{
    public partial class Frm_Clients : Form
    {
        public Frm_Clients()
        {
            InitializeComponent();
            cmd_FontSize.SelectedIndex = 0;
        }

        #region متغییرها

        private Socket SocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		private byte[] buffer = new byte[1024];
		private int ReciveMessage { get; set; }
		private string ReciveMessages { get; set; }
        public string ID { get { return Txt_Username.Text; } }

        #endregion


        #region ReciveCode

        

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
                MessageBox.Show(ex.Message);
            }
        }
		#endregion

		#region متدها
		public void Connecte()
		{
			SocketClient.BeginConnect(IPAddress.Parse(Txt_IP.Text), int.Parse(Txt_Port.Text), 
				new AsyncCallback(ConnectCallback), SocketClient);
		}

		private void ConnectCallback(IAsyncResult ar)
        {
            Socket s = (Socket)ar.AsyncState;
            try
            {
                SocketClient.EndConnect(ar);

                this.Invoke((MethodInvoker)delegate
                {
                    Txt_Roomi.Text += string.Format("{0} {1}", DateTime.Now.ToString("hh,mm,ss"), "Connected Server\n");
                });
                SocketClient.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), s);
            }
            catch (Exception ex)
            {
                Txt_Status.Text = (ex.Message);
            }
        }

        private void SendPM()
        {
            if (Txt_Message.Text != null)
            {

                string sendmsg = ID + " : " + Txt_Message.Text + "\n";

                SendData(SocketClient, sendmsg);

                MessageForm(sendmsg);

                Txt_Roomi.Rtf += Txt_Back.Text;

            }


















            //try
            //{
            //    string Sendmsg = string.Format("{0}: {1}", ID, Txt_Message.Text);
            //    byte[] Buffer = new byte[1024];
            //    Buffer = Encoding.Unicode.GetBytes(Sendmsg);

            //    SocketClient.Send(Buffer);

            //    Txt_Roomi.Text += Sendmsg;

            //    // Txt_Messages.ResetText();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        #endregion

        #region راست کلیک
        private void RC_Cut_Click(object sender, EventArgs e)
        {
            Txt_Message.Cut();
        }

        private void RC_Copy_Click(object sender, EventArgs e)
        {
            Txt_Message.Copy();
        }

        private void RC_Paste_Click(object sender, EventArgs e)
        {
            Txt_Message.Paste();
        }

        private void RC_Clear_Click(object sender, EventArgs e)
        {
            Txt_Message.Clear();
        }

        private void RC_SelectAll_Click(object sender, EventArgs e)
        {
            Txt_Message.SelectAll();
        }
		#endregion

		private void SendData(Socket socket, string msg)
        {
            try
            {
                buffer = Encoding.Unicode.GetBytes(msg);

                socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "کاربر آنلاینی وجود ندارد");
            }
        }
        private void SendCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;

            socket.EndSend(ar);
        }
        private void MessageForm(string msg) =>
            this.Invoke((MethodInvoker)delegate { Txt_Roomi.Text += msg; });
   
		#region رویدادها

        private void Btn_Connect_Click(object sender, EventArgs e) => Connecte();

        private void Btn_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (SocketClient != null)
                {
                    SocketClient.Shutdown(SocketShutdown.Both);
                }
                Environment.Exit(Environment.ExitCode);
            }
            catch (Exception ex)
            {
                Txt_Status.Text = (ex.Message);
            }
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            if (Txt_Message.Text != string.Empty)
            {
                SendPM();
            }
        }

        private void CmdBold_Click(object sender, EventArgs e) => SetBold();

        private void CmdItalic_Click(object sender, EventArgs e) => SetItalic();

        private void CmdUnderline_Click(object sender, EventArgs e) => SetUnderLine();

        private void CmdColor_Click(object sender, EventArgs e) => SetColor();

        private void Cmd_FontSize_SelectedIndexChanged(object sender, EventArgs e) => SetFontSize();

		#endregion
		#region نوار آیکون ها

		public float FontSize
        {
            get
            {
                return
                    (float)Convert.ToInt32
                    (cmd_FontSize.SelectedItem.ToString()
                    ) * 10;
            }
        }
        private void SetColor()
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    Txt_Message.ForeColor = cd.Color;
                }
            }

        }
        public void SetBold()
        {
            if (Txt_Message.SelectionFont == null)
            {
                return;
            }

            FontStyle style = Txt_Message.SelectionFont.Style;

            if (Txt_Message.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;

            }
            Txt_Message.SelectionFont = new Font(Txt_Message.SelectionFont, style);

        }
        private void SetItalic()
        {
            if (Txt_Message.SelectionFont == null)
            {
                return;
            }
            FontStyle style = Txt_Message.SelectionFont.Style;

            if (Txt_Message.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            Txt_Message.SelectionFont = new Font(Txt_Message.SelectionFont, style);

        }
        private void SetUnderLine()
        {
            if (Txt_Message.SelectionFont == null)
            {
                return;
            }

            FontStyle style = Txt_Message.SelectionFont.Style;

            if (Txt_Message.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            Txt_Message.SelectionFont = new Font(Txt_Message.SelectionFont, style);

        }
        private void SetFontSize()
        {
            if (Txt_Message.SelectionFont == null)
            {
                return;
            }
            Txt_Message.SelectionFont = new Font(Txt_Message.SelectionFont.FontFamily,
                FontSize, Txt_Message.SelectionFont.Style);
        }

        #endregion
    }
}
