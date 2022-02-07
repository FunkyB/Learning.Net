const string AreaParam = "площадь";
const string PerimeterParam = "периметр";
Console.WriteLine("Введите первую сторону прямоугольника");
if (decimal.TryParse(Console.ReadLine(), out var firstRectangleSide))
{
    Console.WriteLine($"Первая сторона {firstRectangleSide}");
}
else
{
    Console.WriteLine("Ошибка. Ввденное значение не является длинной стороны прямоугольника");
    return;
}
Console.WriteLine("Введите вторую сторону прямоугольника");
if (decimal.TryParse(Console.ReadLine(), out var secondRectangleSide))
{
    Console.WriteLine($"Вторая сторона {secondRectangleSide}");
}
else
{
    Console.WriteLine("Ошибка. Ввденное значение не является длинной стороны прямоугольника");
    return;
}
Console.WriteLine($"Введите текстом параметр расчета \"{AreaParam}\" или \"{PerimeterParam}\"");
string? inputParam = Console.ReadLine();

if (inputParam == AreaParam)
{
    Console.WriteLine($"Выбран параметр рассчета {AreaParam}");
    decimal area = firstRectangleSide * secondRectangleSide;
    Console.WriteLine($"Площадь прямоугольника = {area}");
}
else if (inputParam == PerimeterParam)
{
    Console.WriteLine($"Выбран параметр рассчета {PerimeterParam}");
    decimal perimeter = 2 * (firstRectangleSide + secondRectangleSide);
    Console.WriteLine($"Периметр прямоугольника = {perimeter}");
}
else
{
    Console.WriteLine($"Неверная команда! {inputParam}");
}
if (firstRectangleSide == secondRectangleSide)
{
    Console.WriteLine("Данный прямоугольник – квадрат");
}