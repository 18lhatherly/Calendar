using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }
        private void Students_Load(object sender, EventArgs e)
        {

            studentList.Items.Add("Adam Hatherly");
            studentList.Items.Add("Laura Hatherly");
            studentList.Items.Add("Emma Hatherly");
            studentList.Items.Add("Luke Hatherly");
        }

        private void Navbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {

        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {

        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = studentList.Items[studentList.SelectedIndex].ToString();
            MessageBox.Show(i.ToString());
        }
    }
}
