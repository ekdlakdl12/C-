using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//생각보다 실행속도가 빠름

//List<T>와 Predicate<T> 콜라보
//Predicate는 결과값을 bool값으로 반환함

//List<T>.Exists(Predicate<T>) = 조건에 요소가 있는지
//List<T>.Find(Predicate<T>) = 조건에 맞는 첫번째 요소 리턴
//List<T>.FindAll(Predicate<T>) = 조건에 맞는 요소 모두 리턴
//List<T>.FindLast(Predicate<T>) = 조건에 맞는 마지막 요소 리턴
//List<T>.RemoveAll(Predicate<T>) = 조건에 맞는 요소를 모두 제거
//List<T>.TrueForAll(Predicate<T>) = 모든요소가 조건에 맞는지 

namespace A119_ListAndLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>
            {
                "mouse","cow","tiger","rabbit","dragon","snake"
            };

            bool n = myList.Exists(s => s.Contains("x"));
            Console.WriteLine("이름에 'x'를 포함하는 동물이 있나요 :" + n);
            

            Console.WriteLine("이름이 3글자인 첫 번째 동물: ");
            string name = myList.Find(s => s.Length == 3);
            Console.WriteLine(name);

            Console.WriteLine("이름이 6글자 이상인 동물들: ");
            //다중값이라 list에 집어넣음
            List<string> longName = myList.FindAll(s => s.Length > 5);
            
            foreach(var item in longName) 
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Console.Write("대문자로 변환");
            List<string> capList = myList.ConvertAll(s => s.ToUpper());
            foreach (var item in capList)
                Console.Write(item + " ");
            Console.WriteLine();
            
        }
    }
}
