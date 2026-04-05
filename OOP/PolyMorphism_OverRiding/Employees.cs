using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_OverRiding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        /// i need to run reference code
        /// so you must override it with static binding
        /// new key word
        public void MyFun01()
        {
            Console.WriteLine("I am Employee");
        }

        /// i need to run object code
        /// so you must override it with dynamic binding
        /// override key word
        public virtual void MyFun02()
        {
            Console.Write($"Employee: id = {Id} , name = {Name} , age = {Age}");
        }
    }

    class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine("I am FullTimeEmployee");
        }

        public override void MyFun02()
        {
            Console.Write($"Employee: id = {Id} , name = {Name} , age = {Age} , Salary = {Salary}");
        }
    }

    class PartTimeEmployee : Employee
    {
        public decimal HoureRate { get; set; }
        public int CountOfHours { get; set; }

        public new void MyFun01()
        {
            Console.WriteLine("I am PartTimeEmployee");
        }

        public override void MyFun02()
        {
            Console.Write($"Employee: id = {Id} , name = {Name} , age = {Age} , HourRate = {HoureRate} , CountOfHours = {CountOfHours}");
        }
    }

    class FreeLanceEmployee : Employee
    {

    }

}
