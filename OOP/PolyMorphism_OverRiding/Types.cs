using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_OverRiding
{
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int _A)
        {
            A = _A;
        }
        public void MyFun01()
        {
            Console.WriteLine("Hii i am MyFun01 of TypeA [Parent]");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA: A = {A}");
        }
    }

    class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A , int _B) : base(_A)
        {
            B = _B;
        }

        /// static binding => early binding => compile time binding
        /// hiding => the method in the child class hides the method in the parent class
        public new void MyFun01()
        {
            Console.WriteLine("Hii i am MyFun01 of TypeB [Child]");
        }

        /// dynamic binding => late binding => runtime binding
        /// overriding => the method in the child class overrides the method in the parent class
        /// parent method that you want to override => Must be Non-Private Virtual
        public override void MyFun02()
        {
            ///base.MyFun02();
            Console.WriteLine($"TypeB: A = {A}, B = {B}");
        }
    }
}
