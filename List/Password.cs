using System.Xml;

namespace List;

class ValidationOptions
{
    public int minLength;
    public int maxLength;
    public bool? useDigits; // true - нужно использовать цифры, false - не нужно, null - не важно
    public bool? useUpper;
    public bool? useLower;
    public bool? useSpecialSymbols;
}

internal class Password
{
    public static bool IsLengthValid(List<char> login, ValidationOptions options)
    {
        return login.Count >= options.minLength && login.Count <= options.maxLength;
    }

    public static bool HasSpecSymbol(List<char> value, ValidationOptions options)
    {
        if (options.useSpecialSymbols == null) return true;

        var symbolList = "!#$%&()*+,-./:<=>?@[]_{|}";
        foreach (var i in value)
        {
            if (symbolList.Contains(i))
            {
                return true;
            }
        }

        return false;
    }

    public static bool UseDigits(List<char> password)
    {
        foreach (var i in password)
        {
            if (char.IsDigit(i))
            {
                return true;
            }
        }

        return false;
    }

    public static bool UseUpper(List<char> password)
    {
        foreach (var i in password)
        {
            if (char.IsUpper(i))
            {
                return true;
            }
        }

        return false;
    }

    public static bool UseLower(List<char> password)
    {
        foreach (var i in password)
        {
            if (char.IsLower(i))
            {
                return true;
            }
        }

        return false;
    }

    public static void PrintRules()
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

        var names = new List<string> { "John", "Bob", "Alice", "Eve", "Max" };

        ValidationOptions passOptions = new()
        {
            minLength = 8, maxLength = 16, useDigits = true, useUpper = true, useLower = true, useSpecialSymbols = true
        };
        ValidationOptions loginOptions = new()
        {
            minLength = 6, maxLength = 12, useDigits = true, useUpper = true, useLower = true, useSpecialSymbols = false
        };

        while (true)
        {
            Console.Write("Введите логин: ");
            var login = new List<char>(Console.ReadLine()); // "лоршгн*:ЕЛООПг!!"№;%:?*(не123гаГАг"

            Console.Write("Введите пароль: ");
            var password = new List<char>(Console.ReadLine());

            bool hasSpecSymbolPass = UseSpecSymbolPass(password);
            bool hasDigitPass = UseDigits(password);
            bool hasUpperPass = UseUpper(password);
            bool hasLowerPass = UseLower(password);

            // if ((isLengthLogin && hasSpecSymbolLogin) &&
            //     (isLengthPass && hasSpecSymbolPass && hasDigitPass && hasUpperPass && hasLowerPass))
            // {
            //     Console.WriteLine("Логин создан успешно.");
            //     Console.WriteLine("Пароль создан успешно.");
            //     Console.WriteLine("Ваш аккаунт успешно создан!");
            //     break;
            // }

            if (!IsLengthValid(login, loginOptions))
                Console.WriteLine("Ошибка: длина логина должна быть от 6 до 12 символов");

            if (HasSpecSymbol(login, loginOptions))
                Console.WriteLine("Ошибка: логин не должен содержать специальные символы");

            // if (isLengthPass && hasSpecSymbolPass && hasDigitPass && hasUpperPass && hasLowerPass)
            // {
            //     Console.WriteLine("Пароль создан успешно!");
            //     break;
            // }

            if (!IsLengthValid(password, passOptions))
                Console.WriteLine("Ошибка: длина пароля должна быть от 8 до 16 символов");

            if (!hasSpecSymbolPass)
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы один специальный символ");
            }

            if (!hasDigitPass)
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы одну цифру");
            }

            if (!hasUpperPass)
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы одну заглавную букву");
            }

            if (!hasLowerPass)
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы одну строчную букву");
            }
        }
    }
}