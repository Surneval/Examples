// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int CheckElement(int[,] array)
{
    int rowToFind = Prompt("Enter number of row for element check");
    int columnToFind = Prompt("Enter number of column cfor element check");
    if ((rowToFind >= array.GetLength(0)) || (columnToFind >= array.GetLength(1)))
    {
        Console.WriteLine($"Element ({rowToFind}, {columnToFind}) was not found in th array ");
    }
    int foundNumber = array[rowToFind, columnToFind];
    Console.WriteLine($"Element is {foundNumber} ");
    return foundNumber;
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
    int elementToFind = CheckElement(array);

}
Execute();