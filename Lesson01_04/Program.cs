// Напишите программу вычисления модуля числа.
System.Console.Write("Please type the number >");
int number = int.Parse(System.Console.ReadLine());
int mod = number;
if (number<0)
{
    mod = -number;
}
System.Console.WriteLine($"{mod} is abs of {number}");