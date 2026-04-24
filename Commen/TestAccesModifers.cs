using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    public class TestAccesModifers
    {
        private int test { get; set; }
        private protected int test1 { get; set; }
        protected int test2 { get; set; }
        internal int test3 { get; set; }
        public int test4 { get; set; }

        protected internal int test5 { get; set; }
    }

    public class TestAccesModifers02 : TestAccesModifers
    {
        public TestAccesModifers02()
        {
            //test = 1; /// private
            test1 = 20; //private protected => allowed in same assemply drived class
            test2 = 20; //protected => allowed in drived class
            test3 = 20; //internal => allowed in same assemply
            test4 = 20; //public => allowed in all locations
        }
    }

    class TestAccesModifers10
    {
        public TestAccesModifers10()
        {
            TestAccesModifers testAccesModifers = new TestAccesModifers();
            //testAccesModifers.test1 = 20;//private protected => allowed in same assemply drived class
            //testAccesModifers.test2 = 20;//protected => allowed in drived class
            testAccesModifers.test5 = 20; //protected internal => allowed if drived or in same assembly
        }
    }

}
