//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Real_Estate_App.Model
{
    using System;
    
    public partial class Login_Agent_Result
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public byte[] Photo { get; set; }
        public string EmpType { get; set; }
        public System.DateTime EmpDate { get; set; }
        public Nullable<int> DepartmentID { get; set; }
    }
}
