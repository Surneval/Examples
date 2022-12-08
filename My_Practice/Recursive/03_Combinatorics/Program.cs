//Вычислить количество комбинаций из n разных элементов по m.
// Количество комбинаций определяется формулой

int Prompt(string userMsg)
{
    Console.WriteLine(userMsg);
    return int.Parse(Console.ReadLine());
}

int Combinations(int n, int m)
{
    if ((m == 0 && n > 0) || (m == n && m > 0)) return 1;
    else if (m > n && n >= 0) return 0;
    else return Combinations(n - 1, m - 1) + Combinations(n - 1, m);
}

void Runner()
{
    int n = Prompt("Enter n");
    int m = Prompt("Enter m");
    int combNum = Combinations(n, m);
    Console.WriteLine(combNum);
}
Runner();
