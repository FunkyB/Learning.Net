//Дядя Вася решил устроить инвентаризацию на складе, но обнаружил, что его калькулятор лишился части кнопок.
//Остались только кнопки: "2", "3", "7", "+" и "*".
//Помогите дяде Васе и напишите метод для программы, которая выводит в консоль все возможные варианты представления исходного числа в виде a*b+c,
//используя для такой записи только имеющиеся на дяди-Васином калькуляторе символы. Варианты в консоль необходимо выводить в порядке возрастания первого множителя (a).
//Если в нескольких вариантах первые множители равны, то выводите их в порядке возрастания второго (b).
//Варианты с перестановкой множителей местами выводить в консоль не нужно.

//using System;
//using System.Collections.Generic;
//using System.Linq;
//public class MainClass
//{
//    public static void Main()
//    {
//        int number = int.Parse(Console.ReadLine());
//        VasyaStyle(number);
//    }
//}
//Sample Input:
//26478
//Sample Output:
//26478 = 33 * 732 + 2322
//26478 = 37 * 73 + 23777
//26478 = 72 * 323 + 3222

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        VasyaStyle(GetVasyaStyleNumbers(number), number);
    }

    private static bool IsVasyaStyleNumber(int number) => number.ToString().All(x => x == '2' || x == '3' || x == '7');

    private static List<int> GetVasyaStyleNumbers (int number)
    {
        var vasyaNumbers = new List<int>();
        for (int i = 0; i < number; i++)
        {
            if (IsVasyaStyleNumber(i) && !vasyaNumbers.Contains(i))
            {
                vasyaNumbers.Add(i);
            }
        }
        return vasyaNumbers;
    }

    static void VasyaStyle(List<int> vasyaNumbers, int number)
    {
        var outputNumbers = new List<int>();
        foreach (int i in vasyaNumbers)
        {
            foreach (int j in vasyaNumbers)
            {
                foreach (int z in vasyaNumbers)
                {
                    if (i * j + z == number && !outputNumbers.Contains(z))
                    {
                        outputNumbers.Add(z);
                        Console.WriteLine($"{number} = {i} * {j} + {z}");
                    }
                }
            }
        }
    }
}