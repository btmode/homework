﻿int[] array = [1, 2, 3];

Console.WriteLine(array);

foreach (var x in array)
{
    Console.WriteLine(x);
}

Console.WriteLine(string.Join(", ", array));