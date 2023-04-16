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
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(68, 256);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 6;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += RegisterStudent;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(110, 194);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(147, 27);
            textBox5.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(13, 65);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 13;
            label1.Text = "Voornaam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(13, 98);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 14;
            label2.Text = "Achternaam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(13, 131);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 15;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(13, 164);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 16;
            label4.Text = "Geslacht";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(13, 197);
            label5.Name = "label5";
            label5.Size = new Size(95, 22);
            label5.TabIndex = 17;
            label5.Text = "Wachtwoord";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Man", "Vrouw", "Overig" });
            comboBox1.Location = new Point(110, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 28);
            comboBox1.TabIndex = 18;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 311);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
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
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
    }
}