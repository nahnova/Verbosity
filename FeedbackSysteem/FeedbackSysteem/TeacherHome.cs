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

        private void OpenStudentGoals(object sender, EventArgs e)
        {
            TeacherGoals teacherGoals = new TeacherGoals(TeacherID);
            teacherGoals.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TeacherProfilePage teacherProfilePage = new TeacherProfilePage(TeacherID);
            teacherProfilePage.ShowDialog();
        }
    }
}
