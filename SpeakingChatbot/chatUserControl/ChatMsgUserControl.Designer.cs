namespace SpeakingChatbot.chatUserControl
{
    partial class ChatMsgUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            authorPanel = new Panel();
            authorLbl = new Label();
            bodyChatPanel = new Panel();
            bodyChatTextBox = new TextBox();
            authorPanel.SuspendLayout();
            bodyChatPanel.SuspendLayout();
            SuspendLayout();
            // 
            // authorPanel
            // 
            authorPanel.BackColor = SystemColors.ActiveCaption;
            authorPanel.Controls.Add(authorLbl);
            authorPanel.Dock = DockStyle.Top;
            authorPanel.Location = new Point(3, 4);
            authorPanel.Name = "authorPanel";
            authorPanel.Size = new Size(765, 27);
            authorPanel.TabIndex = 0;
            // 
            // authorLbl
            // 
            authorLbl.AutoSize = true;
            authorLbl.Location = new Point(3, 3);
            authorLbl.Name = "authorLbl";
            authorLbl.Size = new Size(50, 20);
            authorLbl.TabIndex = 0;
            authorLbl.Text = "label1";
            // 
            // bodyChatPanel
            // 
            bodyChatPanel.BackColor = SystemColors.HotTrack;
            bodyChatPanel.Controls.Add(bodyChatTextBox);
            bodyChatPanel.Dock = DockStyle.Right;
            bodyChatPanel.Location = new Point(367, 31);
            bodyChatPanel.Name = "bodyChatPanel";
            bodyChatPanel.Padding = new Padding(8, 5, 8, 5);
            bodyChatPanel.Size = new Size(401, 73);
            bodyChatPanel.TabIndex = 9;
            // 
            // bodyChatTextBox
            // 
            bodyChatTextBox.BackColor = SystemColors.ControlText;
            bodyChatTextBox.BorderStyle = BorderStyle.None;
            bodyChatTextBox.Dock = DockStyle.Fill;
            bodyChatTextBox.ForeColor = Color.White;
            bodyChatTextBox.Location = new Point(8, 5);
            bodyChatTextBox.Margin = new Padding(4, 3, 4, 3);
            bodyChatTextBox.Multiline = true;
            bodyChatTextBox.Name = "bodyChatTextBox";
            bodyChatTextBox.ReadOnly = true;
            bodyChatTextBox.Size = new Size(385, 63);
            bodyChatTextBox.TabIndex = 4;
            bodyChatTextBox.Text = "Hello there. This is a test for the longer word usage.";
            // 
            // ChatMsgUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bodyChatPanel);
            Controls.Add(authorPanel);
            Name = "ChatMsgUserControl";
            Padding = new Padding(3, 4, 3, 4);
            Size = new Size(771, 108);
            Load += ChatMsgUserControl_Load;
            authorPanel.ResumeLayout(false);
            authorPanel.PerformLayout();
            bodyChatPanel.ResumeLayout(false);
            bodyChatPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel authorPanel;
        private Label authorLbl;
        private Panel bodyChatPanel;
        private TextBox bodyChatTextBox;
    }
}
