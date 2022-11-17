// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateArray(int rows, int columns, int lowerLim, int upperLim)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 9);
        }
    }
    return array;
}

int SumOfDiag(int[,] array)
{
    int sumDiag = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sumDiag += array[i, j];
            }
        }
    }
    Console.Write($"Sum equals {sumDiag}");
    return sumDiag;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Execute()
{
    int rows = Prompt("Enter quantity of raws ");
    int columns = Prompt("Enter quantity of columns ");
    int lowerLim = Prompt("Enter lower limit of array elements value ");
    int upperLim = Prompt("Enter upper limit of array elements value ");
    int[,] array = CreateArray(rows, columns, lowerLim, upperLim);
    PrintArray(array);
    Console.WriteLine();
    int sumDiag = SumOfDiag(array);
}
Execute();