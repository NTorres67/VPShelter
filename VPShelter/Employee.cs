using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        // REQUIREMENTS
        // 1 Property
        // 2 abstract methods

        // field

     

        // Properties
        public string name { get; set; }
        public string numberID { get; set; }
      

        // Constructors 
        // none - abstract method

        // Methods

        public abstract string EmployeeName();
        public abstract string EmployeeIDNumber();





    }
}
