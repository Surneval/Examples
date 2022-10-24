// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
double Prompt(string msg)
{
    Console.Write(msg);
    return double.Parse(Console.ReadLine());
}
double Length(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double x = x2 - x1; double y = y2 - y1; double z = z2 - z1;
    double ABLen = Math.Sqrt(x * x + y * y + z * z);
    Console.Write($"length is {ABLen:f2}");
    return ABLen;
}
void Starter()
{
    double x1 = Prompt("Please enter x1>> ");
    double x2 = Prompt("Please enter x2>> ");
    double y1 = Prompt("Please enter y1>> ");
    double y2 = Prompt("Please enter y2>> ");
    double z1 = Prompt("Please enter z1>> ");
    double z2 = Prompt("Please enter z2>> ");
    double length = Length(x1, x2, y1, y2, z1, z2);
}
Starter();