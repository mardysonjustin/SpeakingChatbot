using System;
using System.Windows.Forms;

namespace SpeakingChatbot
{
    public partial class Form1 : Form
    {
        private string userInput;

        public event EventHandler<string> UserInputEntered;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userInput = textBoxInput.Text;
            OnUserInputEntered(userInput);
        }

        private void OnUserInputEntered(string input)
        {
            if (UserInputEntered != null)
            {
                UserInputEntered(this, input);
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

