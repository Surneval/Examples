// Задача *: Напишите программу, которая из массива случайных чисел.
// Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). 
// Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5

int[] CreateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(0, 10);
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]} ");
    }
}

int FindSecMax (int [] intArray)
{
    int max = intArray[0];
    int secMax = intArray[1];
    for (int i = 1; i < intArray.Length; i++)
    {
        if (intArray[i] >= max)
        {
            secMax = max;
            max = intArray[i];
        }
        else
        {
            if(intArray[i] < max && intArray[i]>secMax)
            {secMax = intArray[i];}
        }
    }
    return secMax;
}
void Run()
{
    Console.WriteLine("Random array is ");
    int length = 8;
    int[] randomArray = CreateArray(length);
    printArray(randomArray);
    int secMax = FindSecMax(randomArray);
    Console.WriteLine($" Second maximum number in the array is {secMax}");
}
Run();