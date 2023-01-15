/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
Не использовать Math.Pow() и аналоги! */

Console.Clear();


//-------------------------------------------------------
int RNum(string m)
{
    Console.WriteLine(m);
    return Convert.ToInt32(Console.ReadLine()); //Конвертитуем текст в число
}
//-------------------------------------------------------

int GSt(int a, int b)
{
    int s = 1;
    for (int i = 0; i < b; i++)
        s *= a;    //s=s*a
    return s;
}
//-------------------------------------------------------

int number1 = RNum("Введите число: ");    //return Convert.ToInt32(Console.ReadLine());
int number2 = RNum("Введите степень: ");    //return Convert.ToInt32(Console.ReadLine());
int st = GSt(number1, number2);   //return s;
Console.WriteLine($"{number1} в степени {number2} = {st}");