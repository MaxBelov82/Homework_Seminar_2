// Задача 26: Напишите программу, которая принимает 
// на вход число и выдает количество цифр в числе.
// 456 ->3
// 79 -> 2
// 89126 ->5

Console.WriteLine("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int i =0;
while (num>0)
{
    i++;
    num/=10;
}
Console.WriteLine("количество цифр в числе: {0}" , i);