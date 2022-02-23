Console.WriteLine("Введите количество элементов массива (целое число)");
bool isValidInt = int.TryParse(Console.ReadLine(), out int arrayNumber);
if (!isValidInt)
{
    Console.WriteLine("Введено не целое число");
    return;
}
int[] array = new int[arrayNumber];
int arrayIndex = 0;
while (arrayIndex < arrayNumber)
{
    Console.WriteLine($"Введите целочисленное значение для элемента массива: {arrayIndex}");
    bool isValidArrayValue = int.TryParse(Console.ReadLine(), out int arrayValue);
    if (!isValidArrayValue)
    {
        Console.WriteLine("Введено не целое число");
        return;
    }
    array[arrayIndex] = arrayValue;
    arrayIndex++;
}
Array.Sort(array);
Array.Reverse(array);
Array.Resize(ref array, arrayNumber + 1);
Console.WriteLine($"Введите целочисленное значения для нового элемента массива");
bool isValidAdditionalArrayValue = int.TryParse(Console.ReadLine(), out int additionalArrayValue);
if (!isValidAdditionalArrayValue)
{
    Console.WriteLine("Введено не целое число");
    return;
}
array[array.Length - 1] = additionalArrayValue;
int FinalArrayIndex = 0;
Console.WriteLine($"Итоговый массив:");
while (FinalArrayIndex < array.Length)
{
    Console.WriteLine(array[FinalArrayIndex]);
    FinalArrayIndex++;
}