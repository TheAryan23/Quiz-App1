namespace Quiz_App
{
    partial class Admin_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(116, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 654);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Admin_login";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(192, 453);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 351);
            label2.Name = "label2";
            label2.Size = new Size(119, 32);
            label2.TabIndex = 3;
            label2.Text = "PASSWORD";
            // 
            // label1
            // 
            label1.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 229);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 2;
            label1.Text = "USER NAME";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(247, 351);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 0;
            // 
            // Admin_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 728);
            Controls.Add(groupBox1);
            Name = "Admin_login";
            Text = "Admin_login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
    }
}