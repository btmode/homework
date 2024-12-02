namespace List;

public class Validator
{

    public static string? Validate(string value, ValidationOptions options, bool isLogin = false)
    {
        var lang = new Lang();

        static bool IsRussianChar(char i)
        {
            return (i >= 'А' && i <= 'я') || i == 'ё' || i == 'Ё';
        }

        static bool IsLatinChar(char i)
        {
            return (i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z');
        }

        static bool IsLangValid(string value, Lang lang)
        {
            foreach (var i in value)
            {
                if (char.IsDigit(i) || char.IsSymbol(i) || char.IsPunctuation(i))
                {
                    continue;
                }

                bool isRussian = IsRussianChar(i);
                bool isLatin = IsLatinChar(i);

                if (lang == Lang.Rus && !isRussian)
                {
                    Console.WriteLine($"Ошибка: символ '{i}' не является кириллицей");
                    return false;
                }

                if (lang == Lang.En && !isLatin)
                {
                    Console.WriteLine($"Ошибка: символ '{i}' не является латинским.");
                    return false;
                }

                if (lang == Lang.Both && !isRussian && !isLatin)
                {
                    Console.WriteLine($"Ошибка: символ '{i}' не является ни кириллице, ни латинице");
                    return false;
                }

            }
            return true;
        }

        static bool IsLengthValid(string value, ValidationOptions options)
        {
            return value.Length >= options.minLength && value.Length <= options.maxLength;
        }

        static bool HasSpecialSymbolLogin(string value, ValidationOptions options)
        {
            var symbolList = "!#$%&()*+,-./:<=>?@[]_{|}";
            foreach (var i in value)
            {
                if (symbolList.Contains(i))
                {
                    return false;
                }
            }
            return true;
        }

        static bool HasSpecialSymbolPass(string value, ValidationOptions options)
        {
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

        static bool HasDigits(string value, ValidationOptions options)
        {
            foreach (var i in value)
            {
                if (char.IsDigit(i))
                {
                    return true;
                }
            }
            return false;
        }

        static bool HasUpper(string value, ValidationOptions options)
        {
            foreach (var i in value)
            {
                if (char.IsUpper(i))
                {
                    return true;
                }
            }
            return false;
        }

        static bool HasLower(string value, ValidationOptions options)
        {
            foreach (var i in value)
            {
                if (char.IsLower(i))
                {
                    return true;
                }
            }
            return false;
        }


        bool isValid = true;
        if (!IsLengthValid(value, options))
        {
            Console.WriteLine($"Ошибка: длина должна быть от {options.minLength} до {options.maxLength}");
            isValid = false;
        }
        if (!IsLangValid(value, options.lang))
        {
            Console.WriteLine("Ошибка: символы не соответствуют, вы можете исользовать только латинские и русские");
            isValid = false;
        }

        if (isLogin)
        {
            if (options.useSpecialSymbols == false && !HasSpecialSymbolLogin(value, options))
            {
                Console.WriteLine("Ошибка: логин не должен содержать специальный символ");
                isValid = false;
            }
        }
        else
        {
            if (options.useSpecialSymbols == true && !HasSpecialSymbolPass(value, options))
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы один специальный символ");
                isValid = false;
            }

            if (options.useDigits == true && !HasDigits(value, options))
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы одну цифру");
                isValid = false;
            }

            if (options.useUpper == true && !HasUpper(value, options))
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы одну заглавную букву");
                isValid = false;
            }

            if (options.useLower == true && !HasLower(value, options))
            {
                Console.WriteLine("Ошибка: пароль должен содержать хотя бы одну строчную букву");
                isValid = false;
            }
        }
        return isValid ? null : "Попробуйте еще раз и соблюдайте правила регистрации!";
    }
}