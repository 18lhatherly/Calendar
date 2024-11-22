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
            addBookingTitle.Location = new Point(72, 87);
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
            Navbar.Controls.Add(calendarBtn);
            Navbar.Controls.Add(dashboardBtn);
            Navbar.Location = new Point(-2, -254);
            Navbar.Margin = new Padding(6, 6, 6, 6);
            Navbar.Name = "Navbar";
            Navbar.Size = new Size(370, 1929);
            Navbar.TabIndex = 1;
            Navbar.Paint += Navbar_Paint;
            // 
            // calendarBtn
            // 
            calendarBtn.BackColor = Color.MediumPurple;
            calendarBtn.Font = new Font("Calibri", 10F);
            calendarBtn.Image = (Image)resources.GetObject("calendarBtn.Image");
            calendarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            calendarBtn.Location = new Point(-2, 674);
            calendarBtn.Margin = new Padding(6, 6, 6, 6);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Padding = new Padding(9, 0, 0, 0);
            calendarBtn.Size = new Size(383, 73);
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
            dashboardBtn.Location = new Point(-2, 614);
            dashboardBtn.Margin = new Padding(6, 6, 6, 6);
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
            reasonTitle.Location = new Point(72, 375);
            reasonTitle.Margin = new Padding(6, 0, 6, 0);
            reasonTitle.Name = "reasonTitle";
            reasonTitle.Size = new Size(95, 32);
            reasonTitle.TabIndex = 2;
            reasonTitle.Text = "Reason:";
            // 
            // urgentBtn
            // 
            urgentBtn.BackColor = Color.MediumPurple;
            urgentBtn.Location = new Point(234, 343);
            urgentBtn.Margin = new Padding(6, 6, 6, 6);
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
            generalBtn.Location = new Point(1047, 410);
            generalBtn.Margin = new Padding(6, 6, 6, 6);
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
            friendBtn.Location = new Point(880, 343);
            friendBtn.Margin = new Padding(6, 6, 6, 6);
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
            schoolBtn.Location = new Point(1176, 343);
            schoolBtn.Margin = new Padding(6, 6, 6, 6);
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
            otherBtn.Location = new Point(1504, 343);
            otherBtn.Margin = new Padding(6, 6, 6, 6);
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
            notesTitle.Location = new Point(72, 582);
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
            notesBox.Margin = new Padding(6, 6, 6, 6);
            notesBox.Multiline = true;
            notesBox.Name = "notesBox";
            notesBox.Size = new Size(1460, 337);
            notesBox.TabIndex = 9;
            notesBox.TextChanged += notesBox_TextChanged;
            // 
            // title1
            // 
            title1.AutoSize = true;
            title1.BackColor = SystemColors.ControlLight;
            title1.ForeColor = Color.Indigo;
            title1.Location = new Point(230, 981);
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
            submitBtn.Location = new Point(1431, 1115);
            submitBtn.Margin = new Padding(6, 6, 6, 6);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(262, 115);
            submitBtn.TabIndex = 11;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Controls.Add(notesBox);
            panel1.Location = new Point(228, 582);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1465, 343);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(title1);
            panel2.Controls.Add(submitBtn);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(addBookingTitle);
            panel2.Controls.Add(reasonTitle);
            panel2.Controls.Add(urgentBtn);
            panel2.Controls.Add(notesTitle);
            panel2.Controls.Add(otherBtn);
            panel2.Controls.Add(friendBtn);
            panel2.Controls.Add(schoolBtn);
            panel2.Location = new Point(496, 66);
            panel2.Margin = new Padding(6, 6, 6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1852, 1315);
            panel2.TabIndex = 13;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2617, 1579);
            Controls.Add(generalBtn);
            Controls.Add(Navbar);
            Controls.Add(panel2);
            Margin = new Padding(6, 6, 6, 6);
            Name = "BookingForm";
            Text = "BookingForm";
            Load += BookingForm_Load;
            Navbar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
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