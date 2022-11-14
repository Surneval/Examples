// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int Prompt (string msg)
{
    Console.WriteLine(msg);
    int length  = Convert.ToInt32(Console.ReadLine());
    return length;
}
int[] CreateArray (int size, int min, int max)
{
    int[] randomArray = new int [size];
    for (int i = 0; i<randomArray.Length; i++)
    {
        randomArray[i] = new Random() .Next(min, max);
    }
    return randomArray;
}
int SumEvenInd (int [] array)
{
    int sumEvenInd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
        {
            sumEvenInd += array[i];
        }
    }
    return sumEvenInd;
}
void PrintArray(int[] array)
{
    Console.Write($"{array[0]}, ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($" {array[i]},");
    }
}

void Execute ()
{
    int arrayLength = Prompt("Please enter the length of an array >> ");
    int minVal = Prompt("Please enter minimum value of an array >> ");
    int maxVal = Prompt("Please enter maximum value of an array >> ");
    int[] randomArray = CreateArray(arrayLength, minVal, maxVal);
    PrintArray(randomArray);
    int sumEvenInd = SumEvenInd(randomArray);
    Console.WriteLine();
    Console.WriteLine($"Sum of array members with even indexes equals {sumEvenInd} ");
}
Execute();