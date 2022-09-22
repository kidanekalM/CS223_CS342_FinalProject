using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Real_Estate_App.Model
{
    internal class Client : CommonDBOperations
    {
        private string ID { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Email { get; set; }
        private string PhoneNumber { get; set; }
        private string Password { get; set; }
        private string EmployeeID { get; set; }

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
        /// Search the database table for matches in every record
        /// </summary>
        /// <param name="value"></param>
        /// <returns>List of Client </returns>
        public static List<Client> Search(string value)
        {
            throw new NotImplementedException();
        }

        static List<Client> ChangeToList(SqlDataReader dr)
        {
            List<Client> list = new List<Client>();
            while (dr.Read())
            {
                Client cl = new Client();
                cl.ID = dr["ID"].ToString();
                cl.FirstName = dr["FirstName"].ToString();
                cl.LastName = dr["LastName"].ToString();
                cl.PhoneNumber = dr["PhoneNumber"].ToString();
                cl.Password = dr["Password"].ToString();
                cl.EmployeeID = dr["EmpId"].ToString();
                cl.Email = dr["Email"].ToString();
                list.Add(cl);
            }
            return list;
            
        }
    }
}
