namespace Dictionary;
class SetValueTask 
{

    private Dictionary<string, string> _dictionary { get; set; } = [];
    private List<string> _list { get; set; } = [];
    private int[] _array { get; set; } = [];

    public void Start()
    {
        while (true)
        {
            ShowMenu();
            if (int.TryParse(Console.ReadLine(), out var choice) && choice < 5)
            {
                if (choice == 1)
                {
                    SetValue();
                }
                else if (choice == 2)
                {
                    SearchByKey();
                }
                else if (choice == 3)
                {
                    PrintDictionary();
                }
                else if (choice == 4)
                {
                    Console.Write("Вы вышли!"); return;
                }
            }
            else { Console.Write("Некорректно"); }
        }
    }
    private void ShowMenu()
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1 - Добавить или обновить запись");
        Console.WriteLine("2 - Найти значение по ключу");
        Console.WriteLine("3 - Вывести весь словарь");
        Console.WriteLine("4 - Выйти");
        Console.Write("Сделайте действие: ");
    }
    private void SetValue()
    {
        Console.Write("Введите ключ: ");     
        var key = Console.ReadLine();

        Console.Write("Введите значение: ");       
        var value = Console.ReadLine();

        if (!_dictionary.ContainsKey(key))
        {
            _dictionary[key] = value;
        }
        else { Console.Write("Такой key уже есть."); }
    }

    private void PrintDictionary()
    {
        var count = 0;
        foreach (var el in _dictionary)
        {
            count++;           
            Console.WriteLine($"Элемент {count}: {el}");          
        }
    }
    private void SearchByKey()
    {
        Console.Write("Введите ключ для поиска: ");        
        var key = Console.ReadLine();

        if (_dictionary.ContainsKey(key))
        {
            Console.WriteLine($"Значение для ключа: {key}: [{_dictionary[key]}]");
        }
        else
        {
            Console.WriteLine($"Ключ {key} не найден в словаре.");
            Console.WriteLine($"Вы можете добавить если нажмете 4");
        }
    }
}

