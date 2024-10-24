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
            Navbar.Location = new Point(6, 9);
            Navbar.Margin = new Padding(6);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(371, 949);
            Navbar.TabIndex = 0;
            // 
            // studentsBtn
            // 
            studentsBtn.BackColor = Color.Transparent;
            studentsBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            studentsBtn.Image = (Image)resources.GetObject("studentsBtn.Image");
            studentsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            studentsBtn.Location = new Point(-1, 466);
            studentsBtn.Margin = new Padding(6);
            studentsBtn.Name = "studentsBtn";
            studentsBtn.Padding = new Padding(10, 0, 0, 0);
            studentsBtn.Size = new Size(373, 73);
            studentsBtn.TabIndex = 2;
            studentsBtn.Text = "Students";
            studentsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            studentsBtn.UseMnemonic = false;
            studentsBtn.UseVisualStyleBackColor = false;
            // 
            // meetingsBtn
            // 
            meetingsBtn.BackColor = Color.Transparent;
            meetingsBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            meetingsBtn.Image = (Image)resources.GetObject("meetingsBtn.Image");
            meetingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            meetingsBtn.Location = new Point(-1, 396);
            meetingsBtn.Margin = new Padding(6);
            meetingsBtn.Name = "meetingsBtn";
            meetingsBtn.Padding = new Padding(10, 0, 0, 0);
            meetingsBtn.Size = new Size(373, 73);
            meetingsBtn.TabIndex = 2;
            meetingsBtn.Text = "Meetings";
            meetingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            meetingsBtn.UseMnemonic = false;
            meetingsBtn.UseVisualStyleBackColor = false;
            // 
            // calendarBtn
            // 
            calendarBtn.BackColor = Color.Transparent;
            calendarBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            calendarBtn.Image = (Image)resources.GetObject("calendarBtn.Image");
            calendarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            calendarBtn.Location = new Point(-1, 325);
            calendarBtn.Margin = new Padding(6);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Padding = new Padding(10, 0, 0, 0);
            calendarBtn.Size = new Size(373, 73);
            calendarBtn.TabIndex = 1;
            calendarBtn.Text = "Calendar";
            calendarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            calendarBtn.UseMnemonic = false;
            calendarBtn.UseVisualStyleBackColor = false;
            calendarBtn.Click += button1_Click_1;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.Transparent;
            dashboardBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(-1, 254);
            dashboardBtn.Margin = new Padding(6);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(10, 0, 0, 0);
            dashboardBtn.Size = new Size(373, 73);
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
            dataGridView1.Location = new Point(746, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1089, 704);
            dataGridView1.TabIndex = 1;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1993, 960);
            Controls.Add(dataGridView1);
            Controls.Add(Navbar);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Navbar;
        private Button dashboardBtn;
        private Button calendarBtn;
        private Button studentsBtn;
        private Button meetingsBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Monday;
        private DataGridViewTextBoxColumn tuesday;
        private DataGridViewTextBoxColumn wednesday;
        private DataGridViewTextBoxColumn thursday;
        private DataGridViewTextBoxColumn friday;
    }
}