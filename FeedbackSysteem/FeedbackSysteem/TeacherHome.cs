using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class TeacherHome : Form
    {
        public int TeacherID { get; set; }

        public TeacherHome(int id)
        {
            InitializeComponent();
            TeacherID = id;
        }

        private void GoToTeacherGoals(object sender, EventArgs e)
        {
            TeacherGoals teacherGoals = new TeacherGoals(TeacherID);
            teacherGoals.ShowDialog();
        }

        private void GoToTeacherProfilePage(object sender, EventArgs e)
        {
            TeacherProfilePage teacherProfilePage = new TeacherProfilePage(TeacherID);
            teacherProfilePage.ShowDialog();
        }

        private void GoToFeedbackOverview(object sender, EventArgs e)
        {
            TeacherFeedbackOverview teacherFeedbackOverview = new TeacherFeedbackOverview(TeacherID);
            teacherFeedbackOverview.ShowDialog();
        }
    }
}
