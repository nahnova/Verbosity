using FBS.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackSysteem
{
    public partial class TeacherAddFeedback : Form
    {
        public int TeacherID { get; set; }

        public string Type { get; set; }

        public TeacherAddFeedback(int teacherID, string type)
        {
            InitializeComponent();
            TeacherID = teacherID;
            Type = type;
        }

        private void SaveFeedback(object sender, EventArgs e)
        {
            FeedbackRepo feedbackRepo = new FeedbackRepo();

            try
            {
                int studentID = Int32.Parse(textBox2.Text);
                int teacherID = TeacherID;
                string feedback = textBox1.Text;
                string course = textBox3.Text;
                DateTime date = dateTimePicker1.Value.Date;
                string type = Type;
                int goalID = 0;

                feedbackRepo.AddFeedback(teacherID, studentID, date, course, feedback, type, goalID);
                Close();
            }
            catch
            {
                MessageBox.Show("kan doel niet maken!");
            }
        }
    }
}
