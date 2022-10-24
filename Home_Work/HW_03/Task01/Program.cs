// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
int Prompt(string message)
{
    Console.Write( message);
    return int.Parse(Console.ReadLine());
}
bool CheckFiveDigit(int FiveDigNum)
{
    return Convert.ToInt32(FiveDigNum / Math.Pow(10, 4)) > 0;
}
int CheckPal (int FiveDigNum, int digit)
{
    if (CheckFiveDigit(FiveDigNum))
    {
        Console.WriteLine($"the figure you have entered {FiveDigNum} is ok >> ");
        int n1 = Convert.ToInt32 (FiveDigNum / Math.Pow(10, digit - 1));
        int n2 = Convert.ToInt32((FiveDigNum / Math.Pow(10, digit - 2)) % 10);
        int n4 = Convert.ToInt32((FiveDigNum / Math.Pow(10, digit - 4)) % 10);
        int n5 = Convert.ToInt32(FiveDigNum % 10);

        if ((n1 == n5) && (n2 == n4))
        {
            Console.WriteLine($"figure {FiveDigNum} is palindrome");
        }
        else
        {
            Console.WriteLine($"figure {FiveDigNum} is not a palindrome");
        }
    }
    else
    {
        Console.WriteLine($"the figure you have entered {FiveDigNum} is not ok, enter 5 digit number >> ");
    }
    return FiveDigNum;
}
void WorkOut()
{
    int UserAnswer = Prompt("Please enter any 5-digit number >>");
    CheckFiveDigit(UserAnswer);
    int digit  = 5;
    CheckPal(UserAnswer, digit);
}
WorkOut();
