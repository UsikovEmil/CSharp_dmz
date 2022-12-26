// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

//int a = Convert.ToInt32(Console.ReadLine());
int a = 12821;
int s = a.ToString().Length;
int[] mas = new int[s];

//Console.WriteLine(s);
//int i = 0;
//while (i <= s)
for (int i = 0; i < s; i++)
{
    mas[i] = a % 10;
    a = a / 10;

    Console.WriteLine($"m={mas[i]}");
    //i++;
}

/* for (int i = 0; i <= s; i++)
{
    mas[i] = a % 10;
    a = a / 10;

    Console.WriteLine($"m={mas[i]}");
    //i++;
}

 */


