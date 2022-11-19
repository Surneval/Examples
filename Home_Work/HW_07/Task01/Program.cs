// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

double[,] CreateArray(int rows, int columns, int lowerLim, int upperLim)
{
    double[,] table = new double[rows, columns];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(lowerLim, upperLim) + new Random().NextDouble();
        }
    }
    return table;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Execute()
{
    int rows = Prompt("Enter quantity of raws ");
    int columns = Prompt("Enter quantity of columns ");
    int lowLim = Prompt("Enter lower limit for array element int value");
    int upperLim = Prompt("Enter upper limit for array element int value");
    Console.WriteLine("Real numbers array");
    double[,] realNumArray = CreateArray(rows, columns, lowLim, upperLim);
    PrintArray(realNumArray);

}
Execute();