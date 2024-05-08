using SpeakingChatbot.Models;
using SpeakingChatbot.socket;
using SpeakingChatbot.UserControls.SubUC;
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

namespace SpeakingChatbot.UserControls {
    public partial class ChatUC : UserControl {

        public event Action BackBtnClick;

        ObservableCollection<UserModel> Users { get; set; }
        ObservableCollection<string> Msgs { get; set; }

        //private socket.ConnectClient connectClient;

        public ChatUC() {
            InitializeComponent();
            // avatarPanel.BackColor = Color.FromArgb(200, Color.Black);
            // chatPanel.BackColor = Color.FromArgb(200, Color.Black);
        }

        public ChatUC(int id) {
            InitializeComponent();

            // get user by id sa db
            // userNameLbl.Text = chatbox_info.NamePlaceholder;
            // statusLbl.Text = chatbox_info.StatusPlaceholder;
        }


        /*        public void connectToServer(chatUserControl.ChatBoxInfo cbi) {
                            // connect client to server
                            // will move this code to acc login 
                            Users = new ObservableCollection<UserModel>();
                            Msgs = new ObservableCollection<string>();

                            connectClient = new socket.ConnectClient();

                            connectClient.connectedEvent += userConnected;
                            connectClient.msgReceivedEvent += msgReceived;
                            connectClient.userDisconnectEvent += userDisconnected;

                            connectClient.ConnectToServer(cbi.User);
                        }*/
        /*        private void userConnected() {
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
        */
        /*        public void msgReceived() {
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
        */
        /*        private void userDisconnected() {
                    var UID = connectClient.packetReader.ReadMsg();
                    var user = Users.Where(x => x.Id.ToString() == UID).FirstOrDefault();

                    Users.Remove(user);
                }
        */



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
                    Sender = "currentUser", // galing db to
                    Body = msg
                };
            }

            try {
                // img
                if (chatModel != null) {
                    addMsg(chatModel);
                    //cancelAttachment(null, null);
                }

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
