using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demos
{
    abstract class Shape
    {
        string color;
        protected float area;

        //Non abstract 
        public void dummy()
        {
            Console.WriteLine("Dummy method");
        }
        public virtual void Accept()
        {
            Console.WriteLine("Enter the color");
            color = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.WriteLine("The color is " + color);
        }

        public abstract void CalculateArea();
        
    }
    class Rectangle : Shape
    {
        int length, breadth;

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Length and Breadth");
            length = Convert.ToInt32(Console.ReadLine());
            breadth = Convert.ToInt32(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Length :" + length);
            Console.WriteLine("Breadth: " + breadth);
        }

        public override void CalculateArea()
        {
            area = length * breadth;
            Console.WriteLine("Area of Rectangle is :" + area);
        }
    }

    class Triangle :Shape
    {
        int height, b;

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter height and Base");
            height = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            area = float.Parse((0.5 * b * height).ToString());
        }

        //public override void Display()
        //{
        //    base.Display();
        //    Console.WriteLine("Area:" + area);
        //    Console.WriteLine("Base: " + b);
        //    Console.WriteLine("Height:" + height);
        //}
        public new void Display()
        {
            Console.WriteLine("Triangle's Display method");
        }
    }
}
