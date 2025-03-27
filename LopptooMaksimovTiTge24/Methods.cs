using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopptooMaksimovTiTge24
{
    class Methods
    {
        public static void CountAdnSum()
        {
            var count = Andmed.Numbrid.Count();
            var sum = Andmed.Numbrid.Sum();

            Console.WriteLine("=========================");

            Console.WriteLine("Numbers count = " + count);
            Console.WriteLine("Numers sum = " + sum);
        }
    }
}
