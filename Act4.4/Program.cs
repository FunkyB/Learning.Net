//Ваша программа так же получает на вход два числа в строковом формате, но теперь они  могут быть разной длины.
//Найдите все уникальные элементы первого числа (значения, которые встречаются  только 1 раз в обоих массивах)
//Пример:
//12335
//1458
//В данном случае уникально число 2 - оно существует в одном экземпляре
//1 и 5 есть во втором массиве, а 3 встречается дважды в первом
//В итоге ответ:
//"Уникально число 2"
//Sample Input:
//12335
//1458
//Sample Output:
//Уникально число 2

using System;

public class MainClass
{
    public static void Main()
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();

        int count = 0;

        foreach (var c in num1)
        {
            foreach (var n in num2)
            {
                if (c == n)
                {
                    count++;
                    break;
                }
                Console.WriteLine($"Уникально число {c}");
                break;
            }
        }
    }
}