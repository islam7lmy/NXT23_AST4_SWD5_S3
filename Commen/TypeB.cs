using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    internal class TypeB
    {
        //You you = You.first; // valid
        //publicYou publicYou = publicYou.first; // valid

        TypeA a = new TypeA();
        TypeC c = new TypeC();
        void Test()
        {
            //a.x = 0; //invaild
            a.y = 1; 
            a.z = 2;

            //c.x = 3;//invaild
            c.y = 4;
            c.z = 5;
        }
    }
}
