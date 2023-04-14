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
    public partial class SubGoalsForm : Form
    {
        public int ID { get; set; }
        public SubGoalsForm(int Id)
        {
            InitializeComponent();
            ID = Id;
            Refresh_Listview();
        }

        public void Refresh_Listview()
        {
            try
            {
                listView1.Items.Clear();

                SubGoalRepo subGoalRepo = new SubGoalRepo();
                subGoalRepo.subGoals.Clear();
                subGoalRepo.GetSubGoalsFromDatabase(ID);
                foreach (SubGoal subGoal in subGoalRepo.subGoals)
                {
                    ListViewItem goalItem = new ListViewItem(subGoal.ID.ToString());
                    goalItem.SubItems.Add(subGoal.GoalID.ToString());
                    goalItem.SubItems.Add(subGoal.Subgoal.ToString());
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
            SubGoalRepo subGoalRepo = new SubGoalRepo();

            try
            {
                int goalId = ID;
                string subgoal = textBox1.Text;

                subGoalRepo.AddSubGoal(goalId, subgoal);
                Close();
            }
            catch (Exception ex)
            {
                string failedCreate = "Failed to create the subgoal!" + ex.Message;
                MessageBox.Show(failedCreate);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubGoalRepo subGoalRepo = new SubGoalRepo();

            try
            {
                int subgoalID = Int32.Parse(textBox1.Text);

                subGoalRepo.DeleteSubGoal(subgoalID);
                Close();
            }
            catch (Exception ex)
            {
                string failedCreate = "Failed to delete the subgoal!" + ex.Message;
                MessageBox.Show(failedCreate);
            }

        }
    }
}
