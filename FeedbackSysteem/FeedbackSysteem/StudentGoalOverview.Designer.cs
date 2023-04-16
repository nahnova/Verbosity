namespace FeedbackSysteem
{
    partial class StudentGoalOverview
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
            button3 = new Button();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            button4 = new Button();
            comboBox1 = new ComboBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(107, 21);
            button3.Name = "button3";
            button3.Size = new Size(106, 29);
            button3.TabIndex = 6;
            button3.Text = "verwijderen";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DeleteGoal;
            // 
            // button1
            // 
            button1.Location = new Point(12, 21);
            button1.Name = "button1";
            button1.Size = new Size(89, 29);
            button1.TabIndex = 4;
            button1.Text = "toevoegen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateGoal;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(12, 56);
            listView1.Name = "listView1";
            listView1.Size = new Size(783, 419);
            listView1.TabIndex = 7;
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
            // button4
            // 
            button4.Location = new Point(219, 21);
            button4.Name = "button4";
            button4.Size = new Size(92, 29);
            button4.TabIndex = 9;
            button4.Text = "subdoelen";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OpenSubGoals;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "te doen", "bezig", "afgerond" });
            comboBox1.Location = new Point(547, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 28);
            comboBox1.TabIndex = 10;
            // 
            // button5
            // 
            button5.Location = new Point(686, 21);
            button5.Name = "button5";
            button5.Size = new Size(109, 29);
            button5.TabIndex = 11;
            button5.Text = "Update status";
            button5.UseVisualStyleBackColor = true;
            button5.Click += UpdateStatus;
            // 
            // GoalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 487);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "GoalForm";
            Text = "GoalForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button1;
        private ListView listView1;
        private Button button4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ComboBox comboBox1;
        private Button button5;
    }
}