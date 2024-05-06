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
            passwordTextBox = new TextBox();
            usernameLbl = new Label();
            usernameTextBox = new TextBox();
            passwordLbl = new Label();
            enterTbl = new TableLayoutPanel();
            button1 = new Button();
            loginTbl.SuspendLayout();
            titleTbl.SuspendLayout();
            midTbl.SuspendLayout();
            enterTbl.SuspendLayout();
            SuspendLayout();
            // 
            // loginTbl
            // 
            loginTbl.BackColor = Color.Transparent;
            loginTbl.ColumnCount = 1;
            loginTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loginTbl.Controls.Add(titleTbl, 0, 0);
            loginTbl.Controls.Add(midTbl, 0, 1);
            loginTbl.Controls.Add(enterTbl, 0, 2);
            loginTbl.Dock = DockStyle.Fill;
            loginTbl.Location = new Point(0, 0);
            loginTbl.Name = "loginTbl";
            loginTbl.RowCount = 3;
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
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
            titleTbl.Size = new Size(1274, 233);
            titleTbl.TabIndex = 0;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.Font = new Font("Segoe UI", 100F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.White;
            titleLbl.Location = new Point(3, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(631, 233);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "LOGIN";
            titleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // midTbl
            // 
            midTbl.ColumnCount = 4;
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            midTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            midTbl.Controls.Add(passwordTextBox, 2, 3);
            midTbl.Controls.Add(usernameLbl, 1, 1);
            midTbl.Controls.Add(usernameTextBox, 2, 1);
            midTbl.Controls.Add(passwordLbl, 1, 3);
            midTbl.Dock = DockStyle.Fill;
            midTbl.Location = new Point(3, 242);
            midTbl.Name = "midTbl";
            midTbl.RowCount = 5;
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            midTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            midTbl.Size = new Size(1274, 234);
            midTbl.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Font = new Font("Segoe UI", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(512, 131);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(567, 63);
            passwordTextBox.TabIndex = 4;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Dock = DockStyle.Right;
            usernameLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLbl.ForeColor = Color.Black;
            usernameLbl.Location = new Point(313, 35);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(193, 70);
            usernameLbl.TabIndex = 0;
            usernameLbl.Text = "USERNAME";
            usernameLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Font = new Font("Segoe UI", 25.2F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(512, 38);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(567, 63);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Dock = DockStyle.Right;
            passwordLbl.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLbl.ForeColor = Color.Black;
            passwordLbl.Location = new Point(309, 128);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(197, 70);
            passwordLbl.TabIndex = 3;
            passwordLbl.Text = "PASSWORD";
            passwordLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // enterTbl
            // 
            enterTbl.AutoSize = true;
            enterTbl.ColumnCount = 3;
            enterTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            enterTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            enterTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            enterTbl.Controls.Add(button1, 1, 1);
            enterTbl.Dock = DockStyle.Fill;
            enterTbl.Location = new Point(3, 482);
            enterTbl.Name = "enterTbl";
            enterTbl.RowCount = 3;
            enterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            enterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            enterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            enterTbl.Size = new Size(1274, 235);
            enterTbl.TabIndex = 4;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(512, 85);
            button1.Name = "button1";
            button1.Size = new Size(248, 64);
            button1.TabIndex = 0;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = true;
            // 
            // LoginUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Log_in_and_signup;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(loginTbl);
            Name = "LoginUC";
            Size = new Size(1280, 720);
            loginTbl.ResumeLayout(false);
            loginTbl.PerformLayout();
            titleTbl.ResumeLayout(false);
            titleTbl.PerformLayout();
            midTbl.ResumeLayout(false);
            midTbl.PerformLayout();
            enterTbl.ResumeLayout(false);
            enterTbl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel loginTbl;
        private TableLayoutPanel titleTbl;
        private Label titleLbl;
        private TableLayoutPanel midTbl;
        private TableLayoutPanel enterTbl;
        private Button button1;
        private Panel usernamePanel;
        private Label usernameLbl;
        private TextBox usernameTextBox;
        private Panel passwordPanel;
        private TextBox passwordTextBox;
        private Label passwordLbl;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
