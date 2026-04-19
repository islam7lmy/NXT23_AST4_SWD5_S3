using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    // Interface: is a contract that defines a set of
    // methods, properties, events, or indexers that a class or struct must implement.
    internal interface IMyType
    {
        /// What You Can Write Inside The Interface?
        /// 1. Method Signature
        /// 2. Property Signature
        /// 3. Event Signature
        /// 4. Indexer Signature
        /// 5. Default Implementation (c# 8.0 +) 


        /// Default Access Modifier Inside The Interface is Public
        /// Private Access Modifier Is Not Allowed Inside The Interface

        ///Property Signature
        int Salary { get; set; }

        /// Method Signature
        void MyFun(string pattern);

        /// Default Implementation
        void Print()
        {
            Console.WriteLine("Hello I am Default Implementation");
        }
    }

    class MyTypeV1 : IMyType //implmentiation
    {
        ///automatic property => [backing filed]
        public int Salary { get; set; }

        public void MyFun(string pattern)
        {
            Console.WriteLine("Hello");
        }

        //void Print()
        //{
        //    Console.WriteLine("Hello I am Default Implementation");
        //}
    }

    class MyTypeV2 : IMyType //implmentiation
    {
        private int salary;
        ///automatic property => [backing filed]
        public int Salary { get { return salary; } set { salary = value > 2000 ? value : 2000; } }

        public void MyFun(string pattern)
        {
            Console.WriteLine($"Hello {pattern}");
        }

        //void Print()
        //{
        //    Console.WriteLine("Hello I am Default Implementation");
        //}
    }
}
