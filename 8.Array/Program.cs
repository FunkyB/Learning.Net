string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
int monthsCounter = 0;
Console.WriteLine("Введите название первого месяца года с заглавной буквы");
while (monthsCounter < months.Length)
{
    string? input = Console.ReadLine();
    if (input == months[monthsCounter])
    {
        monthsCounter++;
    }    
    else
    {
        bool ErrorInInputOfFiveMount = monthsCounter == 4;
        if (ErrorInInputOfFiveMount)
        {
            Console.WriteLine("Ошибка в вводе значения пятого месяца, завершение цикла");
            break;
        }
        else
        {
            Console.WriteLine("Введено неверное значение, попробуйте снова");
        }
    }    
}
if (monthsCounter == months.Length)
{
    Console.WriteLine("Введены все 12 месяцев");
}