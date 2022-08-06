﻿// //Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int numN = Convert.ToInt32(Console.ReadLine());

void RangeNumberSum(int numberM, int numberN, int sum)
{
    if (numberM > numberN)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (numberM++);
    RangeNumberSum(numberM, numberN, sum);
}

RangeNumberSum(numM, numN, 0);


