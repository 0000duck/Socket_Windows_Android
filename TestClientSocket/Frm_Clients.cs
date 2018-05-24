using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;


namespace TestClientSocket
{
    public partial class Frm_Clients : Form
    {
        private Socket SocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        byte[] buffer = new byte[1024];
        public string ID { get { return Txt_Username.Text; } }
        int ReciveMessage { get; set; }

        string ReciveMessages { get; set; }

        public Frm_Clients()
        {
            InitializeComponent();
        }


        public void Connecte()
        {
            SocketClient.BeginConnect(IPAddress.Parse(Txt_IP.Text), int.Parse(Txt_Port.Text), new AsyncCallback(ConnectCallback), SocketClient);
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            Socket s = (Socket)ar.AsyncState;
            try
            {
                SocketClient.EndConnect(ar);

                this.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.Text += string.Format("{0} {1}", DateTime.Now.ToString("hh,mm,ss"), "Connected Server\n");
                });
                SocketClient.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReciveCallBack), s);
            }
            catch (Exception ex)
            {
                Txt_Status.Text = (ex.Message);
            }
        }
        private void ReceiveCallback(IAsyncResult ar)
        {
            Socket s = (Socket)ar.AsyncState;

            try
            {
                SocketClient.EndReceive(ar);

                //ReciveMessage = Encoding.Unicode.GetString(buffer);
                ReciveMessage = SocketClient.Receive(buffer);

                if (ReciveMessage > 0)
                {
                    ReciveMessages = Encoding.Unicode.GetString(buffer, 0, ReciveMessage);

                    this.Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.Text += string.Format("{0}\n", ReciveMessages);
                    });

                }
                s.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), s);


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void ReciveCallBack(IAsyncResult ar)
        {
            Socket s = (Socket)ar.AsyncState;
            try
            {
                SocketClient.EndReceive(ar);

                ReciveMessage = SocketClient.Receive(buffer);

                if (ReciveMessage > 0)
                {
                    ReciveMessages = Encoding.Unicode.GetString(buffer, 0, ReciveMessage);

                    this.Invoke((MethodInvoker)delegate
                    {
                        richTextBox1.Text += string.Format("{0}", ReciveMessages);
                    });
                }
                SocketClient.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReciveCallBack), s);
            }

            catch (Exception ex)
            {
                Txt_Status.Text = (ex.Message);

            }
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            Connecte();
        }

        private void Btn_DisConnect_Click(object sender, EventArgs e)
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
            if (Txt_Messagesssss.Text != string.Empty)
            {
                SendPM();
            }
        }




        #region RightClick
        private void RC_Cut_Click(object sender, EventArgs e)
        {
            Txt_Messagesssss.Cut();
        }

        private void RC_Copy_Click(object sender, EventArgs e)
        {
            Txt_Messagesssss.Copy();
        }

        private void RC_Paste_Click(object sender, EventArgs e)
        {
            Txt_Messagesssss.Paste();
        }

        private void RC_Clear_Click(object sender, EventArgs e)
        {
            Txt_Messagesssss.Clear();
        }

        private void RC_SelectAll_Click(object sender, EventArgs e)
        {
            Txt_Messagesssss.SelectAll();
        }
        #endregion







        private void SendPM()
        {


            string Sendmsg = string.Format("{0}: {1}", Txt_Username.Text, Txt_Messagesssss.Text);
            byte[] Buffer = new byte[1024];
            Buffer = Encoding.Unicode.GetBytes(Sendmsg);

            SocketClient.Send(Buffer);

            richTextBox1.Text += Sendmsg;

            // Txt_Messages.ResetText();
        }

        private void Btn_SendFile_Click(object sender, EventArgs e)
        {
            FrmFileClient s = new FrmFileClient();
            s.Show();

        }
    }

}

