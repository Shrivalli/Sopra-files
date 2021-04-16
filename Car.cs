using System;
using System.Collections.Generic;
using System.Text;

namespace Day2Demos
{
    class Car
    {
        public int CarNo { get; set; }
        public string BrandName { get; set; }
        public float Price { get; set; }
        public DateTime Dom { get; set; }

        //public Car()
        //{

        //}

        public Car(int cno, string bname, float Price, DateTime dom)
        {
            CarNo = cno;
            BrandName = bname;
            this.Price = Price;
            Dom = dom;
        }

        public static List<Car> getcars()
        {
            List<Car> cars = new List<Car>();
            Car obj1 = new Car(1234, "abcd", 34343, Convert.ToDateTime("4/5/2020"));
            cars.Add(new Car(4343, "Ford", 23232, Convert.ToDateTime("3/4/2020")));
            cars.Add(new Car(4365, "Honda", 923232, Convert.ToDateTime("3/4/2021")));
            cars.Add(new Car(6843, "Hyundai", 423232, Convert.ToDateTime("3/5/2020")));
            cars.Add(new Car(9343, "Maruti", 523232, Convert.ToDateTime("3/2/2020")));
            cars.Add(new Car(4283, "BMW", 723232, Convert.ToDateTime("9/4/2020")));
            cars.Add(obj1);
            return cars;
        }

        public override string ToString()
        {
            return string.Format(CarNo + "  " + BrandName + "*******" + Price + "----------"
                + Dom.ToShortDateString());
        }
    }

    class carclient
    { 
        public static void Main()
        {
            List<Car> cs = Car.getcars();
            foreach(Car item in cs)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

}
