// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] CreateArrayRndInt (int size, int min, int max)
// {
//   int[] arr = new int[size];
//   Random rnd = new Random(8);


// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rnd.Next(min, max +1);
   
// }
//    return arr;
// }

// int[] GetPosEvenElem(int[] arr)
// {
//    int evenPosElem = 0;
//    if (array[i] % 2 ==1)
//    {
//     Console.Write("[");
//     Console.Write("Количество чётных чисел : ",arr[i]);

//    }
//     return new int[] {evenPosElem};
// }
//  void PrintArray(int[] arr)
//  {
//     for(int i = 0; i< arr.Length; i++)
//     {
//                 if (i < arr.Length ) Console.Write (arr);
//                 if (i > 0) Console.WriteLine("] ");
//     }
//  }
// int [] array = GetPosEvenElem(arr );
// PrintArray(array);

Console.WriteLine(" Ищем количество чётных чисел в массиве:");
int[] arr = new int[4];

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");

    }
    Console.WriteLine("]");
}

int QuantityEvenElements(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}

FillArray(arr, 100, 1000);
Console.Write("[ ");

WriteArray(arr);



int quantity = QuantityEvenElements(arr);
Console.WriteLine($"Количество чётных чисел в массиве-> {quantity}");

