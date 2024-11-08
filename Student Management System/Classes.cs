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
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();

            loadDgv();
        }

        public void loadDgv()
        {
            dgvClasses.DataSource = Database.Query("SELECT * FROM Classes");
        }


        private void dgvClasses_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tboClassID.Text = dgvClasses.Rows[rowIndex].Cells["colClassID"].Value.ToString();
            tboClassName.Text = dgvClasses.Rows[rowIndex].Cells["colClassName"].Value.ToString();
            tboTeacherID.Text = dgvClasses.Rows[rowIndex].Cells["colTeacherID"].Value.ToString();
        }

        private void btoAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Classes (ClassID,ClassName,TeacherID) VALUES (@ClassID,@ClassName,@TeacherID)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ClassID",tboClassID.Text);
            parameters.Add("@ClassName",tboClassName.Text);
            parameters.Add("@TeacherID",tboTeacherID.Text);
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
            string sql = "UPDATE Classes SET ClassName = @ClassName ,TeacherID = @TeacherID WHERE ClassID = @ClassID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ClassID", tboClassID.Text);
            parameters.Add("@ClassName", tboClassName.Text);
            parameters.Add("@TeacherID", tboTeacherID.Text);
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
            string sql = "DELETE FROM Classes WHERE ClassID = @ClassID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ClassID", dgvClasses.CurrentRow.Cells["colClassID"].Value);
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
            string sql = "SELECT * FROM Classes WHERE ClassID = @ClassID ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@ClassID", tboClassID.Text);
            try
            {
                dgvClasses.DataSource = Database.Query(sql, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btoExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvClasses.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);

                // Set the headers
                for (int i = 1; i <= dgvClasses.Columns.Count; i++)
                {
                    MExcel.Cells[1, i] = dgvClasses.Columns[i - 1].HeaderText;
                }

                // Fill the data
                for (int i = 0; i < dgvClasses.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvClasses.Columns.Count; j++)
                    {
                        Convert.ToString(MExcel.Cells[i + 2, j + 1] = dgvClasses.Rows[i].Cells[j].Value);
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
