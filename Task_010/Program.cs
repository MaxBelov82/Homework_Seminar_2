﻿// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трёхзначное число :");
int i = Convert.ToInt32(Console.ReadLine());

 i = ((i/10)%10);
 {
    Console.WriteLine(i);
 }
