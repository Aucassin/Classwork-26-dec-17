using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra
{
    static class A
    {
        public static int a = 15;
        public static void Move(int x, int y)
        {
            Console.WriteLine(x*y);
        }
    }
    class B
    {
        public static int a;
    }
    class Program
    {
        static void Main(string[] args)
        {
            A.Move(15, 10);
            Console.WriteLine(A.a);
            B b = new Extra.B();
            B.a = 100;
            Console.WriteLine(B.a);
            B.a = 101;
            Console.WriteLine(B.a);

        }
    }
}
