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

        WelcomeUC welcomeUC = new WelcomeUC();
        LoginSignUpUC loginSignUpUC = new LoginSignUpUC();
        LoginUC loginUC = new LoginUC();
        SignUpUC signUpUC = new SignUpUC();
        MainMenuUC mainMenuUC = new MainMenuUC();
        ChatbotUC chatbotUC = new ChatbotUC();
        ChatUC chatUC = new ChatUC();
        ForumsUC forumUC = new ForumsUC();
        ForumsFormUC forumsFormUC = new ForumsFormUC();


        public Chavatar() {
            InitializeComponent();

            // WelcomeUC();

            welcomeUC.WelcomeClick += LoginSignUpUC;
            loginSignUpUC.WelcomeClick += WelcomeUC;
            loginSignUpUC.LoginClick += LoginUC;
            loginSignUpUC.SignUpClick += SignUpUC;
            loginUC.LoginEnterClick += MainMenuUC;
            signUpUC.SignUpEnterClick += LoginUC;
            mainMenuUC.ChatbotClick += ChatbotUC;
            mainMenuUC.ChatClick += ChatUC;
            mainMenuUC.ForumClick += ForumUC;
            chatbotUC.BackBtnClick += MainMenuUC;
            chatUC.BackBtnClick += MainMenuUC;
            forumUC.UploadClick += ForumsFormUC;
            forumUC.BackBtnClick += MainMenuUC;
            forumsFormUC.BackBtnClick += ForumUC;
        }

        protected void WelcomeUC() {
            MainPanel.Controls.Clear();
            welcomeUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(welcomeUC);
        }

        protected void LoginSignUpUC() {
            MainPanel.Controls.Clear();
            loginSignUpUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(loginSignUpUC);
        }

        protected void LoginUC() {
            MainPanel.Controls.Clear();
            loginUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(loginUC);
        }

        protected void SignUpUC() {
            MainPanel.Controls.Clear();
            signUpUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(signUpUC);
        }

        protected void MainMenuUC() {
            MainPanel.Controls.Clear();
            mainMenuUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(mainMenuUC);
        }

        protected void ChatbotUC() {
            MainPanel.Controls.Clear();
            chatbotUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(chatbotUC);
        }

        protected void ChatUC() {
            MainPanel.Controls.Clear();
            chatUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(chatUC);
        }

        protected void ForumUC() {
            MainPanel.Controls.Clear();
            forumUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(forumUC);
        }

        protected void ForumsFormUC() {
            MainPanel.Controls.Clear();
            forumsFormUC.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(forumsFormUC);
        }
    }
}
