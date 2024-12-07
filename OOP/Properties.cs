namespace OOP;

public class Properties
{
    public static void Start()
    {
        var person = new Person();
        
        // person.SetAge(-20);
        person.Age = -20;
        
        // Console.WriteLine(person.GetAge());
        Console.WriteLine(person.Age);
    }
    
    public static int Sum1(int a , int b)
    {
        return a + b;
    }

    public static int Sum2(int a, int b) => a + b;
    public static void PrintHello() => Console.WriteLine("Hello");
}

// 2-ой вариант
class Person
{
    // Поле
    private int _age;

    // Свойство
    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value < 0 || value > 120)
                Console.WriteLine("Возраст должен быть от 0 до 120");
            else
                Age = value;
        }
    }

    private string _name;
    // Здесь реализовано 2 метода
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    
    public string _city;
    public string City
    {
        get => _city;
        set => _city = value;
    }
}

// 1-ый вариант
// class Person
// {
//     private int Age;
//
//     public void SetAge(int age)
//     {
//         if (age < 0 || age > 120)
//             Console.WriteLine("Возраст должен быть от 0 до 120");
//         else
//             Age = age;
//     }
//     
//     public int GetAge()
//     {
//         return Age;
//     }
// }