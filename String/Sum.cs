namespace String
{
    class Sum
    {
        public static int SumNumbers(string text)
        {
            var sum = 0;

            foreach (char i in text)
            {
                if (char.IsDigit(i))
                {
                    sum += int.Parse(i.ToString());
                }
            }

            return sum;
        }

        public static void Start()
        {
            Console.WriteLine("введите текст: ");
            var text = "rhguh4 g34ig34igi"; //Console.ReadLine();

            var res = SumNumbers(text);
            Console.WriteLine(res);
        }
    }
}
