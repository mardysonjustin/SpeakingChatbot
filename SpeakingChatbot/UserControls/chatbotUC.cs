using SpeakingChatbot.UserControls.SubUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakingChatbot.UserControls {
    public partial class ChatbotUC : UserControl {
        public event Action BackBtnClick;
        public ChatbotUC() {
            InitializeComponent();
            // chatTbl.BackColor = Color.FromArgb(200, Color.Black);
        }

        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke();
        }

        private void addMsg(IChatModel textModel) {
            // add sender name and time // add panel

            var chatItem = new ChatItemUC(textModel) {
                Name = "chatMsg" + chatPanel.Controls.Count,
                Dock = DockStyle.Top,
                Width = chatPanel.Width,
            };

            //chatItem.Dock = DockStyle.Fill;

            chatPanel.Controls.Add(chatItem);
            chatItem.BringToFront();

            chatPanel.ScrollControlIntoView(chatItem);
        }

        private void sendBtn_Click(object sender, EventArgs e) {
            string msg = msgBox.Text;
            msg.Trim();

            TextChatModel textModel = null;

            if (!string.IsNullOrWhiteSpace(msg)) {
                textModel = new TextChatModel() {
                    Inbound = false,
                    Read = true,
                    Time = DateTime.Now,
                    Sender = "currentUser", // galing db to
                    Body = msg
                };
            }

            try {
                // chat 
                if (textModel != null) {
                    addMsg(textModel);
                    msgBox.Text = string.Empty;
                    // connectClient.SendMsgToServer(msg);
                }

            } catch (Exception err) {
                textModel = new TextChatModel() {
                    Inbound = false,
                    Read = true,
                    Time = DateTime.Now,
                    Sender = "currentUser", // galing db to
                    Body = "Failed to send message. See error:\r\n" + err.Message
                };
                addMsg(textModel);
            }
        }
    }
}
