using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egysegteszt_SzilagyiIstvanMarcell
{
    public class Rectangle
    {
        public int CalculateArea(int a, int b)
        {
            if (a < 0 || b < 0) throw new ArgumentException("A téglalap oldalai nem lehetnek negatívak!");
            return a * b;
        }

        static void Main(string[] args)
        {
            int a, b;
            ConsoleKey key;
            do
            {
                Console.WriteLine("Add meg a téglalap a oldalát:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Add meg a téglalap b oldalát:");
                b = int.Parse(Console.ReadLine());
                key = Console.ReadKey(true).Key;
            }while (key!=ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
