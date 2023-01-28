// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
    Console.WriteLine();
}

void MultitMatrix(int[,] marray1, int[,] marray2)
{
    int[,] marray = new int[marray1.GetLength(0), marray1.GetLength(1)];

    for (int i = 0; i < marray1.GetLength(0); i++)
    {
        for (int j = 0; j < marray1.GetLength(1); j++)
        {
            for (int k = 0; k < marray1.GetLength(1); k++)
            {
                marray[i, j] += marray1[i, k] * marray2[k, j];
            }
            Console.Write($" {marray[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] array1 = matrix(2, 2);
int[,] array2 = matrix(2, 2);
PrintMatrix(array1);
PrintMatrix(array2);
MultitMatrix(array1, array2);