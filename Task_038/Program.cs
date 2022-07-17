//  Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
//  {   
// Console.WriteLine("Разница между максимальным и минимальным элементом:");
 
double[] arrayRealNumbers = new double[6];
Console.Write("[");
for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = new Random().Next(1, 6);
     Console.Write(arrayRealNumbers[i] + ", ");
    
}
double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

for (int i = 1; i < arrayRealNumbers.Length; i++)
{
    if (maxNumber < arrayRealNumbers[i])
    {
        maxNumber = arrayRealNumbers[i];
    }
    if (minNumber > arrayRealNumbers[i])
    {
        minNumber = arrayRealNumbers[i];
    }
}

double decision = maxNumber - minNumber;

{
Console.Write( "]");
Console.WriteLine($"\nразница между между максимальным ({maxNumber})\n и минимальным({minNumber}) элементами: {decision}");
}


