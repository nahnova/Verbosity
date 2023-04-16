namespace FeedbackSysteem
{
    partial class LoginForm
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
            tabControl2 = new TabControl();
            tabPage2 = new TabPage();
            label4 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            tabPage3 = new TabPage();
            label6 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            button4 = new Button();
            textBox4 = new TextBox();
            tabControl2.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Location = new Point(-5, -1);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(435, 429);
            tabControl2.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(427, 396);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Student login";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 134);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 9;
            label4.Text = "Wachtwoord";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 101);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 134);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(141, 204);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += StudentLogin;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 101);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(141, 239);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 1;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 27);
            textBox2.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(427, 396);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Docent login";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 134);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 9;
            label6.Text = "Wachtwoord";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 101);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(141, 98);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 27);
            textBox3.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(141, 204);
            button4.Name = "button4";
            button4.Size = new Size(134, 29);
            button4.TabIndex = 5;
            button4.Text = "Login";
            button4.UseVisualStyleBackColor = true;
            button4.Click += TeacherLogin;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(141, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(134, 27);
            textBox4.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 341);
            Controls.Add(tabControl2);
            Name = "LoginForm";
            Text = "Form1";
            tabControl2.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl2;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Label label1;
        private Button button2;
        private TextBox textBox2;
        private TabPage tabPage3;
        private Label label4;
        private Label label2;
        private TextBox textBox3;
        private Button button4;
        private TextBox textBox4;
        private Label label6;
        private Label label5;
    }
}