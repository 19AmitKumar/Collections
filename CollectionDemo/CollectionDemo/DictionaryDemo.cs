using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class DictionaryDemo
    {
        //dictionary have contain key value pair data
        //key may be duplicate but value can be duplicate
        public void Dict() 
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "China");
            dict.Add(2, "India");
            dict.Add(3, "Nepal");
            dict.Add(5, "Bhutan");
            dict.Add(6, "India");
            dict[3] = "Srilanka";
            
            for (int i = 0; i < dict.Count; i++)
            {
                var item=dict.ElementAt(i);
                Console.WriteLine(item.Key+" "+item.Value);
            }
            //foreach(var data in dict) 
            //{
            //    Console.WriteLine(data.Key+" "+data.Value);

            //}
            Console.WriteLine("==========================");
            //Dictionary<string,long> di=new Dictionary<string,long>();
            //di.Add("China", 1000000000);
            //di.Add("Bharat", 150000000);
            //di.Add("Nepal", 50000);
            //di.Add("Bhutan", 100000);
            //for (int i = 0;i < di.Count; i++)
            //{
            //    var varible=di.ElementAt(i);
            //    Console.WriteLine(varible.Key+" "+varible.Value);
            //}
            Dictionary<double,int> keyValue=new Dictionary<double,int>();
            keyValue.Add(1.0, 50000);
            keyValue.Add(2.0, 100000);
            keyValue.Add(3.0, 20000);
            keyValue.Add(4.0, 30000);
            keyValue.Add(5.0, 25000);
            for (int i = 0;i < keyValue.Count;i++)
            {
                var varible=keyValue.ElementAt(i);
                Console.WriteLine(varible.Key+" "+varible.Value);
            }

        }
    }
}
