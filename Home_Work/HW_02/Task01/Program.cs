// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int a = Prompt("Please type a number from the range [100, 999] > ");
double k = Math.Pow(10, 2);
if (a / k >= 1 && a / k < 10)
{
    int temp1 = 0;
    int Second(int numb, int temp)
    {
        temp = 0;
        int second = numb;
        while (temp <= 1)
        {
            second = numb % 10;
            temp++;
            numb = numb / 10;
        }
        return second;
    }

    int sec = Second(a, temp1);
    Console.WriteLine($"the second digit of the number you've typed is {sec}");
}
else
{
    Console.WriteLine("you typed wrong number, please put a figure from 100 to 999");
}