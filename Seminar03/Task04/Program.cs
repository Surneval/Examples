// Задача 4: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int n = Prompt("type number N >> ");
int Square(int i, int n)
{
    int sq = 0;
    while (i <= n)
    {
        sq = (i * i);
        Console.Write($"{sq}, ");
        i++;
    }
    return sq;
}
int i = 1;
int sq = Square(i, n);
// for(int i =1; i<=n; i++)
//{
//Console.WriteLine(Math.Pow(i, 2));
//}
