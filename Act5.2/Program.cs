//public static void Main()
//{
//    int value = int.Parse(Console.ReadLine());
//    Factorize(value);
//}
//Напишите метод Factorize для программы, которая должна выводить в консоль все варианты представления исходного целого
//положительного числа в виде произведения двух положительных целых чисел так, чтобы они были расположены в порядке возрастания первого множителя.
//Варианты с перестановкой множителей местами программой выводиться не должны.

//Sample Input 1:
//100
//Sample Output 1:
//100 = 1 * 100
//100 = 2 * 50
//100 = 4 * 25
//100 = 5 * 20
//100 = 10 * 10

//Sample Input 2:
//12
//Sample Output 2:
//12 = 1 * 12
//12 = 2 * 6
//12 = 3 * 4

int value = int.Parse(Console.ReadLine());
Factorize(value);

static void Factorize(int number)
{
    for (int i = 1; i <= number / i; i++)
    {
        if (number % i == 0)
        {
            Console.WriteLine($"{number} = {i} * {number / i}");
        }
    }
}