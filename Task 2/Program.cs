using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Calc
    {
        private int first;

        public Calc(int first)
        {
            this.first = first;
        }

        public int MyProperty
        {
            get
            {
                return first;
            }
            private set
            {
                first = value; ;
            }
        }

        public void SetValue(int t)
        {
            MyProperty = t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc(14);
            Console.Write("Set your value:");
            calc.SetValue(int.Parse(Console.ReadLine()));
            Console.WriteLine(calc.MyProperty);
        }
    }
}
