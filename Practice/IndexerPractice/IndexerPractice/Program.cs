using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c[1] = "Mercedes";
            c[2] = "Honda";
            c[3] = "Hyundai";
            c[4] = "Toyota";

            Console.WriteLine("Car 1 is: " + c[1]);
            Console.WriteLine("Car 2 is: " + c[2]);
            Console.WriteLine("Car 4 is: " + c[41]);
        }



    public class Car
    {
            string[] car = new string[40];

            public string this[int carNum]
            {
                get
                {
                    if(carNum>=0 && carNum < car.Length)
                    {
                        return car[carNum];
                    }
                    return "Out of index range";
                }


                set
                {
                    if (carNum >= 0 && carNum < car.Length)
                    {
                        car[carNum] = value;
                    }
                }
            }
    }



    }
}
