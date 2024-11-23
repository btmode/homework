using System.Reflection.Metadata;
using System.Security.Cryptography;
namespace ListMassive
{
    internal class RemoveDublicatEl
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
        public static void RemoveDublcat(List<int> list)
        {
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.RemoveAt(i);

                    }
                }
                Console.Write(list[i] + " ");
            }

        }
        static void Main(string[] args)
        {
            var list = new List<int>();

            FillList(list);
            RemoveDublcat(list);

        }
    }
}
