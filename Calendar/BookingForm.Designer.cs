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
            notesBox = new TextBox();
            title1 = new Label();
            submitBtn = new Button();
            panel1 = new Panel();
            Navbar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addBookingTitle
            // 
            addBookingTitle.AutoSize = true;
            addBookingTitle.BackColor = Color.Indigo;
            addBookingTitle.ForeColor = Color.White;
            addBookingTitle.Location = new Point(431, 62);
            addBookingTitle.Margin = new Padding(6, 0, 6, 0);
            addBookingTitle.Name = "addBookingTitle";
            addBookingTitle.Padding = new Padding(56, 32, 56, 32);
            addBookingTitle.Size = new Size(320, 96);
            addBookingTitle.TabIndex = 0;
            addBookingTitle.Text = "Add new booking:";
            addBookingTitle.Click += label1_Click;
            // 
            // Navbar
            // 
            Navbar.BackgroundImageLayout = ImageLayout.None;
            Navbar.Controls.Add(studentsBtn);
            Navbar.Controls.Add(calendarBtn);
            Navbar.Controls.Add(meetingsBtn);
            Navbar.Controls.Add(dashboardBtn);
            Navbar.Location = new Point(-2, -254);
            Navbar.Margin = new Padding(6);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(370, 1470);
            Navbar.TabIndex = 1;
            Navbar.Paint += Navbar_Paint;
            // 
            // studentsBtn
            // 
            studentsBtn.BackColor = SystemColors.Control;
            studentsBtn.Font = new Font("Calibri", 10F);
            studentsBtn.Image = (Image)resources.GetObject("studentsBtn.Image");
            studentsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            studentsBtn.Location = new Point(-2, 813);
            studentsBtn.Margin = new Padding(6);
            studentsBtn.Name = "studentsBtn";
            studentsBtn.Padding = new Padding(9, 0, 0, 0);
            studentsBtn.Size = new Size(381, 73);
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
            calendarBtn.Location = new Point(-2, 674);
            calendarBtn.Margin = new Padding(6);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Padding = new Padding(9, 0, 0, 0);
            calendarBtn.Size = new Size(383, 73);
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
            meetingsBtn.Location = new Point(-1, 742);
            meetingsBtn.Margin = new Padding(6);
            meetingsBtn.Name = "meetingsBtn";
            meetingsBtn.Padding = new Padding(9, 0, 0, 0);
            meetingsBtn.Size = new Size(383, 73);
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
            dashboardBtn.Location = new Point(-2, 614);
            dashboardBtn.Margin = new Padding(6);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(9, 0, 0, 0);
            dashboardBtn.Size = new Size(381, 73);
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
            reasonTitle.Location = new Point(431, 279);
            reasonTitle.Margin = new Padding(6, 0, 6, 0);
            reasonTitle.Name = "reasonTitle";
            reasonTitle.Size = new Size(95, 32);
            reasonTitle.TabIndex = 2;
            reasonTitle.Text = "Reason:";
            // 
            // urgentBtn
            // 
            urgentBtn.BackColor = Color.MediumPurple;
            urgentBtn.Location = new Point(550, 245);
            urgentBtn.Margin = new Padding(6);
            urgentBtn.Name = "urgentBtn";
            urgentBtn.Size = new Size(199, 115);
            urgentBtn.TabIndex = 3;
            urgentBtn.Text = "Urgent mental health issue";
            urgentBtn.UseVisualStyleBackColor = false;
            urgentBtn.Click += urgentBtn_Click;
            // 
            // generalBtn
            // 
            generalBtn.BackColor = Color.MediumPurple;
            generalBtn.Location = new Point(802, 245);
            generalBtn.Margin = new Padding(6);
            generalBtn.Name = "generalBtn";
            generalBtn.Size = new Size(199, 115);
            generalBtn.TabIndex = 4;
            generalBtn.Text = "General mental health problems";
            generalBtn.UseVisualStyleBackColor = false;
            generalBtn.Click += generalBtn_Click;
            // 
            // friendBtn
            // 
            friendBtn.BackColor = Color.MediumPurple;
            friendBtn.Location = new Point(1042, 245);
            friendBtn.Margin = new Padding(6);
            friendBtn.Name = "friendBtn";
            friendBtn.Size = new Size(199, 115);
            friendBtn.TabIndex = 5;
            friendBtn.Text = "Friendship Problems";
            friendBtn.UseVisualStyleBackColor = false;
            friendBtn.Click += friendBtn_Click;
            // 
            // schoolBtn
            // 
            schoolBtn.BackColor = Color.MediumPurple;
            schoolBtn.Location = new Point(1300, 245);
            schoolBtn.Margin = new Padding(6);
            schoolBtn.Name = "schoolBtn";
            schoolBtn.Size = new Size(199, 115);
            schoolBtn.TabIndex = 6;
            schoolBtn.Text = "School stress/academic problems";
            schoolBtn.UseVisualStyleBackColor = false;
            schoolBtn.Click += schoolBtn_Click;
            // 
            // otherBtn
            // 
            otherBtn.BackColor = Color.MediumPurple;
            otherBtn.Location = new Point(1553, 245);
            otherBtn.Margin = new Padding(6);
            otherBtn.Name = "otherBtn";
            otherBtn.Size = new Size(199, 115);
            otherBtn.TabIndex = 7;
            otherBtn.Text = "Other";
            otherBtn.UseVisualStyleBackColor = false;
            otherBtn.Click += otherBtn_Click;
            // 
            // notesTitle
            // 
            notesTitle.AutoSize = true;
            notesTitle.BackColor = Color.Transparent;
            notesTitle.ForeColor = Color.Indigo;
            notesTitle.Location = new Point(431, 483);
            notesTitle.Margin = new Padding(6, 0, 6, 0);
            notesTitle.Name = "notesTitle";
            notesTitle.Size = new Size(82, 32);
            notesTitle.TabIndex = 8;
            notesTitle.Text = "Notes:";
            // 
            // notesBox
            // 
            notesBox.BorderStyle = BorderStyle.FixedSingle;
            notesBox.Location = new Point(2, 2);
            notesBox.Margin = new Padding(6);
            notesBox.Multiline = true;
            notesBox.Name = "notesBox";
            notesBox.Size = new Size(1197, 351);
            notesBox.TabIndex = 9;
            // 
            // title1
            // 
            title1.AutoSize = true;
            title1.BackColor = Color.Transparent;
            title1.ForeColor = Color.Indigo;
            title1.Location = new Point(550, 911);
            title1.Margin = new Padding(6, 0, 6, 0);
            title1.Name = "title1";
            title1.Size = new Size(601, 32);
            title1.TabIndex = 10;
            title1.Text = "You will be notified when an appointment is scheduled";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Indigo;
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(1489, 1020);
            submitBtn.Margin = new Padding(6);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(262, 115);
            submitBtn.TabIndex = 11;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(notesBox);
            panel1.Location = new Point(550, 474);
            panel1.Name = "panel1";
            panel1.Size = new Size(1201, 356);
            panel1.TabIndex = 12;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1829, 1227);
            Controls.Add(panel1);
            Controls.Add(submitBtn);
            Controls.Add(title1);
            Controls.Add(notesTitle);
            Controls.Add(otherBtn);
            Controls.Add(schoolBtn);
            Controls.Add(friendBtn);
            Controls.Add(generalBtn);
            Controls.Add(urgentBtn);
            Controls.Add(reasonTitle);
            Controls.Add(Navbar);
            Controls.Add(addBookingTitle);
            Margin = new Padding(6);
            Name = "BookingForm";
            Text = "BookingForm";
            Load += BookingForm_Load;
            Navbar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox notesBox;
        private Label title1;
        private Button submitBtn;
        private Panel panel1;
    }
}