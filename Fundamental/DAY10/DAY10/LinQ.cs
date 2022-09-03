using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10
{
    internal class LinQ
    {
        public static void IntroLinQ()
        {
            int[] numbers = new int[] { 98,88,99,88,99,100,98,00,98,97,97,90,88};

            //sum for index 

            var sum = numbers.Sum(x => x++);
            Console.WriteLine($"sum : {sum}");

            var min = numbers.Min();
            Console.WriteLine($"Min : {min}");

            var max = numbers.Max();
            Console.WriteLine($"Max : {max}");

            var duplicatest = numbers.Distinct();
            foreach (var item in duplicatest)
            {
                Console.WriteLine(item);
            }

        }

    }
}
