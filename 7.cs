using System;

namespace Zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите трёхзначное число");
            a = int.Parse(Console.ReadLine());
            if (a > 999 ^ a < 100)
            {
                do
                {
                    Console.WriteLine("Число не трёхзначное, попытка номер два");
                    a = int.Parse(Console.ReadLine());
                } while (a > 999 ^ a < 100);
            }
            {
                string b = a.ToString();
                char[] bReverse = b.ToCharArray();
                Array.Reverse(bReverse);
                b = new string(bReverse);
                Console.WriteLine(b);
            }
        }
    }
}