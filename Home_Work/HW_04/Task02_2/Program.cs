//  Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Prompt (string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}
int SumOfDigits (int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}
void Execute ()
{
    int number = Prompt("Please enter a number >> ");
    int sumOfDigits = SumOfDigits(number);
    Console.WriteLine($"Sum of digits of entered number equals {sumOfDigits}");
}
Execute();