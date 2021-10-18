using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {        
            Console.WriteLine("Введите число:");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = (int)num1;
            num2 = (num1 - num2)*10;
            num2 = (int)num2;
            Console.WriteLine($"Первая цифра после запятой: {num2}");
        }
    }
}
