using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public List<Image> Photo { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; }
        public float Area { get; set; }
        public float SellPrice { get; set; }
        public string Description { get; set; }
        public string ContractorID { get; set; }

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
        static List<Property> ChangeToList(SqlDataReader dr)
        {
            List<Property> list = new List<Property>();
            while (dr.Read())
            {
                Property property = new Property();
                
                property.Id = dr["ID"].ToString();
                property.Address = dr["Address"].ToString();
                property.SellPrice = (float)dr["Price"];
                property.Type = dr["Type"].ToString();
                property.Area = (float)dr["Area"];
                property.Status = (bool)dr["Status"];
                property.ContractorID = dr["ContractorID"].ToString();
                property.Description = dr["Description"].ToString();
                property.Photo = GetImages(property.Id);
                list.Add(property);
            }
            return list;
        }
        static List<Image> GetImages(string id)
        {
            throw new NotImplementedException();
        }
        static List<Image> AddImages(string id)
        {
            throw new NotImplementedException();
        }
        static List<Image> DeleteImages(string id)
        {
            throw new NotImplementedException();
        }
    }
}
