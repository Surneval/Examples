// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int x1 = Prompt("Please type x1 for A" );
int y1 = Prompt("Please type y1 fpr A" );
int x2 = Prompt("Please type x2 for B" );
int y2 = Prompt("please type y2 for B ");
double Length(double x1, double y1, double x2, double y2)
{
    double x = x2-x1;
    double y = y2-y1;
    double ABlenths = Math.Sqrt(x * x + y * y);
    Console.WriteLine($"lenths is {ABlenths:f2}");
    return ABlenths;
}
double lenths = Length(x1, y1, x2, y2);