// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int Sumnum(int m, int n)
{
    if(n<=m) return m;
    else return n + (Sumnum(m, n-1));

} 

int m = Prompt("Enter m ");
int n = Prompt("Entar n ");
Console.WriteLine();
Console.WriteLine(Sumnum(m, n));