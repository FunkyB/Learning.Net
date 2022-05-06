//В консоль вводится строка с определенной последовательностью чисел. Числа введены через пробел.
//Доработайте программу, которая считает сумму всех четных чисел в этой последовательности.
//Sample Input:
//1 2 3 4 5 6 7 8 9 10
//Sample Output:
//30

using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] array = line.Split(' ');
        int[] numbers = new int[array.Length];
        int summ = 0;
        for (int i = 0; i < array.Length; i++)
        {
            numbers[i] = int.Parse(array[i]);

            if (numbers[i] % 2 == 0)
            {
                summ += numbers[i];
            }
        }
        Console.WriteLine(summ);
    }
}