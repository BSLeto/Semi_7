Console.Clear();
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    double avg = 0;
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        avg += resultMatrix[j, i];
    }

        Console.WriteLine($" среднее арифметическое {i+1} столбца  = {Math.Round(avg / resultMatrix.GetLength(1), 1)}");

}