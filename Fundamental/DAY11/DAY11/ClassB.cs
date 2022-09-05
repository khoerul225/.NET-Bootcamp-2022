using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestKm
{
    internal class ClassB : ClassA
    {
        private string b;

        public ClassB()
        {
        }

        public string B { get => b; set => b = value; }

        public void doB()
        {
            Console.WriteLine($"B Says : {this.b}");
        }
    }
}