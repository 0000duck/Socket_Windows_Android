using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChat
{
    public partial class Frm_Server : Form
    {
        public Frm_Server()
        {
            InitializeComponent();
            cmd_FontSize.SelectedIndex = 0;
        }

        #region متغییر ها

        private Socket socketserver;
        private byte[] buffer = new byte[1024];
        private List<Socket> listclient = new List<Socket>();
        private MyClient obj = new MyClient();

        public string Timerdate { get => DateTime.Now.ToLongTimeString(); }
        public bool ConnectionFlaq { get; private set; }
        public Socket ClientSocket { get; private set; }


        #endregion

        #region متدها

        #region AcceptCode

        private void SetupServer()
        {
            try
            {
                socketserver = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                socketserver.Bind(new IPEndPoint(IPAddress.Any, int.Parse(Txt_Port.Text)));

                socketserver.Listen(0);

                socketserver.BeginAccept(new AsyncCallback(AcceptCallback), null);

                MessageForm("Start Listen...\n");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AcceptCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            try
            {
                ClientSocket = socketserver.EndAccept(ar);

                this.Invoke((MethodInvoker)delegate
                {
                    MessageForm("ConnectedClient.\n");

                    obj.ConvertToIPendPoint(ClientSocket, LBox_Member);
                });

                buffer = new byte[socketserver.ReceiveBufferSize];

                ReciveData();

                ClientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), ClientSocket);
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        #endregion

        #region ReciveCode

        private void ReciveData() => socketserver.BeginAccept(new AsyncCallback(AcceptCallback), ClientSocket);

        private void ReceiveCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;

            try
            {
                int recive = socket.EndReceive(ar);

                string reciveMessage = Encoding.Unicode.GetString(buffer, 0, recive);

                MessageForm(reciveMessage + "\n");

                ClientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), ClientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region SendCode

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

        #endregion


        #endregion

        #region متفرقه
        private void MessageForm(string msg) => this.Invoke((MethodInvoker)delegate { Txt_Roomi.Text += msg; });
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
        private void ChengeFont()
        {
            if (Txt_Message.SelectionFont == null)
            {
                return;
            }
            Txt_Message.SelectionFont = new Font(Txt_Message.SelectionFont.FontFamily,
                FontSize, Txt_Message.SelectionFont.Style);
        }

        #endregion

        #region رویدادها

        private void Btn_Start_Click(object sender, EventArgs e)
        {
           // string path = @"G:\VisualStudio\Projects\Test_Socket\MyClient\bin\Debug\MyClient.exe";
            // Process.Start(path);



            if (Btn_Start.Text == "Start")
            {
                Btn_Start.Text = Btn_Start.Text = "Stop";
                ConnectionFlaq = true;
            }
            else
            {
                ConnectionFlaq = false;
            }


            if (ConnectionFlaq)
            {
                SetupServer();
            }
            else
            {
                Environment.Exit(Environment.ExitCode);
            }
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            if (Txt_Message.Text != null)
            {
                Socket[] sockets = obj.GetListAll();

                foreach (var item in sockets)
                {

                    string sendmsg = "Server : " + Txt_Message.Text + "\n";

                    SendData(item, sendmsg);
                    this.Invoke((MethodInvoker)delegate
                    {
                        MyClient.MessageForMe(Txt_Roomi, Txt_Message.Text);
                    });
                    MessageForm(sendmsg);

                    Txt_Roomi.Rtf += Txt_Back.Text;
                }
            }
        }

        private void CmdBold_Click(object sender, EventArgs e) => SetBold();

        private void CmdItalic_Click(object sender, EventArgs e) => SetItalic();

        private void CmdUnderline_Click(object sender, EventArgs e) => SetUnderLine();

        private void CmdColor_Click(object sender, EventArgs e) => SetColor();

        private void Cmd_FontSize_SelectedIndexChanged(object sender, EventArgs e) => ChengeFont();



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

    }
}