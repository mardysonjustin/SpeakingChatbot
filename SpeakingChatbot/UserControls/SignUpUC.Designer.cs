namespace SpeakingChatbot.UserControls {
    partial class SignUpUC {
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
            signUpTbl = new TableLayoutPanel();
            titleTbl = new TableLayoutPanel();
            signUpLbl = new Label();
            enterTbl = new TableLayoutPanel();
            enterBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            usernameLbl = new Label();
            passwordLbl = new Label();
            cPasswordLbl = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            cPasswordTextBox = new TextBox();
            signUpTbl.SuspendLayout();
            titleTbl.SuspendLayout();
            enterTbl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // signUpTbl
            // 
            signUpTbl.AutoSize = true;
            signUpTbl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signUpTbl.BackColor = Color.Transparent;
            signUpTbl.ColumnCount = 1;
            signUpTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            signUpTbl.Controls.Add(titleTbl, 0, 0);
            signUpTbl.Controls.Add(enterTbl, 0, 2);
            signUpTbl.Controls.Add(tableLayoutPanel1, 0, 1);
            signUpTbl.Dock = DockStyle.Fill;
            signUpTbl.Location = new Point(0, 0);
            signUpTbl.Name = "signUpTbl";
            signUpTbl.RowCount = 3;
            signUpTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            signUpTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 37F));
            signUpTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            signUpTbl.Size = new Size(905, 507);
            signUpTbl.TabIndex = 0;
            // 
            // titleTbl
            // 
            titleTbl.ColumnCount = 2;
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            titleTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            titleTbl.Controls.Add(signUpLbl, 0, 0);
            titleTbl.Dock = DockStyle.Fill;
            titleTbl.Location = new Point(3, 3);
            titleTbl.Name = "titleTbl";
            titleTbl.RowCount = 1;
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            titleTbl.Size = new Size(899, 161);
            titleTbl.TabIndex = 0;
            // 
            // signUpLbl
            // 
            signUpLbl.AutoSize = true;
            signUpLbl.Dock = DockStyle.Fill;
            signUpLbl.Font = new Font("Segoe UI", 49.8000031F, FontStyle.Regular, GraphicsUnit.Point);
            signUpLbl.ForeColor = Color.White;
            signUpLbl.Location = new Point(3, 0);
            signUpLbl.Name = "signUpLbl";
            signUpLbl.Size = new Size(443, 161);
            signUpLbl.TabIndex = 0;
            signUpLbl.Text = "Sign Up";
            signUpLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // enterTbl
            // 
            enterTbl.ColumnCount = 3;
            enterTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            enterTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            enterTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            enterTbl.Controls.Add(enterBtn, 1, 1);
            enterTbl.Dock = DockStyle.Fill;
            enterTbl.Location = new Point(3, 357);
            enterTbl.Name = "enterTbl";
            enterTbl.RowCount = 3;
            enterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            enterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            enterTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            enterTbl.Size = new Size(899, 147);
            enterTbl.TabIndex = 2;
            // 
            // enterBtn
            // 
            enterBtn.Dock = DockStyle.Fill;
            enterBtn.FlatStyle = FlatStyle.Flat;
            enterBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            enterBtn.ForeColor = Color.White;
            enterBtn.Location = new Point(362, 39);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(173, 67);
            enterBtn.TabIndex = 0;
            enterBtn.Text = "ENTER";
            enterBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(usernameLbl, 1, 1);
            tableLayoutPanel1.Controls.Add(passwordLbl, 1, 3);
            tableLayoutPanel1.Controls.Add(cPasswordLbl, 1, 5);
            tableLayoutPanel1.Controls.Add(usernameTextBox, 2, 1);
            tableLayoutPanel1.Controls.Add(passwordTextBox, 2, 3);
            tableLayoutPanel1.Controls.Add(cPasswordTextBox, 2, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 170);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23F));
            tableLayoutPanel1.Size = new Size(899, 181);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.Dock = DockStyle.Right;
            usernameLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLbl.ForeColor = Color.Black;
            usernameLbl.Location = new Point(240, 19);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(160, 41);
            usernameLbl.TabIndex = 0;
            usernameLbl.Text = "USERNAME";
            usernameLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Dock = DockStyle.Right;
            passwordLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLbl.Location = new Point(237, 78);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(163, 41);
            passwordLbl.TabIndex = 1;
            passwordLbl.Text = "PASSWORD";
            passwordLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cPasswordLbl
            // 
            cPasswordLbl.AutoSize = true;
            cPasswordLbl.Dock = DockStyle.Right;
            cPasswordLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            cPasswordLbl.Location = new Point(108, 137);
            cPasswordLbl.Name = "cPasswordLbl";
            cPasswordLbl.Size = new Size(292, 44);
            cPasswordLbl.TabIndex = 2;
            cPasswordLbl.Text = "CONFIRM PASSWORD";
            cPasswordLbl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(406, 22);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(398, 38);
            usernameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(406, 81);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(398, 38);
            passwordTextBox.TabIndex = 4;
            // 
            // cPasswordTextBox
            // 
            cPasswordTextBox.Dock = DockStyle.Fill;
            cPasswordTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cPasswordTextBox.Location = new Point(406, 140);
            cPasswordTextBox.Name = "cPasswordTextBox";
            cPasswordTextBox.Size = new Size(398, 38);
            cPasswordTextBox.TabIndex = 5;
            // 
            // SignUpUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Log_in_and_signup;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(signUpTbl);
            Name = "SignUpUC";
            Size = new Size(905, 507);
            signUpTbl.ResumeLayout(false);
            titleTbl.ResumeLayout(false);
            titleTbl.PerformLayout();
            enterTbl.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel signUpTbl;
        private TableLayoutPanel titleTbl;
        private Label signUpLbl;
        private TableLayoutPanel enterTbl;
        private Button enterBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label usernameLbl;
        private Label passwordLbl;
        private Label cPasswordLbl;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox cPasswordTextBox;
    }
}
