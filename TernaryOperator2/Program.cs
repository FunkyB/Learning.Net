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
(x >= y ? ref x : ref y) = 100;
Console.WriteLine($"Итогвый результат: первое число {x}, второе число {y}");