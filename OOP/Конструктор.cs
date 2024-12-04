namespace OOP;

public class ConstructorTask
{
    public static void Start()
    {
        var alex = new Person("Александр", 20);
        var petr = new Person("Петр", 220);
    }
}

class Person
{
    public string Name;
    public int Age;

    // Конструктор - метод, который вызывается при создании экземпляра класса (alex)
    public Person(string name, int age)
    {
        Name = name;
        if (age < 0 || age > 120) throw new Exception("Возраст должен быть от 0 до 120");
        Age = age;
    }
}