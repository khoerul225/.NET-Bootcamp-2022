using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTestKm
{
    internal class ClassA
    {
        private string a;

        public ClassA()
        {
        }

        public string A { get => a; set => a = value; }

        public void doA()
        {
            Console.WriteLine($"A Says : {this.a}");
        }
    }
}