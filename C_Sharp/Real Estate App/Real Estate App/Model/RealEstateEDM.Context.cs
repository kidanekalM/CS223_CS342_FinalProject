﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class RealEstateEDM : DbContext
    {
        public RealEstateEDM(string s )
            : base(s + "ConnectionString")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        [EdmFunction("AdminConnectionString1", "Get_All_Appointments")]
        public virtual IQueryable<Get_All_Appointments_Result> Get_All_Appointments()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Get_All_Appointments_Result>("[AdminConnectionString1].[Get_All_Appointments]()");
        }
    
        [EdmFunction("AdminConnectionString1", "Get_All_Clients")]
        public virtual IQueryable<Get_All_Clients_Result> Get_All_Clients()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Get_All_Clients_Result>("[AdminConnectionString1].[Get_All_Clients]()");
        }
    
        [EdmFunction("AdminConnectionString1", "Get_All_Employees")]
        public virtual IQueryable<Get_All_Employees_Result> Get_All_Employees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Get_All_Employees_Result>("[AdminConnectionString1].[Get_All_Employees]()");
        }
    
        [EdmFunction("AdminConnectionString1", "Get_All_Properties")]
        public virtual IQueryable<Get_All_Properties_Result> Get_All_Properties()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Get_All_Properties_Result>("[AdminConnectionString1].[Get_All_Properties]()");
        }
    
        public virtual ObjectResult<Nullable<decimal>> Add_Appointment(Nullable<System.DateTime> appointmentDate, string comment, Nullable<int> clientId, Nullable<int> agentId)
        {
            var appointmentDateParameter = appointmentDate.HasValue ?
                new ObjectParameter("AppointmentDate", appointmentDate) :
                new ObjectParameter("AppointmentDate", typeof(System.DateTime));
    
            var commentParameter = comment != null ?
                new ObjectParameter("Comment", comment) :
                new ObjectParameter("Comment", typeof(string));
    
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(int));
    
            var agentIdParameter = agentId.HasValue ?
                new ObjectParameter("AgentId", agentId) :
                new ObjectParameter("AgentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("Add_Appointment", appointmentDateParameter, commentParameter, clientIdParameter, agentIdParameter);
        }
    
        public virtual int Add_Buy(Nullable<int> propertyId, Nullable<int> clientId, Nullable<int> agentId, Nullable<System.DateTime> sellDate, Nullable<decimal> comission)
        {
            var propertyIdParameter = propertyId.HasValue ?
                new ObjectParameter("PropertyId", propertyId) :
                new ObjectParameter("PropertyId", typeof(int));
    
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(int));
    
            var agentIdParameter = agentId.HasValue ?
                new ObjectParameter("AgentId", agentId) :
                new ObjectParameter("AgentId", typeof(int));
    
            var sellDateParameter = sellDate.HasValue ?
                new ObjectParameter("SellDate", sellDate) :
                new ObjectParameter("SellDate", typeof(System.DateTime));
    
            var comissionParameter = comission.HasValue ?
                new ObjectParameter("Comission", comission) :
                new ObjectParameter("Comission", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Buy", propertyIdParameter, clientIdParameter, agentIdParameter, sellDateParameter, comissionParameter);
        }
    
        public virtual int Add_Choosen_Property(Nullable<int> appointmentId, Nullable<int> propertyID)
        {
            var appointmentIdParameter = appointmentId.HasValue ?
                new ObjectParameter("AppointmentId", appointmentId) :
                new ObjectParameter("AppointmentId", typeof(int));
    
            var propertyIDParameter = propertyID.HasValue ?
                new ObjectParameter("PropertyID", propertyID) :
                new ObjectParameter("PropertyID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Choosen_Property", appointmentIdParameter, propertyIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> Add_Client(string firstName, string lastName, byte[] photo, string phoneNumber, string email, string password, Nullable<int> empId)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(byte[]));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("Add_Client", firstNameParameter, lastNameParameter, photoParameter, phoneNumberParameter, emailParameter, passwordParameter, empIdParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> Add_Department(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("Add_Department", nameParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> Add_Employee(string firstName, string lastName, string phoneNumber, string password, byte[] photo, string empType, Nullable<System.DateTime> empDate, Nullable<int> departmentID)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(byte[]));
    
            var empTypeParameter = empType != null ?
                new ObjectParameter("EmpType", empType) :
                new ObjectParameter("EmpType", typeof(string));
    
            var empDateParameter = empDate.HasValue ?
                new ObjectParameter("EmpDate", empDate) :
                new ObjectParameter("EmpDate", typeof(System.DateTime));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("Add_Employee", firstNameParameter, lastNameParameter, phoneNumberParameter, passwordParameter, photoParameter, empTypeParameter, empDateParameter, departmentIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> Add_Property(Nullable<int> iD, string address, Nullable<double> price, string type, Nullable<double> area, Nullable<bool> status, string description)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(double));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var areaParameter = area.HasValue ?
                new ObjectParameter("Area", area) :
                new ObjectParameter("Area", typeof(double));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("Add_Property", iDParameter, addressParameter, priceParameter, typeParameter, areaParameter, statusParameter, descriptionParameter);
        }
    
        public virtual int Add_Property_Photo(Nullable<int> propertyID, byte[] photo)
        {
            var propertyIDParameter = propertyID.HasValue ?
                new ObjectParameter("PropertyID", propertyID) :
                new ObjectParameter("PropertyID", typeof(int));
    
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Property_Photo", propertyIDParameter, photoParameter);
        }
    
        public virtual int Delete_Appointment(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Appointment", iDParameter);
        }
    
        public virtual int Delete_Buy(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Buy", iDParameter);
        }
    
        public virtual int Delete_Choosen_Property(Nullable<int> appointmentId, Nullable<int> propertyId)
        {
            var appointmentIdParameter = appointmentId.HasValue ?
                new ObjectParameter("AppointmentId", appointmentId) :
                new ObjectParameter("AppointmentId", typeof(int));
    
            var propertyIdParameter = propertyId.HasValue ?
                new ObjectParameter("PropertyId", propertyId) :
                new ObjectParameter("PropertyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Choosen_Property", appointmentIdParameter, propertyIdParameter);
        }
    
        public virtual int Delete_Client(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Client", iDParameter);
        }
    
        public virtual int Delete_Department(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Department", iDParameter);
        }
    
        public virtual int Delete_Employee(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Employee", iDParameter);
        }
    
        public virtual int Delete_Property(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Property", iDParameter);
        }
    
        public virtual int Delete_Property_Photo(byte[] photo)
        {
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Property_Photo", photoParameter);
        }
    
        public virtual int Delete_Property_Photo_By_Id(Nullable<int> propertyId)
        {
            var propertyIdParameter = propertyId.HasValue ?
                new ObjectParameter("PropertyId", propertyId) :
                new ObjectParameter("PropertyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_Property_Photo_By_Id", propertyIdParameter);
        }
    
        public virtual ObjectResult<Filter_Property_Result> Filter_Property(string address, Nullable<decimal> price, string type, Nullable<double> area, Nullable<bool> status, string description)
        {
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var areaParameter = area.HasValue ?
                new ObjectParameter("Area", area) :
                new ObjectParameter("Area", typeof(double));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Filter_Property_Result>("Filter_Property", addressParameter, priceParameter, typeParameter, areaParameter, statusParameter, descriptionParameter);
        }
    
        public virtual ObjectResult<Search_Appointment_By_AgentID_Result> Search_Appointment_By_AgentID(Nullable<int> agentID)
        {
            var agentIDParameter = agentID.HasValue ?
                new ObjectParameter("AgentID", agentID) :
                new ObjectParameter("AgentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Appointment_By_AgentID_Result>("Search_Appointment_By_AgentID", agentIDParameter);
        }
    
        public virtual ObjectResult<Search_Appointment_By_ClientID_Result> Search_Appointment_By_ClientID(Nullable<int> clientID)
        {
            var clientIDParameter = clientID.HasValue ?
                new ObjectParameter("ClientID", clientID) :
                new ObjectParameter("ClientID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Appointment_By_ClientID_Result>("Search_Appointment_By_ClientID", clientIDParameter);
        }
    
        public virtual ObjectResult<Search_Appointment_By_Date_Result> Search_Appointment_By_Date(Nullable<System.DateTime> date)
        {
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Appointment_By_Date_Result>("Search_Appointment_By_Date", dateParameter);
        }
    
        public virtual ObjectResult<Search_Appointment_By_ID_Result> Search_Appointment_By_ID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Appointment_By_ID_Result>("Search_Appointment_By_ID", iDParameter);
        }
    
        public virtual ObjectResult<Search_Buy_By_AgentId_Result> Search_Buy_By_AgentId(Nullable<int> agentId)
        {
            var agentIdParameter = agentId.HasValue ?
                new ObjectParameter("AgentId", agentId) :
                new ObjectParameter("AgentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Buy_By_AgentId_Result>("Search_Buy_By_AgentId", agentIdParameter);
        }
    
        public virtual ObjectResult<Search_Buy_By_ClientID_Result> Search_Buy_By_ClientID(Nullable<int> clientID)
        {
            var clientIDParameter = clientID.HasValue ?
                new ObjectParameter("ClientID", clientID) :
                new ObjectParameter("ClientID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Buy_By_ClientID_Result>("Search_Buy_By_ClientID", clientIDParameter);
        }
    
        public virtual ObjectResult<Search_Choosen_Property_By_Appintment_Result> Search_Choosen_Property_By_Appintment(Nullable<int> appointmentID)
        {
            var appointmentIDParameter = appointmentID.HasValue ?
                new ObjectParameter("AppointmentID", appointmentID) :
                new ObjectParameter("AppointmentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Choosen_Property_By_Appintment_Result>("Search_Choosen_Property_By_Appintment", appointmentIDParameter);
        }
    
        public virtual ObjectResult<Search_Choosen_Property_By_Property_Result> Search_Choosen_Property_By_Property(Nullable<int> propertyID)
        {
            var propertyIDParameter = propertyID.HasValue ?
                new ObjectParameter("PropertyID", propertyID) :
                new ObjectParameter("PropertyID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Choosen_Property_By_Property_Result>("Search_Choosen_Property_By_Property", propertyIDParameter);
        }
    
        public virtual ObjectResult<Search_Client_By_ID_Result> Search_Client_By_ID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Client_By_ID_Result>("Search_Client_By_ID", iDParameter);
        }
    
        public virtual ObjectResult<Search_Client_By_Name_Result> Search_Client_By_Name(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Client_By_Name_Result>("Search_Client_By_Name", nameParameter);
        }
    
        public virtual ObjectResult<Search_Department_By_ID_Result> Search_Department_By_ID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Department_By_ID_Result>("Search_Department_By_ID", iDParameter);
        }
    
        public virtual ObjectResult<Search_Department_By_Name_Result> Search_Department_By_Name(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Department_By_Name_Result>("Search_Department_By_Name", nameParameter);
        }
    
        public virtual ObjectResult<Search_Employee_By_ID_Result> Search_Employee_By_ID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Employee_By_ID_Result>("Search_Employee_By_ID", iDParameter);
        }
    
        public virtual ObjectResult<Search_Employee_By_Name_Result> Search_Employee_By_Name(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Employee_By_Name_Result>("Search_Employee_By_Name", nameParameter);
        }
    
        public virtual ObjectResult<Search_Property_By_ID_Result> Search_Property_By_ID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Property_By_ID_Result>("Search_Property_By_ID", iDParameter);
        }
    
        public virtual ObjectResult<Search_Property_By_Type_Result> Search_Property_By_Type(string type)
        {
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Property_By_Type_Result>("Search_Property_By_Type", typeParameter);
        }
    
        public virtual ObjectResult<Search_Property_Photo_By_ID_Result> Search_Property_Photo_By_ID(Nullable<int> propertyID)
        {
            var propertyIDParameter = propertyID.HasValue ?
                new ObjectParameter("PropertyID", propertyID) :
                new ObjectParameter("PropertyID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Search_Property_Photo_By_ID_Result>("Search_Property_Photo_By_ID", propertyIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Search_Total_Sold_By_Employee(string empId)
        {
            var empIdParameter = empId != null ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Search_Total_Sold_By_Employee", empIdParameter);
        }
    
        public virtual int Update_Appointment(Nullable<int> id, Nullable<System.DateTime> appointmentDate, string comment, Nullable<int> clientId, Nullable<int> agentId)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var appointmentDateParameter = appointmentDate.HasValue ?
                new ObjectParameter("AppointmentDate", appointmentDate) :
                new ObjectParameter("AppointmentDate", typeof(System.DateTime));
    
            var commentParameter = comment != null ?
                new ObjectParameter("Comment", comment) :
                new ObjectParameter("Comment", typeof(string));
    
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(int));
    
            var agentIdParameter = agentId.HasValue ?
                new ObjectParameter("AgentId", agentId) :
                new ObjectParameter("AgentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Appointment", idParameter, appointmentDateParameter, commentParameter, clientIdParameter, agentIdParameter);
        }
    
        public virtual int Update_Buy(Nullable<int> iD, Nullable<int> propertyId, Nullable<int> clientId, Nullable<int> agentId, Nullable<System.DateTime> sellDate, Nullable<decimal> comission)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var propertyIdParameter = propertyId.HasValue ?
                new ObjectParameter("PropertyId", propertyId) :
                new ObjectParameter("PropertyId", typeof(int));
    
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(int));
    
            var agentIdParameter = agentId.HasValue ?
                new ObjectParameter("AgentId", agentId) :
                new ObjectParameter("AgentId", typeof(int));
    
            var sellDateParameter = sellDate.HasValue ?
                new ObjectParameter("SellDate", sellDate) :
                new ObjectParameter("SellDate", typeof(System.DateTime));
    
            var comissionParameter = comission.HasValue ?
                new ObjectParameter("Comission", comission) :
                new ObjectParameter("Comission", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Buy", iDParameter, propertyIdParameter, clientIdParameter, agentIdParameter, sellDateParameter, comissionParameter);
        }
    
        public virtual int Update_Choosen_Property(Nullable<int> appointmentId, Nullable<int> oldPropertyId, Nullable<int> newPropertyId)
        {
            var appointmentIdParameter = appointmentId.HasValue ?
                new ObjectParameter("AppointmentId", appointmentId) :
                new ObjectParameter("AppointmentId", typeof(int));
    
            var oldPropertyIdParameter = oldPropertyId.HasValue ?
                new ObjectParameter("OldPropertyId", oldPropertyId) :
                new ObjectParameter("OldPropertyId", typeof(int));
    
            var newPropertyIdParameter = newPropertyId.HasValue ?
                new ObjectParameter("NewPropertyId", newPropertyId) :
                new ObjectParameter("NewPropertyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Choosen_Property", appointmentIdParameter, oldPropertyIdParameter, newPropertyIdParameter);
        }
    
        public virtual int Update_Client(Nullable<int> iD, string firstName, string lastName, byte[] photo, string phoneNumber, string email, string password, Nullable<int> empId)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(byte[]));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Client", iDParameter, firstNameParameter, lastNameParameter, photoParameter, phoneNumberParameter, emailParameter, passwordParameter, empIdParameter);
        }
    
        public virtual int Update_Department(string name, Nullable<int> iD)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Department", nameParameter, iDParameter);
        }
    
        public virtual int Update_Employee(Nullable<int> iD, string firstName, string lastName, string phoneNumber, string password, byte[] photo, string empType, Nullable<System.DateTime> empDate, Nullable<int> departmentID)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("Photo", photo) :
                new ObjectParameter("Photo", typeof(byte[]));
    
            var empTypeParameter = empType != null ?
                new ObjectParameter("EmpType", empType) :
                new ObjectParameter("EmpType", typeof(string));
    
            var empDateParameter = empDate.HasValue ?
                new ObjectParameter("EmpDate", empDate) :
                new ObjectParameter("EmpDate", typeof(System.DateTime));
    
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Employee", iDParameter, firstNameParameter, lastNameParameter, phoneNumberParameter, passwordParameter, photoParameter, empTypeParameter, empDateParameter, departmentIDParameter);
        }
    
        public virtual int Update_Property(Nullable<int> iD, string address, Nullable<double> price, string type, Nullable<double> area, Nullable<bool> status, string description)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(double));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var areaParameter = area.HasValue ?
                new ObjectParameter("Area", area) :
                new ObjectParameter("Area", typeof(double));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Property", iDParameter, addressParameter, priceParameter, typeParameter, areaParameter, statusParameter, descriptionParameter);
        }
    
        public virtual int Update_Property_Photo(byte[] oldPhoto, byte[] newPhoto)
        {
            var oldPhotoParameter = oldPhoto != null ?
                new ObjectParameter("OldPhoto", oldPhoto) :
                new ObjectParameter("OldPhoto", typeof(byte[]));
    
            var newPhotoParameter = newPhoto != null ?
                new ObjectParameter("NewPhoto", newPhoto) :
                new ObjectParameter("NewPhoto", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_Property_Photo", oldPhotoParameter, newPhotoParameter);
        }
    
        public virtual ObjectResult<Get_All_Clients_By_Agent_Result1> Get_All_Clients_By_Agent(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_All_Clients_By_Agent_Result1>("Get_All_Clients_By_Agent", iDParameter);
        }
    }
}
