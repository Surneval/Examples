// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Please type any number >> ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
if(number % 2 == 0)
{
    Console.WriteLine("Your numer is even");
}
else
{
    Console.Write("Your number is odd");
}