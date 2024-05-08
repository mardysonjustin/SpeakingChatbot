namespace SpeakingChatbot.UserControls.SubUC {
    public partial class ChatItemUC : UserControl {

        public IChatModel ChatModel { get; set; }

        public ChatItemUC() {
            InitializeComponent();
        }

        public ChatItemUC(IChatModel chatModel) {
            InitializeComponent();

            ChatModel = chatModel;

            chatTbl.Controls.Clear();

            // receiver
            if (ChatModel.Inbound) {
                chatTbl.Controls.Add(chatMsg, 1, 0);
                chatMsg.BackColor = SystemColors.AppWorkspace;
                chatMsg.Dock = DockStyle.Left;

                // picture
                // profilePic.Image = Properties.Resources.forumicon;
                chatTbl.Controls.Add(profilePic, 0, 0);
            }
            // sender
            else {
                chatTbl.Controls.Add(chatMsg, 2, 0);
                chatMsg.BackColor = SystemColors.ActiveCaption;
                chatMsg.Dock = DockStyle.Right;

                // picture
                // profilePic.Image = Properties.Resources.forumicon;
                chatTbl.Controls.Add(profilePic, 3, 0);
            }

            switch (chatModel.Type) {
                case "text":
                    var textMode = ChatModel as TextChatModel;
                    chatMsg.Text = textMode.Body.Trim();
                    break;
                case "image":
                    break;
                case "attachment":
                    break;
                default:
                    break;
            }
        }
    }
}
