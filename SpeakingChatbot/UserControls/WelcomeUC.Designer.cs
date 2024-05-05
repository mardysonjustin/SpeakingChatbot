using SpeakingChatbot;
using System.Windows.Forms;

namespace SpeakingChatbot.UserControls {
    partial class WelcomeUC {
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
            welcomeTblPanel = new TableLayoutPanel();
            keyLbl = new Label();
            titleLbl = new Label();
            welcomeTblPanel.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeTblPanel
            // 
            welcomeTblPanel.AutoSize = true;
            welcomeTblPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            welcomeTblPanel.BackColor = Color.Transparent;
            welcomeTblPanel.ColumnCount = 1;
            welcomeTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            welcomeTblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            welcomeTblPanel.Controls.Add(keyLbl, 0, 2);
            welcomeTblPanel.Controls.Add(titleLbl, 0, 0);
            welcomeTblPanel.Dock = DockStyle.Fill;
            welcomeTblPanel.Location = new Point(0, 0);
            welcomeTblPanel.Name = "welcomeTblPanel";
            welcomeTblPanel.RowCount = 3;
            welcomeTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            welcomeTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            welcomeTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            welcomeTblPanel.Size = new Size(1514, 597);
            welcomeTblPanel.TabIndex = 4;
            // 
            // keyLbl
            // 
            keyLbl.AutoSize = true;
            keyLbl.BackColor = Color.Transparent;
            keyLbl.Dock = DockStyle.Fill;
            keyLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            keyLbl.ForeColor = Color.FromArgb(192, 0, 0);
            keyLbl.Location = new Point(3, 417);
            keyLbl.Name = "keyLbl";
            keyLbl.Size = new Size(1508, 180);
            keyLbl.TabIndex = 2;
            keyLbl.Text = "Press any key to Continue";
            keyLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleLbl
            // 
            titleLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleLbl.BackColor = Color.Transparent;
            titleLbl.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.FromArgb(192, 0, 0);
            titleLbl.Location = new Point(3, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(1508, 149);
            titleLbl.TabIndex = 3;
            titleLbl.Text = "Chavatar";
            titleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.cat2;
            Controls.Add(welcomeTblPanel);
            DoubleBuffered = true;
            Name = "WelcomePage";
            Size = new Size(1514, 597);
            welcomeTblPanel.ResumeLayout(false);
            welcomeTblPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel welcomeTblPanel;
        private Label keyLbl;
        private Label titleLbl;
    }
}
