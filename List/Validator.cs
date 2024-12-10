namespace List;

class Validator
{
    private ValidationOptions _options;

    public Validator(ValidationOptions options)
    {
        _options = options;
    }


    public ValidationResult Validate(string value)
    {
        var validationResult = new ValidationResult();

        if (!IsLengthValid(value))
        {
            validationResult.IsValid = false;
            validationResult.Message += $"Ошибка: длина должна быть от {_options.minLength} до {_options.maxLength}";
        }

        // Проверка языка
        //if (!IsLangValid(value))
        //{
        //    validationResult.IsValid = false;
        //    validationResult.Message += $"Ошибка: символы не соответствуют выбранному языку: {_options.lang}";
        //}

        
        if (_options.useSpecialSymbols != null)
        {
            if (_options.useSpecialSymbols == true && !HasSpecialSymbols(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: строка должна содержать хотя бы один специальный символ";
            }
            if (_options.useSpecialSymbols == false && HasSpecialSymbols(value))
            {
                validationResult.IsValid = false;
                validationResult.Message += "Ошибка: строка не должна содержать специальные символы";
            }
        }


        if (_options.useDigits != null)
        {
            if (_options.useDigits == true && !HasDigits(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: строка должна содержать хотя бы одну цифру";
            }
            else if (_options.useDigits == false && HasDigits(value))
            {
                validationResult.IsValid = false;
                validationResult.Message += "Ошибка: строка не должна содержать цифры";
            }
        }

        if (_options.useUpper != null)
        {
            if (_options.useUpper == true && !HasUpper(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: строка должна содержать хотя бы одну заглавную букву";
            }
            else if (_options.useUpper == false && HasUpper(value))
            {
                validationResult.IsValid = false;
                validationResult.Message += "Ошибка: строка не должна содержать заглавные буквы";
            }
        }
        
        if (_options.useLower != null)
        {
            if (_options.useLower == true && !HasLower(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: строка должна содержать хотя бы одну строчную букву";
            }
            else if (_options.useLower == false && HasLower(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: строка не должна содержать строчные буквы";
            }
        }

        return validationResult;
    }

    //private string LangToString(Lang lang)
    //{
    //    if (_options.lang == Lang.Rus)
    //    {
    //        return lang.ToString();
    //    }
    //    if (_options.lang == Lang.En)
    //    {
    //        return lang.ToString();
    //    }
    //    if (_options.lang == Lang.Both)
    //    {
    //        return lang.ToString();
    //    }
    //    if (_options.lang == Lang.Either)
    //    {
    //        return lang.ToString();
    //    }
    //    return lang.ToString();
    //}
    private bool ContainsRussianChars(string value)
    {
        var rus = "ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
        foreach (var i in value)
        {
            if (rus.Contains(i))
            {
                return true;
            }
        }
        return false;
    }

    private bool ContainsEnChars(string value)
    {
        var en = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";


        foreach (char i in value)
        {
            if (en.Contains(i))
            {
                return true;
            }
        }
        return false;
    }

    private bool IsLangValid(string value)
    {
        var containsRus = ContainsRussianChars(value);
        var containsEn = ContainsEnChars(value);

        if (_options.lang == Lang.Either)
            return true;

        if (_options.lang == Lang.En)
            return containsEn && !containsRus;

        if (_options.lang == Lang.Rus)
            return containsRus && !containsEn;

        if (_options.lang == Lang.Both)
            return containsRus && containsEn;

        return false;
    }


    private bool IsLengthValid(string value) => value.Length >= _options.minLength && value.Length <= _options.maxLength;


    private bool HasSpecialSymbols(string value)
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

    private static bool HasDigits(string value)
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

    private static bool HasUpper(string value)
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

    private static bool HasLower(string value)
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
}