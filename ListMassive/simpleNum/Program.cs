using System;
using System.Diagnostics.CodeAnalysis;

namespace simpleNum
{
    internal class Program
    {
        public static bool CheckNum(int num)
        {
            bool check = false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var num = int.Parse(Console.ReadLine());

            if (CheckNum(num))
            {
                Console.Write("Простое");
            }
            else
                Console.Write("Непростое");



        }

    }
}
