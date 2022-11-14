// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Prompt (string msg)
{
    Console.WriteLine(msg);
    int length  = Convert.ToInt32(Console.ReadLine());
    return length;
}

double[] CreateArray (int size, int minVal, int maxVal)
{
    double [] randomArray = new double [size];
    for (int i = 0; i<randomArray.Length; i++)
    {
        randomArray[i] = Math.Round((new Random() .Next(minVal, maxVal) + new Random() .NextDouble()), 2);
    }
    return randomArray;
}

void PrintArray(double[] array)
{
    Console.Write($"{array[0]}, ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

double MaxVal (double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {max = array[i];}
    }
    return max;
}

double MinVal (double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {min = array[i];}
    }
    return min;
}

double DiffMaxMin (double [] array)
{
    double max = MaxVal(array);
    double min = MinVal(array);
    double diffMaxMin = max - min;
    return diffMaxMin;
}

void Execute()
{
    int arrayLength = Prompt("Please enter the length of an array >> ");
    int minVal = Prompt("Please enter minimum value of an array >> ");
    int maxVal = Prompt("Please enter maximum value of an array >> ");
    double[] randomArray = CreateArray(arrayLength, minVal, maxVal);
    PrintArray(randomArray);
    Console.WriteLine();
    double min = MinVal(randomArray);
    double max = MaxVal(randomArray);
    double diffMaxMin = Math.Round(DiffMaxMin(randomArray), 2);
    Console.WriteLine($"The difference between Maximum {max} and Minimum value {min} of random array members equals {diffMaxMin} ");
}
Execute();