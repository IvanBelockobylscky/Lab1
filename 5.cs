using System;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первого катета");
            double Katet1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета");
            double Katet2 = double.Parse(Console.ReadLine());

            double Hypo = Math.Sqrt((Katet1 * Katet1) + (Katet2 * Katet2));
            double P = Katet1 + Katet2 + Hypo;
            double S = 1/2 * (Katet1 * Katet2);
            Console.WriteLine($"Периметр = {P}, Площадь = {S}");
        }
    }
}
