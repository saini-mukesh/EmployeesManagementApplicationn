using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arraylist3
{
    public partial class Departments : Form
    {
        Employee emp = new Employee();

        public Departments()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add code to insert departs to Database
            if (txtDept.Text == "")
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Please enter employee name";
                return;
            }

            string res = emp.AddDepartment(txtDept.Text);

            if (res.ToLower().Contains("success"))
            {
                lblMsg.ForeColor = Color.Green;
                txtDept.Text = "";
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
            }

            lblMsg.Text = res;

            dgvDepartment.DataSource = emp.GetAllDepartments();
            dgvDepartment.Refresh();
        }

        private void Departments_Load(object sender, EventArgs e)
        {
            dgvDepartment.DataSource = emp.GetAllDepartments();
            dgvDepartment.Refresh();
        }
    }
}
