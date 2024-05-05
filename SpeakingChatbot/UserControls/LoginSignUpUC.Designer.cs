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
            splitLoginUC = new SplitContainer();
            loginTbl = new TableLayoutPanel();
            loginBtn = new Button();
            signUpTbl = new TableLayoutPanel();
            signUpBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)splitLoginUC).BeginInit();
            splitLoginUC.Panel1.SuspendLayout();
            splitLoginUC.Panel2.SuspendLayout();
            splitLoginUC.SuspendLayout();
            loginTbl.SuspendLayout();
            signUpTbl.SuspendLayout();
            SuspendLayout();
            // 
            // splitLoginUC
            // 
            splitLoginUC.Dock = DockStyle.Fill;
            splitLoginUC.Location = new Point(0, 0);
            splitLoginUC.Name = "splitLoginUC";
            // 
            // splitLoginUC.Panel1
            // 
            splitLoginUC.Panel1.Controls.Add(loginTbl);
            // 
            // splitLoginUC.Panel2
            // 
            splitLoginUC.Panel2.Controls.Add(signUpTbl);
            splitLoginUC.Size = new Size(720, 480);
            splitLoginUC.SplitterDistance = 386;
            splitLoginUC.SplitterWidth = 8;
            splitLoginUC.TabIndex = 0;
            // 
            // loginTbl
            // 
            loginTbl.ColumnCount = 3;
            loginTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.59259F));
            loginTbl.ColumnStyles.Add(new ColumnStyle());
            loginTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.40740728F));
            loginTbl.Controls.Add(loginBtn, 1, 1);
            loginTbl.Dock = DockStyle.Fill;
            loginTbl.Location = new Point(0, 0);
            loginTbl.Name = "loginTbl";
            loginTbl.RowCount = 3;
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            loginTbl.RowStyles.Add(new RowStyle());
            loginTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            loginTbl.Size = new Size(386, 480);
            loginTbl.TabIndex = 0;
            // 
            // loginBtn
            // 
            loginBtn.AutoSize = true;
            loginBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginBtn.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(208, 201);
            loginBtn.Margin = new Padding(0);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(161, 77);
            loginBtn.TabIndex = 0;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            // 
            // signUpTbl
            // 
            signUpTbl.ColumnCount = 3;
            signUpTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.407407F));
            signUpTbl.ColumnStyles.Add(new ColumnStyle());
            signUpTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.59259F));
            signUpTbl.Controls.Add(signUpBtn, 1, 1);
            signUpTbl.Dock = DockStyle.Fill;
            signUpTbl.Location = new Point(0, 0);
            signUpTbl.Name = "signUpTbl";
            signUpTbl.RowCount = 3;
            signUpTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            signUpTbl.RowStyles.Add(new RowStyle());
            signUpTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            signUpTbl.Size = new Size(326, 480);
            signUpTbl.TabIndex = 0;
            // 
            // signUpBtn
            // 
            signUpBtn.AutoSize = true;
            signUpBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            signUpBtn.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            signUpBtn.Location = new Point(3, 201);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(18, 77);
            signUpBtn.TabIndex = 0;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = true;
            // 
            // LoginUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.cat2;
            Controls.Add(splitLoginUC);
            Name = "LoginUC";
            Size = new Size(720, 480);
            splitLoginUC.Panel1.ResumeLayout(false);
            splitLoginUC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitLoginUC).EndInit();
            splitLoginUC.ResumeLayout(false);
            loginTbl.ResumeLayout(false);
            loginTbl.PerformLayout();
            signUpTbl.ResumeLayout(false);
            signUpTbl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitLoginUC;
        private TableLayoutPanel loginTbl;
        private Button loginBtn;
        private TableLayoutPanel signUpTbl;
        private Button signUpBtn;
    }
}
