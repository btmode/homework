var alex = new Person() { Age = 20, City = "Moscow", Name = "Alex" };
var john = new Person() { Age = 30, City = "New York", Name = "John" };
var max = new Person() { Age = 40, City = "London", Name = "Max" };

john.PrintInfo();
Person.StaticPrintInfo("John", "New York", 30);

var operations = new Operations();
// operations.Sum(1, 2);

// статический метод - тот метод, для которого не нужно создавать экземпляр
Operations.Sum(1, 2);

operations.Sub(1, 2);

var operations2 = new Operations();

Operations.Sum(1, 2);

class Person
{
    public string Name;
    public string City;
    public int Age;

    private string GetPrintString()
    {
        return $"Name: {Name}, City: {City}, Age: {Age}";
    }

    public void PrintInfo()
    {
        // this - тот объект, у кого вызвали этот метод
        // Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine(GetPrintString());
    }

    public static void StaticPrintInfo(string name, string city, int age)
    {
        Console.WriteLine();
    }
}

class Operations
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    public int Sub(int a, int b)
    {
        return a - b;
    }
}