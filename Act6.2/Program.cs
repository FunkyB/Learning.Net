//Напишите метод ArraySum для программы, который принимает в качестве аргументов два массива и возвращает третий,
//состоящий из сумм соответствующих элементов первых двух, массивы могут быть разной длины, гарантируется, что ни один из массивов не null.
//public static void Main()
//{
//    int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
//    int[] array2 = { 9, 8, 7, 6, 5, 4, 3, 2 };
//    foreach (var x in ArraySum(array1, array2))
//        Console.Write($"{x} ");
//}
//Sample Input 1:
//{ 1,2,3,4,5,6,7,8}
//{ 9,8,7,6,5,4,3,2}
//Sample Output 1:
//10 10 10 10 10 10 10 10
//Sample Input 2:
//{ 0,10,20,30,40,50}
//{ 1,2,3}
//Sample Output 2:
//1 12 23 30 40 50

class Program

{
    public static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] array2 = { 9, 8, 7, 6, 5, 4, 3, 2 };
        foreach (var x in ArraySum(array1, array2))
            Console.Write($"{x} ");
    }

    private static int[] ArraySum(int[] array1, int[] array2)
    {
        int sizeOfBiggestArray = 0;
        if(array1.Length >= array2.Length)
        {
            sizeOfBiggestArray = array1.Length;
        }
        else
        {
            sizeOfBiggestArray = array2.Length;
        }
        int[] result = new int[sizeOfBiggestArray];
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                result[i] = array1[i] + array2[j];
            }
        }

        return result;
    }

}