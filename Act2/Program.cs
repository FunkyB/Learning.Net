//Напишите программу, в которой пользователь вводит с клавиатуры три числа. Программа должна вывести минимальное значение из представленных.
//При написании кода учитывайте, что числа могут быть одинаковыми. Необходимо писать общее решение для всех случаев

//Sample Input:
//8 11 28
//Sample Output:
//8

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

        int minValue = a;

        if(b <= minValue)
        {
            minValue = b;
        }
        if(c <= minValue)
        {
            minValue = c;
        }

        Console.WriteLine(minValue);
    }
}