// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateArray(int rows, int columns, int lowerLim, int upperLim)
{
    int[,] table = new int[rows, columns];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(lowerLim, upperLim);
        }
    }
    return table;
}

int[] SumByRow(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumByRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumByRow += array[i, j];
        }
        sum[i] = sumByRow;
    }
    return sum;
}

int RowWithMinSum(int[] sums)
{
    int minIndex = 0;
    for (int i = 1; i < sums.Length; i++)
    {
        if (sums[i] < sums[minIndex]) minIndex = i;
    }
    return minIndex;
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

void PrintArrayOne(int[] array)
{
    Console.Write($"{array[0]} ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void Runner()
{
    int rows = Prompt("Enter quantity of raws ");
    int columns = Prompt("Enter quantity of columns ");
    int lowLim = Prompt("Enter lower limit for array element value");
    int upperLim = Prompt("Enter upper limit for array element value");
    int[,] array = CreateArray(rows, columns, lowLim, upperLim);
    PrintArray(array);
    Console.WriteLine();
    int[] sumByRow = SumByRow(array);
    PrintArrayOne(sumByRow);
    int minSumRow = RowWithMinSum(sumByRow);
    Console.WriteLine();
    Console.WriteLine($"Row with minimum sum of elements is {minSumRow}");

}
Runner();