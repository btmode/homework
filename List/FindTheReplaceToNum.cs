namespace List
{
    internal class FindTheReplaceToNum
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

        public static void ReplaceNum(int length)
        {
            var res = 1;

            for (int i = 1; i <= length; i++)
            {
                if (res * i == 0)
                {
                    Console.WriteLine(res);
                    Console.WriteLine(i);
                }
                res *= i;
            }

            Console.Write($"Кол-во возможных вариаций: {res}");
        }

        public static void Start()
        {
            Console.WriteLine("Введите длинну массива: ");
            var length = int.Parse(Console.ReadLine());

            var list = new List<int>(length);
            FillList(list, length);
            // Limiter(length);
            ReplaceNum(length);
        }
    }
}