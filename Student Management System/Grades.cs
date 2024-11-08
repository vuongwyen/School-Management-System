using Student_Management_System;
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
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();

            loadDgv();
        }

        private void Grades_Load(object sender, EventArgs e)
        {

        }

        public void loadDgv()
        {
            dgvGrades.DataSource = Database.Query("SELECT * FROM Grades");
        }

        private void dgvGrades_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tboStudentID.Text = dgvGrades.Rows[rowIndex].Cells["colStudentID"].Value.ToString();
            tboGradeID.Text = dgvGrades.Rows[rowIndex].Cells["colGradeID"].Value.ToString();
            tboSubjectID.Text = dgvGrades.Rows[rowIndex].Cells["colSubjectID"].Value.ToString();
            tboGrade.Text = dgvGrades.Rows[rowIndex].Cells["colGrade"].Value.ToString();
        }

        private void btoAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Grades (StudentID,SubjectID,Grade) VALUES (@StudentID,@SubjectID,@Grade)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@StudentID", tboStudentID.Text);
            parameters.Add("@SubjectID", tboSubjectID.Text);
            parameters.Add("@Grade", tboGrade.Text);
            try
            {
                Database.Query(sql,parameters);
                loadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btoUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Grades SET StudentID = @StudentID,SubjectID = @SubjectID , Grade = @Grade WHERE GradeID = @GradeID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@GradeID", tboGradeID.Text);
            parameters.Add("@StudentID", tboStudentID.Text);
            parameters.Add("@SubjectID", tboSubjectID.Text);
            parameters.Add("@Grade", tboGrade.Text);
            try
            {
                Database.Query(sql, parameters);
                loadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btoDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Grades WHERE GradeID = @GradeID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@GradeID", tboGradeID.Text);
            try
            {
                Database.Query(sql, parameters);
                loadDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btoSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Grades WHERE GradeID = @GradeID ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@GradeID", tboGradeID.Text);
            try
            {
                dgvGrades.DataSource = Database.Query(sql, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btoExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvGrades.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);

                // Set the headers
                for (int i = 1; i <= dgvGrades.Columns.Count; i++)
                {
                    MExcel.Cells[1, i] = dgvGrades.Columns[i - 1].HeaderText;
                }

                // Fill the data
                for (int i = 0; i < dgvGrades.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvGrades.Columns.Count; j++)
                    {
                        Convert.ToString(MExcel.Cells[i + 2, j + 1] = dgvGrades.Rows[i].Cells[j].Value);
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
//(Classes.ClassName = @ClassName OR @ClassName IS NULL) AND (Subjects.SubjectName = @SubjectName OR @SubjectName IS NULL)