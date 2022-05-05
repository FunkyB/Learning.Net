//Дано два целых числа одинаковой длины. Учитывая, что метод Console.ReadLine( ) всегда возвращает строку, а строка - это массив символов,
//напишите программу, которая должна пройти по всем элементам этих чисел и сравнить их.
//Первый элемент первого числа сравнивается с первым элементом второго, и т.д. В консоль должен быть выведен ответ :
//"Совпадение n элементов", где n - количество совпавших элементов.
//Пример:
//13456
//23550
//У этих чисел одинаковые 2ой и 4ый элемент, следовательно ответ:
//"Совпадение 2 элементов"
//Sample Input:
//13456
//23550
//Sample Output:
//Совпадение 2 элементов

using System;

public class MainClass
{
    public static void Main()
    {
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();

        int[] digitsArray1 = new int[num1.Length];
        for (int i = 0; i < num1.Length; i++)
        {
            digitsArray1[i] = Convert.ToInt32(Char.GetNumericValue(num1[i]));
        }

        int[] digitsArray2 = new int[num2.Length];
        for (int i = 0; i < num2.Length; i++)
        {
            digitsArray2[i] = Convert.ToInt32(Char.GetNumericValue(num2[i]));
        }
        int counter = 0;        
        for (int i = 0; i < digitsArray1.Length; i++)
        {
            if (digitsArray1[i] == digitsArray2[i])
            {
                counter++;
            }
        }
        Console.WriteLine($"Совпадение {counter} элементов");
    }
}