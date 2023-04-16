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
    public partial class TeacherFeedbackOverview : Form
    {

        private FeedbackRepo feedbackRepo = new FeedbackRepo();
        public int TeacherID { get; set; }
        public int SelectedFeedbackID { get; set; }

        public TeacherFeedbackOverview(int id)
        {
            InitializeComponent();
            LoadFeedbackListView();
            TeacherID = id;
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

        private void AddFeedback(object sender, EventArgs e)
        {
            TeacherAddFeedback teacherAddFeedback = new TeacherAddFeedback(TeacherID, comboBox1.Text);
            teacherAddFeedback.ShowDialog();
            LoadFeedbackListView();
        }

        private void DeleteFeedback(object sender, EventArgs e)
        {
            FeedbackRepo feedbackRepo = new FeedbackRepo();
            feedbackRepo.DeleteFeedback(SelectedFeedbackID);
            LoadFeedbackListView();
        }

        private void SelectListviewId(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                SelectedFeedbackID = Int32.Parse(listView1.SelectedItems[0].Text);
            }
        }
    }
}
