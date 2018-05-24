using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//________________________
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Drawing.Text;

namespace Test_Socket
{
    public partial class Frm_Server : Form
    {

        public Frm_Server()
        {
            InitializeComponent();

            toolStripComboBox1.SelectedIndex = 0;
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                lstFonts.DropDown.Items.Add(family.Name);
            }
        }



        //_____________________________________________

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
                socketserver.Bind(new IPEndPoint(IPAddress.Any,int.Parse (Txt_Port.Text)));
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

                    obj.ConvertToIPendPoint(ClientSocket, listBox2);
                });

                buffer = new byte[socketserver.ReceiveBufferSize];

                ReciveData();

                ClientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), ClientSocket);
            }

            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        #endregion

        #region ReciveCode

        private void ReciveData()
        {
            socketserver.BeginAccept(new AsyncCallback(AcceptCallback), ClientSocket);
        }

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

        #region رویداد ها
        private void MessageForm(string msg) => this.Invoke((MethodInvoker)delegate { Txt_Roomi.Text += msg; });

        private void Btn_Start_Click(object sender, EventArgs e)
        {

            string path = @"G:\VisualStudio\Projects\Test_Socket\TestClientSocket\bin\Debug\TestClientSocket.exe";
            Process.Start(path);


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
                    MessageForm(sendmsg);

                    Txt_Roomi.Rtf += Txt_Back.Text;
                }
            }
        }

        #endregion

        private void Btn_SendFile_Click(object sender, EventArgs e)
        {

            Frm_FileServer s = new Frm_FileServer();
            s.Show();
            //ReciveFile();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            var Emoji = new Emoji(Txt_Roomi);

            Emoji.CreateEmotions();

            Emoji.AddEmotions();
        }



        private void customRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Messages_SelectionChanged(object sender, EventArgs e)
        {
            if (Txt_Roomi.SelectionFont != null)
            {
                cmdBold.Checked = Txt_Roomi.SelectionFont.Bold;
                cmdItalic.Checked = Txt_Roomi.SelectionFont.Italic;
                cmdUnderline.Checked = Txt_Roomi.SelectionFont.Underline;
            }
        }

        private void cmdBold_Click(object sender, EventArgs e)
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

        private void cmdItalic_Click(object sender, EventArgs e)
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

        private void cmdUnderline_Click(object sender, EventArgs e)
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

        public float FontSize
        {
            get
            {
                return
                    (float)Convert.ToInt32
                    (toolStripComboBox1.SelectedItem.ToString()
                    ) * 10;
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if (Txt_Message.SelectionFont == null)
            {
                return;
            }
            Txt_Message.SelectionFont = new Font(Txt_Message.SelectionFont.FontFamily,
                FontSize,
                Txt_Message.SelectionFont.Style);
        }




        private void lstFonts_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (Txt_Message.SelectionFont == null)
            {
                Txt_Message.SelectionFont = new Font(e.ClickedItem.Text, Txt_Message.Font.Size);
            }
            Txt_Message.SelectionFont = new Font(e.ClickedItem.Text, Txt_Message.SelectionFont.Size);

        }

        private void CmdColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    Txt_Message.ForeColor = cd.Color;
                }
            }

        }

        private void Txt_Message_TextChanged(object sender, EventArgs e)
        {
            Txt_Back.Text += Txt_Message.Rtf;
        }

        private void lstFonts_Click(object sender, EventArgs e)
        {

        }
    }
    public class MyClient
    {
        public List<Socket> ListClient = new List<Socket>();
        public void Add(Socket socket) => ListClient.Add(socket);
        public Socket[] ToArray() => ListClient.ToArray();
        public void ConvertToIPendPoint(Socket socket, ListBox ls)
        {
            this.Add(socket);

            Socket[] sockets = this.ToArray();


            ls.Items.Clear();

            foreach (var item in sockets)
            {
                IPEndPoint InfoClient = item.RemoteEndPoint as IPEndPoint;

                ls.Items.Add(InfoClient);
            }

        }
        public Socket[] GetListAll() => ListClient.ToArray();
    }
}


