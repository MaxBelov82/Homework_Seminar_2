﻿// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[] MatrixMinPlace(int[,] matrix)
{
    int[] matrixMin = new int[2];
    int minRow = 0;
    int minColumn = 0;
    int minimalItem = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minimalItem)
            {
                minimalItem = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    matrixMin[0] = minRow;
    matrixMin[1] = minColumn;
    return matrixMin;
}
void PrintMatrixNoMin(int[,] matrix, int[] matrixMin)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != matrixMin[0])
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != matrixMin[1])
                {
                    if (j == 0)
                        Console.Write("|");
                    if (j < matrix.GetLength(1) - 1)
                        Console.Write($"{matrix[i, j], 3}| ");
                    else
                        Console.Write($"{matrix[i, j], 3}|");
                }
            }
            Console.WriteLine();
        }
    }
}

