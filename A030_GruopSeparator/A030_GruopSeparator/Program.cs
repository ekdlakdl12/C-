using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A030_GruopSeparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("표시할 숫자를 입력하세요(종료-1)");
                string s = Console.ReadLine();
                double v = double.Parse(s); //입력받은 숫자를 더블로 컨버트

                if (v == -1)
                    break;
                Console.WriteLine(NumberWithGroupSeparator(s));
            }
        }
        private static string NumberWithGroupSeparator(string s)
        {
            int pos = 0;
            double v = double.Parse(s);

            if (s.Contains("."))
            {
                pos = s.Length - s.IndexOf(".");
                string formatStr = "{0:N" + (pos - 1) + "}"; //0에서 n번째 까지 끊기
                s = string.Format(formatStr, v);
            }
            else
                s = string.Format("{0:N0}", v);
            return s;

        }
    }
}
