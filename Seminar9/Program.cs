// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"




// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"




// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12 45 -> 9




// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8
using System;
using System.Diagnostics;
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int b = int.Parse(Console.ReadLine());
Stopwatch watch = new Stopwatch();
watch.Start();
double num = 0;
for (int i = 0; i < 1000000; i++)
{
   num = GetExponential(a, b); 
}
watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);
Console.WriteLine(num);
double NumberAtoNumberB (int c, int d)
{
    if (d == 0) return 1;
    else
    {
        if (d%2 == 0) return NumberAtoNumberB(c, d/2) * NumberAtoNumberB(c, d/2);
        else return c * NumberAtoNumberB(c, d - 1);
    }
}
double GetExponential(int a, int b) {
    double result = 1;
    if(b == 0) {
        return 1;
    }

    for(int i = 0; i < Math.Abs(b); i++) {
        result = result * a;
    }

    if(b < 0) {
        return 1 / result;
    }

    return result;
}
