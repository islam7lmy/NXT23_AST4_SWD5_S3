using Commen;
using OOP.Inhertiance;
namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            /// Access Modifiers Types
            /// 1. private
            /// 2. private protected => inhertance
            /// 3. protected => inhertance
            /// 4. internal
            /// 5. internal protected => inhertance
            /// 6. public

            //You you = You.first; //not valid because its internal
            //publicYou publicYou = publicYou.first; // valid because its public

            //TypeA a = new TypeA();
            ////a.x = 1; //invalid because its private
            ////a.y = 1; //invalid because its internal
            //a.z = 1; // valid because its public

            //TypeC c = new TypeC();
            ////a.x = 1; //invalid because its private
            ////a.y = 1; //invalid because its internal
            //a.z = 1; // valid because its public
            #endregion

            #region Struct
            #region EX01 : Point
            //Point p1;
            /////allocate 8 unitialized bytes in stack
            ////Console.WriteLine(p1); //not valid not initilized yet

            //p1.x = 10;
            //p1.y = 10;

            ////p1 = new Point();
            ///// new keyword just for constructor selection 
            ///// that will initialize the attributes of struct

            //Console.WriteLine(p1); //(0,0)

            //p1 = new Point(10, 20);

            //Console.WriteLine(p1); //(10,20)
            #endregion
            #region EX02 : Employee
            //Employee emp = new Employee();
            ////emp.Name = "123456789123456789123456789";
            //emp.SetName("123456789123456789123456789");
            //Console.WriteLine(emp.GetName());

            //emp.Salary = 1000;
            //Console.WriteLine(emp.Salary);

            /////emp.Age = 20;
            //Console.WriteLine(emp.Age);
            #endregion
            #region EX03 : PhoneBook [indexer]
            //PhoneBook book = new PhoneBook(3);
            //book.AddNumbers("amr", 123);
            //book.AddNumbers("ali", 456);
            //book.AddNumbers("aya", 789);
            //book.AddNumbers("test", 1789);
            //book.AddNumbers("test2", 2789);

            //book.RemoveNumber("test");
            //book.RemoveNumber("test2");

            //Console.WriteLine(book.Size);


            ////book.SetNumber("amr", 999);
            ////Console.WriteLine(book.GetNumber("amr"));


            ////book["amr"] = 999;
            ////Console.WriteLine(book["amr"]);

            ////for (int i = 0; i < book.Size; i++)
            ////{
            ////    Console.WriteLine(book[i]);
            ////}

            ////book.Size = 15;
            //for (int i = 0; i < book.Size; i++)
            //{
            //    Console.WriteLine(book[i]);
            //}
            #endregion
            #endregion

            #region Class
            #region Ex:Car
            ///Car c1;
            /// declare reference => refer to null
            /// allocate 4 bytes in stack Uninitilized 
            /// zero bytes has been allocated in heap

            //c1 = new Car();
            ///new
            ///1. allocate required number of bytes in heap
            ///2. initialize all allocated bytes with default value based on datatype
            ///3. call user-defined constructor if exists

            //c1.Id = 10; not valid because c1 is null reference
            //c1.Model = "BMW"; not valid because c1 is null reference
            //c1.Speed = 200; not valid because c1 is null reference

            //Car car = new Car(); // ctor 04, ctor 03, ctor 02, ctor 01
            //car = new Car(1); // ctor 04, ctor 03, ctor 02
            //car = new Car(1, "BMW"); //// ctor 04, ctor 03
            //car = new Car(1, "BMW", 200); ///// ctor 04
            #endregion
            #region Ex:Inhertance
            //object obj = new object();
            //obj.ToString();
            //obj.GetHashCode();
            //obj.GetType();
            //obj.Equals(obj);

            //Parent p1 = new Parent(20, 30); //hii i am constructor of parent
            //Child c1 = new Child(20, 30, 40); //hii i am constructor of parent
            //                                  //hii i am constructor of child

            //Parent p2 = new Child(20, 30, 40); //binding of parent class
            //                                   //hii i am constructor of parent
            //                                   //hii i am constructor of child

            #endregion
            #region Realtionship between classes
            /// inhertance Child is Parent , Dog is Animal
            /// Aggregation => has a
            /// 1. Composition => room has walls
            /// 2. Association => room has chairs
            #endregion

            #region Class vs Struct
            //Car c1 = new Car();
            //Car c2 = c1;
            //c2.Id = 10;
            //Console.WriteLine(c1.Id); ///10 because c1 and c2 refer to the same object in heap
            /////Used for complex objects and behavior
            /////Reference type => stored reference in stack and object in heap
            /////Supports inheritance => [all access modifers]
            /////clr will always generate empty parameterless constructor ,if no user-defined constructor exists
            /////clr will no longer generate empty parameterless constructor, if u write user-defined constructor


            //Point p1 = new Point();
            //Point p2 = p1;
            //p2.x = 10;
            //Console.WriteLine(p1.x); ///0 because p1 and p2 are different objects in stack
            /////Often used for small, simple data
            /////Value type => Stored on the stack
            /////Cannot inherit from another struct or class =>  [private, internal, public]
            /////clr will always Generate Parameterless Constructor
            #endregion
            #endregion

            #region PolyMorphism
            #region OverLoading
            ///Console.WriteLine(Sum(10, 20)); // call Sum(int x, int y)
            #endregion
            #region OverRiding

            #endregion
            #endregion
        }

        #region PolyMorphism - OverLoading
        ///1. data types of parameters
        ///2. Count of parameters
        ///3. order of parameters if not same data types
        

        public static int Sum(int y, short x)
        {
            return x + y;
        }

        public static int Sum(int x, short y) // not overloading because same signature as Sum(int y, short x)
        {
            return x + y;
        }
        public static double Sum(int y, short x)  /// not overloading because same signature as Sum(short x, int y)
        {
            return x + y;
        }
        public static int Sum(short x, short y, short z)
        {
            return x + y + z;
        }
        public static int Sum(short x, short y)
        {
            return x + y;
        }
        public static int Sum(short x, int y)
        {
            return x + y;
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sum(long x, int y)
        {
            return (int)(x + y);
        }
        public static int Sum(long x, long y)
        {
            return (int)(x + y);
        }
        public static int Sum(short x, float y)
        {
            return (int)(x + y);
        }

        public static int Sum(short x, double y)
        {
            return (int)(x + y);
        }

        public static int Sum(short x, decimal y)
        {
            return (int)(x + y);
        }
        #endregion
    }
}
