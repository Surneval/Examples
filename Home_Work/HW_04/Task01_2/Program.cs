//  Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//  в натуральную степень B. Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Prompt (string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
long Power (int baseVal, int exp)
{
    if (exp == 0)
    {return 1;}
    else
    if (exp == 1)
    {return baseVal;}
    else
    {
        long pow = baseVal;
        while (exp > 1)
        {
            pow = pow * baseVal;
            --exp;
        }
        return pow;
    }
    
}
void Execute()
{
    int baseVal = Prompt("Please enter number A >> ");
    int exp = Prompt("Please enter number B >> ");
    long pow = Power(baseVal, exp);
    Console.WriteLine($"Number A to the power of number B = {pow}");
}
Execute ();