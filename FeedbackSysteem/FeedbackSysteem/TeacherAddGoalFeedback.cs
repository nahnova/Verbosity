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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FeedbackSysteem
{
    public partial class TeacherAddGoalFeedback : Form
    {
        public int TeacherID { get; set; }

        public int StudentID { get; set; }

        public int GoalID { get; set; }

        public TeacherAddGoalFeedback(int teacherID, int studentID, int goalID)
        {
            InitializeComponent();
            TeacherID = teacherID;
            StudentID = studentID;
            GoalID = goalID;
        }

        private void SaveFeedback(object sender, EventArgs e)
        {
            FeedbackRepo feedbackRepo = new FeedbackRepo();

            try
            {
                int studentID = StudentID;
                int teacherID = TeacherID;
                string feedback = textBox1.Text;
                string course = "";
                DateTime date = dateTimePicker1.Value.Date;
                string type = "doel";
                int goalID = GoalID;

                feedbackRepo.AddFeedback(teacherID,studentID,date,course,feedback,type,goalID);
                Close();
            }
            catch
            {
                MessageBox.Show("kan doel niet maken!");
            }
        }
    }
}
