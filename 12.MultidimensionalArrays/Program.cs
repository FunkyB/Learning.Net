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

if (firstMatrixСolumn != secondMatrixString)
{
    Console.WriteLine("Матрицы не согласованы, умножение невозможно");
    return;
}

int[,] firstMatrix = new int[firstMatrixString, firstMatrixСolumn];
int[,] secondMatrix = new int[secondMatrixString, secondMatrixColumn];
Console.WriteLine("Заполните первую матрицу");
for (int i = 0; i < firstMatrix.GetLength(0); i++)
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
        Console.WriteLine($"Y: " + (i + 1) + " X: " + (j + 1));
        firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
Console.WriteLine("Заполните вторую матрицу");
for (int i = 0; i < secondMatrix.GetLength(0); i++)
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        Console.WriteLine($"Y: " + (i + 1) + " X: " + (j + 1));
        secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
Console.WriteLine();
var resultMatrix = new int[firstMatrix.GetLength(0),secondMatrix.GetLength(1)];

for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < secondMatrix.GetLength(0); k++)
        {
            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
        Console.Write(resultMatrix[i, j] + "\t");
    }
    Console.WriteLine();
}