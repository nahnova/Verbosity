using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackSysteem
{
    public partial class Home : Form
    {
        public int UserID { get; set; }

        public Home(int id)
        {
            InitializeComponent();
            UserID = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoalForm goalForm = new GoalForm(UserID);
            goalForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage(UserID);
            profilePage.ShowDialog();
        }
    }
}
