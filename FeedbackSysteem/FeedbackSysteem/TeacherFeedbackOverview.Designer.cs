namespace FeedbackSysteem
{
    partial class TeacherFeedbackOverview
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
            columnHeader0 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new Point(3, 54);
            listView1.Name = "listView1";
            listView1.Size = new Size(1102, 633);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += SelectListviewId;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "Id";
            columnHeader0.Width = 40;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DocentID";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "StudentID";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Datum";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Vak";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Feedback";
            columnHeader5.Width = 525;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Type";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "DoelID";
            // 
            // button1
            // 
            button1.Location = new Point(160, 12);
            button1.Name = "button1";
            button1.Size = new Size(125, 36);
            button1.TabIndex = 2;
            button1.Text = "Toevoegen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddFeedback;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Vak", "SLB", "Toets", "Algemeen" });
            comboBox1.Location = new Point(3, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(291, 12);
            button2.Name = "button2";
            button2.Size = new Size(125, 36);
            button2.TabIndex = 4;
            button2.Text = "Verwijderen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DeleteFeedback;
            // 
            // TeacherFeedbackOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 690);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "TeacherFeedbackOverview";
            Text = "TeacherFeedbackOverview";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
    }
}