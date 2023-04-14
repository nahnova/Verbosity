using System;
using System.Windows.Forms;
using FBS.Repository;

namespace FeedbackSysteem
{
    public partial class AddGoalForm : Form
    {
        public AddGoalForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GoalRepo goalRepo = new GoalRepo();

            try
            {
                int goalID = 0;
                int studentID = Int32.Parse(textBox1.Text);
                string priority = textBox2.Text;
                string createdGoal = textBox3.Text;
                string time = textBox4.Text;

                goalRepo.AddGoal(goalID, studentID, priority, createdGoal, time);
                Close();
            }
            catch
            {
                string failedCreate = "Failed to create the goal!";
                MessageBox.Show(failedCreate);
            }
        }
    }
}
