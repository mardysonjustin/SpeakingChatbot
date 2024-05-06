using SpeakingChatbot.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Text;

namespace SpeakingChatbot {
    public partial class Chavatar : Form {
        public Chavatar() {
            InitializeComponent();

            /*            WelcomeUC welcomeUC = new WelcomeUC();
                        welcomeUC.Dock = DockStyle.Fill;
                        MainPanel.Controls.Add(welcomeUC);*/

            /*            LoginSignUpUC loginSignUpUC = new LoginSignUpUC();
                        loginSignUpUC.Dock = DockStyle.Fill;
                        MainPanel.Controls.Add(loginSignUpUC);*/

            /*            LoginUC loginUC = new LoginUC();
                        loginUC.Dock = DockStyle.Fill;
                        MainPanel.Controls.Add(loginUC);*/

/*            SignUpUC signUpUC = new SignUpUC();
            signUpUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(signUpUC);*/

            ChatbotUC chatbotUC = new ChatbotUC();
            chatbotUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(chatbotUC);
        }
    }
}
