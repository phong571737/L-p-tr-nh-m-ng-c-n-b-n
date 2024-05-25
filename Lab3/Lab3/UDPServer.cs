using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class UDPServer : Form
    {
        public UDPServer()
        {
            InitializeComponent();
        }

        public void serverThread()
        {
            /*int portNumber;
            if (!int.TryParse(port.Text, out portNumber))
            {
                MessageBox.Show("Please enter a valid port number.");
                return;
            }
*/
            UdpClient udpClient = new UdpClient(8080);//portNumber);
            while (true) 
            {
                IPEndPoint ipendpoint = new IPEndPoint(IPAddress.Any, 0);// listen from any ip used port enterd by user
                Byte[] receiveBytes = udpClient.Receive(ref ipendpoint); 
                string DataBindings = Encoding.ASCII.GetString(receiveBytes); 
                string mess = ipendpoint.Address.ToString() + ": " + DataBindings.ToString();
                informessage(mess);
            }
        }

        private void informessage(string mess)
        {
            receivedmessages.Invoke(new MethodInvoker(delegate()
            {
                receivedmessages.Items.Add(mess);   
            }
            ));   
        }

        private void listen_Click(object sender, EventArgs e)
        {
            
        }

        private void UDPServer_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(serverThread));
            thread.Start(); // establish connection
        }
    }
}
