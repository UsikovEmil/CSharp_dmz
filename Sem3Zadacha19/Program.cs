// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

int a = Convert.ToInt32(Console.ReadLine());
//int a = 12821;
int s = a.ToString().Length;
int[] mas = new int[s];

if (s != 5)
{
    Console.WriteLine("Число не 5-ти значное");
    return;
}

Console.Write($"Число {a} ({s} - значное)");

for (int i = 0; i < s; i++)
{
    mas[i] = a % 10;
    a = a / 10;
    // Console.WriteLine($"m=[{mas[i]}]");

}
int x = 0;
for (int i = 0; i < s / 2; i++)
{
    x = x + mas[i] - mas[s - 1 - i];
}
//Console.WriteLine($"x={x}");
if (x == 0)
{
    Console.Write(" и являеться палиндромом");
}
else
{
    Console.Write(" и не являеться палиндромом");
}