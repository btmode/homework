using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class GetSetTask
    {
        public static void GetSetTask()
        {
            var milk = new Product() { Name = "Молоко", Price = 10 };
            var bread = new Product() { Name = "Хлеб", Price = 5 };

            var products = new List<Product>() { milk, bread };

            var order = new Order();
            order.Items = products; // value = products

            var milks = new List<Product> { milk, milk, milk };
            order.Items = milks;  // value = milks

            Console.WriteLine(order.TotalCost); // Должно вывести 15

            // value - это то значение, которое мы хотим положить в поле
        }

        public class Order
        {
            public int TotalCost = 0;

            private List<Product> _items;

            public List<Product> Items
            {
                get => _items;
                set
                {
                    _items = value;
                    foreach (var item in value)
                    {
                        TotalCost += item.Price;
                    }
                }
            }

            public int Sum()
            {
                var sum = 0;
                var nums = new int[] { 6, 4, 0 };

                //for (int i = 0; i < nums.Length; i++)
                //{
                //   sum += nums[i];
                //}
                foreach (var item in nums)
                {
                    sum += item;
                }
                return sum;
            }
        }

        public class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
    }
}
