using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class ListDemo
    {
        public void List()
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.WriteLine();
            //List<string> lis = new List<string>();
            //lis.Add("Amit");
            //lis.Add("Jaswant");
            //lis.Add("Manoj");
            //lis.Add("Sudheer");
            //for (int i = 0;i < lis.Count; i++)
            //{
            //    Console.WriteLine(lis[i]);
            //}
            //List<bool> li = new List<bool>();
            //li.Add(false);
            //li.Add(true);
            //li.Add(true);
            //li.Add(false);
            //for (int i = 0; i < li.Count; i++)
            //{
            //    Console.WriteLine(li[i]);
            //}
            Console.WriteLine();
            List<double> lii = new List<double>();
            lii.Add(10.5);
            lii.Add(9.5);
            lii.Add(3.2);
            lii.Add(4);
            lii.Add(5);
            for (int i = 0; i < lii.Count; i++)
            {
                Console.WriteLine(lii[i]);
            }
            Console.WriteLine("-------------");
            //lii.Remove(9.5);
            //lii.Remove(3.2);
            //lii.RemoveAt(0);
            //lii.Reverse();
            //lii.RemoveRange(1,3);
            Console.WriteLine("Count of element is: "+lii.Count);
            Console.WriteLine(lii.Capacity);
            foreach (var item in lii)
            {
                Console.WriteLine(item);
            }


        }
    }
}
