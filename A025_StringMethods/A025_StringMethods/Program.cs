using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A025_StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello world!!";
            string t;

            Console.WriteLine(s.Length); //길이
            Console.WriteLine(s[8]); //8번째 값

            Console.WriteLine(s.Insert(8, "C#")); // 8번째에 C# 문자를 넣음
            Console.WriteLine(s.PadLeft(20, '.')); //지정한 문자를 넣어서 길이를 맞춤

            Console.WriteLine(s.PadRight(20, '.'));
            Console.WriteLine(s.Remove(6)); //6번째 배열부터 다지워짐
            Console.WriteLine(s.Remove(6,7)); //6번째 배열부터 뒤로 7개 지워짐

            Console.WriteLine(s.Replace('l','m')); //배열안에 들어있는 l문자를 모두 m으로 바꿈
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s.ToUpper());

            Console.WriteLine('/' + s.Trim() + '/'); //공백문자를 전부없앰
            Console.WriteLine('/' + s.TrimStart() + '/'); //앞 공백문자를 없앰
            Console.WriteLine('/' + s.TrimEnd() + '/'); //뒤 공백문자를 없앰

            string[] a = s.Split(',');
            
            foreach(var i in a) // == python for i in x:
            {
                Console.WriteLine('/' + i + '/');
            }
            
            char[] destination = new char[10];
            s.CopyTo(8, destination, 0, 6); // s의 8번째 값부터 데스티네이션 변수의 0~6 배열에 복사함
            Console.WriteLine(destination);

            Console.WriteLine('/' + s.Substring(8) + '/'); // a까지 값 리턴
            Console.WriteLine('/' + s.Substring(8 , 5) + '/'); // A~ B 까지 값리턴

            Console.WriteLine(s.Contains("ll"));
            Console.WriteLine(s.IndexOf('o'));

            Console.WriteLine(s.LastIndexOf('o'));
            Console.WriteLine(s.CompareTo("abc"));

            Console.WriteLine(String.Concat("Hi~",s)); // 두개의 String값을 합쳐줌
            Console.WriteLine(String.Compare("abc",s)); //compareto랑다름 

            Console.WriteLine(t = String.Copy(s));

            String[] val = { "apple", "orange", "grape", "pear" };
            String result = String.Join(",", val); //String값에 ,로 분류
            Console.WriteLine(result);





        }
    }
}
