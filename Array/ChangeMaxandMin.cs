namespace ChangeMaxandMin
{
    internal class ChangeMaxandMin
    {
        static void FillArray(int[] array)
        {
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
        }

        static void PrintArray(int[] array)
        {
            // Todo переделать на string.join
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        static void MaxAndMin(int[] array)
        {
            var max = 0;
            var min = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
                else if (array[i] < array[min])
                {
                    min = i;
                }
            }

            int temp = array[max];
            array[max] = array[min];
            array[min] = temp;
        }

        static void Main(string[] args)
        {
            Console.Write("Длина массива: ");
            var lenght = int.Parse(Console.ReadLine());

            var array = new int[lenght];

            FillArray(array);
            PrintArray(array);

            MaxAndMin(array);
            PrintArray(array);
        }
    }
}