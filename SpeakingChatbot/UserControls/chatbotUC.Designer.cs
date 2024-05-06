namespace SpeakingChatbot.UserControls {
    partial class ChatbotUC {
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
            chatbotTbl = new TableLayoutPanel();
            botTbl = new TableLayoutPanel();
            avatar = new PictureBox();
            topTbl = new TableLayoutPanel();
            backBtn = new PictureBox();
            botLbl = new Label();
            chatPanel = new Panel();
            chatbotTbl.SuspendLayout();
            botTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avatar).BeginInit();
            topTbl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).BeginInit();
            SuspendLayout();
            // 
            // chatbotTbl
            // 
            chatbotTbl.BackColor = Color.Transparent;
            chatbotTbl.ColumnCount = 2;
            chatbotTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            chatbotTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            chatbotTbl.Controls.Add(botTbl, 1, 0);
            chatbotTbl.Controls.Add(chatPanel, 0, 0);
            chatbotTbl.Dock = DockStyle.Fill;
            chatbotTbl.Location = new Point(0, 0);
            chatbotTbl.Name = "chatbotTbl";
            chatbotTbl.RowCount = 1;
            chatbotTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            chatbotTbl.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            chatbotTbl.Size = new Size(948, 569);
            chatbotTbl.TabIndex = 0;
            // 
            // botTbl
            // 
            botTbl.ColumnCount = 1;
            botTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            botTbl.Controls.Add(avatar, 0, 1);
            botTbl.Controls.Add(topTbl, 0, 0);
            botTbl.Dock = DockStyle.Fill;
            botTbl.Location = new Point(477, 3);
            botTbl.Name = "botTbl";
            botTbl.RowCount = 2;
            botTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            botTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            botTbl.Size = new Size(468, 563);
            botTbl.TabIndex = 0;
            // 
            // avatar
            // 
            avatar.BackColor = Color.Black;
            avatar.Dock = DockStyle.Fill;
            avatar.Location = new Point(3, 59);
            avatar.Name = "avatar";
            avatar.Size = new Size(462, 501);
            avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            avatar.TabIndex = 0;
            avatar.TabStop = false;
            // 
            // topTbl
            // 
            topTbl.ColumnCount = 2;
            topTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            topTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            topTbl.Controls.Add(backBtn, 1, 0);
            topTbl.Controls.Add(botLbl, 0, 0);
            topTbl.Dock = DockStyle.Fill;
            topTbl.Location = new Point(3, 3);
            topTbl.Name = "topTbl";
            topTbl.RowCount = 1;
            topTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            topTbl.Size = new Size(462, 50);
            topTbl.TabIndex = 1;
            // 
            // backBtn
            // 
            backBtn.Dock = DockStyle.Right;
            backBtn.Image = Properties.Resources.backbutton;
            backBtn.Location = new Point(334, 3);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(125, 44);
            backBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backBtn.TabIndex = 0;
            backBtn.TabStop = false;
            // 
            // botLbl
            // 
            botLbl.AutoSize = true;
            botLbl.Dock = DockStyle.Left;
            botLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            botLbl.Location = new Point(3, 0);
            botLbl.Name = "botLbl";
            botLbl.Size = new Size(101, 50);
            botLbl.TabIndex = 1;
            botLbl.Text = "NAME";
            botLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chatPanel
            // 
            chatPanel.BackColor = Color.Transparent;
            chatPanel.BackgroundImageLayout = ImageLayout.Stretch;
            chatPanel.Dock = DockStyle.Fill;
            chatPanel.ForeColor = SystemColors.ActiveBorder;
            chatPanel.Location = new Point(10, 10);
            chatPanel.Margin = new Padding(10);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(454, 549);
            chatPanel.TabIndex = 1;
            // 
            // chatbotUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ai;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(chatbotTbl);
            Name = "chatbotUC";
            Size = new Size(948, 569);
            chatbotTbl.ResumeLayout(false);
            botTbl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)avatar).EndInit();
            topTbl.ResumeLayout(false);
            topTbl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel chatbotTbl;
        private TableLayoutPanel botTbl;
        private PictureBox avatar;
        private TableLayoutPanel topTbl;
        private PictureBox backBtn;
        private Label botLbl;
        private Panel chatPanel;
    }
}
