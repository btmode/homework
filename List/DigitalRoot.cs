namespace List;

class DigitalRoot
{
    // По именованию метода больше похоже, что он должен возвращать bool.
    // То есть ты назвал Has - имеет или не имеет. А метод находит цифровой корень числа, поэтому нужно его назвать Get или Find
    public static int HasRoot(int number)
    {
        // Обработать ситуацию, когда число отрицательное, например -123
        if (number < 10)
            return number;

        return HasRoot(IsRoot(number));
    }

    // Тут в целом не стоило разбивать на два отдельных метода, можно сделать все в одном
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
