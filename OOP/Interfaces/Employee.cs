using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal class Employee : ICloneable , IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        /// default constructor => empty parameterless constructor
        public Employee()
        {
            
        }

        /// copy constructor => a constructor that takes an object of the same class as a parameter 
        /// and initializes the new object with the values of the existing object.
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            Salary = emp.Salary;
        }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        public static Employee DeepCopy(Employee Emp)
        {
            return new Employee()
            {
                Id = Emp.Id,
                Name = Emp.Name,
                Salary = Emp.Salary,
            };
        }

        /// standard method to create a copy of an object is to implement 
        /// the ICloneable interface and its Clone method.
        public object Clone()
        {
            ///this object will call method
            return new Employee(this);

            //return new Employee()
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary,
            //};
        }

        ///+ve : this > obj
        ///-ve : this < obj
        ///0 : this == obj
        public int CompareTo(object? obj)
        {
            ///this object of employee that using in call
            ///obj refer on object that send as paramater
            Employee other =(Employee) obj; ///explicit casting , un safe cast
            if(this.Salary > other.Salary)
                return 1;
            else if(this.Salary < other.Salary)
                return -1;
            else return 0;
        }
    }
}
