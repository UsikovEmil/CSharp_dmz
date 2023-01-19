/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 

*/

Console.Clear();

int[] RArr(int size)
{
    int[] m = new int[size];
    for (int i = 0; i < size; i++)
    {
        m[i] = new Random().Next(0, 100);
    }
    return m;
}

void sum(int[] a)
{
    int s = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (i % 2 == 0) s+=a[i];
    }
    Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях = {s}");
}

int[] array = RArr(5);
Console.WriteLine(string.Join(" ", array));
sum(array);
