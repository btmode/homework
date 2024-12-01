namespace String
{
    class Sum
    {
        public static int SumNumbers(string text)
        {
            var sum = 0;
            string digit = "";

            foreach (char i in text)
            {
                if (char.IsDigit(i))
                {
                    digit += i;

                }
                else
                {
                    if (digit != "")
                    {
                        sum += int.Parse(digit);
                        digit = "";
                    }
                }
            }

            return sum;
        }

        public static void Start()
        {
            Console.WriteLine("введите текст: ");
            var text = Console.ReadLine();

            var res = SumNumbers(text);
            Console.WriteLine(res);
        }
    }
}
