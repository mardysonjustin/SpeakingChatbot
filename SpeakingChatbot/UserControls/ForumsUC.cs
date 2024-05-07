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
    public partial class ForumsUC : UserControl {

        public event Action BackBtnClick;
        public event Action UploadClick;

        public ForumsUC() {
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e) {
            UploadClick?.Invoke();
        }

        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke();
        }
    }
}
