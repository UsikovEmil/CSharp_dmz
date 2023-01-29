// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();

int[,] matrix(int R, int C)
{
    int[,] marray = new int[R, C];
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        for (int j = 0; j < marray.GetLength(1); j++)
        {
            // marray[i, j] = new Random().Next(0, 10);
             marray[i, j] = j + i + 1;
            
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
            //Console.Write($"{marray[i, j].ToString("## ##")}");
        }
        Console.WriteLine();
    }
}

        // int[,] GetSpire(int n)
        // {
        //     var result = new int[n, n];
        //     Random rand = new Random();
        //     for (int i = 0; i < n; i++)
        //         for (int j = 0; j < n; j++)
        //             result[i, j] = rand.Next(n, n);
        //     for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
        //     {
        //         for (int j = padding; j < n - padding; j++)
        //             result[padding, j] = currentChar;
        //         for (int j = padding; j < n - padding; j++)
        //             result[n - padding - 1, j] = currentChar;
        //         for (int i = padding + 2; i < n - padding - 1; i++)
        //             result[i, padding] = currentChar;
        //         for (int i = padding + 1; i < n - padding - 1; i++)
        //             result[i, n - padding - 1] = currentChar;
        //         currentChar = 1 - currentChar;
        //         result[padding + 1, padding] = currentChar;
        //     }
        //     if (n % 2 != 0 && result[0, 0] == 1)
        //         result[n / 2, n / 2] = 1;
        //     return result;
        // }

int[,] array = matrix(4, 4);
PrintMatrix(array);