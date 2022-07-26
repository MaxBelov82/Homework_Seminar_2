// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и
// предпоследний и т.д. Результат запишите в новом массиве.
// [ 12345] -> 583
// [6 7 3 6] -> 3621

int n =7;
int [] array = new int[n];
Random rnd = new Random();
for(int i = 0; i< array.Length; i++)
{
  array[i] = rnd.Next(0, 10);
  Console.Write(array[i] + " ");
}
Console.WriteLine();

int j = array.Length -1;

for( int i = 0;i < (array.Length +1) /2; i++)
{
    Console.Write( array[i] * array[j] + " ");
    j -- ;
}
if (n% 2 >0)
{
    Console.Write(array[array.Length / 2 + 1]);
}
