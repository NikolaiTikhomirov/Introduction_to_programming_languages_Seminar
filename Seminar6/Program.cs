// Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());

// if (c < a + b && b < a + c && a < c + b) Console.WriteLine("Такой треугольник существует");
// else Console.WriteLine("Такой треугольник не существует");



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101
// 3 -> 11
// 2 -> 10

// int a = int.Parse(Console.ReadLine());

// string BinaryNumber (int num)
// {
//     string str = string.Empty;
//     while (num > 0)
//     {
//         str = str + num%2;
//         num = num / 2;
//     }
//     return str;
// }
// Console.WriteLine(BinaryNumber(a));



// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Сколько чисел Фибоначи вы хотите увидеть?");
int count = int.Parse(Console.ReadLine());
MethodFibonachi(count);

void MethodFibonachi(int countN)
{
    int a = 0;
    int b = 1;
    if (countN == 1) Console.Write($"{a} ");
    else
    {
        int temp = 0;
        Console.Write($"{a} ");
        Console.Write($"{b} ");
        for (int i = 2; i < countN; i++)
        {
            temp = a;
            a = b;
            b = b + temp;
            Console.Write($"{b} ");
        }
    }
}




// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.

// int [] Array = GenerateArray(-10, 10, 5);
// PrintArray(Array);
// int [] ArrayCopy = CopyArray(Array);
// PrintArray(ArrayCopy);

// int[] CopyArray (int [] arr)
// {
//     int[] newArray = new int [arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         newArray[i] = arr[i];
//     }
//     return newArray;
// }


// int[] GenerateArray (int min, int max, int length)
// {
//     int[] array = new int [length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     Console.WriteLine($"[{string.Join(", ", arr)}]");
// }
