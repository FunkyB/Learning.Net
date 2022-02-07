Console.WriteLine("Введите 2 вещественных числа");
Console.WriteLine("Введите первое число");
float firstInputNumber = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Введите второе число");
float secondInputNumber = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Выберете арифметическую операцию \"+\" \"-\" \"*\" \"/\"");
string? arithmeticOperation = Console.ReadLine();
const string Addition = "+", Subtraction = "-", Multiplication = "*", Division = "/";
float result;
switch (arithmeticOperation)
{
    case Addition:
        {
            result = firstInputNumber + secondInputNumber;
            Console.WriteLine(result);
            break;
        }
    case Subtraction:
        {
            result = firstInputNumber - secondInputNumber;
            Console.WriteLine(result);
            break;
        }
    case Multiplication:
        {
            result = firstInputNumber * secondInputNumber;
            Console.WriteLine(result);
            break;
        }
    case Division:
        {
            bool deviderNotNull = secondInputNumber != 0;
            if (deviderNotNull)
            {
                result = firstInputNumber / secondInputNumber;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            break;
        }
    default:
        {
            Console.WriteLine("Неподходящий символ");
            break;
        }
}