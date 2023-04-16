namespace FeedbackSysteem
{
    partial class TeacherHome
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
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon;
            pictureBox1.Location = new Point(723, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += GoToTeacherProfilePage;
            // 
            // button3
            // 
            button3.Location = new Point(451, 49);
            button3.Name = "button3";
            button3.Size = new Size(134, 29);
            button3.TabIndex = 7;
            button3.Text = "Feedback";
            button3.UseVisualStyleBackColor = true;
            button3.Click += GoToFeedbackOverview;
            // 
            // button2
            // 
            button2.Location = new Point(311, 49);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 6;
            button2.Text = "Doelen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += GoToTeacherGoals;
            // 
            // button1
            // 
            button1.Location = new Point(171, 49);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 5;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // TeacherHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TeacherHome";
            Text = "TeacherHome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}