//Напишите программу, в которой пользователь вводит с клавиатуры число от 0 до 5. Программа должна вывести счёт от введённого числа и до 5.
//Sample Input:
//3
//Sample Output:
//3
//4
//5

using System;

public class MainClass
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 0:
                Console.WriteLine("0");
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");
                Console.WriteLine("5");
                break;

            case 1:
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");
                Console.WriteLine("5");
                break;

            case 2:
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("4");
                Console.WriteLine("5");
                break;

            case 3:
                Console.WriteLine("3");
                Console.WriteLine("4");
                Console.WriteLine("5");
                break;

            case 4:
                Console.WriteLine("4");
                Console.WriteLine("5");
                break;

            case 5:
                Console.WriteLine("5");
                break;

            default:
                Console.WriteLine("Введите значение от 0 до 5");
                break;
        }
    }
}