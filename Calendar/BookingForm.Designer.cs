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
            calendarBtn = new Button();
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
            panel2 = new Panel();
            Navbar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // addBookingTitle
            // 
            addBookingTitle.AutoSize = true;
            addBookingTitle.BackColor = Color.Indigo;
            addBookingTitle.ForeColor = Color.White;
            addBookingTitle.Location = new Point(39, 41);
            addBookingTitle.Name = "addBookingTitle";
            addBookingTitle.Padding = new Padding(30, 15, 30, 15);
            addBookingTitle.Size = new Size(164, 45);
            addBookingTitle.TabIndex = 0;
            addBookingTitle.Text = "Add new booking:";
            addBookingTitle.Click += label1_Click;
            // 
            // Navbar
            // 
            Navbar.BackgroundImageLayout = ImageLayout.None;
            Navbar.Controls.Add(calendarBtn);
            Navbar.Controls.Add(dashboardBtn);
            Navbar.Location = new Point(-1, -119);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(199, 904);
            Navbar.TabIndex = 1;
            Navbar.Paint += Navbar_Paint;
            // 
            // calendarBtn
            // 
            calendarBtn.BackColor = Color.MediumPurple;
            calendarBtn.Font = new Font("Calibri", 10F);
            calendarBtn.Image = (Image)resources.GetObject("calendarBtn.Image");
            calendarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            calendarBtn.Location = new Point(-1, 316);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Padding = new Padding(5, 0, 0, 0);
            calendarBtn.Size = new Size(206, 34);
            calendarBtn.TabIndex = 1;
            calendarBtn.Text = "Meetings";
            calendarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            calendarBtn.UseMnemonic = false;
            calendarBtn.UseVisualStyleBackColor = false;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = SystemColors.Control;
            dashboardBtn.Font = new Font("Calibri", 10F);
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(-1, 288);
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
            reasonTitle.Location = new Point(39, 176);
            reasonTitle.Name = "reasonTitle";
            reasonTitle.Size = new Size(48, 15);
            reasonTitle.TabIndex = 2;
            reasonTitle.Text = "Reason:";
            // 
            // urgentBtn
            // 
            urgentBtn.BackColor = Color.MediumPurple;
            urgentBtn.Location = new Point(126, 161);
            urgentBtn.Name = "urgentBtn";
            urgentBtn.Size = new Size(107, 54);
            urgentBtn.TabIndex = 3;
            urgentBtn.Text = "Urgent mental health issue";
            urgentBtn.UseVisualStyleBackColor = false;
            urgentBtn.Click += urgentBtn_Click;
            // 
            // generalBtn
            // 
            generalBtn.BackColor = Color.MediumPurple;
            generalBtn.Location = new Point(564, 192);
            generalBtn.Name = "generalBtn";
            generalBtn.Size = new Size(107, 54);
            generalBtn.TabIndex = 4;
            generalBtn.Text = "General mental health problems";
            generalBtn.UseVisualStyleBackColor = false;
            generalBtn.Click += generalBtn_Click;
            // 
            // friendBtn
            // 
            friendBtn.BackColor = Color.MediumPurple;
            friendBtn.Location = new Point(474, 161);
            friendBtn.Name = "friendBtn";
            friendBtn.Size = new Size(107, 54);
            friendBtn.TabIndex = 5;
            friendBtn.Text = "Friendship Problems";
            friendBtn.UseVisualStyleBackColor = false;
            friendBtn.Click += friendBtn_Click;
            // 
            // schoolBtn
            // 
            schoolBtn.BackColor = Color.MediumPurple;
            schoolBtn.Location = new Point(633, 161);
            schoolBtn.Name = "schoolBtn";
            schoolBtn.Size = new Size(107, 54);
            schoolBtn.TabIndex = 6;
            schoolBtn.Text = "School stress/academic problems";
            schoolBtn.UseVisualStyleBackColor = false;
            schoolBtn.Click += schoolBtn_Click;
            // 
            // otherBtn
            // 
            otherBtn.BackColor = Color.MediumPurple;
            otherBtn.Location = new Point(810, 161);
            otherBtn.Name = "otherBtn";
            otherBtn.Size = new Size(107, 54);
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
            notesTitle.Location = new Point(39, 273);
            notesTitle.Name = "notesTitle";
            notesTitle.Size = new Size(41, 15);
            notesTitle.TabIndex = 8;
            notesTitle.Text = "Notes:";
            // 
            // notesBox
            // 
            notesBox.BorderStyle = BorderStyle.FixedSingle;
            notesBox.Location = new Point(1, 1);
            notesBox.Multiline = true;
            notesBox.Name = "notesBox";
            notesBox.Size = new Size(787, 159);
            notesBox.TabIndex = 9;
            notesBox.TextChanged += notesBox_TextChanged;
            // 
            // title1
            // 
            title1.AutoSize = true;
            title1.BackColor = Color.Transparent;
            title1.ForeColor = Color.Indigo;
            title1.Location = new Point(428, 504);
            title1.Name = "title1";
            title1.Size = new Size(296, 15);
            title1.TabIndex = 10;
            title1.Text = "You will be notified when an appointment is scheduled";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Indigo;
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(934, 555);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(141, 54);
            submitBtn.TabIndex = 11;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(notesBox);
            panel1.Location = new Point(123, 273);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 161);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(addBookingTitle);
            panel2.Controls.Add(reasonTitle);
            panel2.Controls.Add(urgentBtn);
            panel2.Controls.Add(notesTitle);
            panel2.Controls.Add(otherBtn);
            panel2.Controls.Add(friendBtn);
            panel2.Controls.Add(schoolBtn);
            panel2.Location = new Point(267, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(997, 654);
            panel2.TabIndex = 13;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 755);
            Controls.Add(submitBtn);
            Controls.Add(title1);
            Controls.Add(generalBtn);
            Controls.Add(Navbar);
            Controls.Add(panel2);
            Name = "BookingForm";
            Text = "BookingForm";
            Load += BookingForm_Load;
            Navbar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addBookingTitle;
        private Panel Navbar;
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
        private Panel panel2;
        private Button calendarBtn;
    }
}