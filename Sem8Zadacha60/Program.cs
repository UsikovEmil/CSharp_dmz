// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.Clear();

int[,,] matrix(int X, int Y, int Z)
{
    int[,,] marray = new int[X, Y, Z];
    int[] array = new int[X + Y + Z];
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        for (int j = 0; j < marray.GetLength(1); j++)
        {
            for (int k = 0; k < marray.GetLength(2); k++)
            {
                int num = new Random().Next(10, 99);
                if (array.Contains(num)) k--; //Метод Contains() возвращает true, если коллекция содержит определенный элемент.
                else
                {
                    array[i + j + k] = num;
                    marray[i, j, k] = num;
                }
            }
        }
    }
    return marray;
}

void PrintMatrix(int[,,] marray)
{
    for (int i = 0; i < marray.GetLength(0); i++)
    {
        for (int j = 0; j < marray.GetLength(1); j++)
        {
            for (int k = 0; k < marray.GetLength(2); k++)
            {
                Console.Write($" {marray[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] array = matrix(2, 2, 2);
PrintMatrix(array);
