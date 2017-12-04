using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication2
{

    class Program
    {
        static void Main(string[] args)
        {
            StringReadWrite srw = new StringReadWrite();
        }

        #region "Write data using StringWriter"

        public class StringReadWrite
        {

            StringBuilder sb = new StringBuilder();

            public StringReadWrite()
            {
                WriteData();
                ReadData();
            }

            public void WriteData()
            {
                StringWriter sw = new StringWriter(sb);

                Console.WriteLine("Please enter your first and last name: ");
                string name = Console.ReadLine();

                sw.WriteLine("Name: " + name);

                sw.Flush();
                sw.Close();
           }

            #endregion


            #region "Reading the string"
            public void ReadData()
            {
                StringReader sr = new StringReader(sb.ToString());

                Console.WriteLine("Reading the information ");

                while (sr.Peek() > -1)
                {
                    Console.WriteLine(sr.ReadLine());
                }

                Console.WriteLine();
                Console.WriteLine("Thank you for using our string program!");

                sr.Close();

            }

            #endregion








        }
    }
}
