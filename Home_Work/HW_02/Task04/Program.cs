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
string[] days = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
if (number <= days.Length && number > 0)
{
    Console.WriteLine($"{days[number - 1]}");
    if (number == 6 | number == 7)
    {
        Console.WriteLine("It's weekend");
    }
    else
    {
        Console.WriteLine("It's not a weekend");
    }
}
else
{
    Console.WriteLine("please type number from 1 to 7");
}