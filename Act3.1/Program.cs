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
    //public static void Main()
    //{
    //    int firstNumber = int.Parse(Console.ReadLine());
    //    int secondNumber = int.Parse(Console.ReadLine());

    //    // Ваш код       


    //}
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        //int secondNumber = int.Parse(Console.ReadLine());

        Console.Write("\n");

        for (int i = 0; i < firstNumber; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.Write("\n");
        }
    }
}