using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassesAndObjectsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee();
            e1.FirstName = "Mark";
            e1.LastName = "Long";
            e1.Seniority = 5;

            string p = e1.Promote();
            MessageBox.Show(p);

            Employee e2 = new Employee();
            e2.FirstName = "Jessica";
            e2.LastName = "Fields";
            e2.Seniority = 7;

            string ar = e2.AnnualReview();
            MessageBox.Show(ar);
        }

        public class Employee
        {
           public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Seniority { get; set; }
        
            public string Promote()
            {
                return "Employee has been promoted!";
            }

            public string AnnualReview()
            {
                return "Annual review completed";
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
                Car c = new Car();
            c.hp = 340;

            Car d = new Car();
            d.hp = 340;

            Car f = d;
            f.hp = 100;
            string Cond = f.CM();

            MessageBox.Show(Cond);
        }

        public class Car
        {
           public int hp;

            public string CM()
            {
                return "Condtions met!";
            }
        }
    }
}
