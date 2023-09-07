using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A027_StringConcat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "bikang";
            string date = DateTime.Today.ToShortDateString();

            string strPlus = "Hello" + "userName" + ".Today is" + "data" + "."; //1 //그냥입력방법
            Console.WriteLine(strPlus);

            string strFormat = string.Format("Hello {0}", "Today is {1}", userName, date);//2 일반적인방법
            Console.WriteLine(strFormat);

            string strInterpolation = $"Hello {userName}. Today is {date}."; //3 $이용
            Console.WriteLine(strInterpolation);

            String strConcat = string.Concat("Hello", userName, ".Today is", date, "."); //4 concat
            Console.WriteLine(strConcat);

            String[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon" }; //5 concat,join으로 배열합치기
            string s = String.Concat(animals);
            Console.WriteLine(s);
            s = string.Join(", ", animals);
            Console.WriteLine(s);

        }
    }
}
