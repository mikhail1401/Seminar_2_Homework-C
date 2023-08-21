Console.WriteLine("Task 10");
// Задача 10. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5    782 -> 8    918 -> 1

Console.WriteLine("Type a 3 digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = (number / 10) % 10;
Console.WriteLine(result);


Console.WriteLine("\nTask 13");
// Задача 13. Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5     78 -> there is not thrid digit     32679 -> 6

Console.WriteLine("Type a number: ");
int num = Convert.ToInt32(Console.ReadLine());

  
