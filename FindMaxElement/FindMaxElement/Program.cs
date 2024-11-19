namespace FindMaxElement
{
    internal class Program
    {
        public static void FillArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-1000, 1000);
            }
        }
        
        public  static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
        
        public  static int FindMaxNum(int[] array)
        {
            int max = 0,min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else if (array[i]< min)
                {
                    min = array[i];
                }
                
            }
            return max-min;
        }
        
        public  static void Main(string[] args)
        {
            Console.WriteLine("Длинна массива: ");
            int Lenght = int.Parse(Console.ReadLine());

            var array = new int[Lenght];

            FillArray(array);
            PrintArray(array);

            int res = FindMaxNum(array);
            //Console.WriteLine($"Ваше максимальное число: {res}");
            Console.WriteLine($"Разность: {res}");
        }
    }
}
