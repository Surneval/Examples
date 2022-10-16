// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Please type any number N >> ");
string input = Console.ReadLine();
int n = Convert.ToInt32(input);
int i = 1;
if (n < 0)
{
    while (n < i)
    {
        if (n % 2 == 0)
        {
            Console.Write($"{n}, ");

        }
        n++;
    }
}
if (n > 0)
{
    while (i < n + 1)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i}, ");
        }
        i++;
    }
}
