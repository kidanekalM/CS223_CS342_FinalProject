using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_App.Model
{
    internal interface CommonDBOperations
    {

        /// <summary>
        /// add employee too database
        /// </summary>
        /// <returns>bool for success or faliure</returns>
        
        bool Add();


        /// <summary>
        /// update an existing eployee in the database
        /// </summary>
        /// <returns>bool for success or faliure</returns>
       
        bool Update();

        /// <summary>
        /// delete an employee from the database
        /// </summary>
        /// <returns>bool</returns>

        bool Delete();
       
    }
}
