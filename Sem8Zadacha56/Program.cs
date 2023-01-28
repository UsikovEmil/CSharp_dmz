// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] matrix(int R, int C)
{
    int[,] marray = new int[R, C];
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        for (int j = 0; j < marray.GetLength(1); j++)
        {
            marray[i, j] = new Random().Next(0, 10);
        }
    }
    return marray;

}
void PrintMatrix(int[,] marray)
{
    int sum = 0;
    int str = 0;
    int[] array = new int[marray.GetLength(0)];
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        for (int j = 0; j < marray.GetLength(1); j++)
        {
            sum += marray[i, j];
            Console.Write($" {marray[i, j]}");
        }
        array[i] = sum;
        sum = 0;
        Console.WriteLine();
    }
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        if (array[i] > sum) sum = array[i];
    }
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        if (array[i] < sum)
        {
            sum = array[i];
            str = i + 1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой являеться: {str} строка");
}

int[,] array = matrix(4, 4);
PrintMatrix(array);