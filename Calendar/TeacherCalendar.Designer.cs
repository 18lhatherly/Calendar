namespace Calendar
{
    partial class TeacherCalendar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherCalendar));
            Navbar = new Panel();
            studentsBtn = new Button();
            meetingsBtn = new Button();
            calendarBtn = new Button();
            dashboardBtn = new Button();
            weekCalendar = new DataGridView();
            Monday = new DataGridViewTextBoxColumn();
            tuesday = new DataGridViewTextBoxColumn();
            wednesday = new DataGridViewTextBoxColumn();
            thursday = new DataGridViewTextBoxColumn();
            friday = new DataGridViewTextBoxColumn();
            teacherName = new Label();
            monthCalendar1 = new MonthCalendar();
            teacherSelector = new ComboBox();
            seeTeacherTimetable = new Label();
            categoriesTitle = new Label();
            Priority1 = new Label();
            Priority2 = new Label();
            Priority3 = new Label();
            staffMeeting = new Label();
            other = new Label();
            guideTitle = new Label();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weekCalendar).BeginInit();
            SuspendLayout();
            // 
            // Navbar
            // 
            Navbar.BackgroundImageLayout = ImageLayout.None;
            Navbar.Controls.Add(studentsBtn);
            Navbar.Controls.Add(meetingsBtn);
            Navbar.Controls.Add(calendarBtn);
            Navbar.Controls.Add(dashboardBtn);
            Navbar.Location = new Point(4, 3);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(200, 689);
            Navbar.TabIndex = 0;
            // 
            // studentsBtn
            // 
            studentsBtn.BackColor = SystemColors.Control;
            studentsBtn.Font = new Font("Calibri", 10F);
            studentsBtn.Image = (Image)resources.GetObject("studentsBtn.Image");
            studentsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            studentsBtn.Location = new Point(-1, 219);
            studentsBtn.Name = "studentsBtn";
            studentsBtn.Padding = new Padding(5, 0, 0, 0);
            studentsBtn.Size = new Size(205, 34);
            studentsBtn.TabIndex = 2;
            studentsBtn.Text = "Students";
            studentsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            studentsBtn.UseMnemonic = false;
            studentsBtn.UseVisualStyleBackColor = false;
            studentsBtn.Click += studentsBtn_Click;
            // 
            // meetingsBtn
            // 
            meetingsBtn.BackColor = SystemColors.Control;
            meetingsBtn.Font = new Font("Calibri", 10F);
            meetingsBtn.Image = (Image)resources.GetObject("meetingsBtn.Image");
            meetingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            meetingsBtn.Location = new Point(-2, 186);
            meetingsBtn.Name = "meetingsBtn";
            meetingsBtn.Padding = new Padding(5, 0, 0, 0);
            meetingsBtn.Size = new Size(206, 34);
            meetingsBtn.TabIndex = 2;
            meetingsBtn.Text = "Meetings";
            meetingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            meetingsBtn.UseMnemonic = false;
            meetingsBtn.UseVisualStyleBackColor = false;
            // 
            // calendarBtn
            // 
            calendarBtn.BackColor = Color.MediumPurple;
            calendarBtn.Font = new Font("Calibri", 10F);
            calendarBtn.Image = (Image)resources.GetObject("calendarBtn.Image");
            calendarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            calendarBtn.Location = new Point(-2, 153);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Padding = new Padding(5, 0, 0, 0);
            calendarBtn.Size = new Size(206, 34);
            calendarBtn.TabIndex = 1;
            calendarBtn.Text = "Calendar";
            calendarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            calendarBtn.UseMnemonic = false;
            calendarBtn.UseVisualStyleBackColor = false;
            calendarBtn.Click += button1_Click_1;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = SystemColors.Control;
            dashboardBtn.Font = new Font("Calibri", 10F);
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(-1, 119);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(5, 0, 0, 0);
            dashboardBtn.Size = new Size(205, 34);
            dashboardBtn.TabIndex = 0;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardBtn.UseMnemonic = false;
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += button1_Click;
            // 
            // weekCalendar
            // 
            weekCalendar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            weekCalendar.Columns.AddRange(new DataGridViewColumn[] { Monday, tuesday, wednesday, thursday, friday });
            weekCalendar.Location = new Point(482, 90);
            weekCalendar.Margin = new Padding(2, 1, 2, 1);
            weekCalendar.Name = "weekCalendar";
            weekCalendar.RowHeadersWidth = 82;
            weekCalendar.RowTemplate.Height = 100;
            weekCalendar.Size = new Size(1084, 607);
            weekCalendar.TabIndex = 1;
            // 
            // Monday
            // 
            Monday.HeaderText = "Monday";
            Monday.MinimumWidth = 10;
            Monday.Name = "Monday";
            Monday.Width = 200;
            // 
            // tuesday
            // 
            tuesday.HeaderText = "Tuesday";
            tuesday.MinimumWidth = 10;
            tuesday.Name = "tuesday";
            tuesday.Width = 200;
            // 
            // wednesday
            // 
            wednesday.HeaderText = "Wednesday";
            wednesday.MinimumWidth = 10;
            wednesday.Name = "wednesday";
            wednesday.Width = 200;
            // 
            // thursday
            // 
            thursday.HeaderText = "Thursday";
            thursday.MinimumWidth = 10;
            thursday.Name = "thursday";
            thursday.Width = 200;
            // 
            // friday
            // 
            friday.HeaderText = "Friday";
            friday.MinimumWidth = 10;
            friday.Name = "friday";
            friday.Width = 200;
            // 
            // teacherName
            // 
            teacherName.AutoSize = true;
            teacherName.Font = new Font("Consolas", 19.875F, FontStyle.Bold);
            teacherName.ForeColor = Color.Indigo;
            teacherName.Location = new Point(482, 29);
            teacherName.Name = "teacherName";
            teacherName.Size = new Size(224, 32);
            teacherName.TabIndex = 2;
            teacherName.Text = "Laura Hatherly";
            teacherName.Click += label1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(233, 29);
            monthCalendar1.Margin = new Padding(5, 4, 5, 4);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // teacherSelector
            // 
            teacherSelector.FormattingEnabled = true;
            teacherSelector.Items.AddRange(new object[] { "Miss Brown", "Mr Honey", "Ms Moses", "Mr Moss", "Mr Jones" });
            teacherSelector.Location = new Point(233, 229);
            teacherSelector.Name = "teacherSelector";
            teacherSelector.Size = new Size(221, 23);
            teacherSelector.TabIndex = 4;
            // 
            // seeTeacherTimetable
            // 
            seeTeacherTimetable.AutoSize = true;
            seeTeacherTimetable.BackColor = SystemColors.ActiveBorder;
            seeTeacherTimetable.ForeColor = SystemColors.Desktop;
            seeTeacherTimetable.Location = new Point(234, 197);
            seeTeacherTimetable.Margin = new Padding(2, 0, 2, 0);
            seeTeacherTimetable.Name = "seeTeacherTimetable";
            seeTeacherTimetable.Padding = new Padding(50, 5, 50, 5);
            seeTeacherTimetable.Size = new Size(220, 25);
            seeTeacherTimetable.TabIndex = 5;
            seeTeacherTimetable.Text = "See teacher timetable";
            // 
            // categoriesTitle
            // 
            categoriesTitle.AutoSize = true;
            categoriesTitle.BackColor = SystemColors.ActiveBorder;
            categoriesTitle.ForeColor = SystemColors.Desktop;
            categoriesTitle.Location = new Point(245, 261);
            categoriesTitle.Margin = new Padding(2, 0, 2, 0);
            categoriesTitle.Name = "categoriesTitle";
            categoriesTitle.Padding = new Padding(65, 5, 65, 5);
            categoriesTitle.Size = new Size(193, 25);
            categoriesTitle.TabIndex = 6;
            categoriesTitle.Text = "Categories";
            // 
            // Priority1
            // 
            Priority1.AutoSize = true;
            Priority1.BackColor = Color.Brown;
            Priority1.ForeColor = SystemColors.Desktop;
            Priority1.Location = new Point(245, 297);
            Priority1.Margin = new Padding(2, 0, 2, 0);
            Priority1.Name = "Priority1";
            Priority1.Padding = new Padding(70, 5, 70, 5);
            Priority1.Size = new Size(194, 25);
            Priority1.TabIndex = 7;
            Priority1.Text = "Priority 1";
            // 
            // Priority2
            // 
            Priority2.AutoSize = true;
            Priority2.BackColor = Color.Goldenrod;
            Priority2.ForeColor = SystemColors.Desktop;
            Priority2.Location = new Point(245, 332);
            Priority2.Margin = new Padding(2, 0, 2, 0);
            Priority2.Name = "Priority2";
            Priority2.Padding = new Padding(70, 5, 70, 5);
            Priority2.Size = new Size(194, 25);
            Priority2.TabIndex = 8;
            Priority2.Text = "Priority 2";
            // 
            // Priority3
            // 
            Priority3.AutoSize = true;
            Priority3.BackColor = Color.ForestGreen;
            Priority3.ForeColor = SystemColors.Desktop;
            Priority3.Location = new Point(245, 366);
            Priority3.Margin = new Padding(2, 0, 2, 0);
            Priority3.Name = "Priority3";
            Priority3.Padding = new Padding(70, 5, 70, 5);
            Priority3.Size = new Size(194, 25);
            Priority3.TabIndex = 9;
            Priority3.Text = "Priority 3";
            // 
            // staffMeeting
            // 
            staffMeeting.AutoSize = true;
            staffMeeting.BackColor = Color.MediumPurple;
            staffMeeting.ForeColor = SystemColors.Desktop;
            staffMeeting.Location = new Point(245, 403);
            staffMeeting.Margin = new Padding(2, 0, 2, 0);
            staffMeeting.Name = "staffMeeting";
            staffMeeting.Padding = new Padding(58, 5, 58, 5);
            staffMeeting.Size = new Size(194, 25);
            staffMeeting.TabIndex = 10;
            staffMeeting.Text = "Staff meeting";
            // 
            // other
            // 
            other.AutoSize = true;
            other.BackColor = SystemColors.ControlDarkDark;
            other.ForeColor = SystemColors.Desktop;
            other.Location = new Point(245, 439);
            other.Margin = new Padding(2, 0, 2, 0);
            other.Name = "other";
            other.Padding = new Padding(79, 5, 79, 5);
            other.Size = new Size(195, 25);
            other.TabIndex = 11;
            other.Text = "Other";
            // 
            // guideTitle
            // 
            guideTitle.AutoSize = true;
            guideTitle.BackColor = SystemColors.ActiveBorder;
            guideTitle.ForeColor = SystemColors.Desktop;
            guideTitle.Location = new Point(245, 477);
            guideTitle.Margin = new Padding(2, 0, 2, 0);
            guideTitle.Name = "guideTitle";
            guideTitle.Padding = new Padding(79, 5, 79, 5);
            guideTitle.Size = new Size(196, 25);
            guideTitle.TabIndex = 12;
            guideTitle.Text = "Guide";
            // 
            // TeacherCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 733);
            Controls.Add(guideTitle);
            Controls.Add(other);
            Controls.Add(staffMeeting);
            Controls.Add(Priority3);
            Controls.Add(Priority2);
            Controls.Add(Priority1);
            Controls.Add(categoriesTitle);
            Controls.Add(seeTeacherTimetable);
            Controls.Add(teacherSelector);
            Controls.Add(monthCalendar1);
            Controls.Add(teacherName);
            Controls.Add(weekCalendar);
            Controls.Add(Navbar);
            Margin = new Padding(6);
            Name = "TeacherCalendar";
            Text = "Calendar";
            Load += Form1_Load;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)weekCalendar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Navbar;
        private Button dashboardBtn;
        private Button calendarBtn;
        private Button studentsBtn;
        private Button meetingsBtn;
        private DataGridView weekCalendar;
        private Label teacherName;
        private MonthCalendar monthCalendar1;
        private ComboBox teacherSelector;
        private Label seeTeacherTimetable;
        private Label categoriesTitle;
        private Label Priority1;
        private Label Priority2;
        private Label Priority3;
        private Label staffMeeting;
        private Label other;
        private Label guideTitle;
        private DataGridViewTextBoxColumn Monday;
        private DataGridViewTextBoxColumn tuesday;
        private DataGridViewTextBoxColumn wednesday;
        private DataGridViewTextBoxColumn thursday;
        private DataGridViewTextBoxColumn friday;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}