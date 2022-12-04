// Задача 25: Напишите программу, которая принимает на вход два числа (A и B)
// и метод который возводит число A в натуральную степень B.
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// Не использовать Math.Pow()

// Console.WriteLine("Введитте два числа:");
// int number1 = int.Parse(Console.ReadLine());
// int number2 = int.Parse(Console.ReadLine());

// if (number1 == 0 && number2 == 0) Console.WriteLine("Возводить 0 в степень 0 не имеет смысла, так как такое выражение не может быть определено.");
// else Console.WriteLine(Exponentiation(number1, number2));

// decimal Exponentiation(int a, int b)
// {
//     decimal c = a;
//     if (b == 0)
//     {
//         c = 1;
//     }
//     else
//     {
//         int index = 1;
//         if (b < 0)
//         {
//             c = 1 / HalfExponentiation(a, -b);
//         }
//         else
//         {
//             c = HalfExponentiation(a, b);
//         }
//         decimal HalfExponentiation(int aa, int bb)
//         {
//             decimal cc = aa;
//             while (index < bb)
//             {
//                 cc = cc * aa;
//                 index++;
//             }
//             return cc;
//         }
//     }
//     return c;
// }





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число:");
// int someNumber = int.Parse(Console.ReadLine());

// Console.WriteLine(SumOfSomeNumber(someNumber));

// int SumOfSomeNumber(int temp)
// {
//     int a = 0;
//     while(temp > 0)
//     {
//         a = a + temp % 10;
//         temp = temp / 10;
//     }
//     return a;
// }




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Какой длины будет массив?");
int arrLentgth = int.Parse(Console.ReadLine());
int[] Array = new int[arrLentgth];
int index = 0;
while (index < arrLentgth)
{
    Console.Write($"Введите {index + 1} число: ");
    Array[index] = int.Parse(Console.ReadLine());
    index++;
}

PrintArray(Array);

void PrintArray(int[] Col)
{
    int count = Col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count - 1)
    {
        Console.Write($"{Col[position]}, ");
        position++;
    }
    Console.Write($"{Col[Col.Length - 1]}]");
}