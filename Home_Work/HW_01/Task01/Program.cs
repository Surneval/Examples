// SНапишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Please type any number to be considered number1>> ");
Double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please type any number to be considered number2 >> ");
Double number2 = Convert.ToDouble(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"{number1} is maximim, {number2} is minimum");
}
if (number2 > number1)
{
    Console.WriteLine($"{number2} is maximum, {number1} is minimum");
}