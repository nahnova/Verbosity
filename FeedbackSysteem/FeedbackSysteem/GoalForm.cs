using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using FBS.Repository;

namespace FeedbackSysteem
{
    public partial class GoalForm : Form
    {
        public int UserID { get; set; }
        public int SelectedGoalId { get; set; }

        public GoalForm(int id)
        {
            InitializeComponent();
            UserID = id;
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
                    goalItem.SubItems.Add(goal.CreatedGoal.ToString());
                    goalItem.SubItems.Add(goal.Priority.ToString());
                    goalItem.SubItems.Add(goal.Time.ToString());
                    goalItem.SubItems.Add(goal.Status.ToString());
                    listView1.Items.Add(goalItem);
                }
            }
            catch 
            {
                MessageBox.Show("Kan doelen niet laden!");
            }
        }

        private void CreateGoal(object sender, EventArgs e)
        {
            AddGoalForm addGoalForm = new AddGoalForm(UserID);
            addGoalForm.ShowDialog();
            Refresh_Listview();
        }

        private void DeleteGoal(object sender, EventArgs e)
        {
            GoalRepo goalRepo = new GoalRepo();
            try
            {
                goalRepo.DeleteGoal(SelectedGoalId);
                MessageBox.Show("Doel " + SelectedGoalId + " verwijderd");
                Refresh_Listview();
            }
            catch
            {
                MessageBox.Show("Kan doel niet verwijderen!");
            }
        }

        private void OpenSubGoals(object sender, EventArgs e)
        {
            SubGoalsForm subGoalsForm = new SubGoalsForm(SelectedGoalId);
            subGoalsForm.ShowDialog();
            Refresh_Listview();
        }

        private void UpdateStatus(object sender, EventArgs e)
        {
            GoalRepo goalRepo = new GoalRepo();
            try
            {
                goalRepo.UpdateGoalStatus(SelectedGoalId, comboBox1.Text);
                MessageBox.Show("status van doel " + SelectedGoalId + " geupdate");
                Refresh_Listview();
                if(comboBox1.Text == "afgerond")
                {
                    SubGoalRepo subGoalRepo = new SubGoalRepo();
                    subGoalRepo.UpdateSubGoalStatus(SelectedGoalId, comboBox1.Text);
                }
            }
            catch
            {
                MessageBox.Show("kan status niet updaten!");
            }
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