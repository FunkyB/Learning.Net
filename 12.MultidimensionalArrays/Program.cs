//Напишите программу, в которой создайте два двумерных массива, по логике
//задачи реализующих математические матрицы. Размерность массивов получите
//от пользователя. Размерность массивов должна быть таковой, чтобы обеспечить
//возможность умножения этих матриц. На это ограничение нужно выполнить
//проверку.
//При прохождении проверки, заполните массивы данными, получая их от
//пользователя.
//Выведите на экран результат умножения матриц.

int firstMatrixString, firstMatrixСolumn;
Console.WriteLine("Введите количество строк первой матрицы");
firstMatrixString = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы");
firstMatrixСolumn = Convert.ToInt32(Console.ReadLine());

int secondMatrixString, secondMatrixColumn;
Console.WriteLine("Введите количество строк второй матрицы");
secondMatrixString = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы");
secondMatrixColumn = Convert.ToInt32(Console.ReadLine());

bool canMupltiplyMatrix = firstMatrixСolumn == secondMatrixString;

if (firstMatrixСolumn != secondMatrixString)
{
    Console.WriteLine("Матрицы не согласованы, умножение невозможно");
    return;
}

decimal[,] firstMatrix = new decimal[firstMatrixString, firstMatrixСolumn];
decimal[,] secondMatrix = new decimal[secondMatrixString, secondMatrixColumn];

for (int i = 0; i < firstMatrix.GetLength(0); i++)
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
        Console.WriteLine("Введите значения в первую матрицу");
        firstMatrix[i, j] = Convert.ToDecimal(Console.ReadLine());
    }

for (int i = 0; i < secondMatrix.GetLength(0); i++)
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        Console.WriteLine("Введите значения во вторую матрицу");
        secondMatrix[i, j] = Convert.ToDecimal(Console.ReadLine());
    }