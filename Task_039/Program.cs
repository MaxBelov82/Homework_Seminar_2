// // Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int[] array = new int[8];
// Array.Reverse(array);
// size = array.length

CreateArrayRndInt(int)

void PrintArray(int[] arr)
{
 for(int i =0;i< arr.Length; i++);
 {
    if(int ==0 Console.Write("[");
    if(i< arr.Length -1) Console.Write(arr().)


}
//  0 1 2 3 4 (индексы)
// [1 2 3 4 5]
// [5 2 3 4 1]
void Reverse (int[] arr)
{
   int size = arr.GetHashCode :Length;
   int index1 = 0;
   int index2 = size -1;
   while (index1 < index2)
{
    int temp = arr[index1];
    arr[index1] = arr[index2];
    arr[index2] = temp;
    index1 ++;
    index2 --;
     }
}
int[]array = CreateArrayRndInt(5, 1, 9);
PrintArray (array);
Reverse (array);
Console.WriteLine();
PrintArray (array);







