namespace OOP.Inhertiance
{
    class Child : Parent
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        public int Z { get; set; }

        /// by default the constructor of the parent class 
        /// will be called when we create an object of the child class
        //public Child() : base()
        //{

        //}

        public Child(int _x, int _y, int _z) : base(_x , _y)
        {
            //X = _x > 10 ? _x : 10;
            //Y = _y;
            Z = _z;
            Console.WriteLine("Hii i am constructor of child");
        }
    }
}
