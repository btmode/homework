namespace List;

class DigitalRoot
{
    public static int GetRoot(int number)
    {
        if (number < 0) throw new Exception("Не допускаются отрицательные значения");

        if (number < 10)
            return number;

        var sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }

    public static void Start()
    {
        Console.WriteLine("Введите число");

        try
        {
            var number = int.Parse(Console.ReadLine());
            var root = GetRoot(number);
            Console.WriteLine($"Цифровой корень числа {number} равен {root}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Произошла ошибка: {e.Message}");
        }

        Console.WriteLine(123);
    }
}
