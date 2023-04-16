using FBS.Repository;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FeedbackSysteem
{
    public partial class TeacherGoals : Form
    {
        public int SelectedGoalId { get; set; }

        public int TeacherId { get; set; }

        public TeacherGoals(int id)
        {
            InitializeComponent();
            TeacherId = id;
        }
        private void SelectStudent(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            GoalRepo goalRepo = new GoalRepo();
            goalRepo.goals.Clear();
            goalRepo.GetGoalsFromDatabase(Int32.Parse(textBox1.Text));
            foreach (Goal goal in goalRepo.goals)
            {
                ListViewItem goalItem = new ListViewItem(goal.ID.ToString());
                goalItem.SubItems.Add(goal.StudentID.ToString());
                goalItem.SubItems.Add(goal.CreatedGoal.ToString());
                goalItem.SubItems.Add(goal.Priority.ToString());
                goalItem.SubItems.Add(goal.Time.ToString());
                goalItem.SubItems.Add(goal.Status.ToString());
                listView1.Items.Add(goalItem);
            }
        }

        private void OpenSubGoals(object sender, EventArgs e)
        {
            StudentSubGoalOverview subGoalsForm = new StudentSubGoalOverview(SelectedGoalId);
            subGoalsForm.ShowDialog();
        }

        private void SelectListviewId(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                SelectedGoalId = Int32.Parse(listView1.SelectedItems[0].Text);
            }
        }

        private void OpenFeedbackForm(object sender, EventArgs e)
        {
            TeacherAddGoalFeedback teacherFeedbackForm = new TeacherAddGoalFeedback(TeacherId, Int32.Parse(textBox1.Text), SelectedGoalId);
            teacherFeedbackForm.ShowDialog();
        }
    }
}
