// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Сколько чисел вы хотите ввести? ");
// int arreyLength = int.Parse(Console.ReadLine());
// int[] userNumbersArray = new int[arreyLength];

// FillArray(userNumbersArray);
// PrintArray(userNumbersArray);
// Console.WriteLine(CountPositiveNumbers(userNumbersArray));

// int CountPositiveNumbers(int[] col)
// {
//     int count = 0;
//     for (int i = 0; i < col.Length; i++)
//     {
//         if (col[i] >= 0) count++;
//     }
//     return count;
// }
// int[] FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"Введите {i + 1} число: ");
//         arr[i] = int.Parse(Console.ReadLine());
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.WriteLine($"[{string.Join(", ", arr)}]");
// }

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());

double[] intersectionPointArray = FindIntersectionPointOfTwoStraightLines(k1, b1, k2, b2);
PrintArray(intersectionPointArray);

// Если y = k1 * x + b1, y = k2 * x + b2, то справедливо утверждать, что k1 * x + b1 = k2 * x + b2,
// соответственно k1 * x - k2 * x = b2 - b1, далее x*(k1 - k2) = b2 - b1, и наконец x = (b2 - b1) / (k1 - k2)

double[] FindIntersectionPointOfTwoStraightLines(double a1, double c1, double a2, double c2)
{
    double[] intersectionPoint = new double[2];
    intersectionPoint[0] = (c2 - c1) / (a1 - a2);
    intersectionPoint[1] = a1 * intersectionPoint[0] + c1;
    return intersectionPoint;
}

void PrintArray(double[] arr)
{
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}