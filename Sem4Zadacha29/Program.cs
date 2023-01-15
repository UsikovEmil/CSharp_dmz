//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

Console.Clear();

int[] Cmas(int arr)
{
    int[] m = new int[arr];
    for (int i = 0; i < arr; i++)
    {
        Console.Write($"Число {i + 1} = ");
       /*  string a = Console.ReadLine();
        if (a == "") { a = "0"; }
        m[i] = Convert.ToInt32(a);  */
        m[i] = Convert.ToInt32(Console.ReadLine());
    }
    return m;
}

Console.WriteLine("Введите 8 чисел");
int[] mass2 = Cmas(8);
Console.WriteLine(string.Join(",", mass2));