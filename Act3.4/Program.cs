//Факториалом натурального числа n называют произведение всех натуральных чисел от 1 до n включительно. Напишите программу для вычисления факториала введенного пользователем числа.
//Sample Input:
//10
//Sample Output:
//3628800

using System;

public class MainClass
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}