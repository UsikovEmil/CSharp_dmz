// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

int n = new Random().Next(10, 2000);

int s = n.ToString().Length;

Console.WriteLine($"Случайное число: {n}");

if ( n >= 100)
{
    int x = (n / 10) % 10;
    Console.WriteLine($"Третья цифра = {x}");
    Console.WriteLine(s);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}






