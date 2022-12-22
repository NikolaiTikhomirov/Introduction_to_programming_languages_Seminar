// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int numberN = int.Parse(Console.ReadLine());
// OutIntNumbersFromNto1(numberN);

// void OutIntNumbersFromNto1 (int n)
// {
//     if (n >= 1)
//     {
//     Console.Write($"{n}, ");
//     OutIntNumbersFromNto1 (n - 1);
//     }
// }




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int numberM = int.Parse(Console.ReadLine());
// Console.Write("Введите число N: ");
// int numberN = int.Parse(Console.ReadLine());
// Console.WriteLine(SumIntNumbersFromMtoN(numberM, numberN));

// int SumIntNumbersFromMtoN(int m, int n)
// {
//     if (m <= n)
//     {
//         if (m == n) return m;
//         else return m + SumIntNumbersFromMtoN(m + 1, n);
//     }
//     else
//     {
//         return m + SumIntNumbersFromMtoN(m - 1, n);
//     }
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());
Console.WriteLine(Akkerman(numberM, numberN));

int Akkerman (int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, n - 1));
}
