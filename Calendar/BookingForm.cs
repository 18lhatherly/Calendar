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
    public partial class BookingForm : Form
    {
        int selectedPriority = -1;
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            
        }

        private void Navbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void urgentBtn_Click(object sender, EventArgs e)
        {
            selectedPriority = 1;
            MessageBox.Show(selectedPriority.ToString());
        }

        private void generalBtn_Click(object sender, EventArgs e)
        {
            selectedPriority = 2;
            MessageBox.Show(selectedPriority.ToString());
        }

        private void friendBtn_Click(object sender, EventArgs e)
        {
            selectedPriority = 3;
            MessageBox.Show(selectedPriority.ToString());
        }

        private void schoolBtn_Click(object sender, EventArgs e)
        {
            selectedPriority = 2;
            MessageBox.Show(selectedPriority.ToString());
        }

        private void otherBtn_Click(object sender, EventArgs e)
        {
            selectedPriority = 3;
            MessageBox.Show(selectedPriority.ToString());
        }
    }
}
