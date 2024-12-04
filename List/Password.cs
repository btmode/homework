using System.Runtime.InteropServices;

namespace List;

public enum Lang
{
    Rus, En, Both
}

public class ValidationOptions
{
    public int minLength;
    public int maxLength;
    public bool? useDigits; // true - нужно использовать цифры, false - не нужно, null - не важно
    public bool? useUpper;
    public bool? useLower;
    public bool? useSpecialSymbols;
    public Lang lang;
}
public static class Password
{

    private static void PrintRules()
    {
        Console.WriteLine("Минимальная и максимальная длина логин (6-12 символов)");
        Console.WriteLine("В логине нельзя использовать специальные символы");
        Console.WriteLine("Минимальная и максимальная длина пароля (8-16 символов)");
        Console.WriteLine("Минимум одну строчную букву (a-z)");
        Console.WriteLine("Минимум одну заглавную букву (A-Z)");
        Console.WriteLine("Минимум одну цифру (0-9)");
        Console.WriteLine("Пароль можно сделать на EN и Ru или же оба варианта вместе");
        Console.WriteLine("////");
    }

    public static void Start()
    {
        PrintRules();

        ValidationOptions passOptions = new()
        {
            minLength = 8,
            maxLength = 16,
            useDigits = true,
            useUpper = true,
            useLower = true,
            useSpecialSymbols = true,
            lang = Lang.Both
        };
        ValidationOptions loginOptions = new()
        {
            minLength = 6,
            maxLength = 12,
            useDigits = true,
            useUpper = true,
            useLower = true,
            useSpecialSymbols = false,
            lang = Lang.Both
        };

        var validatorlogin = new ValidatorLogin();
        var validatorPass = new ValidatorPass();

        while (true)
        {
            Console.Write("Введите логин: ");
            var login = Console.ReadLine() ?? "";

            Console.Write("Введите пароль: ");
            var password = Console.ReadLine() ?? "";

            var loginMessage = ValidatorLogin.ValidateLogin(login, loginOptions);
            if (loginMessage != null)
            {
                Console.WriteLine(loginMessage);
            }
            
            var passMessage = ValidatorPass.ValidatePass(password, passOptions);
            if (passMessage != null)
            {
                Console.WriteLine(passMessage);
            }

            if (loginMessage == null && passMessage == null)
            {
                Console.WriteLine("Вы зарегистрировались!");
                break;
            }
        }
    }
}