//И снова строка с последовательностью чисел, но на это раз вам необходимо написать программу, которая выводит в консоль наименьшее и наибольшее значение.
//В исходной последовательности есть как минимум два различных числа. Для начала преобразуйте ее в целочисленный массив, используя алгоритм из предыдущего задания
//Sample Input:
//2 0 5 1 1
//Sample Output:
//Наименьшее значение = 0
//Наибольшее значение = 5

using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] stringArray = line.Split(" ");
        int[] intArray = Array.ConvertAll(stringArray, int.Parse);

        Console.WriteLine($"Наименьшее значение = {intArray.Min()}");
        Console.WriteLine($"Наибольшее значение = {intArray.Max()}");
    }
}