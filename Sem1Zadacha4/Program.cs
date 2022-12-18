Console.Clear();

Console.WriteLine("(Какое число большее, а какое меньшее?)");

Console.Write("Введите первое число:= ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:= ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:= ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine($"Максимальное число = ({a}), оно больше второго на: {a-b} и третьего на: {a-c}");
}
else if (b > a && b > c)
{
    Console.WriteLine($"Максимальное число = ({b}), оно больше первого на: {b-a} и третьего на: {b-c}");
}
else if (c > a && c > b)
{
    Console.WriteLine($"Максимальное число = ({c}), оно больше первого на: {c-a} и второго на: {c-b}");
}
else
{
    Console.WriteLine("Извените но эти три числа равны"); 
}
