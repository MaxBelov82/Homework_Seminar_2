// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99999)
{
    Console.Write("Вы ввели не пятизначное число");
}
else
{
    int pal = 0, num = number;
    while (number > 0)
    {
        pal = pal * 10 + number % 10;
        number /= 10;
    }
    Console.WriteLine(num == pal ? "палиндром" : "не палиндром");
}


