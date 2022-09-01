Console.Clear();
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// , и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Write($"Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n) 
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
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.Write($"Введите необходимую строку: ");
int findRow = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите необходимый столбец: ");
int findColumn = Convert.ToInt32(Console.ReadLine());

void FindElement(int[,] FindMatrixElement, int row,int col)
{
    for (int i = 0; i < FindMatrixElement.GetLength(0); i++)
    {
        for (int j = 0; j < FindMatrixElement.GetLength(1); j++)
        {
            if (i == row && j == col) Console.WriteLine($"Число на позиции {i}:{j} = {FindMatrixElement[i,j]}");
        }
        Console.WriteLine();
    }
}
FindElement(resultMatrix, findRow, findColumn);