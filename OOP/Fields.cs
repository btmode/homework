using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    enum Direction
    {
        Up = 0,
        Down = 1,
        Left = 2,
        Right = 3,
    }

    internal class Fields
    {
        public static int _a;

        public static void Test(int a)
        {
            _a = a;
            //var x = 1;
            //new Employee() { position = "сеекреарть" };
            //new Game() { side = 0 };
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.Red;

            //if (side == 0)
            //{

            //}


        }

        public static void Test2()
        {
            Console.WriteLine(_a);
        }
    }

    class Employee
    {
        public string position;

        public static void Test()
        {

            Fields.Test(12);

        }
    }
}
