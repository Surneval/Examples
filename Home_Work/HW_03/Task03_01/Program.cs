// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int numberDigit(double UserAnswer)
{
    int count = 0;
    while (UserAnswer >= 1)
    {
        UserAnswer = UserAnswer / 10;
        count++;
    }

    return count;
}
int[] GetArr(int count, int userAnswer)
{
    int[] numbers = new int[count];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = (userAnswer / Convert.ToInt32((Math.Pow(10, count-i-1))))%10;
    }
    //numbers[numbers.Length-1] = userAnswer % 10;
        return numbers;
}
void PrintArr(int[] numbers)
{
    for (int i = 0; i< numbers.Length; i++)
    {
        Console.Write($"{numbers[i]:f0} ");
    }
    Console.WriteLine();
}

void Pal (int[] numbers, int i)
{
    for (i = 0; i<=(numbers.Length/2); i++)
    {
        if(numbers[i] == numbers[(numbers.Length-i-1)])
        {
            i++;
        }
        else
        {
            
            Console.WriteLine("It is not a pallindrome");
            break;
        }
    if ((i>=(numbers.Length/2-1)& i<=numbers.Length/2)| i==numbers.Length)
    {Console.WriteLine("It's a pallindrome");}
        
    }
}

void Runner()
{
int UserAnswer = Prompt("Please type a number >> ");
int count = numberDigit(UserAnswer);
int[] numbers = GetArr(count, UserAnswer);
PrintArr(numbers);

int k=0;
Pal(numbers, k);

}
Runner ();

//Console.WriteLine(count);

// bool CheckFiveDigit(int FiveDigNum)
// {
//     return Convert.ToInt32(FiveDigNum / Math.Pow(10, 4)) > 0;
// }
// int CheckPal (int FiveDigNum, int digit)
// {
//     if (CheckFiveDigit(FiveDigNum))
//     {
//         Console.WriteLine($"the figure you have entered {FiveDigNum} is ok >> ");
//         int n1 = Convert.ToInt32 (FiveDigNum / Math.Pow(10, digit - 1));
//         int n2 = Convert.ToInt32((FiveDigNum / Math.Pow(10, digit - 2)) % 10);
//         int n4 = Convert.ToInt32((FiveDigNum / Math.Pow(10, digit - 4)) % 10);
//         int n5 = Convert.ToInt32(FiveDigNum % 10);

//         if ((n1 == n5) && (n2 == n4))
//         {
//             Console.WriteLine($"figure {FiveDigNum} is palindrome");
//         }
//         else
//         {
//             Console.WriteLine($"figure {FiveDigNum} is not a palindrome");
//         }
//     }
//     else
//     {
//         Console.WriteLine($"the figure you have entered {FiveDigNum} is not ok, enter 5 digit number >> ");
//     }
//     return FiveDigNum;
// }
// void WorkOut()
// {
//     int UserAnswer = Prompt("Please enter any 5-digit number >>");
//     CheckFiveDigit(UserAnswer);
//     int digit  = 5;
//     CheckPal(UserAnswer, digit);
// }
// WorkOut();
