using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Countingarrelements
    {
        public void Countingarray(int[] arr1)
        {
           
            bool[] check = new bool[arr1.Length];
            int count;
            int j;            

            Array.Sort(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                if (check[i] == true)
                {
                    continue;
                }

                count = 1;
                for (j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        count++;
                        check[j] = true;
                    }
                    
                }
                Console.WriteLine(arr1[i] + "reapeated" + count + "times");
            }

        }
    }
}



       