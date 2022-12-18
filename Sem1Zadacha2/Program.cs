Console.Clear();

Console.WriteLine("(Какое число большее, а какое меньшее?)");

Console.Write("Введите первое число:= ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе  число:= ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Максимальное число = ({a}), оно больше второго на: {a-b}");
}
else if (a < b)
{
    Console.WriteLine($"Максимальное число = ({b}), оно больше первого на: {b-a}");
}
else
{
    Console.WriteLine("Извените но эти два числа равны"); 
}

