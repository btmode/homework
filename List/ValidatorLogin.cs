namespace List;

public class ValidatorLogin
{

    public static string? ValidateLogin(string value, ValidationOptions options)
    {
        //var lang = new Lang();

        //static bool IsRussianChar(char i)
        //{
        //    return (i >= 'А' && i <= 'я') || i == 'ё' || i == 'Ё';
        //}

        //static bool IsLatinChar(char i)
        //{
        //    return (i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z');
        //}

        //static bool IsLangValid(string value, Lang lang)
        //{

        //    foreach (var i in value)
        //    {
        //        if (char.IsDigit(i) || char.IsSymbol(i) || char.IsPunctuation(i))
        //        {
        //            continue;
        //        }

        //        bool isRussian = IsRussianChar(i);
        //        bool isLatin = IsLatinChar(i);

        //        if (lang == Lang.Rus && !isRussian)
        //        {
        //            Console.WriteLine($"Ошибка: символ '{i}' не является кириллицей");
        //            return false;
        //        }

        //        if (lang == Lang.En && !isLatin)
        //        {
        //            Console.WriteLine($"Ошибка: символ '{i}' не является латинским.");
        //            return false;
        //        }

        //        if (lang == Lang.Both && !isRussian && !isLatin)
        //        {
        //            Console.WriteLine($"Ошибка: символ '{i}' не является ни кириллице, ни латинице");
        //            return false;
        //        }

        //    }
        //    return true;
        //}

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

        bool isValid = true;

        if (!IsLengthValid(value, options))
        {
            Console.WriteLine($"Ошибка: длина должна быть от {options.minLength} до {options.maxLength}");
            isValid = false;
        }
        //if (!IsLangValid(value, options.lang))
        //{
        //    Console.WriteLine("Ошибка: символы не соответствуют, вы можете исользовать только латинские и русские");
        //    isValid = false;
        //}

        if (options.useSpecialSymbols == false && !HasSpecialSymbolLogin(value, options))
        {
            Console.WriteLine("Ошибка: логин не должен содержать специальный символ");
            isValid = false;
        }

        return isValid ? null : "Ошибки в логине, соблюдайте правила регистрации!";
    }
}