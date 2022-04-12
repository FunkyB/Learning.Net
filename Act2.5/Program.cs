//Напишите программу, в который пользователь вводит цифру от 1 до 31. То есть день месяца.
//Учитывая что 1 число, это понедельник, программа должна выводить какой сегодня день недели. Примеры вывода для копирования
//"Понедельник"
//"Вторник"
//"Среда"
//"Четверг"
//"Пятница"
//"Суббота"
//"Воскресенье"
//Sample Input:
//16
//Sample Output:
//Вторник

using System;

public class MainClass
{
    public static void Main()
    {
        while (true)
        {
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            if (dayNumber > 0 && dayNumber <= 31)
            {
                switch (dayNumber % 7)
                {
                    case 1:
                        Console.WriteLine("Понедельник");
                        break;

                    case 2:
                        Console.WriteLine("Вторник");
                        break;

                    case 3:
                        Console.WriteLine("Среда");
                        break;

                    case 4:
                        Console.WriteLine("Четверг");
                        break;

                    case 5:
                        Console.WriteLine("Пятница");
                        break;

                    case 6:
                        Console.WriteLine("Суббота");
                        break;

                    case 0:
                        Console.WriteLine("Воскресенье");
                        break;
                }
            }
        }
    }
}