namespace FeedbackSysteem
{
    partial class ProfilePage
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 223);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(186, 27);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(36, 77);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 5;
            label1.Text = "Voornaam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(36, 125);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 6;
            label2.Text = "Achternaam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(36, 175);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(36, 223);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 8;
            label4.Text = "Geslacht";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(154, 28);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(118, 297);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 10;
            button1.Text = "Update profiel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += updateProfile;
            // 
            // ProfilePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 387);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "ProfilePage";
            Text = "ProfilePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}