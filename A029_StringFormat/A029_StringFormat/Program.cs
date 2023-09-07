using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//날짜와 시간형식 지정
//StringFormat은 수식의 값을 문자열로 변환하여 다른 문자열에 삽입함

namespace A029_StringFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string max = string.Format("0x{0:X} {0:E} {0:N}", Int64.MaxValue); //16진수형 지수형 구분자가 있는 숫자형으로 변환
            Console.WriteLine(max);

            Decimal exchangeRate = 1129.20m; //Decimal 10진수

            string s = String.Format("현재 원달러 환율은 {0} 입니다.",exchangeRate);
            Console.WriteLine(s);

            s = String.Format("현재 원달러 환율은 {0:C2}입니다.", exchangeRate); //C는 통화형식으로 화폐단위인 원을 표시하며 기호와 3자리마다 콤마를 넣어줌
            Console.WriteLine(s);

            s = String.Format("오늘 날짜는 {0:d}, 시간은 {0:t}입니다.", DateTime.Now); //d는 day t는 time

            TimeSpan duration = new TimeSpan(1, 12, 23, 62);
            string output = String.Format("소요시간: {0:c}", duration);
            Console.WriteLine(output);


        }
    }
}
