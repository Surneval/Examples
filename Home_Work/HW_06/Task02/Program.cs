// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}

int XCoordInter(int k1, int b1, int k2, int b2)
{
    int x = (b2-b1) / (k1-k2);
    return x;
}

int YCoordInter(int k1, int b1, int x)
{
    int y = k1 * x + b1;
    return y;
}

void Solution()
{
    int k1 = Prompt("Enter coefficient k1 for y1 = k1 * x + b1");
    int b1 = Prompt("Enter coefficient b1 for y1 = k1 * x + b1");
    int k2 = Prompt("Enter coefficient k2 for y2 = k2 * x + b2");
    int b2 = Prompt("Enter coefficient b2 for y2 = k2 * x + b2");
    int xCoord = XCoordInter(k1, b1, k2, b2);
    int yCoord = YCoordInter(k1, b1, xCoord);
    Console.WriteLine($"Coordinates of point of intersection of lines (y1 = k1 * x + b1) and (y2 = k2 * x + b2) has coordinates(x:{xCoord}; y:{yCoord})");

}
Solution();
