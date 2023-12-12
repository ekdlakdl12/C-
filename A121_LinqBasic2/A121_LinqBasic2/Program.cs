using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A121_LinqBasic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 89, 456, 1, 4, 74, 46 };

            Print("data:", data);

            var IstEven = from item in data
                          where (item > 20 && item % 2 == 0)
                          orderby item descending
                          select item;
            Print("20보다 크면서 2로 나눠지는 수를 내림차순으로 정렬: ", IstEven);

            var IstSorted = from item in IstEven
                            orderby item ascending
                            select item * 2;

            Print("2를 곱해서 오름차순 정렬: ", IstSorted);
                           
        }

        private static void Print(string s, IEnumerable<int> data) 
        {
            Console.WriteLine(s);
            foreach(var i in data)
                Console.WriteLine(" " + i);
            Console.WriteLine();
        }

    }
}
