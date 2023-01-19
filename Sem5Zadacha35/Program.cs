/* Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */


Console.Clear();

int[] RArr(int size, int min, int max)
{
    int[] m = new int[size];
    for (int i = 0; i < size; i++)
    {
        m[i] = new Random().Next(min, max);
    }
    return m;
}

void col(int[] a, int min, int max)
{
    int k = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] < max && a[i] > min) k += 1;
    }
    Console.WriteLine($"Кол-во элментов от {min} до {max} в массиве из {a.Length} = {k}");
}

int[] array = RArr(123, 0, 150);
Console.WriteLine(string.Join(" ", array));
col(array,10,99);

