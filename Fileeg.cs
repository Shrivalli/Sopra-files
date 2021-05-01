using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day2Demos
{
    class Fileeg
    {
        public static void Main()
        {
            //FileStream fs = new FileStream("abc.txt", FileMode.Append, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.Write("welcome to my file"+DateTime.Now);
            //sw.Close();
            //Console.WriteLine("Successfully wrote into the file");
            var i = 10;
            FileStream fs = new FileStream("test.bin", FileMode.Append, FileAccess.Write);
            BinaryWriter sw = new BinaryWriter(fs);
            sw.Write("welcome to my file" + DateTime.Now);
            sw.Close();
            Console.WriteLine("Binary data written");

        }
    }
}
