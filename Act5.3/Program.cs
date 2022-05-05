//В следующей программе уже готов метод Main, но для корректной работы кода от вас требуется создать еще два метода:
//Один берет числа в определенном диапазоне (включая начальное и конечное значение) и возвращает массив, заполненный кубами этих чисел
//Другой выводит в консоль сумму всех элементов массива

//public static void Main()
//{
//    int startValue = int.Parse(Console.ReadLine());
//    int endValue = int.Parse(Console.ReadLine());
//    PrintSum(GetCubes(startValue, endValue));
//}
//Напишите методы GetCubes и PrintSum

//Sample Input:
//-9
//11
//Sample Output:
//2331

int startValue = int.Parse(Console.ReadLine());
int endValue = int.Parse(Console.ReadLine());
PrintSum(GetCubes(startValue, endValue));

int [] GetCubes (int startValue, int endValue)
{
    Range range = new Range(startValue, endValue);
    int counter = 0;
    int[] array = new int[22];
    for (int i = startValue; i <= endValue; i++)
    {
        //array[i] = Math.Pow(i, 3);
        counter++;
    }

    
    for (int i = 0; i <= counter; i++)
    {
        array[i] = (int)Math.Pow(i, 3);
    }
    return array;
}

void PrintSum (int [] sum)
{
    Console.WriteLine(sum);
}