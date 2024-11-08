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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();

            loadDgv();
        }

        public void loadDgv()
        {
            dgvTeachers.DataSource = Database.Query("SELECT * FROM Teachers");
        }

        private void dgvTeachers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tboTeacherID.Text = dgvTeachers.Rows[rowIndex].Cells["colTeacherID"].Value.ToString();
            tboFullName.Text = dgvTeachers.Rows[rowIndex].Cells["colFullName"].Value.ToString();
            tboSubjectID.Text = dgvTeachers.Rows[rowIndex].Cells["colSubjectID"].Value.ToString();
            tboSubjectName.Text = dgvTeachers.Rows[rowIndex].Cells["colSubjectName"].Value.ToString();
            tboPhoneNumber.Text = dgvTeachers.Rows[rowIndex].Cells["colPhoneNumber"].Value.ToString();
            tboEmail.Text = dgvTeachers.Rows[rowIndex].Cells["colEmail"].Value.ToString();
        }

        private void btoAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Teachers(TeacherID,FullName,SubjectID,PhoneNumber,Email,SubjectName) " +
                "VALUES (@TeacherID,@FullName,@SubjectID,@PhoneNumber,@Email,@SubjectName)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@TeacherID", tboTeacherID.Text);
            parameters.Add("@FullName",tboFullName.Text);
            parameters.Add("@SubjectID", tboSubjectID.Text);
            parameters.Add("@SubjectName",tboSubjectName.Text);
            parameters.Add("@PhoneNumber",tboPhoneNumber.Text);
            parameters.Add("@Email",tboEmail.Text);
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
            string sql = "UPDATE Teachers SET TeacherID = @TeacherID, FullName = @FullName,SubjectName = @SubjectName,SubjectID = @SubjectID, PhoneNumber = @PhoneNumber," +
                " Email = @Email WHERE TeacherID = @TeacherID OR SubjectID = @SubjectID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@TeacherID", tboTeacherID.Text);
            parameters.Add("@FullName", tboFullName.Text);
            parameters.Add("@SubjectID", tboSubjectID.Text);
            parameters.Add("@SubjectName", tboSubjectName.Text);
            parameters.Add("@PhoneNumber", tboPhoneNumber.Text);
            parameters.Add("@Email", tboEmail.Text);
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
            string sql = "DELETE FROM Teachers WHERE TeacherID = @TeacherID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@TeacherID", dgvTeachers.CurrentRow.Cells["colTeacherID"].Value);
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
            string sql = "SELECT * FROM Teachers WHERE TeacherID = @TeacherID ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@TeacherID", tboTeacherID.Text);
            try
            {
                dgvTeachers.DataSource = Database.Query(sql, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btoExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);

                // Set the headers
                for (int i = 1; i <= dgvTeachers.Columns.Count; i++)
                {
                    MExcel.Cells[1, i] = dgvTeachers.Columns[i - 1].HeaderText;
                }

                // Fill the data
                for (int i = 0; i < dgvTeachers.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvTeachers.Columns.Count; j++)
                    {
                        Convert.ToString(MExcel.Cells[i + 2, j + 1] = dgvTeachers.Rows[i].Cells[j].Value);
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
