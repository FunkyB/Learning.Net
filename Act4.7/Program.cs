//Задача повышенной сложности
//Реализовать сортировку пузырьком для последовательности целых чисел.
//Последовательность произвольной длины, но содержит не менее двух элементов.
//В консоль надо вывести все значения через пробел, отсортированные в порядке возрастания.

//Sample Input:
//2 45 17 9
//Sample Output:
//2 9 17 45

using System;

public class MainClass
{
    public static void Main()
    {
        string line = Console.ReadLine();
        string[] stringArray = line.Split(' ');
        
        int[] array = new int[stringArray.Length];
        for (int i = 0; i < stringArray.Length; i++)
        {
            array[i] = int.Parse(stringArray[i]);
        }

        int temp;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}