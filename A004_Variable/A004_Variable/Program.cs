﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A004_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름을 입력하세요");
            string name = Console.ReadLine();

            Console.Write("나이를 입력하세요");
            int age = int.Parse(Console.ReadLine()); //입력된값을 int로 변환   
            
            Console.Write("키를 입력하세요");
            float height = float.Parse(Console.ReadLine());

            Console.Write("안녕하세요");
            Console.Write(name);
            Console.WriteLine("님");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.Write("세, 키는  ");
            Console.Write(height);
            Console.WriteLine("cm군요?!");

            Console.Write("프로그램종료");
        }
    }
}
