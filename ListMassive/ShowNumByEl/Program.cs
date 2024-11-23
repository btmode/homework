using System;

namespace ShowNumByEl
{
    internal class Program
    {
        public static void ShowSortElNum(List<int> list, int num)
        {

            while (num > 0)
            {
                list.Add(num % 10);
                num = num / 10;

            }
            list.Sort();
            Console.WriteLine(string.Join(", ", list));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var num = int.Parse(Console.ReadLine());

            var list = new List<int>();

            ShowSortElNum(list, num);

            
        }
    }
}
