// Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число :");
int i = Convert.ToInt32(Console.ReadLine());

if (i <= 99)
    Console.WriteLine("Нет третьего числа");

else if (i <= 999)
    Console.WriteLine(i % 10);

else if (i <= 99999)
    Console.WriteLine((i / 100) % 10);
