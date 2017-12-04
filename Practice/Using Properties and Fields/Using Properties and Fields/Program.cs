using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Using_Properties_and_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 91;

            Console.WriteLine("Age: " + p.Age);
        }
    }

    public class Person
    {

        

        public string FirstName { get; set; }

        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }







        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if ((value > 0) && (value < 65))
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Age cannot be over 65");
                }
            }
        }
    }
}
