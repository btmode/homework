using System.ComponentModel.DataAnnotations;

namespace List;

enum Lang
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

internal class Password
{
    public static bool IsLengthValid(List<char> value, ValidationOptions options)
    {
        return value.Count >= options.minLength && value.Count <= options.maxLength;
    }
    
    public static bool IsLengthValid2(string value, ValidationOptions options)
    {
        return value.Length >= options.minLength && value.Length <= options.maxLength;
    }

    public static bool HasSpecialSymbol(List<char> value, ValidationOptions options)
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

    public static bool HasDigits(List<char> password, ValidationOptions options)
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

    public static bool HasUpper(List<char> password, ValidationOptions options)
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

    public static bool HasLower(List<char> password, ValidationOptions options)
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
        
        var validator = new Validator(); // Validator - класс, validator - экземпляр класса
        var passMessage = validator.Validate("какой-то пароль", passOptions); // null, когда все ок
        var loginMessage = validator.Validate("какой-то логин", loginOptions); // "Длина не может быть меньше 6 символов"

        //var names = new List<string> { "John", "Bob", "Alice", "Eve", "Max" };

        ValidationOptions passOptions = new()
        {
            minLength = 8,
            maxLength = 16,
            useDigits = true,
            useUpper = true,
            useLower = true,
            useSpecialSymbols = true,
            lang = Lang.Rus
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

        while (true)
        {
            Console.Write("Введите логин: ");
            var login = new List<char>(Console.ReadLine() ?? string.Empty);

            Console.Write("Введите пароль: ");
            var password = new List<char>(Console.ReadLine() ?? string.Empty);
            string password2 = Console.ReadLine() ?? "";

            bool isValid = true;

            //логин
            if (!IsLengthValid(login, loginOptions))
            {
                Console.WriteLine("Ошибка: длина логина должна быть от 6 до 12 символов");
                isValid = false;
            }
            if (HasSpecialSymbol(login, loginOptions))
            {
                Console.WriteLine("Ошибка: логин не должен содержать специальные символы");
                isValid = false;
            }
            //пароль 
            if (!IsLengthValid(password, passOptions))
            {
                Console.WriteLine("Ошибка: длина пароля должна быть от 8 до 16 символов");
                isValid = false;
            }
            
            if (!IsLengthValid2(password2, passOptions))
            {
                Console.WriteLine("Ошибка: длина пароля должна быть от 8 до 16 символов");
                isValid = false;
            }
            if (!HasSpecialSymbol(password, passOptions))
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы один специальный символ");
                isValid = false;
            }
            if (!HasDigits(password, passOptions))
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы одну цифру");
                isValid = false;
            }
            if (!HasUpper(password, passOptions))
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы одну заглавную букву");
                isValid = false;
            }
            if (!HasLower(password, passOptions))
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы одну строчную букву");
                isValid = false;
            }
            
            if (isValid)
            {
                Console.WriteLine("Вы зарегистрировались!");
                break;
            }

        }
    }
}