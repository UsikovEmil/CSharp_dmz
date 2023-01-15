//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

Console.Clear();

/* int[] Cmas(string arr)
{
    int len = arr.Length;
    int[] m = new int[len];
    int s = Convert.ToInt32(arr);
    for (int i = 0; i < len; i++)
    {

        m[len - 1 - i] = s % 10;
        s /= 10; // s=s/10
    }
    return m;
}

Console.WriteLine("Введите число");
int[] mass2 = Cmas(Console.ReadLine());
Console.WriteLine(string.Join(",", mass2)); */

int[] Cmas(int arr)
{
    int[] m = new int[arr];
    for (int i = 0; i < arr; i++)
    {
        Console.Write($"Число {i + 1} = ");
        string a = Console.ReadLine();
        if (a == "") { a = "0"; }
             
        m[i] = Convert.ToInt32(a);
    }
    return m;
}

Console.WriteLine("Введите 8 чисел");
int[] mass2 = Cmas(8);
Console.WriteLine(string.Join(",", mass2));