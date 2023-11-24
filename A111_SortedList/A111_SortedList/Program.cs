using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SortedList 키의 오름차순으로 키-값 쌍을 저장함
//제네릭이 아닌 타입은 지정하지 않음
//스트링빌더
//어레이리스트,딕셔너리,소티드리스트,리스트

namespace A111_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> s1 = new SortedList<int, string>();

            s1.Add(3, "Three");
            s1.Add(4, "Four");
            s1.Add(1, "One");
            s1.Add(2, "Two");

            for (int i = 0; i < s1.Count; i++)
                Console.Write("k: {0}, v: {1} /", s1.Keys[i], s1.Values[i]);
            Console.WriteLine();

            foreach(var kvp in s1)
                Console.Write("{0, -10}", kvp);
            Console.WriteLine();

            SortedList<string, int> s2 = new SortedList<string, int>();

            s2.Add("One",1);
            s2.Add("Two",2);
            s2.Add("Three",3);
            s2.Add("Four",4);

            Console.WriteLine(s2["Two"]);

            foreach (var kvp in s2)
                Console.WriteLine("{0, -10}",kvp);
            Console.WriteLine();

            int val;
            if (s2.TryGetValue("ten", out val))
                Console.WriteLine("key: ten, value: {0}", val);
            else
                Console.WriteLine("[ten]: key is not valid");

            if (s2.TryGetValue("one", out val))
                Console.WriteLine("key: one, value: {0}", val);

            Console.WriteLine(s2.Contains("One")); //return True
            Console.WriteLine(s2.ContainsKey("ten"));
            Console.WriteLine(s2.ContainsKey(2));
            Console.WriteLine(s2.ContainsKey(6));

            s2.Remove("one");
            s2.Remove(0);

            foreach (KeyValuePair<string,int> kvp in s2)
                Console.WriteLine("{0, -10}", kvp);
            Console.WriteLine();

        }
    }
}
