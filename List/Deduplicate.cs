using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace ListMassive
{
    internal class DeduplicateTask
    {
        public static void FillList(List<int> list)
        {
            var rnd = new Random();
            Console.WriteLine("Длинна List: ");
            var lenght = int.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                list.Add(rnd.Next(1, 20));
            }

            Console.WriteLine(string.Join(", ", list));
        }

        public static void Deduplicate(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(i);
                    }
                }
            }
        }

        public static void Start(string[] args)
        {
            var list = new List<int>();

            FillList(list);
            Deduplicate(list);

            Console.WriteLine(string.Join(", ", list));
        }
    }
}