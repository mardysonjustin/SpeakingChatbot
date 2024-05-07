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
    public partial class MainMenuUC : UserControl {
        public event Action ChatbotClick;
        public event Action ChatClick;
        public event Action ForumClick;
        public MainMenuUC() {
            InitializeComponent();
        }

        private void chatbotIcon_Click(object sender, EventArgs e) {
            ChatbotClick?.Invoke();
        }

        private void chatbotBtn_Click(object sender, EventArgs e) {
            ChatbotClick?.Invoke();
        }

        private void chatIcon_Click(object sender, EventArgs e) {
            ChatClick?.Invoke();
        }

        private void chatBtn_Click(object sender, EventArgs e) {
            ChatClick?.Invoke();
        }

        private void forumIcon_Click(object sender, EventArgs e) {
            ForumClick?.Invoke();
        }

        private void forumBtn_Click(object sender, EventArgs e) {
            ForumClick?.Invoke();
        }
    }
}
