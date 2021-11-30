using System;
using System.Collections.Generic;

namespace UsingList {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Gabriel");
            list.Add("Rafael");
            list.Add("Glauber");
            list.Add("Samuel");
            list.Insert(4, "Alex");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'G');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'G');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'G');
            Console.WriteLine("First Position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'G');
            Console.WriteLine("Last Position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 7);
            Console.WriteLine("----------------------");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2,2);
            Console.WriteLine("----------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.Remove("Glauber");
            Console.WriteLine("----------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'S');
            Console.WriteLine("----------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);
            Console.WriteLine("----------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
