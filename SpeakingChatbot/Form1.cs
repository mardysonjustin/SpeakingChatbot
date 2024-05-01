using SpeakingChatbot.Models;
using SpeakingChatbot.socket;
using System.Windows;
using System.Collections.ObjectModel;
using SpeakingChatbot.chatUserControl;
using System.Diagnostics;

namespace SpeakingChatbot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool chatBoxIsOpen = false;


        private void button1_Click(object sender, EventArgs e)
        {

            if (chatBoxIsOpen == false) {

                chatContainer.Visible = true;

                chatUserControl.ChatBoxInfo cbi = new chatUserControl.ChatBoxInfo {
                    User = "BingBong",
                    NamePlaceholder = "testing",
                    StatusPlaceholder = "online",
                };



                var chatPanel = new chatUserControl.ChatUserControl(cbi)
                {
                    Dock = DockStyle.Fill,
                    Name = "testing",
                };

                chatPanel.connectToServer(cbi);

                chatContainer.Controls.Add(chatPanel);
                chatBoxIsOpen = true;
                chatBoxBtn.Text = "Exit";

            } else {
                chatContainer.Visible = false;
                chatBoxIsOpen = false;
                chatBoxBtn.Text = "Chatbox";
            }
        }
    }
}