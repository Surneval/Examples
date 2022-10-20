// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка
//2       1
//3       4
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool ValidateCoord(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine("Точка на одной из координат прямых");
        return false;
    }
    return true;
}
int GetQuarter(int x, int Y)
{
    if (x > 0 && Y > 0)
    {
        return 1;
    }
    if (x<0 && Y>0)
    {
        return 2;
    }
    if (x < 0 && Y<0)
    {
        return 3;
    }
    return 4;
}
int x = Prompt("Type x value >> ");
int Y = Prompt("Type y value >> ");
if (ValidateCoord(x,Y))
{
    int quarter = GetQuarter(x, Y);
    Console.WriteLine($"Quarter is {quarter}");

}