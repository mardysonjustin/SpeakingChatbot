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
            loginTbl.SuspendLayout();
            SuspendLayout();
            // 
            // loginTbl
            // 
            loginTbl.BackColor = Color.Transparent;
            loginTbl.ColumnCount = 1;
            loginTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            loginTbl.Controls.Add(titleTbl, 0, 0);
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
            titleTbl.Dock = DockStyle.Fill;
            titleTbl.Location = new Point(3, 3);
            titleTbl.Name = "titleTbl";
            titleTbl.RowCount = 1;
            titleTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            titleTbl.Size = new Size(1274, 234);
            titleTbl.TabIndex = 0;
            // 
            // LoginUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cat2;
            Controls.Add(loginTbl);
            Name = "LoginUC";
            Size = new Size(1280, 720);
            loginTbl.ResumeLayout(false);
            loginTbl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel loginTbl;
        private TableLayoutPanel titleTbl;
    }
}
