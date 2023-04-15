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
            button4 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(517, 9);
            button5.Name = "button5";
            button5.Size = new Size(129, 29);
            button5.TabIndex = 17;
            button5.Text = "Feedback geven";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(336, 10);
            button4.Name = "button4";
            button4.Size = new Size(92, 29);
            button4.TabIndex = 15;
            button4.Text = "subdoelen";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OpenSubGoals;
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
            listView1.SelectedIndexChanged += SelectListviewId;
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
            // button1
            // 
            button1.Location = new Point(652, 9);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 18;
            button1.Text = "Feedback openen";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 27);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 14);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 21;
            label1.Text = "Student nummer:";
            // 
            // button2
            // 
            button2.Location = new Point(253, 10);
            button2.Name = "button2";
            button2.Size = new Size(77, 29);
            button2.TabIndex = 22;
            button2.Text = "selecteer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SelectStudent;
            // 
            // TeacherGoals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 475);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listView1);
            Name = "TeacherGoals";
            Text = "TeacherGoals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
    }
}