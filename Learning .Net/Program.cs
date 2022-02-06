decimal firstRectangleSide, secondRectangleSide;
Console.WriteLine("Введите первую сторону прямоугольника");
if (decimal.TryParse(Console.ReadLine(), out firstRectangleSide))
{
    Console.WriteLine($"Первая сторона {firstRectangleSide}");
}
else
{
    Console.WriteLine("Ошибка. Ввденное значение не является длинной стороны прямоугольника");
    return;
}
Console.WriteLine("Введите вторую сторону прямоугольника");
if (decimal.TryParse(Console.ReadLine(), out secondRectangleSide))
{
    Console.WriteLine($"Вторая сторона {secondRectangleSide}");
}
else
{
    Console.WriteLine("Ошибка. Ввденное значение не является длинной стороны прямоугольника");
    return;
}
Console.WriteLine("Введите текстом параметр расчета \"площадь\" или \"периметр\"");
const string areaParam = "площадь",
             perimeterParam = "периметр";
bool rectangleIsSquare = firstRectangleSide == secondRectangleSide;
string? inputParam = Console.ReadLine();

if (inputParam == areaParam)
{
    Console.WriteLine($"Выбран параметр рассчета {areaParam}");
    decimal area = firstRectangleSide * secondRectangleSide;
    Console.WriteLine($"Площадь прямоугольника = {area}");
}
else
    if (inputParam == perimeterParam)
{
    Console.WriteLine($"Выбран параметр рассчета {perimeterParam}");
    decimal perimeter = 2 * (firstRectangleSide + secondRectangleSide);
    Console.WriteLine($"Периметр прямоугольника = {perimeter}");
}
else
{
    Console.WriteLine($"Неверная команда! {inputParam}");
}
if (rectangleIsSquare)
{
    Console.WriteLine("Данный прямоугольник – квадрат");
}