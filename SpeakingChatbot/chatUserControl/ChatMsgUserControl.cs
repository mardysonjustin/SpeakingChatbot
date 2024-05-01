using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakingChatbot.chatUserControl
{
    public partial class ChatMsgUserControl : UserControl
    {
        public IChatModel ChatModel { get; set; }
        public ChatMsgUserControl()
        {
            InitializeComponent();

            bodyChatTextBox.Text = "No messages were found";
            authorLbl.Text = "System " + DateTime.Now.ToShortTimeString();
        }

        public ChatMsgUserControl(IChatModel chatModel)
        {
            InitializeComponent();


            if (chatModel == null)
            {
                chatModel = new TextChatModel()
                {
                    Inbound = true,
                    Time = DateTime.Now,
                    Author = "System",
                    Body = "No chat messages were found regarding this client.",
                };
            }

            ChatModel = chatModel;

            // receiver
            if (ChatModel.Inbound)
            {
                bodyChatPanel.Dock = DockStyle.Left;
                bodyChatPanel.BackColor = SystemColors.ControlDark;
                bodyChatTextBox.BackColor = SystemColors.Info;
                bodyChatTextBox.ForeColor = Color.Black;
                authorLbl.Dock = DockStyle.Left;
            }
            // sender
            else
            {
                bodyChatPanel.Dock = DockStyle.Right;
                bodyChatTextBox.TextAlign = HorizontalAlignment.Right;
                authorLbl.Dock = DockStyle.Right;
            }

            if (ChatModel.Time > DateTime.Today)
            {
                authorLbl.Text = $"{chatModel.Author ?? "System"}, {chatModel.Time.ToShortTimeString()}";
            }
            else
            {
                authorLbl.Text = $"{chatModel.Author ?? "System"}, {chatModel.Time.ToShortDateString()}";
            }

            switch (chatModel.Type)
            {
                case "text":
                    var textMode = ChatModel as TextChatModel;
                    bodyChatTextBox.Text = textMode.Body.Trim();
                    break;
                case "image":
                    break;
                case "attachment":
                    break;
                default:
                    break;
            }

        }

        public void resizeBubbles(int maxWidth)
        {
            if (ChatModel == null)
            {
                return;
            }

            SuspendLayout();
            switch (ChatModel.Type)
            {
                case "text":
                    var textModel = ChatModel as TextChatModel;

                    /*                    string body = textModel.Body;
                                        TextChange(bodyChatTextBox.Text);*/

                    break;
                case "image":
                    break;
                case "attachment":
                    break;
                default:
                    break;
            }
        }

        private void ChatMsgUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
