namespace While;

static class Digits
{
    public static List<int> GetDigitsList(int num)
    {
        var list = new List<int>();

        while (num > 0)
        {
            list.Add(num % 10);
            num = num / 10;
        }

        return list;
    }

    public static void Start()
    {
        Console.WriteLine("Введите число: ");
        var num = int.Parse(Console.ReadLine());

        var digits = GetDigitsList(num);
        digits.Sort();
        Console.WriteLine(string.Join(", ", digits));
    }
}