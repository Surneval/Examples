// Задача 5*: Напишите программу, которая генерирует последовательность случайных чисел из 10
// элементов в диапазоне от 1 до 10, 
// и подсчитывает, сколько сгенерировалось чисел больше 5.

int[] GetArr(int len)
{
    int[] numbers = new int[len];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 11);
    }
    return numbers;
}
int GetCount(int[] numbers)
{
    int counter = 0;
    foreach (int item in numbers)
    {
        if (item > 5)
        {
            counter++;
        }
    }
    return counter;
}
void PrintArr(int[] numbers)
{
    for (int i = 0; i< numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} \t");
    }
    Console.WriteLine();
}

void Runner()
{
    int[] numbers = GetArr(10);
    PrintArr(numbers);
    Console.WriteLine($"Result: {GetCount(numbers)}");
}
Runner ();