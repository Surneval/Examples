// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и
// удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000);
Console.WriteLine($"new random number id {number}");
int x = number / 100 * 10 + number % 10;
Console.WriteLine($"new number without second digit is {x}");