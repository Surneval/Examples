// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

void PrintNumbersMN(int m, int n)
{
    if (n < m)
    {
        return;
    }
    if (m % 2 == 0)
    {
        Console.WriteLine(m);
        PrintNumbersMN(m + 2, n);
    }
    else PrintNumbersMN(m + 1, n);
}

int m = Prompt("Enter m ");
int n = Prompt("Entar n ");
Console.WriteLine();
PrintNumbersMN(m, n);
