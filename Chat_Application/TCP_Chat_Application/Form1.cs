using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace TCP_Chat_Application
{
    public partial class frmChatApp : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;

        public frmChatApp()
        {
            InitializeComponent();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            txtLocalIP.Text = GetLocalIP();
            txtRemoteIP.Text = GetLocalIP();
        }

        public string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var iP in host.AddressList)
            {
                if (iP.AddressFamily == AddressFamily.InterNetwork)
                {
                    return iP.ToString();
                }
            }

            //return IPAddress.Loopback.ToString();
            return "127.0.0.1";
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                string txtToBeSent = txtChatName.Text + ">>" + txtMessage.Text;
                msg = enc.GetBytes(txtToBeSent);
                sck.Send(msg);

                //lstMessage.Items.Add("You >> " + txtMessage.Text);
                lstMessage.Items.Add(txtToBeSent);
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void MessageCallBack(IAsyncResult asyncResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(asyncResult, ref epRemote);
                if (size > 0)
                {
                    byte[] recevedData = new byte[1464];
                    recevedData = (byte[])asyncResult.AsyncState;
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    string recievedMessage = encoding.GetString(recevedData);
                    lstMessage.Items.Add(recievedMessage);

                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtChatName.Text))
                {
                    if (!string.IsNullOrEmpty(txtLocalIP.Text) && !string.IsNullOrEmpty(txtRemoteIP.Text))
                    {
                        epLocal = new IPEndPoint(IPAddress.Parse(txtLocalIP.Text), Convert.ToInt32(txtLocalPort.Text));
                        sck.Bind(epLocal);

                        epRemote = new IPEndPoint(IPAddress.Parse(txtRemoteIP.Text), Convert.ToInt32(txtRemotePort.Text));
                        sck.Connect(epRemote);

                        byte[] buffer = new byte[1500];
                        sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                        btnStart.Text = "Connected...";
                        btnStart.Enabled = false;

                        btnSend.Enabled = true;
                        txtMessage.Focus(); 
                    }
                    else
                    {
                        MessageBox.Show("Either local or Remote IP addresses or both are empty.\n Both of these are needed to intiate the connection");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your chat name and then proceed with connection");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void frmChatApp_Load(object sender, EventArgs e)
        {
            txtChatName.Focus();
        }
    }
}
