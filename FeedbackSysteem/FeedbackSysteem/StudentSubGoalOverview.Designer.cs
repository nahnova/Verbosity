namespace FeedbackSysteem
{
    partial class StudentSubGoalOverview
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
            columnHeader4 = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(12, 95);
            listView1.Name = "listView1";
            listView1.Size = new Size(717, 413);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "SubdoelId";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "DoelId";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Subdoel";
            columnHeader3.Width = 470;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Status";
            columnHeader4.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(347, 16);
            button1.Name = "button1";
            button1.Size = new Size(201, 29);
            button1.TabIndex = 1;
            button1.Text = "Subdoel toevoegen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CreateSubGoal;
            // 
            // button2
            // 
            button2.Location = new Point(347, 51);
            button2.Name = "button2";
            button2.Size = new Size(201, 29);
            button2.TabIndex = 2;
            button2.Text = "Subdoel verwijderen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DeleteSubGoal;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 77);
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
        private ColumnHeader columnHeader4;
    }
}