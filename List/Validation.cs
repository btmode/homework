using static List.LanguageEnum;

namespace List;

internal class Validation
{
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
}
