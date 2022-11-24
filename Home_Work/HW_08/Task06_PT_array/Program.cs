// Задача 5: Вывести первые N строк треугольника Паскаля.

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int Fact(int n)
{
    int fact = 1;
    for (int i = 0; i <= n; i++)
    {
        if (i == 0) fact = 1;
        else fact *= i;
    }
    return fact;
}

void PrintArray(int[,] array)
{
    string[,] stringAr = new string[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            stringAr[i, j] = array[i, j].ToString();
            Console.Write($"{stringAr[i, j]}\t");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        for(int j = i+1; j < array.GetLength(1); j++)
        {
            stringAr[i,j] = " ";
        }
    }
    Console.WriteLine();
}

int[,] CreatePascal(int numb)
{
    int[,] pascal = new int[numb, numb];
    for (int i = 0; i < numb; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            pascal[i, j] = Fact(i) / (Fact(j) * Fact(i - j));// C из i по j = i! / (j! * (i-j)!)

        }

    }
    return pascal;
}

void Runner()
{
    int numb = Prompt("Enter number of raws");
    int[,] pascal = CreatePascal(numb);
    PrintArray(pascal);

}
Runner();