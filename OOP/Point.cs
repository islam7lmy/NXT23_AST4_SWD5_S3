using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Point
    {
        /// What You Can Write Inside The Struct?
        /// 1. Fields (Attributres) => variables
        /// 2. Methods => functions 
        /// 3. Constructor => special method
        /// 4. Properties
        /// 5. Events
        /// 6. Indexers => special property

        public int x;
        public int y;

        //clr will always Generate Paramaterless Constructor
        //public Point()
        //{
        //    x = y = default;
        //}
        /// to initialize all attributes with default value based on it's daatatype
        /// You Can't Create User-Defined Parameterless Constructor Inside Struct (Except C# 10.0)

        //userdefined constructor
        public Point(int _x , int _y)
        {
            x = _x;
            y = _y;
        }

        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}
