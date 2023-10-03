using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your choice: ");
                int Choice=Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                        case 0:
                        flag = false;
                        break;
                        case 1:
                        ListDemo listDemo = new ListDemo();
                        listDemo.List();
                        break;
                        case 2:
                        ArrayDemo arrayDemo = new ArrayDemo();
                        arrayDemo.AddElement();
                        break;
                        case 3:
                        TwoDimensionArray two=new TwoDimensionArray();
                        two.TwoDimension();
                        break;
                        case 4:
                        ArrayLists array=new ArrayLists();
                        array.ArrayListDemo();
                        break; 
                        case 5:
                        DictionaryDemo dictionaryDemo = new DictionaryDemo();
                        dictionaryDemo.Dict();
                        break;

                }
            }
            


            Console.ReadLine();
        }
    }
}
