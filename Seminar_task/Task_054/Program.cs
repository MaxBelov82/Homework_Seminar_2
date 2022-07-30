// // Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMAtrixInt(int m, int n)
 {
    int[,] arr = new int[m, n];
    Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
        {
for (int j = 0; j < arr.GetLength(1); j++)
      {
arr[i, j] = rnd.Next(1, 20);
    }
   }
return arr;
  }

void FIndMinElement(int[,] arr)
 {
    for(int i = 0; i< arr.GetLength(0);i++)
    {
      for( int j =0; j < arr.GetLength(1); j++)
     {
        for(int k =j +1;k < arr.GetLength(1); k++)
       {
         if(arr[i, j] < arr[i,k])
          {
             int temp = arr[i, j];
             arr [i, j] = arr [i,k];
             arr [i, k] = temp;
          }
        }
      }
    }
 }
void PrintMatrix(int[,] arr)
{
     for(int i =0; i < arr.GetLength(0); i++)
    {
        for (int j =0; j < arr.GetLength(1); j++)
        {
     if (j ==0) Console.Write("|");
      if( j < arr.GetLength(1)- 1) Console.Write($"{arr[i, j],3} |");
     else Console.Write($"{arr[i ,j],3} |");
      }
   Console.WriteLine();
   }
}

int[,] arrayCreate = CreateMAtrixInt(4,5);
PrintMatrix(arrayCreate);
Console.WriteLine();
FIndMinElement(arrayCreate);
PrintMatrix(arrayCreate);