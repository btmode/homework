namespace Dictionary;

class DeletKeyTask
{
    public void Start()
    {
        var dict = new Dictionary<string, int>()
        {
            ["а"] = 1,
            ["б"] = 2,
            ["в"] = 3,
            ["г"] = 4,
        };

        var deletKeys = new DeletKeys(dict, "а");
    }
}

class DeletKeys
{
    private Dictionary<string, int> _dictionary { get; set; } = new Dictionary<string, int>();
    public DeletKeys(Dictionary<string, int> dict, string key)
    {
        _dictionary = new Dictionary<string, int>(dict);
        _dictionary = DeletKey(key);
    }
    private Dictionary<string, int> DeletKey(string key)
    {
        if (_dictionary.ContainsKey(key))
        {
            _dictionary.Remove(key);
        }

        foreach (var keys in _dictionary)
        {
            Console.Write(keys);
        }
        return _dictionary;
    }
}