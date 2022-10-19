// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6
int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = Prompt("Please type any number >> ");
int k = Math.Abs(number);
int n = Math.Abs(number);
int count = 0;

if (n == 0)
{
    count++;
}
else
{
    while (n > 0)
    {
        n = n / 10;
        count++;
    }
    Console.WriteLine($" you've typed a number with digit {count} ");
}

int third = 0;

if (count < 3)
{
    Console.WriteLine("the third digit is absent ");
}
else
{
    if (count == 3)
    {
        third = third + k % 10;
    }
    else
    {
        double i = Math.Pow(10, (count-3));
        int l = Convert.ToInt32(i);
        third = third + (k /l ) % 10;
    }

    Console.WriteLine($"the third digit of the number is {third}");
}