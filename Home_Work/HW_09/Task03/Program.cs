// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

bool PosCheck(int m, int n)
{
    if ((n >= 0) && (m >= 0)) return true;
    else return false;

}

int Akk(int m, int n)
{
    if (PosCheck(m, n))
    {
        if (m == 0) return n + 1;
        else if (m > 0 && n == 0)
        {
            return Akk(m - 1, 1);
        }
        else if (n == 0 && m == 0) return 1;
        else return Akk(m - 1, Akk(m, n - 1));

    }
    else
    {
        Console.WriteLine("Mistake, n must be >=0; m >=0");
        return 0;
    }
}

int m = Prompt("Enter m ");
int n = Prompt("Entar n ");
Console.WriteLine();
Console.WriteLine(Akk(m, n));