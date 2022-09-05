using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestKm
{
    internal class ClassC : ClassB
    {
        private string c;

        public ClassC()
        {
        }

        public string C { get => c; set => c = value; }

        public void doA()
        {
            Console.WriteLine("Who cares what A Says");
        }

        public void doB()
        {
            Console.WriteLine("Who cares what B Says");
        }

        public void doC()
        {
            Console.WriteLine($"C says : {A} {B} {C}");
        }
    }
}