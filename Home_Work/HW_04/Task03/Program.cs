// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). 
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”,
// “Введите минимальный порог случайных значений”,
// “Введите максимальный порог случайных значений”)
int UserInput (string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int length, int minVal, int maxVal)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(minVal, maxVal);
    }
    return tempArray;
}
int length = UserInput("Please input the size of an array ");
int minVal = UserInput("Please input min value ");
int maxVal = UserInput("Please input max value ");
int[] array = CreateArray(length, minVal, maxVal);

void PrintArray(int[] array)
{
    Console.Write($"{array[0]}, ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
Console.Write("Random array with your parameters: ");
PrintArray(array);
