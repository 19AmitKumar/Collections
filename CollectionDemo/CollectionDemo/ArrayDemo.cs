using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    //It is the collection of homogenous element.
    //It can has fixed size.
    internal class ArrayDemo
    {
        public void AddElement()
        {
            //Decleration of Array
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            int[] arrOne = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arrTwo = new int[] { 1, 2, 3 };
            int[] arrThree = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            string[] stringArr= new string[5];
            stringArr[0] = "Amit";
            string[] stringArrOne = { "one", "Two", "Three" };
            string[] stringArrTwo = new string[] { "four", "five" };
            double[] doubleArr = { 1.2, 1.3, 1.5, 1.3333 };
            double[] doubleArrOne = new double[4] { 1.6, 3.14, 5.2, 2.3 };
            bool[] arrr = { true, false, true, false };
            float[] floatArr = { 10.5f, 2.5f, 3.2f };
            short[] shortArr = { 112, 122, 133, 144 };
            byte[] byteArr = { 0, 1, 2 };
            long[] longArr = { 100000000, 222222222, 33333333 };
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.WriteLine("-----------------------");
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine("----------------");
            //int j=0;
            //while(j<arr.Length)
            //{
            //    Console.WriteLine(arr[j]);
            //    j++;
            //}
            foreach (string i in stringArrOne)
            {
                Console.WriteLine(i);

            }
            for (int i = 0; i < stringArrOne.Length; i++)
            {
                Console.WriteLine(stringArrOne[i]);
            }
            Console.WriteLine("===============");
            for (int i = 0; i < doubleArrOne.Length; i++)
            {
                Console.WriteLine(doubleArrOne[i]);
            }
            foreach (double i in doubleArrOne)
            {
                Console.WriteLine(i);
            }
            for(int i = 0; i < stringArrOne.Length; i++)
            {
                Console.WriteLine(stringArrOne[i]);
            }
            foreach(string i in stringArrOne)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("-------------------------------");
            for(int i = 0; i < arrr.Length; i++)
            {
                Console.WriteLine(arrr[i]);
            }
            foreach(bool b in arrr)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("====================");
            for(int i = 0; i < floatArr.Length; i++)
            {
                Console.WriteLine(floatArr[i]);
            }
            foreach(float f in floatArr)
            {
                Console.WriteLine(f);
            }
        }
    }
}
