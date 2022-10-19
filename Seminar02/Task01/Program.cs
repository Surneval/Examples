// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и
//показывает наибольшую цифру числа. 287-8, 298-9

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;

}
bool ValidateNumber(int number)
{
    if(number <100 || number>=1000)
    {
        Console.WriteLine("Это не трехзначное");
        return false;
    }
    return true;
}

int number = Prompt("Введите трехзначное число");
if (ValidateNumber(number))
{
    int lastDigit = number % 10;
    Console.WriteLine($"Последняя цифра числа {number} равна {lastDigit}");
}