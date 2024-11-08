namespace Student_Management_System
{
    partial class Subjects
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
            this.btoExportToExcel = new System.Windows.Forms.Button();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.colSubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboCredit = new System.Windows.Forms.TextBox();
            this.tboSubjectName = new System.Windows.Forms.TextBox();
            this.tboSubjectID = new System.Windows.Forms.TextBox();
            this.btoSearch = new System.Windows.Forms.Button();
            this.btoDelete = new System.Windows.Forms.Button();
            this.btoUpdate = new System.Windows.Forms.Button();
            this.btoAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btoExportToExcel
            // 
            this.btoExportToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.btoExportToExcel.Image = global::Student_Management_System.Properties.Resources.excel;
            this.btoExportToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btoExportToExcel.Location = new System.Drawing.Point(17, 642);
            this.btoExportToExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btoExportToExcel.Name = "btoExportToExcel";
            this.btoExportToExcel.Size = new System.Drawing.Size(239, 33);
            this.btoExportToExcel.TabIndex = 13;
            this.btoExportToExcel.Text = "Export to Excel";
            this.btoExportToExcel.UseVisualStyleBackColor = false;
            this.btoExportToExcel.Click += new System.EventHandler(this.btoExportToExcel_Click);
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubjectID,
            this.colSubjectName,
            this.colCredit});
            this.dgvSubjects.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSubjects.Location = new System.Drawing.Point(17, 236);
            this.dgvSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.RowHeadersWidth = 51;
            this.dgvSubjects.RowTemplate.Height = 24;
            this.dgvSubjects.Size = new System.Drawing.Size(1208, 399);
            this.dgvSubjects.TabIndex = 12;
            this.dgvSubjects.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_RowEnter);
            // 
            // colSubjectID
            // 
            this.colSubjectID.DataPropertyName = "SubjectID";
            this.colSubjectID.HeaderText = "SubjectID";
            this.colSubjectID.MinimumWidth = 6;
            this.colSubjectID.Name = "colSubjectID";
            this.colSubjectID.ReadOnly = true;
            // 
            // colSubjectName
            // 
            this.colSubjectName.DataPropertyName = "SubjectName";
            this.colSubjectName.HeaderText = "SubjectName";
            this.colSubjectName.MinimumWidth = 6;
            this.colSubjectName.Name = "colSubjectName";
            this.colSubjectName.ReadOnly = true;
            // 
            // colCredit
            // 
            this.colCredit.DataPropertyName = "Credit";
            this.colCredit.HeaderText = "Credit";
            this.colCredit.MinimumWidth = 6;
            this.colCredit.Name = "colCredit";
            this.colCredit.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tboCredit);
            this.groupBox1.Controls.Add(this.tboSubjectName);
            this.groupBox1.Controls.Add(this.tboSubjectID);
            this.groupBox1.Controls.Add(this.btoSearch);
            this.groupBox1.Controls.Add(this.btoDelete);
            this.groupBox1.Controls.Add(this.btoUpdate);
            this.groupBox1.Controls.Add(this.btoAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1208, 214);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subjects";
            // 
            // tboCredit
            // 
            this.tboCredit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboCredit.Location = new System.Drawing.Point(97, 112);
            this.tboCredit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboCredit.Name = "tboCredit";
            this.tboCredit.Size = new System.Drawing.Size(291, 31);
            this.tboCredit.TabIndex = 17;
            // 
            // tboSubjectName
            // 
            this.tboSubjectName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSubjectName.Location = new System.Drawing.Point(567, 66);
            this.tboSubjectName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboSubjectName.Name = "tboSubjectName";
            this.tboSubjectName.Size = new System.Drawing.Size(468, 31);
            this.tboSubjectName.TabIndex = 12;
            // 
            // tboSubjectID
            // 
            this.tboSubjectID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboSubjectID.Location = new System.Drawing.Point(137, 66);
            this.tboSubjectID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboSubjectID.Name = "tboSubjectID";
            this.tboSubjectID.Size = new System.Drawing.Size(291, 31);
            this.tboSubjectID.TabIndex = 9;
            // 
            // btoSearch
            // 
            this.btoSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoSearch.Location = new System.Drawing.Point(1056, 130);
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
            this.btoDelete.Location = new System.Drawing.Point(891, 130);
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
            this.btoUpdate.Location = new System.Drawing.Point(725, 130);
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
            this.btoAdd.Location = new System.Drawing.Point(560, 130);
            this.btoAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btoAdd.Name = "btoAdd";
            this.btoAdd.Size = new System.Drawing.Size(144, 49);
            this.btoAdd.TabIndex = 8;
            this.btoAdd.Text = "Add";
            this.btoAdd.UseVisualStyleBackColor = true;
            this.btoAdd.Click += new System.EventHandler(this.btoAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SubjectID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Credit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "SubjectName";
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 702);
            this.Controls.Add(this.btoExportToExcel);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1241, 702);
            this.MinimumSize = new System.Drawing.Size(1241, 702);
            this.Name = "Subjects";
            this.Text = "Subjects";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btoExportToExcel;
        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboCredit;
        private System.Windows.Forms.TextBox tboSubjectName;
        private System.Windows.Forms.TextBox tboSubjectID;
        private System.Windows.Forms.Button btoSearch;
        private System.Windows.Forms.Button btoDelete;
        private System.Windows.Forms.Button btoUpdate;
        private System.Windows.Forms.Button btoAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
    }
}