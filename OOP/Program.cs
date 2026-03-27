using Commen;
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
            PhoneBook book = new PhoneBook();
            book.AddNumbers("amr", 123, 0);
            book.AddNumbers("ali", 456, 1);
            book.AddNumbers("aya", 789, 2);



            #endregion
            #endregion
        }
    }
}
