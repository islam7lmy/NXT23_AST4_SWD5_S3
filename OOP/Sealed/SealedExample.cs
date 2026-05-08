using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Sealed
{
    internal class Parent
    {
		private int salary;

		public virtual int Salary
		{
			get { return salary; }
			set { salary = value - 1000; }
		}

		public virtual void print()
		{
            Console.WriteLine("hello Parent");
		}

	}

	class Child02 : Parent
	{
        public override int Salary 
		{ 
			get => base.Salary; 
			set => base.Salary = value - 500; 
		}

        public override void print()
        {
            Console.WriteLine("Hello Child");
        }
	}

    class Child : Parent
    {
        public sealed override int Salary
        {
            get => base.Salary;
            set => base.Salary = value - 500;
        }

        public sealed override void print()
        {
            Console.WriteLine("Hello Child");
        }
    }

    sealed class GrandChild : Child
    {
        public GrandChild()
        {
            Salary = 10000;
            print();
        }

        void test()
        {
            Salary = 115455;
            print();
        }

        //static binding
        public new void Print()
        {
            Console.WriteLine("hello GrandChild");
        }

        //not valid because its sealed
        //public override int Salary { get => base.Salary; set => base.Salary = value; }

        //not valid because its sealed
        //public override void print()
        //{
        //    base.print();
        //}
    }

    //class GrandGrandChild : GrandChild
    //{

    //}

}
