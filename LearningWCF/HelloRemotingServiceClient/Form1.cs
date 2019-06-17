using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace HelloRemotingServiceClient
{
    public partial class Form1 : Form
    {
        IHelloRemotingService.IHelloRemotingService client;

        public Form1()
        {
            InitializeComponent();
            RegisterClient();
        }

        private void RegisterClient()
        {
            TcpChannel channel = new TcpChannel();
#pragma warning disable CS0618 // Type or member is obsolete
            ChannelServices.RegisterChannel(channel);
#pragma warning restore CS0618 // Type or member is obsolete
            client = (IHelloRemotingService.IHelloRemotingService)Activator.GetObject(typeof(IHelloRemotingService.IHelloRemotingService), "tcp://localhost:45012/GetMessage");
            System.Diagnostics.Debug.Assert(client != null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = client.GetGreetingMessage(textBox1.Text);
        }
    }
}
