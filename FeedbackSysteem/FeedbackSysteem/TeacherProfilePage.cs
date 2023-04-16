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
    public partial class TeacherProfilePage : Form
    {
        public int TeacherID { get; set; }
        public TeacherProfilePage(int id)
        {
            InitializeComponent();

            TeacherID = id;
            TeachersRepo teacherRepo = new TeachersRepo();
            Teacher teacher = teacherRepo.GetSingleTeacherByID(TeacherID);

            label5.AutoSize = false;
            label5.Dock = DockStyle.Top;
            label5.Text = "Welkom " + teacher.FirstName + " " + teacher.LastName + "";

            textBox1.Text = teacher.FirstName;
            textBox2.Text = teacher.LastName;
            textBox3.Text = teacher.Email;
            textBox4.Text = teacher.Phone;

        }

        private void updateProfile(object sender, EventArgs e)
        {
            TeachersRepo teacherRepo = new TeachersRepo();
            teacherRepo.UpdateTeacher(TeacherID, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            string updatedFields = "Profiel geupdate";
            MessageBox.Show(updatedFields);
        }
    }
}
