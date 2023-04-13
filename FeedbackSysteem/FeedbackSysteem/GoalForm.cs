namespace FeedbackSysteem
{
    public partial class GoalForm : Form
    {
        public GoalForm()
        {
            InitializeComponent();
        }

        public void Refresh_Listview()
        {
            try
            {
                listView1.Items.Clear();
                FBS.Repository.UsersRepo.goals.Clear();
                FBS.Repository.UsersRepo.GetGoals();
                foreach (Goal goal in FBS.Repository.UsersRepo.goals)
                {
                    /*ListViewItem item = new ListViewItem(product.Id.ToString());
                    item.SubItems.Add(product.Name);
                    item.SubItems.Add(product.BrandName);
                    item.SubItems.Add(product.Price);
                    item.SubItems.Add(product.Type);
                    listView1.Items.Add(item);*/
                }
            }
            catch
            {
                string failedLoad = "Failed to load the goals!";
                MessageBox.Show(failedLoad);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
