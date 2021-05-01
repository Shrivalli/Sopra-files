//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day2Demos
//{
//    class exceptioneg
//    {
// Author : Shrivalli
//Date :30th May 2021
//        public static void Main()
//        {

//            //try block contains all set of statements which might cause
//            //an exception
//            //try block should be followed by a catch block or finally block
//            int x, y, res=0;
//            Console.WriteLine("Enter  2 numbers");
//            try
//            {
//                x = Convert.ToInt32(Console.ReadLine());
//                y = Convert.ToInt32(Console.ReadLine());
//                res = x / y;
//                int[] a = new int[4] { 7, 8, 9, 2 };
//                Console.WriteLine(a[6]);

//            }
//            catch (FormatException f)
//            {
//                Console.WriteLine("Please enter only numbers");
//                Console.WriteLine(f.Source);
//            }
//            catch(IndexOutOfRangeException )
//            {
//                Console.WriteLine("Array does not have the range");
//            }
//            catch(DivideByZeroException)
//            {
//                Console.WriteLine("Division by Zero is not allowed");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//            Console.WriteLine("Sum:"+res);

//        }
//    }
//}
