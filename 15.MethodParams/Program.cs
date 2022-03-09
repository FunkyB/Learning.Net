Console.Write("Введите 3 целых числа: ");
int[] userInput = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Write("Введите число №{0}:\r\n", i + 1);
    userInput[i] = Convert.ToInt32(Console.ReadLine());
}
const string TrueParam = "Да";
const string FalseParam = "Нет";
bool additionalParam = true;
Console.WriteLine($"Введите значение дополинтельного параметра, допустимые значения: {TrueParam} или {FalseParam}");
string? additionalInputParam = Console.ReadLine();
switch (additionalInputParam)
{
    case TrueParam:
        additionalParam = true;
        break;
    case FalseParam:
        additionalParam = false;
        break;
    default:
        Console.WriteLine("Неправильное значение дополнительного параметра");
        break;
}
static int SummUserInput(int[] userInput)
{
    int sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum += userInput[i];
    }
    return sum;
}
static int RefIncrementSumm(ref int[] userInput)
{
    int sum = 0;
    for (int i = 0; i < 3; i++)
    {
        userInput[i]++;
        sum += userInput[i];
    }
    return sum;
}
static int ResultMethod(int[] userInput, bool additionalParam)
{
    if (additionalParam)
    {
        int result = SummUserInput(userInput);
        return result;
    }
    else
    {
        int result = RefIncrementSumm(ref userInput);
        return result;
    }
}
Console.WriteLine($"Результат выполнения метода №3: {ResultMethod(userInput, additionalParam)}");