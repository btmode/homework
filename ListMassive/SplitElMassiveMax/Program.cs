﻿using System.Xml;

namespace SplitElMassiveMax
{
    internal class Program
    {
        public static void FillArray(List<int> list, int lenght)
        {
            var rnd = new Random();
            for (int i = 0; i < lenght; i++)
            {
                list.Add(rnd.Next(1, 50));
            }
            Console.Write("Сгенерированный массив: ");
            Console.WriteLine(string.Join(", ", list));
        }
        //g
        public static int FindMaxEl(List<int> list)
        {

            var max = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }

        public static void SplitOnMaxEl(List<int> list, int max)
        {

            var res = new List<double>();
            for (int i = 0; i < list.Count; i++)
            {
                double result = (double)list[i] / max;                
                res.Add(result);
                Math.Round(result, 2);                
            }
            
            Console.WriteLine(string.Join(", ", res));

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину: ");
            var lenght = int.Parse(Console.ReadLine());
            var list = new List<int>(lenght);

            FillArray(list, lenght);

            int max = FindMaxEl(list);
            Console.WriteLine($"Максимальный элемент: {max}");

            SplitOnMaxEl(list, max);



        }
    }
}