using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A026_SplitMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("더하고자 하는 숫자들을 입력하세요"); 
            string s = Console.ReadLine(); //문자열로 숫자입력
            Console.WriteLine(s); //입력이 잘됫는지 확인

            int sum = 0; //더한값을 저장할 변수
            string[] v = s.Split(); //스플릿시켜서 따로따로 숫자를 배열에 저장

            foreach(var i in v) // 배열에 값이 없을때까지 반복
            {
                sum += int.Parse(i); // 문자열을 int로 형변환 시키는 코드

            }
            Console.WriteLine("결과는 {0}",sum); //저장된 값 출력
        }
    }
}
