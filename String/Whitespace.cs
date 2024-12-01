namespace String
{
    class Whitespace
    {

        public static void Start()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            string[] textMass;
            textMass = text.Split(' ');

            Console.Write("Количество слов: ");
            Console.WriteLine(textMass.Length);
        }
    }
}
