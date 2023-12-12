using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A122_LinqToList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> IstData = new List<int> { 123, 456, 132, 96, 13, 465, 321 };
            Print("Data: ", IstData);

            List<int> IstOdd = new List<int>();

            IstOdd = SelectOddAndSort(IstData);
            Print("Orderby Odd: ", IstOdd);

            int[] arrEven;
            arrEven = SelectEvenAndSort(IstData);
            Print("Orderby Even: ", arrEven);
        }

        private static List<int> SelectOddAndSort(List<int> IstData) 
        {
            return (from item in IstData
                    where item % 2 == 1
                    orderby item
                    select item).ToList<int>();
        }


        private static int[] SelectEvenAndSort(List<int> IstData) 
        {
            return (from item in IstData
                    where item % 2 ==0
                    orderby item
                    select item).ToArray<int>();
        }
        
        private static void Print(string s , IEnumerable<int> data) 
        {
            Console.WriteLine(s);
            foreach (var i in data)
                Console.WriteLine(" " + i);
            Console.WriteLine();
        }

    }
}
