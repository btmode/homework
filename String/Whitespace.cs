namespace String
{
    class Whitespace
    {
        public static void Start()
        {
            Console.Write("Введите текст: ");
            var text = Console.ReadLine();

            var words = text.Split(' ');

            Console.Write("Количество слов: ");
            Console.WriteLine(words.Length);
        }
    }
}
