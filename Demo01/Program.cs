using System.Text;

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
            #region Relational Operators [Comparsion]
            //int X = 6, Y = 5;
            //Console.WriteLine(X == Y); // equality operator, returns true if X and Y are equal, otherwise false
            //Console.WriteLine(X != Y); // inequality operator, returns true if X and Y are not equal, otherwise false
            //Console.WriteLine(X > Y); // greater than operator, returns true if X is greater than Y, otherwise false
            //Console.WriteLine(X < Y); // less than operator, returns true if X is less than Y, otherwise false
            //Console.WriteLine(X >= Y); // greater than or equal operator, returns true if X is greater than or equal to Y, otherwise false
            //Console.WriteLine(X <= Y); // less than or equal operator, returns true if X is less than or equal to Y, otherwise false
            #endregion
            #region Logical Operators
            //Console.WriteLine(!false); // logical NOT operator, returns true if the operand is false, otherwise false
            //Console.WriteLine(false && true); //short circuit // logical AND operator, returns true if both operands are true, otherwise false
            //Console.WriteLine(true || false); //short circuit // logical OR operator, returns true if at least one operand is true, otherwise false

            //Console.WriteLine((4<5) && ((7<9) || 5 ==5)); // logical expression with multiple operators, evaluates to true
            #endregion
            #region Bitwise Operators
            //Console.WriteLine(false & true); //long circuit // bitwise AND operator, returns true if both operands are true, otherwise false
            //Console.WriteLine(true | false); //long circuit // bitwise OR operator, returns true if at least one operand is true, otherwise false
            //Console.WriteLine(true ^ false); // bitwise XOR operator, returns true if exactly one operand is true, otherwise false
            #endregion
            #region Ternary Operator [Conditional Operator]
            //int X = 4 , Y = 7;
            //if(X > Y)
            //    Console.WriteLine("X is greater than Y");
            //else
            //    Console.WriteLine("Y is greater than X");

            //Console.WriteLine(X > Y ? "X is greater than Y" : "Y is greater than X");

            //int flag = X > Y ? 1 : 0;

            //int flag;
            //if (X > Y)
            //    flag = 1;
            //else
            //    flag = 0;
            #endregion
            #region Operator Priorty
            /*
             * 1. unary operators (prefix) ++x , --x
             * 2. round brackets (parentheses)
             * 3. multiplicative operators * , / , %
             * 4. additive operators + , -
             */
            //int a = 20, b = 10, c = 15, d = 5, e;
            //e = (a + b) * c / d; // e = (20 + 10) * 15 / 5 = 30 * 15 / 5 = 450 / 5 = 90
            //e = ((--a + b) * c) / d; // e = ((19 + 10) * 15) / 5 = (29 * 15) / 5 = 435 / 5 = 87
            //e = --a + b * c / d; //e = 19 + 10 * 15 / 5 = 19 + 150 / 5 = 19 + 30 = 49
            #endregion
            #endregion

            #region String vs Stringbuilder
            //Console.WriteLine("string");
            //string X = "Hello"; // syntex sugar string X = new string("Hello");
            //Console.WriteLine(X.GetHashCode());
            //X += " World"; //x = "hello" + "world" = new string("hello world")  
            //Console.WriteLine(X.GetHashCode());
            //// string is immutable, so a new string object is created in heap with value "Hello World", and X reference is updated to point to the new object, the old string "Hello" is eligible for garbage collection
            //X = "hello ahmed"; // a new string object is created in heap with value "hello ahmed", and X reference is updated to point to the new object, the old string "Hello World" is eligible for garbage collection
            //Console.WriteLine(X.GetHashCode());
            //////////////////////////////////////////////
            //Console.WriteLine("StringBuilder");
            //StringBuilder Y = new StringBuilder("Hello"); // allocate StringBuilder object in heap with initial value "Hello", and Y reference points to it
            //Console.WriteLine(Y.GetHashCode());
            //Y.Append(" World"); // modify the existing StringBuilder object by appending " World" to it, no new object is created, Y reference still points to the same object with updated value "Hello World"
            //Console.WriteLine(Y.GetHashCode());
            //Y.Append(" hello ahmed"); // modify the existing StringBuilder object by appending " hello ahmed" to it, no new object is created, Y reference still points to the same object with updated value "Hello World hello ahmed"
            //Console.WriteLine(Y.GetHashCode());
            #endregion

            #region String Formating
            // Equation : 4 + 2 = 6
            //int num1 = 4, num2 = 2;
            //1. string concatenation
            //string result1 = "Equation : " + num1 + " + " + num2 + " = " + (num1 + num2);
            //2. string format method
            //string result1 = string.Format("Equation : {0} + {1} = {2}", num1, num2,(num1 + num2));
            //3. string interpolation (C# 6.0 feature)
            //string result1 = $"Equation : {num1} + {num2} = {num1 + num2}";
            //Console.WriteLine(result1);
            #endregion

            #region Conditional statments
            #region EX01
            #region If
            //Console.Write("insert number of month in first qurter of year : ");
            ////int month;
            //if (int.TryParse(Console.ReadLine(), out int month))
            //{
            //    if (month == 1)
            //    {
            //        Console.WriteLine("January");
            //    }
            //    else if (month == 2)
            //    {
            //        Console.WriteLine("February");
            //    }
            //    else if (month == 3)
            //    {
            //        Console.WriteLine("March");
            //    }
            //    else
            //    {
            //        Console.WriteLine("invalid month number");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("you entered month number with wrong format");
            //}
            #endregion

            #region Switch
            //Console.Write("insert number of month in first qurter of year : ");
            ////int month;
            //if (int.TryParse(Console.ReadLine(), out int month))
            //{
            //    // jump table => O(1) time complexity, no need to evaluate multiple conditions like in if-else if ladder, the program directly jumps to the case that matches the value of month
            //    switch (month)
            //    {
            //        case 1:
            //            Console.WriteLine("January");
            //            break;
            //        case 2:
            //            Console.WriteLine("February");
            //            break;
            //        case 3:
            //            Console.WriteLine("March");
            //            break;
            //        default:
            //            Console.WriteLine("invalid month number");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("you entered month number with wrong format");
            //}
            #endregion

            #endregion
            #region EX02
            //int value = 3000;
            //switch (value)
            //{
            //    case 3000:
            //        Console.WriteLine("option 03");
            //        //Console.WriteLine("option 02");
            //        //Console.WriteLine("option 01");
            //        //break;
            //        goto case 2000; // jump to case 2000 without evaluating its condition, this is a feature of switch statement that allows fall-through behavior
            //    case 2000:
            //        Console.WriteLine("option 02");
            //        //Console.WriteLine("option 01");
            //        //break;
            //        goto case 1000; // jump to case 1000 without evaluating its condition
            //    case 1000:
            //        Console.WriteLine("option 01");
            //        break;
            //    default:
            //        Console.WriteLine("NA");
            //        break;
            //}
            #endregion
            #region EX03: Calculter
            /// +,-,*,/,%
            /// num1, opretation ,num2
            /// protective
            #endregion
            #endregion

            #region Loop Statments
            /// 1 -> 10
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            #region For
            ///1. for loop
            /// for (initialization; condition; iteration)

            /// initialization: executed once at the beginning of the loop, used to initialize loop control variable
            /// condition: evaluated before each iteration, if it evaluates to true, the loop body is executed, otherwise the loop terminates
            /// body: the code that is executed in each iteration of the loop
            /// iteration : executed at the end of each iteration, used to update loop control variable
            /// condition: typically involves the loop control variable and determines when the loop should stop executing

            //for (int i = 1; i <= 10; i++)
            //for (int i = 1; i <= 10; ++i)
            //{
            //    Console.WriteLine(i);
            //}


            /*int i = 1;
            for (; ; )
            {
                if (i <= 10)
                {
                    if (i % 2 == 0)
                    {
                        i++;
                        continue; // skip the rest of the loop body and start the next iteration, this is a feature of loop statements that allows you to skip certain iterations based on a condition
                    }
                    Console.WriteLine(i);
                    i++;
                }
                else
                {
                    break; // exit the loop when i is greater than 10
                    //Console.WriteLine("running");
                }
            }*/

            /*for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // skip the rest of the loop body and start the next iteration when i is even
                }
                Console.WriteLine(i); // print odd numbers from 1 to 10
            }*/

            //int x = 1;
            //x++; //x = 2
            //Console.WriteLine(x); //print 2 | x  2
            ////////////////////////////////////////////////
            //++x; //x = 2
            //Console.WriteLine(x); //print 2 | x  2

            //Console.WriteLine(++x); // print 2 | x  2
            //////////////////////////////////////////////////
            //Console.WriteLine(x++); // print 1 | x  2 
            #endregion

            #region While
            /*while(reader.Read()) //false when end of file is reached, true if there are more lines to read
            {

            }*/

            //Console.WriteLine("insert 0 if you want to continue");
            //string input = Console.ReadLine();
            //while (input == "0")
            //{
            //    Console.WriteLine("you are in the loop");
            //    Console.WriteLine("insert 0 if you want to continue");
            //    input = Console.ReadLine();
            //}

            /*while (true)
            {
                Console.WriteLine("insert first number");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("wrong format,please insert first number");
                }
                Console.WriteLine("insert operation (+ , - , * , / , %)");
                char operation;
                while(!(char.TryParse(Console.ReadLine(), out operation)
                    &&
                    (operation == '+' || operation == '-' ||
                    operation == '*' || operation == '/' ||
                    operation == '%')))
                {
                    Console.WriteLine("wrong format,please insert operation (+ , - , * , / , %)");
                }
                //if (char.TryParse(Console.ReadLine(), out operation)
                //    &&
                //    (operation == '+' || operation == '-' ||
                //    operation == '*' || operation == '/' ||
                //    operation == '%')
                //    )
                //{
                //    Console.WriteLine("operation is char");
                //    Console.WriteLine("operation is valid");
                //}
                //else
                //{
                //    Console.WriteLine("not valid char");
                //    Console.WriteLine("operation is not valid");
                //}

                Console.WriteLine("insert seconed number");
                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("wrong format,please insert seconed number");
                }
                var result = 0;
                //    operation switch
                //{
                //    '+' => num1 + num2,
                //    '-' => num1 - num2,
                //    '*' => num1 * num2,
                //    '/' => num2 != 0 ? num1 / num2 : double.NaN, // handle division by zero case
                //    '%' => num2 != 0 ? num1 % num2 : double.NaN, // handle modulus by zero case
                //    _ => double.NaN // this case should never be hit due to input validation, but it's good practice to have a default case
                //};
                Console.WriteLine($"Eqution: {num1} {operation} {num2} = {result}");
                Console.WriteLine("/////////////////////////////////////////////////////////////");
            }*/
            #endregion

            #region do while
            //for(int i = 11; i<= 10; i++)
            //    Console.WriteLine(i);

            //int i = 11;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}while (i <= 10);

            //double num1;
            //do
            //{
            //    Console.WriteLine("insert first number");
            //} while (!double.TryParse(Console.ReadLine(), out num1));

            #endregion

            #region foreach
            //collections
            //List<string> names = new List<string> { "Ahmed", "Ali", "Omar" };
            //for (int i = 0; i < names.Count; i++)
            //{
            //    string item = names[i];
            //    item = $"hello {item}";
            //    //Console.WriteLine(item);
            //}

            //foreach (string item in names) //for displaying items in collection, it is read-only, you cannot modify the collection items through the loop variable, this is a feature of foreach loop that ensures the integrity of the collection while iterating over it
            //    //item = $"hello {item}";
            //    Console.WriteLine(item);
            #endregion
            #endregion

            #region Block Scope
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(i); //out of scope, i is only accessible within the for loop block


            //if(double.TryParse(Console.ReadLine(),out double x))
            //{
            //    Console.WriteLine(x);
            //}
            //Console.WriteLine(x);

            //while(double.TryParse(Console.ReadLine(), out double y))
            //{
            //    Console.WriteLine(y);
            //}
            //Console.WriteLine(y);

            //{ 
            //    int x;
            //    x = 5; 
            //}

            //{
            //    int x;
            //    x = 5;
            //}
            #endregion

            #region Arrays
            #region One D Array
            ///array reference type

            //int[] numbers = new int[5];
            //int[] numbers = new int[] {1,2,3,4,5};
            //int[] numbers2 = { 1, 2, 3, 4, 5 };

            //numbers[0] = 5;
            //numbers[5] = 6;

            //Console.WriteLine($"the size of array = {numbers.Length} , the number of dimensions = {numbers.Rank}");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"enter the {i + 1} element of array");
            //    } while (!int.TryParse(Console.ReadLine(), out numbers[i]));
            //}

            //foreach (int item in numbers)
            //    Console.WriteLine(item);
            #endregion
            #region Two D Array [Rectangular]
            //int[,] Marks;
            //Marks = new int[3, 5];

            //Console.WriteLine($"the size of array = {Marks.Length} , the number of dimensions = {Marks.Rank}");
            //Console.WriteLine($"{Marks.GetLength(0)} , {Marks.GetLength(1)}");

            #endregion
            #region Two D Array [Judged]
            //int[][] numbers;
            //numbers = new int[3][];

            //numbers[0] = new int[] { 1, 2, 3 };
            //numbers[1] = new int[] { 1, 2 };
            //numbers[2] = new int[] { 1 };

            //numbers[0][0] = 20;
            #endregion
            #region Array Methods

            #endregion
            #endregion

            #region Nullable types

            #endregion

            #region Null Propagation Operator

            #endregion

            #region Functions

            #endregion

            #region Exceptions Handling

            #endregion

            #region Enums

            #endregion
        }
    }
}
