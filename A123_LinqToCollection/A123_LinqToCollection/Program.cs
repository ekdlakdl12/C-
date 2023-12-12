using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A123_LinqToCollection
{   
    //학생 / 이름 / 아이디 / 점수
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<int> Scores { get; set; }
    }
    
    class Program
    {
        static List<Student> students;

        static void Main(string[] args)
        {
            students = new List<Student>
            {
                new Student { Name="Pjkim", Id=19001001,Scores =new List<int>{ 86,90,76}},
                new Student { Name="BsKim", Id=19001002,Scores =new List<int>{ 56,92,93}},
                new Student { Name="Yscho", Id=19001003,Scores =new List<int>{ 69,85,75}},
                new Student { Name="Bikang", Id=19001004,Scores =new List<int>{ 88,80,57}} };


                Print(students);
                HighScore(0, 85); //첫번째 시험에서 85점 이상인 학생 출력
                HighScore(1, 90); //두번째 시험에서 90점 이상인 학생 출력


        }
        

        private static void HighScore(int exam, int cut) 
        {
            var highScores = from student in students
                             where student.Scores[exam] >= cut
                             select new { Name = student.Name, Score = student.Scores[exam] };
        }


        private static void Print(List<Student> students) 
        {
            foreach(var item in students) 
            {
                Console.Write($"{item.Id,-10}{item.Name, -10}");

                foreach (var score in item.Scores)
                    Console.Write($"{score,-5}");
                Console.WriteLine(item.Scores.Average().ToString("F2"));
            }
        
        }

    }
}
