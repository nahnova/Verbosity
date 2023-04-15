namespace FeedbackSysteem
{
    partial class AddGoalForm
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
            components = new System.ComponentModel.Container();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 34);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 99);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(52, 73);
            label1.Name = "label1";
            label1.Size = new Size(43, 22);
            label1.TabIndex = 3;
            label1.Text = "Doel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(52, 144);
            label2.Name = "label2";
            label2.Size = new Size(68, 22);
            label2.TabIndex = 4;
            label2.Text = "Prioriteit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(52, 182);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 5;
            label3.Text = "Tijdregistratie";
            // 
            // button1
            // 
            button1.Location = new Point(135, 242);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 6;
            button1.Text = "Doel toevoegen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox4
            // 
            textBox4.Location = new Point(161, 178);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 27);
            textBox4.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Laag", "Gemiddeld", "Urgent" });
            comboBox1.Location = new Point(126, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 28);
            comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(327, 181);
            label5.Name = "label5";
            label5.Size = new Size(32, 22);
            label5.TabIndex = 10;
            label5.Text = "uur";
            // 
            // AddGoalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 311);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Name = "AddGoalForm";
            Text = "AddGoalForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Label label5;
    }
}