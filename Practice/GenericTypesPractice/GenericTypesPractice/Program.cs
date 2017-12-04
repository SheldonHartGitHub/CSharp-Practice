using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericTypesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList list1 = new System.Collections.ArrayList();
            list1.Add(3);
            list1.Add(5);
            list1.Add(12);
            //list1.Add("Hello");

            Console.WriteLine("Non-GenericTypesPractice List results...");
            foreach (int x in list1)
            {
                Console.WriteLine(x);
            }


            List<int> list2 = new List<int>();
            list2.Add(34);
            list2.Add(9);
            list2.Add(21);
            list2.Add("Hello");

            Console.WriteLine("Generic list results");
            foreach (int item in list2)
            {
                Console.WriteLine(item);
            }














        }
    }
}
