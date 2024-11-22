namespace Calendar
{
    public partial class TeacherCalendar : Form
    {
        public TeacherCalendar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            PopulateDataGridView();
            this.teacherSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            weekCalendar.RowHeadersWidth = 200;
            for (int i = 0; i < 5; i++)
            {
                this.weekCalendar.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            PRQueue<string> myPriorityQueue = new PRQueue<string>();
        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("u clicked me");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void PopulateDataGridView()
        {
            string[] rowb4school = { " ", " ", " ",
            " ", " " };
            string[] row0 = { " ", "Meeting Astrid", " ",
            "Lesson", "Lesson" };
            string[] rowbreak = { "Break", "Break", "Break",
            "Break", "Break" };
            string[] row1 = { "Lesson", " ", "Meeting Zaryaab",
            " ", "Personal profile meeting" };
            string[] row2 = { "Training day", " ", "Lesson",
            "Lesson", "Meeting Astrid" };
            string[] rowlunch = { "Lunch", "Lunch", "Lunch",
            "Lunch", "Lunch" };
            string[] row3 = { " ", "Lesson", "Meeting Thomas",
            " ", "Teacher meeting" };
            string[] row4 = { "Meeting Chloe", " ", "Lesson",
            " ", "Psychedelic Jungle party" };
            string[] rowafterschool = { " ", " ", " ",
            " ", " " };

            weekCalendar.Rows.Add(rowb4school);
            weekCalendar.Rows.Add(row0);
            weekCalendar.Rows.Add(rowbreak);
            weekCalendar.Rows.Add(row1);
            weekCalendar.Rows.Add(row2);
            weekCalendar.Rows.Add(rowlunch);
            weekCalendar.Rows.Add(row3);
            weekCalendar.Rows.Add(row4);
            weekCalendar.Rows.Add(rowafterschool);


            weekCalendar.ReadOnly = true;
            weekCalendar.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            DateTime localDate = DateTime.Now;
            int dayOfWeek = Convert.ToInt32(localDate.DayOfWeek);
            string time = Convert.ToString(localDate.ToShortTimeString());
            int totalTime = 0;
            int timeIndex = 0;


            totalTime = (Convert.ToInt32(time.Substring(0, 2)) * 100) + Convert.ToInt32(time.Substring(3, 2));

            //MessageBox.Show(Convert.ToString(totalTime));
            if (totalTime < 900)
            {
                timeIndex = 0;
            }
            if (totalTime < 1000 && totalTime > 900)
            {
                timeIndex = 1;
            }
            else if (totalTime < 1020 && totalTime > 1000)
            {
                timeIndex = 2;
            }
            else if (totalTime < 1120 && totalTime > 1020)
            {
                timeIndex = 3;
            }
            else if (totalTime < 1220 && totalTime > 1120)
            {
                timeIndex = 4;
            }
            else if (totalTime < 1315 && totalTime > 1220)
            {
                timeIndex = 5;
            }
            else if (totalTime < 1415 && totalTime > 1315)
            {
                timeIndex = 6;
            }
            else if (totalTime < 1515 && totalTime > 1415)
            {
                timeIndex = 7;
            }
            else if (totalTime < 1745 && totalTime > 1515)
            {
                timeIndex = 8;
            }
            else
            {
                timeIndex = -1;
            }

            if (timeIndex == -1)
            {
                weekCalendar.Rows[0].Cells[0].Style.BackColor = Color.White;
            }
            else
            {
                //dataGridView1.Rows[timeIndex].Cells[dayOfWeek - 1].Style.BackColor = Color.LightGray;
            }



            // for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            // {
            //    dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            //}
            weekCalendar.Rows[0].HeaderCell.Value = "Before School";
            weekCalendar.Rows[1].HeaderCell.Value = "Period 1";
            weekCalendar.Rows[2].HeaderCell.Value = "Break";
            weekCalendar.Rows[3].HeaderCell.Value = "Period 2";
            weekCalendar.Rows[4].HeaderCell.Value = "Period 3";
            weekCalendar.Rows[5].HeaderCell.Value = "Lunch";
            weekCalendar.Rows[6].HeaderCell.Value = "Period 4";
            weekCalendar.Rows[7].HeaderCell.Value = "Period 5";
            weekCalendar.Rows[8].HeaderCell.Value = "After School";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            Students studentsForm = new Students();
            studentsForm.Show();
        }
    }
}