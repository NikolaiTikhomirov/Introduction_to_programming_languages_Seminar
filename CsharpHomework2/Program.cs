// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// var phrase = "Введите трёхзначное число ";
// int someNumber = 0;

// while(someNumber>1000 || someNumber<100)
// {
//     Console.WriteLine(phrase);
//     someNumber = int.Parse(Console.ReadLine());
//     phrase = "Введенное число вне диапазона! Введите трехзначное число ";
// }
// int secondNumberOfSomeNumber = someNumber/10%10;
// Console.WriteLine(secondNumberOfSomeNumber);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.Write("Введите число ");
// var someNumber2 = int.Parse(Console.ReadLine());

// var thirdNumberOfSomeNumber2 = someNumber2;
// if(thirdNumberOfSomeNumber2 < 0)
// {
//     thirdNumberOfSomeNumber2 = thirdNumberOfSomeNumber2 * -1;
// }

// while(thirdNumberOfSomeNumber2>999)
// {
//     thirdNumberOfSomeNumber2 = thirdNumberOfSomeNumber2 / 10;
// }
// if(thirdNumberOfSomeNumber2 < 100)
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     Console.WriteLine(thirdNumberOfSomeNumber2 % 10);
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите цифру, обозначающую день недели и мы проверим, является ли этот день выходным!");
int weeknumber = int.Parse(Console.ReadLine());

while(weeknumber < 1 || weeknumber > 7)
{
    Console.WriteLine("Такого дня недели не существует. Введите число от 1 до 7 включительно");
    weeknumber = int.Parse(Console.ReadLine());
}

if(weeknumber > 0 && weeknumber < 6)
{
    Console.WriteLine("Нет, это будний день");
}
else
{
    Console.WriteLine("Да, этот день выходной.");
}