using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace A065_ClassAndStruct
{
    struct DateStruct
    {
        public int year, month, day; 
    }

    struct DateClass
    {
        public int year, month, day;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DateStruct sDay; //sday.Struct
            sDay.year = 2023;
            sDay.month = 10;
            sDay.day = 24;
            Console.WriteLine("sDay: {0}/{1}/{2}", sDay.year, sDay.month, sDay.day);
           
            DateClass cDay = new DateClass(); // cDay.class
            cDay.year = 2023;
            cDay.month = 10;
            cDay.day = 24;
            Console.WriteLine("cDay: {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);

            DateStruct sDay2 = new DateStruct(); //sDay2.Struct
            Console.WriteLine("sDay2: {0}/{1}/{2}", sDay2.year, sDay2.month, sDay2.day);
            
            DateClass cDay2 = new DateClass(); //cDay2.class
            Console.WriteLine("cDay2: {0}/{1}/{2}", cDay2.year, cDay2.month, cDay2.day);

            DateStruct s = sDay;
            DateClass c = cDay;

            s.year = 2000;
            c.year = 2000;

            Console.WriteLine("s: {0}/{1}/{2}", s.year,s.month,s.day);
            Console.WriteLine("c: {0}/{1}/{2}", c.year, c.month, c.day);
            Console.WriteLine("sDay: {0}/{1}/{2}", sDay.year, sDay.month, sDay.day);
            Console.WriteLine("cDay: {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);

            private // 캡슐화 더 좁고 객체 또는 스태틱 클래스로 선언할때 자기 자기자신참조 외부참조안되고 
            protected // 더넓다 // 상속받은것 까지 포함
        }
    }
}
