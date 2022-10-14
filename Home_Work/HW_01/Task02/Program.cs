// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Please type any number to be considered number1 >> ");
string input1 = Console.ReadLine();
int number1 = Convert.ToInt32(input1);
Console.WriteLine("Please type any number to be considered number2 >>");
string input2 = Console.ReadLine();
int number2 = Convert.ToInt32(input2);
Console.WriteLine("Please type any number to be considered number3 >>");
string input3 = Console.ReadLine();
int number3 = Convert.ToInt32(input3);
int maximum = number1;
if (number2 > maximum)
{
    maximum = number2;
}
if (number3 > maximum)
{
    maximum = number3;
}

Console.WriteLine($"Maximum number is {maximum}");