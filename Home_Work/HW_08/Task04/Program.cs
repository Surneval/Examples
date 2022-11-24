//Задача 4: * Напишите программу, которая заполнит спирально квадратный массив

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    int k = 1;
    int iStart = 0;
    int jStart = 0;
    int i = 0;
    int j = 0;
    while (k <= rows * cols)
    {
        matrix[i, j] = k;
        if (i == iStart && j < cols - jStart - 1) j++;
        else if (j == cols - 1 - jStart && i < rows - iStart - 1) i++;
        else if (i == rows - 1 - iStart && j > jStart) j--;
        else --i;
        if ((i == iStart + 1) && j == jStart && jStart != cols - jStart - 1)
        {
            jStart++;
            iStart++;
        }
        k++;
    }
    return matrix;
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

void Runner()
{
    int[,] matrix = CreateMatrix(5, 5);
    PrintArray(matrix);
}
Runner();