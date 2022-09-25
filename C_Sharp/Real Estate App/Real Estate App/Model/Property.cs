using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Real_Estate_App.Model
{
    internal class Property
    {
        private static List<Property> Properties = new List<Property>();
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Image> Photo { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; }
        public double Area { get; set; }
        public double SellPrice { get; set; }
        public string Description { get; set; }
        public int ContractorID { get; set; }

        public void Delete()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source =7AMOOZ;Initial Catalog=RealEstate;Integrated Security=true;");
                con.Open();
                SqlCommand cmd = new SqlCommand($"exec [Delete Property] {this.Id}", con);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                
            }
        }

        public void Update()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source =7AMOOZ;Initial Catalog=RealEstate;Integrated Security=true;");
                con.Open();
                SqlCommand cmd = new SqlCommand($"exec [Update Property] {this.Id},'{this.Address}',{this.SellPrice},'{this.Type}',{this.Area},'{this.Status}',{this.ContractorID},'{this.Description}'", con);
                cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {

            }
        }
        public void Add()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source =7AMOOZ;Initial Catalog=RealEstate;Integrated Security=true;");
                con.Open();
                SqlCommand cmd = new SqlCommand($"exec [Add Property] '{this.Address}',{this.SellPrice},'{this.Type}',{this.Area},'{this.Status}',{this.ContractorID},'{this.Description}'", con);
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                
            }
        }


        /// <summary>
        /// get all properties
        /// </summary>
        /// <returns>List of Property type</returns>

        public static List<Property> GetAllProperties()
        {
            List<Property> temp = new List<Property>();
            try
            {

                SqlConnection con = new SqlConnection("Data Source =7AMOOZ;Initial Catalog=RealEstate;Integrated Security=true;");
                con.Open();
                SqlCommand cmd = new SqlCommand($"Select * from Property", con);
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    temp.Add(new Property()
                    {
                        Id = (int)result["ID"],
                        Address = (string)result["Address"],
                        SellPrice = (double)result["Price"],
                        Type = (string)result["Type"],
                        Area = (double)result["Area"],
                        Status = (bool)result["Status"],
                        ContractorID = (int)result["ContractorID"],
                        Description = (string)result["Description"]
                    }
                    );
                }


            }
            catch (Exception ex)
            {
                
            }
            return temp;
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
        
        public static List<Property> SearchPropertiesbyId(string value)
        {
            List<Property> temp = new List<Property>();
            try
            {

                SqlConnection con = new SqlConnection("Data Source =7AMOOZ;Initial Catalog=RealEstate;Integrated Security=true;");
                con.Open();
                SqlCommand cmd = new SqlCommand($"exec [Search Property By ID] {value}", con);
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    temp.Add(new Property()
                    {
                        Id = (int)result["ID"],
                        Address = (string)result["Address"],
                        SellPrice = (double)result["Price"],
                        Type = (string)result["Type"],
                        Area = (double)result["Area"],
                        Status = (bool)result["Status"],
                        ContractorID = (int)result["ContractorID"],
                        Description = (string)result["Description"]
                    }
                    );
                }


            }
            catch (Exception ex)
            {

            }
            return temp;
        }
        public static List<Property> SearchPropertiesbyType(string value)
        {
            List<Property> temp = new List<Property>();
            try
            {

                SqlConnection con = new SqlConnection("Data Source =7AMOOZ;Initial Catalog=RealEstate;Integrated Security=true;");
                con.Open();
                SqlCommand cmd = new SqlCommand($"exec [Search Property By Type] '{value}'", con);
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    temp.Add(new Property()
                    {
                        Id = (int)result["ID"],
                        Address = (string)result["Address"],
                        SellPrice = (double)result["Price"],
                        Type = (string)result["Type"],
                        Area = (double)result["Area"],
                        Status = (bool)result["Status"],
                        ContractorID = (int)result["ContractorID"],
                        Description = (string)result["Description"]
                    }
                    );
                }


            }
            catch (Exception ex)
            {

            }
            return temp;
        }
        static List<Property> ChangeToList(SqlDataReader dr)
        {
            List<Property> list = new List<Property>();
            while (dr.Read())
            {
                Property property = new Property();
                property.Id = (int)dr["ID"];
                property.Address = dr["Address"].ToString();
                property.SellPrice = (float)dr["Price"];
                property.Type = dr["Type"].ToString();
                property.Area = (float)dr["Area"];
                property.Status = (bool)dr["Status"];
                property.ContractorID = (int)dr["ContractorID"];
                property.Description = dr["Description"].ToString();
                property.Photo = GetImages(property.Id.ToString());
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
