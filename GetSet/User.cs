using System.Text;
using System.Security.Cryptography;

namespace GetSet;
public class User
{
    public string _username;
    public string _password;
    public string _role;


    public string GetUsername() => _username;

    public void SetUsername(string username)
    {
        _username = username;
    }

    public string GetPassword() => _password;

    public void SetPassword(string password)
    {
        _password = HashPasswordSHA256(password);

    }
    public string HashPasswordSHA256(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha256.ComputeHash(bytes);


            StringBuilder builder = new StringBuilder();            
            foreach (byte b in hashBytes)
            {
                builder.Append(b.ToString("x2"));
            }

            return builder.ToString();
        }
    }
    public string GetRole() => _role;

    public void SetRole(string role)
    {
        _role = role;
    }
}

public class InfoUser
{
    public static void Start()
    {
        var user = new User();

        Console.Write("Введите имя пользователя: ");
        user.SetUsername(Console.ReadLine());

        Console.Write("Введите пароль: ");
        user.SetPassword(Console.ReadLine());

        Console.Write("Введите роль: ");
        user.SetRole(Console.ReadLine());


        Console.Write("Информация о пользователе" + Environment.NewLine);
        Console.Write($"Имя пользователя: {user.GetUsername()}" + Environment.NewLine);
        Console.Write($"Ваш хешированный пароль: {user.GetPassword()}" + Environment.NewLine);
        Console.Write($"Роль пользователя: {user.GetRole()}");

    }
}






