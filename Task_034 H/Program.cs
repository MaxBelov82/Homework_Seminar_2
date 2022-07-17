// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



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

