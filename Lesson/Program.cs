Console.Clear();
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
// =================================================================================================

Console.Write($"Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n) //m - строчки n - столбцы
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
//================================================================================================================
// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] NewGetArray(int m, int n) //m - строчки n - столбцы
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}
// int[,] resultMatrix = NewGetArray(rows, columns);
// PrintArray(resultMatrix);

//================================================================================================

// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// for (int i = 0; i < resultMatrix.GetLength(0); i++)
// {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//          if (i % 2 == 0 && j % 2 == 0) resultMatrix[i, j] = Convert.ToInt32(Math.Pow(resultMatrix[i, j], 2));
//     }
// }
// Console.WriteLine();
// PrintArray(resultMatrix);
// Задача 51. Найти сумму элементов главной диагонали.
// например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
//================================================================================================
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

void SumArrayDiagonal(int[,] sumMatrix)
{
    int sumResult = 0;
    for (int i = 0; i < sumMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sumMatrix.GetLength(1); j++)
        {
            if (i == j) sumResult += sumMatrix[i, j];
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали = {sumResult}");
}
// SumArrayDiagonal(resultMatrix);