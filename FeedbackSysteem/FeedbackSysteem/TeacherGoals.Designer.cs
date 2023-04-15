namespace FeedbackSysteem
{
    partial class TeacherGoals
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
            button5 = new Button();
            comboBox1 = new ComboBox();
            button4 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(686, 9);
            button5.Name = "button5";
            button5.Size = new Size(109, 29);
            button5.TabIndex = 17;
            button5.Text = "Feedback";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "te doen", "bezig", "afgerond" });
            comboBox1.Location = new Point(547, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 28);
            comboBox1.TabIndex = 16;
            // 
            // button4
            // 
            button4.Location = new Point(219, 9);
            button4.Name = "button4";
            button4.Size = new Size(92, 29);
            button4.TabIndex = 15;
            button4.Text = "subdoelen";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(12, 44);
            listView1.Name = "listView1";
            listView1.Size = new Size(783, 419);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "studentid";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Doel";
            columnHeader3.Width = 350;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "prioriteit";
            columnHeader4.Width = 105;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "tijd/uur";
            columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Status";
            columnHeader6.Width = 120;
            // 
            // button3
            // 
            button3.Location = new Point(107, 9);
            button3.Name = "button3";
            button3.Size = new Size(106, 29);
            button3.TabIndex = 13;
            button3.Text = "verwijderen";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(89, 29);
            button1.TabIndex = 12;
            button1.Text = "toevoegen";
            button1.UseVisualStyleBackColor = true;
            // 
            // TeacherGoals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 475);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "TeacherGoals";
            Text = "TeacherGoals";
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private ComboBox comboBox1;
        private Button button4;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button3;
        private Button button1;
    }
}