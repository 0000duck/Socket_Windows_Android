using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MyChat
{
    public class MyClient
    {
        public List<Socket> ListClient = new List<Socket>();

        public void Add(Socket socket) => ListClient.Add(socket);
        public Socket[] ToArray() => ListClient.ToArray();
        public Socket[] GetListAll() => ListClient.ToArray();

        public static void MessageForMe(RichTextBox richTextBox, string txt)
        {
            richTextBox.Text += txt;
        }
        


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
    }

}
