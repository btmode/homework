using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interfaces
{
    public interface ICRUD
    {
        public void CreateUser(string email, string name, string password);
        public User ReadUserByName(string name);
        public void Update(string email, string name, string password);
        public void DeleteByName(string name);
    }

    public class User
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }

    public class UserCRUD : ICRUD
    {
        public List<User> Users { get; set; } = [];

        public void CreateUser(string email, string name, string password)
        {
            var user = new User() { Email = email, Name = name, Password = password };
            Users.Add(user);
        }

        public User ReadUserByName(string name)
        {

            foreach (var user in Users)
            {
                if (user.Name == name)
                {
                    return user;
                }
            }

            return null;
        }

        public void Update(string email, string name, string password)
        {
            foreach (var user in Users)
            {
                if (user.Name == name)
                {

                    user.Email = email;
                    user.Password = password;
                    return;

                }
            }

        }

        public void DeleteByName(string name)
        {
            foreach(var user in Users)
            {
                if (user.Name == name)
                {
                    Users.Remove(user);
                    return;
                }
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            UserCRUD user = new UserCRUD();

            user.CreateUser("john@com.com", "john", "1234687");
            user.CreateUser("kffkfkf@com.com", "Петя", "gfgjd");

            Console.WriteLine(user.Users.Count);

            User founduser = user.ReadUserByName("john");

            if (founduser != null)
            {
                Console.WriteLine($"Email: {founduser.Email}, Name: {founduser.Name}, Password: {founduser.Password}");
            }
            else
            {
                Console.WriteLine("Пользователь не найден!");
            }

            user.Update("petr@ru.ru", "федя", "213234");
            founduser = user.ReadUserByName("Петя");

            if (founduser != null)
            {
                Console.WriteLine($"Email: {founduser.Email}, Name: {founduser.Name}, Password: {founduser.Password}");
            }
            else
            {
                Console.WriteLine("Пользователь не найден!");
            }

            user.DeleteByName("john");

            foreach(var name in user.Users)
            {
                Console.WriteLine(name.Name);
            }

        }
    }

}
