namespace String
{
    internal class Plural
    {
        public static void DeclensionToEnd(int number)
        {
            var lastTwoDigits = number % 100; 
            var lastDigit = number % 10;                      

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
            for (int i = 1; i < 100; i++)
            {
                DeclensionToEnd(i);
            }

        }

    }
}
