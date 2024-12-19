namespace GetSet;
class WeatherForecast
{
    public static int _temperature = 98;
    public static int _humidity = 73;
    public static string _weatherContition;
    public static void Start()
    {

        _weatherContition = GetWeatherTitle(_temperature, _humidity);
        Console.WriteLine(_weatherContition);



    }

    public static string GetWeatherTitle(int _temperature, int _humidity)
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



