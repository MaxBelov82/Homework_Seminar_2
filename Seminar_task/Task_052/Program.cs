// // Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndInt(int m, int n)
{
   int[,] arr = new int[m, n];
   Random rnd = new Random();

   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
   {
       arr[i, j] = rnd.Next(1,10);
    }
}
   return arr;
}

double [] ArithmeticMean(int[,] arr)
{
    double [] arrMean = new double[arr.GetLength(1)];
    for (int i = 0; i <arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++ )
        {
            arrMean[i] += arr[i,j];
        }
          arrMean[i] = arrMean [i]/ arr.GetLength(0);
    }
     return arrMean;
}
    
void PrintArrMean(double [] arr)
{
   Console.WriteLine("Среднее арифметическое столбцов : ");

   for (int i =0; i < arr.Length; i++)
{
   
   Console.Write(Math.Round(arr[i],  1) + " ;");
   
   }
}

void PrintMatrix(int[,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) + 1) Console.Write($"{arr[i, j],2} | ");
            else Console.Write($"{arr[i, j],2} | ");
    }
        Console.WriteLine();
    }
}
int[,] arrayResult = CreateMatrixRndInt(3,4 );
PrintMatrix(arrayResult);

PrintArrMean(ArithmeticMean(arrayResult));
