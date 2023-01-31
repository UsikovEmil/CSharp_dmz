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
    int LR = marray.GetLength(0);
    int LC = marray.GetLength(1);
    for (int i = 0; i < LR; i++)
    {
        for (int j = 0; j < LC; j++)
        {

            if (j == LC - 1 || i == 0) marray[i, j] = j + i + 1;
            if (i == LR - 1 && j < LC - 1) marray[i, j] = -j + i + LC + LR - 1;
            if (i == LR - 2 && j < LC - 1) marray[i, j] = -j + i + (LC + LR) * 2 - 1;
            if (i == LR - 2 && j == 0) marray[i, j] = j + i + LC + LR + 1;  //доработать
            if (j < LC - 1 && i == 1) marray[i, j] = j + i + LC + LR + ((LC + LR) / 2) - 1; //доработать
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
            int mas = marray[i, j];
            if (mas < 10) Console.Write($" 0{mas}");
            else Console.Write($" {mas}");

        }
        Console.WriteLine();
    }
}

int[,] array = matrix(4, 4);
PrintMatrix(array);