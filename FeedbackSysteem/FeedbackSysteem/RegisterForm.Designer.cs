namespace FeedbackSysteem
{
    partial class RegisterForm
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 27);
            textBox1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(81, 251);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 6;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(81, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(81, 161);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(81, 194);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(134, 27);
            textBox5.TabIndex = 12;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 398);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}