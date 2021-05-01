//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Day2Demos
//{
//    //Function Delegate, Action Delegate and Predicate
//    class expressioneg
//    {
//       public static Func<Blog, bool> ExcellentBlog = s => s.Ratings >= 4;

//        public bool CheckRatings(Blog s)
//        {
//            return s.Ratings > 18;
//        }

//        public static void Main()
//        {
//            Blog obj = new Blog();
//            var result=obj.getBlogs();
//            foreach(var item in result)
//            {
//                if(ExcellentBlog(item)==true)
//                {
//                    Console.WriteLine(item.BlogName);
//                }
//            }
//        }
//    }
//}
