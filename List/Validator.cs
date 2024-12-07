using static List.LanguageEnum;

namespace List;

class Validator
{
    private Validation.ValidationOptions _options;

    public Validator(Validation.ValidationOptions options)
    {
        _options = options;
    }

    public ValidationResult Validate(string value, bool isLogin = false)
    {
        var validationResult = new ValidationResult();
        if (isLogin)
        {
            if (!IsLengthValid(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = $"Ошибка: длина логина должна быть от {_options.minLength} до {_options.maxLength}";
            }
            if (!IsLangValid(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: символы не соответствуют выбранному языку";
            }
            if (_options.useSpecialSymbols == false && HasSpecialSymbolLogin(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: логин не должен содержать специальный символ";
            }
        }
        else
        {
            if (!IsLengthValid(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = $"Ошибка: длина пароля должна быть от {_options.minLength} до {_options.maxLength}";
            }
            if (!IsLangValid(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: символы не соответствуют выбранному языку";
            }
            if (_options.useSpecialSymbols == true && !HasSpecialSymbolPass(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: пароль должен содержать хотя бы один специальный символ";
            }
            if (_options.useDigits == true && !HasDigits(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: пароль должен содержать хотя бы одну цифру";
            }
            if (_options.useUpper == true && !HasUpper(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: пароль должен содержать хотя бы одну заглавную букву";
            }
            if (_options.useLower == true && !HasLower(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: пароль должен содержать хотя бы одну строчную букву";
            }
            if (!IsLangValid(value))
            {
                validationResult.IsValid = false;
                validationResult.Message = "Ошибка: символы не соответствуют выбранному языку";
            }
        }
        return validationResult;
    }

    private bool ContainsRussianChars(string value)
    {
        var rus = "ёйцукенгшщзхъфывапролджэячсмитьбюЁЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";
        bool containsRus = false;

        foreach (var i in value)
        {
            if (rus.Contains(i))
            {
                containsRus = true;
                return true;
            }
        }
        return false;
    }

    private bool ContainsEnChars(string value)
    {
        var en = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
        bool containsEn = false;

        foreach (char i in value)
        {
            if (en.Contains(i))
            {
                containsEn = true;
                return true;
            }
        }
        return false;
    }

    private bool IsLangValid(string value)
    {
        bool containsRus = ContainsRussianChars(value);
        bool containsEn = ContainsEnChars(value);

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

    private bool IsLengthValid(string value)
    {
        return value.Length >= _options.minLength && value.Length <= _options.maxLength;
    }

    private bool HasSpecialSymbolLogin(string value)
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

    private bool HasSpecialSymbolPass(string value)
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