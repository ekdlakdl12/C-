using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A105_IComparer
{
    //내림차순
    public class ReverseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;

            return string.Compare(s2,s1);
        }
    }

    public class Program
    {   
        static void Main(string[] args)
        {
            string[] animalsEn = { "dog","cow","rabbit","goat","sheep","mouse","horse","deer"};
            string[] animalsko = { "개", "소", "토끼", "염소", "양", "쥐", "말", "사슴" };

            Display("초기 배열",animalsEn);
            Array.Sort(animalsEn);
            Array.Reverse(animalsEn);
            Display("Sort()후 Reverse()", animalsEn);

            Display("초기 배열", animalsko);
            Array.Sort(animalsko,2,3);
            Display("[2]에서 3개 정렬후", animalsko);

            IComparer revComparer = new ReverseComparer(); //비교 클래스 호출

            Array.Sort(animalsko,revComparer);
            Display("내림차순 정렬", animalsko);


        }

        private static void Display(string comment, string[] arr)
        {
            Console.WriteLine(comment);
            for(int i = arr.GetLowerBound(0);  i <= arr.GetUpperBound(0); i++) //GetUpperBound 인수는 배열의 차원
            {
                Console.WriteLine("  {0}", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
