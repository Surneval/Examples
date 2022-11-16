//  Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Вариант, когда пользователь задает число вводов (М), а мы создаем массив рандомно,
// иммитируя ввод пользователя

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random() .Next(-9, 9);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void Runner()
{
    int arrayLength = Prompt("Enter number M - quantity of user numbers > ");
    int[] userNumbers = CreateArray(arrayLength);
    PrintArray(userNumbers);
    int count = CountPositive(userNumbers);
    Console.WriteLine($" Quantity of positive numbers equals {count}");
}
Runner ();