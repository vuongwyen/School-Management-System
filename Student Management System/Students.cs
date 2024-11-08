using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Student_Management_System
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();

            loadDgv();
        }

        public void loadDgv()
        {
            dgvStudents.DataSource = Database.Query("SELECT * FROM Students");
        }

        private void dgvStudents_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tboStudentID.Text = dgvStudents.Rows[rowIndex].Cells["colStudentID"].Value.ToString();
            tboFullName.Text = dgvStudents.Rows[rowIndex].Cells["colFullName"].Value.ToString();
            dtpDateOfBirth.Value = Convert.ToDateTime(dgvStudents.Rows[rowIndex].Cells["colDateOfBirth"].Value);
            cboSex.SelectedItem = dgvStudents.Rows[rowIndex].Cells["colSex"].Value.ToString();
            tboAddress.Text = dgvStudents.Rows[rowIndex].Cells["colAddress"].Value.ToString();
            tboClassID.Text = dgvStudents.Rows[rowIndex].Cells["colClassID"].Value.ToString();
        }
        public static string GetFormattedDate(DateTimePicker dateTimePicker)
        {
            return dateTimePicker.Value.ToString("yyyy-MM-dd");
        }

        private void btoAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Students(StudentID,FullName,DateOfBirth,Sex,Address,ClassID) " +
                "VALUES (@StudentID,@FullName,@DateOfBirth,@Sex,@Address,@ClassID)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@StudentID", tboStudentID.Text);
            parameters.Add("@FullName", tboFullName.Text);
            parameters.Add("@DateOfBirth", GetFormattedDate(dtpDateOfBirth));
            parameters.Add("@Sex", cboSex.SelectedItem);
            parameters.Add("@Address", tboAddress.Text);
            parameters.Add("@ClassID", tboClassID.Text);
            try
            {
                Database.Execute(sql, parameters);
                loadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btoUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Students SET FullName = @FullName, DateOfBirth = @DateOfBirth, " +
                       "Sex = @Sex, Address = @Address, ClassID = @ClassID WHERE StudentID = @StudentID";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@StudentID", tboStudentID.Text);
            parameters.Add("@FullName", tboFullName.Text);
            parameters.Add("@DateOfBirth", GetFormattedDate(dtpDateOfBirth));
            parameters.Add("@Sex", cboSex.SelectedItem);
            parameters.Add("@Address", tboAddress.Text);
            parameters.Add("@ClassID", tboClassID.Text);
            try
            {
                Database.Execute(sql, parameters);
                loadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btoDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Students WHERE StudentId = @StudentID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@StuddentID", dgvStudents.CurrentRow.Cells["colStudentID"].Value);
            try
            {
                Database.Execute(sql, parameters);
                loadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btoSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Students WHERE StudentId = @StudentID ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@StudentID", tboStudentID.Text);
            try
            {
                dgvStudents.DataSource = Database.Query(sql, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btoExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvStudents.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);

                // Set the headers
                for (int i = 1; i <= dgvStudents.Columns.Count; i++)
                {
                    MExcel.Cells[1, i] = dgvStudents.Columns[i - 1].HeaderText;
                }

                // Fill the data
                for (int i = 0; i < dgvStudents.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvStudents.Columns.Count; j++)
                    {
                        Convert.ToString(MExcel.Cells[i + 2, j + 1] = dgvStudents.Rows[i].Cells[j].Value);
                    }
                }

                // Adjust the layout
                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Cells.Font.Size = 12;
                MExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
