﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakingChatbot.UserControls {
    public partial class SignUpUC : UserControl {
        public event Action SignUpEnterClick;
        public SignUpUC() {
            InitializeComponent();
        }


        private void enterBtn_Click_1(object sender, EventArgs e) {
            SignUpEnterClick?.Invoke();
        }
    }
}
