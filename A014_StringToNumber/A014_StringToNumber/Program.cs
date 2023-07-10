using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A014_StringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            Console.Write("1. int로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine(); //문자열 입력
            bool result = Int32.TryParse(input, out value); //입력받은 문자열을 int로 변환하는메소드 변환됬을시 True 실패시 false값을 반환

            if (!result) //변환 판별후 if문으로 출력
            
                Console.WriteLine("'{0}'는 int로 변환될수 없습니다. \n , input");
            else
                Console.WriteLine("int '{0}'는 int로 변환되었습니다. \n , value");
            

            Console.Write("2, double로 변환할 문자열을 입력하세요: ");
            input = Console.ReadLine();

            try
            {
                double m = Double.Parse(input);  //입력받은 문자열을 double로 변환하는메소드 변환됬을시 True 실패시 false값을 반환
                //double m = Convert.ToDouble(input); 
                Console.WriteLine("double '{0}'으로 변환되었습니다. \n, m");

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
