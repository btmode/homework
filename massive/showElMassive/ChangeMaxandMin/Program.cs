namespace ChangeMaxandMin
{
    internal class Program
    {
        static void FillArray(int[] array)
        {
            Random rnd = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1,100);
            }
        }
        static void PrintArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();
        }        
        static void MaxAndMin(int[] array)
        {

            int max = 0;
            int min = 0;
            

            for (int i = 1;i < array.Length; i++)
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
            int Lenght = int.Parse(Console.ReadLine());

            var array = new int[Lenght];

            FillArray(array);
            PrintArray(array);

            MaxAndMin(array);
            PrintArray(array);
        }
    }
}
