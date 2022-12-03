// Задача 25: Напишите программу, которая принимает на вход два числа (A и B)
// и метод который возводит число A в натуральную степень B.
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// Не использовать Math.Pow()

// Console.WriteLine("Введитте два числа:");
// int number1 = int.Parse(Console.ReadLine());
// int number2 = int.Parse(Console.ReadLine());

// Console.WriteLine(Exponentiation(number1, number2));

// int Exponentiation(int a, int b)
// {
//     int c = a;
//     int index = 1;
//     while(index < b)
//     {
//         c = c*a;
//         index++;
//     }
//     return c;
// }





// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число:");
int someNumber = int.Parse(Console.ReadLine());

Console.WriteLine(SumOfSomeNumber(someNumber));

int SumOfSomeNumber(int temp)
{
    int a = 0;
    while(temp > 0)
    {
        a = a + temp % 10;
        temp = temp / 10;
    }
    return a;
}




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
