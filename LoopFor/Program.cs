Console.WriteLine("\n1");
for (int index = 0; index <= 100; index++)
{
    Console.Write($"{index} ");
}
Console.WriteLine("\n2");
for (int index = 1001; index <= 2500; index += 3)
{
    Console.Write($"{index} ");
}
Console.WriteLine("\n3");
for (int index = 100; index >= 0; index -= 4)
{
    Console.Write($"{index} ");
}
Console.WriteLine("\n4");
for (float index = 1; index <= 5.0; index += (float)0.2)
{
    Console.Write($"{Math.Round(index, 2)} ");
}