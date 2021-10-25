using System;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, x, y, z, c, ans;
            Console.WriteLine("Введите четырехзначное число:");
            num= int.Parse(Console.ReadLine());
            if (num <1000 ^ num > 9999)
            {
                do
                {
                    Console.WriteLine("Число не четырехзначное, попытка номер два");
                    num = int.Parse(Console.ReadLine());
                } while (num < 1000 ^ num > 9999);
            }
            {
                x = num / 1000;
                y = (num - (x * 1000)) / 100;
                z = (num - (x * 1000) - (y * 100)) / 10;
                c = (num - (x * 1000)) - (y * 100) - (z * 10);
                ans = x * y * z * c;
                Console.WriteLine($"Произведение цифр введенного четырехзначного числа:{ans}");
            }
        }
    }
}

