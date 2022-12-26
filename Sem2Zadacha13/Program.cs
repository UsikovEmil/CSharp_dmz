// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

int n = new Random().Next(1, 2000);
Console.WriteLine($"Случайное число: {n}");

if ( n < 100)
{
    Console.WriteLine("Третьей цифры нет");   
}
else
{
    while (n>=1000)
    {
        n=n/10; 
    }
    int x = n  % 10;
    Console.WriteLine($"Третья цифра = {x}");
}