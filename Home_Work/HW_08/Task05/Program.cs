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


void CreatePascal(int numb)
{
    for (int i = 0; i < numb; i++)
    {
        for (int j = 0; j <= (numb - i); j++) // создаём отступы слева 
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" "); // создаём пробелы между элементами треугольника для симметрии
            Console.Write(Fact(i) / (Fact(j) * Fact(i - j))); //формула вычисления элементов - С из n по k
        }
        Console.WriteLine();
        Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
    }
}

void Runner()
{
    int numb = Prompt("Enter number of raws");
    CreatePascal(numb);

}
Runner();