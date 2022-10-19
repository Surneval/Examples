// //3.1. Напишите программу, которая будет принимать на вход пять чисел
//  и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4


int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
// int a = Prompt("Type number A ");
// int b = Prompt("Type number B ");
// int c = Prompt("Type number C ");
// int d = Prompt("Type number D ");
// int e = Prompt("Type number E ");

int count = 1;
int sum = 0;
while (count <= 5)
{
    int a = Prompt($"type number {count} >> ");
    sum = sum + a;
    count++;
}
double average = sum / (count-1);
Console.WriteLine($" sum is {sum}, average is {average}");