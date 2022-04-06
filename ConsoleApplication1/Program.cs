using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Numbers numbers = new Numbers();

            Console.WriteLine("Angka Minimum #1: {0}", numbers.FindMinimum(3,1));
            Console.WriteLine("Angka Minimum #2: {0}", numbers.FindMinimum(3, 2, 4));
            Console.WriteLine(); //baris kosong
            Console.WriteLine("Angka Maximum #1: {0}", numbers.FindMaximum(3, 1));
            Console.WriteLine("Angka Maximum #2: {0}", numbers.FindMaximum(3, 2, 4));

            Console.ReadKey();
        }
    }
}
