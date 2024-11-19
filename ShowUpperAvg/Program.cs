
namespace ShowUpperAvg
{
    internal class Program
    {
        static void FillArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }
        }

        static void PrintArray(int[] array)
        {
            //uhihg
            foreach (int el in array)
            {
                Console.Write(el + " ");
            }

            Console.WriteLine();
        }

        public static int GetSum(int[] array)
        {
            int sum = 0;
            foreach (int el in array)
            {
                sum += el;
            }

            return sum;
        }

        static void UpperAvg(int[] array)
        {
            var sum = GetSum(array);

            double res = (double)sum / array.Length;
            res = Math.Round(res, 2);
            Console.WriteLine($"Avg: {res}");

            Console.Write("Числа выше среднего: ");
            foreach (int el in array)
            {
                if (el > res)
                {
                    Console.Write(el + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Длина массива: ");
            int lenght = int.Parse(Console.ReadLine());

            var array = new int[lenght];
            FillArray(array);
            PrintArray(array);

            UpperAvg(array);
        }
    }
}