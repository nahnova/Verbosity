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
            try
            {
                Goal goal = new Goal(0,0, textBox1.Text, textBox2.Text, textBox3.Text);
                FBS.Repository.UsersRepo.AddGoal(goal);
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
