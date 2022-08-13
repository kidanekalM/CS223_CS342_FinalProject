using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Real_Estate_App.Model
{
     public class SQL_Connection
    {
        static SqlConnection myConn;
        static string ServerName = "Server=DESKTOP-HA15RJO;";
        static string ConnectionType = "Trusted_Connection=True;";
        /// <summary>
        /// Creates the conection in a static way
        /// </summary>
        static SQL_Connection()
        {
            String connectionStrng = ServerName+"Database=RealEstate;" + ConnectionType;
            try
            {
                myConn = new SqlConnection(connectionStrng);   
                myConn.Open();

                MessageBox.Show("Connected to database RealEstate ");
            }
            catch (Exception e)
            {
                MessageBox.Show("The database RealEstate may not exist"+"\n"+e.Message);       
            }
        }
        /// <summary>
        /// Executes SQL statements that return a resultset or a table
        /// </summary>
        /// <param name="query"></param>
        /// <returns>retunrns SqlDataReader</returns>
        public static SqlDataReader Query(string query)
        {
            try 
            { 
            SqlCommand cmd = new SqlCommand(query, myConn);
            return cmd.ExecuteReader();
            }
            catch(Exception e)
            {
                return null;
            }
        }
        /// <summary>
        /// Executes SQL statements that do not return a result set
        /// </summary>
        /// <param name="query"></param>
        /// <returns>bool true for success</returns>
        public static bool NonQuery(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, myConn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        /// <summary>
        /// creates an instance of sql command 
        /// </summary>
        /// <returns>SqlCommand </returns>
        public static SqlCommand GetPreparedStatement()
        {
            SqlCommand cmd = new SqlCommand(null, myConn);
            return cmd;
        }
    }
}
