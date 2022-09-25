using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Real_Estate_App.Model
{
     public class SQL_Connection
    {
        static SqlConnection myConn;
        //static string ServerName = "Server=DESKTOP-HA15RJO;";
        //static string ConnectionType = "Trusted_Connection=True;";
        /// <summary>
        /// Creates the conection in a static way
        /// </summary>
         public SQL_Connection(string user)
        {

            try
            {
                String connectionStrng = ConfigurationManager.ConnectionStrings[$"{user}ConnectionString"].ConnectionString;

                myConn = new SqlConnection(connectionStrng);   
                myConn.Open();

                MessageBox.Show($"Connected to database RealEstate as {user}");
            }
            catch (Exception e)
            {
                MessageBox.Show("The database RealEstate may not exist"+"\n"+e.Message);       
            }
            myConn.Close();
        }
        /// <summary>
        /// Executes SQL statements that return a resultset or a table
        /// </summary>
        /// <param name="query"></param>
        /// <returns>retunrns SqlDataReader</returns>
        public static DataTable Query(string query)
        {
            try 
            {
                myConn.Open();
                SqlCommand cmd = new SqlCommand(query,myConn);
                DataTable dt = new DataTable();
                dt.Load( cmd.ExecuteReader());
                myConn.Close();
                return dt;
            }
            catch(Exception e)
            {
                myConn.Close();
                MessageBox.Show(e.Source + e.Message );
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
                myConn.Open();
                SqlCommand cmd = new SqlCommand(query, myConn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            myConn.Close();
        }
        /// <summary>
        /// creates an instance of sql command 
        /// </summary>
        /// <returns>SqlCommand </returns>
        public static SqlCommand GetPreparedStatement()
        {
            myConn.Open();
            SqlCommand cmd = new SqlCommand(null, myConn);
            
            return cmd;
        }
        public static MemoryStream GetBytes(Image image)
        {
            if (image == null)
            {
                return null;
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                return ms;
            }
        }
    }
}
