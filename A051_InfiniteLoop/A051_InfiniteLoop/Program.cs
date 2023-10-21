using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A051_InfiniteLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {   //변수
            int sum = 0;
            int days = 1;
            int money = 1000;

            //while문 버전
            while(true)
            {
                sum += money;
                Console.WriteLine("{0,2}일치 : {1,8:C}, sum = {2,11:C}",days,money,sum); //날짜 돈 합계 반복하여 출력
              if (sum >= 1000000) //조건부 브레이크
                    break;
                days++; //여기서 날짜 ++
                money *= 2;  //money = moeny * 2
            }
            Console.WriteLine("{0}일치에 {1:###,###}원이 됩니다.", days, sum);

            //for문버전
            for(sum = 0, days = 1,money = 1000; ; days++, money *= 2) // ;; 형태로 for문으로 무한루프를 만듦 
            {
                sum += money;
                Console.WriteLine("{0,2}일차 : {1,8:C},sum = {2,11:C}",days,money,sum);
            
                if (sum >= 10000000)
                    break;
            }
            Console.WriteLine("{0}일차에 {1:###,###}원이 됩니다.", days, sum);      
            }
        }
    }
