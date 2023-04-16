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

namespace FeedbackSysteem
{
    public partial class StudentProfilePage : Form
    {
        public int StudentId { get; set; }
        public StudentProfilePage(int id)
        {
            InitializeComponent();

            StudentId = id;
            StudentsRepo studentsRepo = new StudentsRepo();
            Student student = studentsRepo.GetSinglestudentByID(StudentId);

            label5.AutoSize = false;
            label5.Dock = DockStyle.Top;
            label5.Text = "Welkom " + student.FirstName + " " + student.LastName + "";

            textBox1.Text = student.FirstName;
            textBox2.Text = student.LastName;
            textBox3.Text = student.Email;
            textBox4.Text = student.Gender;

        }

        private void updateProfile(object sender, EventArgs e)
        {
            StudentsRepo studentsRepo = new StudentsRepo();
            studentsRepo.UpdateStudent(StudentId, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            string updatedFields = "Profiel geupdate";
            MessageBox.Show(updatedFields);
        }
    }
}
