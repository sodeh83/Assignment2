using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        private static int K;

        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 2, 4, 5, 3, 1, 1, 5 };
            Countingarrelements countelement = new Countingarrelements();
            countelement.Countingarray(arr1);
            Console.ReadKey();

        }

    }
}
