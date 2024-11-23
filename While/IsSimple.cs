namespace While;

internal class IsNumberSimple
{
    public static bool IsSimple(int num = 100)
    {
        for (int i = 2; i < Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    public static void Start()
    {
        Console.WriteLine("Введите число: ");
        var num = int.Parse(Console.ReadLine());

        if (IsSimple(num))
        {
            Console.Write("Простое");
        }
        else
            Console.Write("Непростое");
    }
}