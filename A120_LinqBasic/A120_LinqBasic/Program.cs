using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Linq는 람다와 함깨 같이 도입됨
//Language Integrated Query의 약자로 데이터 질의 기능임
//데이터를 다루는 방법이 훨신 간단해짐

//Linq를 사용하려면 데이터가 IEnumerable이나 IEnumerable<T> 인터페이스를 상속하는 형식이어야함
//List<GameObject> gameObjects = new List<GameObject>(); <-- 열거자 형식을 의미

namespace A120_LinqBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 123, 45, 12, 89, 456, 1, 4, 74, 46 };
            List<int> lstSortedEven = new List<int>();

            foreach (var item in data) 
            {
                if(item % 2 == 0)
                    lstSortedEven.Add(item);
            }
            lstSortedEven.Sort();

            Console.WriteLine("Using foreach: ");
            foreach (var item in lstSortedEven)
                Console.WriteLine(item + " ");
            Console.WriteLine();
//----------------------------------------------------------------------------------------------

            //Linq
            var SortedEven = from item in data
                             where item % 2 == 0
                             orderby item
                             select item;
            Console.WriteLine("\nUsing Linq: ");

            foreach (var item in SortedEven) 
                Console.WriteLine(item + " ");
            Console.WriteLine();

        }
    }
}
