﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A015_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("첫번째 숫자를 입력하세요: ");
            x = Convert.ToInt32(Console.ReadLine()); // Int32 변환기
            Console.Write("두번째 숫자를 입력하세요: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            //2진수, 8진수, 10진수, 16진수로 출력하기
            short value = short.MaxValue; //Int16.Maxvalue
            Console.WriteLine("\n2진수, 8진수, 10진수, 16진수로 출력하기");

            int baseNum = 2;
            string s = Convert.ToString(value, baseNum);
            int i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1,2}진수= {2,16}", i, baseNum, s); //{1,2} <-- 1번째값을 2번째 자리수까지 출력이란뜻

            baseNum = 8;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1.2}진수= {2,16}", i, baseNum, s);

            baseNum = 10;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1.2}진수= {2,16}", i, baseNum, s);

            baseNum = 16;
            s = Convert.ToString(value, baseNum);
            i = Convert.ToInt32(s, baseNum);
            Console.WriteLine("i = {0}, {1.2}진수= {2,16}", i, baseNum, s);



        }
    }
}
