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
            Navbar.Location = new Point(7, 7);
            Navbar.Margin = new Padding(6);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(371, 1469);
            Navbar.TabIndex = 0;
            // 
            // studentsBtn
            // 
            studentsBtn.BackColor = SystemColors.Control;
            studentsBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            studentsBtn.Image = (Image)resources.GetObject("studentsBtn.Image");
            studentsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            studentsBtn.Location = new Point(-2, 464);
            studentsBtn.Margin = new Padding(6);
            studentsBtn.Name = "studentsBtn";
            studentsBtn.Padding = new Padding(10, 0, 0, 0);
            studentsBtn.Size = new Size(381, 73);
            studentsBtn.TabIndex = 2;
            studentsBtn.Text = "Students";
            studentsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            studentsBtn.UseMnemonic = false;
            studentsBtn.UseVisualStyleBackColor = false;
            // 
            // meetingsBtn
            // 
            meetingsBtn.BackColor = SystemColors.Control;
            meetingsBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            meetingsBtn.Image = (Image)resources.GetObject("meetingsBtn.Image");
            meetingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            meetingsBtn.Location = new Point(-7, 393);
            meetingsBtn.Margin = new Padding(6);
            meetingsBtn.Name = "meetingsBtn";
            meetingsBtn.Padding = new Padding(10, 0, 0, 0);
            meetingsBtn.Size = new Size(380, 73);
            meetingsBtn.TabIndex = 2;
            meetingsBtn.Text = "Meetings";
            meetingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            meetingsBtn.UseMnemonic = false;
            meetingsBtn.UseVisualStyleBackColor = false;
            // 
            // calendarBtn
            // 
            calendarBtn.BackColor = Color.MediumPurple;
            calendarBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            calendarBtn.Image = (Image)resources.GetObject("calendarBtn.Image");
            calendarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            calendarBtn.Location = new Point(-3, 323);
            calendarBtn.Margin = new Padding(6);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Padding = new Padding(10, 0, 0, 0);
            calendarBtn.Size = new Size(382, 73);
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
            dashboardBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(-6, 255);
            dashboardBtn.Margin = new Padding(6);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(10, 0, 0, 0);
            dashboardBtn.Size = new Size(380, 73);
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
            dataGridView1.Location = new Point(896, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 100;
            dataGridView1.Size = new Size(1745, 965);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Monday
            // 
            Monday.HeaderText = "Monday";
            Monday.MinimumWidth = 10;
            Monday.Name = "Monday";
            Monday.Width = 300;
            // 
            // tuesday
            // 
            tuesday.HeaderText = "Tuesday";
            tuesday.MinimumWidth = 10;
            tuesday.Name = "tuesday";
            tuesday.Width = 300;
            // 
            // wednesday
            // 
            wednesday.HeaderText = "Wednesday";
            wednesday.MinimumWidth = 10;
            wednesday.Name = "wednesday";
            wednesday.Width = 300;
            // 
            // thursday
            // 
            thursday.HeaderText = "Thursday";
            thursday.MinimumWidth = 10;
            thursday.Name = "thursday";
            thursday.Width = 300;
            // 
            // friday
            // 
            friday.HeaderText = "Friday";
            friday.MinimumWidth = 10;
            friday.Name = "friday";
            friday.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(896, 70);
            label1.Name = "label1";
            label1.Size = new Size(433, 62);
            label1.TabIndex = 2;
            label1.Text = "Laura Hatherly";
            label1.Click += label1_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(433, 61);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Miss Brown", "Mr Honey", "Ms Moses", "Mr Moss", "Mr Jones" });
            comboBox1.Location = new Point(432, 492);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(404, 40);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(435, 420);
            label2.Name = "label2";
            label2.Padding = new Padding(75, 10, 75, 10);
            label2.Size = new Size(397, 52);
            label2.TabIndex = 5;
            label2.Text = "See teacher timetable";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(450, 552);
            label3.Name = "label3";
            label3.Padding = new Padding(120, 10, 120, 10);
            label3.Size = new Size(367, 52);
            label3.TabIndex = 6;
            label3.Text = "Categories";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Brown;
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(450, 629);
            label4.Name = "label4";
            label4.Padding = new Padding(130, 10, 130, 10);
            label4.Size = new Size(369, 52);
            label4.TabIndex = 7;
            label4.Text = "Priority 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Goldenrod;
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(450, 703);
            label5.Name = "label5";
            label5.Padding = new Padding(130, 10, 130, 10);
            label5.Size = new Size(369, 52);
            label5.TabIndex = 8;
            label5.Text = "Priority 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.ForestGreen;
            label6.ForeColor = SystemColors.Desktop;
            label6.Location = new Point(450, 780);
            label6.Name = "label6";
            label6.Padding = new Padding(130, 10, 130, 10);
            label6.Size = new Size(369, 52);
            label6.TabIndex = 9;
            label6.Text = "Priority 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MediumPurple;
            label7.ForeColor = SystemColors.Desktop;
            label7.Location = new Point(451, 858);
            label7.Name = "label7";
            label7.Padding = new Padding(105, 10, 105, 10);
            label7.Size = new Size(368, 52);
            label7.TabIndex = 10;
            label7.Text = "Staff meeting";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ControlDarkDark;
            label8.ForeColor = SystemColors.Desktop;
            label8.Location = new Point(450, 938);
            label8.Name = "label8";
            label8.Padding = new Padding(150, 10, 150, 10);
            label8.Size = new Size(375, 52);
            label8.TabIndex = 11;
            label8.Text = "Other";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveBorder;
            label9.ForeColor = SystemColors.Desktop;
            label9.Location = new Point(448, 1027);
            label9.Name = "label9";
            label9.Padding = new Padding(150, 10, 150, 10);
            label9.Size = new Size(377, 52);
            label9.TabIndex = 12;
            label9.Text = "Guide";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2734, 1453);
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
            Margin = new Padding(6);
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
        private DataGridViewTextBoxColumn Monday;
        private DataGridViewTextBoxColumn tuesday;
        private DataGridViewTextBoxColumn wednesday;
        private DataGridViewTextBoxColumn thursday;
        private DataGridViewTextBoxColumn friday;
        private ComboBox comboBox1;
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