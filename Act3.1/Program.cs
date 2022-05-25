//В консоль вводятся два числа. В обоих числах есть одна общая цифра.
//Выведите в консоль цифру, которая есть в обоих числах через пробел столько раз, сколько раз она встречается в первом числе.
//Sample Input:
//76652
//63416
//Sample Output:
//6 6

using System;

public class MainClass
{
    public static void Main()
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();
        int splitSize = 1;
        int stringLength = firstNumber.Length;
        int secondStringLength = secondNumber.Length;

        for (int i = 0; i < stringLength; i += splitSize)
        {
            for (int j = 0; j < secondStringLength; j++)
            {
                if (firstNumber.Substring(i, splitSize) == secondNumber.Substring(j, splitSize))
                {
                    Console.Write($"{firstNumber.Substring(i, splitSize)} ");
                    break;
                }
            }
        }
    }
}