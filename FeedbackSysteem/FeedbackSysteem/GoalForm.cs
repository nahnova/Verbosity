using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using FBS.Repository;

namespace FeedbackSysteem
{
    public partial class GoalForm : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddGoalForm addGoalForm = new AddGoalForm();
            addGoalForm.ShowDialog();
            Refresh_Listview();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                string emptyId = "Please fill in a Id";
                MessageBox.Show(emptyId);
            }
            else
            {
                SubGoalsForm subGoalsForm = new SubGoalsForm(Int32.Parse(textBox1.Text));
                subGoalsForm.ShowDialog();
                Refresh_Listview();
            }
        }
    }
}