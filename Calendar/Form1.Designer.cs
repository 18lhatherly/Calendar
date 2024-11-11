namespace Calendar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Navbar = new Panel();
            studentsBtn = new Button();
            meetingsBtn = new Button();
            calendarBtn = new Button();
            dashboardBtn = new Button();
            dataGridView1 = new DataGridView();
            Monday = new DataGridViewTextBoxColumn();
            tuesday = new DataGridViewTextBoxColumn();
            wednesday = new DataGridViewTextBoxColumn();
            thursday = new DataGridViewTextBoxColumn();
            friday = new DataGridViewTextBoxColumn();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Monday, tuesday, wednesday, thursday, friday });
            dataGridView1.Location = new Point(482, 90);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.Size = new Size(1084, 607);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 19.875F, FontStyle.Bold);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(482, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 32);
            label1.TabIndex = 2;
            label1.Text = "Laura Hatherly";
            label1.Click += label1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(233, 29);
            monthCalendar1.Margin = new Padding(5, 4, 5, 4);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Miss Brown", "Mr Honey", "Ms Moses", "Mr Moss", "Mr Jones" });
            comboBox1.Location = new Point(233, 231);
            comboBox1.Margin = new Padding(2, 1, 2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(234, 197);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(50, 5, 50, 5);
            label2.Size = new Size(220, 25);
            label2.TabIndex = 5;
            label2.Text = "See teacher timetable";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(245, 261);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(65, 5, 65, 5);
            label3.Size = new Size(193, 25);
            label3.TabIndex = 6;
            label3.Text = "Categories";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Brown;
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(245, 297);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(70, 5, 70, 5);
            label4.Size = new Size(194, 25);
            label4.TabIndex = 7;
            label4.Text = "Priority 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Goldenrod;
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(245, 332);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(70, 5, 70, 5);
            label5.Size = new Size(194, 25);
            label5.TabIndex = 8;
            label5.Text = "Priority 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.ForestGreen;
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(245, 366);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(70, 5, 70, 5);
            label6.Size = new Size(194, 25);
            label6.TabIndex = 9;
            label6.Text = "Priority 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MediumPurple;
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(245, 403);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(58, 5, 58, 5);
            label7.Size = new Size(194, 25);
            label7.TabIndex = 10;
            label7.Text = "Staff meeting";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlDarkDark;
            label8.ForeColor = SystemColors.Desktop;
            label8.Location = new Point(245, 439);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(79, 5, 79, 5);
            label8.Size = new Size(195, 25);
            label8.TabIndex = 11;
            label8.Text = "Other";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveBorder;
            label9.ForeColor = SystemColors.Desktop;
            label9.Location = new Point(245, 477);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Padding = new Padding(79, 5, 79, 5);
            label9.Size = new Size(196, 25);
            label9.TabIndex = 12;
            label9.Text = "Guide";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 733);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(Navbar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Navbar;
        private Button dashboardBtn;
        private Button calendarBtn;
        private Button studentsBtn;
        private Button meetingsBtn;
        private DataGridView dataGridView1;
        private Label label1;
        private MonthCalendar monthCalendar1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn Monday;
        private DataGridViewTextBoxColumn tuesday;
        private DataGridViewTextBoxColumn wednesday;
        private DataGridViewTextBoxColumn thursday;
        private DataGridViewTextBoxColumn friday;
    }
}