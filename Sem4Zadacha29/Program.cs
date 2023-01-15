//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

Console.Clear();
Console.WriteLine("Hello, World!");

int Rnum(string m)
{
    Console.WriteLine(m);
    return Convert.ToInt32(Console.ReadLine());
}

int mass= Rnum("Введите числа");
