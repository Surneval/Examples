// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и
//проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt("Please type any numer from 1 to 7 > ");
string[] days = {"monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"};
if (number <= days.Length && number > 0)
{
        Console.WriteLine($"selected day is {days[number-1]}");
}
else
{
    Console.WriteLine("please type number from 1 to 7");
}