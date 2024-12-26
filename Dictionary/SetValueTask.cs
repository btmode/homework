using System.Collections.Generic;

namespace Dictionary;
class SetValueTask
{
    private Dictionary<string, string> _dictionary { get; set; } = new Dictionary<string, string>();
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
                if (choice == 2)
                {
                    SearchByKey(); break;
                }
                if (choice == 3)
                {
                    PrintDictionary(); break;
                }
                if (choice == 4)
                {
                    Console.Write("Вы вышли!"); return;

                }

            }
            else
            {
                Console.Write("Некоректно" + Environment.NewLine);
            }

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
        string key = Console.ReadLine();

        Console.Write("Введите значение: ");
        string value = Console.ReadLine();

        if (_dictionary.ContainsKey(key) == false)
        {
            _dictionary[key] = value;
        }
        else
        {
            Console.Write("Такой key уже есть." + Environment.NewLine);


        }

    }

    private void PrintDictionary()
    {
        var count = 0;
        foreach (var elDict in _dictionary)
        {
            count++;
            if (_dictionary != null)
            {
                Console.Write($"Элемент{count}: {elDict}\n");
            }
            else
            {
                Console.Write("У вас пустые правила!"); return;
            }
        }
    }
    private void SearchByKey()
    {
        Console.Write("Введите ключ для поиска: ");
        string key = Console.ReadLine();

        if (_dictionary.ContainsKey(key))
        {
            Console.WriteLine($"Значение для ключа: {key}: {_dictionary[key]}");
        }
        else
        {
            Console.WriteLine($"Ключ {key} не найден в словаре.");
            Console.WriteLine($"Вы можете добавить если нажмете 4");
        }
    }
}

