using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A042_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("키를 입력하세요 (cm): ");
            double height = double.Parse(Console.ReadLine());
            
            height = 100; //m단위

            Console.WriteLine("체중을 입력하세요");
            double weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height*height);

            string comment = null;

            if (bmi < 20)
                comment = "저체중";
            else if (bmi < 25)
                comment = "정상체중";
            else if (bmi < 30)
                comment = "경도비만";
            else if (bmi < 40)
                comment = "고도비만";

            Console.WriteLine("BMI={0:F1}, \"{1}\"입니다",bmi,comment);
            //{0:F1} 소숫점 첫째자리 이후 반올림 하라는 뜻
        }
    }
}
