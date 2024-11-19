using System.Timers;

namespace FindPositiveAndNegative
{
    internal class Program
    {
        static void FillArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
        }
        static void PrintArray(int[] array)
        {
            foreach (int el in array)
            {
                Console.Write(el+" ");
            }
            Console.WriteLine();
        }
        static (int[] positives, int[] negatives) FindDifference(int[] array)
        {
            int positiveCount = 0, negativeCount = 0;
            foreach (int i in array)
            {
                if (i > 0)
                {
                    positiveCount++;
                }
                else if (i < 0)
                {
                    negativeCount++;
                }
            }
        

            
            int[] positives = new int[positiveCount];
            int[] negatives = new int[negativeCount];

            int posIndex = 0, negIndex = 0;
            

            foreach(int el in array)
            {
                if (el>0)
                {
                    positives[posIndex++] = el;

                }
                if (el<0)
                {
                    negatives[negIndex++] = el;
                }
            }
            Console.WriteLine($"кол-во положительных: {positiveCount}");
            Console.WriteLine($"кол-во отрицательных: {negativeCount}");

            return (positives, negatives);

        }
        static void Main(string[] args)
        {
            Console.Write("Длина массива: ");
            int lenght = int.Parse(Console.ReadLine());

            var array = new int[lenght];
            FillArray(array);
            PrintArray(array);

            
            var (positives, negatives) = FindDifference(array);
            Console.Write("Положительные числа:");
            PrintArray(positives);

            Console.Write("Отрицательные числа:");
            PrintArray(negatives);


        }
    }
}
