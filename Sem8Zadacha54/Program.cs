// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        for (int j = 0; j < marray.GetLength(1); j++)
        {
            Console.Write($" {marray[i, j]}");
        }
        Console.WriteLine();
    }
}
void SortMatrix(int[,] marray)
{
    int x = 0;
    int[] a = new int[marray.GetLength(1)];
    int[] b = new int[marray.GetLength(1)];
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        for (int j = 0; j < marray.GetLength(1); j++)
        {
            for (int k = 0; k < marray.GetLength(1); k++)
            {
                if (marray[i, k] >= a[j] && b[k] == 0)
                {
                    a[j] = marray[i, k];
                    x = k;
                }
                if (k == marray.GetLength(1) - 1) b[x] = 1;
            }
        }
        for (int j = 0; j < marray.GetLength(1); j++)
        {
            marray[i, j] = a[j];
            a[j] = b[j] = 0;
        }
    }
    Console.WriteLine();
}

int[,] array = matrix(4, 4);
PrintMatrix(array);
SortMatrix(array);
PrintMatrix(array);
