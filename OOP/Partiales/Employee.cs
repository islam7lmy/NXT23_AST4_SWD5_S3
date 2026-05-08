using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Partiales
{
    internal partial class Employee
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary} :: {Address}";
        }

        ///partial Method
        ///dosn't have access modifer
        ///dosn't have return type
        partial void test();

        public partial void test1();
    }

    partial class Employee
    {
        public int Age { get; set; }
        public string City { get; set; }

        public void Hello()
        {
            Console.WriteLine("Hello");
        }

        //partial void test()
        //{
        //    throw new NotImplementedException();
        //}

        public partial void test1()
        {
            throw new NotImplementedException();
        }

    }
}
