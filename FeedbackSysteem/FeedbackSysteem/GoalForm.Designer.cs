namespace FeedbackSysteem
{
    partial class GoalForm
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
            button2 = new Button();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button4 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(245, 41);
            button3.Name = "button3";
            button3.Size = new Size(106, 29);
            button3.TabIndex = 6;
            button3.Text = "Delete goal";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DeleteGoal;
            // 
            // button2
            // 
            button2.Location = new Point(131, 40);
            button2.Name = "button2";
            button2.Size = new Size(108, 29);
            button2.TabIndex = 5;
            button2.Text = "Update goal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += UpdateGoal;
            // 
            // button1
            // 
            button1.Location = new Point(27, 40);
            button1.Name = "button1";
            button1.Size = new Size(98, 29);
            button1.TabIndex = 4;
            button1.Text = "Add goal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateGoal;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.Location = new Point(27, 88);
            listView1.Name = "listView1";
            listView1.Size = new Size(651, 387);
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
            columnHeader3.Text = "Feedback";
            columnHeader3.Width = 350;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "prioriteit";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "tijd";
            // 
            // button4
            // 
            button4.Location = new Point(544, 38);
            button4.Name = "button4";
            button4.Size = new Size(134, 29);
            button4.TabIndex = 9;
            button4.Text = "Open subgoals";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OpenSubGoals;
            // 
            // GoalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 487);
            Controls.Add(button4);
            Controls.Add(listView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "GoalForm";
            Text = "GoalForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private Button button4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}