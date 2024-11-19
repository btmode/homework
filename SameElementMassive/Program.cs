namespace SameElementMassive
{
    internal class Program
    {
        static void FillArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 20);
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
        static void SameEl(int[] array)
        {
            Console.Write($"Повторяющийся элемент: ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.Write(array[i] + " ");
                        break;
                    }                    
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

            SameEl(array);
        }
    }
}
