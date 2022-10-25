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
        numbers[i] = (userAnswer / Convert.ToInt32((Math.Pow(10, count - i - 1)))) % 10;
    }
    //numbers[numbers.Length-1] = userAnswer % 10;
    return numbers;
}
void PrintArr(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]:f0} ");
    }
    Console.WriteLine();
}

void Pal(int[] numbers, int i)
{
    for (i = 0; i <= (numbers.Length / 2); i++)
    {
        if (numbers[i] == numbers[(numbers.Length - i - 1)])
        {
            i++;
        }
        else
        {

            Console.WriteLine("It is not a pallindrome");
            break;
        }
        if ((i >= (numbers.Length / 2 - 1) & i <= numbers.Length / 2) | i == numbers.Length)
        { Console.WriteLine("It's a pallindrome"); }

    }
}

void Runner()
{
    int UserAnswer = Prompt("Please type a number >> ");
    int count = numberDigit(UserAnswer);
    int[] numbers = GetArr(count, UserAnswer);
    PrintArr(numbers);

    int k = 0;
    Pal(numbers, k);

}
Runner();

