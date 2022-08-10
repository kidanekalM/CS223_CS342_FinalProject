using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_App.Model
{
    internal class Appointment
    {
        public string ID { get; set; }
        public string ClientID { get; set; }
        public string agnetID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public List<string> PropertyID { get; set; }
        public string Comment { get; set; }
        /***
         * Add appointment to database
         */
        public bool Add()
        {

        }
        public bool Update()
        {

        }
        public bool Delete()
        {

        }
        public static List<Appointment> GetAllAppointments()
        {

        }
        /***
         * Filters all appointements with the same client(id) 
         */
        public static List<Appointment> GetAllByClient(Client client)
        {

        }
        /***
        * Filters all appointements with the same Agent(id) 
        */
        public static List<Appointment> GetAllByAgent(Agent agent)
        {

        }
        /***
           * Filters all appointements with the same Property(id) 
           */
        public static List<Appointment> GetAllByProerty(Property property)
        {

        }
        /***
        * Filters all appointements with the same AppointmetDate(id) 
        */
        public static List<Appointment> GetAllByAppointment(DateTime Date)
        {

        }

    }
}
