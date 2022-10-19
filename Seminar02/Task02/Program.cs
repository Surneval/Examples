//  Напишите программу, которая выводит случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.
int number = new Random().Next(10, 99);
Console.WriteLine($" number is {number}");
int lastDigit = number % 10;
int FirstDigit = number / 10;
int max = lastDigit;
if (FirstDigit > max)
{
    max = FirstDigit;
}
Console.WriteLine($" max is {max}");