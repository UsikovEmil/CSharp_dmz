//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();

int[] rmassiv(int size, int min, int max)
{
    int[] m = new int[size];
    for (int i = 0; i < size; i++)
    {
        m[i] = new Random().Next(min, max);
    }

    return m;
}

void chet(int[] m)
{
    int k = 0;
    for (int i = 0; i < m.Length; i++)
    {
        if ((m[i] % 2) == 0) k += 1;
    }
    Console.WriteLine($"Количесво чётных элементов = {k}");
}

int[] array = rmassiv(4, 100, 1000);
Console.WriteLine(string.Join(" ", array));
chet(array);