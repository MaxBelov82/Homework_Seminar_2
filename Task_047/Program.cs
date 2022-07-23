// // Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] ArrayRealNumbers(double m, double n, double min, double max);
// {
//     double[,] arr = new double[m, n];
//     Random rnd = new Random();

//     for (double i = 0; i < length; i++)
//     {
//         for (double j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = rnd.Next(min, max + 1);
//      }
// }
    
//     {
//     }
//     void PrintMatrix(double[,] arr)
//     {
//         for (double i = 0; i < arr.GetLength(0); i++)
//         {
//             if (j = 0) (j < arr.GetLength(1))(j++);
//         {
//     if (j == 0) Console.WriteLine("[");
//     if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} |");
//     else Console.Write($"{arr[i, j],3} |");
// }
// Console.WriteLine();
//     }
// }
// double[,] arrayResult = ArrayRealNumbers(3, 4, 1, 20);
// PrintMatrix(arrayResult);
// }

double[,] CreateMatrixRndDouble(int m, int n, int min, int max)
{
   double[,] arr = new double[m, n];
   Random rnd = new Random();

   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
   {
       arr[i, j] = rnd.Next(min, max + 1);
    }
}
   return arr;
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i <arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++ )
        {
    if (j == 0) Console.Write("[");
    if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3} |");
    else Console.Write($"{arr[i, j],3}]");
        }
        Console.WriteLine();
    }
}

double[,] arrayResult = CreateMatrixRndDouble(3, 4, 1, 6);
PrintMatrix(arrayResult);