namespace String
{
    internal class Plural
    {
        public static void DeclensionToEnd(int number)
        {
            int lastTwoDigits = number % 100; 
            int lastDigit = number % 10;                      

            if (lastTwoDigits >= 11 && lastTwoDigits <= 19)
            {
                Console.WriteLine($"{number}: яблок");
            }
            else if (lastDigit == 1) 
            {
                Console.WriteLine($"{number}: яблоко");
            }
            else if (lastDigit >= 2 && lastDigit <= 4) 
            {
                Console.WriteLine($"{number}: яблока");
            }
            else 
            {
                Console.WriteLine($"{number}: яблок");
            }
        }

        public static void Start()
        {
            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            DeclensionToEnd(number);
        }

    }
}
