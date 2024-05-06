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
            welcomeTblPanel.Controls.Add(keyLbl, 0, 2);
            welcomeTblPanel.Controls.Add(titleLbl, 0, 0);
            welcomeTblPanel.Dock = DockStyle.Fill;
            welcomeTblPanel.Location = new Point(0, 0);
            welcomeTblPanel.Name = "welcomeTblPanel";
            welcomeTblPanel.RowCount = 3;
            welcomeTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            welcomeTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            welcomeTblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            welcomeTblPanel.Size = new Size(1515, 597);
            welcomeTblPanel.TabIndex = 4;
            // 
            // keyLbl
            // 
            keyLbl.AutoSize = true;
            keyLbl.BackColor = Color.Transparent;
            keyLbl.Dock = DockStyle.Fill;
            keyLbl.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            keyLbl.ForeColor = Color.White;
            keyLbl.Location = new Point(3, 417);
            keyLbl.Name = "keyLbl";
            keyLbl.Size = new Size(1509, 180);
            keyLbl.TabIndex = 2;
            keyLbl.Text = "PRESS ANY KEY TO CONTINUE";
            keyLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleLbl
            // 
            titleLbl.BackColor = Color.Transparent;
            titleLbl.Dock = DockStyle.Fill;
            titleLbl.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.ForeColor = Color.Black;
            titleLbl.Location = new Point(3, 0);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(1509, 149);
            titleLbl.TabIndex = 3;
            titleLbl.Text = "CHAVATAR";
            titleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WelcomeUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.start1;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(welcomeTblPanel);
            DoubleBuffered = true;
            Name = "WelcomeUC";
            Size = new Size(1515, 597);
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
