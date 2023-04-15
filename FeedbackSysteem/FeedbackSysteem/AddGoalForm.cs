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
                int studentID = Int32.Parse(textBox1.Text);
                string goal = textBox2.Text;
                string priority = comboBox1.Text;
                string time = textBox4.Text;

                goalRepo.AddGoal(studentID, priority, goal, time, "te doen");
                Close();
            }
            catch (Exception ex)
            {
                string failedCreate = "Failed to create the goal!" + ex.Message;
                MessageBox.Show(failedCreate);
            }
        }
    }
}
