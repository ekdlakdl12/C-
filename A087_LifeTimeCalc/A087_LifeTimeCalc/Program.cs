using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TimeSpan을 이용한 생에 계산기

namespace A087_LifeTimeCalc
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("생년월일과 시분초를 입력하세요");
            //입력한시간과 현재시간을 뺌
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Now;

            TimeSpan interval = date2 - date1;
            Console.WriteLine("탄생시간 : {0} ",date1);
            Console.WriteLine("현재시간 : {0} ", date2);
            Console.WriteLine("생존시간 : {0}", interval.ToString()); //시간 간격
            Console.WriteLine("당신은 지금 이순간까지 {0}일 {1}시간" + "{2}분 {3}초를 살았습니다"
                ,interval.Days,interval.Hours,interval.Minutes,interval.Seconds);
            
        }
    }
}
