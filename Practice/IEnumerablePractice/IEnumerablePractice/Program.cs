using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = new List<string>();
            cars.Add("Hyundai");
            cars.Add("Honda");
            cars.Add("Mazda");
            cars.Add("Ford");

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("\n" + "Now in our own collection " + "\n");

            Car c = new Car();
            c[0] = "Chevy";
            c[1] = "Mercedes";
            c[2] = "Dodge";

            foreach (string car in c)
            {
                Console.WriteLine(car);
            }

        }
    }

    public class Car : IEnumerable
    {
        string[] car = new string[3];

        public string this[int carNum]
        {
            get { return car[carNum]; }
            set { car[carNum] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (string c in car)
            {
                yield return c;
            }
        }
    }






}
