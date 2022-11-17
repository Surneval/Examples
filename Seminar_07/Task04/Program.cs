// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение,
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.
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

void FindElement (int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == number)
            {
                Console.WriteLine($"the element {number} exists, position [{i}, {j}] ");
                return;
            }
            
        }
    }
    Console.WriteLine($"The number was not found in the array");
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
    int rows = Prompt("Enter quantity of rows ");
    int columns = Prompt("Enter quantity of columns ");
    int lowerLIm = Prompt("Enter a lower limit for array elements value ");
    int upperLim = Prompt("Enter an upper limit for array elements value ");
    int[,] array = CreateArray(rows, columns, lowerLIm, upperLim);
    PrintArray(array);
    Console.WriteLine();
    int checkNumber = Prompt("Enter some number to find in array ");
    FindElement(array, checkNumber);
}
Execute();