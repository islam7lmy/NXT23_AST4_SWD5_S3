using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct PhoneBook
    {
        string[] Names; // 4 byte 
        long[] Numbers; // 4 byte 

        private int size;
        public int Size
        {
            get { return size; }
            set { size = value <= 0 ? 10 : value; }
        }

        public PhoneBook(int _size)
        {
            Size = _size;
            Numbers = new long[Size];
            Names = new string[Size];
        }

        //clr will parameterless constructor
        ///// constructor chaning
        public PhoneBook() : this(0)
        {
            //Names = default; /// null
            //Numbers = default; /// null
            //size = default; ///0  

            //size = 0;
            //Numbers = new long[size];
            //Names = new string[size];
        }

        public void AddNumbers(string _name, long _number, int _position)
        {
            if (_position >= 0 && _position < Size)
            {
                Names[_position] = _name;
                Numbers[_position] = _number;
            }
        }

        ///quiz
        public long GetNumber(string _name)
        {
            return 123;
        }
        public void SetNumber(string _name, long _number)
        {

        }
    }
}
