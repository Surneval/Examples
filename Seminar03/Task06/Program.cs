// Напишите программу, которая генерирует последовательность случайных чисел до
// тех пор, пока не сгенерирует кратное число введенному в начале.
int Prompt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

void Starter()
{
    int userAnswer = Prompt("Type a figure from 1 to 10 > ");
    while (true)
    {
        int num = new Random().Next(1, 11);

        if(num % userAnswer == 0)
        {
            Console.WriteLine(num);
            break;
        }
        Console.WriteLine($" not ok num = {num}");
    }
}
Starter();

