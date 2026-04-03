using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        #region Full Property
        //private int id;
        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //} 
        #endregion

        #region Auotmatic
        /// CLR will create a private field for us and use it in the get and set accessors
        /// Backing field is the private field that CLR creates for us when we use automatic properties
        public int Id { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        #endregion

        ///clr will Always create a parameterless constructor for us 
        ///if we don't define any constructor in the class
        //public Car(){ } // => do nothing


        /// user defined constructor 
        /// so the will not create the parameterless constructor for us
        //public Car(int x)
        //{

        //}


        public Car(int _id , string _model , int _speed)
        {
            Id = _id;
            Model = _model;
            Speed = _speed;
            Console.WriteLine("ctor 04");
        }

        public Car(int _id, string _model) : this(_id , _model , 120)
        {
            //Id = _id;
            //Model = _model;
            //Speed = 120;
            Console.WriteLine("ctor 03");
        }

        public Car(int _id) : this (_id, "BMW")
        {
            //Id = _id;
            //Model = "BMW";
            //Speed = 120;
            Console.WriteLine("ctor 02");
        }

        public Car() : this(10)
        {
            //Id = 10;
            //Model = "BMW";
            //Speed = 120;
            Console.WriteLine("ctor 01");
        }
    }
}
