using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes__interfaces_etc
{
    abstract class Bake
    {
        public int Temperature { get; set; }

        protected void Heat()
        {
            Console.WriteLine("It is working");
        }

        public abstract void On();
        public abstract void Off();

    }

    class GasBake : Bake
    {
        public override void Off()
        {
            Console.WriteLine("Gas Bake is off");
        }

        public override void On()
        {
            Console.WriteLine("Gas Bake is on");
            Heat();
        }
    }

    class ElectricBake : Bake
    {
        public override void Off()
        {
            Console.WriteLine("Electric Bake is off");
        }

        public override void On()
        {
            Console.WriteLine("Electric Bake is on");
        }
    }

    class Program
    {
        static void On(Bake bake)
        {
            Console.WriteLine(bake.Temperature);
            bake.On();
        }

        static void Off(Bake bake)
        {
            Console.WriteLine(bake.Temperature);
            bake.Off();
        }

        static void Main(string[] args)
        {
            Bake elbake = new ElectricBake();
            Bake gasbake = new GasBake();
            elbake.Temperature = 150;
            gasbake.Temperature = 190;

            On(elbake);
            Off(elbake);
        }
    }
}
