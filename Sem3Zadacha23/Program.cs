// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.Write("Введите число N = ");
int a = Convert.ToInt32(Console.ReadLine());

int s = a.ToString().Length;

Console.Write($"Кубы чисел от 1 до {a} = (");

for (int i = 1; i <= a; i++)
{
    double x = Math.Pow(i, 3);
    
    Console.Write(x);
    if (i < a)
    {
        Console.Write(",");
    }
    else
    {
        Console.Write(")");
    }
}

