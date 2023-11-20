using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A104_Alphabetical
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> lasNames = new List<string>();
            lasNames.Add("dog");
            lasNames.Add("cow");
            lasNames.Add("rabbit");
            lasNames.Add("goat");
            lasNames.Add("sheep");
            lasNames.Sort();

            foreach(string s in lasNames)
            {
                Console.WriteLine(s + " ");
            Console.WriteLine();
            }

            string[] arrNames = new string[100];
            arrNames[0] = "dog";
            arrNames[1] = "cow";
            arrNames[2] = "rabbit";
            arrNames[3] = "goat";
            arrNames[4] = "sheep";

            Array.Sort(arrNames);
            foreach (string s in arrNames)
            {
                Console.WriteLine(s + " ");
            Console.WriteLine();
            }
        }
    }
}
