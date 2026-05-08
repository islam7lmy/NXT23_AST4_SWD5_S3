using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        //public override bool Equals(object? obj)
        //{
        //    //Point other = (Point)obj; //explicit casting [unsafe]
        //    //return this.X == other.X && this.Y == other.Y;

        //    //1. is type check : return true or false
        //    //obj is object of type "Point"
        //    //obj is object of type inhert from "Point"
        //    //if(obj is Point hamada) // safe caste
        //    //{
        //    //    return this.X == hamada.X && this.Y == hamada.Y;
        //    //}
        //    //return false;

        //    //return obj is Point p1 && X == p1.X && Y == p1.Y;

        //    //2. as casting operator : refernce type or nullable type
        //    //to can save null value if not casting successfuly
        //    //int? x = obj as int?;
        //    Point p1 = obj as Point;
        //    if (p1 is null) return false;
        //    return X == p1.X && Y == p1.Y;
        //}

        //public override int GetHashCode()
        //{
        //    //Generics.Point p1 = new Generics.Point(3, 0); // 3
        //    //Generics.Point p2 = new Generics.Point(0, 3); // 3
        //    //if two things are equal (Equals(..) == true) then they must return the same value of gethashcode()
        //    //if the gethashcode is equal, it is not necessary for them to be the same;
        //    //this is collision , and equals will be called to see if it is a real equality or not

        //    //return X.GetHashCode() + Y.GetHashCode();

        //    //c# 8.0
        //    return HashCode.Combine(X, Y);
        //}
    }
}
