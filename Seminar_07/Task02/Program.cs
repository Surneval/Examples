
// Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные,
// и замените эти элементы на их квадраты.
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
int[,] SecondArray(int[,] baseArray)
{
    int[,] secondArray = new int[baseArray.GetLength(0), baseArray.GetLength(1)];
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                secondArray[i, j] = (baseArray[i, j] * baseArray[i, j]);
            }
            else secondArray[i,j] = baseArray[i,j];
        }
    }
    return secondArray;
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

void Execure()
{
    int rows = Prompt("Enter quantity of raws ");
    int columns = Prompt("Enter quantity of columns ");
    int lowLim = Prompt("Enter lower limit for array element value");
    int upperLim = Prompt("Enter upper limit for array element value");
    int[,] baseArray = CreateArray(rows, columns, lowLim, upperLim);
    Console.WriteLine("First array");
    PrintArray(baseArray);
    Console.WriteLine();
    int[,] sqArray = SecondArray(baseArray);
    Console.WriteLine("Second array");
    Console.WriteLine();
    PrintArray(sqArray);
}
Execure();