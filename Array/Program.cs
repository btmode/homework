// for (var i = 1; i <= 9; i++)
// {
//     for (var j = 1; j <= 9; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
// }

var photo = 1;

Console.WriteLine(photo); // 1
ChangeN(ref photo);
Console.WriteLine(photo); // 2

var x = 1;
var y = 2;

var z = x; // 1
z = y; // 2

Sum(x, y);

void ChangeN(ref int n)
{
    n = 2;
}

void Sum(int a, int b)
{
    Console.WriteLine(a + b);
}