Console.WriteLine("Введите 2 целых числа");
Console.WriteLine("Введите первое число");
bool intX = int.TryParse(Console.ReadLine(), out int x);
if (!intX)
{
    Console.WriteLine("Введено не челое число");
    return;
}
Console.WriteLine("Введите второе число");
bool intY = int.TryParse(Console.ReadLine(), out int y);
if (!intY)
{
    Console.WriteLine("Введено не челое число");
    return;
}
var start = Math.Min(x, y) + 1;
var end = Math.Max(x, y);
Console.WriteLine("Результат:");
while (start < end)
{
    if (start % 2 != 0)
    {
        Console.WriteLine(start);
    }
    start++;
}