namespace showElMassive
{
    internal class Program
    {
        static void FillArray(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(50);
            }
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static int[] ChoiceBigEl(int[] array)
        {
            int count = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    count++;
                }
            }
           
            int[] result = new int[count];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    result[index] = array[i];
                    index++;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Длина массива: ");
            int Lenght = int.Parse(Console.ReadLine());

            var array = new int[Lenght];

            FillArray(array);
            PrintArray(array);

            int[] res = ChoiceBigEl(array);
            Console.WriteLine("Ваш новый массив: ");
            PrintArray(res);


        }
    }
}

