// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов,
//  стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write($"Введи количество элементов массива: ");
int arrLength = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int arrLength, int min, int max)
{
    int[] randomNumbers = new int[arrLength];
    int sumElements = 0;
    Console.Write("Массив: [ ");

    for (int i = 0; i < randomNumbers.Length; i++)
    {
        randomNumbers[i] = new Random().Next(min, max);

        Console.Write(randomNumbers[i] + ", ");

        if (i % 2 != 1)
        {
            sumElements = sumElements + randomNumbers[i];

        }
    }
    return sumElements;
}

int randomNumbers = RandomNumbers(arrLength, 1, 10);
Console.Write("]");
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях-> {randomNumbers}");
