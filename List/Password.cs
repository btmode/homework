namespace List;

class Color
{
    public int r;
    public int g;
    public int b;
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

        var loginOptions = new ValidationOptions
        {
            minLength = 6,
            maxLength = 12,
            useDigits = null,
            useUpper = null,
            useLower = null,
            useSpecialSymbols = null,
            //lang = Lang.Either
        };

        var passOptions = new ValidationOptions
        {
            minLength = 8,
            maxLength = 16,
            useDigits = true,
            useUpper = true,
            useLower = true,
            useSpecialSymbols = true,
            //lang = Lang.Either
        };

        var validatorlogin = new Validator(loginOptions);
        var validatorPass = new Validator(passOptions);

        while (true)
        {
            Console.Write("Введите логин: ");
            var login = Console.ReadLine() ?? "";

            Console.Write("Введите пароль: ");
            var password = Console.ReadLine() ?? "";

            var loginValidationResult = validatorlogin.Validate(login);
            Console.WriteLine($"Логин валиден: {loginValidationResult.IsValid}");
            if (loginValidationResult.IsValid)
            {
                Console.WriteLine(loginValidationResult.Message);
            }

            var passValidationResult = validatorPass.Validate(password);
            Console.WriteLine($"Логин валиден: {loginValidationResult.IsValid}");
            if (passValidationResult.IsValid)
            {
                Console.WriteLine(passValidationResult.Message);
            }

            if (loginValidationResult.IsValid && passValidationResult.IsValid)
            {
                Console.WriteLine("Вы зарегистрировались!");
                break;
            }
        }
    }
}