namespace Student_Management_System
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboClassID = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.tboAddress = new System.Windows.Forms.TextBox();
            this.tboFullName = new System.Windows.Forms.TextBox();
            this.tboStudentID = new System.Windows.Forms.TextBox();
            this.btoSearch = new System.Windows.Forms.Button();
            this.btoDelete = new System.Windows.Forms.Button();
            this.btoUpdate = new System.Windows.Forms.Button();
            this.btoAdd = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btoExportToExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "StudentID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "DateOfBirth ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "FullName ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sex ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "ClassID ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboClassID);
            this.groupBox1.Controls.Add(this.dtpDateOfBirth);
            this.groupBox1.Controls.Add(this.cboSex);
            this.groupBox1.Controls.Add(this.tboAddress);
            this.groupBox1.Controls.Add(this.tboFullName);
            this.groupBox1.Controls.Add(this.tboStudentID);
            this.groupBox1.Controls.Add(this.btoSearch);
            this.groupBox1.Controls.Add(this.btoDelete);
            this.groupBox1.Controls.Add(this.btoUpdate);
            this.groupBox1.Controls.Add(this.btoAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 215);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            // 
            // tboClassID
            // 
            this.tboClassID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboClassID.Location = new System.Drawing.Point(73, 169);
            this.tboClassID.Name = "tboClassID";
            this.tboClassID.Size = new System.Drawing.Size(219, 31);
            this.tboClassID.TabIndex = 17;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(348, 90);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(298, 31);
            this.dtpDateOfBirth.TabIndex = 16;
            this.dtpDateOfBirth.Value = new System.DateTime(2024, 11, 1, 20, 31, 17, 0);
            // 
            // cboSex
            // 
            this.cboSex.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboSex.Location = new System.Drawing.Point(68, 92);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(172, 33);
            this.cboSex.TabIndex = 9;
            // 
            // tboAddress
            // 
            this.tboAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboAddress.Location = new System.Drawing.Point(103, 131);
            this.tboAddress.Name = "tboAddress";
            this.tboAddress.Size = new System.Drawing.Size(471, 31);
            this.tboAddress.TabIndex = 15;
            // 
            // tboFullName
            // 
            this.tboFullName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboFullName.Location = new System.Drawing.Point(425, 54);
            this.tboFullName.Name = "tboFullName";
            this.tboFullName.Size = new System.Drawing.Size(352, 31);
            this.tboFullName.TabIndex = 12;
            // 
            // tboStudentID
            // 
            this.tboStudentID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboStudentID.Location = new System.Drawing.Point(103, 54);
            this.tboStudentID.Name = "tboStudentID";
            this.tboStudentID.Size = new System.Drawing.Size(219, 31);
            this.tboStudentID.TabIndex = 9;
            // 
            // btoSearch
            // 
            this.btoSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoSearch.Location = new System.Drawing.Point(786, 164);
            this.btoSearch.Name = "btoSearch";
            this.btoSearch.Size = new System.Drawing.Size(108, 40);
            this.btoSearch.TabIndex = 11;
            this.btoSearch.Text = "Search";
            this.btoSearch.UseVisualStyleBackColor = true;
            this.btoSearch.Click += new System.EventHandler(this.btoSearch_Click);
            // 
            // btoDelete
            // 
            this.btoDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoDelete.Location = new System.Drawing.Point(662, 164);
            this.btoDelete.Name = "btoDelete";
            this.btoDelete.Size = new System.Drawing.Size(108, 40);
            this.btoDelete.TabIndex = 10;
            this.btoDelete.Text = "Delete";
            this.btoDelete.UseVisualStyleBackColor = true;
            this.btoDelete.Click += new System.EventHandler(this.btoDelete_Click);
            // 
            // btoUpdate
            // 
            this.btoUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoUpdate.Location = new System.Drawing.Point(538, 164);
            this.btoUpdate.Name = "btoUpdate";
            this.btoUpdate.Size = new System.Drawing.Size(108, 40);
            this.btoUpdate.TabIndex = 9;
            this.btoUpdate.Text = "Update";
            this.btoUpdate.UseVisualStyleBackColor = true;
            this.btoUpdate.Click += new System.EventHandler(this.btoUpdate_Click);
            // 
            // btoAdd
            // 
            this.btoAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoAdd.Location = new System.Drawing.Point(414, 164);
            this.btoAdd.Name = "btoAdd";
            this.btoAdd.Size = new System.Drawing.Size(108, 40);
            this.btoAdd.TabIndex = 8;
            this.btoAdd.Text = "Add";
            this.btoAdd.UseVisualStyleBackColor = true;
            this.btoAdd.Click += new System.EventHandler(this.btoAdd_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentID,
            this.colFullName,
            this.colDateOfBirth,
            this.colSex,
            this.colAddress,
            this.colClassID});
            this.dgvStudents.GridColor = System.Drawing.SystemColors.Control;
            this.dgvStudents.Location = new System.Drawing.Point(12, 233);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(906, 283);
            this.dgvStudents.TabIndex = 9;
            this.dgvStudents.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_RowEnter);
            // 
            // colStudentID
            // 
            this.colStudentID.DataPropertyName = "StudentID";
            this.colStudentID.HeaderText = "StudentID";
            this.colStudentID.MinimumWidth = 6;
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "FullName";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.DataPropertyName = "DateOfBirth";
            this.colDateOfBirth.HeaderText = "DateOfBirth";
            this.colDateOfBirth.MinimumWidth = 6;
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.ReadOnly = true;
            // 
            // colSex
            // 
            this.colSex.DataPropertyName = "Sex";
            this.colSex.HeaderText = "Sex";
            this.colSex.MinimumWidth = 6;
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // colClassID
            // 
            this.colClassID.DataPropertyName = "ClassID";
            this.colClassID.HeaderText = "ClassID";
            this.colClassID.MinimumWidth = 6;
            this.colClassID.Name = "colClassID";
            this.colClassID.ReadOnly = true;
            // 
            // btoExportToExcel
            // 
            this.btoExportToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.btoExportToExcel.Image = global::Student_Management_System.Properties.Resources.excel;
            this.btoExportToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoExportToExcel.Location = new System.Drawing.Point(12, 522);
            this.btoExportToExcel.Name = "btoExportToExcel";
            this.btoExportToExcel.Size = new System.Drawing.Size(179, 27);
            this.btoExportToExcel.TabIndex = 10;
            this.btoExportToExcel.Text = "Export to Excel";
            this.btoExportToExcel.UseVisualStyleBackColor = false;
            this.btoExportToExcel.Click += new System.EventHandler(this.btoExportToExcel_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 570);
            this.Controls.Add(this.btoExportToExcel);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(931, 570);
            this.MinimumSize = new System.Drawing.Size(931, 570);
            this.Name = "Students";
            this.Text = "Students";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboAddress;
        private System.Windows.Forms.TextBox tboFullName;
        private System.Windows.Forms.TextBox tboStudentID;
        private System.Windows.Forms.Button btoSearch;
        private System.Windows.Forms.Button btoDelete;
        private System.Windows.Forms.Button btoUpdate;
        private System.Windows.Forms.Button btoAdd;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassID;
        private System.Windows.Forms.TextBox tboClassID;
        private System.Windows.Forms.Button btoExportToExcel;
    }
}