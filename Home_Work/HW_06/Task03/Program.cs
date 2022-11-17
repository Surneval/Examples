// Задача 5: * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов.
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2
int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int[,] CreateArray(int qRows, int qCols, int minLim, int maxLim)
{
    int[,] table = new int[qRows, qCols];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(minLim, maxLim);
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

List<int> MaxRow(int[,] array)
{
    List<int> rawsMax = new List<int>();
    int i = 0;
    do
    {
        int maxRaw = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > maxRaw)
            {
                maxRaw = array[i, j];
            }
        }
        rawsMax.Add(maxRaw);
        i++;
    }
    while (i < array.GetLength(0));

    Console.WriteLine("List with maximum value by raws: ");
    foreach (int item in rawsMax)
    {
        Console.WriteLine($"{item} ");
    }
    return rawsMax;
}

int SumOfMaxRaws(List<int> anyList)
{
    int[] maxraws = anyList.ToArray();
    int sum = 0;
    for (int i = 0; i < maxraws.Length; i++)
    {
        sum += maxraws[i];
    }
    Console.WriteLine($"Sum of Maximums of each raw equals {sum} ");
    return sum;
}

List<int> MinColumn(int[,] array)
{
    List<int> colMin = new List<int>();
    int j = 0;
    do
    {
        int minCol = array[0, j];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i, j] < minCol)
            {
                minCol = array[i, j];
            }
        }
        colMin.Add(minCol);
        j++;
    }
    while (j < array.GetLength(1));

    Console.WriteLine("List with minimum value by columns: ");
    foreach (int item in colMin)
    {

        Console.Write($"{item} ");
    }
    Console.WriteLine();
    return colMin;
}

int SumOfMinColumns(List<int> anyList)
{
    int[] mincolumn = anyList.ToArray();
    int sum = 0;
    for (int i = 0; i < mincolumn.Length; i++)
    {
        sum += mincolumn[i];
    }
    Console.WriteLine($"Sum of Minimuns of each column equals {sum} ");
    return sum;
}

int DiffBetweenSums(int sumMax, int sumMin)
{
    int maxMinusMin = sumMax - sumMin;
    Console.WriteLine($"Sum of Maximums by raws minus Sum of Minimums by columns equals {maxMinusMin} ");
    return maxMinusMin;
}

void Runner()
{
    int minLim = Prompt("Enter lower threshold for the value of matrix element ");
    int maxLim = Prompt("Enter upper threshold for the value of matrix element ");
    int rowsQ = Prompt("Enter number of rows in matrix ");
    int colsQ = Prompt("Enter number of columns in matrix ");
    int[,] matrix = CreateArray(rowsQ, colsQ, minLim, maxLim);
    PrintArray(matrix);
    List<int> maxRaws = MaxRow(matrix);
    List<int> minColumn = MinColumn(matrix);
    int sumMaxRaws = SumOfMaxRaws(maxRaws);
    int sumMinColumns = SumOfMinColumns(minColumn);
    int sumMaxMinusMin = DiffBetweenSums(sumMaxRaws, sumMinColumns);
}
Runner();
