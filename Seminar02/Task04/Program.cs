// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool DivBy (int number)
{

    return (number % 7==0) && (number % 23==0);
}
int A = Prompt("Type the number ");
if (DivBy(A))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}