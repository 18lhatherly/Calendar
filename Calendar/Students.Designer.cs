namespace Calendar
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            studentsBtn = new Button();
            meetingsBtn = new Button();
            calendarBtn = new Button();
            dashboardBtn = new Button();
            panel1 = new Panel();
            studentList = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // studentsBtn
            // 
            studentsBtn.BackColor = Color.MediumPurple;
            studentsBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            studentsBtn.Image = (Image)resources.GetObject("studentsBtn.Image");
            studentsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            studentsBtn.Location = new Point(2, 435);
            studentsBtn.Margin = new Padding(6);
            studentsBtn.Name = "studentsBtn";
            studentsBtn.Padding = new Padding(10, 0, 0, 0);
            studentsBtn.Size = new Size(381, 73);
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
            meetingsBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            meetingsBtn.Image = (Image)resources.GetObject("meetingsBtn.Image");
            meetingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            meetingsBtn.Location = new Point(-2, 352);
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
            calendarBtn.BackColor = SystemColors.ButtonFace;
            calendarBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            calendarBtn.Image = (Image)resources.GetObject("calendarBtn.Image");
            calendarBtn.ImageAlign = ContentAlignment.MiddleLeft;
            calendarBtn.Location = new Point(-1, 291);
            calendarBtn.Margin = new Padding(6);
            calendarBtn.Name = "calendarBtn";
            calendarBtn.Padding = new Padding(10, 0, 0, 0);
            calendarBtn.Size = new Size(382, 73);
            calendarBtn.TabIndex = 1;
            calendarBtn.Text = "Calendar";
            calendarBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            calendarBtn.UseMnemonic = false;
            calendarBtn.UseVisualStyleBackColor = false;
            calendarBtn.Click += calendarBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = SystemColors.Control;
            dashboardBtn.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(-1, 218);
            dashboardBtn.Margin = new Padding(6);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Padding = new Padding(10, 0, 0, 0);
            dashboardBtn.Size = new Size(380, 73);
            dashboardBtn.TabIndex = 0;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardBtn.UseMnemonic = false;
            dashboardBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(studentsBtn);
            panel1.Controls.Add(dashboardBtn);
            panel1.Controls.Add(calendarBtn);
            panel1.Location = new Point(-1, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 1298);
            panel1.TabIndex = 3;
            // 
            // studentList
            // 
            studentList.FormattingEnabled = true;
            studentList.ItemHeight = 32;
            studentList.Location = new Point(488, 217);
            studentList.Name = "studentList";
            studentList.Size = new Size(1150, 612);
            studentList.TabIndex = 5;
            studentList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Students
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1736, 944);
            Controls.Add(studentList);
            Controls.Add(meetingsBtn);
            Controls.Add(panel1);
            Name = "Students";
            Text = "Students";
            Load += Students_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button studentsBtn;
        private Button meetingsBtn;
        private Button calendarBtn;
        private Button dashboardBtn;
        private Panel panel1;
        private ListBox studentList;
    }
}