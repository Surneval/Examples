// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.

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

bool IsMultiplPossible(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0)) return true;
    else
    {
        Console.WriteLine("Number of columns in matrix1 must be equal to number of rows in matrix2! Try again");
        return false;
    }
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] multMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < multMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multMatrix.GetLength(1); j++)
        {
            multMatrix[i, j] = 0;
            for (int l = 0; l < matrix1.GetLength(1); l++)
            {
                multMatrix[i, j] += matrix1[i, l] * matrix2[l, j];
            }
        }
    }

    return multMatrix;
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
    int rows1 = Prompt("We are going to multiply two matrixes. Enter quantity of raws for matrix1");
    int columns1 = Prompt("Enter quantity of columns for matrix1.  Number of columns for matrix1 must be equal to number of rows of matrix2");
    int rows2 = Prompt("Enter quantity of raws for matrix2. Number of rows for matrix2 must be equal to number of columns of matrix1");
    int columns2 = Prompt("Enter quantity of columns for matrix2");
    int lowLim = Prompt("Enter lower limit for arrays element value");
    int upperLim = Prompt("Enter upper limit for arrays element value");
    int[,] matrix1 = CreateArray(rows1, columns1, lowLim, upperLim);
    int[,] matrix2 = CreateArray(rows2, columns2, lowLim, upperLim);
    PrintArray(matrix1);
    Console.WriteLine();
    PrintArray(matrix2);
    if (IsMultiplPossible(matrix1, matrix2))
    {
        int[,] multMatrix = MatrixMultiplication(matrix1, matrix2);
        Console.WriteLine();
        PrintArray(multMatrix);
    }

}
Runner();