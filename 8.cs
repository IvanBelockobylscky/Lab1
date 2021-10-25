using System;

namespace zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, ans;
            Console.WriteLine("Введите значение a");
            a = double.Parse(Console.ReadLine());
            ans = (((3 * a - 5) * a + 2) * a - 1) * a + 7;
            Console.WriteLine($"Ответ: {ans}");
        }
    }
}