using System.Xml;

namespace scharp;

internal class Password
{
    public static bool CheckLengthLogin(List<char> login)
    {
        return login.Count >= 6 && login.Count <= 12;
    }

    public static bool UseSpecSymbolLogin(List<char> login)
    {
        string symbolList = "' ! \" # $ % & ’ ( ) * + , - . / : ; < = > ? @ [  ] ^ _ ` { | } ~. '";
        foreach (var i in login)
        {
            if (symbolList.Contains(i))
            {
                return false;
            }
        }
        return true;
    }

    public static bool CheckLengthPass(List<char> password)
    {
        return password.Count >= 8 && password.Count <= 16;
    }

    public static bool UseSpecSymbolPass(List<char> password)
    {
        string symbolList = "!#$%&()*+,-./:<=>?@[]_{|}";
        foreach (var i in password)
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
    public static void typeRule()
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
    static void Main(string[] args)
    {
        typeRule();
        while (true)
        {

            Console.Write("Введите логин: ");
            var length2 = Console.ReadLine();
            Console.Write("Введите пароль: ");
            var length = Console.ReadLine();

            var login = new List<char>(length2);
            var password = new List<char>(length);

            bool isLengthLogin = CheckLengthLogin(login);
            bool hasSpecSymbolLogin = UseSpecSymbolLogin(login);

            bool isLengthPass = CheckLengthPass(password);
            bool hasSpecSymbolPass = UseSpecSymbolPass(password);
            bool hasDigitPass = UseDigits(password);
            bool hasUpperPass = UseUpper(password);
            bool hasLowerPass = UseLower(password);

            if ((isLengthLogin && hasSpecSymbolLogin) &&
                (isLengthPass && hasSpecSymbolPass && hasDigitPass && hasUpperPass && hasLowerPass))
            {
                Console.WriteLine("Логин создан успешно.");
                Console.WriteLine("Пароль создан успешно.");
                Console.WriteLine("Ваш аккаунт успешно создан!");
                break;

            }
            if (!isLengthLogin)
            {
                Console.WriteLine("Ошибка: длина логина должна быть от 6 до 12 символов");
            }
            if (!hasSpecSymbolLogin)
            {
                Console.WriteLine("Ошибка: логин не должен содержать специальные символы");
            }


            if (isLengthPass && hasSpecSymbolPass && hasDigitPass && hasUpperPass && hasLowerPass)
            {
                Console.WriteLine("Пароль создан успешно!");
                break;
            }
            if (!isLengthPass)
            {
                Console.WriteLine("Ошибка: длина пароля должна быть от 8 до 16 символов");
            }
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

