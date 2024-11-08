namespace Student_Management_System
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menusidebarStudents = new System.Windows.Forms.Button();
            this.menusidebarTeachers = new System.Windows.Forms.Button();
            this.menusidebarClass = new System.Windows.Forms.Button();
            this.menusidebarSubjects = new System.Windows.Forms.Button();
            this.menusidebarGrade = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1501, 98);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellcome admin!!!\r\n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.menusidebarStudents);
            this.flowLayoutPanel1.Controls.Add(this.menusidebarTeachers);
            this.flowLayoutPanel1.Controls.Add(this.menusidebarClass);
            this.flowLayoutPanel1.Controls.Add(this.menusidebarSubjects);
            this.flowLayoutPanel1.Controls.Add(this.menusidebarGrade);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 98);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(251, 690);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // menusidebarStudents
            // 
            this.menusidebarStudents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menusidebarStudents.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menusidebarStudents.Image = global::Student_Management_System.Properties.Resources.teen__3_;
            this.menusidebarStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menusidebarStudents.Location = new System.Drawing.Point(0, 0);
            this.menusidebarStudents.Margin = new System.Windows.Forms.Padding(0);
            this.menusidebarStudents.Name = "menusidebarStudents";
            this.menusidebarStudents.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.menusidebarStudents.Size = new System.Drawing.Size(251, 87);
            this.menusidebarStudents.TabIndex = 5;
            this.menusidebarStudents.Text = "Students";
            this.menusidebarStudents.UseVisualStyleBackColor = false;
            this.menusidebarStudents.Click += new System.EventHandler(this.menusidebarStudents_Click);
            // 
            // menusidebarTeachers
            // 
            this.menusidebarTeachers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menusidebarTeachers.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menusidebarTeachers.Image = global::Student_Management_System.Properties.Resources.teacher;
            this.menusidebarTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menusidebarTeachers.Location = new System.Drawing.Point(0, 87);
            this.menusidebarTeachers.Margin = new System.Windows.Forms.Padding(0);
            this.menusidebarTeachers.Name = "menusidebarTeachers";
            this.menusidebarTeachers.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.menusidebarTeachers.Size = new System.Drawing.Size(251, 87);
            this.menusidebarTeachers.TabIndex = 9;
            this.menusidebarTeachers.Text = "Teachers";
            this.menusidebarTeachers.UseVisualStyleBackColor = false;
            this.menusidebarTeachers.Click += new System.EventHandler(this.menusidebarTeachers_Click);
            // 
            // menusidebarClass
            // 
            this.menusidebarClass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menusidebarClass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menusidebarClass.Image = global::Student_Management_System.Properties.Resources.online_education;
            this.menusidebarClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menusidebarClass.Location = new System.Drawing.Point(0, 174);
            this.menusidebarClass.Margin = new System.Windows.Forms.Padding(0);
            this.menusidebarClass.Name = "menusidebarClass";
            this.menusidebarClass.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.menusidebarClass.Size = new System.Drawing.Size(251, 87);
            this.menusidebarClass.TabIndex = 10;
            this.menusidebarClass.Text = "Class";
            this.menusidebarClass.UseVisualStyleBackColor = false;
            this.menusidebarClass.Click += new System.EventHandler(this.menusidebarClass_Click);
            // 
            // menusidebarSubjects
            // 
            this.menusidebarSubjects.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menusidebarSubjects.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menusidebarSubjects.Image = global::Student_Management_System.Properties.Resources.reading;
            this.menusidebarSubjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menusidebarSubjects.Location = new System.Drawing.Point(0, 261);
            this.menusidebarSubjects.Margin = new System.Windows.Forms.Padding(0);
            this.menusidebarSubjects.Name = "menusidebarSubjects";
            this.menusidebarSubjects.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.menusidebarSubjects.Size = new System.Drawing.Size(251, 87);
            this.menusidebarSubjects.TabIndex = 12;
            this.menusidebarSubjects.Text = "Subjects";
            this.menusidebarSubjects.UseVisualStyleBackColor = false;
            this.menusidebarSubjects.Click += new System.EventHandler(this.menusidebarSubjects_Click);
            // 
            // menusidebarGrade
            // 
            this.menusidebarGrade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menusidebarGrade.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menusidebarGrade.Image = global::Student_Management_System.Properties.Resources.examination;
            this.menusidebarGrade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menusidebarGrade.Location = new System.Drawing.Point(0, 348);
            this.menusidebarGrade.Margin = new System.Windows.Forms.Padding(0);
            this.menusidebarGrade.Name = "menusidebarGrade";
            this.menusidebarGrade.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.menusidebarGrade.Size = new System.Drawing.Size(251, 87);
            this.menusidebarGrade.TabIndex = 13;
            this.menusidebarGrade.Text = "Grade";
            this.menusidebarGrade.UseVisualStyleBackColor = false;
            this.menusidebarGrade.Click += new System.EventHandler(this.menusidebarGrade_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(251, 98);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1251, 690);
            this.mainPanel.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 779);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1517, 826);
            this.MinimumSize = new System.Drawing.Size(1517, 826);
            this.Name = "AdminDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button menusidebarStudents;
        private System.Windows.Forms.Button menusidebarTeachers;
        private System.Windows.Forms.Button menusidebarClass;
        private System.Windows.Forms.Button menusidebarSubjects;
        private System.Windows.Forms.Button menusidebarGrade;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
    }
}