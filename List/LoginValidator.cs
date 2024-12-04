namespace List;

public class Validator
{
    private ValidationOptions _options;

    public Validator(ValidationOptions options)
    {
        _options = options;
    }
    
    public ValidationResult Validate(string value)
    {
        var validationResult = new ValidationResult();

        if (!IsLengthValid(value, _options))
        {
            validationResult.IsValid = false;
            validationResult.Message = $"Ошибка: длина должна быть от {_options.minLength} до {_options.maxLength}";
        }
        
        if (!IsLangValid(value, _options.lang))
        {
            validationResult.IsValid = false;
            validationResult.Message = "Ошибка: символы не соответствуют выбранному языку";
        }

        if (_options.useSpecialSymbols == false && HasSpecialSymbolLogin(value, _options))
        {
            validationResult.IsValid = false;
            validationResult.Message = "Ошибка: логин не должен содержать специальный символ";
        }

        return validationResult;
    }
    
    private bool ContainsRussianChars(string value)
    {
        
    }
    
    private bool ContainsEnChars(string value)
    {
        
    }
    
    private bool IsLangValid(string value, Lang lang)
    {
        if (lang == Lang.Either) return true;

        if (lang == Lang.En && ContainsRussianChars(value)) return false;
        if (lang == Lang.Rus && ContainsEnChars(value)) return false;
        if (lang == Lang.Both && ContainsEnChars(value) && ContainsRussianChars(value)) return true;

        return true;
        
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
    
    private bool IsRussianChar(char i)
    {
        var letters = "йцукеёнгшщзхъфывапролджэячсмитьбю".Split("");
        return letters.Contains(char.ToLower(i).ToString());
        // return (i >= 'А' && i <= 'я') || i == 'ё' || i == 'Ё';
    }

    // Переименовать
    private bool IsLatinChar(char i)
    {
        return (i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z');
    }
    
    private bool IsLengthValid(string value, ValidationOptions options)
    {
        return value.Length >= options.minLength && value.Length <= options.maxLength;
    }

    private bool HasSpecialSymbolLogin(string value, ValidationOptions options)
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

    private bool HasSpecialSymbolPass(string value, ValidationOptions options)
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
}