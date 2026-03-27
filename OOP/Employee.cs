using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Employee
    {
        public int Id;

        // encapsulation :Seperates The Data Defintion (Attribute)
        // From Its Use (GetterSetter Or Property)
        #region Name [getter setter method]
        private string Name; // field must be private

        //getter for name attribute
        public string GetName()
        {
            return $"the fullname of employee is : {Name}";
        }

        //setter for name attribute 
        public void SetName(string value)
        {
            Name = value.Length <= 20 ? value : value.Substring(0, 20);
        }
        #endregion

        #region 1. Full Property [has field and property]
        decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value < 2000 ? 2000 : value;
            }
        }
        #endregion

        #region 2. Automatic property
        //int age;
        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

        /// clr will create backingfield [hidden private Attribute]
        public int Age { get; private set; } 

        public decimal Deduction { get { return salary * .2m; } }//Drived attribute
        #endregion
    }
}
