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
    public partial class StudentHome : Form
    {
        public int UserID { get; set; }

        public StudentHome(int id)
        {
            InitializeComponent();
            UserID = id;
        }

        private void GoToGoalOverview(object sender, EventArgs e)
        {
            StudentGoalOverview goalForm = new StudentGoalOverview(UserID);
            goalForm.ShowDialog();
        }

        private void GoToProfilePage(object sender, EventArgs e)
        {
            StudentProfilePage profilePage = new StudentProfilePage(UserID);
            profilePage.ShowDialog();
        }

        private void GoToFeedbackOverview(object sender, EventArgs e)
        {
            StudentFeedbackOverview studentFeedbackOverview = new StudentFeedbackOverview();
            studentFeedbackOverview.ShowDialog();
        }
    }
}
