namespace Calendar
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            addBookingTitle = new Label();
            Navbar = new Panel();
            studentsBtn = new Button();
            calendarBtn = new Button();
            meetingsBtn = new Button();
            dashboardBtn = new Button();
            reasonTitle = new Label();
            urgentBtn = new Button();
            generalBtn = new Button();
            friendBtn = new Button();
            schoolBtn = new Button();
            otherBtn = new Button();
            notesTitle = new Label();
            textBox1 = new TextBox();
            title1 = new Label();
            submitBtn = new Button();
            Navbar.SuspendLayout();
            SuspendLayout();
            // 
            // addBookingTitle
            // 
            addBookingTitle.AutoSize = true;
            addBookingTitle.BackColor = Color.Indigo;
            addBookingTitle.ForeColor = Color.White;
            addBookingTitle.Location = new Point(232, 29);
            addBookingTitle.Name = "addBookingTitle";
            addBookingTitle.Padding = new Padding(30, 15, 30, 15);
            addBookingTitle.Size = new Size(161, 45);
            addBookingTitle.TabIndex = 0;
            addBookingTitle.Text = "Add new booking";
            addBookingTitle.Click += label1_Click;
            // 
            // Navbar
            // 
            Navbar.BackgroundImageLayout = ImageLayout.None;
            Navbar.Controls.Add(studentsBtn);
            Navbar.Controls.Add(calendarBtn);
            Navbar.Controls.Add(meetingsBtn);
            Navbar.Controls.Add(dashboardBtn);
            Navbar.Location = new Point(-1, -119);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(199, 689);
            Navbar.TabIndex = 1;
            Navbar.Paint += Navbar_Paint;
            // 
            // studentsBtn
            // 
            studentsBtn.BackColor = SystemColors.Control;
            studentsBtn.Font = new Font("Calibri", 10F);
            studentsBtn.Image = (Image)resources.GetObject("studentsBtn.Image");
            studentsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            studentsBtn.Location = new Point(-3, 381);
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
            // calendarBtn
            // 
            calendarBtn.BackColor = Color.MediumPurple;
            calendarBtn.Font = new Font("Calibri", 10F);
            calendarBtn.Image = (Image)resources.GetObject("calendarBtn.Image");
            calendarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            calendarBtn.Location = new Point(-4, 316);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Padding = new Padding(5, 0, 0, 0);
            calendarBtn.Size = new Size(206, 34);
            calendarBtn.TabIndex = 1;
            calendarBtn.Text = "Calendar";
            calendarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            calendarBtn.UseMnemonic = false;
            calendarBtn.UseVisualStyleBackColor = false;
            // 
            // meetingsBtn
            // 
            meetingsBtn.BackColor = SystemColors.Control;
            meetingsBtn.Font = new Font("Calibri", 10F);
            meetingsBtn.Image = (Image)resources.GetObject("meetingsBtn.Image");
            meetingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            meetingsBtn.Location = new Point(-4, 348);
            meetingsBtn.Name = "meetingsBtn";
            meetingsBtn.Padding = new Padding(5, 0, 0, 0);
            meetingsBtn.Size = new Size(206, 34);
            meetingsBtn.TabIndex = 2;
            meetingsBtn.Text = "Meetings";
            meetingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            meetingsBtn.UseMnemonic = false;
            meetingsBtn.UseVisualStyleBackColor = false;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = SystemColors.Control;
            dashboardBtn.Font = new Font("Calibri", 10F);
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(-4, 288);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(5, 0, 0, 0);
            dashboardBtn.Size = new Size(205, 34);
            dashboardBtn.TabIndex = 0;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardBtn.UseMnemonic = false;
            dashboardBtn.UseVisualStyleBackColor = false;
            // 
            // reasonTitle
            // 
            reasonTitle.AutoSize = true;
            reasonTitle.BackColor = Color.Transparent;
            reasonTitle.ForeColor = Color.Indigo;
            reasonTitle.Location = new Point(232, 131);
            reasonTitle.Name = "reasonTitle";
            reasonTitle.Size = new Size(48, 15);
            reasonTitle.TabIndex = 2;
            reasonTitle.Text = "Reason:";
            // 
            // urgentBtn
            // 
            urgentBtn.BackColor = Color.MediumPurple;
            urgentBtn.Location = new Point(296, 115);
            urgentBtn.Name = "urgentBtn";
            urgentBtn.Size = new Size(107, 54);
            urgentBtn.TabIndex = 3;
            urgentBtn.Text = "Urgent mental health issue";
            urgentBtn.UseVisualStyleBackColor = false;
            // 
            // generalBtn
            // 
            generalBtn.BackColor = Color.MediumPurple;
            generalBtn.Location = new Point(432, 115);
            generalBtn.Name = "generalBtn";
            generalBtn.Size = new Size(107, 54);
            generalBtn.TabIndex = 4;
            generalBtn.Text = "General mental health problems";
            generalBtn.UseVisualStyleBackColor = false;
            // 
            // friendBtn
            // 
            friendBtn.BackColor = Color.MediumPurple;
            friendBtn.Location = new Point(561, 115);
            friendBtn.Name = "friendBtn";
            friendBtn.Size = new Size(107, 54);
            friendBtn.TabIndex = 5;
            friendBtn.Text = "Friendship Problems";
            friendBtn.UseVisualStyleBackColor = false;
            // 
            // schoolBtn
            // 
            schoolBtn.BackColor = Color.MediumPurple;
            schoolBtn.Location = new Point(700, 115);
            schoolBtn.Name = "schoolBtn";
            schoolBtn.Size = new Size(107, 54);
            schoolBtn.TabIndex = 6;
            schoolBtn.Text = "School stress/academic problems";
            schoolBtn.UseVisualStyleBackColor = false;
            // 
            // otherBtn
            // 
            otherBtn.BackColor = Color.MediumPurple;
            otherBtn.Location = new Point(836, 115);
            otherBtn.Name = "otherBtn";
            otherBtn.Size = new Size(107, 54);
            otherBtn.TabIndex = 7;
            otherBtn.Text = "Other";
            otherBtn.UseVisualStyleBackColor = false;
            // 
            // notesTitle
            // 
            notesTitle.AutoSize = true;
            notesTitle.BackColor = Color.Transparent;
            notesTitle.ForeColor = Color.Indigo;
            notesTitle.Location = new Point(232, 225);
            notesTitle.Name = "notesTitle";
            notesTitle.Size = new Size(41, 15);
            notesTitle.TabIndex = 8;
            notesTitle.Text = "Notes:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(296, 222);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(647, 168);
            textBox1.TabIndex = 9;
            // 
            // title1
            // 
            title1.AutoSize = true;
            title1.BackColor = Color.Transparent;
            title1.ForeColor = Color.Indigo;
            title1.Location = new Point(296, 427);
            title1.Name = "title1";
            title1.Size = new Size(296, 15);
            title1.TabIndex = 10;
            title1.Text = "You will be notified when an appointment is scheduled";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Indigo;
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(802, 478);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(141, 54);
            submitBtn.TabIndex = 11;
            submitBtn.Text = "Other";
            submitBtn.UseVisualStyleBackColor = false;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 575);
            Controls.Add(submitBtn);
            Controls.Add(title1);
            Controls.Add(textBox1);
            Controls.Add(notesTitle);
            Controls.Add(otherBtn);
            Controls.Add(schoolBtn);
            Controls.Add(friendBtn);
            Controls.Add(generalBtn);
            Controls.Add(urgentBtn);
            Controls.Add(reasonTitle);
            Controls.Add(Navbar);
            Controls.Add(addBookingTitle);
            Name = "BookingForm";
            Text = "BookingForm";
            Load += BookingForm_Load;
            Navbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addBookingTitle;
        private Panel Navbar;
        private Button studentsBtn;
        private Button meetingsBtn;
        private Button calendarBtn;
        private Button dashboardBtn;
        private Label reasonTitle;
        private Button urgentBtn;
        private Button generalBtn;
        private Button friendBtn;
        private Button schoolBtn;
        private Button otherBtn;
        private Label notesTitle;
        private TextBox textBox1;
        private Label title1;
        private Button submitBtn;
    }
}