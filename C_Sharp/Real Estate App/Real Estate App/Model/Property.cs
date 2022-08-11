using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_App.Model
{
    internal class Property
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public Image Photo { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public float SellPrice { get; set; }
        

        public bool Update()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Add()
        {
            throw new NotImplementedException();
        }
        
         /// <summary>
         /// get all properties
         /// </summary>
         /// <returns>List of Property type</returns>
         
        public static List<Property> GetAllProperties()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// get all available properties
        /// </summary>
        /// <returns>List of Property type</returns>
        
        public static List<Property> GetAllAvailableProperties()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Filter properties by address type  sell price  
        /// </summary>
        /// <param name="address"></param>
        /// <param name="type"></param>
        /// <param name="status"></param>
        /// <param name="sellPrice"></param>
        /// <returns>List of Property type</returns>
        
        public static List<Property> FilterProperties(string address, string type,string status, float sellPrice)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get all properties that were sold 
        /// </summary>
        /// <returns>List of Property type</returns>
        
        public static List<Property> GetAllSoldProperties()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// searches the database table for similar values with the attributes of the 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>List of Property type</returns>
        
        public static List<Property> SearchProperties(string value)
        {
            throw new NotSupportedException();
        }
    }
}
