namespace FeedbackSysteem
{
    partial class SubGoalsForm
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(12, 127);
            listView1.Name = "listView1";
            listView1.Size = new Size(717, 381);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "SubgoalId";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "GoalId";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Subgoal";
            columnHeader3.Width = 600;
            // 
            // button1
            // 
            button1.Location = new Point(328, 32);
            button1.Name = "button1";
            button1.Size = new Size(201, 29);
            button1.TabIndex = 1;
            button1.Text = "Add subgoal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateSubGoal;
            // 
            // button2
            // 
            button2.Location = new Point(328, 67);
            button2.Name = "button2";
            button2.Size = new Size(201, 29);
            button2.TabIndex = 2;
            button2.Text = "Delete subgoal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DeleteSubGoal;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 109);
            textBox1.TabIndex = 3;
            // 
            // SubGoalsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 520);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "SubGoalsForm";
            Text = "SubGoalsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}