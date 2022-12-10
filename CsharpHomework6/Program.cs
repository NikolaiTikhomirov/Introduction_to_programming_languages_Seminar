// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Сколько чисел вы хотите ввести? ");
int arreyLength = int.Parse(Console.ReadLine());
int[] userNumbersArray = new int[arreyLength];

FillArray(userNumbersArray);
PrintArray(userNumbersArray);
Console.WriteLine(CountPositiveNumbers(userNumbersArray));

int CountPositiveNumbers(int[] col)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] >= 0) count++;
    }
    return count;
}
int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.WriteLine($"[{string.Join(", ", arr)}]");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
