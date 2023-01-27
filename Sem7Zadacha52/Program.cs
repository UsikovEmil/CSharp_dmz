// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
    int a = marray.GetLength(0);
    int b = marray.GetLength(1);
    double sum = 0;
    double[] array = new double[b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Console.Write($" {marray[i, j]}");
        }
        Console.WriteLine();
    }
    for (int i = 0; i < b; i++)
    {
        for (int j = 0; j < a; j++)
        {
            sum += marray[j, i];
        }
        array[i] = Math.Round(sum / a, 1);
        sum = 0;
    }
    Console.WriteLine("Среднее арифметическое каждого столбца: " + string.Join("; ", array));
}
int[,] array = matrix(3, 4);
PrintMatrix(array);