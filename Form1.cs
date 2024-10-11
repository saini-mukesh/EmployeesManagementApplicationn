using System.Windows.Forms;
using System.Collections;

namespace arraylist3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ArrayList ListEmp = new ArrayList();
        Employee emp = new Employee();



        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtEmpName.Text == "")
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Please enter employee name";
                return;
            }
            if (txtSalary.Text == "")
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Please enter salary";
                return;
            }

            int resInt = 0;
            Int32.TryParse(txtSalary.Text, out resInt);
            
            if(resInt <= 0)
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Please enter salary in numbers";
                return;
            }
             

            string res = emp.AddEmployee(txtEmpName.Text, Convert.ToInt32(txtSalary.Text), Convert.ToInt32(ddlDept.SelectedValue));

            if (res.ToLower().Contains("success"))
            {
                lblMsg.ForeColor = Color.Green;
                txtEmpName.Text = "";
                txtSalary.Text = "";
                ddlDept.SelectedIndex = 0;
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
            }

            lblMsg.Text = res;

            dgvEmployee.DataSource = emp.GetAllEmplyees();
            dgvEmployee.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var rows = dgvEmployee.SelectedRows;

            if (rows != null && rows.Count > 0)
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    int EmpId = Convert.ToInt32(rows[i].Cells[0].Value);
                    string res = emp.DeleteEmployee(EmpId);

                    if (res.ToLower().Contains("success"))
                    {
                        lblMsg.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblMsg.ForeColor = Color.Red;
                    }

                    lblMsg.Text = res;
                }                

                dgvEmployee.DataSource = emp.GetAllEmplyees();
                dgvEmployee.Refresh();
            }
            else
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "Employee not selected";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dgvEmployee.DataSource = emp.GetAllEmplyees();
                dgvEmployee.Refresh();

                ddlDept.DisplayMember = "DeptName";
                ddlDept.ValueMember = "DeptId";
                ddlDept.DataSource = emp.GetAllDepartments();
                ddlDept.Refresh();

            }
            catch (Exception ex)
            {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = ex.Message;
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    emp = new Employee();
        //    emp.AddEmployee(int.Parse(txtEmpName.Text), txtSalary.Text, char.Parse(textBox3.Text));
        //    ListEmp.Add(emp);
        //    txtEmpName.Clear();
        //    txtSalary.Clear();
        //    textBox3.Clear();
        //}
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    emp = (Employee)ListEmp[0];
        //    txtEmpName.Text = emp.FunId().ToString();
        //    txtSalary.Text = emp.FunName();
        //    textBox3.Text = emp.FunGender().ToString();
        //}


    }
}