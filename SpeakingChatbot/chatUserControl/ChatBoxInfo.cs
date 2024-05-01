namespace SpeakingChatbot.chatUserControl
{
    public class ChatBoxInfo
    {
    	// public int id { get; set; }
        public string User { get; set; }
        public string NamePlaceholder { get; set; }
        public string StatusPlaceholder { get; set; }
        public string ChatPlaceholder { get; } = "Please enter a message...";
/*        public byte[] Attachment { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentType { get; set; }*/
    }
}
