using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Sn(double x, int i = 6)
            {
                if (i < 0)
                {
                    return 1 / x;
                }
                else
                {
                    return i / Pow(x, i) + Sn(x, --i);
                }
            }

            Console.Write("Введите число(x) ");
            double X = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ответ: {Sn(X):f3}");
        }
    }
}
