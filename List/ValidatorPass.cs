namespace List
{
    class ValidatorPass
    {
        public static string? ValidatePass(string value, ValidationOptions options)
        {

            static bool IsLengthValid(string value, ValidationOptions options)
            {
                return value.Length >= options.minLength && value.Length <= options.maxLength;
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

            return isValid ? null : "Ошибки в пароле, соблюдайте правила регистрации!";
        }
    }
}
