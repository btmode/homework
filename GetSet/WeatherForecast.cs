namespace GetSet;

public class WeatherForecastTask
{

    public static void Start()
    {

        var weather1 = new WeatherForecast("Москва");
        var weather2 = new WeatherForecast("Лондон");

        Console.Write($"Город: {weather1.City}, Погода: {weather1.Title}, температура: {weather1._temperature} , влажность: {weather1._humidity}\n");
        Console.Write($"Город: {weather2.City}, Погода: {weather2.Title}, температура: {weather2._temperature} , влажность: {weather2._humidity}\n");
    }
}
// _temperature, _humidity - генерировать
// GetTitle - переделать на свойство Title
// В конструктор передавать название города.
// Для города Х должны быть параметры _temperature и _humidity Y и Z соответственно.
class WeatherForecast
{
    public int _temperature;
    public int _humidity;


    public string City { get; }

    public string? Title
    {
        get
        {
            if (_temperature > 25 && _humidity > 60)
                return "Жарко и влажно";
            else if (_temperature > 25 && _humidity <= 60)
                return "Жарко и сухо";
            else if (_temperature <= 25 && _humidity > 60)
                return "Холодно и влажно";
            else
                return "Холодно и сухо";
        }
    }

    private Dictionary<char, (int temperature, int humidity)> dictonary = new()
        {
           { 'а', (3, 3) }, { 'A', (3, 3) },
           { 'б', (3, 1) }, { 'Б', (3, 1) },
           { 'в', (5, 2) }, { 'В', (5, 2) },
           { 'г', (5, 2) }, { 'Г', (5, 2) },
           { 'д', (4, 3) }, { 'Д', (4, 3) },
           { 'е', (5, 1) }, { 'Е', (5, 1) },
           { 'ё', (5, 2) }, { 'Ё', (5, 2) },
           { 'ж', (2, 4) }, { 'Ж', (2, 4) },
           { 'з', (5, 1) }, { 'З', (5, 1) },
           { 'и', (2, 3) }, { 'И', (2, 3) },
           { 'й', (2, 3) }, { 'Й', (2, 3) },
           { 'к', (2, 4) }, { 'К', (2, 4) },
           { 'л', (1, 4) }, { 'Л', (1, 4) },
           { 'м', (3, 1) }, { 'М', (3, 1) },
           { 'н', (5, 5) }, { 'Н', (5, 5) },
           { 'о', (4, 3) }, { 'О', (4, 3) },
           { 'п', (5, 2) }, { 'П', (5, 2) },
           { 'р', (4, 1) }, { 'Р', (4, 1) },
           { 'с', (1, 3) }, { 'С', (1, 3) },
           { 'т', (4, 3) }, { 'Т', (4, 3) },
           { 'у', (5, 1) }, { 'У', (5, 1) },
           { 'ф', (4, 2) }, { 'Ф', (4, 2) },
           { 'х', (2, 3) }, { 'Х', (2, 3) },
           { 'ц', (2, 3) }, { 'Ц', (2, 3) },
           { 'ч', (2, 2) }, { 'Ч', (2, 2) },
           { 'ш', (2, 3) }, { 'Ш', (2, 3) },
           { 'щ', (2, 3) }, { 'Щ', (2, 3) },
           { 'ъ', (3, 2) }, { 'Ъ', (3, 2) },
           { 'ы', (5, 1) }, { 'Ы', (5, 1) },
           { 'ь', (1, 4) }, { 'Ь', (1, 4) },
           { 'э', (3, 2) }, { 'Э', (3, 2) },
           { 'ю', (3, 1) }, { 'Ю', (3, 1) },
           { 'я', (1, 3) }, { 'Я', (1, 3) },
        };

    public WeatherForecast(string city)
    {
        City = city;
        (_temperature, _humidity) = GenerateWeatherData(city);
    }

    private (int _temperature, int _humidity) GenerateWeatherData(string city)
    {
        int temp = 0;
        int humid = 0;

        foreach (char c in city)
        {
            if (dictonary.TryGetValue(c, out var values))
            {
                temp += values.temperature;
                humid += values.humidity * 2;
            }
        }
        temp = temp % 40;
        humid = humid % 100;

        return (temp, humid);
    }
}






