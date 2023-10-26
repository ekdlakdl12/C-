using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A066_MemberVariable
{
    //클래스형과 함수형의 가장 큰 차이점은 위의 소스와 같이 동일한 함수를 다른 변수명으로 여러번 호출해야 하는 경우가 생긴다면
    //클래스형은 함수한번으로 여러번 호출가능하지만 함수형은 호출시마다 함수를 계속 새로 호출해주어야 한다는 단점이 있습니다.

    internal class Program
    {

        class Product
        {
            public string name;
            public int price;
        }

        class math
        {
            public static double PI = 3.14;
        }

        class MyCalendar //const 상수
        {
            public const int months = 12;
            public const int weeks = 52;
            public const int days = 365;

            public const double daysPerWeek = (double)days / (double)weeks; // 평균
            public const double daysPerMonth = (double)days / (double)months;
        }

        class MemberVariables
        {

            static void Main(string[] args)
            {
                Product p = new Product();
                p.name = "시계";
                p.price = 100000;

                Console.WriteLine("{0} : {1:C}",p.name,p.price); //{1:C} 통화포멧C로 출력한것
                Console.WriteLine("원주율: {0}", Math.PI);
                Console.WriteLine("한 달은 평균 {0:F3}일", MyCalendar.daysPerWeek);

            }
        }
    }
}