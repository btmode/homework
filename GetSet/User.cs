using System.Text;
using System.Security.Cryptography;

namespace GetSet;

public class User
{
    public string Username {  get; set; }
    public string Role { get; set; }

    private string _password;

    public string Password
    {

        get => _password;
        set
        {
            _password = HashPasswordSHA256(value);
        }
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
}

public class InfoUser
{
    public static void Start()
    {
        var user = new User();

        Console.WriteLine("Введите имя пользователя: ");
        var username = Console.ReadLine();
        user.Username = username;

        Console.WriteLine("Введите пароль: ");
        var pass = Console.ReadLine();
        user.Password = pass;

        Console.WriteLine("Введите роль: ");
        var role = Console.ReadLine();
        user.Role = role;


        Console.Write("Информация о пользователе" + Environment.NewLine);
        Console.Write($"Имя пользователя: {user.Username}" + Environment.NewLine);
        Console.Write($"Ваш хешированный пароль: {user.Password}" + Environment.NewLine);
        Console.Write($"Роль пользователя: {user.Role}");
    }
}






