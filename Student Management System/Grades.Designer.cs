namespace Student_Management_System
{
    partial class Grades
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboSubjectID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboGrade = new System.Windows.Forms.TextBox();
            this.tboGradeID = new System.Windows.Forms.TextBox();
            this.btoSearch = new System.Windows.Forms.Button();
            this.btoDelete = new System.Windows.Forms.Button();
            this.btoUpdate = new System.Windows.Forms.Button();
            this.btoAdd = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.Label();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.colGradeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btoExportToExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tboSubjectID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboStudentID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboGrade);
            this.groupBox1.Controls.Add(this.tboGradeID);
            this.groupBox1.Controls.Add(this.btoSearch);
            this.groupBox1.Controls.Add(this.btoDelete);
            this.groupBox1.Controls.Add(this.btoUpdate);
            this.groupBox1.Controls.Add(this.btoAdd);
            this.groupBox1.Controls.Add(this.FullName);
            this.groupBox1.Controls.Add(this.Grade);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1208, 226);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grades";
            // 
            // tboSubjectID
            // 
            this.tboSubjectID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSubjectID.Location = new System.Drawing.Point(113, 110);
            this.tboSubjectID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboSubjectID.Name = "tboSubjectID";
            this.tboSubjectID.Size = new System.Drawing.Size(291, 31);
            this.tboSubjectID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "SubjectID";
            // 
            // tboStudentID
            // 
            this.tboStudentID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboStudentID.Location = new System.Drawing.Point(520, 49);
            this.tboStudentID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboStudentID.Name = "tboStudentID";
            this.tboStudentID.Size = new System.Drawing.Size(291, 31);
            this.tboStudentID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "StudentID";
            // 
            // tboGrade
            // 
            this.tboGrade.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboGrade.Location = new System.Drawing.Point(545, 108);
            this.tboGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboGrade.Name = "tboGrade";
            this.tboGrade.Size = new System.Drawing.Size(291, 31);
            this.tboGrade.TabIndex = 17;
            // 
            // tboGradeID
            // 
            this.tboGradeID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboGradeID.Location = new System.Drawing.Point(121, 49);
            this.tboGradeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboGradeID.Name = "tboGradeID";
            this.tboGradeID.Size = new System.Drawing.Size(291, 31);
            this.tboGradeID.TabIndex = 9;
            // 
            // btoSearch
            // 
            this.btoSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoSearch.Location = new System.Drawing.Point(1056, 167);
            this.btoSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btoSearch.Name = "btoSearch";
            this.btoSearch.Size = new System.Drawing.Size(144, 49);
            this.btoSearch.TabIndex = 11;
            this.btoSearch.Text = "Search";
            this.btoSearch.UseVisualStyleBackColor = true;
            this.btoSearch.Click += new System.EventHandler(this.btoSearch_Click);
            // 
            // btoDelete
            // 
            this.btoDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoDelete.Location = new System.Drawing.Point(891, 167);
            this.btoDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btoDelete.Name = "btoDelete";
            this.btoDelete.Size = new System.Drawing.Size(144, 49);
            this.btoDelete.TabIndex = 10;
            this.btoDelete.Text = "Delete";
            this.btoDelete.UseVisualStyleBackColor = true;
            this.btoDelete.Click += new System.EventHandler(this.btoDelete_Click);
            // 
            // btoUpdate
            // 
            this.btoUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoUpdate.Location = new System.Drawing.Point(725, 167);
            this.btoUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btoUpdate.Name = "btoUpdate";
            this.btoUpdate.Size = new System.Drawing.Size(144, 49);
            this.btoUpdate.TabIndex = 9;
            this.btoUpdate.Text = "Update";
            this.btoUpdate.UseVisualStyleBackColor = true;
            this.btoUpdate.Click += new System.EventHandler(this.btoUpdate_Click);
            // 
            // btoAdd
            // 
            this.btoAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoAdd.Location = new System.Drawing.Point(560, 167);
            this.btoAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btoAdd.Name = "btoAdd";
            this.btoAdd.Size = new System.Drawing.Size(144, 49);
            this.btoAdd.TabIndex = 8;
            this.btoAdd.Text = "Add";
            this.btoAdd.UseVisualStyleBackColor = true;
            this.btoAdd.Click += new System.EventHandler(this.btoAdd_Click);
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(8, 53);
            this.FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(77, 25);
            this.FullName.TabIndex = 1;
            this.FullName.Text = "GradeID";
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade.Location = new System.Drawing.Point(456, 113);
            this.Grade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(59, 25);
            this.Grade.TabIndex = 7;
            this.Grade.Text = "Grade";
            // 
            // dgvGrades
            // 
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGradeID,
            this.colStudentID,
            this.colSubjectID,
            this.colGrade});
            this.dgvGrades.GridColor = System.Drawing.SystemColors.Control;
            this.dgvGrades.Location = new System.Drawing.Point(16, 250);
            this.dgvGrades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.RowHeadersWidth = 51;
            this.dgvGrades.RowTemplate.Height = 24;
            this.dgvGrades.Size = new System.Drawing.Size(1208, 385);
            this.dgvGrades.TabIndex = 13;
            this.dgvGrades.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_RowEnter);
            // 
            // colGradeID
            // 
            this.colGradeID.DataPropertyName = "GradeID";
            this.colGradeID.HeaderText = "GradeID";
            this.colGradeID.MinimumWidth = 6;
            this.colGradeID.Name = "colGradeID";
            this.colGradeID.ReadOnly = true;
            // 
            // colStudentID
            // 
            this.colStudentID.DataPropertyName = "StudentID";
            this.colStudentID.HeaderText = "StudentID";
            this.colStudentID.MinimumWidth = 6;
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.ReadOnly = true;
            // 
            // colSubjectID
            // 
            this.colSubjectID.DataPropertyName = "SubjectID";
            this.colSubjectID.HeaderText = "SubjectID";
            this.colSubjectID.MinimumWidth = 6;
            this.colSubjectID.Name = "colSubjectID";
            this.colSubjectID.ReadOnly = true;
            // 
            // colGrade
            // 
            this.colGrade.DataPropertyName = "Grade";
            this.colGrade.HeaderText = "Grade";
            this.colGrade.MinimumWidth = 6;
            this.colGrade.Name = "colGrade";
            this.colGrade.ReadOnly = true;
            // 
            // btoExportToExcel
            // 
            this.btoExportToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.btoExportToExcel.Image = global::Student_Management_System.Properties.Resources.excel;
            this.btoExportToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoExportToExcel.Location = new System.Drawing.Point(16, 642);
            this.btoExportToExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btoExportToExcel.Name = "btoExportToExcel";
            this.btoExportToExcel.Size = new System.Drawing.Size(239, 33);
            this.btoExportToExcel.TabIndex = 14;
            this.btoExportToExcel.Text = "Export to Excel";
            this.btoExportToExcel.UseVisualStyleBackColor = false;
            this.btoExportToExcel.Click += new System.EventHandler(this.btoExportToExcel_Click);
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 702);
            this.Controls.Add(this.btoExportToExcel);
            this.Controls.Add(this.dgvGrades);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1241, 702);
            this.MinimumSize = new System.Drawing.Size(1241, 702);
            this.Name = "Grades";
            this.Text = "Grades";
            this.Load += new System.EventHandler(this.Grades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboGrade;
        private System.Windows.Forms.TextBox tboGradeID;
        private System.Windows.Forms.Button btoSearch;
        private System.Windows.Forms.Button btoDelete;
        private System.Windows.Forms.Button btoUpdate;
        private System.Windows.Forms.Button btoAdd;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboStudentID;
        private System.Windows.Forms.Button btoExportToExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGradeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGrade;
        private System.Windows.Forms.TextBox tboSubjectID;
        private System.Windows.Forms.Label label2;
    }
}