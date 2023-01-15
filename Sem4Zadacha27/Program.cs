/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();

//-------------------------------------------------------
int RNum(string m)
{
    Console.WriteLine(m);
    return Convert.ToInt32(Console.ReadLine()); //Конвертитуем текст в число
}
//-------------------------------------------------------

int GSt(int a)
{
    int s = 0;
    int b = 0;

    while (a > 0)
    {
        b = a % 10;
        s += b;    //s=s*b
        a = a / 10;
    }

    return s;
}
//-------------------------------------------------------

int number1 = RNum("Введите число: ");    //return Convert.ToInt32(Console.ReadLine());
int st = GSt(number1);   //return s;
Console.WriteLine($"сумму цифр в числе {number1} = {st}");
