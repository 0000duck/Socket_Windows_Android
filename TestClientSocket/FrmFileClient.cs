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

namespace TestClientSocket
{
    public partial class FrmFileClient : Form
    {
        public FrmFileClient() => InitializeComponent();

        Socket socketSend;
        public void SetupSocketAndSend(string ip, int port, string path)
        {
            try
            {
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ip), port);
                socketSend.Connect(ipe);
                //------------------------------------
                if (socketSend.Connected)
                {
                    FileStream fs = new FileStream(path, FileMode.Open);
                    byte[] b = new byte[fs.Length];
                    fs.Read(b, 0, b.Length);
                    socketSend.Send(b);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //______________________________


        }


        private void Btn_brows_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog o = new OpenFileDialog())
            {
                if (o.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = o.FileName;
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Send(handler, "teste");

        }

        //public void SendFileU()
        //{
        //    socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
        //    socketSend.Connect(ipe);

        //    socketSend.BeginSendFile(textBox1.Text, new AsyncCallback(SendCallback), socketSend);



        //}

        //private void SendCallback(IAsyncResult ar)
        //{
        //    Socket socket = (Socket)ar.AsyncState;

        //    try
        //    {
        //        //FileStream fs = new FileStream(textBox1.Text, FileMode.Open);

        //       /// byte[] b = new byte[fs.Length];

        //        //fs.Read(b, 0, b.Length);

        //        socket.EndSendFile(ar);
        //        socketSend.BeginSendFile(textBox1.Text, new AsyncCallback(SendCallback), socketSend);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }












        //    //if (socketSend.Connected)
        //    //{
        //    //    FileStream fs = new FileStream(textBox1.Text, FileMode.Open);
        //    //    byte[] b = new byte[fs.Length];
        //    //    fs.Read(b, 0, b.Length);
        //    //    socketSend.Send(b);
        //    //}
        //}

        #region declaracoes

        public byte[] bytes = new Byte[1024];
        public static byte[] byteData = new byte[1024];
        public static Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static Socket handler = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        public static String content = String.Empty;


        #endregion



        private void Form1_Load(object sender, EventArgs e)
        {

            StartListening();
        }

        public static void StartListening()
        {
           // Form1 forme = new Form1();


            /* forme.Invoke(new EventHandler(delegate
            {
              forme.textBox1.AppendText("Início\n");
            }));*/

            //forme.textBox1.AppendText( "inicio /n");
           
            //forme.label1.Text = "Início /n";

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 11000);

            listener.Bind(localEndPoint);
            listener.Listen(3);

            // Set the event to nonsignaled state.
            allDone.Reset();

            // Start an asynchronous socket to listen for connections.
            MessageBox.Show("waiting for connection");

            listener.BeginAccept(new AsyncCallback(AcceptCallback), listener);

            // Wait until a connection is made before continuing.
            allDone.WaitOne();
         //   forme.label1.Text = "conectado /n";
            //MessageBox.Show("Conectado");





        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.
            allDone.Set();

            // Get the socket that handles the client request.
            Socket listener = (Socket)ar.AsyncState;
            handler = listener.EndAccept(ar);

            // Create the state object.
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
        }

        public static void ReadCallback(IAsyncResult ar)
        {

           // Form1 forme = new Form1();
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Read data from the client socket. 
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {

                //state.sb.Append(Encoding.UTF8.GetString(state.buffer,0,bytesRead));
                content = Encoding.UTF8.GetString(state.buffer, 0, bytesRead);
                //content = state.sb.ToString();

                MessageBox.Show(content);

                //forme.label1.Text = content;

                /*if (content.IndexOf("<EOF>") > -1)
                {

                  // All the data has been read from the 
                  // client. Display it on the console.

                  // Echo the data back to the client.
                  Send(handler, content);

                } 
                else 
                {
                  // Not all data received. Get more.
                  handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,new AsyncCallback(ReadCallback), state);
                }*/

            }
        }

        public static void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byteData = Encoding.UTF8.GetBytes(data);

            // Begin sending the data to the remote device.
            handler.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), handler);
        }

        public static void SendCallback(IAsyncResult ar)
        {
           // Form1 forme = new Form1();
            try
            {
                // Retrieve the socket from the state object.
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
                MessageBox.Show(bytesSent.ToString());

                //forme.label1.Text = bytesSent.ToString();


                //handler.Shutdown(SocketShutdown.Both);
                //handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


        }

 


    

    public class StateObject
    {
        // Client socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 1024;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder sb = new StringBuilder();
    }















    }
}
