/* Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 

*/

Console.Clear();

int[] RArr(int size)
{
    int[] m = new int[size];
    for (int i = 0; i < size; i++)
    {
        m[i] = new Random().Next(1, 100);
    }
    return m;
}

void Raz(int[] a)
{
    int min = a[0];
    int max = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] > max) max = a[i];
        if (a[i] < min) min = a[i];
    }
    Console.WriteLine($"Разницу между максимальным и минимальным элементов массива = {max - min}");
}

int[] array = RArr(5);
Console.WriteLine(string.Join(" ",array));
Raz(array);
