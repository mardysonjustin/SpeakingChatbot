namespace SpeakingChatbot.UserControls {
    partial class MainMenuUC {
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
            mainMenuTbl = new TableLayoutPanel();
            startedTbl = new TableLayoutPanel();
            startedLbl = new Label();
            midPanel = new TableLayoutPanel();
            forumTbl = new TableLayoutPanel();
            forumIcon = new PictureBox();
            forumBtn = new PictureBox();
            chatTbl = new TableLayoutPanel();
            chatIcon = new PictureBox();
            chatBtn = new PictureBox();
            chatbotTbl = new TableLayoutPanel();
            chatbotIcon = new PictureBox();
            chatbotBtn = new PictureBox();
            mainMenuTbl.SuspendLayout();
            startedTbl.SuspendLayout();
            midPanel.SuspendLayout();
            forumTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)forumIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)forumBtn).BeginInit();
            chatTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatBtn).BeginInit();
            chatbotTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatbotIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatbotBtn).BeginInit();
            SuspendLayout();
            // 
            // mainMenuTbl
            // 
            mainMenuTbl.ColumnCount = 1;
            mainMenuTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainMenuTbl.Controls.Add(startedTbl, 0, 3);
            mainMenuTbl.Controls.Add(midPanel, 0, 1);
            mainMenuTbl.Dock = DockStyle.Fill;
            mainMenuTbl.Location = new Point(0, 0);
            mainMenuTbl.Name = "mainMenuTbl";
            mainMenuTbl.RowCount = 5;
            mainMenuTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            mainMenuTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            mainMenuTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            mainMenuTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            mainMenuTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            mainMenuTbl.Size = new Size(1163, 720);
            mainMenuTbl.TabIndex = 0;
            // 
            // startedTbl
            // 
            startedTbl.ColumnCount = 3;
            startedTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            startedTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            startedTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            startedTbl.Controls.Add(startedLbl, 1, 0);
            startedTbl.Dock = DockStyle.Fill;
            startedTbl.Location = new Point(3, 543);
            startedTbl.Name = "startedTbl";
            startedTbl.RowCount = 1;
            startedTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            startedTbl.Size = new Size(1157, 123);
            startedTbl.TabIndex = 0;
            // 
            // startedLbl
            // 
            startedLbl.AutoSize = true;
            startedLbl.Dock = DockStyle.Fill;
            startedLbl.Font = new Font("Segoe UI", 55.2F, FontStyle.Regular, GraphicsUnit.Point);
            startedLbl.Location = new Point(118, 0);
            startedLbl.Name = "startedLbl";
            startedLbl.Size = new Size(919, 123);
            startedLbl.TabIndex = 0;
            startedLbl.Text = "GET STARTED";
            startedLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // midPanel
            // 
            midPanel.AutoSize = true;
            midPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            midPanel.ColumnCount = 7;
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            midPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            midPanel.Controls.Add(forumTbl, 5, 0);
            midPanel.Controls.Add(chatTbl, 3, 0);
            midPanel.Controls.Add(chatbotTbl, 1, 0);
            midPanel.Dock = DockStyle.Fill;
            midPanel.Location = new Point(3, 147);
            midPanel.Name = "midPanel";
            midPanel.RowCount = 1;
            midPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            midPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            midPanel.Size = new Size(1157, 282);
            midPanel.TabIndex = 1;
            // 
            // forumTbl
            // 
            forumTbl.ColumnCount = 1;
            forumTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            forumTbl.Controls.Add(forumIcon, 0, 0);
            forumTbl.Controls.Add(forumBtn, 0, 1);
            forumTbl.Dock = DockStyle.Fill;
            forumTbl.Location = new Point(807, 0);
            forumTbl.Margin = new Padding(0);
            forumTbl.Name = "forumTbl";
            forumTbl.RowCount = 2;
            forumTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 63F));
            forumTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            forumTbl.Size = new Size(231, 282);
            forumTbl.TabIndex = 5;
            forumTbl.Click += forumTbl_Click;
            // 
            // forumIcon
            // 
            forumIcon.Dock = DockStyle.Fill;
            forumIcon.ErrorImage = Properties.Resources.forumicon;
            forumIcon.Image = Properties.Resources.forumicon;
            forumIcon.InitialImage = Properties.Resources.forumicon;
            forumIcon.Location = new Point(0, 0);
            forumIcon.Margin = new Padding(0);
            forumIcon.Name = "forumIcon";
            forumIcon.Size = new Size(231, 177);
            forumIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            forumIcon.TabIndex = 0;
            forumIcon.TabStop = false;
            // 
            // forumBtn
            // 
            forumBtn.Dock = DockStyle.Fill;
            forumBtn.ErrorImage = Properties.Resources.forumsbutton;
            forumBtn.Image = Properties.Resources.forumsbutton;
            forumBtn.InitialImage = Properties.Resources.forumsbutton;
            forumBtn.Location = new Point(0, 177);
            forumBtn.Margin = new Padding(0);
            forumBtn.Name = "forumBtn";
            forumBtn.Size = new Size(231, 105);
            forumBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            forumBtn.TabIndex = 1;
            forumBtn.TabStop = false;
            // 
            // chatTbl
            // 
            chatTbl.ColumnCount = 1;
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            chatTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            chatTbl.Controls.Add(chatIcon, 0, 0);
            chatTbl.Controls.Add(chatBtn, 0, 1);
            chatTbl.Dock = DockStyle.Fill;
            chatTbl.Location = new Point(461, 0);
            chatTbl.Margin = new Padding(0);
            chatTbl.Name = "chatTbl";
            chatTbl.RowCount = 2;
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 63F));
            chatTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            chatTbl.Size = new Size(231, 282);
            chatTbl.TabIndex = 6;
            chatTbl.Click += chatTbl_Click;
            // 
            // chatIcon
            // 
            chatIcon.Dock = DockStyle.Fill;
            chatIcon.ErrorImage = Properties.Resources.onlinechaticon;
            chatIcon.Image = Properties.Resources.onlinechaticon;
            chatIcon.InitialImage = Properties.Resources.onlinechaticon;
            chatIcon.Location = new Point(0, 0);
            chatIcon.Margin = new Padding(0);
            chatIcon.Name = "chatIcon";
            chatIcon.Size = new Size(231, 177);
            chatIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            chatIcon.TabIndex = 0;
            chatIcon.TabStop = false;
            // 
            // chatBtn
            // 
            chatBtn.Dock = DockStyle.Fill;
            chatBtn.ErrorImage = Properties.Resources.onlinechatbutton;
            chatBtn.Image = Properties.Resources.onlinechatbutton;
            chatBtn.InitialImage = Properties.Resources.onlinechatbutton;
            chatBtn.Location = new Point(0, 177);
            chatBtn.Margin = new Padding(0);
            chatBtn.Name = "chatBtn";
            chatBtn.Size = new Size(231, 105);
            chatBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            chatBtn.TabIndex = 1;
            chatBtn.TabStop = false;
            // 
            // chatbotTbl
            // 
            chatbotTbl.ColumnCount = 1;
            chatbotTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            chatbotTbl.Controls.Add(chatbotIcon, 0, 0);
            chatbotTbl.Controls.Add(chatbotBtn, 0, 1);
            chatbotTbl.Dock = DockStyle.Fill;
            chatbotTbl.Location = new Point(115, 0);
            chatbotTbl.Margin = new Padding(0);
            chatbotTbl.Name = "chatbotTbl";
            chatbotTbl.RowCount = 2;
            chatbotTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 63F));
            chatbotTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            chatbotTbl.Size = new Size(231, 282);
            chatbotTbl.TabIndex = 7;
            chatbotTbl.Click += chatbotTbl_Click;
            // 
            // chatbotIcon
            // 
            chatbotIcon.Dock = DockStyle.Fill;
            chatbotIcon.ErrorImage = Properties.Resources.chatboticon;
            chatbotIcon.Image = Properties.Resources.chatboticon;
            chatbotIcon.InitialImage = Properties.Resources.chatboticon;
            chatbotIcon.Location = new Point(0, 0);
            chatbotIcon.Margin = new Padding(0);
            chatbotIcon.Name = "chatbotIcon";
            chatbotIcon.Size = new Size(231, 177);
            chatbotIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            chatbotIcon.TabIndex = 0;
            chatbotIcon.TabStop = false;
            // 
            // chatbotBtn
            // 
            chatbotBtn.Dock = DockStyle.Fill;
            chatbotBtn.ErrorImage = Properties.Resources.chatbotbutton;
            chatbotBtn.Image = Properties.Resources.chatbotbutton;
            chatbotBtn.InitialImage = Properties.Resources.chatbotbutton;
            chatbotBtn.Location = new Point(0, 177);
            chatbotBtn.Margin = new Padding(0);
            chatbotBtn.Name = "chatbotBtn";
            chatbotBtn.Size = new Size(231, 105);
            chatbotBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            chatbotBtn.TabIndex = 1;
            chatbotBtn.TabStop = false;
            // 
            // MainMenuUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.main_menu;
            Controls.Add(mainMenuTbl);
            Name = "MainMenuUC";
            Size = new Size(1163, 720);
            mainMenuTbl.ResumeLayout(false);
            mainMenuTbl.PerformLayout();
            startedTbl.ResumeLayout(false);
            startedTbl.PerformLayout();
            midPanel.ResumeLayout(false);
            forumTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)forumIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)forumBtn).EndInit();
            chatTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chatIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatBtn).EndInit();
            chatbotTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chatbotIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatbotBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainMenuTbl;
        private TableLayoutPanel startedTbl;
        private Label startedLbl;
        private TableLayoutPanel midPanel;
        private PictureBox chatIcon;
        private PictureBox chatBtn;
        private TableLayoutPanel chatbotTbl;
        private PictureBox chatbotIcon;
        private PictureBox chatbotBtn;
        private PictureBox forumIcon;
        private TableLayoutPanel forumTbl;
        private PictureBox forumBtn;
        private TableLayoutPanel chatTbl;
        private PictureBox pictureBox1;
    }
}
