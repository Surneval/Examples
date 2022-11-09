//  Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//  Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Prompt (string msg)
{
    Console.WriteLine(msg);
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
    
    return numbers;
}
// void PrintArr(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write($"{numbers[i]:f0} ");
//     }
//     Console.WriteLine();
// }
int Sum (int[] numbers)
{
    int sum = numbers[0];
    for(int i = 1; i < numbers.Length; i++)
    {
        sum = sum + numbers[i];
    }
    return sum;
}
void Run()
{
    int UserAnswer = Prompt("Please type a number >> ");
    int count = numberDigit(UserAnswer);
    int[] array = GetArr(count, UserAnswer);
    int sum = Sum(array);
    Console.WriteLine($"The sum of digits equals {sum}");
}
Run();