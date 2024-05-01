namespace SpeakingChatbot
{
    public partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        public void SetPictureBoxImage(Image image)
        {
            pictureBox1.Image = image;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            chatBoxBtn = new Button();
            chatContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(252, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // chatBoxBtn
            // 
            chatBoxBtn.Location = new Point(664, 12);
            chatBoxBtn.Name = "chatBoxBtn";
            chatBoxBtn.Size = new Size(124, 49);
            chatBoxBtn.TabIndex = 1;
            chatBoxBtn.Text = "chatbox";
            chatBoxBtn.UseVisualStyleBackColor = true;
            chatBoxBtn.Click += button1_Click;
            // 
            // chatContainer
            // 
            chatContainer.BackColor = Color.Transparent;
            chatContainer.Location = new Point(12, 67);
            chatContainer.Name = "chatContainer";
            chatContainer.Size = new Size(776, 371);
            chatContainer.TabIndex = 2;
            chatContainer.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chatContainer);
            Controls.Add(chatBoxBtn);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button chatBoxBtn;
        private Panel chatContainer;
    }
}