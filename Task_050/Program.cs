// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет



int[,] CreateMatrixRndInt(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void PrintIndexElement(int row, int column)
{
    int[,] arr = CreateMatrixRndInt(5, 5);
    PrintMatrix(arr);
    if (row > arr.GetLength(0) - 1 || column > arr.GetLength(1) - 1)
    {
        Console.WriteLine("такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine(arr[row, column]);
    }

}

  void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите индекс строки m:");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца n:");
int column = Convert.ToInt32(Console.ReadLine());

PrintIndexElement(row, column);

