using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Socket
{
    public partial class Frm_FileServer : Form
    {
        public Frm_FileServer() => InitializeComponent();


        //___________________________________________________
        public string FilePath { get; set; }
        bool end;
        public void ReciveFile()
        {
            try
            {
                Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 8888);
                server.Bind(ipe);
                server.Listen(1);
                Socket Getfile = server.Accept();

                byte[] b = new byte[1024 * 10];

                while (true)
                {
                    int r = Getfile.Receive(b);

                    if (r > 0)
                    {
                        this.Invoke(new Action(() =>
                        {
                            using (SaveFileDialog s = new SaveFileDialog())
                            {
                                if (s.ShowDialog() == DialogResult.OK)
                                {
                                    FilePath = s.FileName;
                                    FileStream fs = new FileStream(s.FileName, FileMode.Create);
                                    fs.Write(b, 0, r);
                                    fs.Flush();
                                    fs.Close();
                                    end = true; if (end)
                                    {
                                        tr.Abort();
                                        if (tr.ThreadState != a)
                                        {
                                            button1.Text = tr.ThreadState.ToString();
                                        }
                                    }
                                }
                            }

                        }));
                        Thread.CurrentThread.Abort();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        Thread tr; ThreadState a;
        private void button1_Click(object sender, EventArgs e)
        {
            //  a = Thread.CurrentThread.ThreadState;
            //  button1.Text = a.ToString();

            //  tr = new Thread(ReciveFile); tr.Start();

            ReciveFileMe();
        }

        private void ReciveFileMe()
        {
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 8888);
            server.Bind(ipe);
            server.Listen(0);
            server.BeginAccept(new AsyncCallback(AcceptCallback), server);
            button1.Enabled = false;
        }

        private void AcceptCallback(IAsyncResult ar)
        {

            try
            {
                Socket socket = (Socket)ar.AsyncState;

                byte[] b = new byte[1024 * 10];

                socket.BeginReceive(b, 0, b.Length, SocketFlags.None, new AsyncCallback(RecivefileCallback), socket);

                socket.EndAccept(ar);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RecivefileCallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            try
            {
                byte[] b = new byte[11024 * 10];

                int r = socket.EndReceive(ar);
                if (r > 0)
                {
                    this.Invoke(new Action(() =>
                    {
                        using (SaveFileDialog s = new SaveFileDialog())
                        {
                            if (s.ShowDialog() == DialogResult.OK)
                            {
                                FilePath = s.FileName;
                                FileStream fs = new FileStream(s.FileName, FileMode.Create);
                                fs.Write(b, 0, r);
                                fs.Flush();
                                fs.Close();
                                end = true; if (end)
                                {
                                    tr.Abort();
                                    if (tr.ThreadState != a)
                                    {
                                        button1.Text = tr.ThreadState.ToString();
                                    }
                                }
                            }
                        }

                    }));
                    Thread.CurrentThread.Abort();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
