// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int qRows, int qCols, int lowLim, int upperLim)
{
    int[,] table = new int[qRows, qCols];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(lowLim, upperLim);
        }
    }
    return table;
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

void PrintArrayOne(double[] array)
{
    Console.Write($"for column [{0}] {array[0]} ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", for column [{i}] {array[i]:f2} ");
    }
}


double[] AverageByColumn(int[,] array)
{
    List<double> average = new List<double>();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double aver = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            aver += array[i, j];
        }
        aver /= array.GetLength(0);
        average.Add(aver);
    }
    double[] averageArray = average.ToArray();
    return averageArray;
}

void Execute()
{
    int rows = Prompt("Enter quantity of raws ");
    int columns = Prompt("Enter quantity of columns ");
    int lowLim = Prompt("Enter lower limit for array element int value");
    int upperLim = Prompt("Enter upper limit for array element int value");
    Console.WriteLine("Array for further operations is: ");
    Console.WriteLine();
    int[,] array = CreateArray(rows, columns, lowLim, upperLim);
    PrintArray(array);
    double[] averageByColumn = AverageByColumn(array);
    Console.WriteLine($"Average for each column is ");
    PrintArrayOne(averageByColumn);

}
Execute();

// double average(int[,] array)
// {
//     int aver =0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             aver = (aver + array[i,j])/array.GetLength(0);
//         }
//         Console.WriteLine
//     }
// }