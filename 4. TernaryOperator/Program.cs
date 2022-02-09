Console.WriteLine("Введите 2 целых числа");
Console.WriteLine("Введите первое число");
bool intX = int.TryParse(Console.ReadLine(), out int x);
if (!intX)
{
    Console.WriteLine("Введено не челое число");
    return;
}
bool isEvenX = true ? x % 2 == 0 : x % 2 != 0;
Console.WriteLine($"Четное число - {isEvenX}");
if (!isEvenX) x++;
Console.WriteLine("Введите второе число");
bool intY = int.TryParse(Console.ReadLine(), out int y);
if (!intY)
{
    Console.WriteLine("Введено не челое число");
    return;
}
bool isEvenY = true ? y % 2 == 0 : y % 2 != 0;
Console.WriteLine($"Четное число - {isEvenY}");
if (!isEvenY) y++;
string result = (x + y) % 4 == 0 ? $"Сумма значений {x} и {y} делится на 4" : $"Сумма значений {x} и { y} на 4 не делится";
Console.WriteLine(result);