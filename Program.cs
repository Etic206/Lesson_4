using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    internal class Program
    {
        static void PrintMe<T>(T x)
        {
            x.ToString();
        }

        static void Main(string[] args)
        {
            string Hey = "Welcome";
            Console.WriteLine(Hey);
            int num = 2024;
            Console.WriteLine(num);
            double num2 = 125.32;
            Console.WriteLine(num2 + num);
            bool smile = true;
            Console.WriteLine(smile);

            List<int> listNums = new List<int>() { 1, 2, 3, 4, 5 };

            SwapList<int> listSwap = new SwapList<int>();
            listSwap.Add(68);
            listSwap.Add(71);
            listSwap.Add(98);

            Console.WriteLine("1" + " " + listSwap[0] + " " + "2" + " " + listSwap[1] + " " + "3" + " " + listSwap[2]);
            listSwap.Swap(1, 2);
            Console.WriteLine("1" + " " + listSwap[0] + " " + "2" + " " + listSwap[1] + " " + "3" + " " + listSwap[2]);



            Console.ReadLine();

            Console.Read();
        }
    }
}
