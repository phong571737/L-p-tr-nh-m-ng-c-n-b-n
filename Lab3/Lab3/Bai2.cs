using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai2 : Form
    {

        public Bai2()
        {
            InitializeComponent();
        }

        private bool Listening = false;
        private Socket listenerSocket;
        private string receivedData = "";

        private void listen_Click(object sender, EventArgs e)
        {
            if(!Listening)
            {
                Listening = true;

                CheckForIllegalCrossThreadCalls = false;
                Thread serverThread = new Thread(new ThreadStart(StartListening));
                serverThread.Start();
            }
            else
            {
                listenerSocket.Close();
                btlisten.Text = "Listen";
            }
            
        }
        private void StartListening()
        {
            int bytesReceived = 0;

            // khởi tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1];

            // tạo socket bên gửi
            Socket clientSocket;

            // tạo socket bên nhận
            listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());
            IPEndPoint ipepServer = new IPEndPoint(IPHost.AddressList[0], 8080);

            listenerSocket.Bind(ipepServer);
            // bắt đầu lắng nghe. Socket.Listen(int backlog)
            // với backlog: là độ dài tối đa của hàng đợi các kết nối đang chờ xử lý
            listenerSocket.Listen(-1);
            //Đồng ý kết nối
            clientSocket = listenerSocket.Accept();
            //Nhận dữ liệu
            listView1.Items.Add(new ListViewItem("New Client Connected"));
            while (clientSocket.Connected)
            {
                bytesReceived = clientSocket.Receive(recv);
                receivedData += Encoding.ASCII.GetString(recv, 0, bytesReceived);

                if(receivedData.EndsWith("\r\n"))
                {
                    if(Listening)
                    {
                        listView1.Items.Add(receivedData);
                    }
                    receivedData = "";
                }
            }
            listenerSocket.Close();
        }
    }
}
