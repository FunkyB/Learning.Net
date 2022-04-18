﻿//Гипотеза Сиракуз утверждает, что любое натуральное число сводится к единице в результате повторения следующих действий над самим числом и результатами этих действий.
//Если число четное следует разделить его на 2. Если нечетное, то умножить его на 3, прибавить 1.
//В попытке доказать эту гипотезу, Лотар Коллатц написал программу, но так как он привык программировать на Java, а не на С#,
//и вообще он математик, а не программист, он допустил в ней некоторые ошибки. Найдите и исправьте эти ошибки и помогите справиться с нерешенной проблемой математики.
//Sample Input:
//555
//Sample Output:
//1

using System;

public class MainClass
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        while (number > 1)
        {
            if (number % 2 == 0)
            {
                number /= 2;
            }
            else
            {
                number = number * 3 + 1;
            }
        }
        Console.WriteLine(number);
    }
}