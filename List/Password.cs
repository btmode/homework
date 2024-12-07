using static List.IsEnum;


namespace List;

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


        var loginOptions = new Validation.ValidationOptions
        {
            minLength = 8,
            maxLength = 16,
            useDigits = true,
            useUpper = true,
            useLower = true,
            useSpecialSymbols = true,
            lang = Lang.En
        };

        var passOptions = new Validation.ValidationOptions
        {
            minLength = 6,
            maxLength = 12,
            useDigits = true,
            useUpper = true,
            useLower = true,
            useSpecialSymbols = false,
            lang = Lang.En
        };

        var validatorlogin = new Validator(loginOptions);
        var validatorPass = new Validator(passOptions);

        while (true)
        {
            Console.Write("Введите логин: ");
            var login = Console.ReadLine();

            Console.Write("Введите пароль: ");
            var password = Console.ReadLine();

            var loginValidationResult = validatorlogin.Validate(login, isLogin: true);
            if (!loginValidationResult.IsValid)
            {
                Console.WriteLine(loginValidationResult.Message);
            }

            var passValidationResult = validatorPass.Validate(password);
            if (!passValidationResult.IsValid)
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