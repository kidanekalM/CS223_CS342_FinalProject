using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_App.Model
{
    internal class Employee : CommonDBOperations
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Image Photo { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Password { get; set; }
        public string DepartmentID { get; set; }
        public string EmployeeType { get; set; }

       
        public bool Add()
        {
            throw new NotImplementedException();
        }
         
        public bool Update()
        {
            throw new NotImplementedException();
        }
         
        public bool Delete()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  return all agents in the employee table of the database
        /// </summary>
        /// <returns>List<Employee></returns>
         
        public static List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }
        
         /// <summary>
         /// returns a list of all employees in the database together with the departments
         /// </summary>
         /// <returns>List<Employee></returns>
         
        public static List<Employee> GetAllEmployeesWithDep()
        {
            throw new NotImplementedException();
        }
        
         /// <summary>
         /// returns a list of all admins
         /// </summary>
         /// <returns>List<Employees></returns>
         
        public static List<Employee> GetAllAdmins()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        ///  searches the database table with similar 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>List<Employees></returns>
         
        public static List<Employee> SearchEmployees(string value)
        {
            throw new NotSupportedException();
        }
        static List<Employee> ChangeToList(SqlDataReader dr)
        {
            List<Employee> employees = new List<Employee>();
            while (dr.Read())
            {
                Employee employee = new Employee();

                employee.ID = (int)dr["ID"];
                employee.FirstName = dr["FirstName"].ToString();
                employee.LastName = dr["LastName"].ToString();
                employee.PhoneNumber = dr["PhoneNumber"].ToString();
                employee.EmploymentDate = (DateTime)dr["EmpDate"];
                employee.Password = dr["Password"].ToString();
                employee.DepartmentID = dr["DepartementID"].ToString();
                employee.EmployeeType = dr["EmpType"].ToString();
                employee.Photo = (Image)dr["Photo"];
                employees.Add(employee);
            }    
            return employees;
        }
    }
}
