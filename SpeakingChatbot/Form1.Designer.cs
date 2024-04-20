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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = Image.FromFile("C:\\Users\\foagr\\source\\repos\\SpeakingChatbot\\SpeakingChatbot\\assets\\IMG_20240415_195608_239.jpg");
            this.pictureBox1.Location = new System.Drawing.Point(252, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom; // Set size mode to Zoom
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
    }
}