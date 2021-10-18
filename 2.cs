using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Введите прошедшее время в секундах:");
            int time = int.Parse(Console.ReadLine());
            int hour = time / 3600;
            int min = ((time - hour * 3600) / 60);
            int sec = time - hour * 3600 - min * 60;
            Console.Clear();
            Console.WriteLine($"{time} секунд = {hour} часов, {min} минут и {sec} секунд");
        }
    }
}
