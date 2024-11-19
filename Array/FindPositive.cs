namespace FindPositive
{
    internal class FindPositive
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
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        static int[] PositiveEl(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                }
            }

            var a = new int[count];
            int index = 0;
            var b = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    a[index++] = array[i];
                    b++;
                }
            }
            Console.WriteLine($"кол-по положительных чисел: {b}");
            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("Длина массива: ");
            int Lenght = int.Parse(Console.ReadLine());

            var array = new int[Lenght];

            FillArray(array);
            PrintArray(array);

            int[] res = PositiveEl(array);
            Console.Write("Ваш положительный массив: ");
            PrintArray(res);
        }
    }
}
