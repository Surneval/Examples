// //3.1. Напишите программу, которая будет принимать на вход пять чисел
//  и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4
int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number1 = Prompt("Type number1 ");
int number2 = Prompt("Type number2 ");
int number3 = Prompt("Type number3 ");
int number4 = Prompt("Type number4 ");
int number5 = Prompt("Type number5 ");

int Sum(int a, int b, int c, int d, int e)
{
    int sum = a + b + c + d + e;
    return sum;
}

int total = Sum(number1, number2, number3, number4, number5);

double aver(int a, int b, int c, int d, int e)
{
    double aver = (a + b + c + d + e) / 5.0;
    return aver;
}
double average = aver(number1, number2, number3, number4, number5);
Console.WriteLine($"sum is {total}, average is {average}");