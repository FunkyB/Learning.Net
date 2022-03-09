//Напишите программу, в которой создайте три метода.
//Первый метод - принимает три целых числа и возвращает сумму этих чисел.
//Второй метод принимает три целочисленных ref параметра, увеличивает каждый из
//полученных параметров на единицу, а затем возвращает сумму этих увеличенных
//значений.
//Третий метод в качестве параметров принимает три целых числа и булево значение,
//и возвращает целочисленное значение. Если булевый параметр содержит значение
//true – третий метод вызовет метод №1 и передаст ему значения своих числовые
//параметров, иначе - если булевый параметр содержит значение false - третий метод
//в своем теле вызовет метод №2 и передаст ему свои числовые параметры.
//Выведите на экран результат выполнения метода №3 и значение его параметров.

Console.Write("Введите 3 целых числа: ");
int[] userInput = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Write("Введите число №{0}:\r\n", i + 1);
    userInput[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите значение дополинтельного параметра, допустимые значения: \"Да\" или \"Нет\"");
const string TrueParam = "Да";
const string FalseParam = "Нет";
bool additionalInputParam = true 
    ? Console.ReadLine() == TrueParam 
    : Console.ReadLine() == FalseParam;
if (additionalInputParam) != TrueParam || FalseParam
static int SummUserInput(int[] userInput)
{
    int sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum += userInput[i];                
    }    
    return sum;
}
Console.WriteLine($"Сумма введеных чисел: {SummUserInput(userInput)}");

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
Console.WriteLine($"Сумма введеных чисел: {RefIncrementSumm(ref userInput)}");

static int Method3(int[] userInput, bool additionalParam)
{
    if (additionalParam)
    {
        SummUserInput(userInput);
    }
    else
    {
        RefIncrementSumm(ref userInput);
    }
}