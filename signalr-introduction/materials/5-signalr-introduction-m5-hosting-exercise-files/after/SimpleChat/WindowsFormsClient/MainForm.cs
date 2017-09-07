using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client.Hubs;

namespace WindowsFormsClient
{
    public partial class MainForm : Form
    {
        private IHubProxy chat;

        public MainForm()
        {
            InitializeComponent();
        }

        private void bnConnect_Click(object sender, EventArgs e)
        {
            var hubConnection = new HubConnection("http://localhost/SimpleChat");

            chat = hubConnection.CreateHubProxy("chat");

            chat.On<string>("newMessage",
                            msg => messages.Invoke(new Action(() =>
                                                              messages.Items.Add(msg))));
            // Note: do real async... ;)
            hubConnection.Start().Wait();
        }

        private void bnSend_Click(object sender, EventArgs e)
        {
            chat.Invoke<string>("sendMessage", tbMessage.Text);
        }
    }
}
