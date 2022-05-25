//Немого изменим предыдущую задачу. Вам так же нужно написать два метода:
//Один берет числа из определенного диапазона и возвращает список тех чисел, которые кратны семи, кроме ноля
//Другой выводит в консоль через пробел значения каждого второго элемента такого списка
//Создайте их, чтобы код заработал:
//using System;
//using System.Collections.Generic;

//public class MainClass
//{
//    public static void Main()
//    {
//        int startValue = int.Parse(Console.ReadLine());
//        int endValue = int.Parse(Console.ReadLine());
//        PrintEven(GetMultiple(startValue, endValue));
//    }
//}
//Обратите внимание, что для работы с классом List<T>  здесь уже использована директива using System.Collections.Generic
//Sample Input:
//-100
//100
//Sample Output:
//-91 - 77 - 63 - 49 - 35 - 21 - 7 14 28 42 56 70 84 98

int startValue = int.Parse(Console.ReadLine());
int endValue = int.Parse(Console.ReadLine());
PrintEven(GetMultiple(startValue, endValue));

List<int> GetMultiple (int startValue, int endValue)
{
    List<int> result = new List<int>();
    for (int i = startValue; i < endValue; i++)
    {
        if (i % 7 == 0 && i != 0)
        {
            result.Add(i);
        }    
    }
    return result;
}

void PrintEven (List<int> result)
{
    for (int i = 0; i < result.Count; i++)
    {
        if (i % 2 != 0)
        {
            Console.Write($"{result[i]} ");
        }
    }
}