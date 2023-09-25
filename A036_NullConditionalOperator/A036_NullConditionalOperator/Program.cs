using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A036_NullConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = null;

            Console.WriteLine("4글자 이상인 동물의 이름만 출력합니다");
            do 
            {
                LongNameAnimal(animal); 
                Console.Write("동물 이름: "); //선처리 후반복

            }while((animal = Console.ReadLine()) != ""); //값이 없으면 종료됨
        }
            private static void LongNameAnimal(string animal)
            {
            if (animal?.Length >= 4) //Null값 오류 안뜨게끔 새로생긴거
                Console.WriteLine(animal + " : " + animal.Length);
            }
    }
}
