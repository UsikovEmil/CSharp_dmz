// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();
Console.Write("Введите положительное число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите положительное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int PrintAkker(int m, int n)
{

    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return PrintAkker(m - 1, 1);
    else if (m > 0 && n > 0) return PrintAkker(m - 1, PrintAkker(m, n - 1));
    return n + 1;

}
Console.Write($"Значение функции Аккермана = {PrintAkker(M, N)} ");