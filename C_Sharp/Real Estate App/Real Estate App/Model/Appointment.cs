using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_App.Model
{
    internal class Appointment : CommonDBOperations
    {
        public string ID { get; set; }
        public string ClientID { get; set; }
        public string agnetID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public List<string> PropertyID { get; set; }
        public string Comment { get; set; }

        public int Add()
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
        public static List<Appointment> GetAllAppointments()
        {
            throw new NotImplementedException();
        }
        
         /// <summary>
         /// Filters all appointements with the same client(id) 
         /// </summary>
         /// <param name="client"></param>
         /// <returns>List of Appointment</returns>
         
        public static List<Appointment> GetAllByClient(Client client)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Filters all appointements with the same Agent(id) 
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>List of Applointment</returns>
        public static List<Appointment> GetAllByAgent(Employee employee)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///   Filters all appointements with the same Property(id) 
        /// </summary>
        /// <param name="property"></param>
        /// <returns>List of Applointment</returns>

        public static List<Appointment> GetAllByProerty(Property property)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Filters all appointements with the same Date 
        /// </summary>
        /// <param name="date"></param>
        /// <returns>List of Applointment</returns>

        public static List<Appointment> GetAllByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// returns properties with similar id client id agentid appointmentdate propertyid or comment
        /// </summary>
        /// <param name="value"></param>
        /// <returns>List of Applointment</returns>

        public static List<Appointment> SearchAppointment(string value)
        {
            throw new NotImplementedException();
        }
        static List<Appointment> ChangeToList(SqlDataReader dr)
        {
            List<Appointment> list = new List<Appointment>();
            while (dr.Read())
            {
                Appointment appointment = new Appointment();
                appointment.ID = dr["ID"].ToString();
                appointment.AppointmentDate = (DateTime)dr["AppointmentDate"];
                appointment.Comment = dr["Comment"].ToString();
                appointment.ClientID = dr["ClientID"].ToString();
                appointment.agnetID = dr["AgentID"].ToString();
                appointment.PropertyID = GetChoosenProperty(appointment.ID);
                list.Add(appointment);
            }
            return list;
        }
        static List<string> GetChoosenProperty(string appointmentId)
        {
            throw new NotSupportedException();
        }
    }
}
