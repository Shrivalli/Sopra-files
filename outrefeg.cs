using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demos
{
    class outrefeg
    {
        static int Inc(int i)//in parameter
        {
           return ++i;
        }

        public static void AddnMul(int x,int y,out int sum, out int prod)
        {
            sum = x + y;
            prod = x * y;
        }

        static void swap(ref int x, ref int y)
        {
            int t;
            t = x;
            x = y;
            y = t;
            Console.WriteLine("With in swap method");
            Console.WriteLine("Value of a:" + x);
            Console.WriteLine("Value of b:" + y);
        }

        static void PrintNames(params string[] names)
        {
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
        //public static void Main()
        //{
        //    //int z = Inc(5);
        //    //Console.WriteLine(z);

        //    //int add1, prod1;
        //    //AddnMul(4, 5, out add1, out prod1);
        //    //Console.WriteLine("Addition :" + add1);
        //    //Console.WriteLine("Multiplication: " + prod1);

        //    //int a = 10, b = 20;
        //    //Console.WriteLine("Values before swapping:");
        //    //Console.WriteLine("A: {0}, B:{1}", a, b);
        //    //swap(ref a, ref b);
        //    //Console.WriteLine("Values After swapping:");
        //    //Console.WriteLine("A: {0}, B:{1}", a, b);

        //    PrintNames("Radha", "Vandhana");
        //    PrintNames("Sam", "Ram", "Tom");


        //}
    }
}
