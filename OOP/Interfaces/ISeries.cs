using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal interface ISeries
    {
        int Current { get; set; }
        void GetNext();
        //void Reset();
        void Reset()
        {
            Current = 0;
        }
    }

    class SeriesByTwo : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current +=2;
        }

        //public void Reset()
        //{
        //    Current = 0;
        //}
    }

    class SeriesByThree : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 3;
        }

        //public void Reset()
        //{
        //    Current = 0;
        //}
    }

    class SeriesByFour : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 4;
        }

        //public void Reset()
        //{
        //    Current = 0;
        //}
    }
}
