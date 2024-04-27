namespace Quiz_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(609, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 179);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(237, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 179);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 430);
            label1.Name = "label1";
            label1.Size = new Size(222, 39);
            label1.TabIndex = 4;
            label1.Text = "ADMIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(609, 430);
            label2.Name = "label2";
            label2.Size = new Size(222, 39);
            label2.TabIndex = 5;
            label2.Text = "STUDENT";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 730);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Quiz App";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
    }
}
