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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();

            loadDgv();
        }

        public void loadDgv()
        {
            dgvSubjects.DataSource = Database.Query("SELECT * FROM Subjects");
        }

        private void dgvSubjects_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tboSubjectID.Text = dgvSubjects.Rows[rowIndex].Cells["colSubjectID"].Value.ToString();
            tboSubjectName.Text = dgvSubjects.Rows[rowIndex].Cells["colSubjectName"].Value.ToString();
            tboCredit.Text = dgvSubjects.Rows[rowIndex].Cells["colCredit"].Value.ToString();
        }

        private void btoAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Subjects (SubjectID,SubjectName,Credit) VALUES (@SubjectID,@SubjectName,@Credit)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@SubjectID", tboSubjectID.Text);
            parameters.Add("@SubjectName", tboSubjectName.Text);
            parameters.Add("@Credit", tboCredit.Text);
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
            string sql = "UPDATE Subjects SET SubjectName = @SubjectName,Credit = @Credit WHERE SubjectID = @SubjectID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@SubjectID", tboSubjectID.Text);
            parameters.Add("@SubjectName", tboSubjectName.Text);
            parameters.Add("@Credit", tboCredit.Text);
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
            string sql = "DELETE FROM Subjects WHERE SubjectID = @SubjectID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@SubjectID", dgvSubjects.CurrentRow.Cells["colSubjectID"].Value);
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
            string sql = "SELECT * FROM Subjects WHERE SubjectID = @SubjectID ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@SubjectID", tboSubjectID.Text);
            try
            {
                dgvSubjects.DataSource = Database.Query(sql, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btoExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);

                // Set the headers
                for (int i = 1; i <= dgvSubjects.Columns.Count; i++)
                {
                    MExcel.Cells[1, i] = dgvSubjects.Columns[i - 1].HeaderText;
                }

                // Fill the data
                for (int i = 0; i < dgvSubjects.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvSubjects.Columns.Count; j++)
                    {
                        Convert.ToString(MExcel.Cells[i + 2, j + 1] = dgvSubjects.Rows[i].Cells[j].Value);
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
