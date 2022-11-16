//  Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// вариант 2 - Динамический список с проверкой корректиности значений, Преобразование в массив

int [] GetUserData()
{
    List<int> numbersList = new List<int>(); //объявляем лист для динамического добавления новых элементов
    while (true) //бесконечный цикл
    {
        Console.WriteLine("Please enter a number, if all the numbers are entered, type (exit) ");
        string symbol = Console.ReadLine();
        if ((symbol == "exit") | (symbol == "Exit")) break; // если написал "exit", то прекращаем работу цикла
        try
        {
            numbersList.Add(Convert.ToInt32(symbol)); // добавляем цифру в лист
        }
        catch (Exception excep) //если пользователь ввёл не цифру
        {
            Console.WriteLine(excep.Message); //мы его об этом уведомляем
            Console.WriteLine("You added a wrong format, please type (continue) or (end)"); //предлагаем ввести (continue) или (end)
            if ((Console.ReadLine() == "end") | (Console.ReadLine() == "End")) break; //если (end), то завершаем работу цикла
            else continue; // в ином случае продолжаем работу цикла
        }
    }
    int[] userArray = numbersList.ToArray(); // преобразуем лист в массив
    return userArray;
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
    int[] userArray = GetUserData();
    PrintArray(userArray);
    int countPos = CountPositive(userArray);
    Console.WriteLine($" Quantity of positive numbers equals {countPos}");
}
Runner();