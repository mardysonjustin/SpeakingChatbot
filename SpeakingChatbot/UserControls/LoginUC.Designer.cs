namespace SpeakingChatbot.UserControls {
    partial class LoginUC {
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
            loginTbl = new TableLayoutPanel();
            titleTbl = new TableLayoutPanel();
            titleLbl = new Label();
            midTbl = new TableLayoutPanel();
            usernamePanel = new Panel();
            usernameTextBox = new TextBox();
            usernameLbl = new Label();
            passwordPanel = new Panel();
            passwordLbl = new Label();
            passwordTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            enterBtn = new Button();
            loginTbl.SuspendLayout();
            titleTbl.SuspendLayout();
            midTbl.SuspendLayout();
            usernamePanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginTbl
            // 
            loginTbl.BackColor = Color.Transparent;
            loginTbl.ColumnCount = 1;
            loginTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loginTbl.Controls.Add(titleTbl, 0, 0);
            loginTbl.Controls.Add(midTbl, 0, 1);
            loginTbl.Controls.Add(tableLayoutPanel1, 0, 2);
            loginTbl.Dock = DockStyle.Fill;
            loginTbl.Location = new Point(0, 0);
            loginTbl.Name = "loginTbl";
            loginTbl.RowCount = 3;
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            loginTbl.Size = new Size(1280, 720);
            loginTbl.TabIndex = 0;
            // 
            // titleTbl
            // 
            titleTbl.AutoSize = true;
            titleTbl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            titleTbl.ColumnCount = 2;
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            titleTbl.Controls.Add(titleLbl, 0, 0);
            titleTbl.Dock = DockStyle.Fill;
            titleTbl.Location = new Point(3, 3);
            titleTbl.Name = "titleTbl";
            titleTbl.RowCount = 1;
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            titleTbl.Size = new Size(1274, 234);
            titleTbl.TabIndex = 0;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.Font = new Font("Segoe UI", 100F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.ForeColor = SystemColors.MenuHighlight;
            titleLbl.Location = new Point(3, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(631, 234);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "LOGIN";
            titleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // midTbl
            // 
            midTbl.ColumnCount = 3;
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            midTbl.Controls.Add(usernamePanel, 1, 1);
            midTbl.Controls.Add(passwordPanel, 1, 2);
            midTbl.Dock = DockStyle.Fill;
            midTbl.Location = new Point(3, 243);
            midTbl.Name = "midTbl";
            midTbl.RowCount = 4;
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            midTbl.Size = new Size(1274, 234);
            midTbl.TabIndex = 1;
            // 
            // usernamePanel
            // 
            usernamePanel.Controls.Add(usernameTextBox);
            usernamePanel.Controls.Add(usernameLbl);
            usernamePanel.Dock = DockStyle.Fill;
            usernamePanel.Location = new Point(194, 49);
            usernamePanel.Name = "usernamePanel";
            usernamePanel.Size = new Size(885, 64);
            usernamePanel.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(284, 0);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(601, 74);
            usernameTextBox.TabIndex = 1;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Dock = DockStyle.Left;
            usernameLbl.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLbl.ForeColor = Color.White;
            usernameLbl.Location = new Point(0, 0);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(284, 67);
            usernameLbl.TabIndex = 0;
            usernameLbl.Text = "USERNAME";
            usernameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordPanel
            // 
            passwordPanel.Controls.Add(passwordTextBox);
            passwordPanel.Controls.Add(passwordLbl);
            passwordPanel.Dock = DockStyle.Fill;
            passwordPanel.Location = new Point(194, 119);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(885, 64);
            passwordPanel.TabIndex = 2;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Dock = DockStyle.Left;
            passwordLbl.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLbl.ForeColor = Color.White;
            passwordLbl.Location = new Point(0, 0);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(290, 67);
            passwordLbl.TabIndex = 3;
            passwordLbl.Text = "PASSWORD";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(290, 0);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(595, 74);
            passwordTextBox.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            tableLayoutPanel1.Controls.Add(enterBtn, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 483);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1274, 234);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // enterBtn
            // 
            enterBtn.AutoSize = true;
            enterBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            enterBtn.Dock = DockStyle.Fill;
            enterBtn.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            enterBtn.Location = new Point(474, 80);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(325, 71);
            enterBtn.TabIndex = 0;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = true;
            // 
            // LoginUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cat2;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(loginTbl);
            Name = "LoginUC";
            Size = new Size(1280, 720);
            loginTbl.ResumeLayout(false);
            loginTbl.PerformLayout();
            titleTbl.ResumeLayout(false);
            titleTbl.PerformLayout();
            midTbl.ResumeLayout(false);
            usernamePanel.ResumeLayout(false);
            usernamePanel.PerformLayout();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel loginTbl;
        private TableLayoutPanel titleTbl;
        private Label titleLbl;
        private TableLayoutPanel midTbl;
        private Panel usernamePanel;
        private Label usernameLbl;
        private TextBox usernameTextBox;
        private Panel passwordPanel;
        private TextBox passwordTextBox;
        private Label passwordLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Button enterBtn;
    }
}
