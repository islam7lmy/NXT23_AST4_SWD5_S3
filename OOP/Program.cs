//using Commen;
//using OOP.Inhertiance;
using OOP.Interfaces;
using OOP.PolyMorphism_OverRiding;
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
            //object obj = new object();
            //obj.ToString();

            //TypeA a = new TypeA(10);
            //Console.WriteLine(a.ToString());

            //TypeB b = new TypeB(10,20);
            //b.MyFun01();
            //b.MyFun02();
            #endregion
            #endregion

            #region Binding
            #region What is Binding
            /// reference => stack
            /// object => heap
            /// binding => create reference form parent type and create object from child type
            //Parent p = new Child(10,20,30); //binding

            //Child c =(Child) new Parent(10,20); //not binding

            //TypeB b = new TypeB(10, 20);
            //b.A = 1;
            //b.B = 2;
            //b.MyFun01();
            //b.MyFun02();
            //Console.WriteLine(b.ToString());

            //TypeA a = new TypeB(10, 20);
            //a.A = 1;
            ////a.B = 2; //invalid
            //a.MyFun01();
            //a.MyFun02();
            ////a.MyFun03();//invalid
            //Console.WriteLine(a.ToString());

            ///static binding [early binding]
            ///Complier will bind function call based on reference type not object type
            //a.MyFun01(); /// will run parent Code

            ///dynamic binding [late binding]
            ///complier will bind function call based on object type not reference type
            //a.MyFun02(); /// will run child code
            #endregion
            #region Not Binding
            ///animal = dog; //binding
            ///dog =(dog) animal; //not binding

            ///Child c =(Child) new Parent(10,20); //not binding
            #endregion
            #region Why Need Binding
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            ////Employee emp = new FullTimeEmployee(); //binding
            //ProcessEmployee(fullTimeEmployee);
            //ProcessEmployee(new FullTimeEmployee());

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            ////Employee emp = new PartTimeEmployee();
            //ProcessEmployee(partTimeEmployee);
            #endregion
            #region More Practise On Binding
            //TypeA typeA = new TypeC(1, 2, 3); /// reference from Indirect Parent
            //typeA.A = 11;
            ////typeA.B = 22;//invalid
            ////typeA.C = 33;//invalid
            //typeA.MyFun01(); ///Hii i am MyFun01 of TypeA [Parent]
            //typeA.MyFun02(); ///TypeC: A = 11, B = 2, C = 3
            ////typeA.MyFun03();//invalid

            //TypeB typeB = new TypeC(1, 2, 3); /// reference from direct Parent
            //typeB.A = 11;
            //typeB.B = 22;
            ////typeB.C = 33;//invalid
            //typeB.MyFun01(); ///Hii i am MyFun01 of TypeB [Child]
            //typeB.MyFun02(); ///TypeC: A = 11, B = 22, C = 3
            //typeB.MyFun03(); ///I am test function

            //TypeA typeA = new TypeD(1, 2, 3, 4); 
            //TypeB typeB = new TypeD(1, 2, 3, 4); 
            //TypeC typeC = new TypeD(1, 2, 3, 4); 

            //typeA.MyFun02();///TypeC: A = 1, B = 2, C = 3
            //typeB.MyFun02();///TypeC: A = 1, B = 2, C = 3
            //typeC.MyFun02();///TypeC: A = 1, B = 2, C = 3


            //TypeA typeA = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD1 = new TypeD(1, 2, 3, 4);
            //TypeD typeD2 = new TypeE(1, 2, 3, 4, 5);

            //typeA.MyFun02();///TypeC: A = 1, B = 2, C = 3
            //typeB.MyFun02();///TypeC: A = 1, B = 2, C = 3
            //typeC.MyFun02();///TypeC: A = 1, B = 2, C = 3
            //typeD1.MyFun02();///TypeD: A = 1, B = 2, C = 3, D = 4
            //typeD2.MyFun02();///TypeE: A = 1, B = 2, C = 3, D = 4, E = 5

            #endregion
            #endregion

            #region Interfaces
            #region Ex01
            //IMyType myType0 = new IMyType(); //not valid

            /// reference form parent type => refere object from child type
            //IMyType myType = new MyTypeV2(); //binding
            //myType.MyFun("***");
            //myType.Salary = 20;
            //myType.Print(); ///default implmented

            //MyTypeV1 myTypeV1 = new MyTypeV1();
            //myTypeV1.MyFun("**");
            //myTypeV1.Salary = 20;
            //myTypeV1.Print(); /// not valid
            #endregion
            #region Ex02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesByTwo);
            //Print10NumbersFromSeries(new SeriesByTwo());
            //Print10NumbersFromSeries(new SeriesByThree());
            //Print10NumbersFromSeries(new SeriesByFour());
            #endregion
            #region Implment Interface Implicitly Vs Implment Interface Explicitly
            //OOP.Interfaces.Car car = new OOP.Interfaces.Car();
            //car.Forward();
            //car.Backward();

            //AirPlan plan = new AirPlan();
            //plan.Backward(); //implicit
            ////plan.Forward();//notvalid because its explicit implment

            //IFlayable flayable = plan;
            //flayable.Forward();

            //IMoveable moveable = plan;
            //moveable.Forward();

            #endregion
            #endregion

            #region Shallow Copy Vs Deep Copy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");
            #region Shallow Copy
            //Arr02 = Arr01; ///Shallow Copy => copy Refernece Only
            ////Arr02[0] = 30;
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");
            #endregion

            #region Deep Copy
            //Arr02 = (int[])Arr01.Clone();
            ////Arr02[0] = 30;
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 = {Arr02.GetHashCode()}");
            #endregion
            //foreach (int i in Arr01)
            //{
            //    Console.Write($"{i}\t");
            //}
            //Console.WriteLine();
            //foreach (int i in Arr02)
            //{
            //    Console.Write($"{i}\t");
            //}

            //int x = 5;
            //int y = 10;
            //y = x;
            //y = 30;

            #endregion

            #region Built-In Interface ICloneable
            //OOP.Interfaces.Employee emp01 = new OOP.Interfaces.Employee() { Id = 10, Name = "Ahmed", Salary = 4000 };
            //OOP.Interfaces.Employee emp02 = new OOP.Interfaces.Employee() { Id = 20, Name = "Omr", Salary = 8000 };

            //Console.WriteLine($"emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"emp02 : {emp02.GetHashCode()}");

            //emp02 = emp01;
            //Console.WriteLine("after Shallow copy");
            //Console.WriteLine($"emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"emp02 : {emp02.GetHashCode()}");


            //emp02 = OOP.Interfaces.Employee.DeepCopy(emp01);
            //emp02 = new OOP.Interfaces.Employee(emp01);
            //emp02 =(OOP.Interfaces.Employee) emp01.Clone();
            //Console.WriteLine("after Deep copy");
            //Console.WriteLine($"emp01 : {emp01.GetHashCode()}");
            //Console.WriteLine($"emp02 : {emp02.GetHashCode()}");
            //Console.WriteLine(emp01);
            //Console.WriteLine(emp02);

            //OOP.Interfaces.Employee[] employees01 = {
            //    new OOP.Interfaces.Employee(){ Id = 10, Name = "Ahmed", Salary = 4000 },
            //    new OOP.Interfaces.Employee(){ Id = 20, Name = "omr", Salary = 8000 },
            //    new OOP.Interfaces.Employee(){ Id = 30, Name = "Mohamed", Salary = 10000 },
            //};


            //OOP.Interfaces.Employee[] employees02 = {
            //    new OOP.Interfaces.Employee(){ Id = 40, Name = "Ali", Salary = 4000 },
            //    new OOP.Interfaces.Employee(){ Id = 50, Name = "Medhat", Salary = 8000 },
            //    new OOP.Interfaces.Employee(){ Id = 60, Name = "Ibrahem", Salary = 10000 },
            //};

            //employees02 =(OOP.Interfaces.Employee[]) employees01.Clone();

            //foreach (var item in employees01)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("///////////////////////////////////////////////////");

            //foreach (var item in employees02)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Built-In Interface IComparable

            #endregion
            #region Abstract Class

            #endregion

            #region Operator Overloading

            #endregion

            #region User-Defined Casting Operator

            #endregion
        }

        #region PolyMorphism - OverLoading
        ///1. data types of parameters
        ///2. Count of parameters
        ///3. order of parameters if not same data types


        //public static int Sum(int y, short x)
        //{
        //    return x + y;
        //}

        //public static int Sum(int x, short y) // not overloading because same signature as Sum(int y, short x)
        //{
        //    return x + y;
        //}
        //public static double Sum(int y, short x)  /// not overloading because same signature as Sum(short x, int y)
        //{
        //    return x + y;
        //}
        //public static int Sum(short x, short y, short z)
        //{
        //    return x + y + z;
        //}
        //public static int Sum(short x, short y)
        //{
        //    return x + y;
        //}
        //public static int Sum(short x, int y)
        //{
        //    return x + y;
        //}
        //public static int Sum(int x, int y)
        //{
        //    return x + y;
        //}
        //public static int Sum(long x, int y)
        //{
        //    return (int)(x + y);
        //}
        //public static int Sum(long x, long y)
        //{
        //    return (int)(x + y);
        //}
        //public static int Sum(short x, float y)
        //{
        //    return (int)(x + y);
        //}

        //public static int Sum(short x, double y)
        //{
        //    return (int)(x + y);
        //}

        //public static int Sum(short x, decimal y)
        //{
        //    return (int)(x + y);
        //}
        #endregion

        #region Why Need Binding
        public static void ProcessEmployee(PolyMorphism_OverRiding.Employee emp)
        {
            if (emp is not null)
            {
                /// i need to run reference code
                /// so you must override it with static binding
                /// new key word
                emp.MyFun01(); /// parent code

                /// i need to run object code
                /// so you must override it with dynamic binding
                /// override key word
                emp.MyFun02(); /// child code
            }
        }

        //public static void ProcessEmployee(FullTimeEmployee emp)
        //{
        //    if(emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}

        //public static void ProcessEmployee(PartTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}

        //public static void ProcessEmployee(FreeLanceEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}
        #endregion

        #region InterFaces
        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(series.Current);
                    Console.Write("\t");
                    series.GetNext();
                }
                series.Reset();
                Console.WriteLine();
            }
        }

        //public static void Print10NumbersFromSeries(SeriesByTwo series)
        //{
        //    if (series is not null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.Write(series.Current);
        //            Console.Write("\t");
        //            series.GetNext();
        //        }
        //        series.Reset();
        //        Console.WriteLine();
        //    }
        //}

        //public static void Print10NumbersFromSeries(SeriesByThree series)
        //{
        //    if (series is not null)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.Write(series.Current);
        //            Console.Write("\t");
        //            series.GetNext();
        //        }
        //        series.Reset();
        //        Console.WriteLine();
        //    }
        //} 
        #endregion
    }
}
