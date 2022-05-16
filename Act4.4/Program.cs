﻿//Ваша программа так же получает на вход два числа в строковом формате, но теперь они  могут быть разной длины.
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
        num1 = GetDeduplicateList(num1);
        num2 = GetDeduplicateList(num2);
        var num1List = GetIntList(num1);
        var num2List = GetIntList(num2);
        var compareLists = num1List.Except(num2List).ToList();

        foreach (char item in compareLists)
        {
            Console.WriteLine($"Уникально число {item}");
        }
    }

    private static List<int> GetIntList(string input)
    {
        var numList = new List<int>();
        return input.Select(x => (int)x).ToList();
    }

    private static string GetDeduplicateList(string input)
    {
        var deduplicateItems = new string(
        input.GroupBy(x => x)
        .Where(x => x.Count() == 1)
        .Select(x => x.Key)
        .ToArray());
        return deduplicateItems;
    }
}