namespace SpeakingChatbot.UserControls {
    partial class LoginSignUpUC {
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
            titleLbl = new Label();
            keyLbl = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            loginBtn = new Button();
            signUpBtn = new Button();
            loginTbl.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginTbl
            // 
            loginTbl.ColumnCount = 1;
            loginTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loginTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            loginTbl.Controls.Add(titleLbl, 0, 0);
            loginTbl.Controls.Add(keyLbl, 0, 2);
            loginTbl.Controls.Add(tableLayoutPanel1, 0, 1);
            loginTbl.Dock = DockStyle.Fill;
            loginTbl.Location = new Point(0, 0);
            loginTbl.Name = "loginTbl";
            loginTbl.RowCount = 3;
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            loginTbl.Size = new Size(720, 480);
            loginTbl.TabIndex = 0;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.BackColor = Color.Transparent;
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.Font = new Font("Segoe UI", 40.2F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.Black;
            titleLbl.Location = new Point(3, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(714, 120);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "CHAVATAR";
            titleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // keyLbl
            // 
            keyLbl.AutoSize = true;
            keyLbl.Dock = DockStyle.Fill;
            keyLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            keyLbl.ForeColor = Color.DarkGray;
            keyLbl.Location = new Point(3, 336);
            keyLbl.Name = "keyLbl";
            keyLbl.Size = new Size(714, 144);
            keyLbl.TabIndex = 1;
            keyLbl.Text = "PRESS ANY KEY TO CONTINUE";
            keyLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.5F));
            tableLayoutPanel1.Controls.Add(signUpBtn, 3, 1);
            tableLayoutPanel1.Controls.Add(loginBtn, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 123);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Size = new Size(714, 210);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // loginBtn
            // 
            loginBtn.AutoSize = true;
            loginBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginBtn.Dock = DockStyle.Right;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(167, 63);
            loginBtn.Margin = new Padding(0);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(185, 84);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = true;
            // 
            // signUpBtn
            // 
            signUpBtn.AutoSize = true;
            signUpBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signUpBtn.BackColor = Color.Transparent;
            signUpBtn.Dock = DockStyle.Left;
            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            signUpBtn.ForeColor = Color.White;
            signUpBtn.Location = new Point(362, 66);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(214, 78);
            signUpBtn.TabIndex = 1;
            signUpBtn.Text = "SIGNUP";
            signUpBtn.TextAlign = ContentAlignment.MiddleLeft;
            signUpBtn.UseVisualStyleBackColor = false;
            // 
            // LoginSignUpUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.start2;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(loginTbl);
            Name = "LoginSignUpUC";
            Size = new Size(720, 480);
            loginTbl.ResumeLayout(false);
            loginTbl.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel loginTbl;
        private Label titleLbl;
        private Label keyLbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Button signUpBtn;
        private Button loginBtn;
    }
}
