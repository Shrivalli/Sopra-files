//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day2Demos
//{
//    class delegateeg
//    {
//        //function pointers - reference types
//        public delegate void delcalci(int a, int b);//Delegate declaraiton
//        public delegate void printmsg(string s);//declaring a delegate
//        public static void add(int x, int y)
//        {
//            Console.WriteLine(x + y);
//        }

//        public static void inc(int z)
//        {
//            z = z + 1;
//            Console.WriteLine(z);
//        }
//        public static void mul(int x, int y)
//        {
//            Console.WriteLine(x * y);
//        }

//        public static void div(int x, int y)
//        {
//            Console.WriteLine(x / y);
//        }

//        public static void sub(int x, int y)
//        {
//            Console.WriteLine(x - y);
//        }

//        public static void Main()
//        {
//            //Abstraction and security
//            //Chain of methods
//            //Two types of delegates - single cast, multicast
//            delcalci d1 = new delcalci(add);
//            delcalci d2 = new delcalci(mul);
//            delcalci d3 = new delcalci(div);
//            delcalci d4 = new delcalci(sub);

//            //add(10, 20);
//            //mul(40, 50);
//           // d1(10, 20);
//            //d2(40, 20);

//            //multicast delegate
//            delcalci d5;
//            d5 = d1 + d2 + d3 + d4;
//            d5(100, 20);
            
//            //Anonymous Delegate - using anonymous methods
//            printmsg p = delegate (string name)
//            {
//                Console.WriteLine("printing using delegates" + name);
//            };
//              p("Vandhana");
//        }
//    }
//}
