using System;
namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте значения часа:");
            int hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значения минут:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Задайте значения секунд:");
            int sec= int.Parse(Console.ReadLine());
            int dhour = (hour * 30);//час°
            int dmin = (min * 2); //минута°
            double dsec = (sec * 0.03);// секунда°
            double ans = (dhour + dmin + dsec);
            Console.WriteLine($"Стрелка отклонилась на {ans} градусов");
        }
    }
}
