// /Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

Console.WriteLine("Задайте число ");
int n = Convert.ToInt32(Console.ReadLine());

void SummNumbers(int argNum, int sum)
{
    int remain = argNum % 10;
    sum += remain;
    if (remain == 0) 
    {
        Console.Write($"{sum} ");
        return;
    }
    argNum /= 10;
    SummNumbers(argNum, sum );
}


SummNumbers(n,0);
