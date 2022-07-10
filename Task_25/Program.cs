// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А : ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B : ");
int B = Convert.ToInt32(Console.ReadLine());
int i = 0;
int result = 1;
while (i < B)
{
    result = result * A;
    i++;
}

Console.WriteLine($"Степень числа {A}= {result} ");
