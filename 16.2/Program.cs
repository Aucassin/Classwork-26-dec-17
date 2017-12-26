using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._2
{
    abstract class Figure
    {
        public abstract void Area();
    }

    class Square : Figure
    {
        int sideA;
        int sideB;

        public override void Area()
        {
            Console.WriteLine(sideA*sideB);
        }
    }

    class Circle : Figure
    {
        int rad;
        public override void Area()
        {
            Console.WriteLine(Math.PI*(Math.Pow(rad, 2)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
