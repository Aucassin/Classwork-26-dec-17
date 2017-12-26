using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_26_dec_17
{
    class Numbers
    {
        public int[] arrayofnumbers = new int[50];
        public double sum = 0;
        public double averagenumber
        {
            get
            {
                foreach (var item in arrayofnumbers)
                {
                    sum += item;
                }

                return sum / arrayofnumbers.Length;
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                Random rand = new Random();
                Numbers newnumbers = new Numbers();
                for (int i = 0; i < newnumbers.arrayofnumbers.Length; i++)
                {
                    newnumbers.arrayofnumbers[i] = rand.Next(0, 100);
                }
                Console.WriteLine(newnumbers.averagenumber);
            }
        }
    }
}
