// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int palindromeOrNot = int.Parse(Console.ReadLine());
// while(palindromeOrNot < 10000 || palindromeOrNot > 99999)
// {
//     Console.Write("Вы ввели неверное число. Введите пятизначное число: ");
//     palindromeOrNot = int.Parse(Console.ReadLine());
// }
// if(Revers(palindromeOrNot))
// {
//     Console.WriteLine("Число является палиндромом!");
// }
// else
// {
//     Console.WriteLine("Число не является палиндромом!");
// }

// bool Revers(int numberRevers)
//  {
//     int count = 5;
//     int index = 0;
//     int temp = numberRevers;
//     int newNumber = 0;
//     while(index < count)
//         {
//             newNumber = newNumber * 10 + temp % 10;
//             temp = temp / 10;
//             index++;
//         }
//     bool a = newNumber == numberRevers;
//     return a;
//  }




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек в 3D пространстве");
bool isParsedxa = int.TryParse(Console.ReadLine(), out int xa);
bool isParsedya = int.TryParse(Console.ReadLine(), out int ya);
bool isParsedza = int.TryParse(Console.ReadLine(), out int za);
bool isParsedxb = int.TryParse(Console.ReadLine(), out int xb);
bool isParsedyb = int.TryParse(Console.ReadLine(), out int yb);
bool isParsedzb = int.TryParse(Console.ReadLine(), out int zb);

if(!isParsedxa || !isParsedya || !isParsedza || !isParsedxb || !isParsedyb || !isParsedzb)
{
    Console.WriteLine("Координаты введены не корректно");
    return;
}
Console.WriteLine(DistanceBetweenToPoints(xa, ya, za, xb, yb, zb));


double DistanceBetweenToPoints (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
    return distance;
}






// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125