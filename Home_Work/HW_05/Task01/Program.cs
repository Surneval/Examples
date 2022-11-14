/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
int Prompt(string msg)
{
    Console.WriteLine(msg);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}
int[] CreateArray(int size, int min, int max)
{
    int[] randomArray = new int[size];
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(min, max);
    }
    return randomArray;
}
int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write($"{array[0]}, ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($" {array[i]},");
    }
}

void Execute()
{
    int arrayLength = Prompt("Please enter the length of an array >> ");
    int minVal = Prompt("Please enter minimum value of an array >> ");
    int maxVal = Prompt("Please enter maximum value of an array >> ");
    int[] randomArray = CreateArray(arrayLength, minVal, maxVal);
    PrintArray(randomArray);
    int countEven = CountEven(randomArray);
    Console.WriteLine();
    Console.WriteLine($" Count of even number in the random array equals {countEven}");
}
Execute();

