using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A106_SortArrayPair
{   

    // Class는 main class 밖에 생성 _내림차순 정렬
    public class ReverseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;

            return Compare(s1, s2);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animalsEn = { "dog", "cow", "rabbit", "goat", "sheep", "mouse", "horse", "deer" };
            string[] animalsko = { "개", "소", "토끼", "염소", "양", "쥐", "말", "사슴" };

            Display("Before Sort",animalsEn, animalsko);

            Array.Sort(animalsEn, animalsko);
            Display("After Sort",animalsEn, animalsko);

            Array.Sort(animalsko, animalsEn);
            Display("After Sort by Korean",animalsEn,animalsko);

            IComparer revCom = new ReverseComparer();
            Array.Sort(animalsEn,animalsko, revCom);
            Display("After Descending Sort",animalsEn,animalsko);


        }

        private static void Display(string cmt, string[] a1, string[] a2)
        {
            Console.WriteLine(cmt);
            for(int i = 0; i< a1.Length;  i++) 
            {
                Console.WriteLine("[{0}]: {1,-8} {2,-8}", i, a1[i], a2[i]); 
            }
            Console.WriteLine();

        }
    }
}
