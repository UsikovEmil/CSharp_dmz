// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();
// Console.Write("Введите число от M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число до N: ");
// int N = Convert.ToInt32(Console.ReadLine());
int M = 2;
int N = 3;

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
