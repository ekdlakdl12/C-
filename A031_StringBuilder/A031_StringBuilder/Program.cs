using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Capacity: stringBuilder 객체에 할당된 메모리가 허용하는최대 문자수를 가져오거나 설정합니다
//Length 길이 가져옴

namespace A031_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is a StringBuilder Test."); //StringBuilder를 사용하기위한 객체 생성
            Console.WriteLine("{0} ({1} characters)", sb.ToString(),sb.Length);

            sb.Clear(); //객체 전부삭제
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Append("This New String"); //객체의 끝에 문자열 추가
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Insert(5, "xyz", 2); //특정위치에 문자열 추가
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Remove(5,4); //특정위치에 있는 문자열 제게
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            sb.Replace("xyz","abc"); //특정위치에 있는 문자열 대체
            Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

            Stopwatch time = new Stopwatch(); //17초 걸림
            string test = string.Empty; //
            time.Start();

            for (int i = 0; i < 100000; i++)
            {
                test += i;
            }
            time.Stop();

            Console.WriteLine("String: " + time.ElapsedMilliseconds + "ms");

            StringBuilder test1 = new StringBuilder(); //12초걸림 이게 더 효율적임
            time.Reset();
            time.Start();

            for (int i = 0; i < 100000; i = 0)
            {
                test1.Append(i);
            }

            time.Stop();
            Console.WriteLine("StringBuilder:" + time.ElapsedMilliseconds + "ms");
        }
    }
}
