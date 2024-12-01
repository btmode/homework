var alex = new Person() { Name = "Александр", City = "Москва", Age = 20 };
var pavel = new Person() { Name = "Павел", City = "Москва", Age = 25 };

alex.PrintInfo();
pavel.PrintInfo();

// { "Name": "Александр", "City": "Москва", "Age": 20 }

Person.PrintInfo("Александр", "Москва", 20);

class Person
{
    public string Name;
    public string City;
    public int Age;
    
    // Не статический - относится к экземпляру класса Person (alex, pavel)
    public void PrintInfo()
    {
        Console.WriteLine($"Привет! Меня зовут {Name}, я живу в городе {City} и мне {Age} лет.");
    }

    // Статический - относится к самому классу Person
    public static void PrintInfo(string name, string city, int age)
    {
        Console.WriteLine($"Привет! Меня зовут {name}, я живу в городе {city} и мне {age} лет.");
    }
}