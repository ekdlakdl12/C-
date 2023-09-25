using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A035_PassingArrayAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 };
            Console.WriteLine("Main() before: arr[0] = {0} ", arr[0]);
            Change(arr); //원래값이 10이지만 Change 메소드에서 -10이 출력됨
            Console.WriteLine("Main() after: arr[0] = {0} ", arr[0]);

            Student s1 = new Student();
            s1.name = "Alpha";
            Console.WriteLine("Main() before : arr[0] = {0}", s1.name);
            Change(s1); //원래 문자열이 알파였지만 change 메소드에서 베타가 출력
            Console.WriteLine("Main() after : arr[0] = {0}", s1.name);

        }

        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }

        private static void Change(Student s1)
        {
            s1.name = "Beta";

        }

        class Student
        {
            public string name;
        }
    }
}