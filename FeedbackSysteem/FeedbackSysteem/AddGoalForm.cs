using System;
using System.Windows.Forms;
using FBS.Repository;

namespace FeedbackSysteem
{
    public partial class AddGoalForm : Form
    {
        public int UserID { get; set; }
        public AddGoalForm(int id)
        {
            InitializeComponent();
            UserID = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GoalRepo goalRepo = new GoalRepo();

            try
            {
                int studentID = UserID;
                string goal = textBox2.Text;
                string priority = comboBox1.Text;
                string time = textBox4.Text;

                goalRepo.AddGoal(studentID, priority, goal, time, "te doen");
                Close();
            }
            catch
            {
                MessageBox.Show("kan doel niet maken!");
            }
        }
    }
}
