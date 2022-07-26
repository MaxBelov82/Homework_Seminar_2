// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


int [] ConvertToOneDimensionArray(int[,] in_array)
{
    int [] arrayForMethod =  new int [in_array.Length];
    int count = 0;
    Console.WriteLine($"in_array.Length = {in_array.Length}");
    
int [] SummUniqValuesInArray(int[] in_array,int[] in_array2)
{
    int count = 0;
    int actualValue = in_array[0];
    int iForSecondArray = 0;

    for (int i = 0; i < in_array.Length; i++)
    {
        if (actualValue == in_array[i])
        {
            count ++;
        }
        else 
        {
            actualValue = in_array[i];
            in_array2[iForSecondArray] = count;
            count  = 1;
            iForSecondArray ++;
        } 

        if (i == in_array.Length-1)
        {
            in_array2[iForSecondArray] = count;
        } 

    }

    return in_array2;

}
