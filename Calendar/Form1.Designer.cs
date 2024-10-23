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
            this.Navbar = new System.Windows.Forms.Panel();
            this.studentsBtn = new System.Windows.Forms.Button();
            this.meetingsBtn = new System.Windows.Forms.Button();
            this.calendarBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.Navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navbar
            // 
            this.Navbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Navbar.Controls.Add(this.studentsBtn);
            this.Navbar.Controls.Add(this.meetingsBtn);
            this.Navbar.Controls.Add(this.calendarBtn);
            this.Navbar.Controls.Add(this.dashboardBtn);
            this.Navbar.Location = new System.Drawing.Point(3, 4);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(200, 445);
            this.Navbar.TabIndex = 0;
            // 
            // studentsBtn
            // 
            this.studentsBtn.BackColor = System.Drawing.Color.Transparent;
            this.studentsBtn.Location = new System.Drawing.Point(52, 308);
            this.studentsBtn.Name = "studentsBtn";
            this.studentsBtn.Size = new System.Drawing.Size(148, 65);
            this.studentsBtn.TabIndex = 3;
            this.studentsBtn.Text = "Students";
            this.studentsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.studentsBtn.UseVisualStyleBackColor = false;
            // 
            // meetingsBtn
            // 
            this.meetingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.meetingsBtn.Location = new System.Drawing.Point(52, 245);
            this.meetingsBtn.Name = "meetingsBtn";
            this.meetingsBtn.Size = new System.Drawing.Size(148, 65);
            this.meetingsBtn.TabIndex = 2;
            this.meetingsBtn.Text = "Meetings";
            this.meetingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.meetingsBtn.UseVisualStyleBackColor = false;
            // 
            // calendarBtn
            // 
            this.calendarBtn.BackColor = System.Drawing.Color.Transparent;
            this.calendarBtn.Location = new System.Drawing.Point(52, 182);
            this.calendarBtn.Name = "calendarBtn";
            this.calendarBtn.Size = new System.Drawing.Size(148, 65);
            this.calendarBtn.TabIndex = 1;
            this.calendarBtn.Text = "Calendar";
            this.calendarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calendarBtn.UseVisualStyleBackColor = false;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(52, 119);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(148, 65);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseMnemonic = false;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Navbar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Navbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Navbar;
        private Button meetingsBtn;
        private Button calendarBtn;
        private Button dashboardBtn;
        private Button studentsBtn;
    }
}