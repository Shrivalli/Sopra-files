//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day2Demos
//{
class student
{
    //private variable
    int sid;
    string sname;
    public float Age { get; set; }
    public string Sname
    {
        get { return sname; }
        set { sname = value; }
    }
    //public property
    public int Sid
    {
        get { return sid; }
        set
        {
            if (value > 0)
            { sid = value; }
            else
            {
                sid = 1;
            }
        }

    }
}
//        class propseg
//        {
//            static int x;
//            public static int accept()
//            {
//                Console.WriteLine("Enter a value");
//                x = Convert.ToInt32(Console.ReadLine());
//                return x;
//            }
//            public static void Main()
//            {
//                //access private variables outside the class but still the restrictions 
//                //has to be implemented - Properties
//                student s = new student();
//                s.Sid = accept(); ;//set method is called
//                Console.WriteLine(s.Sid);//get method is called
//            }
//        }
//    }
//}
