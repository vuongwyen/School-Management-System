using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            loadForm(new Students());
        }
        
        public void loadForm(object Form)
        {
            if(this.mainPanel.Controls.Count > 0)this.mainPanel.Controls.RemoveAt(0);
            {
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(f);
                this.mainPanel.Tag = f;
                f.Show();
            }
        }

        private void menusidebarStudents_Click(object sender, EventArgs e)
        {
            loadForm(new Students());
        }

        private void menusidebarTeachers_Click(object sender, EventArgs e)
        {
            loadForm(new Teachers());
        }

        private void menusidebarClass_Click(object sender, EventArgs e)
        {
            loadForm(new Classes());
        }

        private void menusidebarSubjects_Click(object sender, EventArgs e)
        {
            loadForm(new Subjects());
        }

        private void menusidebarGrade_Click(object sender, EventArgs e)
        {
            loadForm(new Grades());
        }
    }
}
