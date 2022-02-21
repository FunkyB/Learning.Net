Console.WriteLine("Введите 2 целых числа");
Console.WriteLine("Введите первое число");
bool isValidX = int.TryParse(Console.ReadLine(), out int x);
if (!isValidX)
{
    Console.WriteLine("Введено не целое число");
    return;
}
Console.WriteLine("Введите второе число");
bool isValidY = int.TryParse(Console.ReadLine(), out int y);
if (!isValidY)
{
    Console.WriteLine("Введено не целое число");
    return;
}
var start = Math.Min(x, y) + 1;
var end = Math.Max(x, y);
Console.WriteLine("Результат:");
if (start == end)
{
    Console.WriteLine("Введеные числа равны, невозможно выполнить операцию");
    return;
}
while (start < end)
{
    if (start % 2 != 0)
    {
        Console.WriteLine(start);
    }
    start++;
}