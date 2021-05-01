using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    class Jaggedarray
    {
        public static void Main()
        {
            string[][] employee;
            Console.WriteLine("Enter the number of employees");
            int empnum = Convert.ToInt32(Console.ReadLine());
            employee = new string[empnum][];
            for(int i=0;i<empnum;i++)
            {
                Console.WriteLine("Enter the name of the employee:");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter the number of projects done by {name}");
                int numPro = Convert.ToInt32(Console.ReadLine());
                employee[i] = new string[numPro+1];
                //Console.WriteLine(employee[i].Length);
                int k = 0;
                employee[i][k] = name;
                for (int z=1;z<numPro+1;z++)
                {
                    //Console.WriteLine($"I:{i}\nZ:{z}");
                    Console.WriteLine("Enter the project name:");
                    employee[i][z] = Console.ReadLine();
                    
                }
            }
            Console.WriteLine("Details of the projects:");
            for(int i=0;i<empnum;i++)
            {
                int k = 0;
                Console.WriteLine($"Name of the employee {employee[i][k]}");
                Console.Write($"Project names are:");
                for (int j=1;j<employee[i].Length;j++)
                {
                    Console.Write($"{employee[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
