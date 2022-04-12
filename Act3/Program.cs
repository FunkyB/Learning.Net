//Напишите программу, которая считает сумму всех простых чисел в определенном диапазоне.
//Простое число - целое положительное число, имеющее ровно два различных натуральных делителя - единицу и самого себя.
//Число 1 не является ни простым, ни составным числом, так как у него только один делитель - 1.
//Sample Input:
//-100
//100
//Sample Output:

//Сумма простых чисел = 1060

using System;

public class MainClass
{
    public static void Main()
    {
        int startValue = int.Parse(Console.ReadLine());
        int endValue = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int number = startValue; number < endValue; ++number)
        {
            if (number == 2)
            {
                sum += number;
                continue;
            }
            if (number % 2 == 0 || number <= 1) continue;

            bool isPrimeNumber = true;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    isPrimeNumber = false;
                    break;
                }
            }

            if (isPrimeNumber)
            {
                sum += number;
            }
        }
        Console.WriteLine($"Сумма простых чисел = {sum}");
    }
}