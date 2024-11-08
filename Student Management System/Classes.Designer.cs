namespace Student_Management_System
{
    partial class Classes
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
            this.tboTeacherID = new System.Windows.Forms.TextBox();
            this.tboClassName = new System.Windows.Forms.TextBox();
            this.tboClassID = new System.Windows.Forms.TextBox();
            this.btoSearch = new System.Windows.Forms.Button();
            this.btoDelete = new System.Windows.Forms.Button();
            this.btoUpdate = new System.Windows.Forms.Button();
            this.btoAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.colClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeacherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btoExportToExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tboTeacherID);
            this.groupBox1.Controls.Add(this.tboClassName);
            this.groupBox1.Controls.Add(this.tboClassID);
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
            this.groupBox1.Size = new System.Drawing.Size(1208, 209);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes";
            // 
            // tboTeacherID
            // 
            this.tboTeacherID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboTeacherID.Location = new System.Drawing.Point(116, 107);
            this.tboTeacherID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboTeacherID.Name = "tboTeacherID";
            this.tboTeacherID.Size = new System.Drawing.Size(291, 31);
            this.tboTeacherID.TabIndex = 17;
            // 
            // tboClassName
            // 
            this.tboClassName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboClassName.Location = new System.Drawing.Point(567, 66);
            this.tboClassName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboClassName.Name = "tboClassName";
            this.tboClassName.Size = new System.Drawing.Size(468, 31);
            this.tboClassName.TabIndex = 12;
            // 
            // tboClassID
            // 
            this.tboClassID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboClassID.Location = new System.Drawing.Point(116, 66);
            this.tboClassID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tboClassID.Name = "tboClassID";
            this.tboClassID.Size = new System.Drawing.Size(312, 31);
            this.tboClassID.TabIndex = 9;
            // 
            // btoSearch
            // 
            this.btoSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btoSearch.Location = new System.Drawing.Point(1051, 153);
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
            this.btoDelete.Location = new System.Drawing.Point(885, 153);
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
            this.btoUpdate.Location = new System.Drawing.Point(720, 153);
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
            this.btoAdd.Location = new System.Drawing.Point(555, 153);
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
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ClassID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "TeacherID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "ClassName";
            // 
            // dgvClasses
            // 
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClassID,
            this.colClassName,
            this.colTeacherID});
            this.dgvClasses.GridColor = System.Drawing.SystemColors.Control;
            this.dgvClasses.Location = new System.Drawing.Point(16, 231);
            this.dgvClasses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowHeadersWidth = 51;
            this.dgvClasses.RowTemplate.Height = 24;
            this.dgvClasses.Size = new System.Drawing.Size(1208, 404);
            this.dgvClasses.TabIndex = 10;
            this.dgvClasses.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_RowEnter);
            // 
            // colClassID
            // 
            this.colClassID.DataPropertyName = "ClassID";
            this.colClassID.HeaderText = "ClassID";
            this.colClassID.MinimumWidth = 6;
            this.colClassID.Name = "colClassID";
            this.colClassID.ReadOnly = true;
            // 
            // colClassName
            // 
            this.colClassName.DataPropertyName = "ClassName";
            this.colClassName.HeaderText = "ClassName";
            this.colClassName.MinimumWidth = 6;
            this.colClassName.Name = "colClassName";
            this.colClassName.ReadOnly = true;
            // 
            // colTeacherID
            // 
            this.colTeacherID.DataPropertyName = "TeacherID";
            this.colTeacherID.HeaderText = "TeacherID";
            this.colTeacherID.MinimumWidth = 6;
            this.colTeacherID.Name = "colTeacherID";
            this.colTeacherID.ReadOnly = true;
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
            this.btoExportToExcel.TabIndex = 12;
            this.btoExportToExcel.Text = "Export to Excel";
            this.btoExportToExcel.UseVisualStyleBackColor = false;
            this.btoExportToExcel.Click += new System.EventHandler(this.btoExportToExcel_Click);
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 702);
            this.Controls.Add(this.btoExportToExcel);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1241, 702);
            this.MinimumSize = new System.Drawing.Size(1241, 702);
            this.Name = "Classes";
            this.Text = "Classes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboTeacherID;
        private System.Windows.Forms.TextBox tboClassName;
        private System.Windows.Forms.TextBox tboClassID;
        private System.Windows.Forms.Button btoSearch;
        private System.Windows.Forms.Button btoDelete;
        private System.Windows.Forms.Button btoUpdate;
        private System.Windows.Forms.Button btoAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.Button btoExportToExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeacherID;
    }
}