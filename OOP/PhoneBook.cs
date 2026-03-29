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

        int count; // the number of entries in the phone book
        public int Count { get { return count; } }

        private int size; //capacity of the phone book
        public int Size
        {
            get { return size; }
            private set { Resize(value); }
        }

        public PhoneBook(int _size)
        {
            Size = _size;
            count = 0;
            //Numbers = new long[Size];
            //Names = new string[Size];
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

        public void AddNumbers(string _name, long _number)
        {
            if (count == size)
                Resize(size + 1); // resize the phone book if it's full

            Names[count] = _name;
            Numbers[count] = _number;
            count++;
        }

        /// method to remove contact
        public void RemoveNumber(string _name)
        {
            int index = Array.IndexOf(Names, _name);
            if (index >= 0)
            {
                for(int i = index; i < count - 1; i++)
                {
                    Names[i] = Names[i + 1]; 
                    Numbers[i] = Numbers[i + 1];
                }
                count--; 
                Resize(size - 1); // resize the phone book after removing the contact
            }
            else
                Console.WriteLine("the name is not found in the phone book");
        }

        public long GetNumber(string _name)
        {
            int index = Array.IndexOf(Names, _name);
            if (index >= 0)
                return Numbers[index];
            return -1;
        }
        public void SetNumber(string _name, long _number)
        {
            int index = Array.IndexOf(Names, _name);
            if (index >= 0)
                Numbers[index] = _number;
        }

        public long this[string _name] //indexer => special property that allow us to access the elements of the struct as if it was an array
        {
            get
            {
                int index = Array.IndexOf(Names, _name);
                if (index >= 0)
                    return Numbers[index];
                return -1;
            }
            set
            {
                int index = Array.IndexOf(Names, _name);
                if (index >= 0)
                    Numbers[index] = value;
            }
        }

        public string this[int index] //indexer => allow us to access the elements of the struct as if it was an array
        {
            get
            {
                //if(index >= 0 && index < size)
                try
                {
                    return $"the {index + 1} elmenet of phone book is : [{Names[index]} => {Numbers[index]}]";
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void Resize(int value)
        {
            if (size == 0)
            {
                size = value <= 0 ? 10 : value;
                Numbers = new long[size];
                Names = new string[size];
            }
            if (value > size)
            {
                //resize the arrays
                long[] newnumbers = new long[value];
                string[] newnames = new string[value];

                //copy old values
                Numbers?.CopyTo(newnumbers, 0);
                Names?.CopyTo(newnames, 0);

                Numbers = newnumbers;
                Names = newnames;

                size = value <= 0 ? 10 : value;
            }
            else if (value < size)
            {
                //check if the values that will be removed are empty or not
                //int maxindexhasdata = Array.IndexOf(Names, null) - 1; // the last index that has data
                //if (maxindexhasdata >= 0 && value >= maxindexhasdata)

                if (value >= count)
                {
                    //resize the arrays
                    long[] newnumbers = new long[value];
                    string[] newnames = new string[value];

                    //copy old values
                    for (int i = 0; i < value; i++)
                    {
                        newnumbers[i] = Numbers[i];
                        newnames[i] = Names[i];
                    }

                    Numbers = newnumbers;
                    Names = newnames;

                    size = value <= 0 ? 10 : value;
                }
                else
                {
                    throw new Exception("can't resize the phone book because there are entries that will be removed");
                }
            }
        }
    }
}
