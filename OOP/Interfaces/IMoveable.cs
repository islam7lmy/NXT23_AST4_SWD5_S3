using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal interface IMoveable
    {
        void Forward();
        void Backward();
    }

    internal interface IFlayable
    {
        void Forward();
        void Backward();
    }

    class Car : IMoveable
    {
        public void Backward() ///implicit implmintion
        {
            Console.WriteLine("Car is Moving Forward");
        }

        public void Forward()///implicit implmintion
        {
            Console.WriteLine("Car is Moving BackWard");
        }
    }

    class AirPlan : IMoveable, IFlayable ///implmention
    {
        public void Backward()///implicit implmintion
        {
            Console.WriteLine("AirPlane is Moving Backward");
        }

        void IFlayable.Forward()//explicit implementation
        {
            Console.WriteLine("AirPlane is Flying Forward");
        }

        void IMoveable.Forward()//explicit implementation
        {
            Console.WriteLine("AirPlane is Moving Forward");
        }
    }
}
