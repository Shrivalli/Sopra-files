using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demos
{
    class iphone : Smartphone
    {
        public void camera()
        {
            Console.WriteLine("Camera implemented");
        }

        public void unlock()
        {
            Console.WriteLine("Unlock implemented");
        }

        public bool wifi()
        {
            return true;
        }
    }
    class samsung : Smartphone,sm1
    {
        public void camera()
        {
            Console.WriteLine("Camera implemented in samsung");
        }

        public void socialnetworking()
        {
            Console.WriteLine("Social Networking implemented");
        }

        void Smartphone.unlock()
        {
            Console.WriteLine("Smartphone unlock implemented in samsung");
        }
         void sm1.unlock()
        {
            Console.WriteLine("sm Unlock implemented in samsung");
        }

        public bool wifi()
        {
            return false;
        }
    }
}
