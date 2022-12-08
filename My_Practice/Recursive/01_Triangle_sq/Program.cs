// Площадь треугольника S(m,n)задана зависимостями 
// S = 1, if n=m=1; S(n-1, m), if n >1; S(n, m-1), if m>1

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

bool CheckPositive(int m, int n)
{
    if (n > 0 && m > 0) return true;
    else return false;
}

int TriangleSq(int m, int n)
{
    if (CheckPositive(m, n))
    {
        if (m == 1 && n == 1) return 1;
        else if (n > 1) return TriangleSq(m, n - 1) + m;
        else return TriangleSq(m - 1, n) + 1;
       
    }
    else return 0;
}

void Runner()
{
    int m = Prompt("Enter m");
    int n = Prompt("Enter n");
    int square = TriangleSq(m, n);
    Console.WriteLine($"Square of triangle equals {square} ");
}
Runner();