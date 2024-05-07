namespace SpeakingChatbot.UserControls {
    partial class ChatUC {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            chatTbl = new TableLayoutPanel();
            leftChatTbl = new TableLayoutPanel();
            avatarTbl = new TableLayoutPanel();
            avatarPanel = new Panel();
            onlineTblPanel = new TableLayoutPanel();
            botBtn = new PictureBox();
            usersBtn = new PictureBox();
            chatLblTbl = new TableLayoutPanel();
            chatLbl = new PictureBox();
            chatRightTbl = new TableLayoutPanel();
            chatBoxTbl = new TableLayoutPanel();
            chatBoxBottomTbl = new TableLayoutPanel();
            sendBtn = new Button();
            chatTextBox = new TextBox();
            usernameLbl = new Label();
            backTbl = new TableLayoutPanel();
            backBtn = new PictureBox();
            chatTbl.SuspendLayout();
            leftChatTbl.SuspendLayout();
            avatarTbl.SuspendLayout();
            onlineTblPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)botBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBtn).BeginInit();
            chatLblTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatLbl).BeginInit();
            chatRightTbl.SuspendLayout();
            chatBoxTbl.SuspendLayout();
            chatBoxBottomTbl.SuspendLayout();
            backTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // chatTbl
            // 
            chatTbl.BackColor = Color.Transparent;
            chatTbl.ColumnCount = 2;
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            chatTbl.Controls.Add(leftChatTbl, 0, 0);
            chatTbl.Controls.Add(chatRightTbl, 1, 0);
            chatTbl.Dock = DockStyle.Fill;
            chatTbl.Location = new Point(0, 0);
            chatTbl.Name = "chatTbl";
            chatTbl.RowCount = 1;
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            chatTbl.Size = new Size(833, 464);
            chatTbl.TabIndex = 0;
            // 
            // leftChatTbl
            // 
            leftChatTbl.ColumnCount = 1;
            leftChatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftChatTbl.Controls.Add(avatarTbl, 0, 3);
            leftChatTbl.Controls.Add(chatLblTbl, 0, 1);
            leftChatTbl.Dock = DockStyle.Fill;
            leftChatTbl.Location = new Point(3, 3);
            leftChatTbl.Name = "leftChatTbl";
            leftChatTbl.RowCount = 5;
            leftChatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            leftChatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            leftChatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            leftChatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            leftChatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            leftChatTbl.Size = new Size(327, 458);
            leftChatTbl.TabIndex = 0;
            // 
            // avatarTbl
            // 
            avatarTbl.ColumnCount = 3;
            avatarTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            avatarTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            avatarTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            avatarTbl.Controls.Add(avatarPanel, 1, 1);
            avatarTbl.Controls.Add(onlineTblPanel, 1, 0);
            avatarTbl.Dock = DockStyle.Fill;
            avatarTbl.Location = new Point(0, 67);
            avatarTbl.Margin = new Padding(0);
            avatarTbl.Name = "avatarTbl";
            avatarTbl.RowCount = 2;
            avatarTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            avatarTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            avatarTbl.Size = new Size(327, 366);
            avatarTbl.TabIndex = 1;
            // 
            // avatarPanel
            // 
            avatarPanel.AutoSize = true;
            avatarPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            avatarPanel.BackColor = Color.FromArgb(200, 0, 0, 0);
            avatarPanel.Dock = DockStyle.Fill;
            avatarPanel.Location = new Point(32, 36);
            avatarPanel.Margin = new Padding(0);
            avatarPanel.Name = "avatarPanel";
            avatarPanel.Size = new Size(261, 330);
            avatarPanel.TabIndex = 1;
            // 
            // onlineTblPanel
            // 
            onlineTblPanel.ColumnCount = 5;
            onlineTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            onlineTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            onlineTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6F));
            onlineTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            onlineTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            onlineTblPanel.Controls.Add(botBtn, 1, 1);
            onlineTblPanel.Controls.Add(usersBtn, 3, 1);
            onlineTblPanel.Location = new Point(32, 0);
            onlineTblPanel.Margin = new Padding(0);
            onlineTblPanel.Name = "onlineTblPanel";
            onlineTblPanel.RowCount = 2;
            onlineTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            onlineTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 98F));
            onlineTblPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            onlineTblPanel.Size = new Size(250, 36);
            onlineTblPanel.TabIndex = 2;
            // 
            // botBtn
            // 
            botBtn.Dock = DockStyle.Fill;
            botBtn.Image = Properties.Resources.dahlia;
            botBtn.Location = new Point(15, 3);
            botBtn.Name = "botBtn";
            botBtn.Size = new Size(99, 30);
            botBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            botBtn.TabIndex = 0;
            botBtn.TabStop = false;
            // 
            // usersBtn
            // 
            usersBtn.Dock = DockStyle.Fill;
            usersBtn.Image = Properties.Resources.currently_online_label;
            usersBtn.Location = new Point(135, 3);
            usersBtn.Name = "usersBtn";
            usersBtn.Size = new Size(99, 30);
            usersBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            usersBtn.TabIndex = 1;
            usersBtn.TabStop = false;
            // 
            // chatLblTbl
            // 
            chatLblTbl.ColumnCount = 3;
            chatLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            chatLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            chatLblTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            chatLblTbl.Controls.Add(chatLbl, 1, 1);
            chatLblTbl.Dock = DockStyle.Fill;
            chatLblTbl.Location = new Point(3, 12);
            chatLblTbl.Name = "chatLblTbl";
            chatLblTbl.RowCount = 3;
            chatLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            chatLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            chatLblTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            chatLblTbl.Size = new Size(321, 48);
            chatLblTbl.TabIndex = 2;
            // 
            // chatLbl
            // 
            chatLbl.Dock = DockStyle.Fill;
            chatLbl.Image = Properties.Resources.chats_label;
            chatLbl.Location = new Point(67, 7);
            chatLbl.Name = "chatLbl";
            chatLbl.Size = new Size(186, 32);
            chatLbl.SizeMode = PictureBoxSizeMode.StretchImage;
            chatLbl.TabIndex = 0;
            chatLbl.TabStop = false;
            // 
            // chatRightTbl
            // 
            chatRightTbl.ColumnCount = 2;
            chatRightTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));
            chatRightTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            chatRightTbl.Controls.Add(chatBoxTbl, 0, 2);
            chatRightTbl.Controls.Add(backTbl, 0, 1);
            chatRightTbl.Dock = DockStyle.Fill;
            chatRightTbl.Location = new Point(336, 3);
            chatRightTbl.Name = "chatRightTbl";
            chatRightTbl.RowCount = 4;
            chatRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 2F));
            chatRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            chatRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            chatRightTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            chatRightTbl.Size = new Size(494, 458);
            chatRightTbl.TabIndex = 1;
            // 
            // chatBoxTbl
            // 
            chatBoxTbl.BackColor = Color.FromArgb(200, 0, 0, 0);
            chatBoxTbl.ColumnCount = 1;
            chatBoxTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            chatBoxTbl.Controls.Add(chatBoxBottomTbl, 0, 2);
            chatBoxTbl.Controls.Add(usernameLbl, 0, 0);
            chatBoxTbl.Dock = DockStyle.Fill;
            chatBoxTbl.Location = new Point(0, 68);
            chatBoxTbl.Margin = new Padding(0);
            chatBoxTbl.Name = "chatBoxTbl";
            chatBoxTbl.RowCount = 3;
            chatBoxTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            chatBoxTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 77F));
            chatBoxTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            chatBoxTbl.Size = new Size(469, 366);
            chatBoxTbl.TabIndex = 0;
            // 
            // chatBoxBottomTbl
            // 
            chatBoxBottomTbl.BackColor = Color.Transparent;
            chatBoxBottomTbl.ColumnCount = 2;
            chatBoxBottomTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77F));
            chatBoxBottomTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            chatBoxBottomTbl.Controls.Add(sendBtn, 1, 0);
            chatBoxBottomTbl.Controls.Add(chatTextBox, 0, 0);
            chatBoxBottomTbl.Dock = DockStyle.Fill;
            chatBoxBottomTbl.Location = new Point(0, 328);
            chatBoxBottomTbl.Margin = new Padding(0);
            chatBoxBottomTbl.Name = "chatBoxBottomTbl";
            chatBoxBottomTbl.RowCount = 1;
            chatBoxBottomTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chatBoxBottomTbl.Size = new Size(469, 38);
            chatBoxBottomTbl.TabIndex = 0;
            // 
            // sendBtn
            // 
            sendBtn.AutoSize = true;
            sendBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sendBtn.Dock = DockStyle.Fill;
            sendBtn.FlatStyle = FlatStyle.Flat;
            sendBtn.ForeColor = Color.White;
            sendBtn.Location = new Point(364, 3);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(102, 32);
            sendBtn.TabIndex = 0;
            sendBtn.Text = "Send";
            sendBtn.UseVisualStyleBackColor = true;
            // 
            // chatTextBox
            // 
            chatTextBox.Dock = DockStyle.Fill;
            chatTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            chatTextBox.Location = new Point(5, 5);
            chatTextBox.Margin = new Padding(5);
            chatTextBox.Name = "chatTextBox";
            chatTextBox.Size = new Size(351, 31);
            chatTextBox.TabIndex = 1;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.BackColor = Color.Transparent;
            usernameLbl.Dock = DockStyle.Left;
            usernameLbl.Font = new Font("SimSun-ExtB", 18F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLbl.ForeColor = Color.White;
            usernameLbl.Location = new Point(10, 0);
            usernameLbl.Margin = new Padding(10, 0, 3, 0);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(133, 47);
            usernameLbl.TabIndex = 1;
            usernameLbl.Text = "USERNAME";
            usernameLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // backTbl
            // 
            backTbl.ColumnCount = 2;
            backTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            backTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            backTbl.Controls.Add(backBtn, 1, 0);
            backTbl.Dock = DockStyle.Fill;
            backTbl.Location = new Point(3, 12);
            backTbl.Name = "backTbl";
            backTbl.RowCount = 1;
            backTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            backTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            backTbl.Size = new Size(463, 53);
            backTbl.TabIndex = 1;
            // 
            // backBtn
            // 
            backBtn.Dock = DockStyle.Fill;
            backBtn.Image = Properties.Resources.backbutton;
            backBtn.Location = new Point(324, 0);
            backBtn.Margin = new Padding(0);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(139, 53);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 0;
            backBtn.TabStop = false;
            backBtn.Click += backBtn_Click;
            // 
            // ChatUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.chat;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(chatTbl);
            DoubleBuffered = true;
            Margin = new Padding(0);
            Name = "ChatUC";
            Size = new Size(833, 464);
            chatTbl.ResumeLayout(false);
            leftChatTbl.ResumeLayout(false);
            avatarTbl.ResumeLayout(false);
            avatarTbl.PerformLayout();
            onlineTblPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)botBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBtn).EndInit();
            chatLblTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chatLbl).EndInit();
            chatRightTbl.ResumeLayout(false);
            chatBoxTbl.ResumeLayout(false);
            chatBoxTbl.PerformLayout();
            chatBoxBottomTbl.ResumeLayout(false);
            chatBoxBottomTbl.PerformLayout();
            backTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel chatTbl;
        private TableLayoutPanel leftChatTbl;
        private TableLayoutPanel avatarTbl;
        private Panel avatarPanel;
        private TableLayoutPanel onlineTblPanel;
        private TableLayoutPanel chatRightTbl;
        private TableLayoutPanel chatBoxTbl;
        private TableLayoutPanel chatBoxBottomTbl;
        private Button sendBtn;
        private TextBox chatTextBox;
        private Label usernameLbl;
        private TableLayoutPanel chatLblTbl;
        private PictureBox chatLbl;
        private PictureBox botBtn;
        private PictureBox usersBtn;
        private TableLayoutPanel backTbl;
        private PictureBox backBtn;
    }
}
