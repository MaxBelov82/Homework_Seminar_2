// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
    int sum = 0;

    for (int i = 0; i <= number; i++)
{
        sum += number%10;
        number = number/10;
     }
     return sum;
}
int result = Sum(number);
Console.WriteLine($"Сумма цифр в числе : {number}={result}");
