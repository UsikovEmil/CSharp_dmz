Console.Clear();
int i = 0;
Console.WriteLine("(Показывает все чётные числа от 1 до N?)");

Console.Write("Введите число N:= ");
int a = Convert.ToInt32(Console.ReadLine());

while (i <= a)
{
    if (i % 2 == 0)
    {   
        Console.Write(i);
        if (i < a-1)
        {
            Console.Write(",");
        }
    }
    i++;
}