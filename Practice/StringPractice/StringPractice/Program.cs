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
            var dogs = new List<string>();

            dogs.Add("Bulldog");
            dogs.Add("Doberman");
            dogs.Add("Retriever");

            //// foreach to move through the list
            //foreach (var dog in dogs)
            //{
            //    Console.WriteLine(dog + " ");
            //}

            int[] a1 = new int[] { 1, 3, 5, 9, 11 };

            foreach (int i in a1)
            {
                Console.WriteLine(i + " ");
            }

            string str1, str2;

            str1 = " ";
            
            Console.WriteLine("Please enter a string of characters");
            str2 = Console.ReadLine();

            int leg = str2.Length;

            for (int i = 0; i < leg; i--)
            {
                Console.WriteLine(leg + str1);
            }

        }
    }
}
