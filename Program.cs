Console.WriteLine("Task 10");
// Задача 10. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5    782 -> 8    918 -> 1

int number = new Random().Next(100,1000);

int result = (number / 10) % 10;
Console.WriteLine(result);


Console.WriteLine("\nTask 13");
// Задача 13. Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5     78 -> there is not thrid digit     32679 -> 6

// int num = new Random().Next();

// if(num>=100) ConsoleWriteLine()



Console.WriteLine("\nTask 15");
// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> Yes     7 -> Yes      1 -> No

Console.WriteLine("Type a number: ");
int day = Convert.ToInt32(Console.ReadLine());

if ((day>0)&&(day<6)) Console.WriteLine("No");
else if ((day>5)&&(day<8)) Console.WriteLine("Yes");
else Console.WriteLine("There is no such day");