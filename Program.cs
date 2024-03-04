using System.Diagnostics.SymbolStore;
using System.Collections.Generic;

namespace ROUGH
{
    class program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "tejas");
            d.Add(2, "gowda");
            d.Add(3, "manohar");
            d.Add(4, "surya");
            //d.Remove(2);                                                                                            //.Add(key,value);
            //.Remove(key);
            Console.WriteLine(d[1]);                                                                                //.ContainKey(key);
            if (d.ContainsKey(2))                                                                                    //.count
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine("absent");
            }
            Console.WriteLine();

            foreach (var val in d)
            {
                Console.WriteLine($"key:{val.Key} value:{val.Value}");
            }

            Console.WriteLine();

            Console.WriteLine($"number of items in the dictionary:{d.Count}");









            HashSet<int> list = new HashSet<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(4);
            list.Add(6);
            list.Remove(2);                                                                     // doen't support duplicate values...only support unique elements

            if (list.Contains(2))
            {
                Console.WriteLine("present");
            }
            else
            {
                Console.WriteLine("absent");
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }



             HashSet<string> names = new HashSet<string> {
                 "Rajeev",
                 "Akash",
                 "Amit",
             };
             foreach (var name in names)
             {
                 Console.WriteLine(name);
             }
             Console.ReadKey();


            HashSet<string> names = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit",
                "tejas"
            };
            HashSet<string> names1 = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit",
                "Deepak",
                "Mohit"
            };
            //names.UnionWith(names1);
            names.IntersectWith(names1);
           // names1.ExceptWith(names);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }

    }



}
