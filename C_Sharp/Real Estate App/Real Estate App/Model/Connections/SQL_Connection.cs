using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
//Microsoft.SqlServer.ConnectionInfo.dll
using Microsoft.SqlServer.Management.Common;

namespace Real_Estate_App.Model
{
     public class SQL_Connection
    {
        static Microsoft.Data.SqlClient.SqlConnection myConn;
        static string ServerName = "Server=DESKTOP-HA15RJO;";
        static string ConnectionType = "Trusted_Connection=True;";
        static SQL_Connection()
        {
            String connectionStrng = ServerName+"Database=RealEstate;" + ConnectionType;
            try
            {
                myConn = new Microsoft.Data.SqlClient.SqlConnection(connectionStrng);   
                myConn.Open();
            }
            catch (Exception e)
            {
                try
                {
                    connectionStrng = ServerName + "Database=MASTER;" + ConnectionType;
                    myConn = new Microsoft.Data.SqlClient.SqlConnection(connectionStrng);
                    FileInfo fileInfo = new FileInfo("C:\\Users\\hp\\Desktop\\New folder\\code\\CS223_CS342_FinalProject\\C_Sharp\\Real Estate App\\Real Estate App\\Model\\Connections\\RealEstateDatabaseDefinitions.sql");
                    string script = fileInfo.OpenText().ReadToEnd();
                    Server server = new Server(new ServerConnection(myConn,null));
                    //TODO: make the database here
                    server.ConnectionContext.ExecuteNonQuery(script);

                    myConn.ChangeDatabase("RealEstate");
                }
                catch(Exception e2)
                {
                    MessageBox.Show(e.Message+"\n"+e2.Message);
                }
                    
            }
        }
        /*
        static SqlDataReader ExecuteQuery(string query)
        {
            SqlDataReader dr = null;
            try
            {
                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = myConn;
                dr = cmd.ExecuteReader();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dr;
        }*/
    }
}
