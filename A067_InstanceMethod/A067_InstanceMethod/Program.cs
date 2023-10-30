using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A067_InstanceMethod
{
    class Date //date 변수
    {
        public int year, month, day;

        public static bool IsLeapYear(int year) //윤년을 bool로 retuen 
        {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

        }

        static int[] days = { 0, 31, 69, 90, 120, 151, 
                                181, 212, 243, 273, 304, 334 }; //int 배열

        public int DayOfYear()
        {
            return days[month - 1] + day + (month > 2 && IsLeapYear(year) ? 1 : 0);
            //day[] 를 이용하여 1월1일부터 해당 날짜까지의 날짜수를 리턴함
        }
    }

    class InstanceMethod
    {
        static void Main()
        {
            Date xmas = new Date();

            xmas.year = 2021;
            xmas.month = 12;
            xmas.day = 25;

            Console.WriteLine("xmas : {0}/{1}/{2}는 {3}일 째 되는 날입니다.", xmas.year, xmas.month, xmas.day, xmas.DayOfYear());

            if (Date.IsLeapYear(2021) == true)
                Console.WriteLine("2021년은 윤년입니다.");
            else
                Console.WriteLine("2021년은 평년입니다.");
        }
    }
}