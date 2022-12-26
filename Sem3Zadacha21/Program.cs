// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
int s = 3;
int[] mas1 = new int[s];
int[] mas2 = new int[s];

for (int i = 0; i < s; i++)
{
    Console.Write($"A{i + 1}=");
    mas1[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"A({mas1[0]},{mas1[1]},{mas1[2]})");

for (int i = 0; i < s; i++)
{
    Console.Write($"B{i + 1}=");
    mas2[i] = Convert.ToInt32(Console.ReadLine());
}

double x = Math.Sqrt(Math.Pow((mas2[0] - mas1[0]), 2) + Math.Pow((mas2[1] - mas1[1]), 2) + Math.Pow((mas2[2] - mas1[2]), 2));

Console.WriteLine($"B({mas2[0]},{mas2[1]},{mas2[2]})");
Console.WriteLine($"Расстояния между двумя точками A({mas1[0]},{mas1[1]},{mas1[2]}) и B({mas2[0]},{mas2[1]},{mas2[2]}) в пространстве = {Math.Round(x,2)}");
