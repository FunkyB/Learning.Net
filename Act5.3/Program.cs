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

//посчитать кол-во элементов для массива
//создать массив
//заполнить массив изначальными значениями (сразу с возведением в куб)

int startValue = int.Parse(Console.ReadLine());
int endValue = int.Parse(Console.ReadLine());
PrintSum(GetCubes(startValue, endValue));

int [] GetCubes (int startValue, int endValue)
{
    int counter = 0;
    for (int i = startValue; i <= endValue; i++)
    {
       counter++;
    }

    int[] array = new int[counter];
    for (int i = 0; i < array.Length; i++)
    {
        
        for (int j = startValue; j <= endValue; j++)
        {
            array[i] = (int)Math.Pow(j, 3);
            i++;
        }
    }
    return array;
}

void PrintSum (int [] sum)
{
    int result = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        result = result + sum[i];
    }
    Console.WriteLine(result);
}