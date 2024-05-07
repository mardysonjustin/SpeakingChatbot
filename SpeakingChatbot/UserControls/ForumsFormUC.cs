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
    public partial class ForumsFormUC : UserControl {

        public event Action BackBtnClick;
        public ForumsFormUC() {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke();
        }

        private void submitBtn_Click(object sender, EventArgs e) {
            BackBtnClick?.Invoke();

            // add data sa db
        }

        private void addFileBtn_Click(object sender, EventArgs e) {
            // add file
        }
    }
}
