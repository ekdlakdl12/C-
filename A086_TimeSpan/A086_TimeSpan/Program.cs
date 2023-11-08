using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A086_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            TimeSpan inteval = new TimeSpan;
            TimeSpan interval = new TimeSpan(2,14,18) //2시간 14분 18초
             */

            DateTime chrismas = new DateTime(2018, 12, 25);
            DateTime newYearsDay = new DateTime(2019, 1, 1);

            TimeSpan span = newYearsDay - chrismas;
            // TimeSpan span = newYearsDay.Substract(chrismas) <-- 슈트 만재시간 구할때 사용함

            Console.WriteLine("{0,14}", span);
            Console.WriteLine("{0,14} days", span.Days);
            Console.WriteLine("{0,14} hours", span.Hours);
            Console.WriteLine("{0,14} minute", span.Minutes);
            Console.WriteLine("{0,14} seconds", span.Seconds);
            Console.WriteLine("{0,14} miliseconds", span.Milliseconds);


            Console.WriteLine("또는");

            Console.WriteLine("{0,14}", span);
            Console.WriteLine("{0,14} days", span.TotalDays);
            Console.WriteLine("{0,14} hours", span.TotalHours);
            Console.WriteLine("{0,14} minute", span.TotalMinutes);
            Console.WriteLine("{0,14} seconds", span.TotalSeconds);
            Console.WriteLine("{0,14} miliseconds", span.TotalMilliseconds);
            Console.WriteLine("{0,14} ticks", span.Ticks);
        }
    }
}
