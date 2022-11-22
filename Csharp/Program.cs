// Console.Write("Введите первое число: ");
// int number1 = int.Parse(Console.ReadLine());

// Console.Write("Введите первое число: ");
// int number2 = int.Parse(Console.ReadLine());

// int quadrate = number2 * number2;

// if (number1 == quadrate)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"

// int N = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int Nmin = -N;

// while(N>=Nmin)
// {
//     Console.WriteLine(N);
//     N = N-1;
// }

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456->6 782->2 918->8

Console.WriteLine("Введите трехзначное число ");
int N = int.Parse(Console.ReadLine());

N = N%10;

Console.WriteLine(N);
