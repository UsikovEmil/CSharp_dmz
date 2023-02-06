// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число от M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число до N: ");
int N = Convert.ToInt32(Console.ReadLine());


void PrintBinaryViev(int m, int n, int s)
{
    if (m > n)
    {
        Console.Write($"Cумму натуральных элементов = {s} ");
        return;
    }
    PrintBinaryViev(m + 1, n, s + m);

}

PrintBinaryViev(M, N, 0);
