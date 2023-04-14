using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using FBS.Repository;

namespace FeedbackSysteem
{
    public partial class GoalForm : Form
    {
        public int SelectedGoalId { get; set; }

        public GoalForm()
        {
            InitializeComponent();
            Refresh_Listview();
        }

        public void Refresh_Listview()
        {
            try
            {
                listView1.Items.Clear();

                GoalRepo goalRepo = new GoalRepo();
                goalRepo.goals.Clear();
                goalRepo.GetGoalsFromDatabase();
                foreach (Goal goal in goalRepo.goals)
                {
                    ListViewItem goalItem = new ListViewItem(goal.ID.ToString());
                    goalItem.SubItems.Add(goal.StudentID.ToString());
                    goalItem.SubItems.Add(goal.Priority.ToString());
                    goalItem.SubItems.Add(goal.CreatedGoal.ToString());
                    goalItem.SubItems.Add(goal.Time.ToString());
                    listView1.Items.Add(goalItem);
                }
            }
            catch (Exception ex)
            {
                string failedLoad = "Failed to load the goals! Error: " + ex.Message;
                MessageBox.Show(failedLoad);
            }
        }

        private void CreateGoal(object sender, EventArgs e)
        {
            AddGoalForm addGoalForm = new AddGoalForm();
            addGoalForm.ShowDialog();
            Refresh_Listview();
        }

        private void UpdateGoal(object sender, EventArgs e)
        {

        }

        private void DeleteGoal(object sender, EventArgs e)
        {

        }

        private void OpenSubGoals(object sender, EventArgs e)
        {
            SubGoalsForm subGoalsForm = new SubGoalsForm(SelectedGoalId);
            subGoalsForm.ShowDialog();
            Refresh_Listview();
        }

        private void SelectListviewId(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                SelectedGoalId = Int32.Parse(listView1.SelectedItems[0].Text);
            }
        }
    }
}