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
        /***
         * Update a property in the database table
         */
        public bool Update()
        {

        }
        /***
         * Delete a property from database table
         */
        public bool Delete()
        {

        }
        /***
         * Add a property to the database table 
         */
        public bool Add()
        {

        }
        /***
         * get all properties
         */
        public List<Property> GetAllProperties()
        {

        }
        /***
           * get all available properties
          */
        public List<Property> GetAllAvailableProperties()
        {

        }
        /***
         * Filter properties by address
         * type
         * sell price  
         */
        public List<Property> FilterProperties(string address, string type,string status, float sellPrice)
        {

        }
        /***
         * Get all properties that were sold 
         */
        public List<Property> GetAllSoldProperties()
        {

        }
    }
}
