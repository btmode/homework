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

        //var x = new Dictionary<string, string>()
        //{
        //    ["kate"] = "name",
        //};

        DeleteKeysInPlace(dict, "а");
        var newDictionary = DeleteKeysWithNewDictionary(dict, "а");

        PrintDictionary(dict);
        Console.WriteLine();
        PrintDictionary(newDictionary);
    }

    private void DeleteKeysInPlace(Dictionary<string, int> dict, string key)
    {
        dict.Remove(key);
    }

    private Dictionary<string, int> DeleteKeysWithNewDictionary(Dictionary<string, int> dict, string key)
    {
        Dictionary<string, int> copy = new(dict);
        copy.Remove(key);
        return copy;
    }

    private void PrintDictionary(Dictionary<string, int> dict)
    {
        foreach (var pair in dict)
        {
            Console.Write(pair);
        }

        
    }

    private int Sum(int a, int b) => a + b;
    private int Sum(int a, int b, int c) => a + b + c;
    private void Sum(int a, int b, int c, int d)
    {
        Console.WriteLine("Слишком много аргументов");
    }
}