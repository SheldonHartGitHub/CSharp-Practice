using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OverloadingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.CheckBilling();
            p.CheckBilling(3, 3);
            p.CheckBilling("Sheldon", 3);

            Child c = new Child();
            c.CheckBilling("b", "c");
        }
    }


    public class Patient
    {
        public void CheckBilling()
        {
            Console.WriteLine("Patient: The billing has been checked ");
        }


        public void CheckBilling(int a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using two submitted integers ");
        }

        public void CheckBilling(string a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using a submitted string and an integer ");
        }
    }

    public class Child : Patient
    {
        public void CheckBilling(string a, string b)
        {
            Console.WriteLine("Child: The billing has been checked using two submitted strings ");
        }
    }

}
