using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace A068_Constructor
{
    class Date
    {
        private int year, month, day; //필드는 private를 자주 사용함

        public Date() 
        {
            year = 1;
            month = 1;
            day = 1;
        }
        
        public Date(int y, int m, int d) //자기참조 this 
        {
            year = y;
            month = m;
            day = d;
        }

        public void printDate() //출력메소드
        {
            Console.WriteLine("{0}/{1}/{2}",year,month,day);
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date(1997,12,31); //값 넣기
            Date christmas = new Date(2023,12,25);
            Date firstDay = new Date(); //디폴트값 나옴
            
            birthday.printDate();
            christmas.printDate();
            firstDay.printDate();
        }
    }
}
