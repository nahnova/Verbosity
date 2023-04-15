using System.Data.SqlClient;
using System.Data;
using FBS.DataAccess;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using FBS.Repository;

namespace FeedbackSysteem
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;

        SqlDataReader dr;

        public int UserID { get; set; }

        private FeedbackCollectionDBDataAccess iDB { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.iDB = new FeedbackCollectionDBDataAccess();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                cmd = new SqlCommand("SELECT * FROM Student WHERE email= '" + textBox1.Text + "' AND password= '" + textBox2.Text + "' ", iDB.Sqlcon);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    UserID = Convert.ToInt32(dr["id"]);
                    dr.Close();
                    this.Hide();
                    Home home = new Home(UserID);
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Vul een correcte gebruiker in!");
                }
            }
            else
            {
                MessageBox.Show("Vul de velden in!");
            }
        }
    }
}
