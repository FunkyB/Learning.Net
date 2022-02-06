//Пользователь вводит 4 числа. Найти наибольшее четное. Если такого нет – вывести «Not found».  
//Если есть – вывести его. (Решите задачу с использованием условных конструкций)  

Console.WriteLine("Введите подряд 3 числа");
Console.WriteLine("Введите первое");

int firstNumber;
firstNumber = Convert.ToInt32(Console.ReadLine());
bool isEvenFirstNumber = (firstNumber % 2) == 0;

Console.WriteLine("Введите второе");
int secondNumber;
secondNumber = Convert.ToInt32(Console.ReadLine());
bool isEvenSecondNumber = (secondNumber % 2) == 0;

Console.WriteLine("Введите третье");
int thirdNumber;
thirdNumber = Convert.ToInt32(Console.ReadLine());
bool isEvenThirdNumber = (thirdNumber % 2) == 0;

if (isEvenFirstNumber)
{
    if (isEvenSecondNumber)
    {
        if (isEvenThirdNumber)
        {
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"Максимальное четное число = {firstNumber}");
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"Максимальное четное число = {secondNumber}");
            }
            else
            {
                Console.WriteLine($"Максимальное четное число = {thirdNumber}");
            }
        }

    }
}
else if (isEvenSecondNumber)
{
    if (isEvenThirdNumber)
    {
        if (secondNumber > thirdNumber)
        {
            Console.WriteLine($"Максимальное четное число = {secondNumber}");
        }
        else
        {
            Console.WriteLine($"Максимальное четное число = {thirdNumber}");
        }
    }
}
else if (isEvenThirdNumber)
{
    Console.WriteLine($"Максимальное четное число = {thirdNumber}");
}
else
{
    Console.WriteLine("«Not found");
}



//Console.WriteLine("Введите второе");
//int fourthNumber;
//fourthNumber = Convert.ToInt32(Console.ReadLine());
