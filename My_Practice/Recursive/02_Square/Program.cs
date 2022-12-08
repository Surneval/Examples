// Рассчитать значение квадрата целого положительного числа n, если известна зависимость
// n2 = (n-1)2 + 2·(n-1) + 1

int Prompt(string userMsg)
{
    Console.WriteLine(userMsg);
    return int.Parse(Console.ReadLine());
}

bool IsInt(int n)
{
    if (Convert.ToInt32(n) == Convert.ToDouble(n)) return true;
    else return false;
}

int Square(int n)
{
    if (IsInt(n))
    {
        if (n == 1) return 1;
        else return Square(n - 1) + 2 * n - 1;
    }
    return 0;
}
void Runner()
{
    int n = Prompt("Enter n");
    int square = Square(n);
    Console.WriteLine($"n ^ 2 = {square}");
}
Runner();