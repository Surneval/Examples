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
    if (b == 0)
    { return 1; }
    if (b % 2 == 0)
    {
        double pow = Math.Pow(a, (b/2));
        return pow = pow * pow;
    }
    else
    {
        double pow = Math.Pow(a, ((b-1)/2));
        return pow = a * pow * pow;
    }
}
void Run()
{
    int a = Prompt("Type a number a >>");
    Console.WriteLine($"Number a = {a}");
    int b = Prompt("Type a number b >>");
    Console.WriteLine($"Number a = {b}");
    CheckNat(b);
    double pow = Power(a,b);
    Console.WriteLine($"a to the power of b = {pow}");
}
Run();