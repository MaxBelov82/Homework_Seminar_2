// // Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


Console.Clear();
Console.WriteLine("Задайте число");

int num = Convert.ToInt32(Console.ReadLine());
NaturalNumber(num);

void NaturalNumber(int num)
{
    if (num == 0) return; 
    Console.Write($"{num} ");     
    NaturalNumber (num - 1);
    
}
// Просто можно поменять строки 16 и 17 местами, чтобы порядок чисел был прямым или обратным


