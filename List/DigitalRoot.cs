namespace List;

class DigitalRoot
{
    public static int HasRoot(int number)
    {
        if (number < 10)
            return number;

        return HasRoot(IsRoot(number));
    }

    public static int IsRoot(int digit)
    {
        var number = 0;
        while (digit != 0)
        {
            number += digit % 10;
            digit /= 10;
        }
        return number;
    }

    public static void Start()
    {
        Console.WriteLine("Введите число");
        var number = int.Parse(Console.ReadLine());

        int res = HasRoot(number);
        Console.WriteLine($"Цифровой корень числа {number} равен {res}");
    }
}
