// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​1 -3,3 8 -9,9
// ​8 7,8 -7,1 9
Console.Clear();

double[,] matrix(int R, int C)
{
    double[,] marray = new double[R, C];
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        for (int j = 0; j < marray.GetLength(1); j++)
        {
            marray[i, j] = new Random().Next(-10, 10) * 0.1;
        }
    }
    return marray;

}

void PrintMatrix(double[,] marray)
{
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        for (int j = 0; j < marray.GetLength(1); j++)
        {
            Console.Write($" {marray[i, j]:f1}");
        }
        Console.WriteLine();
    }
}
double[,] array = matrix(4, 4);
PrintMatrix(array);
