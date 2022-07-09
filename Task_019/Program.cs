// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
Convert.ToInt32(Console.ReadLine());
int num =1 ;


for (int i =1; i <= num; i++)
{
 num=((num%10)/10);
}   
 
Console.WriteLine($"{num+10} -> да");
   
else 
{
    
}

Console.WriteLine($"{num} -> нет");
