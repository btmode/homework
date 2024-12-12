using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace OOP;

//class _Person
//{
//    // Свойство = private поле + 2 public метода (1 на получение этого поля, другой на установку значения)

//    private string _name;

//    public string GetName()
//    {
//        return _name;
//    }

//    public void SetName(string newName)
//    {
//        _name = newName;
//    }
//}

class _Test
{
    public static void Test()
    {
        //var person = new _Person();
        //person.SetName("John");
        //Console.WriteLine(person.GetName());

        //var person = new _Person();

        //person.Name = "John";

        //Console.WriteLine(person.Name);

        var person = new _Person();

        person.NameProperty = "name"; // value="name"
        person.NameField = "name";

        Console.WriteLine(person.NameProperty);
        Console.WriteLine(person.NameField);

        var vasya = new Pupil() { Name = "Вася" };
        vasya.Name = "Вася";

        vasya.Marks = [-400, 15];
        vasya.Marks = [2, 15, -1000000];

        var pety = new Pupil();
        pety.Name = "петя";

        pety.Marks = [4, 1];

    }
}
// Ctrl + KD

class Pupil
{
    //private string _name;
    //public string Name
    //{
    //    get => _name;
    //    set => _name = value;
    //}

    public string Name { get; set; }

    private int[] _marks;
    public int[] Marks
    {
        get => _marks;
        set
        {
            foreach (int mark in value)
            {
                if (mark < 2 || mark > 5)
                {
                    throw new Exception("Неправильная оценка");
                }
            }
            _marks = value;
        }

    }

    class _Person
    {
        public string NameProperty { get; set; }
        public string NameField;

        public string City { get; set; }

        public int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Возраст не может быть отрицательным");
                }
                _age = value;
            }
        }

        public void Test()
        {

        }
    }




//class _Person
//{
//    // Свойство = private поле + 2 public метода (1 на получение этого поля, другой на установку значения)
//    private string _name;

//    public string NameProperty
//    {
//        get
//        {
//            return _name;
//        }
//        set
//        {
//            _name = value;
//        }
//    }

//    public string NameField;
//}


//class _Person
//{
//    // Свойство = private поле + 2 public метода (1 на получение этого поля, другой на установку значения)

//    private string _name;

//    public string Name
//    {
//        get
//        {
//            Console.WriteLine("Кто-то пытается получить значение Name");
//            return _name;
//        }
//        set
//        {
//            Console.WriteLine("Кто-то пытается изменить значение Name");
//            var MAX_NAME_LENGTH = 40;

//            if (value.Length > MAX_NAME_LENGTH)
//                value = value.Substring(0, MAX_NAME_LENGTH);

//            _name = value;
//        }  
//    }
//}

//class _Person
//{
//    // Свойство = private поле + 2 public метода (1 на получение этого поля, другой на установку значения)

//    private string _name = "Alex";

//    public string GetName()
//    {
//        return _name;
//    }

//    public void SetName(string newName)
//    {
//        var MAX_NAME_LENGTH = 40;

//        if (newName.Length > MAX_NAME_LENGTH)
//            newName = newName.Substring(0, MAX_NAME_LENGTH);

//        _name = newName;
//    }
//};





