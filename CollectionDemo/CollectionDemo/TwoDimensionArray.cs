using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class TwoDimensionArray
    {
        public void TwoDimension()
        {
            int[,] arr = { { 1, 2, 3, 4, 5 }, { 2, 3, 4, 5, 10 } };
            Console.WriteLine(arr[1, 4]);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine("{0}", arr[i,j]);
                }
            }
        }
    }
}
