// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
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

string PrintMatrix(int[,] marray, int x, int y)
{
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        for (int j = 0; j < marray.GetLength(1); j++)
        {
            Console.Write($" {marray[i, j]}");
        }
        Console.WriteLine();
    }
    if (marray.GetLength(0) < x && marray.GetLength(1) < y || (x + y) <2)
    {
        return "такого числа в массиве нет";
    }
    else return Convert.ToString(marray[x - 1, y - 1]);



}
int[,] array = matrix(4, 4);
Console.Write("Введите позицию строки = ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца = ");
int Y = Convert.ToInt32(Console.ReadLine());

string a = PrintMatrix(array, X, Y);
Console.WriteLine($"{X} {Y} -> {a}");