using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace arraylist3
{
    internal class Employee
    {
        string conString = "server=INBOOK_X1\\SQLEXPRESS;database=EmpDB;Integrated Security=True;";
        
        
        public DataTable GetAllEmplyees()
        {
            DataTable dtEmp = new DataTable();

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select Employee.EmpId, Employee.EmpName, Employee.EmpSalary, Department.DeptName, Department.DeptLocation from Employee INNER JOIN Department ON Employee.DeptId = Department.DeptId", con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtEmp);
                        con.Close();
                    }
                }
            }

            return dtEmp;
        }



        public DataTable GetAllDepartments()
        {
            DataTable dtEmp = new DataTable();

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("Select DeptId, DeptName From Department", con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtEmp);
                        con.Close();
                    }
                }
            }

            return dtEmp;
        }

        public string AddEmployee(string EmpName, int Salary, int DeptId)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdText = "insert into Employee(EmpName, EmpSalary, DeptId) values ('" + EmpName + "', " + Salary.ToString() + ", " + DeptId.ToString() + " )";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    int res = cmd.ExecuteNonQuery();

                    if (res > 0)
                    {
                        return "Employee Addedd Successfuly";
                    }
                    else
                    {
                        return "Unable to Add Employee";
                    }
                }
            }
        }

        public string DeleteEmployee(int EmptId)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdText = "Delete from Employee Where EmpId = " + EmptId.ToString();
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    int res = cmd.ExecuteNonQuery();

                    if (res > 0)
                    {
                        return "Employee Deleted Successfuly";
                    }
                    else
                    {
                        return "Unable to Delete Employee";
                    }
                }
            }
        }
    }
}
