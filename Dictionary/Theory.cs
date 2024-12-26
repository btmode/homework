namespace Dictionary
{
    internal class Theory
    {
        static void Start()
        {
            //var person = {
            //    name: "A",
            //    id: 1,
            //    title: "T"
            //};

            // var phones = {
            //    alex: "809458092345",
            //    mike: "453234234234",
            //    kate: "12312345"
            // };

            //var dictionary = new Dictionary<string, string>();
            //dictionary["alex"] = "809458092345";
            //dictionary["mike"] = "453234234234";
            //dictionary["kate"] = "12312345";

            ////dictionary.Add("alex", "new phone");
            //dictionary["alex"] = "new phone";

            ////Console.WriteLine(dictionary["alexx"]);
            //Console.WriteLine(dictionary.TryGetValue("alexx", out var result));
            
            //Sum(1, 2, out var b);

            //Console.WriteLine(b);

        }

        private static void Sum(int a, int b, out int result)
        {
            result = a + b;

            //var success = int.TryParse("asd", out var x);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
    }

    class Phones
    {
        public string Alex { get; set; }
        public string Mike { get; set; }
        public string Kate { get; set; }
    }
}
