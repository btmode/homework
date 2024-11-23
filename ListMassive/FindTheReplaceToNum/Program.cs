namespace FindTheReplaceToNum
{
    internal class Program
    {
        public static void FillList(List<int> list, int lenght)
        {
            Random rnd = new Random();
            for (int i = 0; i < lenght; i++)
            {
                list.Add(rnd.Next(1, 20));
            }
            Console.Write("Ваш List: ");
            Console.WriteLine(string.Join(" ", list));


        }

        public static void Limiter(int lenght)
        {
            if (lenght > 17)
            {
                Console.WriteLine("Слишком огромное число!");
            }
        }

        public static void ReplaceNum(List<int> list, int lenght)
        {
            var res = 1;

            for (int i = 1; i <= list.Count; i++)
            {
                res *= i;
            }
            Console.Write($"Кол-во возможных вариаций: {res}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну массива: ");
            var lenght = int.Parse(Console.ReadLine());

            List<int> list = new List<int>(lenght);
            FillList(list, lenght);
            Limiter(lenght);
            ReplaceNum(list, lenght);

        }
    }
}
