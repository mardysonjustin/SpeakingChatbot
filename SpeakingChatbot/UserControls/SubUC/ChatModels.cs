using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakingChatbot.UserControls.SubUC {
    public interface IChatModel {
        bool Inbound { get; set; }
        bool Read { get; set; }
        DateTime Time { get; set; }
        string Sender { get; set; }
        string Type { get; }
    }
    public class TextChatModel : IChatModel {
        public bool Inbound { get; set; }
        public bool Read { get; set; }
        public DateTime Time { get; set; }
        public string Sender { get; set; }
        public string Type { get; } = "text";
        public string Body { get; set; }
    }
}
