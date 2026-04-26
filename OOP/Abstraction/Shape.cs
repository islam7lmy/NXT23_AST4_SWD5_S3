using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    abstract class Shape
    {
        ///property implementation => property with implementation
        public double Dim01 { get; protected set; }
        public double Dim02 { get; protected set; }


        ///method not impemented => 
        ///virtual method => a method that is declared in a base class and can be overridden in a derived class.
        public abstract double Perimeter { get; }

        /// abstract method => a method that is declared in an abstract class but 
        /// does not have an implementation.
        /// virtual method => a method that is declared in a base class and can be overridden in a derived class.
        public abstract double CalcArea(); ///signature

        ///fully implmented method
        public double CalcArea2() { return CalcArea(); }
    }

    abstract class rectshape : Shape
    {
        public override double CalcArea()
        {
            return Dim01 * Dim02;
        }
    }

    class Squere : rectshape
    {
        public Squere(double Dim)
        {
            Dim01 = Dim02 = Dim;
        }
        //public double Dim01 { get; set; }

        public override double Perimeter { get { return Dim01 * 4; } }

        //public override double CalcArea()
        //{
        //    return Dim01 * Dim01;
        //}
    }


    class Rectangle : rectshape
    {
        public Rectangle(double dim1 , double dim2 )
        {
            Dim01 = dim1;
            Dim02 = dim2;
        }
        //public double Dim01 { get; set; }
        //public double Dim02 { get; set; }

        public override double Perimeter { get { return (Dim01 + Dim02) * 2; } }

        //public override double CalcArea()
        //{
        //    return Dim01 * Dim02;
        //}
    }


    class Circle : Shape
    {
        public Circle(double Dim)
        {
            Dim01 = Dim02 = Dim;
        }
        //public int Dim01 { get; set; }

        public override double Perimeter { get { return 2 * Dim01 * 3.14; } }

        public override double CalcArea()
        {
            return 3.14 * Dim01 * Dim01;
        }
    }

    class test
    {
        public test()
        {
            Squere s = new Squere(10);
            //s.Dim01 = 20;
        }
    }
}
