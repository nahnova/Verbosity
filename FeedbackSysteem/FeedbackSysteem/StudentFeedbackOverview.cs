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
    public partial class StudentFeedbackOverview : Form
    {

        private FeedbackRepo feedbackRepo = new FeedbackRepo();

        public StudentFeedbackOverview()
        {
            InitializeComponent();

            // Load feedback list view
            LoadFeedbackListView();
        }

        private void LoadFeedbackListView()
        {
            // Clear the list view items
            listView1.Items.Clear();

            // Get feedback from the database
            feedbackRepo.GetFeedbackFromDatabase();

            // Loop through the feedback and add to list view
            foreach (Feedback feedback in feedbackRepo.feedbackList)
            {
                ListViewItem item = new ListViewItem(feedback.ID.ToString());
                item.SubItems.Add(feedback.TeacherID.ToString());
                item.SubItems.Add(feedback.StudentID.ToString());
                item.SubItems.Add(feedback.Date.ToShortDateString());
                item.SubItems.Add(feedback.Course);
                item.SubItems.Add(feedback.GivenFeedback);
                item.SubItems.Add(feedback.Type);
                item.SubItems.Add(feedback.GoalID.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}