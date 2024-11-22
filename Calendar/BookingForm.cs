using Calendar.Models;
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
        private LoginSession loginSession;
        private IDataAccess dataAccess;
        private int selectedPriority = -1;
        //string studentName = "Laura";
        //PRQueue<int> myPriorityQueue = new PRQueue<int>();
        public BookingForm()
        {
            dataAccess = new DataAccessSQL();
            loginSession = new LoginSession();
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
            makeAllPurple();
            selectedPriority = 1;
            urgentBtn.BackColor = Color.Gray;
            //MessageBox.Show(selectedPriority.ToString());
        }

        private void generalBtn_Click(object sender, EventArgs e)
        {
            makeAllPurple();
            selectedPriority = 2;
            generalBtn.BackColor = Color.Gray;
            //MessageBox.Show(selectedPriority.ToString());
        }

        private void friendBtn_Click(object sender, EventArgs e)
        {
            makeAllPurple();
            selectedPriority = 3;
            friendBtn.BackColor = Color.Gray;
            //MessageBox.Show(selectedPriority.ToString());
        }

        private void schoolBtn_Click(object sender, EventArgs e)
        {
            makeAllPurple();
            selectedPriority = 2;
            schoolBtn.BackColor = Color.Gray;
            //MessageBox.Show(selectedPriority.ToString());
        }

        private void otherBtn_Click(object sender, EventArgs e)
        {
            makeAllPurple();
            selectedPriority = 3;
            otherBtn.BackColor = Color.Gray;
            //MessageBox.Show(selectedPriority.ToString());
        }

        private void notesBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            dataAccess.MakeStudentBooking(loginSession.StudentID, notesBox.Text, selectedPriority, "unscheduled");
        }
        private void makeAllPurple()
        {
            schoolBtn.BackColor = Color.MediumPurple;
            friendBtn.BackColor = Color.MediumPurple;
            urgentBtn.BackColor = Color.MediumPurple;
            generalBtn.BackColor = Color.MediumPurple;
            otherBtn.BackColor = Color.MediumPurple;
        }
    }
}
