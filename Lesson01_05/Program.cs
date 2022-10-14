// Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.
Console.Write("Please type the number > ");
string inputString = Console.ReadLine();
double number = Convert.ToDouble(inputString);
double reciprocal = 1 / number;
Console.WriteLine($"{reciprocal} is reciprocal number of {number}");