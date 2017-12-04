using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceExplicitPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Sheldon s = new Sheldon();
           ((IFirst)s).DoThis();

            ((ISecond)s).DoThis();

            ISecond ss = new Sheldon();
            ss.DoThis();
        }
    }



    interface IFirst
    {
        void DoThis();
    }

    interface ISecond
    {
        int DoThis();
    }



    public class Sheldon : IFirst, ISecond
    {
        public void DoThis()
        {
            Console.WriteLine("Implementation of IFirst.DoThis ");
        }

        int ISecond.DoThis()
        {
            Console.WriteLine("Implementation of ISecond.DoThis ");
            return 6;
        }

        public void Test()
        {
            // add code
        }
    }
}
