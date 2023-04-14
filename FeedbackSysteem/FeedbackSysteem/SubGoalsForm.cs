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
    public partial class SubGoalsForm : Form
    {
        public int ID { get; set; }
        public SubGoalsForm(int Id)
        {
            InitializeComponent();
            ID = Id;
        }
    }
}
