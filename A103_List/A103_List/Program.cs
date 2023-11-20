using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A103_List
//크기가 가변이고 제네렉이여서 어떠한 자료형도 넣을수있음

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Random r = new Random();

            PrintValues(a);

            for(int i =0; i < 10; i++)
                a.Add(r.Next(100));

            PrintValues(a);
            a.Sort();
            PrintValues(a);

            //3번째 값을 제거
            a.RemoveAt(3);
            PrintValues(a);

        }

        private static void PrintValues(List<int> a)
        {
            Console.WriteLine("Print Values in List<int>");
            Console.WriteLine("Count : {0}",a.Count);
            Console.WriteLine("Capacity : {0}", a.Capacity);
        
            foreach (var i in a)
                Console.WriteLine("  {0}", i);
            Console.WriteLine();
        }

    }
}
