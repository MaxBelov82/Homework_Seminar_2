// See https://aka.ms/new-console-template for more information


Console.WriteLine("Введите число :");
int i =Convert.ToInt32(Console.ReadLine());

if (i<=99)
Console.WriteLine("Нет третьего числа");

else if (i<=999)
 Console.WriteLine(i%10);

else if (i <= 99999)
    Console.WriteLine((i / 100) % 10);

    case 1: Console.WriteLine ("i<=6 Нет,не выходной");break;
  case 2: Console.WriteLine ("i>5 и i<=7 Да,выходной");break;
  default: Console.WriteLine("Нет, не выходной");break;
}
switch(i)
{
  case 1: Console.WriteLine ("i>=1 и i<6");break;
  case 2: Console.WriteLine ("Нет, не выходной");break;
  case 3: Console.WriteLine ("i=6 и i=7");break;
  default: Console.WriteLine("Да, выходной");break;
}

