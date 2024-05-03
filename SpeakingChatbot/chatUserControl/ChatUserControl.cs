using SpeakingChatbot.Bot;
using SpeakingChatbot.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace SpeakingChatbot.chatUserControl {
    public partial class ChatUserControl : UserControl {

        public ChatBoxInfo chatbox_info;

        public string Msg { get; set; }

        // will move it somewhere once na may ui na
        ObservableCollection<UserModel> Users { get; set; }
        ObservableCollection<string> Msgs { get; set; }

        private socket.ConnectClient connectClient;

        private TextChatModel textModel;

        public void connectToServer(chatUserControl.ChatBoxInfo cbi) {
            // connect client to server
            // will move this code to acc login 
            Users = new ObservableCollection<UserModel>();
            Msgs = new ObservableCollection<string>();

            connectClient = new socket.ConnectClient();

            connectClient.connectedEvent += userConnected;
            connectClient.msgReceivedEvent += msgReceived;
            connectClient.userDisconnectEvent += userDisconnected;

            connectClient.ConnectToServer(cbi.User);
        }

        private void userConnected() {
            var user = new Models.UserModel {
                UserName = connectClient.packetReader.ReadMsg(),
                Id = connectClient.packetReader.ReadMsg()
            };

            Users.Add(user);


            // display user sa gc for now debug muna, wait for the ui
            if (!Users.Any(x => x.Id == user.Id)) {
            }
            Debug.WriteLine(user.UserName);
            Debug.WriteLine(user.Id);
        }

        public void msgReceived() {
            var senderId = connectClient.packetReader.ReadMsg();
            var msg = connectClient.packetReader.ReadMsg();
            Msgs.Add(msg);

            Debug.WriteLine(senderId);
            Debug.WriteLine(msg);


            TextChatModel textModel = null;
            if (!string.IsNullOrWhiteSpace(msg)) {
                textModel = new TextChatModel() {
                    Inbound = true,
                    Read = true,
                    Time = DateTime.Now,
                    Author = chatbox_info.User,
                    // for now change it later to just msg
                    Body = senderId + ": " + msg
                };
            }

            // chat 
            if (textModel != null) {
                var chatMsg = new ChatMsgUserControl(textModel) {
                    Name = "chatMsg" + chatBoxPanel.Controls.Count,
                    Dock = DockStyle.Top
                };

                chatBoxPanel.Invoke((MethodInvoker)(() => {
                    chatBoxPanel.Controls.Add(chatMsg);
                    chatBoxPanel.ScrollControlIntoView(chatMsg);
                }));

                chatMsg.Invoke((MethodInvoker)(() => chatMsg.BringToFront()));
            }

        }

        private void userDisconnected() {
            var UID = connectClient.packetReader.ReadMsg();
            var user = Users.Where(x => x.Id.ToString() == UID).FirstOrDefault();

            Users.Remove(user);
        }


        public ChatUserControl(ChatBoxInfo _chatbox_info) {
            InitializeComponent();

            chatbox_info = _chatbox_info;
            userNameLbl.Text = chatbox_info.NamePlaceholder;
            statusLbl.Text = chatbox_info.StatusPlaceholder;
            msgBox.PlaceholderText = chatbox_info.ChatPlaceholder;

            addMessage(null);
        }


        public void addMessage(IChatModel textModel) {
            var chatMsg = new ChatMsgUserControl(textModel) {
                Name = "chatMsg" + chatBoxPanel.Controls.Count,
                Dock = DockStyle.Top
            };

            chatBoxPanel.Controls.Add(chatMsg);
            chatMsg.BringToFront();

            chatBoxPanel.ScrollControlIntoView(chatMsg);
        }

        public void addUser(IChatModel textModel) {

        }


        private string checkMsgInput(string msg) {
            string[] calledWaifu;
            string msgToBot = "";

            if (msg.Contains("@waifu")) {
                // wake waifu
                Debug.WriteLine("waifu in");
                calledWaifu = new string[2];
                calledWaifu = msg.Split(" ", 2, System.StringSplitOptions.RemoveEmptyEntries);

                try {
                    // "@waifu"
                    Debug.WriteLine(calledWaifu[0]);
                    // question
                    Debug.WriteLine(calledWaifu[1]);

                    msgToBot = calledWaifu[1];
                } catch (Exception ex) {
                    // call waifu lang no msg
                    Debug.WriteLine("No question");

                    string[] wakeWaifu = { "hi", "hello", "hey", "you there? ", "gemini" };
                    Random random = new Random();
                    int randomIndex = random.Next(0, wakeWaifu.Length);
                    Debug.WriteLine(wakeWaifu[randomIndex]);

                    msgToBot = wakeWaifu[randomIndex];
                }

                return msgToBot;
            }
            return msg;
        }

        // add text to db
        private async void sendBtn_Click(object sender, EventArgs e) {
            string toUser = userNameLbl.Text;
            string msg = msgBox.Text;
            msg.Trim();

            IChatModel chatModel = null;
            TextChatModel textModel = null;

            if (!string.IsNullOrWhiteSpace(msg)) {
                textModel = new TextChatModel() {
                    Inbound = false,
                    Read = true,
                    Time = DateTime.Now,
                    Author = chatbox_info.User,
                    Body = msg
                };
            }

            try {
                // img
                if (chatModel != null) {
                    addMessage(chatModel);
                    //cancelAttachment(null, null);
                }

                // chat 
                if (textModel != null) {
                    addMessage(textModel);
                    msgBox.Text = string.Empty;
                    connectClient.SendMsgToServer(msg);
                }

            } catch (Exception err) {
                textModel = new TextChatModel() {
                    Inbound = false,
                    Read = true,
                    Time = DateTime.Now,
                    Author = chatbox_info.User,
                    Body = "Failed to send message. See error:\r\n" + err.Message
                };
                addMessage(textModel);
            }

            /*            // if yung msg is nagcocontain ng @waifu
                        msgToBot = checkMsgInput(msg);
                        if (msgToBot != null) {
                            msgFromBot = await GeminiAPI.SendRequestAndGetResponse(msgToBot);
                        }

                        Debug.WriteLine("Message from Gemini", msgFromBot);*/
        }

        private void attachBtn_Click(object sender, EventArgs e) {

        }
    }
}
