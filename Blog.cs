using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demos
{
    class Blog
    {
        //Auto implemented properties 
        public int BlogID { get; set; }
        public string BlogName { get; set; }
        public float Ratings { get; set; }
        public DateTime dop { get; set; }
        public Blog()
        {

        }
        public Blog(int bid, string bname, float r, DateTime p)
        {
            BlogID = bid;
            BlogName = bname;
            Ratings = r;
            dop = p;
        }
        public override string ToString()
        {
            return string.Format(BlogID + ":" + BlogName + "*******" + "Ratings: " + Ratings);
        }

        public List<Blog> getBlogs()
        {
            //Object Initializers - Anonymous Types
            List<Blog> blogs = new List<Blog>()
            {
                new Blog(1,"Dotnet",4.5f,Convert.ToDateTime("4/5/2020")),
                new Blog(2,"Java",2.5f,Convert.ToDateTime("4/5/2020")),
                new Blog(3,"Angular",3.5f,Convert.ToDateTime("4/5/2020")),
                new Blog(4,"React",5f,Convert.ToDateTime("4/5/2020"))
            };
            return blogs;
        }
    }
}

//    public class Client
//    { 
//        public static void Main()
//        {
//            Blog obj = new Blog();
//            var result=obj.getBlogs();
//            foreach(var item in result )
//            {
//                //Console.WriteLine(item.BlogID + " " + item.BlogName + "has ratings of  " + item.Ratings);
//                Console.WriteLine(item.ToString());
//            }
//        }

//    }
//}
