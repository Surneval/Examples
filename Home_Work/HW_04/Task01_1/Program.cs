//  Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//  в натуральную степень B. Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int CheckNat(int inputNumb)
{
    if (inputNumb > 0 && inputNumb % 1 == 0)
    {
        Console.WriteLine("Number B is a natural number ");
    }
    else
        Console.WriteLine("Number B is not a natural  number, type the correct one");
    return inputNumb;
}
double Power(int a, int b)
{
    int c =a;
    if (b == 0)
    { return 1; }
    if (b % 2 == 0)
    {
        double pow = 1;
        for (int k = 2; k <= (b / 2); k++)
        {
            c = c * a;
            
        }
        pow = pow * c * c;
        return pow;
    }
    else
    {
        double pow = 1;
        for (int k = 2; k <= ((b - 1) / 2); k++)
        {
            c = c * a;
            
        }
        pow = pow * a * c * c;
        return pow;
    }
}
void Run()
{
    int a = Prompt("Type a number a >>");
    Console.WriteLine($"Number a = {a}");
    int b = Prompt("Type a number b >>");
    Console.WriteLine($"Number a = {b}");
    CheckNat(b);
    double pow = Power(a, b);
    Console.WriteLine($"a to the power of b = {pow}");
}
Run();