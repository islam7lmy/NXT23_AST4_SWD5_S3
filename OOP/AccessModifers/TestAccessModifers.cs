using Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AccessModifers
{

    //private => in same class
    //private protected => allowed in same assembly drived class
    //protected => allowed in drived class
    //internal => allowed in same assemply
    //protected internal => allowed if drived or in same assembly
    //public => allowed in all locations

    public class TestAccesModifers03 : TestAccesModifers
    {
        public TestAccesModifers03()
        {
            //test = 1; /// private
            //test1 = 20; //private protected => allowed in same assemply drived class
            test2 = 20; //protected => allowed in drived class
            //test3 = 20; //internal => allowed in same assemply
            test4 = 20; //public => allowed in all locations
            test5 = 20; //protected internal => allowed if drived or in same assembly
        }
    }
    public class TestAccesModifers04 
    {
        public TestAccesModifers04()
        {
            TestAccesModifers testAccesModifers = new TestAccesModifers();
            //test = 1; /// private
            //test1 = 20; //private protected => allowed in same assemply drived class
            //test2 = 20; //protected => allowed in drived class
            //test3 = 20; //internal => allowed in same assemply
            testAccesModifers.test4 = 20; //public => allowed in all locations
            //testAccesModifers.test5 = 20; //protected internal => allowed if drived or in same assembly

        }
    }

}
