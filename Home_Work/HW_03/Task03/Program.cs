// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125
int Prompt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}
int Cube (int i, int n)
{
    int cube = 0;
    i = 1;
    if (n<=0)
    {
        while(n<=i)
        {
            cube = n * n * n;
            Console.Write($"{cube}, ");
            n++; 
        }   
     }
    else
    {
    while(i<=n)
    {
        cube = i * i * i;
        Console.Write($"{cube}, ");
        i++;
    }
    }
    return cube;
}
void Start()
{
    int i = 1;
    int n = Prompt("Please type any number N >>");
    int cube = Cube(i, n);
}
Start();