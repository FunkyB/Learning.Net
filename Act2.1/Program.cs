//Напишите программу, в которой пользователь вводит с клавиатуры 4 числа. Программа должна вывести наибольшее число и наименьшее число.
//Sample Input:
//8 11 16 20
//Sample Output:
//Наименьшее число - 8
//Наибольшее число - 20

using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int a = Convert.ToInt32(splitString[0]);
        int b = Convert.ToInt32(splitString[1]);
        int c = Convert.ToInt32(splitString[2]);
        int d = Convert.ToInt32(splitString[3]);

        int minValue = a;
        int maxValue = a;

        if (b <= minValue)
        {
            minValue = b;
        }

        if (c <= minValue)
        {
            minValue = c;
        }

        if (d <= minValue)
        {
            minValue = d;
        }

        if (b >= maxValue)
        {
            maxValue = b;
        }

        if (c >= maxValue)
        {
            maxValue = c;
        }

        if (d >= maxValue)
        {
            maxValue = d;
        }

        Console.WriteLine($"Наименьшее число - {minValue}");
        Console.WriteLine($"Наибольшее число - {maxValue}");
    }
}