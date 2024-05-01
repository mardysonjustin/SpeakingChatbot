namespace SpeakingChatbot.chatUserControl
{
    partial class ChatUserControl
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
            infoPanel = new Panel();
            statusLbl = new Label();
            userNameLbl = new Label();
            chatBoxPanel = new Panel();
            btmPanel = new Panel();
            attachBtn = new Button();
            msgBox = new TextBox();
            sendBtn = new Button();
            infoPanel.SuspendLayout();
            btmPanel.SuspendLayout();
            SuspendLayout();
            // 
            // infoPanel
            // 
            infoPanel.BackColor = SystemColors.ActiveCaption;
            infoPanel.Controls.Add(statusLbl);
            infoPanel.Controls.Add(userNameLbl);
            infoPanel.Dock = DockStyle.Top;
            infoPanel.Location = new Point(0, 0);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(785, 59);
            infoPanel.TabIndex = 0;
            // 
            // statusLbl
            // 
            statusLbl.AutoSize = true;
            statusLbl.Location = new Point(5, 30);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(47, 20);
            statusLbl.TabIndex = 1;
            statusLbl.Text = "status";
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Location = new Point(4, 5);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(76, 20);
            userNameLbl.TabIndex = 0;
            userNameLbl.Text = "userName";
            // 
            // chatBoxPanel
            // 
            chatBoxPanel.AutoScroll = true;
            chatBoxPanel.BackColor = SystemColors.ButtonShadow;
            chatBoxPanel.Location = new Point(0, 59);
            chatBoxPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chatBoxPanel.Name = "chatBoxPanel";
            chatBoxPanel.Size = new Size(785, 270);
            chatBoxPanel.TabIndex = 2;
            // 
            // btmPanel
            // 
            btmPanel.BackColor = SystemColors.ControlDarkDark;
            btmPanel.Controls.Add(attachBtn);
            btmPanel.Controls.Add(msgBox);
            btmPanel.Controls.Add(sendBtn);
            btmPanel.Dock = DockStyle.Bottom;
            btmPanel.Location = new Point(0, 329);
            btmPanel.Name = "btmPanel";
            btmPanel.Padding = new Padding(5, 3, 5, 3);
            btmPanel.Size = new Size(785, 46);
            btmPanel.TabIndex = 4;
            // 
            // attachBtn
            // 
            attachBtn.Dock = DockStyle.Right;
            attachBtn.Location = new Point(660, 3);
            attachBtn.Margin = new Padding(5, 3, 5, 3);
            attachBtn.Name = "attachBtn";
            attachBtn.Padding = new Padding(4, 1, 4, 1);
            attachBtn.Size = new Size(26, 40);
            attachBtn.TabIndex = 4;
            attachBtn.Text = "+";
            attachBtn.UseVisualStyleBackColor = true;
            attachBtn.Click += attachBtn_Click;
            // 
            // msgBox
            // 
            msgBox.Dock = DockStyle.Fill;
            msgBox.Location = new Point(5, 3);
            msgBox.Multiline = true;
            msgBox.Name = "msgBox";
            msgBox.Size = new Size(681, 40);
            msgBox.TabIndex = 2;
            // 
            // sendBtn
            // 
            sendBtn.Dock = DockStyle.Right;
            sendBtn.Location = new Point(686, 3);
            sendBtn.Margin = new Padding(5, 3, 5, 3);
            sendBtn.Name = "sendBtn";
            sendBtn.Padding = new Padding(4, 1, 4, 1);
            sendBtn.Size = new Size(94, 40);
            sendBtn.TabIndex = 3;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // ChatUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btmPanel);
            Controls.Add(chatBoxPanel);
            Controls.Add(infoPanel);
            Name = "ChatUserControl";
            Size = new Size(785, 375);
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            btmPanel.ResumeLayout(false);
            btmPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel infoPanel;
        private Panel chatBoxPanel;
        private TextBox msgBox;
        private Button sendBtn;
        private Label statusLbl;
        private Label userNameLbl;
        private Panel btmPanel;
        private Button attachBtn;
    }
}
