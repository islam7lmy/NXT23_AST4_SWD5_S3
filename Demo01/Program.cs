namespace Demo01
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Comment
            // line comment
            /*
             block comment
             */
            #endregion

            #region Value Type
            //int X;
            ///// allocate 4 uninitialized bytes in stack for X
            ///// int : C# keyword for integer type
            //X = 5; // assign value 5 to X

            //Int32 Y;
            ///// allocate 4 uninitialized bytes in stack for Y
            ///// int32 : .NET type for integer type

            //Y = X; // assign value of X to Y
            //X += 1; // increment X by 1, now X is 6
            //Console.WriteLine(X);
            //Console.WriteLine(Y);
            #endregion

            #region Reference Type
            //Point p1;
            ///// allocate 4 bytes in stack for reference p1
            ///// p1 is uninitialized, it does not point to any object
            ///// zero bytes allocated in heap for Point object

            //p1 = new Point();
            ///// new
            ///// 1. allocate memory in heap for Point object, 8 bytes for X and Y fields
            ///// 2. initialize X and Y to default value 0
            ///// 3. call user-defined constructor (if any) 
            ///// 4. return reference to the allocated object, which is assigned to p1

            //Point p2 = new Point();

            //p2 = p1; // assign reference of p1 to p2, now p1 and p2 point to the same Point object in heap

            //p1.X = 5; // modify X field of the Point object through p1 reference

            //Console.WriteLine(p1.X); // output 5
            //Console.WriteLine(p2.X); // output 5, because p2 points to the same object as p1
            #endregion

            #region Object
            //object o1 = new Point();
            //object o2 =new Point();

            //o1.GetHashCode(); // GetHashCode is a method inherited from System.Object, it returns a hash code for the object
            //o1.ToString(); // ToString is a method inherited from System.Object, it returns a string representation of the object
            //o1.GetType(); // GetType is a method inherited from System.Object, it returns the runtime type of the object
            //o1.Equals(o2); // Equals is a method inherited from System.Object, it determines whether the specified object is equal to the current object

            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());

            //o2 = o1; // assign reference of o1 to o2, now o1 and o2 point to the same object in heap
            //Console.WriteLine("after assignment");

            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());
            #endregion

            #region Fractions and Discard
            //// discard for reading only
            //int X = 1_234_567_891; // C# 7.0 feature, digit separator for better readability

            ////2.2; // double
            //float f = 2.2f;
            //double d = 2.2;
            //decimal m = 2.2m;
            ////var x = 2.2m;
            #endregion

            #region Value Type Casting
            /// 1. implicit casting (safe casting)
            //int X = 5;
            //long Y = X; // implicit casting from int to long, no data loss, no explicit cast operator needed

            //Y = 1234567890123456789;

            /// 2. explicit casting (unsafe casting)
            //X = (int) Y;
            //Console.WriteLine(X);
            //unchecked
            //{
            //    X = (int)Y;
            //    Console.WriteLine(X);
            //}
            //checked
            //{
            //    int Z = (int)Y;
            //    unchecked
            //    {
            //        Console.WriteLine(Z);
            //    }
            //}

            //3. parse (convert from string to any datatype)
            /// int X = int.Parse("123");
            //int X = int.Parse(Console.ReadLine());
            //Console.Write("please enter your name :");
            //string name = Console.ReadLine();
            //Console.Write("please enter your age :");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hello " + name);
            //Console.WriteLine("your age is " + age);

            //4. try parse (safe parsing, returns bool to indicate success or failure)
            //Console.Write("please enter your name :");
            //string name = Console.ReadLine();
            //Console.Write("please enter your age :");
            //int age; 
            //bool Result = int.TryParse(Console.ReadLine(),out age);
            //if (Result)
            //{
            //    Console.WriteLine("Hello " + name);
            //    Console.WriteLine("your age is " + age);
            //}
            //else
            //{
            //    Console.WriteLine("you entered age with wrong format");
            //}

            //5. convert class (provides static methods for converting between types)
            //Console.Write("please enter your name :");
            //string name = Console.ReadLine();
            //Console.Write("please enter your age :");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hello " + name);
            //Console.WriteLine("your age is " + age);
            #endregion

            #region Operators
            #region Unary Operators
            //// Unary Operators => Works On One Operand (Variable)
            //int X = 10;
            ///// prefix [increment and then print]
            //Console.WriteLine(++X); // increment X by 1, now X is 11, then print 11
            ///// postfix [print and then increment]
            //Console.WriteLine(X++); // print 11, then increment X by 1, now X is 12

            //Console.WriteLine(X);

            ///// prefix [decrement and then print]
            //Console.WriteLine(--X); // decrement X by 1, now X is 11, then print 11
            ///// postfix [print and then decrement]
            //Console.WriteLine(X--); // print 11, then decrement X by 1, now X is 10

            //Console.WriteLine(X);
            #endregion
            #region Binary Operators
            //Binary Operators => Works On Two Operand (Variable)
            //int Sum,Mul,Sub,Div,Mod;
            //int num1 = 10, num2 = 3;
            //Sum = num1 + num2; // addition
            //Mul = num1 * num2; // multiplication
            //Sub = num1 - num2; // subtraction
            //Div = num1 / num2; // division
            //Mod = num1 % num2; // modulus (remainder)
            #endregion
            #region Assignment Operator
            //int X = 4;
            //X += 2; // X = X + 2, now X is 6
            //X -= 2; // X = X - 2, now X is 4
            //X *= 2; // X = X * 2, now X is 8
            //X /= 2; // X = X / 2, now X is 4
            //X %= 2; // X = X % 2, now X is 0
            #endregion
            #endregion
        }
    }
}
