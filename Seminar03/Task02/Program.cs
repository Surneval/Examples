// Задача 2: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных 
//координат точек в этой четверти (x и y)
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool ValidateQuart(int quarter)
{
    if (quarter > 0 && quarter < 5)
    {
    
        return true;
    }
    return true;
}
(int, int) FindCoords(int quarter)
{
    if (quarter == 1) return (1,1);
    if(quarter ==2) return (-1,1);
    if(quarter==3) return (-1,-1);
    return(1,-1);
}
int quarter = Prompt("Please type the number of quarter");
if (ValidateQuart(quarter))
{
    (int x, int y) = FindCoords(quarter);
    Console.WriteLine($"for quarter {quarter} you have coordinates ({x}, {y})");

}
else
{
    Console.WriteLine("Uncorrect quarter");
}