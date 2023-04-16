using FBS.Repository;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedbackSysteem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterStudent(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBox3.Text != string.Empty || comboBox1.Text != string.Empty || textBox5.Text != string.Empty)
            {
                string firstName = textBox1.Text;
                string lastName = textBox2.Text;
                string email = textBox3.Text;
                string gender = comboBox1.Text;
                string password = textBox5.Text;

                StudentsRepo studentsRepo = new StudentsRepo();
                studentsRepo.AddStudent(firstName, lastName, email, gender, password);

                this.Close();
            }
            else
            {
                MessageBox.Show("Vul alle velden in!");
            }
        }
    }
}
