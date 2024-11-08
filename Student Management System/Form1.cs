using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class loginSite : Form
    {
        public loginSite()
        {
            InitializeComponent();
        }

        private void btoLogin_Click(object sender, EventArgs e)
        {
            if (tboUsername.Text == "admin" && tboPassword.Text == "12345")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("The username or password is incorrect");
                tboPassword.Clear();
                tboPassword.Focus();
                tboUsername.Clear();
            }
        }
    }
}
