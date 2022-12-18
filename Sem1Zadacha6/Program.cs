Console.Clear();

Console.WriteLine("(Является ли число четным?)");

Console.Write("Введите число:= ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число не чётное"); 
}