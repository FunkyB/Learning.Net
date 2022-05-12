//Необходимо вывести в консоль средний бал пяти участников конкурса с тремя этапами.
//Программа почти готова, осталось только написать метод, который берет три численных значения и возвращает их среднее арифметическое.

//public static void Main()
//{
//    Console.WriteLine(Average(3, 4, 5));
//    Console.WriteLine(Average(10, 18, 5));
//    Console.WriteLine(Average(1, 0, 8));
//    Console.WriteLine(Average(1, 1, 4));
//    Console.WriteLine(Average(15, 15, 15));
//}

Console.WriteLine(Average(3, 4, 5));
Console.WriteLine(Average(10, 18, 5));
Console.WriteLine(Average(1, 0, 8));
Console.WriteLine(Average(1, 1, 4));
Console.WriteLine(Average(15, 15, 15));

static int Average(int a, int b, int c)
{
    return (a + b + c) / 3;
}