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
        VasyaStyle(number);
    }

    private static bool IsVasyaStyleNumber(int number) => number.ToString().All(x => x == '2' || x == '3' || x == '7');

    static void VasyaStyle(int number)
    {
        //List<int> outputNumbers = new List<int>();
        for (int i = 1; i < number; i++)
        {
            if (IsVasyaStyleNumber(i))
            {
                for (int j = 1; j < number; j++)
                {
                    if (IsVasyaStyleNumber(j))
                    {
                        for (int z = 1; z < number; z++)
                        {
                            if (IsVasyaStyleNumber(z) && i * j + z == number)
                            {
                                Console.WriteLine($"{number} = {i} * {j} + {z}");
                            }
                        }
                    }
                }
            }
        }
    }
}