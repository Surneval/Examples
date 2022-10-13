// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да
System.Console.WriteLine("Please type the number1 >"); // выводим подсказку на экран
string inputString1 = Console.ReadLine(); // Получаем введенную строку с консолью
int number1 = Convert.ToInt32(inputString1); // Преобразуем к целому типу
System.Console.WriteLine("Please type the number2 >"); // выводим подсказку на экран
string inputString2 = Console.ReadLine(); // Получаем введенную строку с консолью
int number2 = Convert.ToInt32(inputString2); // Преобразуем к целому типу

if(number1 * number1 == number2)
{
    Console.WriteLine("Yes, it's a square");
}
else
{
    Console.WriteLine("no");
}